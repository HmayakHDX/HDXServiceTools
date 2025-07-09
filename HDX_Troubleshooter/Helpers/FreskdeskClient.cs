using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace HDX_ServiceTools.Helpers
{
    public static class FreshdeskClient
    {
        private static readonly HttpClient httpClient = new();

        /// <summary>
        /// Submits a ticket to Freshdesk with the option to attach the current session's log file.
        /// </summary>
        public static async Task<(bool Success, int? TicketId, string Message)> CreateTicketWithAttachmentAsync(
            string clinicName,
            string dentistName,
            string email,
            string phone,
            string description)
        {
            try
            {
                string freshdeskDomain = "hdxwillhelp.freshdesk.com";

                // TODO: secure API key (back-end service)
                // & create one for application (using API key tied to my profile currently)
                string apiKey = "0yvGDFAN0x9BoQhe10h";

                string subject = $"{clinicName} - {dentistName}";

                // Attempt to get the log file path for this session
                string logFilePath = Logger.LogPath;
                bool logExists = File.Exists(logFilePath);

                using var form = new MultipartFormDataContent
                {
                    // Required fields for the ticket
                    // TODO: Phone content is currently not included in tickets
                    { new StringContent(email), "email" },
                    { new StringContent(phone), "phone" },
                    { new StringContent(subject), "subject" },
                    { new StringContent(description), "description" },
                    { new StringContent("2"), "priority" }, // Normal priority
                    { new StringContent("2"), "status" },   // Open
                    { new StringContent("Software/Hardware Troubleshooting"), "type" }
                };

                // Attach the log file if it exists
                if (logExists)
                {
                    var logBytes = File.ReadAllBytes(logFilePath);
                    var fileContent = new ByteArrayContent(logBytes);
                    fileContent.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
                    form.Add(fileContent, "attachments[]", Path.GetFileName(logFilePath));
                }

                // Auth header: base64(apiKey:X)
                var byteArray = Encoding.ASCII.GetBytes($"{apiKey}:X");
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                // Submit the ticket
                var response = await httpClient.PostAsync($"https://{freshdeskDomain}/api/v2/tickets", form);
                string responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    using var doc = JsonDocument.Parse(responseBody);
                    int ticketId = doc.RootElement.GetProperty("id").GetInt32();

                    string successMsg = logExists
                        ? $"Ticket #{ticketId} submitted with log attached."
                        : $"Ticket #{ticketId} submitted (log file not found).";

                    return (true, ticketId, successMsg);
                }
                else
                {
                    return (false, null, $"Freshdesk rejected the ticket:\n{responseBody}");
                }
            }
            catch (Exception ex)
            {
                return (false, null, $"Error submitting ticket with attachment:\n{ex.Message}");
            }
        }
    }
}
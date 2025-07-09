namespace HDX_ServiceTools.Models
{
    // Represents the structure of each error entry in the JSON file
    public class ErrorInfo
    {
        public string Code { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public List<string> Solutions { get; set; } = [];
    }
}
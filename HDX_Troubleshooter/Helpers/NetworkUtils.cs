namespace HDX_ServiceTools.Helpers
{
    internal class NetworkUtils
    {
    }
}

// Network Logic

/*string serverPath = @"\\" + textBoxServerName.Text;

try
    {
        // Create a new Ping object
        Ping ping = new Ping();

        // Resolve the hostname to an IP address
        IPHostEntry entry = Dns.GetHostEntry(textBoxServerName.Text);

        // Send the ping with a 3-second timeout
        PingReply reply = ping.Send(textBoxServerName.Text, 3000);

        // Check if ping was successful
        if (reply.Status == IPStatus.Success)
            {
                foreach (IPAddress ip in entry.AddressList)
                    {
                        // Filter for IPv4 addresses only
                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        statusBox.Text += $"{ip}{Environment.NewLine}";
                    }
                try
                    {
                        string[] files = Directory.GetFiles(serverPath + @"\TestShare");
                        // If we get here, access is granted (no prompt will appear)
                        statusBox.Text += ("Access successful, no prompt expected." + Environment.NewLine);
                        foreach (string file in files)
                            statusBox.Text += $"{file}{Environment.NewLine}";
                        statusBox.SelectionStart = statusBox.Text.Length;
                        statusBox.ScrollToCaret();
                    }
                catch (UnauthorizedAccessException)
                    {
                        statusBox.Text += ("Access denied – credentials likely required." + Environment.NewLine);
                        // File Explorer will likely prompt
                        statusBox.SelectionStart = statusBox.Text.Length;
                        statusBox.ScrollToCaret();
                    }
                catch (Exception ex)
                    {
                        statusBox.Text += $"Error: {ex.Message}{Environment.NewLine}";
                        statusBox.SelectionStart = statusBox.Text.Length;
                        statusBox.ScrollToCaret();
                    }

                Process.Start("explorer.exe", serverPath);

            }
        else
            {
                statusBox.Text += $"Ping failed. Status: {reply.Status}{Environment.NewLine}";
                statusBox.SelectionStart = statusBox.Text.Length;
                statusBox.ScrollToCaret();
            }
    }
catch (PingException ex)
    {
        // Handle ping-specific exceptions
        statusBox.Text += $"Ping failed: {ex.Message}{Environment.NewLine}";
        statusBox.SelectionStart = statusBox.Text.Length;
        statusBox.ScrollToCaret();
    }
catch (Exception ex)
    {
        // Handle any other general exceptions
        statusBox.Text += $"General error: {ex.Message}{Environment.NewLine}";
        statusBox.SelectionStart = statusBox.Text.Length;
        statusBox.ScrollToCaret();
    }*/
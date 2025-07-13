namespace HDX_ServiceTools.Models
{
    // Rpresents the structure of each installation option entry in the installOptions JSON file
    public class InstallationInfo
    {
        public string Option { get; set; } = string.Empty;
        public List<string> Description { get; set; } = [];
    }
}

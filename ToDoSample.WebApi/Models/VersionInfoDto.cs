namespace ToDoSample.WebApi.Models
{
    /// <summary>
    /// The version info dto.
    /// </summary>
    public class VersionInfoDto
    {
        public string ProductVersion { get; set; }
        public string ApiVersion { get; set; }
        public string BuildNumber { get; set; }

        public string AssemblyConfiguration { get; set; }
        public string Environment { get; set; }
        public string BuildDateTime { get; set; }
        public string FullVersion { get; set; }
    }
}
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;

using ToDoSample.WebApi.Models;

namespace ToDoSample.WebApi
{
    /// <summary>
    /// The assembly version helper.
    /// </summary>
    public class AssemblyVersionHelper
    {
        public static VersionInfoDto GetVersion(Assembly assembly, string environment)
        {
            Assembly thisAssembly = assembly;
            string assemblyConfiguration = string.Empty;
            string sourceCodeVersion = "(not detected)";

            var configurationAttribute = thisAssembly.GetCustomAttributes(typeof(AssemblyConfigurationAttribute)).OfType<AssemblyConfigurationAttribute>().ToList();
            if (configurationAttribute.Any())
            {
                assemblyConfiguration = configurationAttribute.First().Configuration;
            }

            var informalVersionAttribute = thisAssembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute)).OfType<AssemblyInformationalVersionAttribute>().ToList();
            if (informalVersionAttribute.Any())
            {
                var informalVersion = informalVersionAttribute.First().InformationalVersion;

                // This can be slitted into version and commit
                var splitted = informalVersion.Split(new[] { '+' }, 2, StringSplitOptions.RemoveEmptyEntries);

                if (splitted.Length == 2)
                {
                    sourceCodeVersion = splitted[1].Substring(0, 7);
                }
            }

            var assemblyDate = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location);

            var versionDto = new VersionInfoDto
            {
                ProductVersion = thisAssembly.GetName().Version.ToString(), 
                ApiVersion = "1.0.4", 
                BuildNumber = thisAssembly.GetName().Version.Revision.ToString(CultureInfo.CurrentCulture), 
                BuildDateTime = string.Format("{0:yyyy-MM-dd HH:mm:ss}", assemblyDate), 
                FullVersion = string.Format("{0}-{1:yyyyMMddHHmmss}-{2}-{3}", thisAssembly.GetName().Version, assemblyDate, sourceCodeVersion, assemblyConfiguration), 
                AssemblyConfiguration = assemblyConfiguration, 
                Environment = environment
            };
            return versionDto;
        }
    }
}

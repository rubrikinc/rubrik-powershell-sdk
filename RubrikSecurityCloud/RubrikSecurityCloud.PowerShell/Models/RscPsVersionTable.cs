using System;
namespace RubrikSecurityCloud.PowerShell.Models
{
    public class RscPsVersionTable
    {
        // To ensure that only the C# code can set these values,
        // and to ensure that no code can override these values
        // from PowerShell, set as public properties with only getters.
        // Values can only be assigned within the constructor

        public string SdkSchemaVersion { get; }
        public string ServerVersion { get; }

        public RscPsVersionTable(string sdkSchemaVersion, string serverVersion)
        {
            this.SdkSchemaVersion = sdkSchemaVersion;
            this.ServerVersion = serverVersion;
        }
    }
}


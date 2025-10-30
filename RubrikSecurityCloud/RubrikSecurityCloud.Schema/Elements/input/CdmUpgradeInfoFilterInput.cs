// CdmUpgradeInfoFilterInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region CdmUpgradeInfoFilterInput

    public class CdmUpgradeInfoFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? Id
        // GraphQL -> id: [UUID!] (scalar)
        [JsonProperty("id")]
        public List<System.String>? Id { get; set; }

        //      C# -> List<System.String>? Name
        // GraphQL -> name: [String!] (scalar)
        [JsonProperty("name")]
        public List<System.String>? Name { get; set; }

        //      C# -> List<ClusterTypeEnum>? Type
        // GraphQL -> type: [ClusterTypeEnum!] (enum)
        [JsonProperty("type")]
        public List<ClusterTypeEnum>? Type { get; set; }

        //      C# -> DateTime? RegistrationtimeGt
        // GraphQL -> registrationTime_gt: DateTime (scalar)
        [JsonProperty("registrationTime_gt")]
        public DateTime? RegistrationtimeGt { get; set; }

        //      C# -> DateTime? RegistrationtimeLt
        // GraphQL -> registrationTime_lt: DateTime (scalar)
        [JsonProperty("registrationTime_lt")]
        public DateTime? RegistrationtimeLt { get; set; }

        //      C# -> System.String? MinSoftwareVersion
        // GraphQL -> minSoftwareVersion: String (scalar)
        [JsonProperty("minSoftwareVersion")]
        public System.String? MinSoftwareVersion { get; set; }

        //      C# -> List<System.String>? DownloadedVersion
        // GraphQL -> downloadedVersion: [String!] (scalar)
        [JsonProperty("downloadedVersion")]
        public List<System.String>? DownloadedVersion { get; set; }

        //      C# -> List<System.String>? InstalledVersion
        // GraphQL -> installedVersion: [String!] (scalar)
        [JsonProperty("installedVersion")]
        public List<System.String>? InstalledVersion { get; set; }

        //      C# -> List<ClusterEosStatus>? EosStatus
        // GraphQL -> eosStatus: [ClusterEosStatus!] (enum)
        [JsonProperty("eosStatus")]
        public List<ClusterEosStatus>? EosStatus { get; set; }

        //      C# -> List<ClusterJobStatusTypeEnum>? UpgradeJobStatus
        // GraphQL -> upgradeJobStatus: [ClusterJobStatusTypeEnum!] (enum)
        [JsonProperty("upgradeJobStatus")]
        public List<ClusterJobStatusTypeEnum>? UpgradeJobStatus { get; set; }

        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        [JsonProperty("clusterLocation")]
        public List<System.String>? ClusterLocation { get; set; }

        //      C# -> List<VersionStatus>? VersionStatus
        // GraphQL -> versionStatus: [VersionStatus!] (enum)
        [JsonProperty("versionStatus")]
        public List<VersionStatus>? VersionStatus { get; set; }

        //      C# -> List<PrechecksStatusTypeEnum>? PrechecksStatus
        // GraphQL -> prechecksStatus: [PrechecksStatusTypeEnum!] (enum)
        [JsonProperty("prechecksStatus")]
        public List<PrechecksStatusTypeEnum>? PrechecksStatus { get; set; }

        //      C# -> List<ClusterStatus>? ConnectionState
        // GraphQL -> connectionState: [ClusterStatus!] (enum)
        [JsonProperty("connectionState")]
        public List<ClusterStatus>? ConnectionState { get; set; }

        //      C# -> System.Boolean? UpgradeScheduled
        // GraphQL -> upgradeScheduled: Boolean (scalar)
        [JsonProperty("upgradeScheduled")]
        public System.Boolean? UpgradeScheduled { get; set; }

        //      C# -> List<ClusterProductEnum>? ProductType
        // GraphQL -> productType: [ClusterProductEnum!] (enum)
        [JsonProperty("productType")]
        public List<ClusterProductEnum>? ProductType { get; set; }

        //      C# -> List<System.String>? UpgradeStatusCategory
        // GraphQL -> upgradeStatusCategory: [String!] (scalar)
        [JsonProperty("upgradeStatusCategory")]
        public List<System.String>? UpgradeStatusCategory { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class CdmUpgradeInfoFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types
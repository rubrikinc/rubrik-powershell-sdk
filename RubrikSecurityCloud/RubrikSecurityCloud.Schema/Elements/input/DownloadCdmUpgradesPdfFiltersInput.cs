// DownloadCdmUpgradesPdfFiltersInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region DownloadCdmUpgradesPdfFiltersInput

    public class DownloadCdmUpgradesPdfFiltersInput
    {
        #region members
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [String!] (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }

        //      C# -> List<System.String>? ClusterNames
        // GraphQL -> clusterNames: [String!] (scalar)
        [JsonProperty("clusterNames")]
        public List<System.String>? ClusterNames { get; set; }

        //      C# -> List<System.String>? ClusterTypes
        // GraphQL -> clusterTypes: [String!] (scalar)
        [JsonProperty("clusterTypes")]
        public List<System.String>? ClusterTypes { get; set; }

        //      C# -> List<System.String>? DownloadedVersions
        // GraphQL -> downloadedVersions: [String!] (scalar)
        [JsonProperty("downloadedVersions")]
        public List<System.String>? DownloadedVersions { get; set; }

        //      C# -> List<System.String>? InstalledVersions
        // GraphQL -> installedVersions: [String!] (scalar)
        [JsonProperty("installedVersions")]
        public List<System.String>? InstalledVersions { get; set; }

        //      C# -> List<System.String>? ClusterLocations
        // GraphQL -> clusterLocations: [String!] (scalar)
        [JsonProperty("clusterLocations")]
        public List<System.String>? ClusterLocations { get; set; }

        //      C# -> List<System.String>? UpgradeJobStatus
        // GraphQL -> upgradeJobStatus: [String!] (scalar)
        [JsonProperty("upgradeJobStatus")]
        public List<System.String>? UpgradeJobStatus { get; set; }

        //      C# -> List<System.String>? PrechecksStatus
        // GraphQL -> prechecksStatus: [String!] (scalar)
        [JsonProperty("prechecksStatus")]
        public List<System.String>? PrechecksStatus { get; set; }

        //      C# -> List<System.String>? VersionStatus
        // GraphQL -> versionStatus: [String!] (scalar)
        [JsonProperty("versionStatus")]
        public List<System.String>? VersionStatus { get; set; }

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

    } // class DownloadCdmUpgradesPdfFiltersInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
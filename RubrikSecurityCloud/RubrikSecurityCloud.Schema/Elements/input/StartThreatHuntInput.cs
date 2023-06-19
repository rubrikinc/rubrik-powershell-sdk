// StartThreatHuntInput.cs
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
    #region StartThreatHuntInput

    public class StartThreatHuntInput: IInput
    {
        #region members

        //      C# -> System.String? Notes
        // GraphQL -> notes: String (scalar)
        [JsonProperty("notes")]
        public System.String? Notes { get; set; }

        //      C# -> MalwareScanFileCriteriaInput? FileScanCriteria
        // GraphQL -> fileScanCriteria: MalwareScanFileCriteriaInput (input)
        [JsonProperty("fileScanCriteria")]
        public MalwareScanFileCriteriaInput? FileScanCriteria { get; set; }

        //      C# -> List<IndicatorOfCompromiseInput>? IndicatorsOfCompromise
        // GraphQL -> indicatorsOfCompromise: [IndicatorOfCompromiseInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("indicatorsOfCompromise")]
        public List<IndicatorOfCompromiseInput>? IndicatorsOfCompromise { get; set; }

        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        [JsonProperty("maxMatchesPerSnapshot")]
        public System.Int32? MaxMatchesPerSnapshot { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? ObjectFids
        // GraphQL -> objectFids: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectFids")]
        public List<System.String>? ObjectFids { get; set; }

        //      C# -> RequestedMatchDetailsInput? RequestedMatchDetails
        // GraphQL -> requestedMatchDetails: RequestedMatchDetailsInput (input)
        [JsonProperty("requestedMatchDetails")]
        public RequestedMatchDetailsInput? RequestedMatchDetails { get; set; }

        //      C# -> System.Boolean? ShouldTrustFilesystemTimeInfo
        // GraphQL -> shouldTrustFilesystemTimeInfo: Boolean (scalar)
        [JsonProperty("shouldTrustFilesystemTimeInfo")]
        public System.Boolean? ShouldTrustFilesystemTimeInfo { get; set; }

        //      C# -> MalwareScanSnapshotLimitInput? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: MalwareScanSnapshotLimitInput (input)
        [JsonProperty("snapshotScanLimit")]
        public MalwareScanSnapshotLimitInput? SnapshotScanLimit { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }


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

    } // class StartThreatHuntInput
    #endregion

} // namespace RubrikSecurityCloud.Types
// ThreatHuntBaseConfigInputType.cs
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
    #region ThreatHuntBaseConfigInputType

    public class ThreatHuntBaseConfigInputType: IInput
    {
        #region members

        //      C# -> System.String? Notes
        // GraphQL -> notes: String (scalar)
        [JsonProperty("notes")]
        public System.String? Notes { get; set; }

        //      C# -> ThreatHuntType? ThreatHuntType
        // GraphQL -> threatHuntType: ThreatHuntType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("threatHuntType")]
        public ThreatHuntType? ThreatHuntType { get; set; }

        //      C# -> IocInputType? Ioc
        // GraphQL -> ioc: IocInputType! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("ioc")]
        public IocInputType? Ioc { get; set; }

        //      C# -> ScanLimitInputType? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: ScanLimitInputType (input)
        [JsonProperty("snapshotScanLimit")]
        public ScanLimitInputType? SnapshotScanLimit { get; set; }

        //      C# -> HuntScanFileCriteriaInputType? FileScanCriteria
        // GraphQL -> fileScanCriteria: HuntScanFileCriteriaInputType (input)
        [JsonProperty("fileScanCriteria")]
        public HuntScanFileCriteriaInputType? FileScanCriteria { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        [JsonProperty("maxMatchesPerSnapshot")]
        public System.Int32? MaxMatchesPerSnapshot { get; set; }


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

    } // class ThreatHuntBaseConfigInputType
    #endregion

} // namespace RubrikSecurityCloud.Types
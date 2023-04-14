// ReplicationToCloudRegionSpecInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ReplicationToCloudRegionSpecInput

    public class ReplicationToCloudRegionSpecInput: IInput
    {
        #region members

        //      C# -> System.String? ReplicationTargetRegion
        // GraphQL -> replicationTargetRegion: String (scalar)
        [JsonProperty("replicationTargetRegion")]
        public System.String? ReplicationTargetRegion { get; set; }

        //      C# -> CloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudProvider (enum)
        [JsonProperty("cloudProvider")]
        public CloudProvider? CloudProvider { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }

        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit (enum)
        [JsonProperty("retentionUnit")]
        public RetentionUnit? RetentionUnit { get; set; }


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

    } // class ReplicationToCloudRegionSpecInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
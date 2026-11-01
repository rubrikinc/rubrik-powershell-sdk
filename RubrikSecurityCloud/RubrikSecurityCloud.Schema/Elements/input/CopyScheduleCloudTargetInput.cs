// CopyScheduleCloudTargetInput.cs
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
    #region CopyScheduleCloudTargetInput

    public class CopyScheduleCloudTargetInput: IInput
    {
        #region members

        //      C# -> CopyScheduleCloudProvider? Provider
        // GraphQL -> provider: CopyScheduleCloudProvider! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("provider")]
        public CopyScheduleCloudProvider? Provider { get; set; }

        //      C# -> System.String? DataBucket
        // GraphQL -> dataBucket: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("dataBucket")]
        public System.String? DataBucket { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String (scalar)
        [JsonProperty("storageAccountName")]
        public System.String? StorageAccountName { get; set; }

        //      C# -> System.String? Host
        // GraphQL -> host: String (scalar)
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> CopyScheduleStorageTier? Tier
        // GraphQL -> tier: CopyScheduleStorageTier (enum)
        [JsonProperty("tier")]
        public CopyScheduleStorageTier? Tier { get; set; }

        //      C# -> System.String? AccessKeyId
        // GraphQL -> accessKeyId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("accessKeyId")]
        public System.String? AccessKeyId { get; set; }

        //      C# -> System.String? SecretKey
        // GraphQL -> secretKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("secretKey")]
        public System.String? SecretKey { get; set; }


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

    } // class CopyScheduleCloudTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types
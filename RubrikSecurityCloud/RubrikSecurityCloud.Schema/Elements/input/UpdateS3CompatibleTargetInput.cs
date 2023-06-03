// UpdateS3CompatibleTargetInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateS3CompatibleTargetInput

    public class UpdateS3CompatibleTargetInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? SecretKey
        // GraphQL -> secretKey: String (scalar)
        [JsonProperty("secretKey")]
        public System.String? SecretKey { get; set; }

        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: String (scalar)
        [JsonProperty("endpoint")]
        public System.String? Endpoint { get; set; }

        //      C# -> System.Int32? NumberOfBuckets
        // GraphQL -> numberOfBuckets: Int (scalar)
        [JsonProperty("numberOfBuckets")]
        public System.Int32? NumberOfBuckets { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean (scalar)
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

        //      C# -> System.Boolean? UseSystemProxy
        // GraphQL -> useSystemProxy: Boolean (scalar)
        [JsonProperty("useSystemProxy")]
        public System.Boolean? UseSystemProxy { get; set; }

        //      C# -> LocationImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: LocationImmutabilitySettings (input)
        [JsonProperty("immutabilitySettings")]
        public LocationImmutabilitySettings? ImmutabilitySettings { get; set; }


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

    } // class UpdateS3CompatibleTargetInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
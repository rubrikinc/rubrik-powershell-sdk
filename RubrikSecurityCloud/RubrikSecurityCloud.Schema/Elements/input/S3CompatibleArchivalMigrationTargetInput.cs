// S3CompatibleArchivalMigrationTargetInput.cs
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
    #region S3CompatibleArchivalMigrationTargetInput

    public class S3CompatibleArchivalMigrationTargetInput: IInput
    {
        #region members

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? SecretKey
        // GraphQL -> secretKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("secretKey")]
        public System.String? SecretKey { get; set; }

        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: URL! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("endpoint")]
        public System.String? Endpoint { get; set; }

        //      C# -> S3CompatibleSubType? Subtype
        // GraphQL -> subtype: S3CompatibleSubType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("subtype")]
        public S3CompatibleSubType? Subtype { get; set; }

        //      C# -> IbmCosDetailsInput? IbmDetails
        // GraphQL -> ibmDetails: IbmCosDetailsInput (input)
        [JsonProperty("ibmDetails")]
        public IbmCosDetailsInput? IbmDetails { get; set; }


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

    } // class S3CompatibleArchivalMigrationTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types
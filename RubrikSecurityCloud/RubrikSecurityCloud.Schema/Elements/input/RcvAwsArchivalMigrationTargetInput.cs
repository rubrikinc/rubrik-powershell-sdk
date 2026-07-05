// RcvAwsArchivalMigrationTargetInput.cs
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
    #region RcvAwsArchivalMigrationTargetInput

    public class RcvAwsArchivalMigrationTargetInput: IInput
    {
        #region members

        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> RcsTierEnumType? RcvTier
        // GraphQL -> rcvTier: RcsTierEnumType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("rcvTier")]
        public RcsTierEnumType? RcvTier { get; set; }

        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("redundancy")]
        public RcvRedundancy? Redundancy { get; set; }

        //      C# -> System.String? EncryptionKeyInDer
        // GraphQL -> encryptionKeyInDer: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("encryptionKeyInDer")]
        public System.String? EncryptionKeyInDer { get; set; }


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

    } // class RcvAwsArchivalMigrationTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types
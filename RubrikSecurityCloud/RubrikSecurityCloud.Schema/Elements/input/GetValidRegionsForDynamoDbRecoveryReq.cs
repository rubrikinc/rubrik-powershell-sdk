// GetValidRegionsForDynamoDbRecoveryReq.cs
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
    #region GetValidRegionsForDynamoDbRecoveryReq

    public class GetValidRegionsForDynamoDbRecoveryReq: IInput
    {
        #region members

        //      C# -> System.String? TargetAwsAccountId
        // GraphQL -> targetAwsAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetAwsAccountId")]
        public System.String? TargetAwsAccountId { get; set; }

        //      C# -> System.String? ArchivalLocationAwsAccountId
        // GraphQL -> archivalLocationAwsAccountId: UUID (scalar)
        [JsonProperty("archivalLocationAwsAccountId")]
        public System.String? ArchivalLocationAwsAccountId { get; set; }

        //      C# -> System.String? SourceAwsAccountId
        // GraphQL -> sourceAwsAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceAwsAccountId")]
        public System.String? SourceAwsAccountId { get; set; }


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

    } // class GetValidRegionsForDynamoDbRecoveryReq
    #endregion

} // namespace RubrikSecurityCloud.Types
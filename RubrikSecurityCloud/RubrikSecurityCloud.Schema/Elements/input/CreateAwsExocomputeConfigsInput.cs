// CreateAwsExocomputeConfigsInput.cs
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
    #region CreateAwsExocomputeConfigsInput

    public class CreateAwsExocomputeConfigsInput: IInput
    {
        #region members

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> List<AwsExocomputeConfigInput>? Configs
        // GraphQL -> configs: [AwsExocomputeConfigInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("configs")]
        public List<AwsExocomputeConfigInput>? Configs { get; set; }

        //      C# -> System.Boolean? TriggerHealthCheck
        // GraphQL -> triggerHealthCheck: Boolean (scalar)
        [JsonProperty("triggerHealthCheck")]
        public System.Boolean? TriggerHealthCheck { get; set; }


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

    } // class CreateAwsExocomputeConfigsInput
    #endregion

} // namespace RubrikSecurityCloud.Types
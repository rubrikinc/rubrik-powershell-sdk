// StartAwsNativeAccountDisableJobInput.cs
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
    #region StartAwsNativeAccountDisableJobInput

    public class StartAwsNativeAccountDisableJobInput: IInput
    {
        #region members

        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("awsAccountRubrikId")]
        public System.String? AwsAccountRubrikId { get; set; }

        //      C# -> System.Boolean? ShouldDeleteNativeSnapshots
        // GraphQL -> shouldDeleteNativeSnapshots: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldDeleteNativeSnapshots")]
        public System.Boolean? ShouldDeleteNativeSnapshots { get; set; }

        //      C# -> AwsNativeProtectionFeature? AwsNativeProtectionFeature
        // GraphQL -> awsNativeProtectionFeature: AwsNativeProtectionFeature! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("awsNativeProtectionFeature")]
        public AwsNativeProtectionFeature? AwsNativeProtectionFeature { get; set; }


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

    } // class StartAwsNativeAccountDisableJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
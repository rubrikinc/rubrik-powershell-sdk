// StartRefreshAwsNativeAccountsJobInput.cs
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
    #region StartRefreshAwsNativeAccountsJobInput

    public class StartRefreshAwsNativeAccountsJobInput: IInput
    {
        #region members

        //      C# -> List<System.String>? AwsAccountRubrikIds
        // GraphQL -> awsAccountRubrikIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("awsAccountRubrikIds")]
        public List<System.String>? AwsAccountRubrikIds { get; set; }

        //      C# -> List<AwsNativeProtectionFeature>? AwsNativeProtectionFeatures
        // GraphQL -> awsNativeProtectionFeatures: [AwsNativeProtectionFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("awsNativeProtectionFeatures")]
        public List<AwsNativeProtectionFeature>? AwsNativeProtectionFeatures { get; set; }


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

    } // class StartRefreshAwsNativeAccountsJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types
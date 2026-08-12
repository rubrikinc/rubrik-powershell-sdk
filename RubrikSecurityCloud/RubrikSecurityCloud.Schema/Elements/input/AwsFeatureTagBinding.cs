// AwsFeatureTagBinding.cs
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
    #region AwsFeatureTagBinding

    public class AwsFeatureTagBinding: IInput
    {
        #region members

        //      C# -> System.String? ScopeId
        // GraphQL -> scopeId: String (scalar)
        [JsonProperty("scopeId")]
        public System.String? ScopeId { get; set; }

        //      C# -> List<TagCondition>? Conditions
        // GraphQL -> conditions: [TagCondition!] (input)
        [JsonProperty("conditions")]
        public List<TagCondition>? Conditions { get; set; }


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

    } // class AwsFeatureTagBinding
    #endregion

} // namespace RubrikSecurityCloud.Types
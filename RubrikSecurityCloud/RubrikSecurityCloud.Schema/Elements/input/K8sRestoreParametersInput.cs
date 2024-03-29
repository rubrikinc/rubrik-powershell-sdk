// K8sRestoreParametersInput.cs
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
    #region K8sRestoreParametersInput

    public class K8sRestoreParametersInput: IInput
    {
        #region members

        //      C# -> System.String? Filter
        // GraphQL -> filter: String (scalar)
        [JsonProperty("filter")]
        public System.String? Filter { get; set; }

        //      C# -> List<System.String>? PvcNames
        // GraphQL -> pvcNames: [String!] (scalar)
        [JsonProperty("pvcNames")]
        public List<System.String>? PvcNames { get; set; }

        //      C# -> System.Boolean? IgnoreErrors
        // GraphQL -> ignoreErrors: Boolean (scalar)
        [JsonProperty("ignoreErrors")]
        public System.Boolean? IgnoreErrors { get; set; }


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

    } // class K8sRestoreParametersInput
    #endregion

} // namespace RubrikSecurityCloud.Types
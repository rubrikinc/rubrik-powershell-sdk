// K8sDiscoveryScopeInput.cs
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
    #region K8sDiscoveryScopeInput

    public class K8sDiscoveryScopeInput: IInput
    {
        #region members

        //      C# -> List<K8sLabelSelectorInput>? LabelSelectors
        // GraphQL -> labelSelectors: [K8sLabelSelectorInput!] (input)
        [JsonProperty("labelSelectors")]
        public List<K8sLabelSelectorInput>? LabelSelectors { get; set; }

        //      C# -> List<System.String>? Namespaces
        // GraphQL -> namespaces: [String!] (scalar)
        [JsonProperty("namespaces")]
        public List<System.String>? Namespaces { get; set; }


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

    } // class K8sDiscoveryScopeInput
    #endregion

} // namespace RubrikSecurityCloud.Types
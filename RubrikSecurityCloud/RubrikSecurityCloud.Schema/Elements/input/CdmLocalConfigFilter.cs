// CdmLocalConfigFilter.cs
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
    #region CdmLocalConfigFilter

    public class CdmLocalConfigFilter: IInput
    {
        #region members

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> List<CdmConfigParamState>? States
        // GraphQL -> states: [CdmConfigParamState!] (enum)
        [JsonProperty("states")]
        public List<CdmConfigParamState>? States { get; set; }

        //      C# -> List<System.String>? Nodes
        // GraphQL -> nodes: [String!] (scalar)
        [JsonProperty("nodes")]
        public List<System.String>? Nodes { get; set; }

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

    } // class CdmLocalConfigFilter
    #endregion

} // namespace RubrikSecurityCloud.Types
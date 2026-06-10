// NamespaceMappingEntry.cs
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
    #region NamespaceMappingEntry

    public class NamespaceMappingEntry: IInput
    {
        #region members

        //      C# -> System.String? SourceNamespace
        // GraphQL -> sourceNamespace: String (scalar)
        [JsonProperty("sourceNamespace")]
        public System.String? SourceNamespace { get; set; }

        //      C# -> System.String? TargetNamespace
        // GraphQL -> targetNamespace: String (scalar)
        [JsonProperty("targetNamespace")]
        public System.String? TargetNamespace { get; set; }


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

    } // class NamespaceMappingEntry
    #endregion

} // namespace RubrikSecurityCloud.Types
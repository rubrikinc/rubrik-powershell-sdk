// DomainMappingEntry.cs
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
    #region DomainMappingEntry

    public class DomainMappingEntry: IInput
    {
        #region members

        //      C# -> System.String? SourceDomainName
        // GraphQL -> sourceDomainName: String (scalar)
        [JsonProperty("sourceDomainName")]
        public System.String? SourceDomainName { get; set; }

        //      C# -> System.String? TargetDomainName
        // GraphQL -> targetDomainName: String (scalar)
        [JsonProperty("targetDomainName")]
        public System.String? TargetDomainName { get; set; }


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

    } // class DomainMappingEntry
    #endregion

} // namespace RubrikSecurityCloud.Types
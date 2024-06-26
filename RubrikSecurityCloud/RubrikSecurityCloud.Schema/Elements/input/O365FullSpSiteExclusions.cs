// O365FullSpSiteExclusions.cs
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
    #region O365FullSpSiteExclusions

    public class O365FullSpSiteExclusions: IInput
    {
        #region members

        //      C# -> System.String? SiteFid
        // GraphQL -> siteFid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("siteFid")]
        public System.String? SiteFid { get; set; }

        //      C# -> List<O365FullSpExclusion>? ExcludedObjects
        // GraphQL -> excludedObjects: [O365FullSpExclusion!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("excludedObjects")]
        public List<O365FullSpExclusion>? ExcludedObjects { get; set; }


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

    } // class O365FullSpSiteExclusions
    #endregion

} // namespace RubrikSecurityCloud.Types
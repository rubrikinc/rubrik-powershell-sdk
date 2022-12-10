// O365FullSpSiteExclusions.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:33.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region O365FullSpSiteExclusions

    public class O365FullSpSiteExclusions
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

} // namespace Rubrik.SecurityCloud.Types
// SetupAtlassianSiteInput.cs
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
    #region SetupAtlassianSiteInput

    public class SetupAtlassianSiteInput: IInput
    {
        #region members

        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("siteId")]
        public System.String? SiteId { get; set; }

        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("slaDomainId")]
        public System.String? SlaDomainId { get; set; }

        //      C# -> StorageRegion? StorageRegion
        // GraphQL -> storageRegion: StorageRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("storageRegion")]
        public StorageRegion? StorageRegion { get; set; }


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

    } // class SetupAtlassianSiteInput
    #endregion

} // namespace RubrikSecurityCloud.Types
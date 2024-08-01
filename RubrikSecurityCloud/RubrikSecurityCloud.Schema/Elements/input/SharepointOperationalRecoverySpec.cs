// SharepointOperationalRecoverySpec.cs
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
    #region SharepointOperationalRecoverySpec

    public class SharepointOperationalRecoverySpec: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldSkipItemPermission
        // GraphQL -> shouldSkipItemPermission: Boolean (scalar)
        [JsonProperty("shouldSkipItemPermission")]
        public System.Boolean? ShouldSkipItemPermission { get; set; }

        //      C# -> System.String? SiteOwnerEmail
        // GraphQL -> siteOwnerEmail: String (scalar)
        [JsonProperty("siteOwnerEmail")]
        public System.String? SiteOwnerEmail { get; set; }

        //      C# -> LastModifiedTimeFilter? LastModifiedTimeFilter
        // GraphQL -> lastModifiedTimeFilter: LastModifiedTimeFilter! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("lastModifiedTimeFilter")]
        public LastModifiedTimeFilter? LastModifiedTimeFilter { get; set; }

        //      C# -> System.String? TargetSiteCollectionUrl
        // GraphQL -> targetSiteCollectionUrl: URL (scalar)
        [JsonProperty("targetSiteCollectionUrl")]
        public System.String? TargetSiteCollectionUrl { get; set; }


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

    } // class SharepointOperationalRecoverySpec
    #endregion

} // namespace RubrikSecurityCloud.Types
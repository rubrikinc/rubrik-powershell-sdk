// BackupO365SharePointSiteInput.cs
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
    #region BackupO365SharePointSiteInput

    public class BackupO365SharePointSiteInput: IInput
    {
        #region members

        //      C# -> System.String? SiteFid
        // GraphQL -> siteFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("siteFid")]
        public System.String? SiteFid { get; set; }

        //      C# -> System.String? RetentionSlaId
        // GraphQL -> retentionSlaId: UUID (scalar)
        [JsonProperty("retentionSlaId")]
        public System.String? RetentionSlaId { get; set; }


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

    } // class BackupO365SharePointSiteInput
    #endregion

} // namespace RubrikSecurityCloud.Types
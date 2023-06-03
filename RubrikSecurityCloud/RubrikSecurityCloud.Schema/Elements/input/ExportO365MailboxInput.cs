// ExportO365MailboxInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ExportO365MailboxInput

    public class ExportO365MailboxInput: IInput
    {
        #region members

        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID (scalar)
        [JsonProperty("orgUuid")]
        public System.String? OrgUuid { get; set; }

        //      C# -> System.String? FromMailboxUuid
        // GraphQL -> fromMailboxUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fromMailboxUuid")]
        public System.String? FromMailboxUuid { get; set; }

        //      C# -> System.String? ToMailboxUuid
        // GraphQL -> toMailboxUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("toMailboxUuid")]
        public System.String? ToMailboxUuid { get; set; }

        //      C# -> System.String? SnapshotUuid
        // GraphQL -> snapshotUuid: UUID (scalar)
        [JsonProperty("snapshotUuid")]
        public System.String? SnapshotUuid { get; set; }

        //      C# -> List<RestoreObjectConfig>? ExportConfigs
        // GraphQL -> exportConfigs: [RestoreObjectConfig!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("exportConfigs")]
        public List<RestoreObjectConfig>? ExportConfigs { get; set; }


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

    } // class ExportO365MailboxInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
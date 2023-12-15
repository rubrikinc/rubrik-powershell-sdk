// RestoreO365MailboxInput.cs
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
    #region RestoreO365MailboxInput

    public class RestoreO365MailboxInput: IInput
    {
        #region members

        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID (scalar)
        [JsonProperty("orgUuid")]
        public System.String? OrgUuid { get; set; }

        //      C# -> System.String? MailboxUuid
        // GraphQL -> mailboxUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("mailboxUuid")]
        public System.String? MailboxUuid { get; set; }

        //      C# -> System.String? SnapshotUuid
        // GraphQL -> snapshotUuid: UUID (scalar)
        [JsonProperty("snapshotUuid")]
        public System.String? SnapshotUuid { get; set; }

        //      C# -> List<RestoreObjectConfig>? RestoreConfigs
        // GraphQL -> restoreConfigs: [RestoreObjectConfig!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreConfigs")]
        public List<RestoreObjectConfig>? RestoreConfigs { get; set; }

        //      C# -> O365RestoreActionType? ActionType
        // GraphQL -> actionType: O365RestoreActionType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("actionType")]
        public O365RestoreActionType? ActionType { get; set; }

        //      C# -> InplaceRestoreConfig? InplaceRestoreConfig
        // GraphQL -> inplaceRestoreConfig: InplaceRestoreConfig (input)
        [JsonProperty("inplaceRestoreConfig")]
        public InplaceRestoreConfig? InplaceRestoreConfig { get; set; }


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

    } // class RestoreO365MailboxInput
    #endregion

} // namespace RubrikSecurityCloud.Types
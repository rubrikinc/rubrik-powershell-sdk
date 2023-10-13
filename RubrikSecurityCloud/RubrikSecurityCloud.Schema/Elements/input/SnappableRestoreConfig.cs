// SnappableRestoreConfig.cs
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
    #region SnappableRestoreConfig

    public class SnappableRestoreConfig: IInput
    {
        #region members

        //      C# -> SharePointDriveRestoreConfig? SharePointDriveRestoreConfig
        // GraphQL -> SharePointDriveRestoreConfig: SharePointDriveRestoreConfig (input)
        [JsonProperty("SharePointDriveRestoreConfig")]
        public SharePointDriveRestoreConfig? SharePointDriveRestoreConfig { get; set; }

        //      C# -> SharePointListRestoreConfig? SharePointListRestoreConfig
        // GraphQL -> sharePointListRestoreConfig: SharePointListRestoreConfig (input)
        [JsonProperty("sharePointListRestoreConfig")]
        public SharePointListRestoreConfig? SharePointListRestoreConfig { get; set; }

        //      C# -> SharePointFullRestoreConfig? SharePointFullRestoreConfig
        // GraphQL -> sharePointFullRestoreConfig: SharePointFullRestoreConfig (input)
        [JsonProperty("sharePointFullRestoreConfig")]
        public SharePointFullRestoreConfig? SharePointFullRestoreConfig { get; set; }

        //      C# -> DriveRestoreConfig? OneDriveRestoreConfig
        // GraphQL -> OneDriveRestoreConfig: DriveRestoreConfig (input)
        [JsonProperty("OneDriveRestoreConfig")]
        public DriveRestoreConfig? OneDriveRestoreConfig { get; set; }

        //      C# -> TeamsRestoreConfig? TeamsRestoreConfig
        // GraphQL -> TeamsRestoreConfig: TeamsRestoreConfig (input)
        [JsonProperty("TeamsRestoreConfig")]
        public TeamsRestoreConfig? TeamsRestoreConfig { get; set; }

        //      C# -> MailboxRestoreConfig? MailboxRestoreConfig
        // GraphQL -> MailboxRestoreConfig: MailboxRestoreConfig (input)
        [JsonProperty("MailboxRestoreConfig")]
        public MailboxRestoreConfig? MailboxRestoreConfig { get; set; }

        //      C# -> CalendarRestoreConfig? CalendarRestoreConfig
        // GraphQL -> calendarRestoreConfig: CalendarRestoreConfig (input)
        [JsonProperty("calendarRestoreConfig")]
        public CalendarRestoreConfig? CalendarRestoreConfig { get; set; }

        //      C# -> ContactsRestoreConfig? ContactsRestoreConfig
        // GraphQL -> contactsRestoreConfig: ContactsRestoreConfig (input)
        [JsonProperty("contactsRestoreConfig")]
        public ContactsRestoreConfig? ContactsRestoreConfig { get; set; }

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

    } // class SnappableRestoreConfig
    #endregion

} // namespace RubrikSecurityCloud.Types
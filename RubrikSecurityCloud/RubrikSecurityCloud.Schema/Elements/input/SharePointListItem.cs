// SharePointListItem.cs
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
    #region SharePointListItem

    public class SharePointListItem: IInput
    {
        #region members

        //      C# -> System.String? ItemId
        // GraphQL -> itemId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("itemId")]
        public System.String? ItemId { get; set; }

        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("itemName")]
        public System.String? ItemName { get; set; }

        //      C# -> List<SharePointListItemSnapshot>? ItemSnapshotsToRestore
        // GraphQL -> itemSnapshotsToRestore: [SharePointListItemSnapshot!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("itemSnapshotsToRestore")]
        public List<SharePointListItemSnapshot>? ItemSnapshotsToRestore { get; set; }


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

    } // class SharePointListItem
    #endregion

} // namespace Rubrik.SecurityCloud.Types
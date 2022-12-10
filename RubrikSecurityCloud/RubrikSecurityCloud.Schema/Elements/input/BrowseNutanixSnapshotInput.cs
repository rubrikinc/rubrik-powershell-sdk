// BrowseNutanixSnapshotInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:50.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region BrowseNutanixSnapshotInput

    public class BrowseNutanixSnapshotInput
    {
        #region members
        //      C# -> System.Int32? Limit
        // GraphQL -> limit: Int (scalar)
        [JsonProperty("limit")]
        public System.Int32? Limit { get; set; }

        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int (scalar)
        [JsonProperty("offset")]
        public System.Int32? Offset { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("path")]
        public System.String? Path { get; set; }

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

    } // class BrowseNutanixSnapshotInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
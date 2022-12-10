// RestoreO365SnappableInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region RestoreO365SnappableInput

    public class RestoreO365SnappableInput
    {
        #region members
        //      C# -> SnappableType? SnappableType
        // GraphQL -> snappableType: SnappableType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("snappableType")]
        public SnappableType? SnappableType { get; set; }

        //      C# -> System.String? SourceSnappableUuid
        // GraphQL -> sourceSnappableUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceSnappableUuid")]
        public System.String? SourceSnappableUuid { get; set; }

        //      C# -> System.String? DestinationSnappableUuid
        // GraphQL -> destinationSnappableUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationSnappableUuid")]
        public System.String? DestinationSnappableUuid { get; set; }

        //      C# -> SnappableRestoreConfig? RestoreConfig
        // GraphQL -> restoreConfig: SnappableRestoreConfig! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreConfig")]
        public SnappableRestoreConfig? RestoreConfig { get; set; }

        //      C# -> O365RestoreActionType? ActionType
        // GraphQL -> actionType: O365RestoreActionType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("actionType")]
        public O365RestoreActionType? ActionType { get; set; }

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

    } // class RestoreO365SnappableInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
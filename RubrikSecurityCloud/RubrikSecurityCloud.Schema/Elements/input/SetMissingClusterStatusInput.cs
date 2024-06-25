// SetMissingClusterStatusInput.cs
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
    #region SetMissingClusterStatusInput

    public class SetMissingClusterStatusInput: IInput
    {
        #region members

        //      C# -> MissingClusterDisconnectedState? DisconnectedState
        // GraphQL -> disconnectedState: MissingClusterDisconnectedState (enum)
        [JsonProperty("disconnectedState")]
        public MissingClusterDisconnectedState? DisconnectedState { get; set; }

        //      C# -> System.String? ExclusionReason
        // GraphQL -> exclusionReason: String (scalar)
        [JsonProperty("exclusionReason")]
        public System.String? ExclusionReason { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }


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

    } // class SetMissingClusterStatusInput
    #endregion

} // namespace RubrikSecurityCloud.Types
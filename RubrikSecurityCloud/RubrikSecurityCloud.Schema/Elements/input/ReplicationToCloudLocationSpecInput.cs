// ReplicationToCloudLocationSpecInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ReplicationToCloudLocationSpecInput

    public class ReplicationToCloudLocationSpecInput: IInput
    {
        #region members

        //      C# -> System.String? ReplicationTargetId
        // GraphQL -> replicationTargetId: String (scalar)
        [JsonProperty("replicationTargetId")]
        public System.String? ReplicationTargetId { get; set; }

        //      C# -> CloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudProvider (enum)
        [JsonProperty("cloudProvider")]
        public CloudProvider? CloudProvider { get; set; }

        //      C# -> SlaDurationInput? RetentionDuration
        // GraphQL -> retentionDuration: SlaDurationInput (input)
        [JsonProperty("retentionDuration")]
        public SlaDurationInput? RetentionDuration { get; set; }


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

    } // class ReplicationToCloudLocationSpecInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
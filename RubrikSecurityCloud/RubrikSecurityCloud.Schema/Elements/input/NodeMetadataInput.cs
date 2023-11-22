// NodeMetadataInput.cs
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
    #region NodeMetadataInput

    public class NodeMetadataInput: IInput
    {
        #region members

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String (scalar)
        [JsonProperty("chassisId")]
        public System.String? ChassisId { get; set; }

        //      C# -> ClusterNodePlatformType? Platform
        // GraphQL -> platform: ClusterNodePlatformType (enum)
        [JsonProperty("platform")]
        public ClusterNodePlatformType? Platform { get; set; }

        //      C# -> ClusterNodeStatus? Status
        // GraphQL -> status: ClusterNodeStatus (enum)
        [JsonProperty("status")]
        public ClusterNodeStatus? Status { get; set; }

        //      C# -> System.Boolean? UseQuickDrain
        // GraphQL -> useQuickDrain: Boolean (scalar)
        [JsonProperty("useQuickDrain")]
        public System.Boolean? UseQuickDrain { get; set; }


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

    } // class NodeMetadataInput
    #endregion

} // namespace RubrikSecurityCloud.Types
// K8sNamespaceSnapshot.cs
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
    #region K8sNamespaceSnapshot

    public class K8sNamespaceSnapshot: IInput
    {
        #region members

        //      C# -> System.String? NamespaceId
        // GraphQL -> namespaceId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("namespaceId")]
        public System.String? NamespaceId { get; set; }

        //      C# -> System.String? OnDemandSnapshotSlaId
        // GraphQL -> onDemandSnapshotSlaId: String (scalar)
        [JsonProperty("onDemandSnapshotSlaId")]
        public System.String? OnDemandSnapshotSlaId { get; set; }


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

    } // class K8sNamespaceSnapshot
    #endregion

} // namespace RubrikSecurityCloud.Types
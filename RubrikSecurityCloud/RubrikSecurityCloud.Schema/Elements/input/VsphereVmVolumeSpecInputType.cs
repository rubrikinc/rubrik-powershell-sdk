// VsphereVmVolumeSpecInputType.cs
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
    #region VsphereVmVolumeSpecInputType

    public class VsphereVmVolumeSpecInputType: IInput
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? DataStoreId
        // GraphQL -> dataStoreId: String (scalar)
        [JsonProperty("dataStoreId")]
        public System.String? DataStoreId { get; set; }

        //      C# -> System.Single? SizeGbs
        // GraphQL -> sizeGbs: Float (scalar)
        [JsonProperty("sizeGbs")]
        public System.Single? SizeGbs { get; set; }

        //      C# -> System.String? DataStoreCdmId
        // GraphQL -> dataStoreCdmId: String (scalar)
        [JsonProperty("dataStoreCdmId")]
        public System.String? DataStoreCdmId { get; set; }

        //      C# -> System.String? DatastoreClusterId
        // GraphQL -> datastoreClusterId: String (scalar)
        [JsonProperty("datastoreClusterId")]
        public System.String? DatastoreClusterId { get; set; }

        //      C# -> System.String? Label
        // GraphQL -> label: String (scalar)
        [JsonProperty("label")]
        public System.String? Label { get; set; }


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

    } // class VsphereVmVolumeSpecInputType
    #endregion

} // namespace RubrikSecurityCloud.Types
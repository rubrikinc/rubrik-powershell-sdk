// BulkAddKmipServerInput.cs
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
    #region BulkAddKmipServerInput

    public class BulkAddKmipServerInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ClusterIds
        // GraphQL -> clusterIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterIds")]
        public List<System.String>? ClusterIds { get; set; }

        //      C# -> System.String? ServerAddress
        // GraphQL -> serverAddress: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("serverAddress")]
        public System.String? ServerAddress { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.Int32? PolarisCertId
        // GraphQL -> polarisCertId: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("polarisCertId")]
        public System.Int32? PolarisCertId { get; set; }

        //      C# -> System.String? PolarisCertFid
        // GraphQL -> polarisCertFid: UUID (scalar)
        [JsonProperty("polarisCertFid")]
        public System.String? PolarisCertFid { get; set; }


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

    } // class BulkAddKmipServerInput
    #endregion

} // namespace RubrikSecurityCloud.Types
// CloudDirectAddSubdirBackupInput.cs
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
    #region CloudDirectAddSubdirBackupInput

    public class CloudDirectAddSubdirBackupInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }

        //      C# -> System.String? ShareFid
        // GraphQL -> shareFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shareFid")]
        public System.String? ShareFid { get; set; }

        //      C# -> System.String? Subpath
        // GraphQL -> subpath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subpath")]
        public System.String? Subpath { get; set; }

        //      C# -> List<CloudDirectExclusion>? Exclusions
        // GraphQL -> exclusions: [CloudDirectExclusion!] (input)
        [JsonProperty("exclusions")]
        public List<CloudDirectExclusion>? Exclusions { get; set; }


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

    } // class CloudDirectAddSubdirBackupInput
    #endregion

} // namespace RubrikSecurityCloud.Types
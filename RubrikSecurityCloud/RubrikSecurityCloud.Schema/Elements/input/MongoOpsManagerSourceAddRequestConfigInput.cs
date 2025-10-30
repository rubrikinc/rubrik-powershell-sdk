// MongoOpsManagerSourceAddRequestConfigInput.cs
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
    #region MongoOpsManagerSourceAddRequestConfigInput

    public class MongoOpsManagerSourceAddRequestConfigInput: IInput
    {
        #region members

        //      C# -> List<System.String>? IgnoreNodes
        // GraphQL -> ignoreNodes: [String!] (scalar)
        [JsonProperty("ignoreNodes")]
        public List<System.String>? IgnoreNodes { get; set; }

        //      C# -> System.String? CaCertificateId
        // GraphQL -> caCertificateId: String (scalar)
        [JsonProperty("caCertificateId")]
        public System.String? CaCertificateId { get; set; }

        //      C# -> System.String? OpsManagerApiToken
        // GraphQL -> opsManagerApiToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("opsManagerApiToken")]
        public System.String? OpsManagerApiToken { get; set; }

        //      C# -> System.String? OpsManagerClusterId
        // GraphQL -> opsManagerClusterId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("opsManagerClusterId")]
        public System.String? OpsManagerClusterId { get; set; }

        //      C# -> System.String? OpsManagerGroupId
        // GraphQL -> opsManagerGroupId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("opsManagerGroupId")]
        public System.String? OpsManagerGroupId { get; set; }

        //      C# -> List<System.String>? OpsManagerNodes
        // GraphQL -> opsManagerNodes: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("opsManagerNodes")]
        public List<System.String>? OpsManagerNodes { get; set; }

        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceName")]
        public System.String? SourceName { get; set; }


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

    } // class MongoOpsManagerSourceAddRequestConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
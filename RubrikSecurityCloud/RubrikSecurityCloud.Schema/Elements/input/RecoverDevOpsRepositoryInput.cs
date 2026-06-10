// RecoverDevOpsRepositoryInput.cs
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
    #region RecoverDevOpsRepositoryInput

    public class RecoverDevOpsRepositoryInput: IInput
    {
        #region members

        //      C# -> System.String? RepositoryId
        // GraphQL -> repositoryId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("repositoryId")]
        public System.String? RepositoryId { get; set; }

        //      C# -> DevopsOrgType? RepoType
        // GraphQL -> repoType: DevopsOrgType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("repoType")]
        public DevopsOrgType? RepoType { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? RepositoryName
        // GraphQL -> repositoryName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("repositoryName")]
        public System.String? RepositoryName { get; set; }

        //      C# -> DevOpsTypeRepositoryRecoveryConfig? DevopsTypeRestoreConfig
        // GraphQL -> devopsTypeRestoreConfig: DevOpsTypeRepositoryRecoveryConfig (input)
        [JsonProperty("devopsTypeRestoreConfig")]
        public DevOpsTypeRepositoryRecoveryConfig? DevopsTypeRestoreConfig { get; set; }

        //      C# -> RecoveryAuthConfig? AuthConfig
        // GraphQL -> authConfig: RecoveryAuthConfig (input)
        [JsonProperty("authConfig")]
        public RecoveryAuthConfig? AuthConfig { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Boolean? IncludePipelines
        // GraphQL -> includePipelines: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("includePipelines")]
        public System.Boolean? IncludePipelines { get; set; }


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

    } // class RecoverDevOpsRepositoryInput
    #endregion

} // namespace RubrikSecurityCloud.Types
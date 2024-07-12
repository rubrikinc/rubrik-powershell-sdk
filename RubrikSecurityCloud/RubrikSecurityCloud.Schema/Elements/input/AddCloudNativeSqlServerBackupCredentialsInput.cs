// AddCloudNativeSqlServerBackupCredentialsInput.cs
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
    #region AddCloudNativeSqlServerBackupCredentialsInput

    public class AddCloudNativeSqlServerBackupCredentialsInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> WorkloadLevelHierarchy? WorkloadType
        // GraphQL -> workloadType: WorkloadLevelHierarchy! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadType")]
        public WorkloadLevelHierarchy? WorkloadType { get; set; }

        //      C# -> LoginCredentials? BackupCredentials
        // GraphQL -> backupCredentials: LoginCredentials! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("backupCredentials")]
        public LoginCredentials? BackupCredentials { get; set; }

        //      C# -> System.String? LogicAppName
        // GraphQL -> logicAppName: String (scalar)
        [JsonProperty("logicAppName")]
        public System.String? LogicAppName { get; set; }

        //      C# -> System.String? LogicAppApiKey
        // GraphQL -> logicAppApiKey: String (scalar)
        [JsonProperty("logicAppApiKey")]
        public System.String? LogicAppApiKey { get; set; }


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

    } // class AddCloudNativeSqlServerBackupCredentialsInput
    #endregion

} // namespace RubrikSecurityCloud.Types
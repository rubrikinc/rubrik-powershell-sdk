// RestoreAzureAdObjectsWithPasswordsInput.cs
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
    #region RestoreAzureAdObjectsWithPasswordsInput

    public class RestoreAzureAdObjectsWithPasswordsInput: IInput
    {
        #region members

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> List<PasswordByUserId>? PasswordByUserIdMap
        // GraphQL -> passwordByUserIdMap: [PasswordByUserId!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("passwordByUserIdMap")]
        public List<PasswordByUserId>? PasswordByUserIdMap { get; set; }

        //      C# -> List<ObjectInfoType>? ObjectTypeToIdMap
        // GraphQL -> objectTypeToIdMap: [ObjectInfoType!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("objectTypeToIdMap")]
        public List<ObjectInfoType>? ObjectTypeToIdMap { get; set; }

        //      C# -> System.Boolean? ForceChangePasswordWithMfa
        // GraphQL -> forceChangePasswordWithMfa: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("forceChangePasswordWithMfa")]
        public System.Boolean? ForceChangePasswordWithMfa { get; set; }

        //      C# -> AzureAdRelationshipRestoreModeEnumType? RelationshipRestoreMode
        // GraphQL -> relationshipRestoreMode: AzureAdRelationshipRestoreModeEnumType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("relationshipRestoreMode")]
        public AzureAdRelationshipRestoreModeEnumType? RelationshipRestoreMode { get; set; }

        //      C# -> ObjectRecoveryOptionsType? ObjectRecoveryOptions
        // GraphQL -> objectRecoveryOptions: ObjectRecoveryOptionsType (input)
        [JsonProperty("objectRecoveryOptions")]
        public ObjectRecoveryOptionsType? ObjectRecoveryOptions { get; set; }


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

    } // class RestoreAzureAdObjectsWithPasswordsInput
    #endregion

} // namespace RubrikSecurityCloud.Types
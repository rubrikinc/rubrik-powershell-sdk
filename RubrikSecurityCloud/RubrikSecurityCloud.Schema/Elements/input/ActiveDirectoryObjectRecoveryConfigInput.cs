// ActiveDirectoryObjectRecoveryConfigInput.cs
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
    #region ActiveDirectoryObjectRecoveryConfigInput

    public class ActiveDirectoryObjectRecoveryConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldMergeLinkedAttrs
        // GraphQL -> shouldMergeLinkedAttrs: Boolean (scalar)
        [JsonProperty("shouldMergeLinkedAttrs")]
        public System.Boolean? ShouldMergeLinkedAttrs { get; set; }

        //      C# -> List<ActiveDirectoryRecoveryObjectInput>? DomainControllerRecoveryObjects
        // GraphQL -> domainControllerRecoveryObjects: [ActiveDirectoryRecoveryObjectInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("domainControllerRecoveryObjects")]
        public List<ActiveDirectoryRecoveryObjectInput>? DomainControllerRecoveryObjects { get; set; }

        //      C# -> ActiveDirectoryUserRestoreOptionsInput? UserRestoreOptions
        // GraphQL -> userRestoreOptions: ActiveDirectoryUserRestoreOptionsInput (input)
        [JsonProperty("userRestoreOptions")]
        public ActiveDirectoryUserRestoreOptionsInput? UserRestoreOptions { get; set; }

        //      C# -> System.String? RestoreToDifferentContainer
        // GraphQL -> restoreToDifferentContainer: String (scalar)
        [JsonProperty("restoreToDifferentContainer")]
        public System.String? RestoreToDifferentContainer { get; set; }

        //      C# -> System.Boolean? ShouldContinueOnError
        // GraphQL -> shouldContinueOnError: Boolean (scalar)
        [JsonProperty("shouldContinueOnError")]
        public System.Boolean? ShouldContinueOnError { get; set; }

        //      C# -> System.Boolean? ClearUpAttrsIfNullInBackup
        // GraphQL -> clearUpAttrsIfNullInBackup: Boolean (scalar)
        [JsonProperty("clearUpAttrsIfNullInBackup")]
        public System.Boolean? ClearUpAttrsIfNullInBackup { get; set; }

        //      C# -> ActiveDirectoryRecoveryLdapCredsInput? CredsForRestore
        // GraphQL -> credsForRestore: ActiveDirectoryRecoveryLdapCredsInput (input)
        [JsonProperty("credsForRestore")]
        public ActiveDirectoryRecoveryLdapCredsInput? CredsForRestore { get; set; }

        //      C# -> System.String? AlternateDcId
        // GraphQL -> alternateDcId: String (scalar)
        [JsonProperty("alternateDcId")]
        public System.String? AlternateDcId { get; set; }

        //      C# -> ActiveDirectoryObjectMovedOption? ObjectMovedOptions
        // GraphQL -> objectMovedOptions: ActiveDirectoryObjectMovedOption (enum)
        [JsonProperty("objectMovedOptions")]
        public ActiveDirectoryObjectMovedOption? ObjectMovedOptions { get; set; }

        //      C# -> System.Boolean? ShouldCreateMissingParents
        // GraphQL -> shouldCreateMissingParents: Boolean (scalar)
        [JsonProperty("shouldCreateMissingParents")]
        public System.Boolean? ShouldCreateMissingParents { get; set; }

        //      C# -> ActiveDirectoryContainerRestoreOptionsInput? ContainerRestoreOptions
        // GraphQL -> containerRestoreOptions: ActiveDirectoryContainerRestoreOptionsInput (input)
        [JsonProperty("containerRestoreOptions")]
        public ActiveDirectoryContainerRestoreOptionsInput? ContainerRestoreOptions { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> ActiveDirectoryObjectNameConflictOption? NameConflict
        // GraphQL -> nameConflict: ActiveDirectoryObjectNameConflictOption (enum)
        [JsonProperty("nameConflict")]
        public ActiveDirectoryObjectNameConflictOption? NameConflict { get; set; }


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

    } // class ActiveDirectoryObjectRecoveryConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
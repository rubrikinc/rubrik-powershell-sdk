// AzureSqlPersistentBackupExportInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureSqlPersistentBackupExportInput

    public class AzureSqlPersistentBackupExportInput: IInput
    {
        #region members

        //      C# -> System.String? SourceSnapshotRubrikId
        // GraphQL -> sourceSnapshotRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceSnapshotRubrikId")]
        public System.String? SourceSnapshotRubrikId { get; set; }

        //      C# -> LoginCredentials? DestinationServerCredentials
        // GraphQL -> destinationServerCredentials: LoginCredentials (input)
        [JsonProperty("destinationServerCredentials")]
        public LoginCredentials? DestinationServerCredentials { get; set; }

        //      C# -> SqlAuthenticationMechanism? AuthMechanism
        // GraphQL -> authMechanism: SqlAuthenticationMechanism (enum)
        [JsonProperty("authMechanism")]
        public SqlAuthenticationMechanism? AuthMechanism { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> AzureSqlBackupStorageRedundancyType? DbBackupRedundancy
        // GraphQL -> dbBackupRedundancy: AzureSqlBackupStorageRedundancyType (enum)
        [JsonProperty("dbBackupRedundancy")]
        public AzureSqlBackupStorageRedundancyType? DbBackupRedundancy { get; set; }


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

    } // class AzureSqlPersistentBackupExportInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
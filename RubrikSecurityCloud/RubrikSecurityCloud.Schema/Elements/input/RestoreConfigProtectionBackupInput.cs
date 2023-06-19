// RestoreConfigProtectionBackupInput.cs
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
    #region RestoreConfigProtectionBackupInput

    public class RestoreConfigProtectionBackupInput: IInput
    {
        #region members

        //      C# -> System.String? BackupClusterUuid
        // GraphQL -> backupClusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("backupClusterUuid")]
        public System.String? BackupClusterUuid { get; set; }

        //      C# -> RestoreConfigBackupInput? RestoreBackupRequestDetails
        // GraphQL -> restoreBackupRequestDetails: RestoreConfigBackupInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreBackupRequestDetails")]
        public RestoreConfigBackupInput? RestoreBackupRequestDetails { get; set; }

        //      C# -> System.String? CaSignedCsr
        // GraphQL -> caSignedCsr: String (scalar)
        [JsonProperty("caSignedCsr")]
        public System.String? CaSignedCsr { get; set; }

        //      C# -> System.Boolean? UseDefaultConfigurations
        // GraphQL -> useDefaultConfigurations: Boolean (scalar)
        [JsonProperty("useDefaultConfigurations")]
        public System.Boolean? UseDefaultConfigurations { get; set; }


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

    } // class RestoreConfigProtectionBackupInput
    #endregion

} // namespace RubrikSecurityCloud.Types
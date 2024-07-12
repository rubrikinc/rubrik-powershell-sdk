// MssqlBackupSelectionInput.cs
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
    #region MssqlBackupSelectionInput

    public class MssqlBackupSelectionInput: IInput
    {
        #region members

        //      C# -> MssqlBackupType? BackupType
        // GraphQL -> backupType: MssqlBackupType (enum)
        [JsonProperty("backupType")]
        public MssqlBackupType? BackupType { get; set; }

        //      C# -> MssqlRecoveryPointInput? EndPoint
        // GraphQL -> endPoint: MssqlRecoveryPointInput (input)
        [JsonProperty("endPoint")]
        public MssqlRecoveryPointInput? EndPoint { get; set; }

        //      C# -> LegalHoldDownloadConfigInput? LegalHoldDownloadConfig
        // GraphQL -> legalHoldDownloadConfig: LegalHoldDownloadConfigInput (input)
        [JsonProperty("legalHoldDownloadConfig")]
        public LegalHoldDownloadConfigInput? LegalHoldDownloadConfig { get; set; }

        //      C# -> MssqlRecoveryPointInput? RecoveryPoint
        // GraphQL -> recoveryPoint: MssqlRecoveryPointInput (input)
        [JsonProperty("recoveryPoint")]
        public MssqlRecoveryPointInput? RecoveryPoint { get; set; }

        //      C# -> MssqlRecoveryPointInput? StartPoint
        // GraphQL -> startPoint: MssqlRecoveryPointInput (input)
        [JsonProperty("startPoint")]
        public MssqlRecoveryPointInput? StartPoint { get; set; }


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

    } // class MssqlBackupSelectionInput
    #endregion

} // namespace RubrikSecurityCloud.Types
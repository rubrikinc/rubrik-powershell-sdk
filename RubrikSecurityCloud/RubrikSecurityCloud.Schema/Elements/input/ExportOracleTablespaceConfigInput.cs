// ExportOracleTablespaceConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ExportOracleTablespaceConfigInput

    public class ExportOracleTablespaceConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ExposeAllLogs
        // GraphQL -> exposeAllLogs: Boolean (scalar)
        [JsonProperty("exposeAllLogs")]
        public System.Boolean? ExposeAllLogs { get; set; }

        //      C# -> System.String? AuxiliaryDestinationPath
        // GraphQL -> auxiliaryDestinationPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("auxiliaryDestinationPath")]
        public System.String? AuxiliaryDestinationPath { get; set; }

        //      C# -> OracleRecoveryPointInput? RecoveryPoint
        // GraphQL -> recoveryPoint: OracleRecoveryPointInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryPoint")]
        public OracleRecoveryPointInput? RecoveryPoint { get; set; }

        //      C# -> System.String? TablespaceName
        // GraphQL -> tablespaceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tablespaceName")]
        public System.String? TablespaceName { get; set; }


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

    } // class ExportOracleTablespaceConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
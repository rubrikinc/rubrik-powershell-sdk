// MysqldbAutomatedRestoreConfigInput.cs
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
    #region MysqldbAutomatedRestoreConfigInput

    public class MysqldbAutomatedRestoreConfigInput: IInput
    {
        #region members

        //      C# -> MysqldbAutomatedRestoreInstanceDetailsInput? MysqldbAutomatedRestoreInstanceDetails
        // GraphQL -> mysqldbAutomatedRestoreInstanceDetails: MysqldbAutomatedRestoreInstanceDetailsInput (input)
        [JsonProperty("mysqldbAutomatedRestoreInstanceDetails")]
        public MysqldbAutomatedRestoreInstanceDetailsInput? MysqldbAutomatedRestoreInstanceDetails { get; set; }

        //      C# -> System.String? TargetMysqldbInstanceId
        // GraphQL -> targetMysqldbInstanceId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetMysqldbInstanceId")]
        public System.String? TargetMysqldbInstanceId { get; set; }

        //      C# -> RestoreInputInput? RestoreInfo
        // GraphQL -> restoreInfo: RestoreInputInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreInfo")]
        public RestoreInputInput? RestoreInfo { get; set; }

        //      C# -> MysqldbAutomatedRestoreConnectionInfoInput? MysqldbAutomatedRestoreConnectionInfo
        // GraphQL -> mysqldbAutomatedRestoreConnectionInfo: MysqldbAutomatedRestoreConnectionInfoInput (input)
        [JsonProperty("mysqldbAutomatedRestoreConnectionInfo")]
        public MysqldbAutomatedRestoreConnectionInfoInput? MysqldbAutomatedRestoreConnectionInfo { get; set; }

        //      C# -> MysqldbAutomatedRestoreDatabaseDetailsInput? MysqldbAutomatedRestoreDatabaseDetails
        // GraphQL -> mysqldbAutomatedRestoreDatabaseDetails: MysqldbAutomatedRestoreDatabaseDetailsInput (input)
        [JsonProperty("mysqldbAutomatedRestoreDatabaseDetails")]
        public MysqldbAutomatedRestoreDatabaseDetailsInput? MysqldbAutomatedRestoreDatabaseDetails { get; set; }


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

    } // class MysqldbAutomatedRestoreConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
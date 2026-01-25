// AwsNativeDynamoDbSlaConfigInput.cs
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
    #region AwsNativeDynamoDbSlaConfigInput

    public class AwsNativeDynamoDbSlaConfigInput: IInput
    {
        #region members

        //      C# -> System.String? CmkAliasForPrimaryBackup
        // GraphQL -> cmkAliasForPrimaryBackup: String (scalar)
        [JsonProperty("cmkAliasForPrimaryBackup")]
        public System.String? CmkAliasForPrimaryBackup { get; set; }

        //      C# -> System.Boolean? ContinuousBackupsEnabled
        // GraphQL -> continuousBackupsEnabled: Boolean (scalar)
        [JsonProperty("continuousBackupsEnabled")]
        public System.Boolean? ContinuousBackupsEnabled { get; set; }

        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int (scalar)
        [JsonProperty("continuousBackupRetentionInDays")]
        public System.Int32? ContinuousBackupRetentionInDays { get; set; }


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

    } // class AwsNativeDynamoDbSlaConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
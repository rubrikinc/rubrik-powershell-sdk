// MssqlDbDefaultsUpdateInput.cs
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
    #region MssqlDbDefaultsUpdateInput

    public class MssqlDbDefaultsUpdateInput: IInput
    {
        #region members

        //      C# -> System.Boolean? CbtStatus
        // GraphQL -> cbtStatus: Boolean (scalar)
        [JsonProperty("cbtStatus")]
        public System.Boolean? CbtStatus { get; set; }

        //      C# -> System.Int64? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Long (scalar)
        [JsonProperty("logBackupFrequencyInSeconds")]
        public System.Int64? LogBackupFrequencyInSeconds { get; set; }

        //      C# -> System.Int32? LogRetentionTimeInHours
        // GraphQL -> logRetentionTimeInHours: Int (scalar)
        [JsonProperty("logRetentionTimeInHours")]
        public System.Int32? LogRetentionTimeInHours { get; set; }

        //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
        // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
        [JsonProperty("shouldUseDefaultBackupLocation")]
        public System.Boolean? ShouldUseDefaultBackupLocation { get; set; }


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

    } // class MssqlDbDefaultsUpdateInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
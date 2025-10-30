// RecoverToPointInTimeSapHanaDbConfigInput.cs
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
    #region RecoverToPointInTimeSapHanaDbConfigInput

    public class RecoverToPointInTimeSapHanaDbConfigInput: IInput
    {
        #region members

        //      C# -> SapHanaRestoreSourceConfigInput? SourceDbConfig
        // GraphQL -> sourceDbConfig: SapHanaRestoreSourceConfigInput (input)
        [JsonProperty("sourceDbConfig")]
        public SapHanaRestoreSourceConfigInput? SourceDbConfig { get; set; }

        //      C# -> System.Boolean? ShouldInitializeLogArea
        // GraphQL -> shouldInitializeLogArea: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldInitializeLogArea")]
        public System.Boolean? ShouldInitializeLogArea { get; set; }

        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        [JsonProperty("recoveryPoint")]
        public DateTime? RecoveryPoint { get; set; }

        //      C# -> System.String? DbId
        // GraphQL -> dbId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("dbId")]
        public System.String? DbId { get; set; }


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

    } // class RecoverToPointInTimeSapHanaDbConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
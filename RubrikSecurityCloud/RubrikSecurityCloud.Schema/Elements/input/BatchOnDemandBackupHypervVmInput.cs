// BatchOnDemandBackupHypervVmInput.cs
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
    #region BatchOnDemandBackupHypervVmInput

    public class BatchOnDemandBackupHypervVmInput: IInput
    {
        #region members

        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        [JsonProperty("userNote")]
        public System.String? UserNote { get; set; }

        //      C# -> HypervBatchOnDemandBackupJobConfigInput? Config
        // GraphQL -> config: HypervBatchOnDemandBackupJobConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public HypervBatchOnDemandBackupJobConfigInput? Config { get; set; }


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

    } // class BatchOnDemandBackupHypervVmInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
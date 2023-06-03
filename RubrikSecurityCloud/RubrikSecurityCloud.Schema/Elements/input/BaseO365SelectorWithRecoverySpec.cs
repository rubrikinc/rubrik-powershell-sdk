// BaseO365SelectorWithRecoverySpec.cs
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
    #region BaseO365SelectorWithRecoverySpec

    public class BaseO365SelectorWithRecoverySpec: IInput
    {
        #region members

        //      C# -> WorkloadType? SnappableType
        // GraphQL -> snappableType: WorkloadType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("snappableType")]
        public WorkloadType? SnappableType { get; set; }

        //      C# -> SubWorkloadType? SubSnappableType
        // GraphQL -> subSnappableType: SubWorkloadType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("subSnappableType")]
        public SubWorkloadType? SubSnappableType { get; set; }

        //      C# -> SelectorRecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: SelectorRecoverySpec! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("recoverySpec")]
        public SelectorRecoverySpec? RecoverySpec { get; set; }


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

    } // class BaseO365SelectorWithRecoverySpec
    #endregion

} // namespace Rubrik.SecurityCloud.Types
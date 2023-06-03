// ValidateBlueprintInput.cs
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
    #region ValidateBlueprintInput

    public class ValidateBlueprintInput: IInput
    {
        #region members

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> BlueprintFailoverPropertiesInput? BlueprintFailoverProperties
        // GraphQL -> blueprintFailoverProperties: BlueprintFailoverPropertiesInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("blueprintFailoverProperties")]
        public BlueprintFailoverPropertiesInput? BlueprintFailoverProperties { get; set; }

        //      C# -> List<ChildSnappableFailoverInfoInput>? ChildSnappableFailoverInfos
        // GraphQL -> childSnappableFailoverInfos: [ChildSnappableFailoverInfoInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("childSnappableFailoverInfos")]
        public List<ChildSnappableFailoverInfoInput>? ChildSnappableFailoverInfos { get; set; }

        //      C# -> System.Boolean? EnableRecoveryWithRba
        // GraphQL -> enableRecoveryWithRba: Boolean (scalar)
        [JsonProperty("enableRecoveryWithRba")]
        public System.Boolean? EnableRecoveryWithRba { get; set; }

        //      C# -> System.Boolean? SkipSnappableRecoveryStatusValidation
        // GraphQL -> skipSnappableRecoveryStatusValidation: Boolean (scalar)
        [JsonProperty("skipSnappableRecoveryStatusValidation")]
        public System.Boolean? SkipSnappableRecoveryStatusValidation { get; set; }


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

    } // class ValidateBlueprintInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
// StartInPlaceDataMaskingInput.cs
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
    #region StartInPlaceDataMaskingInput

    public class StartInPlaceDataMaskingInput: IInput
    {
        #region members

        //      C# -> System.String? DestinationOrgId
        // GraphQL -> destinationOrgId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationOrgId")]
        public System.String? DestinationOrgId { get; set; }

        //      C# -> System.Int64? MaskingTemplateId
        // GraphQL -> maskingTemplateId: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("maskingTemplateId")]
        public System.Int64? MaskingTemplateId { get; set; }

        //      C# -> System.Boolean? DisableAutomations
        // GraphQL -> disableAutomations: Boolean (scalar)
        [JsonProperty("disableAutomations")]
        public System.Boolean? DisableAutomations { get; set; }


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

    } // class StartInPlaceDataMaskingInput
    #endregion

} // namespace RubrikSecurityCloud.Types
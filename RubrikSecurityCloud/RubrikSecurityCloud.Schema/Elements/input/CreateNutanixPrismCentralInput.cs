// CreateNutanixPrismCentralInput.cs
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
    #region CreateNutanixPrismCentralInput

    public class CreateNutanixPrismCentralInput: IInput
    {
        #region members

        //      C# -> NutanixPrismCentralConfigInput? PrismCentralConfig
        // GraphQL -> prismCentralConfig: NutanixPrismCentralConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("prismCentralConfig")]
        public NutanixPrismCentralConfigInput? PrismCentralConfig { get; set; }

        //      C# -> List<PrismElementCdmTuple>? PrismElementCdmTuple
        // GraphQL -> prismElementCdmTuple: [PrismElementCdmTuple!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("prismElementCdmTuple")]
        public List<PrismElementCdmTuple>? PrismElementCdmTuple { get; set; }


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

    } // class CreateNutanixPrismCentralInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
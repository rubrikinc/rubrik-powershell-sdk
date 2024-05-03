// BulkAddNasSharesRequestInput.cs
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
    #region BulkAddNasSharesRequestInput

    public class BulkAddNasSharesRequestInput: IInput
    {
        #region members

        //      C# -> List<CreateNasShareInput>? NasShares
        // GraphQL -> nasShares: [CreateNasShareInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("nasShares")]
        public List<CreateNasShareInput>? NasShares { get; set; }

        //      C# -> System.String? NasSourceId
        // GraphQL -> nasSourceId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nasSourceId")]
        public System.String? NasSourceId { get; set; }


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

    } // class BulkAddNasSharesRequestInput
    #endregion

} // namespace RubrikSecurityCloud.Types
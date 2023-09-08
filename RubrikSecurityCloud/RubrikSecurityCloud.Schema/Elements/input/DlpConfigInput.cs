// DlpConfigInput.cs
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
    #region DlpConfigInput

    public class DlpConfigInput: IInput
    {
        #region members

        //      C# -> List<System.String>? Policies
        // GraphQL -> policies: [String!] (scalar)
        [JsonProperty("policies")]
        public List<System.String>? Policies { get; set; }

        //      C# -> DlpConfigGenericNasInput? GenericNas
        // GraphQL -> genericNas: DlpConfigGenericNasInput (input)
        [JsonProperty("genericNas")]
        public DlpConfigGenericNasInput? GenericNas { get; set; }

        //      C# -> DlpConfigVmwareVmInput? VmwareVm
        // GraphQL -> vmwareVm: DlpConfigVmwareVmInput (input)
        [JsonProperty("vmwareVm")]
        public DlpConfigVmwareVmInput? VmwareVm { get; set; }

        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String (scalar)
        [JsonProperty("serviceAccountId")]
        public System.String? ServiceAccountId { get; set; }

        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String (scalar)
        [JsonProperty("serviceAccountName")]
        public System.String? ServiceAccountName { get; set; }

        //      C# -> DlpStatusInput? Status
        // GraphQL -> status: DlpStatusInput (input)
        [JsonProperty("status")]
        public DlpStatusInput? Status { get; set; }

        //      C# -> DlpConfigTargetType? TargetType
        // GraphQL -> targetType: DlpConfigTargetType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("targetType")]
        public DlpConfigTargetType? TargetType { get; set; }


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

    } // class DlpConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
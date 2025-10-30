// AddCrossAccountServiceConsumerInput.cs
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
    #region AddCrossAccountServiceConsumerInput

    public class AddCrossAccountServiceConsumerInput: IInput
    {
        #region members

        //      C# -> System.String? CrossAccountId
        // GraphQL -> crossAccountId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("crossAccountId")]
        public System.String? CrossAccountId { get; set; }

        //      C# -> CrossAccountSaInput? ServiceConsumerSa
        // GraphQL -> serviceConsumerSa: CrossAccountSaInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceConsumerSa")]
        public CrossAccountSaInput? ServiceConsumerSa { get; set; }

        //      C# -> System.Boolean? IsRefresh
        // GraphQL -> isRefresh: Boolean (scalar)
        [JsonProperty("isRefresh")]
        public System.Boolean? IsRefresh { get; set; }

        //      C# -> System.String? Fqdn
        // GraphQL -> fqdn: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fqdn")]
        public System.String? Fqdn { get; set; }


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

    } // class AddCrossAccountServiceConsumerInput
    #endregion

} // namespace RubrikSecurityCloud.Types
// NasSystemRegisterInput.cs
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
    #region NasSystemRegisterInput

    public class NasSystemRegisterInput: IInput
    {
        #region members

        //      C# -> GenericNasSystemParametersInput? GenericNasSystemParameters
        // GraphQL -> genericNasSystemParameters: GenericNasSystemParametersInput (input)
        [JsonProperty("genericNasSystemParameters")]
        public GenericNasSystemParametersInput? GenericNasSystemParameters { get; set; }

        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        [JsonProperty("isIsilonChangelistEnabled")]
        public System.Boolean? IsIsilonChangelistEnabled { get; set; }

        //      C# -> NasApiCredentialsInput? NasTmpApiCredentials
        // GraphQL -> nasTmpApiCredentials: NasApiCredentialsInput (input)
        [JsonProperty("nasTmpApiCredentials")]
        public NasApiCredentialsInput? NasTmpApiCredentials { get; set; }

        //      C# -> NasVendorType? NasVendorType
        // GraphQL -> nasVendorType: NasVendorType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("nasVendorType")]
        public NasVendorType? NasVendorType { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }


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

    } // class NasSystemRegisterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
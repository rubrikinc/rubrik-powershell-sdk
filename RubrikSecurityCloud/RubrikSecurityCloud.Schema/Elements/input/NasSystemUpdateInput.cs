// NasSystemUpdateInput.cs
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
    #region NasSystemUpdateInput

    public class NasSystemUpdateInput: IInput
    {
        #region members

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        [JsonProperty("isIsilonChangelistEnabled")]
        public System.Boolean? IsIsilonChangelistEnabled { get; set; }

        //      C# -> System.Boolean? ShouldResetGeneratedNamespaceSmbCredentials
        // GraphQL -> shouldResetGeneratedNamespaceSmbCredentials: Boolean (scalar)
        [JsonProperty("shouldResetGeneratedNamespaceSmbCredentials")]
        public System.Boolean? ShouldResetGeneratedNamespaceSmbCredentials { get; set; }

        //      C# -> System.Boolean? ShouldGrantSmbShareRootAccess
        // GraphQL -> shouldGrantSmbShareRootAccess: Boolean (scalar)
        [JsonProperty("shouldGrantSmbShareRootAccess")]
        public System.Boolean? ShouldGrantSmbShareRootAccess { get; set; }

        //      C# -> System.Boolean? ShouldGrantNfsShareRootAccess
        // GraphQL -> shouldGrantNfsShareRootAccess: Boolean (scalar)
        [JsonProperty("shouldGrantNfsShareRootAccess")]
        public System.Boolean? ShouldGrantNfsShareRootAccess { get; set; }

        //      C# -> GenericNasSystemParametersInput? GenericNasSystemParameters
        // GraphQL -> genericNasSystemParameters: GenericNasSystemParametersInput (input)
        [JsonProperty("genericNasSystemParameters")]
        public GenericNasSystemParametersInput? GenericNasSystemParameters { get; set; }

        //      C# -> NasApiCredentialsInput? NasApiCredentials
        // GraphQL -> nasApiCredentials: NasApiCredentialsInput (input)
        [JsonProperty("nasApiCredentials")]
        public NasApiCredentialsInput? NasApiCredentials { get; set; }

        //      C# -> FlashBladeSystemParametersInput? NasFlashBladeApiCredentials
        // GraphQL -> nasFlashBladeApiCredentials: FlashBladeSystemParametersInput (input)
        [JsonProperty("nasFlashBladeApiCredentials")]
        public FlashBladeSystemParametersInput? NasFlashBladeApiCredentials { get; set; }

        //      C# -> NutanixFileServerParametersInput? NutanixFileServerParameters
        // GraphQL -> nutanixFileServerParameters: NutanixFileServerParametersInput (input)
        [JsonProperty("nutanixFileServerParameters")]
        public NutanixFileServerParametersInput? NutanixFileServerParameters { get; set; }

        //      C# -> NasShareCredentialsInput? SmbCredentials
        // GraphQL -> smbCredentials: NasShareCredentialsInput (input)
        [JsonProperty("smbCredentials")]
        public NasShareCredentialsInput? SmbCredentials { get; set; }


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

    } // class NasSystemUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types
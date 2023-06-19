// ObjectStoreAccessInput.cs
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
    #region ObjectStoreAccessInput

    public class ObjectStoreAccessInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsSslEnabled
        // GraphQL -> isSslEnabled: Boolean (scalar)
        [JsonProperty("isSslEnabled")]
        public System.Boolean? IsSslEnabled { get; set; }

        //      C# -> System.String? ObjectServerUrl
        // GraphQL -> objectServerUrl: String (scalar)
        [JsonProperty("objectServerUrl")]
        public System.String? ObjectServerUrl { get; set; }

        //      C# -> System.String? ProviderType
        // GraphQL -> providerType: String (scalar)
        [JsonProperty("providerType")]
        public System.String? ProviderType { get; set; }

        //      C# -> System.Boolean? ShouldUseHttpProxy
        // GraphQL -> shouldUseHttpProxy: Boolean (scalar)
        [JsonProperty("shouldUseHttpProxy")]
        public System.Boolean? ShouldUseHttpProxy { get; set; }


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

    } // class ObjectStoreAccessInput
    #endregion

} // namespace RubrikSecurityCloud.Types
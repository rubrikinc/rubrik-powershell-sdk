// K8sClusterUpdateConfigInput.cs
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
    #region K8sClusterUpdateConfigInput

    public class K8sClusterUpdateConfigInput: IInput
    {
        #region members

        //      C# -> System.String? Kubeconfig
        // GraphQL -> kubeconfig: String (scalar)
        [JsonProperty("kubeconfig")]
        public System.String? Kubeconfig { get; set; }

        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        [JsonProperty("registry")]
        public System.String? Registry { get; set; }

        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String (scalar)
        [JsonProperty("serviceAccountName")]
        public System.String? ServiceAccountName { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String (scalar)
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String (scalar)
        [JsonProperty("accessToken")]
        public System.String? AccessToken { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }


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

    } // class K8sClusterUpdateConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
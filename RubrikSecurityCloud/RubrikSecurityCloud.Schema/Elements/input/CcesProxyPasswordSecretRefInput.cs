// CcesProxyPasswordSecretRefInput.cs
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
    #region CcesProxyPasswordSecretRefInput

    public class CcesProxyPasswordSecretRefInput: IInput
    {
        #region members

        //      C# -> AwsSsmSecretRef? AwsSsm
        // GraphQL -> awsSsm: AwsSsmSecretRef (input)
        [JsonProperty("awsSsm")]
        public AwsSsmSecretRef? AwsSsm { get; set; }

        //      C# -> AzureKeyVaultSecretRef? AzureKeyVault
        // GraphQL -> azureKeyVault: AzureKeyVaultSecretRef (input)
        [JsonProperty("azureKeyVault")]
        public AzureKeyVaultSecretRef? AzureKeyVault { get; set; }

        //      C# -> GcpSecretManagerRef? GcpSecretManager
        // GraphQL -> gcpSecretManager: GcpSecretManagerRef (input)
        [JsonProperty("gcpSecretManager")]
        public GcpSecretManagerRef? GcpSecretManager { get; set; }


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

    } // class CcesProxyPasswordSecretRefInput
    #endregion

} // namespace RubrikSecurityCloud.Types
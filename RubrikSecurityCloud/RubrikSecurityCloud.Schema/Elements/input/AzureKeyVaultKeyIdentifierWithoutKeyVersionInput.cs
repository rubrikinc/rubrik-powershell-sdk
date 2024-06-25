// AzureKeyVaultKeyIdentifierWithoutKeyVersionInput.cs
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
    #region AzureKeyVaultKeyIdentifierWithoutKeyVersionInput

    public class AzureKeyVaultKeyIdentifierWithoutKeyVersionInput: IInput
    {
        #region members

        //      C# -> System.String? KmsKeyVaultId
        // GraphQL -> kmsKeyVaultId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("kmsKeyVaultId")]
        public System.String? KmsKeyVaultId { get; set; }

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }


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

    } // class AzureKeyVaultKeyIdentifierWithoutKeyVersionInput
    #endregion

} // namespace RubrikSecurityCloud.Types
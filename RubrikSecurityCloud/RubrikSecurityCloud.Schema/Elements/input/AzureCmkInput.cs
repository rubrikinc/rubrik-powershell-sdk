// AzureCmkInput.cs
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
    #region AzureCmkInput

    public class AzureCmkInput: IInput
    {
        #region members

        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String (scalar)
        [JsonProperty("keyVaultName")]
        public System.String? KeyVaultName { get; set; }

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion (enum)
        [JsonProperty("region")]
        public AzureRegion? Region { get; set; }


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

    } // class AzureCmkInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
// KickoffAzureAdAppSetupInput.cs
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
    #region KickoffAzureAdAppSetupInput

    public class KickoffAzureAdAppSetupInput: IInput
    {
        #region members

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> AzureCommonRegion? Region
        // GraphQL -> region: AzureCommonRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AzureCommonRegion? Region { get; set; }

        //      C# -> AzureAdApp? AzureAdApp
        // GraphQL -> azureADApp: AzureADApp (input)
        [JsonProperty("azureADApp")]
        public AzureAdApp? AzureAdApp { get; set; }


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

    } // class KickoffAzureAdAppSetupInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
// SecretConfig.cs
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
    #region SecretConfig

    public class SecretConfig: IInput
    {
        #region members

        //      C# -> System.String? SettingDefinitionId
        // GraphQL -> settingDefinitionId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("settingDefinitionId")]
        public System.String? SettingDefinitionId { get; set; }

        //      C# -> System.String? SecretValue
        // GraphQL -> secretValue: String (scalar)
        [JsonProperty("secretValue")]
        public System.String? SecretValue { get; set; }

        //      C# -> System.String? CollectionDefinitionId
        // GraphQL -> collectionDefinitionId: String (scalar)
        [JsonProperty("collectionDefinitionId")]
        public System.String? CollectionDefinitionId { get; set; }

        //      C# -> System.Int32? RowIndex
        // GraphQL -> rowIndex: Int (scalar)
        [JsonProperty("rowIndex")]
        public System.Int32? RowIndex { get; set; }

        //      C# -> List<System.String>? SecretValues
        // GraphQL -> secretValues: [String!] (scalar)
        [JsonProperty("secretValues")]
        public List<System.String>? SecretValues { get; set; }


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

    } // class SecretConfig
    #endregion

} // namespace RubrikSecurityCloud.Types
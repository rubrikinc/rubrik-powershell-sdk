// MosaicGetSchemaRequestInput.cs
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
    #region MosaicGetSchemaRequestInput

    public class MosaicGetSchemaRequestInput: IInput
    {
        #region members

        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("databaseName")]
        public System.String? DatabaseName { get; set; }

        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceName")]
        public System.String? SourceName { get; set; }

        //      C# -> System.String? TableName
        // GraphQL -> tableName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tableName")]
        public System.String? TableName { get; set; }

        //      C# -> System.String? VersionTimestamp
        // GraphQL -> versionTimestamp: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("versionTimestamp")]
        public System.String? VersionTimestamp { get; set; }


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

    } // class MosaicGetSchemaRequestInput
    #endregion

} // namespace RubrikSecurityCloud.Types
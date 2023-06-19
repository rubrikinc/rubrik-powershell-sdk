// VersionInput.cs
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
    #region VersionInput

    public class VersionInput: IInput
    {
        #region members

        //      C# -> System.Int32? MaxEntries
        // GraphQL -> maxEntries: Int (scalar)
        [JsonProperty("maxEntries")]
        public System.Int32? MaxEntries { get; set; }

        //      C# -> System.Int32? Since
        // GraphQL -> since: Int (scalar)
        [JsonProperty("since")]
        public System.Int32? Since { get; set; }

        //      C# -> System.Int32? Upto
        // GraphQL -> upto: Int (scalar)
        [JsonProperty("upto")]
        public System.Int32? Upto { get; set; }

        //      C# -> VersionSourceType? SourceType
        // GraphQL -> sourceType: VersionSourceType (enum)
        [JsonProperty("sourceType")]
        public VersionSourceType? SourceType { get; set; }

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

    } // class VersionInput
    #endregion

} // namespace RubrikSecurityCloud.Types
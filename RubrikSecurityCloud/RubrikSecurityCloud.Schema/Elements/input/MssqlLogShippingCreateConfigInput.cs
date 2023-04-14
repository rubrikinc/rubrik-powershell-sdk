// MssqlLogShippingCreateConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MssqlLogShippingCreateConfigInput

    public class MssqlLogShippingCreateConfigInput: IInput
    {
        #region members

        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        [JsonProperty("maxDataStreams")]
        public System.Int32? MaxDataStreams { get; set; }

        //      C# -> System.String? TargetDataFilePath
        // GraphQL -> targetDataFilePath: String (scalar)
        [JsonProperty("targetDataFilePath")]
        public System.String? TargetDataFilePath { get; set; }

        //      C# -> List<MssqlDbFileExportPathInput>? TargetFilePaths
        // GraphQL -> targetFilePaths: [MssqlDbFileExportPathInput!] (input)
        [JsonProperty("targetFilePaths")]
        public List<MssqlDbFileExportPathInput>? TargetFilePaths { get; set; }

        //      C# -> System.String? TargetLogFilePath
        // GraphQL -> targetLogFilePath: String (scalar)
        [JsonProperty("targetLogFilePath")]
        public System.String? TargetLogFilePath { get; set; }

        //      C# -> MssqlLogShippingTargetStateOptionsInput? MssqlLogShippingTargetStateOptions
        // GraphQL -> mssqlLogShippingTargetStateOptions: MssqlLogShippingTargetStateOptionsInput (input)
        [JsonProperty("mssqlLogShippingTargetStateOptions")]
        public MssqlLogShippingTargetStateOptionsInput? MssqlLogShippingTargetStateOptions { get; set; }

        //      C# -> System.String? TargetDatabaseName
        // GraphQL -> targetDatabaseName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetDatabaseName")]
        public System.String? TargetDatabaseName { get; set; }

        //      C# -> System.String? TargetInstanceId
        // GraphQL -> targetInstanceId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetInstanceId")]
        public System.String? TargetInstanceId { get; set; }


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

    } // class MssqlLogShippingCreateConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
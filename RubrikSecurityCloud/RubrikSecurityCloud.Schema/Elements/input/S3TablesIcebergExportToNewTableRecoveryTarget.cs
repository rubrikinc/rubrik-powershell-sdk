// S3TablesIcebergExportToNewTableRecoveryTarget.cs
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
    #region S3TablesIcebergExportToNewTableRecoveryTarget

    public class S3TablesIcebergExportToNewTableRecoveryTarget: IInput
    {
        #region members

        //      C# -> System.String? DestTableBucketId
        // GraphQL -> destTableBucketId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destTableBucketId")]
        public System.String? DestTableBucketId { get; set; }

        //      C# -> System.String? DestNamespaceId
        // GraphQL -> destNamespaceId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destNamespaceId")]
        public System.String? DestNamespaceId { get; set; }

        //      C# -> System.String? DestTableName
        // GraphQL -> destTableName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destTableName")]
        public System.String? DestTableName { get; set; }


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

    } // class S3TablesIcebergExportToNewTableRecoveryTarget
    #endregion

} // namespace RubrikSecurityCloud.Types
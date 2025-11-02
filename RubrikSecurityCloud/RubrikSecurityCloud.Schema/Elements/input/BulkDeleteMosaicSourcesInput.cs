// BulkDeleteMosaicSourcesInput.cs
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
    #region BulkDeleteMosaicSourcesInput

    public class BulkDeleteMosaicSourcesInput: IInput
    {
        #region members

        //      C# -> BulkDeleteSourceRequestInput? SourceData
        // GraphQL -> sourceData: BulkDeleteSourceRequestInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceData")]
        public BulkDeleteSourceRequestInput? SourceData { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> V2BulkDeleteMosaicSourcesRequestSourceType? SourceType
        // GraphQL -> sourceType: V2BulkDeleteMosaicSourcesRequestSourceType (enum)
        [JsonProperty("sourceType")]
        public V2BulkDeleteMosaicSourcesRequestSourceType? SourceType { get; set; }


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

    } // class BulkDeleteMosaicSourcesInput
    #endregion

} // namespace RubrikSecurityCloud.Types
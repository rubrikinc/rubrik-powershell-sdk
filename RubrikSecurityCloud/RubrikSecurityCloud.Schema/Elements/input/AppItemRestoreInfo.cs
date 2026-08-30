// AppItemRestoreInfo.cs
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
    #region AppItemRestoreInfo

    public class AppItemRestoreInfo: IInput
    {
        #region members

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> List<RestoreItemInfo>? ItemsToRestore
        // GraphQL -> itemsToRestore: [RestoreItemInfo!] (input)
        [JsonProperty("itemsToRestore")]
        public List<RestoreItemInfo>? ItemsToRestore { get; set; }

        //      C# -> RestoreItemCriteria? ItemCriteria
        // GraphQL -> itemCriteria: RestoreItemCriteria (input)
        [JsonProperty("itemCriteria")]
        public RestoreItemCriteria? ItemCriteria { get; set; }

        //      C# -> List<ExcludedChildDetails>? ExcludeChildren
        // GraphQL -> excludeChildren: [ExcludedChildDetails!] (input)
        [JsonProperty("excludeChildren")]
        public List<ExcludedChildDetails>? ExcludeChildren { get; set; }

        //      C# -> System.Int32? HierarchyDepth
        // GraphQL -> hierarchyDepth: Int (scalar)
        [JsonProperty("hierarchyDepth")]
        public System.Int32? HierarchyDepth { get; set; }

        //      C# -> List<System.String>? FieldsToRestore
        // GraphQL -> fieldsToRestore: [String!] (scalar)
        [JsonProperty("fieldsToRestore")]
        public List<System.String>? FieldsToRestore { get; set; }


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

    } // class AppItemRestoreInfo
    #endregion

} // namespace RubrikSecurityCloud.Types
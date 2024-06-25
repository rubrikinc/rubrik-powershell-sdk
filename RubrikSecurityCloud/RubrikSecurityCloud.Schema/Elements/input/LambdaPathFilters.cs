// LambdaPathFilters.cs
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
    #region LambdaPathFilters

    public class LambdaPathFilters: IInput
    {
        #region members

        //      C# -> System.Boolean? EnableAbsolutePaths
        // GraphQL -> enableAbsolutePaths: Boolean (scalar)
        [JsonProperty("enableAbsolutePaths")]
        public System.Boolean? EnableAbsolutePaths { get; set; }

        //      C# -> System.Boolean? EnableAbsolutePathCachePreload
        // GraphQL -> enableAbsolutePathCachePreload: Boolean (scalar)
        [JsonProperty("enableAbsolutePathCachePreload")]
        public System.Boolean? EnableAbsolutePathCachePreload { get; set; }

        //      C# -> List<System.String>? ParentFolderIdBatch
        // GraphQL -> parentFolderIdBatch: [String!] (scalar)
        [JsonProperty("parentFolderIdBatch")]
        public List<System.String>? ParentFolderIdBatch { get; set; }

        //      C# -> System.String? SearchRecurseFolderId
        // GraphQL -> searchRecurseFolderId: String (scalar)
        [JsonProperty("searchRecurseFolderId")]
        public System.String? SearchRecurseFolderId { get; set; }

        //      C# -> System.Boolean? IncludeAncestors
        // GraphQL -> includeAncestors: Boolean (scalar)
        [JsonProperty("includeAncestors")]
        public System.Boolean? IncludeAncestors { get; set; }


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

    } // class LambdaPathFilters
    #endregion

} // namespace RubrikSecurityCloud.Types
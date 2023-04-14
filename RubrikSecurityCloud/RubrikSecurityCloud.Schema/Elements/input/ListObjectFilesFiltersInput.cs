// ListObjectFilesFiltersInput.cs
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
    #region ListObjectFilesFiltersInput

    public class ListObjectFilesFiltersInput: IInput
    {
        #region members

        //      C# -> List<OpenAccessType>? OpenAccessTypes
        // GraphQL -> openAccessTypes: [OpenAccessType!] (enum)
        [JsonProperty("openAccessTypes")]
        public List<OpenAccessType>? OpenAccessTypes { get; set; }

        //      C# -> List<StalenessType>? StalenessTypes
        // GraphQL -> stalenessTypes: [StalenessType!] (enum)
        [JsonProperty("stalenessTypes")]
        public List<StalenessType>? StalenessTypes { get; set; }

        //      C# -> List<System.String>? AnalyzerGroupIds
        // GraphQL -> analyzerGroupIds: [String!] (scalar)
        [JsonProperty("analyzerGroupIds")]
        public List<System.String>? AnalyzerGroupIds { get; set; }

        //      C# -> List<System.String>? ClusterIds
        // GraphQL -> clusterIds: [String!] (scalar)
        [JsonProperty("clusterIds")]
        public List<System.String>? ClusterIds { get; set; }

        //      C# -> System.String? PathPrefix
        // GraphQL -> pathPrefix: String (scalar)
        [JsonProperty("pathPrefix")]
        public System.String? PathPrefix { get; set; }

        //      C# -> List<System.String>? SnappableTypes
        // GraphQL -> snappableTypes: [String!] (scalar)
        [JsonProperty("snappableTypes")]
        public List<System.String>? SnappableTypes { get; set; }

        //      C# -> System.String? SearchText
        // GraphQL -> searchText: String (scalar)
        [JsonProperty("searchText")]
        public System.String? SearchText { get; set; }

        //      C# -> System.Boolean? WhitelistEnabled
        // GraphQL -> whitelistEnabled: Boolean (scalar)
        [JsonProperty("whitelistEnabled")]
        public System.Boolean? WhitelistEnabled { get; set; }

        //      C# -> List<FileCountType>? FileCountTypes
        // GraphQL -> fileCountTypes: [FileCountType!] (enum)
        [JsonProperty("fileCountTypes")]
        public List<FileCountType>? FileCountTypes { get; set; }

        //      C# -> List<AccessType>? AccessTypes
        // GraphQL -> accessTypes: [AccessType!] (enum)
        [JsonProperty("accessTypes")]
        public List<AccessType>? AccessTypes { get; set; }

        //      C# -> List<ActivityAccessType>? ActivityTypes
        // GraphQL -> activityTypes: [ActivityAccessType!] (enum)
        [JsonProperty("activityTypes")]
        public List<ActivityAccessType>? ActivityTypes { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!] (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> List<InodeType>? InodeTypes
        // GraphQL -> inodeTypes: [InodeType!] (enum)
        [JsonProperty("inodeTypes")]
        public List<InodeType>? InodeTypes { get; set; }

        //      C# -> List<HierarchyObjectTypeEnum>? ObjectTypes
        // GraphQL -> objectTypes: [HierarchyObjectTypeEnum!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectTypes")]
        public List<HierarchyObjectTypeEnum>? ObjectTypes { get; set; }


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

    } // class ListObjectFilesFiltersInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
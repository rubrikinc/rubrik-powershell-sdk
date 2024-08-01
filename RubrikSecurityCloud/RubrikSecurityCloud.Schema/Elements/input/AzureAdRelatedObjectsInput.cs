// AzureAdRelatedObjectsInput.cs
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
    #region AzureAdRelatedObjectsInput

    public class AzureAdRelatedObjectsInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> System.String? AzureAdObjectUuid
        // GraphQL -> azureAdObjectUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("azureAdObjectUuid")]
        public System.String? AzureAdObjectUuid { get; set; }

        //      C# -> System.String? AzureAdCommonSearchKeyword
        // GraphQL -> azureAdCommonSearchKeyword: String (scalar)
        [JsonProperty("azureAdCommonSearchKeyword")]
        public System.String? AzureAdCommonSearchKeyword { get; set; }

        //      C# -> AzureAdObjectType? AzureAdObjectType
        // GraphQL -> azureAdObjectType: AzureAdObjectType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("azureAdObjectType")]
        public AzureAdObjectType? AzureAdObjectType { get; set; }

        //      C# -> List<AzureAdRelationshipTypeInput>? AzureAdRelationshipType
        // GraphQL -> azureAdRelationshipType: [AzureAdRelationshipTypeInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("azureAdRelationshipType")]
        public List<AzureAdRelationshipTypeInput>? AzureAdRelationshipType { get; set; }

        //      C# -> AzureAdObjectCommonSearchType? AzureAdCommonSearchKeywordType
        // GraphQL -> azureAdCommonSearchKeywordType: AzureAdObjectCommonSearchType (enum)
        [JsonProperty("azureAdCommonSearchKeywordType")]
        public AzureAdObjectCommonSearchType? AzureAdCommonSearchKeywordType { get; set; }

        //      C# -> List<AzureAdObjectType>? AzureAdRelatedObjectTypeFilter
        // GraphQL -> azureAdRelatedObjectTypeFilter: [AzureAdObjectType!] (enum)
        [JsonProperty("azureAdRelatedObjectTypeFilter")]
        public List<AzureAdObjectType>? AzureAdRelatedObjectTypeFilter { get; set; }


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

    } // class AzureAdRelatedObjectsInput
    #endregion

} // namespace RubrikSecurityCloud.Types
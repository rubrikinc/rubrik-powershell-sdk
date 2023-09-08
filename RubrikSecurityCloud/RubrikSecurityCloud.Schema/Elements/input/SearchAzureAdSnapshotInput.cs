// SearchAzureAdSnapshotInput.cs
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
    #region SearchAzureAdSnapshotInput

    public class SearchAzureAdSnapshotInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? AzureAdSearchKeyword
        // GraphQL -> azureAdSearchKeyword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("azureAdSearchKeyword")]
        public System.String? AzureAdSearchKeyword { get; set; }

        //      C# -> AzureAdObjectType? AzureAdObjectType
        // GraphQL -> azureAdObjectType: AzureAdObjectType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("azureAdObjectType")]
        public AzureAdObjectType? AzureAdObjectType { get; set; }

        //      C# -> AzureAdObjectSearchType? AzureAdSearchKeywordType
        // GraphQL -> azureAdSearchKeywordType: AzureAdObjectSearchType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("azureAdSearchKeywordType")]
        public AzureAdObjectSearchType? AzureAdSearchKeywordType { get; set; }


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

    } // class SearchAzureAdSnapshotInput
    #endregion

} // namespace RubrikSecurityCloud.Types
// CreateCloudNativeApplicationInput.cs
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
    #region CreateCloudNativeApplicationInput

    public class CreateCloudNativeApplicationInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudNativeAccountId")]
        public System.String? CloudNativeAccountId { get; set; }

        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetCloudNativeAccountId")]
        public System.String? TargetCloudNativeAccountId { get; set; }

        //      C# -> CloudRegionInput? Region
        // GraphQL -> region: CloudRegionInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public CloudRegionInput? Region { get; set; }

        //      C# -> ApplicationServiceConfigurationInput? ServiceConfigured
        // GraphQL -> serviceConfigured: ApplicationServiceConfigurationInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceConfigured")]
        public ApplicationServiceConfigurationInput? ServiceConfigured { get; set; }

        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudType")]
        public CloudServiceProvider? CloudType { get; set; }

        //      C# -> List<System.String>? ResourceInclusionList
        // GraphQL -> resourceInclusionList: [String!] (scalar)
        [JsonProperty("resourceInclusionList")]
        public List<System.String>? ResourceInclusionList { get; set; }

        //      C# -> List<System.String>? ResourceExclusionList
        // GraphQL -> resourceExclusionList: [String!] (scalar)
        [JsonProperty("resourceExclusionList")]
        public List<System.String>? ResourceExclusionList { get; set; }

        //      C# -> CreateApplicationMatchingTagInput? MatchingTags
        // GraphQL -> matchingTags: CreateApplicationMatchingTagInput (input)
        [JsonProperty("matchingTags")]
        public CreateApplicationMatchingTagInput? MatchingTags { get; set; }


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

    } // class CreateCloudNativeApplicationInput
    #endregion

} // namespace RubrikSecurityCloud.Types
// UpdateCloudNativeApplicationInput.cs
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
    #region UpdateCloudNativeApplicationInput

    public class UpdateCloudNativeApplicationInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID (scalar)
        [JsonProperty("targetCloudNativeAccountId")]
        public System.String? TargetCloudNativeAccountId { get; set; }

        //      C# -> ApplicationServiceConfigurationInput? ServiceConfigured
        // GraphQL -> serviceConfigured: ApplicationServiceConfigurationInput (input)
        [JsonProperty("serviceConfigured")]
        public ApplicationServiceConfigurationInput? ServiceConfigured { get; set; }

        //      C# -> System.Boolean? PostRecoveryScriptConfigured
        // GraphQL -> postRecoveryScriptConfigured: Boolean (scalar)
        [JsonProperty("postRecoveryScriptConfigured")]
        public System.Boolean? PostRecoveryScriptConfigured { get; set; }

        //      C# -> ResourceUriList? ResourceInclusionList
        // GraphQL -> resourceInclusionList: ResourceUriList (input)
        [JsonProperty("resourceInclusionList")]
        public ResourceUriList? ResourceInclusionList { get; set; }

        //      C# -> ResourceUriList? ResourceExclusionList
        // GraphQL -> resourceExclusionList: ResourceUriList (input)
        [JsonProperty("resourceExclusionList")]
        public ResourceUriList? ResourceExclusionList { get; set; }

        //      C# -> UpdateApplicationMatchingTagInput? MatchingTags
        // GraphQL -> matchingTags: UpdateApplicationMatchingTagInput (input)
        [JsonProperty("matchingTags")]
        public UpdateApplicationMatchingTagInput? MatchingTags { get; set; }


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

    } // class UpdateCloudNativeApplicationInput
    #endregion

} // namespace RubrikSecurityCloud.Types
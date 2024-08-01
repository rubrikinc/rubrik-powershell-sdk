// CreateChatbotInput.cs
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
    #region CreateChatbotInput

    public class CreateChatbotInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> SourceDataFiltersInput? Filters
        // GraphQL -> filters: SourceDataFiltersInput (input)
        [JsonProperty("filters")]
        public SourceDataFiltersInput? Filters { get; set; }

        //      C# -> ChatbotUserAssignmentInput? UserAssignment
        // GraphQL -> userAssignment: ChatbotUserAssignmentInput (input)
        [JsonProperty("userAssignment")]
        public ChatbotUserAssignmentInput? UserAssignment { get; set; }

        //      C# -> ChatbotSettingsInput? ChatbotSettings
        // GraphQL -> chatbotSettings: ChatbotSettingsInput (input)
        [JsonProperty("chatbotSettings")]
        public ChatbotSettingsInput? ChatbotSettings { get; set; }

        //      C# -> EmbeddingFactorySettingsInput? EmbeddingFactorySettings
        // GraphQL -> embeddingFactorySettings: EmbeddingFactorySettingsInput (input)
        [JsonProperty("embeddingFactorySettings")]
        public EmbeddingFactorySettingsInput? EmbeddingFactorySettings { get; set; }

        //      C# -> List<ChatbotObjectMetadataInput>? Objects
        // GraphQL -> objects: [ChatbotObjectMetadataInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("objects")]
        public List<ChatbotObjectMetadataInput>? Objects { get; set; }

        //      C# -> List<System.String>? RoleIds
        // GraphQL -> roleIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("roleIds")]
        public List<System.String>? RoleIds { get; set; }


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

    } // class CreateChatbotInput
    #endregion

} // namespace RubrikSecurityCloud.Types
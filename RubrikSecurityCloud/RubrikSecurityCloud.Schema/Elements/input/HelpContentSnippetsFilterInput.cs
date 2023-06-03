// HelpContentSnippetsFilterInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region HelpContentSnippetsFilterInput

    public class HelpContentSnippetsFilterInput: IInput
    {
        #region members

        //      C# -> HelpContentSnippetsFilterInitiator? Initiator
        // GraphQL -> initiator: HelpContentSnippetsFilterInitiator (enum)
        [JsonProperty("initiator")]
        public HelpContentSnippetsFilterInitiator? Initiator { get; set; }

        //      C# -> System.String? Query
        // GraphQL -> query: String (scalar)
        [JsonProperty("query")]
        public System.String? Query { get; set; }

        //      C# -> System.String? Language
        // GraphQL -> language: String (scalar)
        [JsonProperty("language")]
        public System.String? Language { get; set; }

        //      C# -> HelpContentSource? Source
        // GraphQL -> source: HelpContentSource (enum)
        [JsonProperty("source")]
        public HelpContentSource? Source { get; set; }

        //      C# -> List<System.String>? Categories
        // GraphQL -> categories: [String!] (scalar)
        [JsonProperty("categories")]
        public List<System.String>? Categories { get; set; }

        //      C# -> List<ProductDocumentationType>? ProductDocumentationTypes
        // GraphQL -> productDocumentationTypes: [ProductDocumentationType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("productDocumentationTypes")]
        public List<ProductDocumentationType>? ProductDocumentationTypes { get; set; }


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

    } // class HelpContentSnippetsFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
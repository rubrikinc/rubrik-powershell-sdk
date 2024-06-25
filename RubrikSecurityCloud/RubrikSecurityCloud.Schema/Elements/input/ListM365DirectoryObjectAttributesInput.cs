// ListM365DirectoryObjectAttributesInput.cs
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
    #region ListM365DirectoryObjectAttributesInput

    public class ListM365DirectoryObjectAttributesInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> DirectoryObjectType? ObjectType
        // GraphQL -> objectType: DirectoryObjectType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectType")]
        public DirectoryObjectType? ObjectType { get; set; }

        //      C# -> AttributeType? AttributeType
        // GraphQL -> attributeType: AttributeType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("attributeType")]
        public AttributeType? AttributeType { get; set; }

        //      C# -> System.String? SearchTextPrefix
        // GraphQL -> searchTextPrefix: String (scalar)
        [JsonProperty("searchTextPrefix")]
        public System.String? SearchTextPrefix { get; set; }

        //      C# -> System.Int32? MaxResults
        // GraphQL -> maxResults: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("maxResults")]
        public System.Int32? MaxResults { get; set; }


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

    } // class ListM365DirectoryObjectAttributesInput
    #endregion

} // namespace RubrikSecurityCloud.Types
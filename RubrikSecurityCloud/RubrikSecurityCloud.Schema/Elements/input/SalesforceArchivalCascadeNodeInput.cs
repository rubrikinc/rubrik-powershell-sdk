// SalesforceArchivalCascadeNodeInput.cs
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
    #region SalesforceArchivalCascadeNodeInput

    public class SalesforceArchivalCascadeNodeInput: IInput
    {
        #region members

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.Boolean? IncludeAllChildren
        // GraphQL -> includeAllChildren: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("includeAllChildren")]
        public System.Boolean? IncludeAllChildren { get; set; }

        //      C# -> List<SalesforceArchivalCascadeNodeInput>? Children
        // GraphQL -> children: [SalesforceArchivalCascadeNodeInput!] (input)
        [JsonProperty("children")]
        public List<SalesforceArchivalCascadeNodeInput>? Children { get; set; }

        //      C# -> SalesforceRelationshipType? RelationshipType
        // GraphQL -> relationshipType: SalesforceRelationshipType (enum)
        [JsonProperty("relationshipType")]
        public SalesforceRelationshipType? RelationshipType { get; set; }

        //      C# -> System.String? RelationshipField
        // GraphQL -> relationshipField: String (scalar)
        [JsonProperty("relationshipField")]
        public System.String? RelationshipField { get; set; }


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

    } // class SalesforceArchivalCascadeNodeInput
    #endregion

} // namespace RubrikSecurityCloud.Types
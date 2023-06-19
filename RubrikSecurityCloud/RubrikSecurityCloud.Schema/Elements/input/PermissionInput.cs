// PermissionInput.cs
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
    #region PermissionInput

    public class PermissionInput: IInput
    {
        #region members

        //      C# -> Operation? Operation
        // GraphQL -> operation: Operation! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("operation")]
        public Operation? Operation { get; set; }

        //      C# -> List<ObjectIdsForHierarchyTypeInput>? ObjectsForHierarchyTypes
        // GraphQL -> objectsForHierarchyTypes: [ObjectIdsForHierarchyTypeInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("objectsForHierarchyTypes")]
        public List<ObjectIdsForHierarchyTypeInput>? ObjectsForHierarchyTypes { get; set; }


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

    } // class PermissionInput
    #endregion

} // namespace RubrikSecurityCloud.Types
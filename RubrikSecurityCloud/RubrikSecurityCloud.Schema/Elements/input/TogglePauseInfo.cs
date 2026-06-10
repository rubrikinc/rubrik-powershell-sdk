// TogglePauseInfo.cs
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
    #region TogglePauseInfo

    public class TogglePauseInfo: IInput
    {
        #region members

        //      C# -> List<System.String>? ObjectId
        // GraphQL -> objectId: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectId")]
        public List<System.String>? ObjectId { get; set; }

        //      C# -> WorkloadLevelHierarchy? SnappableHierarchyType
        // GraphQL -> snappableHierarchyType: WorkloadLevelHierarchy (enum)
        [JsonProperty("snappableHierarchyType")]
        public WorkloadLevelHierarchy? SnappableHierarchyType { get; set; }


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

    } // class TogglePauseInfo
    #endregion

} // namespace RubrikSecurityCloud.Types
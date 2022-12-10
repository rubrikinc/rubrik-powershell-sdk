// SelfServicePermissionInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:31.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SelfServicePermissionInput

    public class SelfServicePermissionInput
    {
        #region members
        //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
        // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("inventoryRoot")]
        public InventorySubHierarchyRootEnum? InventoryRoot { get; set; }

        //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
        // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("inventoryWorkloadType")]
        public WorkloadLevelHierarchy? InventoryWorkloadType { get; set; }

        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("operations")]
        public List<Operation>? Operations { get; set; }

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

    } // class SelfServicePermissionInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
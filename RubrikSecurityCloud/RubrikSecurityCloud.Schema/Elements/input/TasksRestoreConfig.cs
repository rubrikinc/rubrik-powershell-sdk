// TasksRestoreConfig.cs
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
    #region TasksRestoreConfig

    public class TasksRestoreConfig: IInput
    {
        #region members

        //      C# -> List<TaskInfo>? TasksToRestore
        // GraphQL -> tasksToRestore: [TaskInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("tasksToRestore")]
        public List<TaskInfo>? TasksToRestore { get; set; }

        //      C# -> List<TaskListRestoreInfo>? TaskListsToRestore
        // GraphQL -> taskListsToRestore: [TaskListRestoreInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("taskListsToRestore")]
        public List<TaskListRestoreInfo>? TaskListsToRestore { get; set; }


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

    } // class TasksRestoreConfig
    #endregion

} // namespace RubrikSecurityCloud.Types
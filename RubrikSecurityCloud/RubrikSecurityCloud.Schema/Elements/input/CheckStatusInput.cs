// CheckStatusInput.cs
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
    #region CheckStatusInput

    public class CheckStatusInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? ShouldSwitchMode
        // GraphQL -> shouldSwitchMode: Boolean (scalar)
        [JsonProperty("shouldSwitchMode")]
        public System.Boolean? ShouldSwitchMode { get; set; }

        //      C# -> System.Boolean? ShouldRunOnlyRscModeTasks
        // GraphQL -> shouldRunOnlyRSCModeTasks: Boolean (scalar)
        [JsonProperty("shouldRunOnlyRSCModeTasks")]
        public System.Boolean? ShouldRunOnlyRscModeTasks { get; set; }

        //      C# -> ClusterMigrationModes? ClusterMigrationMode
        // GraphQL -> clusterMigrationMode: ClusterMigrationModes (enum)
        [JsonProperty("clusterMigrationMode")]
        public ClusterMigrationModes? ClusterMigrationMode { get; set; }


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

    } // class CheckStatusInput
    #endregion

} // namespace RubrikSecurityCloud.Types
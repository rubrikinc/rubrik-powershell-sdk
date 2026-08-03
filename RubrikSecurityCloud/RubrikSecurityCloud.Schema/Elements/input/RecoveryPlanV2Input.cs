// RecoveryPlanV2Input.cs
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
    #region RecoveryPlanV2Input

    public class RecoveryPlanV2Input: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType (enum)
        [JsonProperty("recoveryPlanType")]
        public RecoveryPlanType? RecoveryPlanType { get; set; }

        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType (enum)
        [JsonProperty("workloadType")]
        public ManagedObjectType? WorkloadType { get; set; }

        //      C# -> RecoveryPlanLocationInput? SourceLocation
        // GraphQL -> sourceLocation: RecoveryPlanLocationInput (input)
        [JsonProperty("sourceLocation")]
        public RecoveryPlanLocationInput? SourceLocation { get; set; }

        //      C# -> RecoveryPlanLocationInput? TargetLocation
        // GraphQL -> targetLocation: RecoveryPlanLocationInput (input)
        [JsonProperty("targetLocation")]
        public RecoveryPlanLocationInput? TargetLocation { get; set; }

        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean (scalar)
        [JsonProperty("isHydrationEnabled")]
        public System.Boolean? IsHydrationEnabled { get; set; }

        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean (scalar)
        [JsonProperty("isHidden")]
        public System.Boolean? IsHidden { get; set; }


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

    } // class RecoveryPlanV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types
// InPlaceRecoveryJobConfigV2Input.cs
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
    #region InPlaceRecoveryJobConfigV2Input

    public class InPlaceRecoveryJobConfigV2Input: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldKeepVsphereSnapshotAfterRecovery
        // GraphQL -> shouldKeepVsphereSnapshotAfterRecovery: Boolean (scalar)
        [JsonProperty("shouldKeepVsphereSnapshotAfterRecovery")]
        public System.Boolean? ShouldKeepVsphereSnapshotAfterRecovery { get; set; }

        //      C# -> System.Boolean? ShouldPowerOn
        // GraphQL -> shouldPowerOn: Boolean (scalar)
        [JsonProperty("shouldPowerOn")]
        public System.Boolean? ShouldPowerOn { get; set; }

        //      C# -> RequiredRecoveryParametersInput? RequiredRecoveryParameters
        // GraphQL -> requiredRecoveryParameters: RequiredRecoveryParametersInput (input)
        [JsonProperty("requiredRecoveryParameters")]
        public RequiredRecoveryParametersInput? RequiredRecoveryParameters { get; set; }


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

    } // class InPlaceRecoveryJobConfigV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types
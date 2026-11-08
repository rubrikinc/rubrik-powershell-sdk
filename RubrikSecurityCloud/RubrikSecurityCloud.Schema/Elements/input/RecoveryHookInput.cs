// RecoveryHookInput.cs
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
    #region RecoveryHookInput

    public class RecoveryHookInput: IInput
    {
        #region members

        //      C# -> RecoveryHookInfoInput? HookInfo
        // GraphQL -> hookInfo: RecoveryHookInfoInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("hookInfo")]
        public RecoveryHookInfoInput? HookInfo { get; set; }

        //      C# -> HookFailureHandling? FailureHandling
        // GraphQL -> failureHandling: HookFailureHandling! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("failureHandling")]
        public HookFailureHandling? FailureHandling { get; set; }


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

    } // class RecoveryHookInput
    #endregion

} // namespace RubrikSecurityCloud.Types
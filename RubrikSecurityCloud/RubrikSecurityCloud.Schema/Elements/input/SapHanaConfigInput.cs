// SapHanaConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SapHanaConfigInput

    public class SapHanaConfigInput: IInput
    {
        #region members

        //      C# -> SlaDurationInput? IncrementalFrequency
        // GraphQL -> incrementalFrequency: SlaDurationInput (input)
        [JsonProperty("incrementalFrequency")]
        public SlaDurationInput? IncrementalFrequency { get; set; }

        //      C# -> SlaDurationInput? LogRetention
        // GraphQL -> logRetention: SlaDurationInput (input)
        [JsonProperty("logRetention")]
        public SlaDurationInput? LogRetention { get; set; }

        //      C# -> SlaDurationInput? DifferentialFrequency
        // GraphQL -> differentialFrequency: SlaDurationInput (input)
        [JsonProperty("differentialFrequency")]
        public SlaDurationInput? DifferentialFrequency { get; set; }


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

    } // class SapHanaConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
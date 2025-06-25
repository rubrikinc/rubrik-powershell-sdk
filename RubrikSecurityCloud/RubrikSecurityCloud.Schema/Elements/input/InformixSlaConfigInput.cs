// InformixSlaConfigInput.cs
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
    #region InformixSlaConfigInput

    public class InformixSlaConfigInput: IInput
    {
        #region members

        //      C# -> SlaDurationInput? IncrementalFrequency
        // GraphQL -> incrementalFrequency: SlaDurationInput (input)
        [JsonProperty("incrementalFrequency")]
        public SlaDurationInput? IncrementalFrequency { get; set; }

        //      C# -> SlaDurationInput? IncrementalRetention
        // GraphQL -> incrementalRetention: SlaDurationInput (input)
        [JsonProperty("incrementalRetention")]
        public SlaDurationInput? IncrementalRetention { get; set; }

        //      C# -> SlaDurationInput? LogFrequency
        // GraphQL -> logFrequency: SlaDurationInput (input)
        [JsonProperty("logFrequency")]
        public SlaDurationInput? LogFrequency { get; set; }

        //      C# -> SlaDurationInput? LogRetention
        // GraphQL -> logRetention: SlaDurationInput (input)
        [JsonProperty("logRetention")]
        public SlaDurationInput? LogRetention { get; set; }


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

    } // class InformixSlaConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
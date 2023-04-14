// ArchivalSpecInput.cs
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
    #region ArchivalSpecInput

    public class ArchivalSpecInput: IInput
    {
        #region members

        //      C# -> System.String? ArchivalGroupId
        // GraphQL -> archivalGroupId: String (scalar)
        [JsonProperty("archivalGroupId")]
        public System.String? ArchivalGroupId { get; set; }

        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int (scalar)
        [JsonProperty("threshold")]
        public System.Int32? Threshold { get; set; }

        //      C# -> RetentionUnit? ThresholdUnit
        // GraphQL -> thresholdUnit: RetentionUnit (enum)
        [JsonProperty("thresholdUnit")]
        public RetentionUnit? ThresholdUnit { get; set; }

        //      C# -> ArchivalTieringSpecInput? ArchivalTieringSpecInput
        // GraphQL -> archivalTieringSpecInput: ArchivalTieringSpecInput (input)
        [JsonProperty("archivalTieringSpecInput")]
        public ArchivalTieringSpecInput? ArchivalTieringSpecInput { get; set; }

        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!] (enum)
        [JsonProperty("frequencies")]
        public List<RetentionUnit>? Frequencies { get; set; }

        //      C# -> List<ArchivalLocationToClusterMappingInput>? ArchivalLocationToClusterMapping
        // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMappingInput!] (input)
        [JsonProperty("archivalLocationToClusterMapping")]
        public List<ArchivalLocationToClusterMappingInput>? ArchivalLocationToClusterMapping { get; set; }


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

    } // class ArchivalSpecInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
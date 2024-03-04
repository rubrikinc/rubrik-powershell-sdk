// ResolveAnomalyInput.cs
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
    #region ResolveAnomalyInput

    public class ResolveAnomalyInput: IInput
    {
        #region members

        //      C# -> AnomalyType? AnomalyType
        // GraphQL -> anomalyType: AnomalyType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("anomalyType")]
        public AnomalyType? AnomalyType { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? AnomalyId
        // GraphQL -> anomalyId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("anomalyId")]
        public System.String? AnomalyId { get; set; }

        //      C# -> AnomalyFalsePositiveReport? FalsePositiveReport
        // GraphQL -> falsePositiveReport: AnomalyFalsePositiveReport (input)
        [JsonProperty("falsePositiveReport")]
        public AnomalyFalsePositiveReport? FalsePositiveReport { get; set; }

        //      C# -> List<System.String>? DirectoriesToSnooze
        // GraphQL -> directoriesToSnooze: [String!] (scalar)
        [JsonProperty("directoriesToSnooze")]
        public List<System.String>? DirectoriesToSnooze { get; set; }


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

    } // class ResolveAnomalyInput
    #endregion

} // namespace RubrikSecurityCloud.Types
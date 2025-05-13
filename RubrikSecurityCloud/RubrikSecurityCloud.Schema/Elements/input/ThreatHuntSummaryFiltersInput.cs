// ThreatHuntSummaryFiltersInput.cs
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
    #region ThreatHuntSummaryFiltersInput

    public class ThreatHuntSummaryFiltersInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }

        //      C# -> List<System.String>? CloudProviders
        // GraphQL -> cloudProviders: [String!] (scalar)
        [JsonProperty("cloudProviders")]
        public List<System.String>? CloudProviders { get; set; }

        //      C# -> List<IndicatorOfCompromiseKind>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromiseKind!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("matchTypes")]
        public List<IndicatorOfCompromiseKind>? MatchTypes { get; set; }

        //      C# -> List<ThreatHuntObjectStatus>? ObjectScanStatus
        // GraphQL -> objectScanStatus: [ThreatHuntObjectStatus!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectScanStatus")]
        public List<ThreatHuntObjectStatus>? ObjectScanStatus { get; set; }


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

    } // class ThreatHuntSummaryFiltersInput
    #endregion

} // namespace RubrikSecurityCloud.Types
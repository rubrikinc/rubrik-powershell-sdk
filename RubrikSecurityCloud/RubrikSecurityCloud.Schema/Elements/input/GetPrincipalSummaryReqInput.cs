// GetPrincipalSummaryReqInput.cs
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
    #region GetPrincipalSummaryReqInput

    public class GetPrincipalSummaryReqInput: IInput
    {
        #region members

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? TimelineDate
        // GraphQL -> timelineDate: String (scalar)
        [JsonProperty("timelineDate")]
        public System.String? TimelineDate { get; set; }

        //      C# -> System.Int32? HistoricalDeltaDays
        // GraphQL -> historicalDeltaDays: Int (scalar)
        [JsonProperty("historicalDeltaDays")]
        public System.Int32? HistoricalDeltaDays { get; set; }

        //      C# -> System.Boolean? InsightsMarkerRequested
        // GraphQL -> insightsMarkerRequested: Boolean (scalar)
        [JsonProperty("insightsMarkerRequested")]
        public System.Boolean? InsightsMarkerRequested { get; set; }

        //      C# -> PrincipalFeature? FeatureFilter
        // GraphQL -> featureFilter: PrincipalFeature (enum)
        [JsonProperty("featureFilter")]
        public PrincipalFeature? FeatureFilter { get; set; }

        //      C# -> List<ListApiPermissionsSort>? ApiPermissionsSort
        // GraphQL -> apiPermissionsSort: [ListApiPermissionsSort!] (input)
        [JsonProperty("apiPermissionsSort")]
        public List<ListApiPermissionsSort>? ApiPermissionsSort { get; set; }


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

    } // class GetPrincipalSummaryReqInput
    #endregion

} // namespace RubrikSecurityCloud.Types
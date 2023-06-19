// TaskSummaryFilterInput.cs
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
    #region TaskSummaryFilterInput

    public class TaskSummaryFilterInput: IInput
    {
        #region members

        //      C# -> CommonClusterFilterInput? Cluster
        // GraphQL -> cluster: CommonClusterFilterInput (input)
        [JsonProperty("cluster")]
        public CommonClusterFilterInput? Cluster { get; set; }

        //      C# -> SnappableSlaDomainFilterInput? SlaDomain
        // GraphQL -> slaDomain: SnappableSlaDomainFilterInput (input)
        [JsonProperty("slaDomain")]
        public SnappableSlaDomainFilterInput? SlaDomain { get; set; }

        //      C# -> List<ObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
        [JsonProperty("objectType")]
        public List<ObjectTypeEnum>? ObjectType { get; set; }

        //      C# -> DateTime? TimeGt
        // GraphQL -> time_gt: DateTime (scalar)
        [JsonProperty("time_gt")]
        public DateTime? TimeGt { get; set; }

        //      C# -> DateTime? TimeLt
        // GraphQL -> time_lt: DateTime (scalar)
        [JsonProperty("time_lt")]
        public DateTime? TimeLt { get; set; }


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

    } // class TaskSummaryFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types
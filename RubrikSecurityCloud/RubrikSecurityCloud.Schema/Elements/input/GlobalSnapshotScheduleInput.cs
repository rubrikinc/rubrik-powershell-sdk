// GlobalSnapshotScheduleInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region GlobalSnapshotScheduleInput

    public class GlobalSnapshotScheduleInput
    {
        #region members
        //      C# -> MinuteSnapshotScheduleInput? Minute
        // GraphQL -> minute: MinuteSnapshotScheduleInput (input)
        [JsonProperty("minute")]
        public MinuteSnapshotScheduleInput? Minute { get; set; }

        //      C# -> HourlySnapshotScheduleInput? Hourly
        // GraphQL -> hourly: HourlySnapshotScheduleInput (input)
        [JsonProperty("hourly")]
        public HourlySnapshotScheduleInput? Hourly { get; set; }

        //      C# -> DailySnapshotScheduleInput? Daily
        // GraphQL -> daily: DailySnapshotScheduleInput (input)
        [JsonProperty("daily")]
        public DailySnapshotScheduleInput? Daily { get; set; }

        //      C# -> WeeklySnapshotScheduleInput? Weekly
        // GraphQL -> weekly: WeeklySnapshotScheduleInput (input)
        [JsonProperty("weekly")]
        public WeeklySnapshotScheduleInput? Weekly { get; set; }

        //      C# -> MonthlySnapshotScheduleInput? Monthly
        // GraphQL -> monthly: MonthlySnapshotScheduleInput (input)
        [JsonProperty("monthly")]
        public MonthlySnapshotScheduleInput? Monthly { get; set; }

        //      C# -> QuarterlySnapshotScheduleInput? Quarterly
        // GraphQL -> quarterly: QuarterlySnapshotScheduleInput (input)
        [JsonProperty("quarterly")]
        public QuarterlySnapshotScheduleInput? Quarterly { get; set; }

        //      C# -> YearlySnapshotScheduleInput? Yearly
        // GraphQL -> yearly: YearlySnapshotScheduleInput (input)
        [JsonProperty("yearly")]
        public YearlySnapshotScheduleInput? Yearly { get; set; }

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

    } // class GlobalSnapshotScheduleInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
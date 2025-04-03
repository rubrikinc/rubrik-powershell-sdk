// NcdConfigInput.cs
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
    #region NcdConfigInput

    public class NcdConfigInput: IInput
    {
        #region members

        //      C# -> List<System.String>? MinutelyBackupLocations
        // GraphQL -> minutelyBackupLocations: [UUID!] (scalar)
        [JsonProperty("minutelyBackupLocations")]
        public List<System.String>? MinutelyBackupLocations { get; set; }

        //      C# -> List<System.String>? HourlyBackupLocations
        // GraphQL -> hourlyBackupLocations: [UUID!] (scalar)
        [JsonProperty("hourlyBackupLocations")]
        public List<System.String>? HourlyBackupLocations { get; set; }

        //      C# -> List<System.String>? DailyBackupLocations
        // GraphQL -> dailyBackupLocations: [UUID!] (scalar)
        [JsonProperty("dailyBackupLocations")]
        public List<System.String>? DailyBackupLocations { get; set; }

        //      C# -> List<System.String>? WeeklyBackupLocations
        // GraphQL -> weeklyBackupLocations: [UUID!] (scalar)
        [JsonProperty("weeklyBackupLocations")]
        public List<System.String>? WeeklyBackupLocations { get; set; }

        //      C# -> List<System.String>? MonthlyBackupLocations
        // GraphQL -> monthlyBackupLocations: [UUID!] (scalar)
        [JsonProperty("monthlyBackupLocations")]
        public List<System.String>? MonthlyBackupLocations { get; set; }

        //      C# -> List<System.String>? QuarterlyBackupLocations
        // GraphQL -> quarterlyBackupLocations: [UUID!] (scalar)
        [JsonProperty("quarterlyBackupLocations")]
        public List<System.String>? QuarterlyBackupLocations { get; set; }

        //      C# -> List<System.String>? YearlyBackupLocations
        // GraphQL -> yearlyBackupLocations: [UUID!] (scalar)
        [JsonProperty("yearlyBackupLocations")]
        public List<System.String>? YearlyBackupLocations { get; set; }


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

    } // class NcdConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
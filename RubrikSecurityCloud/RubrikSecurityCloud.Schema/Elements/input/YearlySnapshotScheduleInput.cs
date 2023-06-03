// YearlySnapshotScheduleInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region YearlySnapshotScheduleInput

    public class YearlySnapshotScheduleInput: IInput
    {
        #region members

        //      C# -> BasicSnapshotScheduleInput? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotScheduleInput (input)
        [JsonProperty("basicSchedule")]
        public BasicSnapshotScheduleInput? BasicSchedule { get; set; }

        //      C# -> DayOfYear? DayOfYear
        // GraphQL -> dayOfYear: DayOfYear (enum)
        [JsonProperty("dayOfYear")]
        public DayOfYear? DayOfYear { get; set; }

        //      C# -> Month? YearStartMonth
        // GraphQL -> yearStartMonth: Month (enum)
        [JsonProperty("yearStartMonth")]
        public Month? YearStartMonth { get; set; }


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

    } // class YearlySnapshotScheduleInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
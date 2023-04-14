// StartTimeAttributesInput.cs
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
    #region StartTimeAttributesInput

    public class StartTimeAttributesInput: IInput
    {
        #region members

        //      C# -> DayOfWeekOptInput? DayOfWeek
        // GraphQL -> dayOfWeek: DayOfWeekOptInput (input)
        [JsonProperty("dayOfWeek")]
        public DayOfWeekOptInput? DayOfWeek { get; set; }

        //      C# -> System.Int32? Hour
        // GraphQL -> hour: Int (scalar)
        [JsonProperty("hour")]
        public System.Int32? Hour { get; set; }

        //      C# -> System.Int32? Minute
        // GraphQL -> minute: Int (scalar)
        [JsonProperty("minute")]
        public System.Int32? Minute { get; set; }


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

    } // class StartTimeAttributesInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
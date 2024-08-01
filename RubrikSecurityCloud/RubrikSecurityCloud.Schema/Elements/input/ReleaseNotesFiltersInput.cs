// ReleaseNotesFiltersInput.cs
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
    #region ReleaseNotesFiltersInput

    public class ReleaseNotesFiltersInput: IInput
    {
        #region members

        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime (scalar)
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        //      C# -> List<ReleaseNoteTypeType>? Types
        // GraphQL -> types: [ReleaseNoteTypeType!] (enum)
        [JsonProperty("types")]
        public List<ReleaseNoteTypeType>? Types { get; set; }


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

    } // class ReleaseNotesFiltersInput
    #endregion

} // namespace RubrikSecurityCloud.Types
// CascadingArchivalSpecInput.cs
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
    #region CascadingArchivalSpecInput

    public class CascadingArchivalSpecInput: IInput
    {
        #region members

        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String (scalar)
        [JsonProperty("archivalLocationId")]
        public System.String? ArchivalLocationId { get; set; }

        //      C# -> SlaDurationInput? ArchivalThreshold
        // GraphQL -> archivalThreshold: SlaDurationInput (input)
        [JsonProperty("archivalThreshold")]
        public SlaDurationInput? ArchivalThreshold { get; set; }

        //      C# -> ArchivalTieringSpecInput? ArchivalTieringSpecInput
        // GraphQL -> archivalTieringSpecInput: ArchivalTieringSpecInput (input)
        [JsonProperty("archivalTieringSpecInput")]
        public ArchivalTieringSpecInput? ArchivalTieringSpecInput { get; set; }

        //      C# -> List<RetentionUnit>? Frequency
        // GraphQL -> frequency: [RetentionUnit!] (enum)
        [JsonProperty("frequency")]
        public List<RetentionUnit>? Frequency { get; set; }


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

    } // class CascadingArchivalSpecInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
// TicketFieldValueInput.cs
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
    #region TicketFieldValueInput

    public class TicketFieldValueInput: IInput
    {
        #region members

        //      C# -> TicketFieldType? FieldType
        // GraphQL -> fieldType: TicketFieldType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("fieldType")]
        public TicketFieldType? FieldType { get; set; }

        //      C# -> System.String? StringValue
        // GraphQL -> stringValue: String (scalar)
        [JsonProperty("stringValue")]
        public System.String? StringValue { get; set; }

        //      C# -> System.Int64? NumberValue
        // GraphQL -> numberValue: Long (scalar)
        [JsonProperty("numberValue")]
        public System.Int64? NumberValue { get; set; }

        //      C# -> System.String? OptionValue
        // GraphQL -> optionValue: String (scalar)
        [JsonProperty("optionValue")]
        public System.String? OptionValue { get; set; }

        //      C# -> StringArrayInput? MultiOptionValues
        // GraphQL -> multiOptionValues: StringArrayInput (input)
        [JsonProperty("multiOptionValues")]
        public StringArrayInput? MultiOptionValues { get; set; }

        //      C# -> StringArrayInput? ArrayValues
        // GraphQL -> arrayValues: StringArrayInput (input)
        [JsonProperty("arrayValues")]
        public StringArrayInput? ArrayValues { get; set; }

        //      C# -> System.String? UserValue
        // GraphQL -> userValue: String (scalar)
        [JsonProperty("userValue")]
        public System.String? UserValue { get; set; }

        //      C# -> System.String? DateValue
        // GraphQL -> dateValue: String (scalar)
        [JsonProperty("dateValue")]
        public System.String? DateValue { get; set; }

        //      C# -> System.String? DatetimeValue
        // GraphQL -> datetimeValue: String (scalar)
        [JsonProperty("datetimeValue")]
        public System.String? DatetimeValue { get; set; }

        //      C# -> System.Boolean? BooleanValue
        // GraphQL -> booleanValue: Boolean (scalar)
        [JsonProperty("booleanValue")]
        public System.Boolean? BooleanValue { get; set; }

        //      C# -> System.String? TextAreaValue
        // GraphQL -> textAreaValue: String (scalar)
        [JsonProperty("textAreaValue")]
        public System.String? TextAreaValue { get; set; }


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

    } // class TicketFieldValueInput
    #endregion

} // namespace RubrikSecurityCloud.Types
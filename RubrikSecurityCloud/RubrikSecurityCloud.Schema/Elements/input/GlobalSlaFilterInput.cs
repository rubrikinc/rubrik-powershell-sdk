// GlobalSlaFilterInput.cs
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
    #region GlobalSlaFilterInput

    public class GlobalSlaFilterInput: IInput
    {
        #region members

        //      C# -> GlobalSlaQueryFilterInputField? Field
        // GraphQL -> field: GlobalSlaQueryFilterInputField (enum)
        [JsonProperty("field")]
        public GlobalSlaQueryFilterInputField? Field { get; set; }

        //      C# -> System.String? Text
        // GraphQL -> text: String (scalar)
        [JsonProperty("text")]
        public System.String? Text { get; set; }

        //      C# -> List<SlaObjectType>? ObjectTypeList
        // GraphQL -> objectTypeList: [SlaObjectType!] (enum)
        [JsonProperty("objectTypeList")]
        public List<SlaObjectType>? ObjectTypeList { get; set; }

        //      C# -> List<System.String>? TextList
        // GraphQL -> textList: [String!] (scalar)
        [JsonProperty("textList")]
        public List<System.String>? TextList { get; set; }


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

    } // class GlobalSlaFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types
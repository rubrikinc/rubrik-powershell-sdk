// SnapshotQueryFilterInput.cs
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
    #region SnapshotQueryFilterInput

    public class SnapshotQueryFilterInput: IInput
    {
        #region members

        //      C# -> SnapshotQueryFilterField? Field
        // GraphQL -> field: SnapshotQueryFilterField (enum)
        [JsonProperty("field")]
        public SnapshotQueryFilterField? Field { get; set; }

        //      C# -> System.String? Text
        // GraphQL -> text: String (scalar)
        [JsonProperty("text")]
        public System.String? Text { get; set; }

        //      C# -> List<SnapshotTypeEnum>? TypeFilters
        // GraphQL -> typeFilters: [SnapshotTypeEnum!] (enum)
        [JsonProperty("typeFilters")]
        public List<SnapshotTypeEnum>? TypeFilters { get; set; }

        //      C# -> System.Boolean? ShouldFetchLinked
        // GraphQL -> shouldFetchLinked: Boolean (scalar)
        [JsonProperty("shouldFetchLinked")]
        public System.Boolean? ShouldFetchLinked { get; set; }

        //      C# -> List<System.String>? TextList
        // GraphQL -> textList: [String!] (scalar)
        [JsonProperty("textList")]
        public List<System.String>? TextList { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> List<SnapshotCustomization>? CustomizationFilters
        // GraphQL -> customizationFilters: [SnapshotCustomization!] (enum)
        [JsonProperty("customizationFilters")]
        public List<SnapshotCustomization>? CustomizationFilters { get; set; }


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

    } // class SnapshotQueryFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
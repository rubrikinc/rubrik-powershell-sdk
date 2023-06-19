// SearchFilter.cs
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
    #region SearchFilter

    public class SearchFilter: IInput
    {
        #region members

        //      C# -> SearchKeywordFilter? SearchKeywordFilter
        // GraphQL -> searchKeywordFilter: SearchKeywordFilter (input)
        [JsonProperty("searchKeywordFilter")]
        public SearchKeywordFilter? SearchKeywordFilter { get; set; }

        //      C# -> List<EmailAddressFilter>? EmailAddresses
        // GraphQL -> emailAddresses: [EmailAddressFilter!] (input)
        [JsonProperty("emailAddresses")]
        public List<EmailAddressFilter>? EmailAddresses { get; set; }

        //      C# -> DateTime? FromTime
        // GraphQL -> fromTime: DateTime (scalar)
        [JsonProperty("fromTime")]
        public DateTime? FromTime { get; set; }

        //      C# -> DateTime? UntilTime
        // GraphQL -> untilTime: DateTime (scalar)
        [JsonProperty("untilTime")]
        public DateTime? UntilTime { get; set; }

        //      C# -> SearchObjectFilter? SearchObjectFilter
        // GraphQL -> searchObjectFilter: SearchObjectFilter (input)
        [JsonProperty("searchObjectFilter")]
        public SearchObjectFilter? SearchObjectFilter { get; set; }


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

    } // class SearchFilter
    #endregion

} // namespace RubrikSecurityCloud.Types
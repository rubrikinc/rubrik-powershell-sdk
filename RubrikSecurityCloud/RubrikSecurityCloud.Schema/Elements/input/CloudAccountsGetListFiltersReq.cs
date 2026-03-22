// CloudAccountsGetListFiltersReq.cs
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
    #region CloudAccountsGetListFiltersReq

    public class CloudAccountsGetListFiltersReq: IInput
    {
        #region members

        //      C# -> CloudVendor? CloudVendor
        // GraphQL -> cloudVendor: CloudVendor (enum)
        [JsonProperty("cloudVendor")]
        public CloudVendor? CloudVendor { get; set; }

        //      C# -> List<CloudAccountFilterType>? FilterTypes
        // GraphQL -> filterTypes: [CloudAccountFilterType!] (enum)
        [JsonProperty("filterTypes")]
        public List<CloudAccountFilterType>? FilterTypes { get; set; }


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

    } // class CloudAccountsGetListFiltersReq
    #endregion

} // namespace RubrikSecurityCloud.Types
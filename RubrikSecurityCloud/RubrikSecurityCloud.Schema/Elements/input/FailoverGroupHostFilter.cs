// FailoverGroupHostFilter.cs
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
    #region FailoverGroupHostFilter

    public class FailoverGroupHostFilter: IInput
    {
        #region members

        //      C# -> List<HostRegisterOsType>? HostType
        // GraphQL -> hostType: [HostRegisterOsType!] (enum)
        [JsonProperty("hostType")]
        public List<HostRegisterOsType>? HostType { get; set; }

        //      C# -> List<FailoverGroupStatus>? HostStatus
        // GraphQL -> hostStatus: [FailoverGroupStatus!] (enum)
        [JsonProperty("hostStatus")]
        public List<FailoverGroupStatus>? HostStatus { get; set; }


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

    } // class FailoverGroupHostFilter
    #endregion

} // namespace RubrikSecurityCloud.Types
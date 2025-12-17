// FailoverGroupWorkloadFilter.cs
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
    #region FailoverGroupWorkloadFilter

    public class FailoverGroupWorkloadFilter: IInput
    {
        #region members

        //      C# -> List<System.String>? ActiveClusterUuid
        // GraphQL -> activeClusterUuid: [UUID!] (scalar)
        [JsonProperty("activeClusterUuid")]
        public List<System.String>? ActiveClusterUuid { get; set; }

        //      C# -> List<FailoverGroupObjectStatus>? ObjectStatus
        // GraphQL -> objectStatus: [FailoverGroupObjectStatus!] (enum)
        [JsonProperty("objectStatus")]
        public List<FailoverGroupObjectStatus>? ObjectStatus { get; set; }

        //      C# -> List<System.String>? Host
        // GraphQL -> host: [UUID!] (scalar)
        [JsonProperty("host")]
        public List<System.String>? Host { get; set; }


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

    } // class FailoverGroupWorkloadFilter
    #endregion

} // namespace RubrikSecurityCloud.Types
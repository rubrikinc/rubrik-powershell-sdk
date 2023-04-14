// AwsNativeEc2InstanceTypeFilter.cs
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
    #region AwsNativeEc2InstanceTypeFilter

    public class AwsNativeEc2InstanceTypeFilter: IInput
    {
        #region members

        //      C# -> List<AwsNativeEc2InstanceType>? Ec2InstanceTypes
        // GraphQL -> ec2InstanceTypes: [AwsNativeEc2InstanceType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("ec2InstanceTypes")]
        public List<AwsNativeEc2InstanceType>? Ec2InstanceTypes { get; set; }


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

    } // class AwsNativeEc2InstanceTypeFilter
    #endregion

} // namespace Rubrik.SecurityCloud.Types
// UpdateIocStatusInput.cs
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
    #region UpdateIocStatusInput

    public class UpdateIocStatusInput: IInput
    {
        #region members

        //      C# -> IocOperation? Operation
        // GraphQL -> operation: IocOperation! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("operation")]
        public IocOperation? Operation { get; set; }

        //      C# -> IocHashOnly? IocHashOnly
        // GraphQL -> iocHashOnly: IocHashOnly (input)
        [JsonProperty("iocHashOnly")]
        public IocHashOnly? IocHashOnly { get; set; }

        //      C# -> IocHashWithProvider? IocHashWithProvider
        // GraphQL -> iocHashWithProvider: IocHashWithProvider (input)
        [JsonProperty("iocHashWithProvider")]
        public IocHashWithProvider? IocHashWithProvider { get; set; }

        //      C# -> IocProviderWithThreatFeedType? IocProviderWithThreatFeedType
        // GraphQL -> iocProviderWithThreatFeedType: IocProviderWithThreatFeedType (input)
        [JsonProperty("iocProviderWithThreatFeedType")]
        public IocProviderWithThreatFeedType? IocProviderWithThreatFeedType { get; set; }


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

    } // class UpdateIocStatusInput
    #endregion

} // namespace RubrikSecurityCloud.Types
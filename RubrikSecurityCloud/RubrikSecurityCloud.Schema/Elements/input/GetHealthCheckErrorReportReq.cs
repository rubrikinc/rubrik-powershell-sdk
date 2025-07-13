// GetHealthCheckErrorReportReq.cs
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
    #region GetHealthCheckErrorReportReq

    public class GetHealthCheckErrorReportReq: IInput
    {
        #region members

        //      C# -> System.String? ExocomputeConfigId
        // GraphQL -> exocomputeConfigId: String (scalar)
        [JsonProperty("exocomputeConfigId")]
        public System.String? ExocomputeConfigId { get; set; }

        //      C# -> System.String? CheckType
        // GraphQL -> checkType: String (scalar)
        [JsonProperty("checkType")]
        public System.String? CheckType { get; set; }

        //      C# -> ExocomputeCloudType? CloudVendor
        // GraphQL -> cloudVendor: ExocomputeCloudType (enum)
        [JsonProperty("cloudVendor")]
        public ExocomputeCloudType? CloudVendor { get; set; }


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

    } // class GetHealthCheckErrorReportReq
    #endregion

} // namespace RubrikSecurityCloud.Types
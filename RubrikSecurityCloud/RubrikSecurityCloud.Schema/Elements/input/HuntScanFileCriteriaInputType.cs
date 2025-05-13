// HuntScanFileCriteriaInputType.cs
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
    #region HuntScanFileCriteriaInputType

    public class HuntScanFileCriteriaInputType: IInput
    {
        #region members

        //      C# -> HuntScanFileSizeLimitsInputType? FileSizeLimits
        // GraphQL -> fileSizeLimits: HuntScanFileSizeLimitsInputType (input)
        [JsonProperty("fileSizeLimits")]
        public HuntScanFileSizeLimitsInputType? FileSizeLimits { get; set; }

        //      C# -> HuntScanFileTimeLimitsInputType? FileTimeLimits
        // GraphQL -> fileTimeLimits: HuntScanFileTimeLimitsInputType (input)
        [JsonProperty("fileTimeLimits")]
        public HuntScanFileTimeLimitsInputType? FileTimeLimits { get; set; }

        //      C# -> HuntScanPathFiltersInputType? PathFilter
        // GraphQL -> pathFilter: HuntScanPathFiltersInputType (input)
        [JsonProperty("pathFilter")]
        public HuntScanPathFiltersInputType? PathFilter { get; set; }


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

    } // class HuntScanFileCriteriaInputType
    #endregion

} // namespace RubrikSecurityCloud.Types
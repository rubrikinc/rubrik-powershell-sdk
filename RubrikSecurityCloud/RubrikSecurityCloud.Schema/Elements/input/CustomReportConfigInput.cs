// CustomReportConfigInput.cs
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
    #region CustomReportConfigInput

    public class CustomReportConfigInput: IInput
    {
        #region members

        //      C# -> NgAlphaReportConfigInput? NgAlphaConfig
        // GraphQL -> ngAlphaConfig: NgAlphaReportConfigInput (input)
        [JsonProperty("ngAlphaConfig")]
        public NgAlphaReportConfigInput? NgAlphaConfig { get; set; }

        //      C# -> NgReportConfigInput? NgConfig
        // GraphQL -> ngConfig: NgReportConfigInput (input)
        [JsonProperty("ngConfig")]
        public NgReportConfigInput? NgConfig { get; set; }

        //      C# -> ReportVersionType? ReportVersion
        // GraphQL -> reportVersion: ReportVersionType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("reportVersion")]
        public ReportVersionType? ReportVersion { get; set; }


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

    } // class CustomReportConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
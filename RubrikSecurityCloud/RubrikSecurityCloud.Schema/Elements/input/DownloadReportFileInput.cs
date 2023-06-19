// DownloadReportFileInput.cs
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
    #region DownloadReportFileInput

    public class DownloadReportFileInput: IInput
    {
        #region members

        //      C# -> FileTypeEnum? FileType
        // GraphQL -> fileType: FileTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("fileType")]
        public FileTypeEnum? FileType { get; set; }

        //      C# -> System.Int64? ReportId
        // GraphQL -> reportId: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("reportId")]
        public System.Int64? ReportId { get; set; }

        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        [JsonProperty("timezone")]
        public System.String? Timezone { get; set; }

        //      C# -> CustomReportConfigInput? Config
        // GraphQL -> config: CustomReportConfigInput (input)
        [JsonProperty("config")]
        public CustomReportConfigInput? Config { get; set; }


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

    } // class DownloadReportFileInput
    #endregion

} // namespace RubrikSecurityCloud.Types
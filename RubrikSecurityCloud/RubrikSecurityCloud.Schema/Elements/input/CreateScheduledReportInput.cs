// CreateScheduledReportInput.cs
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
    #region CreateScheduledReportInput

    public class CreateScheduledReportInput: IInput
    {
        #region members

        //      C# -> System.Int32? ReportId
        // GraphQL -> reportId: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("reportId")]
        public System.Int32? ReportId { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> DateTime? DailyTime
        // GraphQL -> dailyTime: LocalTime (scalar)
        [JsonProperty("dailyTime")]
        public DateTime? DailyTime { get; set; }

        //      C# -> DateTime? WeeklyTime
        // GraphQL -> weeklyTime: LocalTime (scalar)
        [JsonProperty("weeklyTime")]
        public DateTime? WeeklyTime { get; set; }

        //      C# -> System.Int32? MonthlyDate
        // GraphQL -> monthlyDate: Int (scalar)
        [JsonProperty("monthlyDate")]
        public System.Int32? MonthlyDate { get; set; }

        //      C# -> DateTime? MonthlyTime
        // GraphQL -> monthlyTime: LocalTime (scalar)
        [JsonProperty("monthlyTime")]
        public DateTime? MonthlyTime { get; set; }

        //      C# -> List<System.String>? RubrikRecipientUserIds
        // GraphQL -> rubrikRecipientUserIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("rubrikRecipientUserIds")]
        public List<System.String>? RubrikRecipientUserIds { get; set; }

        //      C# -> List<System.String>? NonRubrikRecipientEmails
        // GraphQL -> nonRubrikRecipientEmails: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nonRubrikRecipientEmails")]
        public List<System.String>? NonRubrikRecipientEmails { get; set; }

        //      C# -> System.Boolean? UpdateCreator
        // GraphQL -> updateCreator: Boolean (scalar)
        [JsonProperty("updateCreator")]
        public System.Boolean? UpdateCreator { get; set; }

        //      C# -> List<WeekDay>? WeeklyDays
        // GraphQL -> weeklyDays: [WeekDay!] (enum)
        [JsonProperty("weeklyDays")]
        public List<WeekDay>? WeeklyDays { get; set; }

        //      C# -> List<ReportAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [ReportAttachmentType!] (enum)
        [JsonProperty("attachmentTypes")]
        public List<ReportAttachmentType>? AttachmentTypes { get; set; }


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

    } // class CreateScheduledReportInput
    #endregion

} // namespace RubrikSecurityCloud.Types
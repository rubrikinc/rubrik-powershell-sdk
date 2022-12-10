// ScheduledReport.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:59.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region ScheduledReport
    public class ScheduledReport: IFragment
    {
        #region members
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> DateTime? DailyTime
        // GraphQL -> dailyTime: LocalTime (scalar)
        [JsonProperty("dailyTime")]
        public DateTime? DailyTime { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime! (scalar)
        [JsonProperty("lastUpdatedAt")]
        public DateTime? LastUpdatedAt { get; set; }

        //      C# -> System.Int32? MonthlyDate
        // GraphQL -> monthlyDate: Int (scalar)
        [JsonProperty("monthlyDate")]
        public System.Int32? MonthlyDate { get; set; }

        //      C# -> DateTime? MonthlyTime
        // GraphQL -> monthlyTime: LocalTime (scalar)
        [JsonProperty("monthlyTime")]
        public DateTime? MonthlyTime { get; set; }

        //      C# -> List<System.String>? RecipientEmails
        // GraphQL -> recipientEmails: [String!]! (scalar)
        [JsonProperty("recipientEmails")]
        public List<System.String>? RecipientEmails { get; set; }

        //      C# -> System.Int32? ReportId
        // GraphQL -> reportId: Int! (scalar)
        [JsonProperty("reportId")]
        public System.Int32? ReportId { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> DateTime? WeeklyTime
        // GraphQL -> weeklyTime: LocalTime (scalar)
        [JsonProperty("weeklyTime")]
        public DateTime? WeeklyTime { get; set; }

        //      C# -> User? Creator
        // GraphQL -> creator: User! (type)
        [JsonProperty("creator")]
        public User? Creator { get; set; }

        //      C# -> User? LastEditor
        // GraphQL -> lastEditor: User! (type)
        [JsonProperty("lastEditor")]
        public User? LastEditor { get; set; }

        //      C# -> List<User>? RubrikRecipientUsers
        // GraphQL -> rubrikRecipientUsers: [User!]! (type)
        [JsonProperty("rubrikRecipientUsers")]
        public List<User>? RubrikRecipientUsers { get; set; }

        //      C# -> List<ReportAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [ReportAttachmentType!]! (enum)
        [JsonProperty("attachmentTypes")]
        public List<ReportAttachmentType>? AttachmentTypes { get; set; }

        //      C# -> List<WeekDay>? WeeklyDays
        // GraphQL -> weeklyDays: [WeekDay!] (enum)
        [JsonProperty("weeklyDays")]
        public List<WeekDay>? WeeklyDays { get; set; }

        #endregion

    #region methods

    public ScheduledReport Set(
        DateTime? CreatedAt = null,
        DateTime? DailyTime = null,
        System.Int64? Id = null,
        DateTime? LastUpdatedAt = null,
        System.Int32? MonthlyDate = null,
        DateTime? MonthlyTime = null,
        List<System.String>? RecipientEmails = null,
        System.Int32? ReportId = null,
        System.String? Title = null,
        DateTime? WeeklyTime = null,
        User? Creator = null,
        User? LastEditor = null,
        List<User>? RubrikRecipientUsers = null,
        List<ReportAttachmentType>? AttachmentTypes = null,
        List<WeekDay>? WeeklyDays = null
    ) 
    {
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( DailyTime != null ) {
            this.DailyTime = DailyTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastUpdatedAt != null ) {
            this.LastUpdatedAt = LastUpdatedAt;
        }
        if ( MonthlyDate != null ) {
            this.MonthlyDate = MonthlyDate;
        }
        if ( MonthlyTime != null ) {
            this.MonthlyTime = MonthlyTime;
        }
        if ( RecipientEmails != null ) {
            this.RecipientEmails = RecipientEmails;
        }
        if ( ReportId != null ) {
            this.ReportId = ReportId;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( WeeklyTime != null ) {
            this.WeeklyTime = WeeklyTime;
        }
        if ( Creator != null ) {
            this.Creator = Creator;
        }
        if ( LastEditor != null ) {
            this.LastEditor = LastEditor;
        }
        if ( RubrikRecipientUsers != null ) {
            this.RubrikRecipientUsers = RubrikRecipientUsers;
        }
        if ( AttachmentTypes != null ) {
            this.AttachmentTypes = AttachmentTypes;
        }
        if ( WeeklyDays != null ) {
            this.WeeklyDays = WeeklyDays;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime! (scalar)
            if (this.CreatedAt != null)
            {
                 s += ind + "createdAt\n";

            }
            //      C# -> DateTime? DailyTime
            // GraphQL -> dailyTime: LocalTime (scalar)
            if (this.DailyTime != null)
            {
                 s += ind + "dailyTime\n";

            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> DateTime? LastUpdatedAt
            // GraphQL -> lastUpdatedAt: DateTime! (scalar)
            if (this.LastUpdatedAt != null)
            {
                 s += ind + "lastUpdatedAt\n";

            }
            //      C# -> System.Int32? MonthlyDate
            // GraphQL -> monthlyDate: Int (scalar)
            if (this.MonthlyDate != null)
            {
                 s += ind + "monthlyDate\n";

            }
            //      C# -> DateTime? MonthlyTime
            // GraphQL -> monthlyTime: LocalTime (scalar)
            if (this.MonthlyTime != null)
            {
                 s += ind + "monthlyTime\n";

            }
            //      C# -> List<System.String>? RecipientEmails
            // GraphQL -> recipientEmails: [String!]! (scalar)
            if (this.RecipientEmails != null)
            {
                 s += ind + "recipientEmails\n";

            }
            //      C# -> System.Int32? ReportId
            // GraphQL -> reportId: Int! (scalar)
            if (this.ReportId != null)
            {
                 s += ind + "reportId\n";

            }
            //      C# -> System.String? Title
            // GraphQL -> title: String! (scalar)
            if (this.Title != null)
            {
                 s += ind + "title\n";

            }
            //      C# -> DateTime? WeeklyTime
            // GraphQL -> weeklyTime: LocalTime (scalar)
            if (this.WeeklyTime != null)
            {
                 s += ind + "weeklyTime\n";

            }
            //      C# -> User? Creator
            // GraphQL -> creator: User! (type)
            if (this.Creator != null)
            {
                 s += ind + "creator\n";

                 s += ind + "{\n" + 
                 this.Creator.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> User? LastEditor
            // GraphQL -> lastEditor: User! (type)
            if (this.LastEditor != null)
            {
                 s += ind + "lastEditor\n";

                 s += ind + "{\n" + 
                 this.LastEditor.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<User>? RubrikRecipientUsers
            // GraphQL -> rubrikRecipientUsers: [User!]! (type)
            if (this.RubrikRecipientUsers != null)
            {
                 s += ind + "rubrikRecipientUsers\n";

                 s += ind + "{\n" + 
                 this.RubrikRecipientUsers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ReportAttachmentType>? AttachmentTypes
            // GraphQL -> attachmentTypes: [ReportAttachmentType!]! (enum)
            if (this.AttachmentTypes != null)
            {
                 s += ind + "attachmentTypes\n";

            }
            //      C# -> List<WeekDay>? WeeklyDays
            // GraphQL -> weeklyDays: [WeekDay!] (enum)
            if (this.WeeklyDays != null)
            {
                 s += ind + "weeklyDays\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime! (scalar)
            if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt$"))
            {
                this.CreatedAt = new DateTime();
            }
            //      C# -> DateTime? DailyTime
            // GraphQL -> dailyTime: LocalTime (scalar)
            if (this.DailyTime == null && Exploration.Includes(parent + ".dailyTime$"))
            {
                this.DailyTime = new DateTime();
            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.Int64();
            }
            //      C# -> DateTime? LastUpdatedAt
            // GraphQL -> lastUpdatedAt: DateTime! (scalar)
            if (this.LastUpdatedAt == null && Exploration.Includes(parent + ".lastUpdatedAt$"))
            {
                this.LastUpdatedAt = new DateTime();
            }
            //      C# -> System.Int32? MonthlyDate
            // GraphQL -> monthlyDate: Int (scalar)
            if (this.MonthlyDate == null && Exploration.Includes(parent + ".monthlyDate$"))
            {
                this.MonthlyDate = new System.Int32();
            }
            //      C# -> DateTime? MonthlyTime
            // GraphQL -> monthlyTime: LocalTime (scalar)
            if (this.MonthlyTime == null && Exploration.Includes(parent + ".monthlyTime$"))
            {
                this.MonthlyTime = new DateTime();
            }
            //      C# -> List<System.String>? RecipientEmails
            // GraphQL -> recipientEmails: [String!]! (scalar)
            if (this.RecipientEmails == null && Exploration.Includes(parent + ".recipientEmails$"))
            {
                this.RecipientEmails = new List<System.String>();
            }
            //      C# -> System.Int32? ReportId
            // GraphQL -> reportId: Int! (scalar)
            if (this.ReportId == null && Exploration.Includes(parent + ".reportId$"))
            {
                this.ReportId = new System.Int32();
            }
            //      C# -> System.String? Title
            // GraphQL -> title: String! (scalar)
            if (this.Title == null && Exploration.Includes(parent + ".title$"))
            {
                this.Title = new System.String("FETCH");
            }
            //      C# -> DateTime? WeeklyTime
            // GraphQL -> weeklyTime: LocalTime (scalar)
            if (this.WeeklyTime == null && Exploration.Includes(parent + ".weeklyTime$"))
            {
                this.WeeklyTime = new DateTime();
            }
            //      C# -> User? Creator
            // GraphQL -> creator: User! (type)
            if (this.Creator == null && Exploration.Includes(parent + ".creator"))
            {
                this.Creator = new User();
                this.Creator.ApplyExploratoryFragment(parent + ".creator");
            }
            //      C# -> User? LastEditor
            // GraphQL -> lastEditor: User! (type)
            if (this.LastEditor == null && Exploration.Includes(parent + ".lastEditor"))
            {
                this.LastEditor = new User();
                this.LastEditor.ApplyExploratoryFragment(parent + ".lastEditor");
            }
            //      C# -> List<User>? RubrikRecipientUsers
            // GraphQL -> rubrikRecipientUsers: [User!]! (type)
            if (this.RubrikRecipientUsers == null && Exploration.Includes(parent + ".rubrikRecipientUsers"))
            {
                this.RubrikRecipientUsers = new List<User>();
                this.RubrikRecipientUsers.ApplyExploratoryFragment(parent + ".rubrikRecipientUsers");
            }
            //      C# -> List<ReportAttachmentType>? AttachmentTypes
            // GraphQL -> attachmentTypes: [ReportAttachmentType!]! (enum)
            if (this.AttachmentTypes == null && Exploration.Includes(parent + ".attachmentTypes$"))
            {
                this.AttachmentTypes = new List<ReportAttachmentType>();
            }
            //      C# -> List<WeekDay>? WeeklyDays
            // GraphQL -> weeklyDays: [WeekDay!] (enum)
            if (this.WeeklyDays == null && Exploration.Includes(parent + ".weeklyDays$"))
            {
                this.WeeklyDays = new List<WeekDay>();
            }
        }


    #endregion

    } // class ScheduledReport
    #endregion

    public static class ListScheduledReportExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ScheduledReport> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ScheduledReport> list, 
            String parent = "")
        {
            var item = new ScheduledReport();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
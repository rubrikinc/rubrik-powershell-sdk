// ScheduledReport.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ScheduledReport
    public class ScheduledReport: BaseType
    {
        #region members

        //      C# -> List<ReportAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [ReportAttachmentType!]! (enum)
        [JsonProperty("attachmentTypes")]
        public List<ReportAttachmentType>? AttachmentTypes { get; set; }

        //      C# -> List<WeekDay>? WeeklyDays
        // GraphQL -> weeklyDays: [WeekDay!] (enum)
        [JsonProperty("weeklyDays")]
        public List<WeekDay>? WeeklyDays { get; set; }

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

        //      C# -> System.String? TimeZone
        // GraphQL -> timeZone: String! (scalar)
        [JsonProperty("timeZone")]
        public System.String? TimeZone { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ScheduledReport";
    }

    public ScheduledReport Set(
        List<ReportAttachmentType>? AttachmentTypes = null,
        List<WeekDay>? WeeklyDays = null,
        DateTime? CreatedAt = null,
        DateTime? DailyTime = null,
        System.Int64? Id = null,
        DateTime? LastUpdatedAt = null,
        System.Int32? MonthlyDate = null,
        DateTime? MonthlyTime = null,
        List<System.String>? RecipientEmails = null,
        System.Int32? ReportId = null,
        System.String? TimeZone = null,
        System.String? Title = null,
        DateTime? WeeklyTime = null,
        User? Creator = null,
        User? LastEditor = null,
        List<User>? RubrikRecipientUsers = null
    ) 
    {
        if ( AttachmentTypes != null ) {
            this.AttachmentTypes = AttachmentTypes;
        }
        if ( WeeklyDays != null ) {
            this.WeeklyDays = WeeklyDays;
        }
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
        if ( TimeZone != null ) {
            this.TimeZone = TimeZone;
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<ReportAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [ReportAttachmentType!]! (enum)
        if (this.AttachmentTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachmentTypes\n" ;
            } else {
                s += ind + "attachmentTypes\n" ;
            }
        }
        //      C# -> List<WeekDay>? WeeklyDays
        // GraphQL -> weeklyDays: [WeekDay!] (enum)
        if (this.WeeklyDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "weeklyDays\n" ;
            } else {
                s += ind + "weeklyDays\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> DateTime? DailyTime
        // GraphQL -> dailyTime: LocalTime (scalar)
        if (this.DailyTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dailyTime\n" ;
            } else {
                s += ind + "dailyTime\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime! (scalar)
        if (this.LastUpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedAt\n" ;
            } else {
                s += ind + "lastUpdatedAt\n" ;
            }
        }
        //      C# -> System.Int32? MonthlyDate
        // GraphQL -> monthlyDate: Int (scalar)
        if (this.MonthlyDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "monthlyDate\n" ;
            } else {
                s += ind + "monthlyDate\n" ;
            }
        }
        //      C# -> DateTime? MonthlyTime
        // GraphQL -> monthlyTime: LocalTime (scalar)
        if (this.MonthlyTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "monthlyTime\n" ;
            } else {
                s += ind + "monthlyTime\n" ;
            }
        }
        //      C# -> List<System.String>? RecipientEmails
        // GraphQL -> recipientEmails: [String!]! (scalar)
        if (this.RecipientEmails != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recipientEmails\n" ;
            } else {
                s += ind + "recipientEmails\n" ;
            }
        }
        //      C# -> System.Int32? ReportId
        // GraphQL -> reportId: Int! (scalar)
        if (this.ReportId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportId\n" ;
            } else {
                s += ind + "reportId\n" ;
            }
        }
        //      C# -> System.String? TimeZone
        // GraphQL -> timeZone: String! (scalar)
        if (this.TimeZone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timeZone\n" ;
            } else {
                s += ind + "timeZone\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        //      C# -> DateTime? WeeklyTime
        // GraphQL -> weeklyTime: LocalTime (scalar)
        if (this.WeeklyTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "weeklyTime\n" ;
            } else {
                s += ind + "weeklyTime\n" ;
            }
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User! (type)
        if (this.Creator != null) {
            var fspec = this.Creator.AsFieldSpec(conf.Child("creator"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "creator" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> User? LastEditor
        // GraphQL -> lastEditor: User! (type)
        if (this.LastEditor != null) {
            var fspec = this.LastEditor.AsFieldSpec(conf.Child("lastEditor"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastEditor" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<User>? RubrikRecipientUsers
        // GraphQL -> rubrikRecipientUsers: [User!]! (type)
        if (this.RubrikRecipientUsers != null) {
            var fspec = this.RubrikRecipientUsers.AsFieldSpec(conf.Child("rubrikRecipientUsers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rubrikRecipientUsers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ReportAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [ReportAttachmentType!]! (enum)
        if (ec.Includes("attachmentTypes",true))
        {
            if(this.AttachmentTypes == null) {

                this.AttachmentTypes = new List<ReportAttachmentType>();

            } else {


            }
        }
        else if (this.AttachmentTypes != null && ec.Excludes("attachmentTypes",true))
        {
            this.AttachmentTypes = null;
        }
        //      C# -> List<WeekDay>? WeeklyDays
        // GraphQL -> weeklyDays: [WeekDay!] (enum)
        if (ec.Includes("weeklyDays",true))
        {
            if(this.WeeklyDays == null) {

                this.WeeklyDays = new List<WeekDay>();

            } else {


            }
        }
        else if (this.WeeklyDays != null && ec.Excludes("weeklyDays",true))
        {
            this.WeeklyDays = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> DateTime? DailyTime
        // GraphQL -> dailyTime: LocalTime (scalar)
        if (ec.Includes("dailyTime",true))
        {
            if(this.DailyTime == null) {

                this.DailyTime = new DateTime();

            } else {


            }
        }
        else if (this.DailyTime != null && ec.Excludes("dailyTime",true))
        {
            this.DailyTime = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime! (scalar)
        if (ec.Includes("lastUpdatedAt",true))
        {
            if(this.LastUpdatedAt == null) {

                this.LastUpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdatedAt != null && ec.Excludes("lastUpdatedAt",true))
        {
            this.LastUpdatedAt = null;
        }
        //      C# -> System.Int32? MonthlyDate
        // GraphQL -> monthlyDate: Int (scalar)
        if (ec.Includes("monthlyDate",true))
        {
            if(this.MonthlyDate == null) {

                this.MonthlyDate = Int32.MinValue;

            } else {


            }
        }
        else if (this.MonthlyDate != null && ec.Excludes("monthlyDate",true))
        {
            this.MonthlyDate = null;
        }
        //      C# -> DateTime? MonthlyTime
        // GraphQL -> monthlyTime: LocalTime (scalar)
        if (ec.Includes("monthlyTime",true))
        {
            if(this.MonthlyTime == null) {

                this.MonthlyTime = new DateTime();

            } else {


            }
        }
        else if (this.MonthlyTime != null && ec.Excludes("monthlyTime",true))
        {
            this.MonthlyTime = null;
        }
        //      C# -> List<System.String>? RecipientEmails
        // GraphQL -> recipientEmails: [String!]! (scalar)
        if (ec.Includes("recipientEmails",true))
        {
            if(this.RecipientEmails == null) {

                this.RecipientEmails = new List<System.String>();

            } else {


            }
        }
        else if (this.RecipientEmails != null && ec.Excludes("recipientEmails",true))
        {
            this.RecipientEmails = null;
        }
        //      C# -> System.Int32? ReportId
        // GraphQL -> reportId: Int! (scalar)
        if (ec.Includes("reportId",true))
        {
            if(this.ReportId == null) {

                this.ReportId = Int32.MinValue;

            } else {


            }
        }
        else if (this.ReportId != null && ec.Excludes("reportId",true))
        {
            this.ReportId = null;
        }
        //      C# -> System.String? TimeZone
        // GraphQL -> timeZone: String! (scalar)
        if (ec.Includes("timeZone",true))
        {
            if(this.TimeZone == null) {

                this.TimeZone = "FETCH";

            } else {


            }
        }
        else if (this.TimeZone != null && ec.Excludes("timeZone",true))
        {
            this.TimeZone = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
        //      C# -> DateTime? WeeklyTime
        // GraphQL -> weeklyTime: LocalTime (scalar)
        if (ec.Includes("weeklyTime",true))
        {
            if(this.WeeklyTime == null) {

                this.WeeklyTime = new DateTime();

            } else {


            }
        }
        else if (this.WeeklyTime != null && ec.Excludes("weeklyTime",true))
        {
            this.WeeklyTime = null;
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User! (type)
        if (ec.Includes("creator",false))
        {
            if(this.Creator == null) {

                this.Creator = new User();
                this.Creator.ApplyExploratoryFieldSpec(ec.NewChild("creator"));

            } else {

                this.Creator.ApplyExploratoryFieldSpec(ec.NewChild("creator"));

            }
        }
        else if (this.Creator != null && ec.Excludes("creator",false))
        {
            this.Creator = null;
        }
        //      C# -> User? LastEditor
        // GraphQL -> lastEditor: User! (type)
        if (ec.Includes("lastEditor",false))
        {
            if(this.LastEditor == null) {

                this.LastEditor = new User();
                this.LastEditor.ApplyExploratoryFieldSpec(ec.NewChild("lastEditor"));

            } else {

                this.LastEditor.ApplyExploratoryFieldSpec(ec.NewChild("lastEditor"));

            }
        }
        else if (this.LastEditor != null && ec.Excludes("lastEditor",false))
        {
            this.LastEditor = null;
        }
        //      C# -> List<User>? RubrikRecipientUsers
        // GraphQL -> rubrikRecipientUsers: [User!]! (type)
        if (ec.Includes("rubrikRecipientUsers",false))
        {
            if(this.RubrikRecipientUsers == null) {

                this.RubrikRecipientUsers = new List<User>();
                this.RubrikRecipientUsers.ApplyExploratoryFieldSpec(ec.NewChild("rubrikRecipientUsers"));

            } else {

                this.RubrikRecipientUsers.ApplyExploratoryFieldSpec(ec.NewChild("rubrikRecipientUsers"));

            }
        }
        else if (this.RubrikRecipientUsers != null && ec.Excludes("rubrikRecipientUsers",false))
        {
            this.RubrikRecipientUsers = null;
        }
    }


    #endregion

    } // class ScheduledReport
    
    #endregion

    public static class ListScheduledReportExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ScheduledReport> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ScheduledReport> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ScheduledReport> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScheduledReport());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ScheduledReport> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
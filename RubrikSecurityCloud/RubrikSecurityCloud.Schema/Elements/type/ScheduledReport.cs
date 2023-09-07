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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<ReportAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [ReportAttachmentType!]! (enum)
        if (this.AttachmentTypes != null) {
            s += ind + "attachmentTypes\n" ;
        }
        //      C# -> List<WeekDay>? WeeklyDays
        // GraphQL -> weeklyDays: [WeekDay!] (enum)
        if (this.WeeklyDays != null) {
            s += ind + "weeklyDays\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> DateTime? DailyTime
        // GraphQL -> dailyTime: LocalTime (scalar)
        if (this.DailyTime != null) {
            s += ind + "dailyTime\n" ;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime! (scalar)
        if (this.LastUpdatedAt != null) {
            s += ind + "lastUpdatedAt\n" ;
        }
        //      C# -> System.Int32? MonthlyDate
        // GraphQL -> monthlyDate: Int (scalar)
        if (this.MonthlyDate != null) {
            s += ind + "monthlyDate\n" ;
        }
        //      C# -> DateTime? MonthlyTime
        // GraphQL -> monthlyTime: LocalTime (scalar)
        if (this.MonthlyTime != null) {
            s += ind + "monthlyTime\n" ;
        }
        //      C# -> List<System.String>? RecipientEmails
        // GraphQL -> recipientEmails: [String!]! (scalar)
        if (this.RecipientEmails != null) {
            s += ind + "recipientEmails\n" ;
        }
        //      C# -> System.Int32? ReportId
        // GraphQL -> reportId: Int! (scalar)
        if (this.ReportId != null) {
            s += ind + "reportId\n" ;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        //      C# -> DateTime? WeeklyTime
        // GraphQL -> weeklyTime: LocalTime (scalar)
        if (this.WeeklyTime != null) {
            s += ind + "weeklyTime\n" ;
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User! (type)
        if (this.Creator != null) {
            var fspec = this.Creator.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "creator {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> User? LastEditor
        // GraphQL -> lastEditor: User! (type)
        if (this.LastEditor != null) {
            var fspec = this.LastEditor.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lastEditor {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<User>? RubrikRecipientUsers
        // GraphQL -> rubrikRecipientUsers: [User!]! (type)
        if (this.RubrikRecipientUsers != null) {
            var fspec = this.RubrikRecipientUsers.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "rubrikRecipientUsers {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ReportAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [ReportAttachmentType!]! (enum)
        if (this.AttachmentTypes == null && ec.Includes("attachmentTypes",true))
        {
            this.AttachmentTypes = new List<ReportAttachmentType>();
        }
        //      C# -> List<WeekDay>? WeeklyDays
        // GraphQL -> weeklyDays: [WeekDay!] (enum)
        if (this.WeeklyDays == null && ec.Includes("weeklyDays",true))
        {
            this.WeeklyDays = new List<WeekDay>();
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (this.CreatedAt == null && ec.Includes("createdAt",true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> DateTime? DailyTime
        // GraphQL -> dailyTime: LocalTime (scalar)
        if (this.DailyTime == null && ec.Includes("dailyTime",true))
        {
            this.DailyTime = new DateTime();
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = new System.Int64();
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime! (scalar)
        if (this.LastUpdatedAt == null && ec.Includes("lastUpdatedAt",true))
        {
            this.LastUpdatedAt = new DateTime();
        }
        //      C# -> System.Int32? MonthlyDate
        // GraphQL -> monthlyDate: Int (scalar)
        if (this.MonthlyDate == null && ec.Includes("monthlyDate",true))
        {
            this.MonthlyDate = Int32.MinValue;
        }
        //      C# -> DateTime? MonthlyTime
        // GraphQL -> monthlyTime: LocalTime (scalar)
        if (this.MonthlyTime == null && ec.Includes("monthlyTime",true))
        {
            this.MonthlyTime = new DateTime();
        }
        //      C# -> List<System.String>? RecipientEmails
        // GraphQL -> recipientEmails: [String!]! (scalar)
        if (this.RecipientEmails == null && ec.Includes("recipientEmails",true))
        {
            this.RecipientEmails = new List<System.String>();
        }
        //      C# -> System.Int32? ReportId
        // GraphQL -> reportId: Int! (scalar)
        if (this.ReportId == null && ec.Includes("reportId",true))
        {
            this.ReportId = Int32.MinValue;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && ec.Includes("title",true))
        {
            this.Title = "FETCH";
        }
        //      C# -> DateTime? WeeklyTime
        // GraphQL -> weeklyTime: LocalTime (scalar)
        if (this.WeeklyTime == null && ec.Includes("weeklyTime",true))
        {
            this.WeeklyTime = new DateTime();
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User! (type)
        if (this.Creator == null && ec.Includes("creator",false))
        {
            this.Creator = new User();
            this.Creator.ApplyExploratoryFieldSpec(ec.NewChild("creator"));
        }
        //      C# -> User? LastEditor
        // GraphQL -> lastEditor: User! (type)
        if (this.LastEditor == null && ec.Includes("lastEditor",false))
        {
            this.LastEditor = new User();
            this.LastEditor.ApplyExploratoryFieldSpec(ec.NewChild("lastEditor"));
        }
        //      C# -> List<User>? RubrikRecipientUsers
        // GraphQL -> rubrikRecipientUsers: [User!]! (type)
        if (this.RubrikRecipientUsers == null && ec.Includes("rubrikRecipientUsers",false))
        {
            this.RubrikRecipientUsers = new List<User>();
            this.RubrikRecipientUsers.ApplyExploratoryFieldSpec(ec.NewChild("rubrikRecipientUsers"));
        }
    }


    #endregion

    } // class ScheduledReport
    
    #endregion

    public static class ListScheduledReportExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ScheduledReport> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<ScheduledReport> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
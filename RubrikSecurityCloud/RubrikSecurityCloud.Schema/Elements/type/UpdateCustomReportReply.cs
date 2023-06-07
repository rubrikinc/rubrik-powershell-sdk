// UpdateCustomReportReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateCustomReportReply
    public class UpdateCustomReportReply: BaseType
    {
        #region members

        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        [JsonProperty("focus")]
        public ReportFocusEnum? Focus { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        [JsonProperty("id")]
        public System.Int32? Id { get; set; }

        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        [JsonProperty("isHidden")]
        public System.Boolean? IsHidden { get; set; }

        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        [JsonProperty("isReadOnly")]
        public System.Boolean? IsReadOnly { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> DateTime? NewestSyncDate
        // GraphQL -> newestSyncDate: DateTime (scalar)
        [JsonProperty("newestSyncDate")]
        public DateTime? NewestSyncDate { get; set; }

        //      C# -> DateTime? OldestSyncDate
        // GraphQL -> oldestSyncDate: DateTime (scalar)
        [JsonProperty("oldestSyncDate")]
        public DateTime? OldestSyncDate { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> DateTime? ViewedAt
        // GraphQL -> viewedAt: DateTime! (scalar)
        [JsonProperty("viewedAt")]
        public DateTime? ViewedAt { get; set; }

        //      C# -> CustomReportFilters? Filters
        // GraphQL -> filters: CustomReportFilters! (type)
        [JsonProperty("filters")]
        public CustomReportFilters? Filters { get; set; }

        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        [JsonProperty("owner")]
        public User? Owner { get; set; }

        //      C# -> ScheduledReportConnection? ScheduledReportConnection
        // GraphQL -> scheduledReportConnection: ScheduledReportConnection! (type)
        [JsonProperty("scheduledReportConnection")]
        public ScheduledReportConnection? ScheduledReportConnection { get; set; }

        //      C# -> List<ReportChartType>? Charts
        // GraphQL -> charts: [ReportChartType!]! (union)
        [JsonProperty("charts")]
        public List<ReportChartType>? Charts { get; set; }

        //      C# -> List<ReportTableType>? Tables
        // GraphQL -> tables: [ReportTableType!]! (union)
        [JsonProperty("tables")]
        public List<ReportTableType>? Tables { get; set; }


        #endregion

    #region methods

    public UpdateCustomReportReply Set(
        ReportFocusEnum? Focus = null,
        DateTime? CreatedAt = null,
        System.Int32? Id = null,
        System.Boolean? IsHidden = null,
        System.Boolean? IsReadOnly = null,
        System.String? Name = null,
        DateTime? NewestSyncDate = null,
        DateTime? OldestSyncDate = null,
        DateTime? UpdatedAt = null,
        DateTime? ViewedAt = null,
        CustomReportFilters? Filters = null,
        User? Owner = null,
        ScheduledReportConnection? ScheduledReportConnection = null,
        List<ReportChartType>? Charts = null,
        List<ReportTableType>? Tables = null
    ) 
    {
        if ( Focus != null ) {
            this.Focus = Focus;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsHidden != null ) {
            this.IsHidden = IsHidden;
        }
        if ( IsReadOnly != null ) {
            this.IsReadOnly = IsReadOnly;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NewestSyncDate != null ) {
            this.NewestSyncDate = NewestSyncDate;
        }
        if ( OldestSyncDate != null ) {
            this.OldestSyncDate = OldestSyncDate;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( ViewedAt != null ) {
            this.ViewedAt = ViewedAt;
        }
        if ( Filters != null ) {
            this.Filters = Filters;
        }
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( ScheduledReportConnection != null ) {
            this.ScheduledReportConnection = ScheduledReportConnection;
        }
        if ( Charts != null ) {
            this.Charts = Charts;
        }
        if ( Tables != null ) {
            this.Tables = Tables;
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
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus != null) {
            s += ind + "focus\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden != null) {
            s += ind + "isHidden\n" ;
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (this.IsReadOnly != null) {
            s += ind + "isReadOnly\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> DateTime? NewestSyncDate
        // GraphQL -> newestSyncDate: DateTime (scalar)
        if (this.NewestSyncDate != null) {
            s += ind + "newestSyncDate\n" ;
        }
        //      C# -> DateTime? OldestSyncDate
        // GraphQL -> oldestSyncDate: DateTime (scalar)
        if (this.OldestSyncDate != null) {
            s += ind + "oldestSyncDate\n" ;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        if (this.UpdatedAt != null) {
            s += ind + "updatedAt\n" ;
        }
        //      C# -> DateTime? ViewedAt
        // GraphQL -> viewedAt: DateTime! (scalar)
        if (this.ViewedAt != null) {
            s += ind + "viewedAt\n" ;
        }
        //      C# -> CustomReportFilters? Filters
        // GraphQL -> filters: CustomReportFilters! (type)
        if (this.Filters != null) {
            s += ind + "filters {\n" + this.Filters.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        if (this.Owner != null) {
            s += ind + "owner {\n" + this.Owner.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ScheduledReportConnection? ScheduledReportConnection
        // GraphQL -> scheduledReportConnection: ScheduledReportConnection! (type)
        if (this.ScheduledReportConnection != null) {
            s += ind + "scheduledReportConnection {\n" + this.ScheduledReportConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ReportChartType>? Charts
        // GraphQL -> charts: [ReportChartType!]! (union)
        if (this.Charts != null) {
            s += ind + "charts {\n" + this.Charts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ReportTableType>? Tables
        // GraphQL -> tables: [ReportTableType!]! (union)
        if (this.Tables != null) {
            s += ind + "tables {\n" + this.Tables.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus == null && Exploration.Includes(parent + ".focus", true))
        {
            this.Focus = new ReportFocusEnum();
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = Int32.MinValue;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden == null && Exploration.Includes(parent + ".isHidden", true))
        {
            this.IsHidden = true;
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (this.IsReadOnly == null && Exploration.Includes(parent + ".isReadOnly", true))
        {
            this.IsReadOnly = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> DateTime? NewestSyncDate
        // GraphQL -> newestSyncDate: DateTime (scalar)
        if (this.NewestSyncDate == null && Exploration.Includes(parent + ".newestSyncDate", true))
        {
            this.NewestSyncDate = new DateTime();
        }
        //      C# -> DateTime? OldestSyncDate
        // GraphQL -> oldestSyncDate: DateTime (scalar)
        if (this.OldestSyncDate == null && Exploration.Includes(parent + ".oldestSyncDate", true))
        {
            this.OldestSyncDate = new DateTime();
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt", true))
        {
            this.UpdatedAt = new DateTime();
        }
        //      C# -> DateTime? ViewedAt
        // GraphQL -> viewedAt: DateTime! (scalar)
        if (this.ViewedAt == null && Exploration.Includes(parent + ".viewedAt", true))
        {
            this.ViewedAt = new DateTime();
        }
        //      C# -> CustomReportFilters? Filters
        // GraphQL -> filters: CustomReportFilters! (type)
        if (this.Filters == null && Exploration.Includes(parent + ".filters"))
        {
            this.Filters = new CustomReportFilters();
            this.Filters.ApplyExploratoryFieldSpec(parent + ".filters");
        }
        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        if (this.Owner == null && Exploration.Includes(parent + ".owner"))
        {
            this.Owner = new User();
            this.Owner.ApplyExploratoryFieldSpec(parent + ".owner");
        }
        //      C# -> ScheduledReportConnection? ScheduledReportConnection
        // GraphQL -> scheduledReportConnection: ScheduledReportConnection! (type)
        if (this.ScheduledReportConnection == null && Exploration.Includes(parent + ".scheduledReportConnection"))
        {
            this.ScheduledReportConnection = new ScheduledReportConnection();
            this.ScheduledReportConnection.ApplyExploratoryFieldSpec(parent + ".scheduledReportConnection");
        }
        //      C# -> List<ReportChartType>? Charts
        // GraphQL -> charts: [ReportChartType!]! (union)
        if (this.Charts == null && Exploration.Includes(parent + ".charts"))
        {
            this.Charts = new List<ReportChartType>();
            this.Charts.ApplyExploratoryFieldSpec(parent + ".charts");
        }
        //      C# -> List<ReportTableType>? Tables
        // GraphQL -> tables: [ReportTableType!]! (union)
        if (this.Tables == null && Exploration.Includes(parent + ".tables"))
        {
            this.Tables = new List<ReportTableType>();
            this.Tables.ApplyExploratoryFieldSpec(parent + ".tables");
        }
    }


    #endregion

    } // class UpdateCustomReportReply
    
    #endregion

    public static class ListUpdateCustomReportReplyExtensions
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
            this List<UpdateCustomReportReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateCustomReportReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateCustomReportReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
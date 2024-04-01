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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> System.String? Room
        // GraphQL -> room: String (scalar)
        [JsonProperty("room")]
        public System.String? Room { get; set; }

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

    public override string GetGqlTypeName() {
        return "UpdateCustomReportReply";
    }

    public UpdateCustomReportReply Set(
        ReportFocusEnum? Focus = null,
        DateTime? CreatedAt = null,
        System.Int32? Id = null,
        System.Boolean? IsHidden = null,
        System.Boolean? IsReadOnly = null,
        System.String? Name = null,
        DateTime? NewestSyncDate = null,
        DateTime? OldestSyncDate = null,
        System.String? Room = null,
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
        if ( Room != null ) {
            this.Room = Room;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "focus\n" ;
            } else {
                s += ind + "focus\n" ;
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
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHidden\n" ;
            } else {
                s += ind + "isHidden\n" ;
            }
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (this.IsReadOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReadOnly\n" ;
            } else {
                s += ind + "isReadOnly\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> DateTime? NewestSyncDate
        // GraphQL -> newestSyncDate: DateTime (scalar)
        if (this.NewestSyncDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newestSyncDate\n" ;
            } else {
                s += ind + "newestSyncDate\n" ;
            }
        }
        //      C# -> DateTime? OldestSyncDate
        // GraphQL -> oldestSyncDate: DateTime (scalar)
        if (this.OldestSyncDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestSyncDate\n" ;
            } else {
                s += ind + "oldestSyncDate\n" ;
            }
        }
        //      C# -> System.String? Room
        // GraphQL -> room: String (scalar)
        if (this.Room != null) {
            if (conf.Flat) {
                s += conf.Prefix + "room\n" ;
            } else {
                s += ind + "room\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> DateTime? ViewedAt
        // GraphQL -> viewedAt: DateTime! (scalar)
        if (this.ViewedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "viewedAt\n" ;
            } else {
                s += ind + "viewedAt\n" ;
            }
        }
        //      C# -> CustomReportFilters? Filters
        // GraphQL -> filters: CustomReportFilters! (type)
        if (this.Filters != null) {
            var fspec = this.Filters.AsFieldSpec(conf.Child("filters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filters {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        if (this.Owner != null) {
            var fspec = this.Owner.AsFieldSpec(conf.Child("owner"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "owner {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ScheduledReportConnection? ScheduledReportConnection
        // GraphQL -> scheduledReportConnection: ScheduledReportConnection! (type)
        if (this.ScheduledReportConnection != null) {
            var fspec = this.ScheduledReportConnection.AsFieldSpec(conf.Child("scheduledReportConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "scheduledReportConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReportChartType>? Charts
        // GraphQL -> charts: [ReportChartType!]! (union)
        if (this.Charts != null) {
            var fspec = this.Charts.AsFieldSpec(conf.Child("charts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "charts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReportTableType>? Tables
        // GraphQL -> tables: [ReportTableType!]! (union)
        if (this.Tables != null) {
            var fspec = this.Tables.AsFieldSpec(conf.Child("tables"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tables {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (ec.Includes("focus",true))
        {
            if(this.Focus == null) {

                this.Focus = new ReportFocusEnum();

            } else {


            }
        }
        else if (this.Focus != null && ec.Excludes("focus",true))
        {
            this.Focus = null;
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
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = Int32.MinValue;

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (ec.Includes("isHidden",true))
        {
            if(this.IsHidden == null) {

                this.IsHidden = true;

            } else {


            }
        }
        else if (this.IsHidden != null && ec.Excludes("isHidden",true))
        {
            this.IsHidden = null;
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (ec.Includes("isReadOnly",true))
        {
            if(this.IsReadOnly == null) {

                this.IsReadOnly = true;

            } else {


            }
        }
        else if (this.IsReadOnly != null && ec.Excludes("isReadOnly",true))
        {
            this.IsReadOnly = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> DateTime? NewestSyncDate
        // GraphQL -> newestSyncDate: DateTime (scalar)
        if (ec.Includes("newestSyncDate",true))
        {
            if(this.NewestSyncDate == null) {

                this.NewestSyncDate = new DateTime();

            } else {


            }
        }
        else if (this.NewestSyncDate != null && ec.Excludes("newestSyncDate",true))
        {
            this.NewestSyncDate = null;
        }
        //      C# -> DateTime? OldestSyncDate
        // GraphQL -> oldestSyncDate: DateTime (scalar)
        if (ec.Includes("oldestSyncDate",true))
        {
            if(this.OldestSyncDate == null) {

                this.OldestSyncDate = new DateTime();

            } else {


            }
        }
        else if (this.OldestSyncDate != null && ec.Excludes("oldestSyncDate",true))
        {
            this.OldestSyncDate = null;
        }
        //      C# -> System.String? Room
        // GraphQL -> room: String (scalar)
        if (ec.Includes("room",true))
        {
            if(this.Room == null) {

                this.Room = "FETCH";

            } else {


            }
        }
        else if (this.Room != null && ec.Excludes("room",true))
        {
            this.Room = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
        //      C# -> DateTime? ViewedAt
        // GraphQL -> viewedAt: DateTime! (scalar)
        if (ec.Includes("viewedAt",true))
        {
            if(this.ViewedAt == null) {

                this.ViewedAt = new DateTime();

            } else {


            }
        }
        else if (this.ViewedAt != null && ec.Excludes("viewedAt",true))
        {
            this.ViewedAt = null;
        }
        //      C# -> CustomReportFilters? Filters
        // GraphQL -> filters: CustomReportFilters! (type)
        if (ec.Includes("filters",false))
        {
            if(this.Filters == null) {

                this.Filters = new CustomReportFilters();
                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            } else {

                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            }
        }
        else if (this.Filters != null && ec.Excludes("filters",false))
        {
            this.Filters = null;
        }
        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        if (ec.Includes("owner",false))
        {
            if(this.Owner == null) {

                this.Owner = new User();
                this.Owner.ApplyExploratoryFieldSpec(ec.NewChild("owner"));

            } else {

                this.Owner.ApplyExploratoryFieldSpec(ec.NewChild("owner"));

            }
        }
        else if (this.Owner != null && ec.Excludes("owner",false))
        {
            this.Owner = null;
        }
        //      C# -> ScheduledReportConnection? ScheduledReportConnection
        // GraphQL -> scheduledReportConnection: ScheduledReportConnection! (type)
        if (ec.Includes("scheduledReportConnection",false))
        {
            if(this.ScheduledReportConnection == null) {

                this.ScheduledReportConnection = new ScheduledReportConnection();
                this.ScheduledReportConnection.ApplyExploratoryFieldSpec(ec.NewChild("scheduledReportConnection"));

            } else {

                this.ScheduledReportConnection.ApplyExploratoryFieldSpec(ec.NewChild("scheduledReportConnection"));

            }
        }
        else if (this.ScheduledReportConnection != null && ec.Excludes("scheduledReportConnection",false))
        {
            this.ScheduledReportConnection = null;
        }
        //      C# -> List<ReportChartType>? Charts
        // GraphQL -> charts: [ReportChartType!]! (union)
        if (ec.Includes("charts",false))
        {
            if(this.Charts == null) {

                this.Charts = new List<ReportChartType>();
                this.Charts.ApplyExploratoryFieldSpec(ec.NewChild("charts"));

            } else {

                this.Charts.ApplyExploratoryFieldSpec(ec.NewChild("charts"));

            }
        }
        else if (this.Charts != null && ec.Excludes("charts",false))
        {
            this.Charts = null;
        }
        //      C# -> List<ReportTableType>? Tables
        // GraphQL -> tables: [ReportTableType!]! (union)
        if (ec.Includes("tables",false))
        {
            if(this.Tables == null) {

                this.Tables = new List<ReportTableType>();
                this.Tables.ApplyExploratoryFieldSpec(ec.NewChild("tables"));

            } else {

                this.Tables.ApplyExploratoryFieldSpec(ec.NewChild("tables"));

            }
        }
        else if (this.Tables != null && ec.Excludes("tables",false))
        {
            this.Tables = null;
        }
    }


    #endregion

    } // class UpdateCustomReportReply
    
    #endregion

    public static class ListUpdateCustomReportReplyExtensions
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
            this List<UpdateCustomReportReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateCustomReportReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateCustomReportReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateCustomReportReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateCustomReportReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
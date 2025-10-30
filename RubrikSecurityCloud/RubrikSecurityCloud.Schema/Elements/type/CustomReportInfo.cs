// CustomReportInfo.cs
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
    #region CustomReportInfo
    public class CustomReportInfo: BaseType
    {
        #region members

        //      C# -> ReportCategory? ReportCategory
        // GraphQL -> reportCategory: ReportCategory! (enum)
        [JsonProperty("reportCategory")]
        public ReportCategory? ReportCategory { get; set; }

        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        [JsonProperty("reportViewType")]
        public PolarisReportViewType? ReportViewType { get; set; }

        //      C# -> ReportRoomType? Room
        // GraphQL -> room: ReportRoomType! (enum)
        [JsonProperty("room")]
        public ReportRoomType? Room { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        [JsonProperty("createdBy")]
        public System.String? CreatedBy { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> System.String? UpdatedBy
        // GraphQL -> updatedBy: String! (scalar)
        [JsonProperty("updatedBy")]
        public System.String? UpdatedBy { get; set; }

        //      C# -> List<FilterOutput>? ReportFilters
        // GraphQL -> reportFilters: [FilterOutput!]! (type)
        [JsonProperty("reportFilters")]
        public List<FilterOutput>? ReportFilters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomReportInfo";
    }

    public CustomReportInfo Set(
        ReportCategory? ReportCategory = null,
        PolarisReportViewType? ReportViewType = null,
        ReportRoomType? Room = null,
        DateTime? CreatedAt = null,
        System.String? CreatedBy = null,
        System.Int64? Id = null,
        System.String? Name = null,
        DateTime? UpdatedAt = null,
        System.String? UpdatedBy = null,
        List<FilterOutput>? ReportFilters = null
    ) 
    {
        if ( ReportCategory != null ) {
            this.ReportCategory = ReportCategory;
        }
        if ( ReportViewType != null ) {
            this.ReportViewType = ReportViewType;
        }
        if ( Room != null ) {
            this.Room = Room;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CreatedBy != null ) {
            this.CreatedBy = CreatedBy;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( UpdatedBy != null ) {
            this.UpdatedBy = UpdatedBy;
        }
        if ( ReportFilters != null ) {
            this.ReportFilters = ReportFilters;
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
        //      C# -> ReportCategory? ReportCategory
        // GraphQL -> reportCategory: ReportCategory! (enum)
        if (this.ReportCategory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportCategory\n" ;
            } else {
                s += ind + "reportCategory\n" ;
            }
        }
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (this.ReportViewType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportViewType\n" ;
            } else {
                s += ind + "reportViewType\n" ;
            }
        }
        //      C# -> ReportRoomType? Room
        // GraphQL -> room: ReportRoomType! (enum)
        if (this.Room != null) {
            if (conf.Flat) {
                s += conf.Prefix + "room\n" ;
            } else {
                s += ind + "room\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        if (this.CreatedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdBy\n" ;
            } else {
                s += ind + "createdBy\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> System.String? UpdatedBy
        // GraphQL -> updatedBy: String! (scalar)
        if (this.UpdatedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedBy\n" ;
            } else {
                s += ind + "updatedBy\n" ;
            }
        }
        //      C# -> List<FilterOutput>? ReportFilters
        // GraphQL -> reportFilters: [FilterOutput!]! (type)
        if (this.ReportFilters != null) {
            var fspec = this.ReportFilters.AsFieldSpec(conf.Child("reportFilters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "reportFilters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ReportCategory? ReportCategory
        // GraphQL -> reportCategory: ReportCategory! (enum)
        if (ec.Includes("reportCategory",true))
        {
            if(this.ReportCategory == null) {

                this.ReportCategory = new ReportCategory();

            } else {


            }
        }
        else if (this.ReportCategory != null && ec.Excludes("reportCategory",true))
        {
            this.ReportCategory = null;
        }
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (ec.Includes("reportViewType",true))
        {
            if(this.ReportViewType == null) {

                this.ReportViewType = new PolarisReportViewType();

            } else {


            }
        }
        else if (this.ReportViewType != null && ec.Excludes("reportViewType",true))
        {
            this.ReportViewType = null;
        }
        //      C# -> ReportRoomType? Room
        // GraphQL -> room: ReportRoomType! (enum)
        if (ec.Includes("room",true))
        {
            if(this.Room == null) {

                this.Room = new ReportRoomType();

            } else {


            }
        }
        else if (this.Room != null && ec.Excludes("room",true))
        {
            this.Room = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
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
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        if (ec.Includes("createdBy",true))
        {
            if(this.CreatedBy == null) {

                this.CreatedBy = "FETCH";

            } else {


            }
        }
        else if (this.CreatedBy != null && ec.Excludes("createdBy",true))
        {
            this.CreatedBy = null;
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
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
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
        //      C# -> System.String? UpdatedBy
        // GraphQL -> updatedBy: String! (scalar)
        if (ec.Includes("updatedBy",true))
        {
            if(this.UpdatedBy == null) {

                this.UpdatedBy = "FETCH";

            } else {


            }
        }
        else if (this.UpdatedBy != null && ec.Excludes("updatedBy",true))
        {
            this.UpdatedBy = null;
        }
        //      C# -> List<FilterOutput>? ReportFilters
        // GraphQL -> reportFilters: [FilterOutput!]! (type)
        if (ec.Includes("reportFilters",false))
        {
            if(this.ReportFilters == null) {

                this.ReportFilters = new List<FilterOutput>();
                this.ReportFilters.ApplyExploratoryFieldSpec(ec.NewChild("reportFilters"));

            } else {

                this.ReportFilters.ApplyExploratoryFieldSpec(ec.NewChild("reportFilters"));

            }
        }
        else if (this.ReportFilters != null && ec.Excludes("reportFilters",false))
        {
            this.ReportFilters = null;
        }
    }


    #endregion

    } // class CustomReportInfo
    
    #endregion

    public static class ListCustomReportInfoExtensions
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
            this List<CustomReportInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CustomReportInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CustomReportInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomReportInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CustomReportInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
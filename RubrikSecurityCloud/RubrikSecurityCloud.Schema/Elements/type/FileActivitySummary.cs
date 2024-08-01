// FileActivitySummary.cs
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
    #region FileActivitySummary
    public class FileActivitySummary: BaseType
    {
        #region members

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int64? LastAccessTimestamp
        // GraphQL -> lastAccessTimestamp: Long! (scalar)
        [JsonProperty("lastAccessTimestamp")]
        public System.Int64? LastAccessTimestamp { get; set; }

        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        [JsonProperty("paginationId")]
        public System.String? PaginationId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        [JsonProperty("currentActivitySummary")]
        public ActivitySummary? CurrentActivitySummary { get; set; }

        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        [JsonProperty("deltaActivitySummary")]
        public ActivitySummary? DeltaActivitySummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FileActivitySummary";
    }

    public FileActivitySummary Set(
        RiskLevelType? Risk = null,
        System.String? FileName = null,
        System.Int64? LastAccessTimestamp = null,
        System.String? PaginationId = null,
        System.String? SnapshotId = null,
        ActivitySummary? CurrentActivitySummary = null,
        ActivitySummary? DeltaActivitySummary = null
    ) 
    {
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( LastAccessTimestamp != null ) {
            this.LastAccessTimestamp = LastAccessTimestamp;
        }
        if ( PaginationId != null ) {
            this.PaginationId = PaginationId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( CurrentActivitySummary != null ) {
            this.CurrentActivitySummary = CurrentActivitySummary;
        }
        if ( DeltaActivitySummary != null ) {
            this.DeltaActivitySummary = DeltaActivitySummary;
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
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "risk\n" ;
            } else {
                s += ind + "risk\n" ;
            }
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileName\n" ;
            } else {
                s += ind + "fileName\n" ;
            }
        }
        //      C# -> System.Int64? LastAccessTimestamp
        // GraphQL -> lastAccessTimestamp: Long! (scalar)
        if (this.LastAccessTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastAccessTimestamp\n" ;
            } else {
                s += ind + "lastAccessTimestamp\n" ;
            }
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "paginationId\n" ;
            } else {
                s += ind + "paginationId\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        if (this.CurrentActivitySummary != null) {
            var fspec = this.CurrentActivitySummary.AsFieldSpec(conf.Child("currentActivitySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "currentActivitySummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        if (this.DeltaActivitySummary != null) {
            var fspec = this.DeltaActivitySummary.AsFieldSpec(conf.Child("deltaActivitySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaActivitySummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (ec.Includes("risk",true))
        {
            if(this.Risk == null) {

                this.Risk = new RiskLevelType();

            } else {


            }
        }
        else if (this.Risk != null && ec.Excludes("risk",true))
        {
            this.Risk = null;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (ec.Includes("fileName",true))
        {
            if(this.FileName == null) {

                this.FileName = "FETCH";

            } else {


            }
        }
        else if (this.FileName != null && ec.Excludes("fileName",true))
        {
            this.FileName = null;
        }
        //      C# -> System.Int64? LastAccessTimestamp
        // GraphQL -> lastAccessTimestamp: Long! (scalar)
        if (ec.Includes("lastAccessTimestamp",true))
        {
            if(this.LastAccessTimestamp == null) {

                this.LastAccessTimestamp = new System.Int64();

            } else {


            }
        }
        else if (this.LastAccessTimestamp != null && ec.Excludes("lastAccessTimestamp",true))
        {
            this.LastAccessTimestamp = null;
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (ec.Includes("paginationId",true))
        {
            if(this.PaginationId == null) {

                this.PaginationId = "FETCH";

            } else {


            }
        }
        else if (this.PaginationId != null && ec.Excludes("paginationId",true))
        {
            this.PaginationId = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        if (ec.Includes("currentActivitySummary",false))
        {
            if(this.CurrentActivitySummary == null) {

                this.CurrentActivitySummary = new ActivitySummary();
                this.CurrentActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("currentActivitySummary"));

            } else {

                this.CurrentActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("currentActivitySummary"));

            }
        }
        else if (this.CurrentActivitySummary != null && ec.Excludes("currentActivitySummary",false))
        {
            this.CurrentActivitySummary = null;
        }
        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        if (ec.Includes("deltaActivitySummary",false))
        {
            if(this.DeltaActivitySummary == null) {

                this.DeltaActivitySummary = new ActivitySummary();
                this.DeltaActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("deltaActivitySummary"));

            } else {

                this.DeltaActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("deltaActivitySummary"));

            }
        }
        else if (this.DeltaActivitySummary != null && ec.Excludes("deltaActivitySummary",false))
        {
            this.DeltaActivitySummary = null;
        }
    }


    #endregion

    } // class FileActivitySummary
    
    #endregion

    public static class ListFileActivitySummaryExtensions
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
            this List<FileActivitySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FileActivitySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FileActivitySummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileActivitySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FileActivitySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// FilesetSnapshotSummary.cs
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
    #region FilesetSnapshotSummary
    public class FilesetSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.Int64? ErrorsCollected
        // GraphQL -> errorsCollected: Long (scalar)
        [JsonProperty("errorsCollected")]
        public System.Int64? ErrorsCollected { get; set; }

        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long (scalar)
        [JsonProperty("fileCount")]
        public System.Int64? FileCount { get; set; }

        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        [JsonProperty("filesetName")]
        public System.String? FilesetName { get; set; }

        //      C# -> System.Boolean? SnapdiffUsed
        // GraphQL -> snapdiffUsed: Boolean (scalar)
        [JsonProperty("snapdiffUsed")]
        public System.Boolean? SnapdiffUsed { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesetSnapshotSummary";
    }

    public FilesetSnapshotSummary Set(
        System.Int64? ErrorsCollected = null,
        System.Int64? FileCount = null,
        System.String? FilesetName = null,
        System.Boolean? SnapdiffUsed = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( ErrorsCollected != null ) {
            this.ErrorsCollected = ErrorsCollected;
        }
        if ( FileCount != null ) {
            this.FileCount = FileCount;
        }
        if ( FilesetName != null ) {
            this.FilesetName = FilesetName;
        }
        if ( SnapdiffUsed != null ) {
            this.SnapdiffUsed = SnapdiffUsed;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
        //      C# -> System.Int64? ErrorsCollected
        // GraphQL -> errorsCollected: Long (scalar)
        if (this.ErrorsCollected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorsCollected\n" ;
            } else {
                s += ind + "errorsCollected\n" ;
            }
        }
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long (scalar)
        if (this.FileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileCount\n" ;
            } else {
                s += ind + "fileCount\n" ;
            }
        }
        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        if (this.FilesetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesetName\n" ;
            } else {
                s += ind + "filesetName\n" ;
            }
        }
        //      C# -> System.Boolean? SnapdiffUsed
        // GraphQL -> snapdiffUsed: Boolean (scalar)
        if (this.SnapdiffUsed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapdiffUsed\n" ;
            } else {
                s += ind + "snapdiffUsed\n" ;
            }
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(conf.Child("baseSnapshotSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseSnapshotSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ErrorsCollected
        // GraphQL -> errorsCollected: Long (scalar)
        if (ec.Includes("errorsCollected",true))
        {
            if(this.ErrorsCollected == null) {

                this.ErrorsCollected = new System.Int64();

            } else {


            }
        }
        else if (this.ErrorsCollected != null && ec.Excludes("errorsCollected",true))
        {
            this.ErrorsCollected = null;
        }
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long (scalar)
        if (ec.Includes("fileCount",true))
        {
            if(this.FileCount == null) {

                this.FileCount = new System.Int64();

            } else {


            }
        }
        else if (this.FileCount != null && ec.Excludes("fileCount",true))
        {
            this.FileCount = null;
        }
        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        if (ec.Includes("filesetName",true))
        {
            if(this.FilesetName == null) {

                this.FilesetName = "FETCH";

            } else {


            }
        }
        else if (this.FilesetName != null && ec.Excludes("filesetName",true))
        {
            this.FilesetName = null;
        }
        //      C# -> System.Boolean? SnapdiffUsed
        // GraphQL -> snapdiffUsed: Boolean (scalar)
        if (ec.Includes("snapdiffUsed",true))
        {
            if(this.SnapdiffUsed == null) {

                this.SnapdiffUsed = true;

            } else {


            }
        }
        else if (this.SnapdiffUsed != null && ec.Excludes("snapdiffUsed",true))
        {
            this.SnapdiffUsed = null;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (ec.Includes("baseSnapshotSummary",false))
        {
            if(this.BaseSnapshotSummary == null) {

                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            } else {

                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            }
        }
        else if (this.BaseSnapshotSummary != null && ec.Excludes("baseSnapshotSummary",false))
        {
            this.BaseSnapshotSummary = null;
        }
    }


    #endregion

    } // class FilesetSnapshotSummary
    
    #endregion

    public static class ListFilesetSnapshotSummaryExtensions
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
            this List<FilesetSnapshotSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilesetSnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSnapshotSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
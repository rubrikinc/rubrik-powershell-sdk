// StrainInfo.cs
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
    #region StrainInfo
    public class StrainInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? SampleAffectedFiles
        // GraphQL -> sampleAffectedFiles: [String!]! (scalar)
        [JsonProperty("sampleAffectedFiles")]
        public List<System.String>? SampleAffectedFiles { get; set; }

        //      C# -> List<System.String>? SampleRansomwareNotes
        // GraphQL -> sampleRansomwareNotes: [String!]! (scalar)
        [JsonProperty("sampleRansomwareNotes")]
        public List<System.String>? SampleRansomwareNotes { get; set; }

        //      C# -> System.String? StrainId
        // GraphQL -> strainId: String! (scalar)
        [JsonProperty("strainId")]
        public System.String? StrainId { get; set; }

        //      C# -> System.Int64? TotalAffectedFiles
        // GraphQL -> totalAffectedFiles: Long! (scalar)
        [JsonProperty("totalAffectedFiles")]
        public System.Int64? TotalAffectedFiles { get; set; }

        //      C# -> System.Int64? TotalRansomwareNotes
        // GraphQL -> totalRansomwareNotes: Long! (scalar)
        [JsonProperty("totalRansomwareNotes")]
        public System.Int64? TotalRansomwareNotes { get; set; }

        //      C# -> List<SuspiciousFileInfo>? SampleAffectedFilesInfo
        // GraphQL -> sampleAffectedFilesInfo: [SuspiciousFileInfo!]! (type)
        [JsonProperty("sampleAffectedFilesInfo")]
        public List<SuspiciousFileInfo>? SampleAffectedFilesInfo { get; set; }

        //      C# -> List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo
        // GraphQL -> sampleRansomwareNoteFilesInfo: [SuspiciousFileInfo!]! (type)
        [JsonProperty("sampleRansomwareNoteFilesInfo")]
        public List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StrainInfo";
    }

    public StrainInfo Set(
        List<System.String>? SampleAffectedFiles = null,
        List<System.String>? SampleRansomwareNotes = null,
        System.String? StrainId = null,
        System.Int64? TotalAffectedFiles = null,
        System.Int64? TotalRansomwareNotes = null,
        List<SuspiciousFileInfo>? SampleAffectedFilesInfo = null,
        List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo = null
    ) 
    {
        if ( SampleAffectedFiles != null ) {
            this.SampleAffectedFiles = SampleAffectedFiles;
        }
        if ( SampleRansomwareNotes != null ) {
            this.SampleRansomwareNotes = SampleRansomwareNotes;
        }
        if ( StrainId != null ) {
            this.StrainId = StrainId;
        }
        if ( TotalAffectedFiles != null ) {
            this.TotalAffectedFiles = TotalAffectedFiles;
        }
        if ( TotalRansomwareNotes != null ) {
            this.TotalRansomwareNotes = TotalRansomwareNotes;
        }
        if ( SampleAffectedFilesInfo != null ) {
            this.SampleAffectedFilesInfo = SampleAffectedFilesInfo;
        }
        if ( SampleRansomwareNoteFilesInfo != null ) {
            this.SampleRansomwareNoteFilesInfo = SampleRansomwareNoteFilesInfo;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? SampleAffectedFiles
        // GraphQL -> sampleAffectedFiles: [String!]! (scalar)
        if (this.SampleAffectedFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sampleAffectedFiles\n" ;
            } else {
                s += ind + "sampleAffectedFiles\n" ;
            }
        }
        //      C# -> List<System.String>? SampleRansomwareNotes
        // GraphQL -> sampleRansomwareNotes: [String!]! (scalar)
        if (this.SampleRansomwareNotes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sampleRansomwareNotes\n" ;
            } else {
                s += ind + "sampleRansomwareNotes\n" ;
            }
        }
        //      C# -> System.String? StrainId
        // GraphQL -> strainId: String! (scalar)
        if (this.StrainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "strainId\n" ;
            } else {
                s += ind + "strainId\n" ;
            }
        }
        //      C# -> System.Int64? TotalAffectedFiles
        // GraphQL -> totalAffectedFiles: Long! (scalar)
        if (this.TotalAffectedFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalAffectedFiles\n" ;
            } else {
                s += ind + "totalAffectedFiles\n" ;
            }
        }
        //      C# -> System.Int64? TotalRansomwareNotes
        // GraphQL -> totalRansomwareNotes: Long! (scalar)
        if (this.TotalRansomwareNotes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalRansomwareNotes\n" ;
            } else {
                s += ind + "totalRansomwareNotes\n" ;
            }
        }
        //      C# -> List<SuspiciousFileInfo>? SampleAffectedFilesInfo
        // GraphQL -> sampleAffectedFilesInfo: [SuspiciousFileInfo!]! (type)
        if (this.SampleAffectedFilesInfo != null) {
            var fspec = this.SampleAffectedFilesInfo.AsFieldSpec(conf.Child("sampleAffectedFilesInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sampleAffectedFilesInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo
        // GraphQL -> sampleRansomwareNoteFilesInfo: [SuspiciousFileInfo!]! (type)
        if (this.SampleRansomwareNoteFilesInfo != null) {
            var fspec = this.SampleRansomwareNoteFilesInfo.AsFieldSpec(conf.Child("sampleRansomwareNoteFilesInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sampleRansomwareNoteFilesInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? SampleAffectedFiles
        // GraphQL -> sampleAffectedFiles: [String!]! (scalar)
        if (ec.Includes("sampleAffectedFiles",true))
        {
            if(this.SampleAffectedFiles == null) {

                this.SampleAffectedFiles = new List<System.String>();

            } else {


            }
        }
        else if (this.SampleAffectedFiles != null && ec.Excludes("sampleAffectedFiles",true))
        {
            this.SampleAffectedFiles = null;
        }
        //      C# -> List<System.String>? SampleRansomwareNotes
        // GraphQL -> sampleRansomwareNotes: [String!]! (scalar)
        if (ec.Includes("sampleRansomwareNotes",true))
        {
            if(this.SampleRansomwareNotes == null) {

                this.SampleRansomwareNotes = new List<System.String>();

            } else {


            }
        }
        else if (this.SampleRansomwareNotes != null && ec.Excludes("sampleRansomwareNotes",true))
        {
            this.SampleRansomwareNotes = null;
        }
        //      C# -> System.String? StrainId
        // GraphQL -> strainId: String! (scalar)
        if (ec.Includes("strainId",true))
        {
            if(this.StrainId == null) {

                this.StrainId = "FETCH";

            } else {


            }
        }
        else if (this.StrainId != null && ec.Excludes("strainId",true))
        {
            this.StrainId = null;
        }
        //      C# -> System.Int64? TotalAffectedFiles
        // GraphQL -> totalAffectedFiles: Long! (scalar)
        if (ec.Includes("totalAffectedFiles",true))
        {
            if(this.TotalAffectedFiles == null) {

                this.TotalAffectedFiles = new System.Int64();

            } else {


            }
        }
        else if (this.TotalAffectedFiles != null && ec.Excludes("totalAffectedFiles",true))
        {
            this.TotalAffectedFiles = null;
        }
        //      C# -> System.Int64? TotalRansomwareNotes
        // GraphQL -> totalRansomwareNotes: Long! (scalar)
        if (ec.Includes("totalRansomwareNotes",true))
        {
            if(this.TotalRansomwareNotes == null) {

                this.TotalRansomwareNotes = new System.Int64();

            } else {


            }
        }
        else if (this.TotalRansomwareNotes != null && ec.Excludes("totalRansomwareNotes",true))
        {
            this.TotalRansomwareNotes = null;
        }
        //      C# -> List<SuspiciousFileInfo>? SampleAffectedFilesInfo
        // GraphQL -> sampleAffectedFilesInfo: [SuspiciousFileInfo!]! (type)
        if (ec.Includes("sampleAffectedFilesInfo",false))
        {
            if(this.SampleAffectedFilesInfo == null) {

                this.SampleAffectedFilesInfo = new List<SuspiciousFileInfo>();
                this.SampleAffectedFilesInfo.ApplyExploratoryFieldSpec(ec.NewChild("sampleAffectedFilesInfo"));

            } else {

                this.SampleAffectedFilesInfo.ApplyExploratoryFieldSpec(ec.NewChild("sampleAffectedFilesInfo"));

            }
        }
        else if (this.SampleAffectedFilesInfo != null && ec.Excludes("sampleAffectedFilesInfo",false))
        {
            this.SampleAffectedFilesInfo = null;
        }
        //      C# -> List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo
        // GraphQL -> sampleRansomwareNoteFilesInfo: [SuspiciousFileInfo!]! (type)
        if (ec.Includes("sampleRansomwareNoteFilesInfo",false))
        {
            if(this.SampleRansomwareNoteFilesInfo == null) {

                this.SampleRansomwareNoteFilesInfo = new List<SuspiciousFileInfo>();
                this.SampleRansomwareNoteFilesInfo.ApplyExploratoryFieldSpec(ec.NewChild("sampleRansomwareNoteFilesInfo"));

            } else {

                this.SampleRansomwareNoteFilesInfo.ApplyExploratoryFieldSpec(ec.NewChild("sampleRansomwareNoteFilesInfo"));

            }
        }
        else if (this.SampleRansomwareNoteFilesInfo != null && ec.Excludes("sampleRansomwareNoteFilesInfo",false))
        {
            this.SampleRansomwareNoteFilesInfo = null;
        }
    }


    #endregion

    } // class StrainInfo
    
    #endregion

    public static class ListStrainInfoExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<StrainInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StrainInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StrainInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StrainInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StrainInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
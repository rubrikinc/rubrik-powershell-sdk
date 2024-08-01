// ThreatMonitoringFileMatchDetailsV2.cs
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
    #region ThreatMonitoringFileMatchDetailsV2
    public class ThreatMonitoringFileMatchDetailsV2: BaseType
    {
        #region members

        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        [JsonProperty("detectedSnapshotDate")]
        public DateTime? DetectedSnapshotDate { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        [JsonProperty("filePath")]
        public System.String? FilePath { get; set; }

        //      C# -> System.String? FirstDetectedSnapshotFid
        // GraphQL -> firstDetectedSnapshotFid: String! (scalar)
        [JsonProperty("firstDetectedSnapshotFid")]
        public System.String? FirstDetectedSnapshotFid { get; set; }

        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        [JsonProperty("isQuarantinedInFirstObservedSnapshot")]
        public System.Boolean? IsQuarantinedInFirstObservedSnapshot { get; set; }

        //      C# -> System.String? MatchedFileMd5
        // GraphQL -> matchedFileMd5: String! (scalar)
        [JsonProperty("matchedFileMd5")]
        public System.String? MatchedFileMd5 { get; set; }

        //      C# -> System.String? MatchedFileSha1
        // GraphQL -> matchedFileSha1: String! (scalar)
        [JsonProperty("matchedFileSha1")]
        public System.String? MatchedFileSha1 { get; set; }

        //      C# -> System.String? MatchedFileSha256
        // GraphQL -> matchedFileSha256: String! (scalar)
        [JsonProperty("matchedFileSha256")]
        public System.String? MatchedFileSha256 { get; set; }

        //      C# -> List<IocDetails>? IocDetails
        // GraphQL -> iocDetails: [IOCDetails!]! (type)
        [JsonProperty("iocDetails")]
        public List<IocDetails>? IocDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatMonitoringFileMatchDetailsV2";
    }

    public ThreatMonitoringFileMatchDetailsV2 Set(
        DateTime? DetectedSnapshotDate = null,
        System.String? FileName = null,
        System.String? FilePath = null,
        System.String? FirstDetectedSnapshotFid = null,
        System.Boolean? IsQuarantinedInFirstObservedSnapshot = null,
        System.String? MatchedFileMd5 = null,
        System.String? MatchedFileSha1 = null,
        System.String? MatchedFileSha256 = null,
        List<IocDetails>? IocDetails = null
    ) 
    {
        if ( DetectedSnapshotDate != null ) {
            this.DetectedSnapshotDate = DetectedSnapshotDate;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( FilePath != null ) {
            this.FilePath = FilePath;
        }
        if ( FirstDetectedSnapshotFid != null ) {
            this.FirstDetectedSnapshotFid = FirstDetectedSnapshotFid;
        }
        if ( IsQuarantinedInFirstObservedSnapshot != null ) {
            this.IsQuarantinedInFirstObservedSnapshot = IsQuarantinedInFirstObservedSnapshot;
        }
        if ( MatchedFileMd5 != null ) {
            this.MatchedFileMd5 = MatchedFileMd5;
        }
        if ( MatchedFileSha1 != null ) {
            this.MatchedFileSha1 = MatchedFileSha1;
        }
        if ( MatchedFileSha256 != null ) {
            this.MatchedFileSha256 = MatchedFileSha256;
        }
        if ( IocDetails != null ) {
            this.IocDetails = IocDetails;
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
        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        if (this.DetectedSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectedSnapshotDate\n" ;
            } else {
                s += ind + "detectedSnapshotDate\n" ;
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
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (this.FilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filePath\n" ;
            } else {
                s += ind + "filePath\n" ;
            }
        }
        //      C# -> System.String? FirstDetectedSnapshotFid
        // GraphQL -> firstDetectedSnapshotFid: String! (scalar)
        if (this.FirstDetectedSnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstDetectedSnapshotFid\n" ;
            } else {
                s += ind + "firstDetectedSnapshotFid\n" ;
            }
        }
        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        if (this.IsQuarantinedInFirstObservedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantinedInFirstObservedSnapshot\n" ;
            } else {
                s += ind + "isQuarantinedInFirstObservedSnapshot\n" ;
            }
        }
        //      C# -> System.String? MatchedFileMd5
        // GraphQL -> matchedFileMd5: String! (scalar)
        if (this.MatchedFileMd5 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedFileMd5\n" ;
            } else {
                s += ind + "matchedFileMd5\n" ;
            }
        }
        //      C# -> System.String? MatchedFileSha1
        // GraphQL -> matchedFileSha1: String! (scalar)
        if (this.MatchedFileSha1 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedFileSha1\n" ;
            } else {
                s += ind + "matchedFileSha1\n" ;
            }
        }
        //      C# -> System.String? MatchedFileSha256
        // GraphQL -> matchedFileSha256: String! (scalar)
        if (this.MatchedFileSha256 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedFileSha256\n" ;
            } else {
                s += ind + "matchedFileSha256\n" ;
            }
        }
        //      C# -> List<IocDetails>? IocDetails
        // GraphQL -> iocDetails: [IOCDetails!]! (type)
        if (this.IocDetails != null) {
            var fspec = this.IocDetails.AsFieldSpec(conf.Child("iocDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "iocDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        if (ec.Includes("detectedSnapshotDate",true))
        {
            if(this.DetectedSnapshotDate == null) {

                this.DetectedSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.DetectedSnapshotDate != null && ec.Excludes("detectedSnapshotDate",true))
        {
            this.DetectedSnapshotDate = null;
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
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (ec.Includes("filePath",true))
        {
            if(this.FilePath == null) {

                this.FilePath = "FETCH";

            } else {


            }
        }
        else if (this.FilePath != null && ec.Excludes("filePath",true))
        {
            this.FilePath = null;
        }
        //      C# -> System.String? FirstDetectedSnapshotFid
        // GraphQL -> firstDetectedSnapshotFid: String! (scalar)
        if (ec.Includes("firstDetectedSnapshotFid",true))
        {
            if(this.FirstDetectedSnapshotFid == null) {

                this.FirstDetectedSnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.FirstDetectedSnapshotFid != null && ec.Excludes("firstDetectedSnapshotFid",true))
        {
            this.FirstDetectedSnapshotFid = null;
        }
        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        if (ec.Includes("isQuarantinedInFirstObservedSnapshot",true))
        {
            if(this.IsQuarantinedInFirstObservedSnapshot == null) {

                this.IsQuarantinedInFirstObservedSnapshot = true;

            } else {


            }
        }
        else if (this.IsQuarantinedInFirstObservedSnapshot != null && ec.Excludes("isQuarantinedInFirstObservedSnapshot",true))
        {
            this.IsQuarantinedInFirstObservedSnapshot = null;
        }
        //      C# -> System.String? MatchedFileMd5
        // GraphQL -> matchedFileMd5: String! (scalar)
        if (ec.Includes("matchedFileMd5",true))
        {
            if(this.MatchedFileMd5 == null) {

                this.MatchedFileMd5 = "FETCH";

            } else {


            }
        }
        else if (this.MatchedFileMd5 != null && ec.Excludes("matchedFileMd5",true))
        {
            this.MatchedFileMd5 = null;
        }
        //      C# -> System.String? MatchedFileSha1
        // GraphQL -> matchedFileSha1: String! (scalar)
        if (ec.Includes("matchedFileSha1",true))
        {
            if(this.MatchedFileSha1 == null) {

                this.MatchedFileSha1 = "FETCH";

            } else {


            }
        }
        else if (this.MatchedFileSha1 != null && ec.Excludes("matchedFileSha1",true))
        {
            this.MatchedFileSha1 = null;
        }
        //      C# -> System.String? MatchedFileSha256
        // GraphQL -> matchedFileSha256: String! (scalar)
        if (ec.Includes("matchedFileSha256",true))
        {
            if(this.MatchedFileSha256 == null) {

                this.MatchedFileSha256 = "FETCH";

            } else {


            }
        }
        else if (this.MatchedFileSha256 != null && ec.Excludes("matchedFileSha256",true))
        {
            this.MatchedFileSha256 = null;
        }
        //      C# -> List<IocDetails>? IocDetails
        // GraphQL -> iocDetails: [IOCDetails!]! (type)
        if (ec.Includes("iocDetails",false))
        {
            if(this.IocDetails == null) {

                this.IocDetails = new List<IocDetails>();
                this.IocDetails.ApplyExploratoryFieldSpec(ec.NewChild("iocDetails"));

            } else {

                this.IocDetails.ApplyExploratoryFieldSpec(ec.NewChild("iocDetails"));

            }
        }
        else if (this.IocDetails != null && ec.Excludes("iocDetails",false))
        {
            this.IocDetails = null;
        }
    }


    #endregion

    } // class ThreatMonitoringFileMatchDetailsV2
    
    #endregion

    public static class ListThreatMonitoringFileMatchDetailsV2Extensions
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
            this List<ThreatMonitoringFileMatchDetailsV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatMonitoringFileMatchDetailsV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringFileMatchDetailsV2> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringFileMatchDetailsV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatMonitoringFileMatchDetailsV2> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
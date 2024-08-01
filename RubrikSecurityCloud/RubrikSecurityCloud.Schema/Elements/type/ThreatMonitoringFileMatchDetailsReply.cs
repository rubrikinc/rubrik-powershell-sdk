// ThreatMonitoringFileMatchDetailsReply.cs
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
    #region ThreatMonitoringFileMatchDetailsReply
    public class ThreatMonitoringFileMatchDetailsReply: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

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

        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        [JsonProperty("intelSource")]
        public System.String? IntelSource { get; set; }

        //      C# -> System.String? IocRuleAuthor
        // GraphQL -> iocRuleAuthor: String! (scalar)
        [JsonProperty("iocRuleAuthor")]
        public System.String? IocRuleAuthor { get; set; }

        //      C# -> System.String? IocRuleDescription
        // GraphQL -> iocRuleDescription: String! (scalar)
        [JsonProperty("iocRuleDescription")]
        public System.String? IocRuleDescription { get; set; }

        //      C# -> System.String? IocRuleName
        // GraphQL -> iocRuleName: String! (scalar)
        [JsonProperty("iocRuleName")]
        public System.String? IocRuleName { get; set; }

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

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatMonitoringFileMatchDetailsReply";
    }

    public ThreatMonitoringFileMatchDetailsReply Set(
        IndicatorOfCompromiseKind? MatchType = null,
        DateTime? DetectedSnapshotDate = null,
        System.String? FileName = null,
        System.String? FilePath = null,
        System.String? FirstDetectedSnapshotFid = null,
        System.String? IntelSource = null,
        System.String? IocRuleAuthor = null,
        System.String? IocRuleDescription = null,
        System.String? IocRuleName = null,
        System.Boolean? IsQuarantinedInFirstObservedSnapshot = null,
        System.String? MatchedFileMd5 = null,
        System.String? MatchedFileSha1 = null,
        System.String? MatchedFileSha256 = null,
        System.String? ObjectFid = null,
        Cluster? Cluster = null
    ) 
    {
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
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
        if ( IntelSource != null ) {
            this.IntelSource = IntelSource;
        }
        if ( IocRuleAuthor != null ) {
            this.IocRuleAuthor = IocRuleAuthor;
        }
        if ( IocRuleDescription != null ) {
            this.IocRuleDescription = IocRuleDescription;
        }
        if ( IocRuleName != null ) {
            this.IocRuleName = IocRuleName;
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
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchType\n" ;
            } else {
                s += ind + "matchType\n" ;
            }
        }
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
        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        if (this.IntelSource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "intelSource\n" ;
            } else {
                s += ind + "intelSource\n" ;
            }
        }
        //      C# -> System.String? IocRuleAuthor
        // GraphQL -> iocRuleAuthor: String! (scalar)
        if (this.IocRuleAuthor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocRuleAuthor\n" ;
            } else {
                s += ind + "iocRuleAuthor\n" ;
            }
        }
        //      C# -> System.String? IocRuleDescription
        // GraphQL -> iocRuleDescription: String! (scalar)
        if (this.IocRuleDescription != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocRuleDescription\n" ;
            } else {
                s += ind + "iocRuleDescription\n" ;
            }
        }
        //      C# -> System.String? IocRuleName
        // GraphQL -> iocRuleName: String! (scalar)
        if (this.IocRuleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocRuleName\n" ;
            } else {
                s += ind + "iocRuleName\n" ;
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
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectFid\n" ;
            } else {
                s += ind + "objectFid\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (ec.Includes("matchType",true))
        {
            if(this.MatchType == null) {

                this.MatchType = new IndicatorOfCompromiseKind();

            } else {


            }
        }
        else if (this.MatchType != null && ec.Excludes("matchType",true))
        {
            this.MatchType = null;
        }
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
        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        if (ec.Includes("intelSource",true))
        {
            if(this.IntelSource == null) {

                this.IntelSource = "FETCH";

            } else {


            }
        }
        else if (this.IntelSource != null && ec.Excludes("intelSource",true))
        {
            this.IntelSource = null;
        }
        //      C# -> System.String? IocRuleAuthor
        // GraphQL -> iocRuleAuthor: String! (scalar)
        if (ec.Includes("iocRuleAuthor",true))
        {
            if(this.IocRuleAuthor == null) {

                this.IocRuleAuthor = "FETCH";

            } else {


            }
        }
        else if (this.IocRuleAuthor != null && ec.Excludes("iocRuleAuthor",true))
        {
            this.IocRuleAuthor = null;
        }
        //      C# -> System.String? IocRuleDescription
        // GraphQL -> iocRuleDescription: String! (scalar)
        if (ec.Includes("iocRuleDescription",true))
        {
            if(this.IocRuleDescription == null) {

                this.IocRuleDescription = "FETCH";

            } else {


            }
        }
        else if (this.IocRuleDescription != null && ec.Excludes("iocRuleDescription",true))
        {
            this.IocRuleDescription = null;
        }
        //      C# -> System.String? IocRuleName
        // GraphQL -> iocRuleName: String! (scalar)
        if (ec.Includes("iocRuleName",true))
        {
            if(this.IocRuleName == null) {

                this.IocRuleName = "FETCH";

            } else {


            }
        }
        else if (this.IocRuleName != null && ec.Excludes("iocRuleName",true))
        {
            this.IocRuleName = null;
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
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (ec.Includes("objectFid",true))
        {
            if(this.ObjectFid == null) {

                this.ObjectFid = "FETCH";

            } else {


            }
        }
        else if (this.ObjectFid != null && ec.Excludes("objectFid",true))
        {
            this.ObjectFid = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
    }


    #endregion

    } // class ThreatMonitoringFileMatchDetailsReply
    
    #endregion

    public static class ListThreatMonitoringFileMatchDetailsReplyExtensions
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
            this List<ThreatMonitoringFileMatchDetailsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatMonitoringFileMatchDetailsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringFileMatchDetailsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringFileMatchDetailsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatMonitoringFileMatchDetailsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
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

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

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


        #endregion

    #region methods

    public ThreatMonitoringFileMatchDetailsReply Set(
        IndicatorOfCompromiseKind? MatchType = null,
        DateTime? DetectedSnapshotDate = null,
        System.String? FirstDetectedSnapshotFid = null,
        System.String? IntelSource = null,
        System.String? IocRuleAuthor = null,
        System.String? IocRuleDescription = null,
        System.String? IocRuleName = null,
        System.Boolean? IsQuarantined = null,
        System.String? MatchedFileMd5 = null,
        System.String? MatchedFileSha1 = null,
        System.String? MatchedFileSha256 = null
    ) 
    {
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
        if ( DetectedSnapshotDate != null ) {
            this.DetectedSnapshotDate = DetectedSnapshotDate;
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
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType != null) {
            s += ind + "matchType\n" ;
        }
        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        if (this.DetectedSnapshotDate != null) {
            s += ind + "detectedSnapshotDate\n" ;
        }
        //      C# -> System.String? FirstDetectedSnapshotFid
        // GraphQL -> firstDetectedSnapshotFid: String! (scalar)
        if (this.FirstDetectedSnapshotFid != null) {
            s += ind + "firstDetectedSnapshotFid\n" ;
        }
        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        if (this.IntelSource != null) {
            s += ind + "intelSource\n" ;
        }
        //      C# -> System.String? IocRuleAuthor
        // GraphQL -> iocRuleAuthor: String! (scalar)
        if (this.IocRuleAuthor != null) {
            s += ind + "iocRuleAuthor\n" ;
        }
        //      C# -> System.String? IocRuleDescription
        // GraphQL -> iocRuleDescription: String! (scalar)
        if (this.IocRuleDescription != null) {
            s += ind + "iocRuleDescription\n" ;
        }
        //      C# -> System.String? IocRuleName
        // GraphQL -> iocRuleName: String! (scalar)
        if (this.IocRuleName != null) {
            s += ind + "iocRuleName\n" ;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            s += ind + "isQuarantined\n" ;
        }
        //      C# -> System.String? MatchedFileMd5
        // GraphQL -> matchedFileMd5: String! (scalar)
        if (this.MatchedFileMd5 != null) {
            s += ind + "matchedFileMd5\n" ;
        }
        //      C# -> System.String? MatchedFileSha1
        // GraphQL -> matchedFileSha1: String! (scalar)
        if (this.MatchedFileSha1 != null) {
            s += ind + "matchedFileSha1\n" ;
        }
        //      C# -> System.String? MatchedFileSha256
        // GraphQL -> matchedFileSha256: String! (scalar)
        if (this.MatchedFileSha256 != null) {
            s += ind + "matchedFileSha256\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType == null && Exploration.Includes(parent + ".matchType", true))
        {
            this.MatchType = new IndicatorOfCompromiseKind();
        }
        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        if (this.DetectedSnapshotDate == null && Exploration.Includes(parent + ".detectedSnapshotDate", true))
        {
            this.DetectedSnapshotDate = new DateTime();
        }
        //      C# -> System.String? FirstDetectedSnapshotFid
        // GraphQL -> firstDetectedSnapshotFid: String! (scalar)
        if (this.FirstDetectedSnapshotFid == null && Exploration.Includes(parent + ".firstDetectedSnapshotFid", true))
        {
            this.FirstDetectedSnapshotFid = "FETCH";
        }
        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        if (this.IntelSource == null && Exploration.Includes(parent + ".intelSource", true))
        {
            this.IntelSource = "FETCH";
        }
        //      C# -> System.String? IocRuleAuthor
        // GraphQL -> iocRuleAuthor: String! (scalar)
        if (this.IocRuleAuthor == null && Exploration.Includes(parent + ".iocRuleAuthor", true))
        {
            this.IocRuleAuthor = "FETCH";
        }
        //      C# -> System.String? IocRuleDescription
        // GraphQL -> iocRuleDescription: String! (scalar)
        if (this.IocRuleDescription == null && Exploration.Includes(parent + ".iocRuleDescription", true))
        {
            this.IocRuleDescription = "FETCH";
        }
        //      C# -> System.String? IocRuleName
        // GraphQL -> iocRuleName: String! (scalar)
        if (this.IocRuleName == null && Exploration.Includes(parent + ".iocRuleName", true))
        {
            this.IocRuleName = "FETCH";
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined", true))
        {
            this.IsQuarantined = true;
        }
        //      C# -> System.String? MatchedFileMd5
        // GraphQL -> matchedFileMd5: String! (scalar)
        if (this.MatchedFileMd5 == null && Exploration.Includes(parent + ".matchedFileMd5", true))
        {
            this.MatchedFileMd5 = "FETCH";
        }
        //      C# -> System.String? MatchedFileSha1
        // GraphQL -> matchedFileSha1: String! (scalar)
        if (this.MatchedFileSha1 == null && Exploration.Includes(parent + ".matchedFileSha1", true))
        {
            this.MatchedFileSha1 = "FETCH";
        }
        //      C# -> System.String? MatchedFileSha256
        // GraphQL -> matchedFileSha256: String! (scalar)
        if (this.MatchedFileSha256 == null && Exploration.Includes(parent + ".matchedFileSha256", true))
        {
            this.MatchedFileSha256 = "FETCH";
        }
    }


    #endregion

    } // class ThreatMonitoringFileMatchDetailsReply
    
    #endregion

    public static class ListThreatMonitoringFileMatchDetailsReplyExtensions
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
            this List<ThreatMonitoringFileMatchDetailsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringFileMatchDetailsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringFileMatchDetailsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
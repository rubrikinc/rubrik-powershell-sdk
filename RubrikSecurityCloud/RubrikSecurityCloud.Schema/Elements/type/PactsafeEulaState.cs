// PactsafeEulaState.cs
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
    #region PactsafeEulaState
    public class PactsafeEulaState: BaseType
    {
        #region members

        //      C# -> System.Boolean? BypassCheck
        // GraphQL -> bypassCheck: Boolean! (scalar)
        [JsonProperty("bypassCheck")]
        public System.Boolean? BypassCheck { get; set; }

        //      C# -> System.String? ContractBase64
        // GraphQL -> contractBase64: String! (scalar)
        [JsonProperty("contractBase64")]
        public System.String? ContractBase64 { get; set; }

        //      C# -> System.String? CurrentMajorVersion
        // GraphQL -> currentMajorVersion: String! (scalar)
        [JsonProperty("currentMajorVersion")]
        public System.String? CurrentMajorVersion { get; set; }

        //      C# -> System.String? CurrentVersion
        // GraphQL -> currentVersion: String! (scalar)
        [JsonProperty("currentVersion")]
        public System.String? CurrentVersion { get; set; }

        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        [JsonProperty("deadline")]
        public DateTime? Deadline { get; set; }

        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: String! (scalar)
        [JsonProperty("downloadEndpoint")]
        public System.String? DownloadEndpoint { get; set; }

        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime (scalar)
        [JsonProperty("effectiveDate")]
        public DateTime? EffectiveDate { get; set; }

        //      C# -> DateTime? FirstSeenTimestamp
        // GraphQL -> firstSeenTimestamp: DateTime (scalar)
        [JsonProperty("firstSeenTimestamp")]
        public DateTime? FirstSeenTimestamp { get; set; }

        //      C# -> System.Boolean? IsAuthorizedSigner
        // GraphQL -> isAuthorizedSigner: Boolean! (scalar)
        [JsonProperty("isAuthorizedSigner")]
        public System.Boolean? IsAuthorizedSigner { get; set; }

        //      C# -> System.String? LatestVersionAccepted
        // GraphQL -> latestVersionAccepted: String! (scalar)
        [JsonProperty("latestVersionAccepted")]
        public System.String? LatestVersionAccepted { get; set; }

        //      C# -> List<System.String>? RequiredEmailDomains
        // GraphQL -> requiredEmailDomains: [String!]! (scalar)
        [JsonProperty("requiredEmailDomains")]
        public List<System.String>? RequiredEmailDomains { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }


        #endregion

    #region methods

    public PactsafeEulaState Set(
        System.Boolean? BypassCheck = null,
        System.String? ContractBase64 = null,
        System.String? CurrentMajorVersion = null,
        System.String? CurrentVersion = null,
        DateTime? Deadline = null,
        System.String? DownloadEndpoint = null,
        DateTime? EffectiveDate = null,
        DateTime? FirstSeenTimestamp = null,
        System.Boolean? IsAuthorizedSigner = null,
        System.String? LatestVersionAccepted = null,
        List<System.String>? RequiredEmailDomains = null,
        System.String? Title = null
    ) 
    {
        if ( BypassCheck != null ) {
            this.BypassCheck = BypassCheck;
        }
        if ( ContractBase64 != null ) {
            this.ContractBase64 = ContractBase64;
        }
        if ( CurrentMajorVersion != null ) {
            this.CurrentMajorVersion = CurrentMajorVersion;
        }
        if ( CurrentVersion != null ) {
            this.CurrentVersion = CurrentVersion;
        }
        if ( Deadline != null ) {
            this.Deadline = Deadline;
        }
        if ( DownloadEndpoint != null ) {
            this.DownloadEndpoint = DownloadEndpoint;
        }
        if ( EffectiveDate != null ) {
            this.EffectiveDate = EffectiveDate;
        }
        if ( FirstSeenTimestamp != null ) {
            this.FirstSeenTimestamp = FirstSeenTimestamp;
        }
        if ( IsAuthorizedSigner != null ) {
            this.IsAuthorizedSigner = IsAuthorizedSigner;
        }
        if ( LatestVersionAccepted != null ) {
            this.LatestVersionAccepted = LatestVersionAccepted;
        }
        if ( RequiredEmailDomains != null ) {
            this.RequiredEmailDomains = RequiredEmailDomains;
        }
        if ( Title != null ) {
            this.Title = Title;
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
        //      C# -> System.Boolean? BypassCheck
        // GraphQL -> bypassCheck: Boolean! (scalar)
        if (this.BypassCheck != null) {
            s += ind + "bypassCheck\n" ;
        }
        //      C# -> System.String? ContractBase64
        // GraphQL -> contractBase64: String! (scalar)
        if (this.ContractBase64 != null) {
            s += ind + "contractBase64\n" ;
        }
        //      C# -> System.String? CurrentMajorVersion
        // GraphQL -> currentMajorVersion: String! (scalar)
        if (this.CurrentMajorVersion != null) {
            s += ind + "currentMajorVersion\n" ;
        }
        //      C# -> System.String? CurrentVersion
        // GraphQL -> currentVersion: String! (scalar)
        if (this.CurrentVersion != null) {
            s += ind + "currentVersion\n" ;
        }
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        if (this.Deadline != null) {
            s += ind + "deadline\n" ;
        }
        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: String! (scalar)
        if (this.DownloadEndpoint != null) {
            s += ind + "downloadEndpoint\n" ;
        }
        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime (scalar)
        if (this.EffectiveDate != null) {
            s += ind + "effectiveDate\n" ;
        }
        //      C# -> DateTime? FirstSeenTimestamp
        // GraphQL -> firstSeenTimestamp: DateTime (scalar)
        if (this.FirstSeenTimestamp != null) {
            s += ind + "firstSeenTimestamp\n" ;
        }
        //      C# -> System.Boolean? IsAuthorizedSigner
        // GraphQL -> isAuthorizedSigner: Boolean! (scalar)
        if (this.IsAuthorizedSigner != null) {
            s += ind + "isAuthorizedSigner\n" ;
        }
        //      C# -> System.String? LatestVersionAccepted
        // GraphQL -> latestVersionAccepted: String! (scalar)
        if (this.LatestVersionAccepted != null) {
            s += ind + "latestVersionAccepted\n" ;
        }
        //      C# -> List<System.String>? RequiredEmailDomains
        // GraphQL -> requiredEmailDomains: [String!]! (scalar)
        if (this.RequiredEmailDomains != null) {
            s += ind + "requiredEmailDomains\n" ;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? BypassCheck
        // GraphQL -> bypassCheck: Boolean! (scalar)
        if (this.BypassCheck == null && Exploration.Includes(parent + ".bypassCheck", true))
        {
            this.BypassCheck = true;
        }
        //      C# -> System.String? ContractBase64
        // GraphQL -> contractBase64: String! (scalar)
        if (this.ContractBase64 == null && Exploration.Includes(parent + ".contractBase64", true))
        {
            this.ContractBase64 = "FETCH";
        }
        //      C# -> System.String? CurrentMajorVersion
        // GraphQL -> currentMajorVersion: String! (scalar)
        if (this.CurrentMajorVersion == null && Exploration.Includes(parent + ".currentMajorVersion", true))
        {
            this.CurrentMajorVersion = "FETCH";
        }
        //      C# -> System.String? CurrentVersion
        // GraphQL -> currentVersion: String! (scalar)
        if (this.CurrentVersion == null && Exploration.Includes(parent + ".currentVersion", true))
        {
            this.CurrentVersion = "FETCH";
        }
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        if (this.Deadline == null && Exploration.Includes(parent + ".deadline", true))
        {
            this.Deadline = new DateTime();
        }
        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: String! (scalar)
        if (this.DownloadEndpoint == null && Exploration.Includes(parent + ".downloadEndpoint", true))
        {
            this.DownloadEndpoint = "FETCH";
        }
        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime (scalar)
        if (this.EffectiveDate == null && Exploration.Includes(parent + ".effectiveDate", true))
        {
            this.EffectiveDate = new DateTime();
        }
        //      C# -> DateTime? FirstSeenTimestamp
        // GraphQL -> firstSeenTimestamp: DateTime (scalar)
        if (this.FirstSeenTimestamp == null && Exploration.Includes(parent + ".firstSeenTimestamp", true))
        {
            this.FirstSeenTimestamp = new DateTime();
        }
        //      C# -> System.Boolean? IsAuthorizedSigner
        // GraphQL -> isAuthorizedSigner: Boolean! (scalar)
        if (this.IsAuthorizedSigner == null && Exploration.Includes(parent + ".isAuthorizedSigner", true))
        {
            this.IsAuthorizedSigner = true;
        }
        //      C# -> System.String? LatestVersionAccepted
        // GraphQL -> latestVersionAccepted: String! (scalar)
        if (this.LatestVersionAccepted == null && Exploration.Includes(parent + ".latestVersionAccepted", true))
        {
            this.LatestVersionAccepted = "FETCH";
        }
        //      C# -> List<System.String>? RequiredEmailDomains
        // GraphQL -> requiredEmailDomains: [String!]! (scalar)
        if (this.RequiredEmailDomains == null && Exploration.Includes(parent + ".requiredEmailDomains", true))
        {
            this.RequiredEmailDomains = new List<System.String>();
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && Exploration.Includes(parent + ".title", true))
        {
            this.Title = "FETCH";
        }
    }


    #endregion

    } // class PactsafeEulaState
    
    #endregion

    public static class ListPactsafeEulaStateExtensions
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
            this List<PactsafeEulaState> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PactsafeEulaState> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PactsafeEulaState());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
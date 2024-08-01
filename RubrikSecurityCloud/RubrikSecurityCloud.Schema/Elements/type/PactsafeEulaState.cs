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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "PactsafeEulaState";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? BypassCheck
        // GraphQL -> bypassCheck: Boolean! (scalar)
        if (this.BypassCheck != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bypassCheck\n" ;
            } else {
                s += ind + "bypassCheck\n" ;
            }
        }
        //      C# -> System.String? ContractBase64
        // GraphQL -> contractBase64: String! (scalar)
        if (this.ContractBase64 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contractBase64\n" ;
            } else {
                s += ind + "contractBase64\n" ;
            }
        }
        //      C# -> System.String? CurrentMajorVersion
        // GraphQL -> currentMajorVersion: String! (scalar)
        if (this.CurrentMajorVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentMajorVersion\n" ;
            } else {
                s += ind + "currentMajorVersion\n" ;
            }
        }
        //      C# -> System.String? CurrentVersion
        // GraphQL -> currentVersion: String! (scalar)
        if (this.CurrentVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentVersion\n" ;
            } else {
                s += ind + "currentVersion\n" ;
            }
        }
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        if (this.Deadline != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deadline\n" ;
            } else {
                s += ind + "deadline\n" ;
            }
        }
        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: String! (scalar)
        if (this.DownloadEndpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadEndpoint\n" ;
            } else {
                s += ind + "downloadEndpoint\n" ;
            }
        }
        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime (scalar)
        if (this.EffectiveDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveDate\n" ;
            } else {
                s += ind + "effectiveDate\n" ;
            }
        }
        //      C# -> DateTime? FirstSeenTimestamp
        // GraphQL -> firstSeenTimestamp: DateTime (scalar)
        if (this.FirstSeenTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstSeenTimestamp\n" ;
            } else {
                s += ind + "firstSeenTimestamp\n" ;
            }
        }
        //      C# -> System.Boolean? IsAuthorizedSigner
        // GraphQL -> isAuthorizedSigner: Boolean! (scalar)
        if (this.IsAuthorizedSigner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAuthorizedSigner\n" ;
            } else {
                s += ind + "isAuthorizedSigner\n" ;
            }
        }
        //      C# -> System.String? LatestVersionAccepted
        // GraphQL -> latestVersionAccepted: String! (scalar)
        if (this.LatestVersionAccepted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestVersionAccepted\n" ;
            } else {
                s += ind + "latestVersionAccepted\n" ;
            }
        }
        //      C# -> List<System.String>? RequiredEmailDomains
        // GraphQL -> requiredEmailDomains: [String!]! (scalar)
        if (this.RequiredEmailDomains != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requiredEmailDomains\n" ;
            } else {
                s += ind + "requiredEmailDomains\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? BypassCheck
        // GraphQL -> bypassCheck: Boolean! (scalar)
        if (ec.Includes("bypassCheck",true))
        {
            if(this.BypassCheck == null) {

                this.BypassCheck = true;

            } else {


            }
        }
        else if (this.BypassCheck != null && ec.Excludes("bypassCheck",true))
        {
            this.BypassCheck = null;
        }
        //      C# -> System.String? ContractBase64
        // GraphQL -> contractBase64: String! (scalar)
        if (ec.Includes("contractBase64",true))
        {
            if(this.ContractBase64 == null) {

                this.ContractBase64 = "FETCH";

            } else {


            }
        }
        else if (this.ContractBase64 != null && ec.Excludes("contractBase64",true))
        {
            this.ContractBase64 = null;
        }
        //      C# -> System.String? CurrentMajorVersion
        // GraphQL -> currentMajorVersion: String! (scalar)
        if (ec.Includes("currentMajorVersion",true))
        {
            if(this.CurrentMajorVersion == null) {

                this.CurrentMajorVersion = "FETCH";

            } else {


            }
        }
        else if (this.CurrentMajorVersion != null && ec.Excludes("currentMajorVersion",true))
        {
            this.CurrentMajorVersion = null;
        }
        //      C# -> System.String? CurrentVersion
        // GraphQL -> currentVersion: String! (scalar)
        if (ec.Includes("currentVersion",true))
        {
            if(this.CurrentVersion == null) {

                this.CurrentVersion = "FETCH";

            } else {


            }
        }
        else if (this.CurrentVersion != null && ec.Excludes("currentVersion",true))
        {
            this.CurrentVersion = null;
        }
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        if (ec.Includes("deadline",true))
        {
            if(this.Deadline == null) {

                this.Deadline = new DateTime();

            } else {


            }
        }
        else if (this.Deadline != null && ec.Excludes("deadline",true))
        {
            this.Deadline = null;
        }
        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: String! (scalar)
        if (ec.Includes("downloadEndpoint",true))
        {
            if(this.DownloadEndpoint == null) {

                this.DownloadEndpoint = "FETCH";

            } else {


            }
        }
        else if (this.DownloadEndpoint != null && ec.Excludes("downloadEndpoint",true))
        {
            this.DownloadEndpoint = null;
        }
        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime (scalar)
        if (ec.Includes("effectiveDate",true))
        {
            if(this.EffectiveDate == null) {

                this.EffectiveDate = new DateTime();

            } else {


            }
        }
        else if (this.EffectiveDate != null && ec.Excludes("effectiveDate",true))
        {
            this.EffectiveDate = null;
        }
        //      C# -> DateTime? FirstSeenTimestamp
        // GraphQL -> firstSeenTimestamp: DateTime (scalar)
        if (ec.Includes("firstSeenTimestamp",true))
        {
            if(this.FirstSeenTimestamp == null) {

                this.FirstSeenTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.FirstSeenTimestamp != null && ec.Excludes("firstSeenTimestamp",true))
        {
            this.FirstSeenTimestamp = null;
        }
        //      C# -> System.Boolean? IsAuthorizedSigner
        // GraphQL -> isAuthorizedSigner: Boolean! (scalar)
        if (ec.Includes("isAuthorizedSigner",true))
        {
            if(this.IsAuthorizedSigner == null) {

                this.IsAuthorizedSigner = true;

            } else {


            }
        }
        else if (this.IsAuthorizedSigner != null && ec.Excludes("isAuthorizedSigner",true))
        {
            this.IsAuthorizedSigner = null;
        }
        //      C# -> System.String? LatestVersionAccepted
        // GraphQL -> latestVersionAccepted: String! (scalar)
        if (ec.Includes("latestVersionAccepted",true))
        {
            if(this.LatestVersionAccepted == null) {

                this.LatestVersionAccepted = "FETCH";

            } else {


            }
        }
        else if (this.LatestVersionAccepted != null && ec.Excludes("latestVersionAccepted",true))
        {
            this.LatestVersionAccepted = null;
        }
        //      C# -> List<System.String>? RequiredEmailDomains
        // GraphQL -> requiredEmailDomains: [String!]! (scalar)
        if (ec.Includes("requiredEmailDomains",true))
        {
            if(this.RequiredEmailDomains == null) {

                this.RequiredEmailDomains = new List<System.String>();

            } else {


            }
        }
        else if (this.RequiredEmailDomains != null && ec.Excludes("requiredEmailDomains",true))
        {
            this.RequiredEmailDomains = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
    }


    #endregion

    } // class PactsafeEulaState
    
    #endregion

    public static class ListPactsafeEulaStateExtensions
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
            this List<PactsafeEulaState> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PactsafeEulaState> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PactsafeEulaState> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PactsafeEulaState());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PactsafeEulaState> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
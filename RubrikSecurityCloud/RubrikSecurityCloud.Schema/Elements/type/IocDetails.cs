// IocDetails.cs
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
    #region IocDetails
    public class IocDetails: BaseType
    {
        #region members

        //      C# -> FeedEntryStatus? IocStatus
        // GraphQL -> iocStatus: FeedEntryStatus! (enum)
        [JsonProperty("iocStatus")]
        public FeedEntryStatus? IocStatus { get; set; }

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        //      C# -> System.String? IntelFeedName
        // GraphQL -> intelFeedName: String! (scalar)
        [JsonProperty("intelFeedName")]
        public System.String? IntelFeedName { get; set; }

        //      C# -> System.String? IocHashHex
        // GraphQL -> iocHashHex: String! (scalar)
        [JsonProperty("iocHashHex")]
        public System.String? IocHashHex { get; set; }

        //      C# -> System.String? IocRuleAuthor
        // GraphQL -> iocRuleAuthor: String! (scalar)
        [JsonProperty("iocRuleAuthor")]
        public System.String? IocRuleAuthor { get; set; }

        //      C# -> System.String? MalwareDescription
        // GraphQL -> malwareDescription: String! (scalar)
        [JsonProperty("malwareDescription")]
        public System.String? MalwareDescription { get; set; }

        //      C# -> System.String? MalwareName
        // GraphQL -> malwareName: String! (scalar)
        [JsonProperty("malwareName")]
        public System.String? MalwareName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IOCDetails";
    }

    public IocDetails Set(
        FeedEntryStatus? IocStatus = null,
        IndicatorOfCompromiseKind? MatchType = null,
        System.String? IntelFeedName = null,
        System.String? IocHashHex = null,
        System.String? IocRuleAuthor = null,
        System.String? MalwareDescription = null,
        System.String? MalwareName = null
    ) 
    {
        if ( IocStatus != null ) {
            this.IocStatus = IocStatus;
        }
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
        if ( IntelFeedName != null ) {
            this.IntelFeedName = IntelFeedName;
        }
        if ( IocHashHex != null ) {
            this.IocHashHex = IocHashHex;
        }
        if ( IocRuleAuthor != null ) {
            this.IocRuleAuthor = IocRuleAuthor;
        }
        if ( MalwareDescription != null ) {
            this.MalwareDescription = MalwareDescription;
        }
        if ( MalwareName != null ) {
            this.MalwareName = MalwareName;
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
        //      C# -> FeedEntryStatus? IocStatus
        // GraphQL -> iocStatus: FeedEntryStatus! (enum)
        if (this.IocStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocStatus\n" ;
            } else {
                s += ind + "iocStatus\n" ;
            }
        }
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchType\n" ;
            } else {
                s += ind + "matchType\n" ;
            }
        }
        //      C# -> System.String? IntelFeedName
        // GraphQL -> intelFeedName: String! (scalar)
        if (this.IntelFeedName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "intelFeedName\n" ;
            } else {
                s += ind + "intelFeedName\n" ;
            }
        }
        //      C# -> System.String? IocHashHex
        // GraphQL -> iocHashHex: String! (scalar)
        if (this.IocHashHex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocHashHex\n" ;
            } else {
                s += ind + "iocHashHex\n" ;
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
        //      C# -> System.String? MalwareDescription
        // GraphQL -> malwareDescription: String! (scalar)
        if (this.MalwareDescription != null) {
            if (conf.Flat) {
                s += conf.Prefix + "malwareDescription\n" ;
            } else {
                s += ind + "malwareDescription\n" ;
            }
        }
        //      C# -> System.String? MalwareName
        // GraphQL -> malwareName: String! (scalar)
        if (this.MalwareName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "malwareName\n" ;
            } else {
                s += ind + "malwareName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FeedEntryStatus? IocStatus
        // GraphQL -> iocStatus: FeedEntryStatus! (enum)
        if (ec.Includes("iocStatus",true))
        {
            if(this.IocStatus == null) {

                this.IocStatus = new FeedEntryStatus();

            } else {


            }
        }
        else if (this.IocStatus != null && ec.Excludes("iocStatus",true))
        {
            this.IocStatus = null;
        }
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
        //      C# -> System.String? IntelFeedName
        // GraphQL -> intelFeedName: String! (scalar)
        if (ec.Includes("intelFeedName",true))
        {
            if(this.IntelFeedName == null) {

                this.IntelFeedName = "FETCH";

            } else {


            }
        }
        else if (this.IntelFeedName != null && ec.Excludes("intelFeedName",true))
        {
            this.IntelFeedName = null;
        }
        //      C# -> System.String? IocHashHex
        // GraphQL -> iocHashHex: String! (scalar)
        if (ec.Includes("iocHashHex",true))
        {
            if(this.IocHashHex == null) {

                this.IocHashHex = "FETCH";

            } else {


            }
        }
        else if (this.IocHashHex != null && ec.Excludes("iocHashHex",true))
        {
            this.IocHashHex = null;
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
        //      C# -> System.String? MalwareDescription
        // GraphQL -> malwareDescription: String! (scalar)
        if (ec.Includes("malwareDescription",true))
        {
            if(this.MalwareDescription == null) {

                this.MalwareDescription = "FETCH";

            } else {


            }
        }
        else if (this.MalwareDescription != null && ec.Excludes("malwareDescription",true))
        {
            this.MalwareDescription = null;
        }
        //      C# -> System.String? MalwareName
        // GraphQL -> malwareName: String! (scalar)
        if (ec.Includes("malwareName",true))
        {
            if(this.MalwareName == null) {

                this.MalwareName = "FETCH";

            } else {


            }
        }
        else if (this.MalwareName != null && ec.Excludes("malwareName",true))
        {
            this.MalwareName = null;
        }
    }


    #endregion

    } // class IocDetails
    
    #endregion

    public static class ListIocDetailsExtensions
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
            this List<IocDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IocDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IocDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IocDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IocDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
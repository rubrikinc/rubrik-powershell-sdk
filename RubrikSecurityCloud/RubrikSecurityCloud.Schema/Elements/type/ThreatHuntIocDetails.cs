// ThreatHuntIocDetails.cs
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
    #region ThreatHuntIocDetails
    public class ThreatHuntIocDetails: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        //      C# -> System.String? FilePatternRule
        // GraphQL -> filePatternRule: String! (scalar)
        [JsonProperty("filePatternRule")]
        public System.String? FilePatternRule { get; set; }

        //      C# -> System.String? IntelFeedName
        // GraphQL -> intelFeedName: String! (scalar)
        [JsonProperty("intelFeedName")]
        public System.String? IntelFeedName { get; set; }

        //      C# -> System.String? ThreatFamily
        // GraphQL -> threatFamily: String! (scalar)
        [JsonProperty("threatFamily")]
        public System.String? ThreatFamily { get; set; }

        //      C# -> System.String? YaraRule
        // GraphQL -> yaraRule: String! (scalar)
        [JsonProperty("yaraRule")]
        public System.String? YaraRule { get; set; }

        //      C# -> HashInfo? HashRule
        // GraphQL -> hashRule: HashInfo (type)
        [JsonProperty("hashRule")]
        public HashInfo? HashRule { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntIocDetails";
    }

    public ThreatHuntIocDetails Set(
        IndicatorOfCompromiseKind? MatchType = null,
        System.String? FilePatternRule = null,
        System.String? IntelFeedName = null,
        System.String? ThreatFamily = null,
        System.String? YaraRule = null,
        HashInfo? HashRule = null
    ) 
    {
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
        if ( FilePatternRule != null ) {
            this.FilePatternRule = FilePatternRule;
        }
        if ( IntelFeedName != null ) {
            this.IntelFeedName = IntelFeedName;
        }
        if ( ThreatFamily != null ) {
            this.ThreatFamily = ThreatFamily;
        }
        if ( YaraRule != null ) {
            this.YaraRule = YaraRule;
        }
        if ( HashRule != null ) {
            this.HashRule = HashRule;
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
        //      C# -> System.String? FilePatternRule
        // GraphQL -> filePatternRule: String! (scalar)
        if (this.FilePatternRule != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filePatternRule\n" ;
            } else {
                s += ind + "filePatternRule\n" ;
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
        //      C# -> System.String? ThreatFamily
        // GraphQL -> threatFamily: String! (scalar)
        if (this.ThreatFamily != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threatFamily\n" ;
            } else {
                s += ind + "threatFamily\n" ;
            }
        }
        //      C# -> System.String? YaraRule
        // GraphQL -> yaraRule: String! (scalar)
        if (this.YaraRule != null) {
            if (conf.Flat) {
                s += conf.Prefix + "yaraRule\n" ;
            } else {
                s += ind + "yaraRule\n" ;
            }
        }
        //      C# -> HashInfo? HashRule
        // GraphQL -> hashRule: HashInfo (type)
        if (this.HashRule != null) {
            var fspec = this.HashRule.AsFieldSpec(conf.Child("hashRule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hashRule" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> System.String? FilePatternRule
        // GraphQL -> filePatternRule: String! (scalar)
        if (ec.Includes("filePatternRule",true))
        {
            if(this.FilePatternRule == null) {

                this.FilePatternRule = "FETCH";

            } else {


            }
        }
        else if (this.FilePatternRule != null && ec.Excludes("filePatternRule",true))
        {
            this.FilePatternRule = null;
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
        //      C# -> System.String? ThreatFamily
        // GraphQL -> threatFamily: String! (scalar)
        if (ec.Includes("threatFamily",true))
        {
            if(this.ThreatFamily == null) {

                this.ThreatFamily = "FETCH";

            } else {


            }
        }
        else if (this.ThreatFamily != null && ec.Excludes("threatFamily",true))
        {
            this.ThreatFamily = null;
        }
        //      C# -> System.String? YaraRule
        // GraphQL -> yaraRule: String! (scalar)
        if (ec.Includes("yaraRule",true))
        {
            if(this.YaraRule == null) {

                this.YaraRule = "FETCH";

            } else {


            }
        }
        else if (this.YaraRule != null && ec.Excludes("yaraRule",true))
        {
            this.YaraRule = null;
        }
        //      C# -> HashInfo? HashRule
        // GraphQL -> hashRule: HashInfo (type)
        if (ec.Includes("hashRule",false))
        {
            if(this.HashRule == null) {

                this.HashRule = new HashInfo();
                this.HashRule.ApplyExploratoryFieldSpec(ec.NewChild("hashRule"));

            } else {

                this.HashRule.ApplyExploratoryFieldSpec(ec.NewChild("hashRule"));

            }
        }
        else if (this.HashRule != null && ec.Excludes("hashRule",false))
        {
            this.HashRule = null;
        }
    }


    #endregion

    } // class ThreatHuntIocDetails
    
    #endregion

    public static class ListThreatHuntIocDetailsExtensions
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
            this List<ThreatHuntIocDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntIocDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntIocDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntIocDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntIocDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
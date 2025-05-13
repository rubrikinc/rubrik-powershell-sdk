// FeedSummaryStats.cs
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
    #region FeedSummaryStats
    public class FeedSummaryStats: BaseType
    {
        #region members

        //      C# -> System.Int32? ActiveHashes
        // GraphQL -> activeHashes: Int! (scalar)
        [JsonProperty("activeHashes")]
        public System.Int32? ActiveHashes { get; set; }

        //      C# -> System.Int32? ActiveYaraRules
        // GraphQL -> activeYaraRules: Int! (scalar)
        [JsonProperty("activeYaraRules")]
        public System.Int32? ActiveYaraRules { get; set; }

        //      C# -> System.Int32? NotEnabledHashes
        // GraphQL -> notEnabledHashes: Int! (scalar)
        [JsonProperty("notEnabledHashes")]
        public System.Int32? NotEnabledHashes { get; set; }

        //      C# -> System.Int32? NotEnabledYaraRules
        // GraphQL -> notEnabledYaraRules: Int! (scalar)
        [JsonProperty("notEnabledYaraRules")]
        public System.Int32? NotEnabledYaraRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FeedSummaryStats";
    }

    public FeedSummaryStats Set(
        System.Int32? ActiveHashes = null,
        System.Int32? ActiveYaraRules = null,
        System.Int32? NotEnabledHashes = null,
        System.Int32? NotEnabledYaraRules = null
    ) 
    {
        if ( ActiveHashes != null ) {
            this.ActiveHashes = ActiveHashes;
        }
        if ( ActiveYaraRules != null ) {
            this.ActiveYaraRules = ActiveYaraRules;
        }
        if ( NotEnabledHashes != null ) {
            this.NotEnabledHashes = NotEnabledHashes;
        }
        if ( NotEnabledYaraRules != null ) {
            this.NotEnabledYaraRules = NotEnabledYaraRules;
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
        //      C# -> System.Int32? ActiveHashes
        // GraphQL -> activeHashes: Int! (scalar)
        if (this.ActiveHashes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeHashes\n" ;
            } else {
                s += ind + "activeHashes\n" ;
            }
        }
        //      C# -> System.Int32? ActiveYaraRules
        // GraphQL -> activeYaraRules: Int! (scalar)
        if (this.ActiveYaraRules != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeYaraRules\n" ;
            } else {
                s += ind + "activeYaraRules\n" ;
            }
        }
        //      C# -> System.Int32? NotEnabledHashes
        // GraphQL -> notEnabledHashes: Int! (scalar)
        if (this.NotEnabledHashes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notEnabledHashes\n" ;
            } else {
                s += ind + "notEnabledHashes\n" ;
            }
        }
        //      C# -> System.Int32? NotEnabledYaraRules
        // GraphQL -> notEnabledYaraRules: Int! (scalar)
        if (this.NotEnabledYaraRules != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notEnabledYaraRules\n" ;
            } else {
                s += ind + "notEnabledYaraRules\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? ActiveHashes
        // GraphQL -> activeHashes: Int! (scalar)
        if (ec.Includes("activeHashes",true))
        {
            if(this.ActiveHashes == null) {

                this.ActiveHashes = Int32.MinValue;

            } else {


            }
        }
        else if (this.ActiveHashes != null && ec.Excludes("activeHashes",true))
        {
            this.ActiveHashes = null;
        }
        //      C# -> System.Int32? ActiveYaraRules
        // GraphQL -> activeYaraRules: Int! (scalar)
        if (ec.Includes("activeYaraRules",true))
        {
            if(this.ActiveYaraRules == null) {

                this.ActiveYaraRules = Int32.MinValue;

            } else {


            }
        }
        else if (this.ActiveYaraRules != null && ec.Excludes("activeYaraRules",true))
        {
            this.ActiveYaraRules = null;
        }
        //      C# -> System.Int32? NotEnabledHashes
        // GraphQL -> notEnabledHashes: Int! (scalar)
        if (ec.Includes("notEnabledHashes",true))
        {
            if(this.NotEnabledHashes == null) {

                this.NotEnabledHashes = Int32.MinValue;

            } else {


            }
        }
        else if (this.NotEnabledHashes != null && ec.Excludes("notEnabledHashes",true))
        {
            this.NotEnabledHashes = null;
        }
        //      C# -> System.Int32? NotEnabledYaraRules
        // GraphQL -> notEnabledYaraRules: Int! (scalar)
        if (ec.Includes("notEnabledYaraRules",true))
        {
            if(this.NotEnabledYaraRules == null) {

                this.NotEnabledYaraRules = Int32.MinValue;

            } else {


            }
        }
        else if (this.NotEnabledYaraRules != null && ec.Excludes("notEnabledYaraRules",true))
        {
            this.NotEnabledYaraRules = null;
        }
    }


    #endregion

    } // class FeedSummaryStats
    
    #endregion

    public static class ListFeedSummaryStatsExtensions
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
            this List<FeedSummaryStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FeedSummaryStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FeedSummaryStats> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FeedSummaryStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FeedSummaryStats> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
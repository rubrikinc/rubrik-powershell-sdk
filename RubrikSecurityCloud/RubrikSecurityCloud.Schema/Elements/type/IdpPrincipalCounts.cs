// IdpPrincipalCounts.cs
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
    #region IdpPrincipalCounts
    public class IdpPrincipalCounts: BaseType
    {
        #region members

        //      C# -> Count? AdCount
        // GraphQL -> adCount: Count (type)
        [JsonProperty("adCount")]
        public Count? AdCount { get; set; }

        //      C# -> Count? AwsCount
        // GraphQL -> awsCount: Count (type)
        [JsonProperty("awsCount")]
        public Count? AwsCount { get; set; }

        //      C# -> Count? EntraidCount
        // GraphQL -> entraidCount: Count (type)
        [JsonProperty("entraidCount")]
        public Count? EntraidCount { get; set; }

        //      C# -> Count? OktaCount
        // GraphQL -> oktaCount: Count (type)
        [JsonProperty("oktaCount")]
        public Count? OktaCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IDPPrincipalCounts";
    }

    public IdpPrincipalCounts Set(
        Count? AdCount = null,
        Count? AwsCount = null,
        Count? EntraidCount = null,
        Count? OktaCount = null
    ) 
    {
        if ( AdCount != null ) {
            this.AdCount = AdCount;
        }
        if ( AwsCount != null ) {
            this.AwsCount = AwsCount;
        }
        if ( EntraidCount != null ) {
            this.EntraidCount = EntraidCount;
        }
        if ( OktaCount != null ) {
            this.OktaCount = OktaCount;
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
        //      C# -> Count? AdCount
        // GraphQL -> adCount: Count (type)
        if (this.AdCount != null) {
            var fspec = this.AdCount.AsFieldSpec(conf.Child("adCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "adCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Count? AwsCount
        // GraphQL -> awsCount: Count (type)
        if (this.AwsCount != null) {
            var fspec = this.AwsCount.AsFieldSpec(conf.Child("awsCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Count? EntraidCount
        // GraphQL -> entraidCount: Count (type)
        if (this.EntraidCount != null) {
            var fspec = this.EntraidCount.AsFieldSpec(conf.Child("entraidCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entraidCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Count? OktaCount
        // GraphQL -> oktaCount: Count (type)
        if (this.OktaCount != null) {
            var fspec = this.OktaCount.AsFieldSpec(conf.Child("oktaCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oktaCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Count? AdCount
        // GraphQL -> adCount: Count (type)
        if (ec.Includes("adCount",false))
        {
            if(this.AdCount == null) {

                this.AdCount = new Count();
                this.AdCount.ApplyExploratoryFieldSpec(ec.NewChild("adCount"));

            } else {

                this.AdCount.ApplyExploratoryFieldSpec(ec.NewChild("adCount"));

            }
        }
        else if (this.AdCount != null && ec.Excludes("adCount",false))
        {
            this.AdCount = null;
        }
        //      C# -> Count? AwsCount
        // GraphQL -> awsCount: Count (type)
        if (ec.Includes("awsCount",false))
        {
            if(this.AwsCount == null) {

                this.AwsCount = new Count();
                this.AwsCount.ApplyExploratoryFieldSpec(ec.NewChild("awsCount"));

            } else {

                this.AwsCount.ApplyExploratoryFieldSpec(ec.NewChild("awsCount"));

            }
        }
        else if (this.AwsCount != null && ec.Excludes("awsCount",false))
        {
            this.AwsCount = null;
        }
        //      C# -> Count? EntraidCount
        // GraphQL -> entraidCount: Count (type)
        if (ec.Includes("entraidCount",false))
        {
            if(this.EntraidCount == null) {

                this.EntraidCount = new Count();
                this.EntraidCount.ApplyExploratoryFieldSpec(ec.NewChild("entraidCount"));

            } else {

                this.EntraidCount.ApplyExploratoryFieldSpec(ec.NewChild("entraidCount"));

            }
        }
        else if (this.EntraidCount != null && ec.Excludes("entraidCount",false))
        {
            this.EntraidCount = null;
        }
        //      C# -> Count? OktaCount
        // GraphQL -> oktaCount: Count (type)
        if (ec.Includes("oktaCount",false))
        {
            if(this.OktaCount == null) {

                this.OktaCount = new Count();
                this.OktaCount.ApplyExploratoryFieldSpec(ec.NewChild("oktaCount"));

            } else {

                this.OktaCount.ApplyExploratoryFieldSpec(ec.NewChild("oktaCount"));

            }
        }
        else if (this.OktaCount != null && ec.Excludes("oktaCount",false))
        {
            this.OktaCount = null;
        }
    }


    #endregion

    } // class IdpPrincipalCounts
    
    #endregion

    public static class ListIdpPrincipalCountsExtensions
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
            this List<IdpPrincipalCounts> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdpPrincipalCounts> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdpPrincipalCounts> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdpPrincipalCounts());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdpPrincipalCounts> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
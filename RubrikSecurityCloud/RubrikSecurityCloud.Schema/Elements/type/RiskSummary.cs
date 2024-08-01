// RiskSummary.cs
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
    #region RiskSummary
    public class RiskSummary: BaseType
    {
        #region members

        //      C# -> PrincipalRiskCount? HighRiskPrincipals
        // GraphQL -> highRiskPrincipals: PrincipalRiskCount (type)
        [JsonProperty("highRiskPrincipals")]
        public PrincipalRiskCount? HighRiskPrincipals { get; set; }

        //      C# -> PrincipalRiskCount? LowRiskPrincipals
        // GraphQL -> lowRiskPrincipals: PrincipalRiskCount (type)
        [JsonProperty("lowRiskPrincipals")]
        public PrincipalRiskCount? LowRiskPrincipals { get; set; }

        //      C# -> PrincipalRiskCount? MediumRiskPrincipals
        // GraphQL -> mediumRiskPrincipals: PrincipalRiskCount (type)
        [JsonProperty("mediumRiskPrincipals")]
        public PrincipalRiskCount? MediumRiskPrincipals { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RiskSummary";
    }

    public RiskSummary Set(
        PrincipalRiskCount? HighRiskPrincipals = null,
        PrincipalRiskCount? LowRiskPrincipals = null,
        PrincipalRiskCount? MediumRiskPrincipals = null
    ) 
    {
        if ( HighRiskPrincipals != null ) {
            this.HighRiskPrincipals = HighRiskPrincipals;
        }
        if ( LowRiskPrincipals != null ) {
            this.LowRiskPrincipals = LowRiskPrincipals;
        }
        if ( MediumRiskPrincipals != null ) {
            this.MediumRiskPrincipals = MediumRiskPrincipals;
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
        //      C# -> PrincipalRiskCount? HighRiskPrincipals
        // GraphQL -> highRiskPrincipals: PrincipalRiskCount (type)
        if (this.HighRiskPrincipals != null) {
            var fspec = this.HighRiskPrincipals.AsFieldSpec(conf.Child("highRiskPrincipals"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskPrincipals" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalRiskCount? LowRiskPrincipals
        // GraphQL -> lowRiskPrincipals: PrincipalRiskCount (type)
        if (this.LowRiskPrincipals != null) {
            var fspec = this.LowRiskPrincipals.AsFieldSpec(conf.Child("lowRiskPrincipals"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowRiskPrincipals" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalRiskCount? MediumRiskPrincipals
        // GraphQL -> mediumRiskPrincipals: PrincipalRiskCount (type)
        if (this.MediumRiskPrincipals != null) {
            var fspec = this.MediumRiskPrincipals.AsFieldSpec(conf.Child("mediumRiskPrincipals"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mediumRiskPrincipals" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PrincipalRiskCount? HighRiskPrincipals
        // GraphQL -> highRiskPrincipals: PrincipalRiskCount (type)
        if (ec.Includes("highRiskPrincipals",false))
        {
            if(this.HighRiskPrincipals == null) {

                this.HighRiskPrincipals = new PrincipalRiskCount();
                this.HighRiskPrincipals.ApplyExploratoryFieldSpec(ec.NewChild("highRiskPrincipals"));

            } else {

                this.HighRiskPrincipals.ApplyExploratoryFieldSpec(ec.NewChild("highRiskPrincipals"));

            }
        }
        else if (this.HighRiskPrincipals != null && ec.Excludes("highRiskPrincipals",false))
        {
            this.HighRiskPrincipals = null;
        }
        //      C# -> PrincipalRiskCount? LowRiskPrincipals
        // GraphQL -> lowRiskPrincipals: PrincipalRiskCount (type)
        if (ec.Includes("lowRiskPrincipals",false))
        {
            if(this.LowRiskPrincipals == null) {

                this.LowRiskPrincipals = new PrincipalRiskCount();
                this.LowRiskPrincipals.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskPrincipals"));

            } else {

                this.LowRiskPrincipals.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskPrincipals"));

            }
        }
        else if (this.LowRiskPrincipals != null && ec.Excludes("lowRiskPrincipals",false))
        {
            this.LowRiskPrincipals = null;
        }
        //      C# -> PrincipalRiskCount? MediumRiskPrincipals
        // GraphQL -> mediumRiskPrincipals: PrincipalRiskCount (type)
        if (ec.Includes("mediumRiskPrincipals",false))
        {
            if(this.MediumRiskPrincipals == null) {

                this.MediumRiskPrincipals = new PrincipalRiskCount();
                this.MediumRiskPrincipals.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskPrincipals"));

            } else {

                this.MediumRiskPrincipals.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskPrincipals"));

            }
        }
        else if (this.MediumRiskPrincipals != null && ec.Excludes("mediumRiskPrincipals",false))
        {
            this.MediumRiskPrincipals = null;
        }
    }


    #endregion

    } // class RiskSummary
    
    #endregion

    public static class ListRiskSummaryExtensions
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
            this List<RiskSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RiskSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RiskSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RiskSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RiskSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
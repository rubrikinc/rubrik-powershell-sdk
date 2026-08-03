// DataProtectionCoverageSummary.cs
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
    #region DataProtectionCoverageSummary
    public class DataProtectionCoverageSummary: BaseType
    {
        #region members

        //      C# -> PlatformProtectionCoverage? OverallProtectionCoverage
        // GraphQL -> overallProtectionCoverage: PlatformProtectionCoverage (type)
        [JsonProperty("overallProtectionCoverage")]
        public PlatformProtectionCoverage? OverallProtectionCoverage { get; set; }

        //      C# -> List<PlatformProtectionCoverage>? PlatformCoverage
        // GraphQL -> platformCoverage: [PlatformProtectionCoverage!]! (type)
        [JsonProperty("platformCoverage")]
        public List<PlatformProtectionCoverage>? PlatformCoverage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataProtectionCoverageSummary";
    }

    public DataProtectionCoverageSummary Set(
        PlatformProtectionCoverage? OverallProtectionCoverage = null,
        List<PlatformProtectionCoverage>? PlatformCoverage = null
    ) 
    {
        if ( OverallProtectionCoverage != null ) {
            this.OverallProtectionCoverage = OverallProtectionCoverage;
        }
        if ( PlatformCoverage != null ) {
            this.PlatformCoverage = PlatformCoverage;
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
        //      C# -> PlatformProtectionCoverage? OverallProtectionCoverage
        // GraphQL -> overallProtectionCoverage: PlatformProtectionCoverage (type)
        if (this.OverallProtectionCoverage != null) {
            var fspec = this.OverallProtectionCoverage.AsFieldSpec(conf.Child("overallProtectionCoverage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "overallProtectionCoverage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PlatformProtectionCoverage>? PlatformCoverage
        // GraphQL -> platformCoverage: [PlatformProtectionCoverage!]! (type)
        if (this.PlatformCoverage != null) {
            var fspec = this.PlatformCoverage.AsFieldSpec(conf.Child("platformCoverage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "platformCoverage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PlatformProtectionCoverage? OverallProtectionCoverage
        // GraphQL -> overallProtectionCoverage: PlatformProtectionCoverage (type)
        if (ec.Includes("overallProtectionCoverage",false))
        {
            if(this.OverallProtectionCoverage == null) {

                this.OverallProtectionCoverage = new PlatformProtectionCoverage();
                this.OverallProtectionCoverage.ApplyExploratoryFieldSpec(ec.NewChild("overallProtectionCoverage"));

            } else {

                this.OverallProtectionCoverage.ApplyExploratoryFieldSpec(ec.NewChild("overallProtectionCoverage"));

            }
        }
        else if (this.OverallProtectionCoverage != null && ec.Excludes("overallProtectionCoverage",false))
        {
            this.OverallProtectionCoverage = null;
        }
        //      C# -> List<PlatformProtectionCoverage>? PlatformCoverage
        // GraphQL -> platformCoverage: [PlatformProtectionCoverage!]! (type)
        if (ec.Includes("platformCoverage",false))
        {
            if(this.PlatformCoverage == null) {

                this.PlatformCoverage = new List<PlatformProtectionCoverage>();
                this.PlatformCoverage.ApplyExploratoryFieldSpec(ec.NewChild("platformCoverage"));

            } else {

                this.PlatformCoverage.ApplyExploratoryFieldSpec(ec.NewChild("platformCoverage"));

            }
        }
        else if (this.PlatformCoverage != null && ec.Excludes("platformCoverage",false))
        {
            this.PlatformCoverage = null;
        }
    }


    #endregion

    } // class DataProtectionCoverageSummary
    
    #endregion

    public static class ListDataProtectionCoverageSummaryExtensions
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
            this List<DataProtectionCoverageSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataProtectionCoverageSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataProtectionCoverageSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataProtectionCoverageSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataProtectionCoverageSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
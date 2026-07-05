// ViolationsSummary.cs
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
    #region ViolationsSummary
    public class ViolationsSummary: BaseType
    {
        #region members

        //      C# -> System.Int32? ViolationsCount
        // GraphQL -> violationsCount: Int! (scalar)
        [JsonProperty("violationsCount")]
        public System.Int32? ViolationsCount { get; set; }

        //      C# -> ViolationsInsights? ViolationsInsights
        // GraphQL -> violationsInsights: ViolationsInsights (union)
        [JsonProperty("violationsInsights")]
        public ViolationsInsights? ViolationsInsights { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ViolationsSummary";
    }

    public ViolationsSummary Set(
        System.Int32? ViolationsCount = null,
        ViolationsInsights? ViolationsInsights = null
    ) 
    {
        if ( ViolationsCount != null ) {
            this.ViolationsCount = ViolationsCount;
        }
        if ( ViolationsInsights != null ) {
            this.ViolationsInsights = ViolationsInsights;
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
        //      C# -> System.Int32? ViolationsCount
        // GraphQL -> violationsCount: Int! (scalar)
        if (this.ViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violationsCount\n" ;
            } else {
                s += ind + "violationsCount\n" ;
            }
        }
        //      C# -> ViolationsInsights? ViolationsInsights
        // GraphQL -> violationsInsights: ViolationsInsights (union)
        if (this.ViolationsInsights != null) {
            var fspec = this.ViolationsInsights.AsFieldSpec(conf.Child("violationsInsights"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "violationsInsights" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? ViolationsCount
        // GraphQL -> violationsCount: Int! (scalar)
        if (ec.Includes("violationsCount",true))
        {
            if(this.ViolationsCount == null) {

                this.ViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ViolationsCount != null && ec.Excludes("violationsCount",true))
        {
            this.ViolationsCount = null;
        }
        //      C# -> ViolationsInsights? ViolationsInsights
        // GraphQL -> violationsInsights: ViolationsInsights (union)
        if (ec.Includes("violationsInsights",false))
        {
            if(this.ViolationsInsights == null) {

                var impls = new List<ViolationsInsights>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("violationsInsights"));
                this.ViolationsInsights = (ViolationsInsights)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ViolationsInsights>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("violationsInsights"));
                this.ViolationsInsights = (ViolationsInsights)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ViolationsInsights != null && ec.Excludes("violationsInsights",false))
        {
            this.ViolationsInsights = null;
        }
    }


    #endregion

    } // class ViolationsSummary
    
    #endregion

    public static class ListViolationsSummaryExtensions
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
            this List<ViolationsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ViolationsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ViolationsSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ViolationsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ViolationsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
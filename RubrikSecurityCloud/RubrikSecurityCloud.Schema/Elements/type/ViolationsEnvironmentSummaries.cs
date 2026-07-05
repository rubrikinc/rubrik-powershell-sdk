// ViolationsEnvironmentSummaries.cs
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
    #region ViolationsEnvironmentSummaries
    public class ViolationsEnvironmentSummaries: BaseType
    {
        #region members

        //      C# -> List<ViolationsEnvironmentSummary>? ViolationsEnvSummary
        // GraphQL -> violationsEnvSummary: [ViolationsEnvironmentSummary!]! (type)
        [JsonProperty("violationsEnvSummary")]
        public List<ViolationsEnvironmentSummary>? ViolationsEnvSummary { get; set; }

        //      C# -> ViolationsEnvironmentSummary? ViolationsOverallSummary
        // GraphQL -> violationsOverallSummary: ViolationsEnvironmentSummary (type)
        [JsonProperty("violationsOverallSummary")]
        public ViolationsEnvironmentSummary? ViolationsOverallSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ViolationsEnvironmentSummaries";
    }

    public ViolationsEnvironmentSummaries Set(
        List<ViolationsEnvironmentSummary>? ViolationsEnvSummary = null,
        ViolationsEnvironmentSummary? ViolationsOverallSummary = null
    ) 
    {
        if ( ViolationsEnvSummary != null ) {
            this.ViolationsEnvSummary = ViolationsEnvSummary;
        }
        if ( ViolationsOverallSummary != null ) {
            this.ViolationsOverallSummary = ViolationsOverallSummary;
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
        //      C# -> List<ViolationsEnvironmentSummary>? ViolationsEnvSummary
        // GraphQL -> violationsEnvSummary: [ViolationsEnvironmentSummary!]! (type)
        if (this.ViolationsEnvSummary != null) {
            var fspec = this.ViolationsEnvSummary.AsFieldSpec(conf.Child("violationsEnvSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "violationsEnvSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ViolationsEnvironmentSummary? ViolationsOverallSummary
        // GraphQL -> violationsOverallSummary: ViolationsEnvironmentSummary (type)
        if (this.ViolationsOverallSummary != null) {
            var fspec = this.ViolationsOverallSummary.AsFieldSpec(conf.Child("violationsOverallSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "violationsOverallSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ViolationsEnvironmentSummary>? ViolationsEnvSummary
        // GraphQL -> violationsEnvSummary: [ViolationsEnvironmentSummary!]! (type)
        if (ec.Includes("violationsEnvSummary",false))
        {
            if(this.ViolationsEnvSummary == null) {

                this.ViolationsEnvSummary = new List<ViolationsEnvironmentSummary>();
                this.ViolationsEnvSummary.ApplyExploratoryFieldSpec(ec.NewChild("violationsEnvSummary"));

            } else {

                this.ViolationsEnvSummary.ApplyExploratoryFieldSpec(ec.NewChild("violationsEnvSummary"));

            }
        }
        else if (this.ViolationsEnvSummary != null && ec.Excludes("violationsEnvSummary",false))
        {
            this.ViolationsEnvSummary = null;
        }
        //      C# -> ViolationsEnvironmentSummary? ViolationsOverallSummary
        // GraphQL -> violationsOverallSummary: ViolationsEnvironmentSummary (type)
        if (ec.Includes("violationsOverallSummary",false))
        {
            if(this.ViolationsOverallSummary == null) {

                this.ViolationsOverallSummary = new ViolationsEnvironmentSummary();
                this.ViolationsOverallSummary.ApplyExploratoryFieldSpec(ec.NewChild("violationsOverallSummary"));

            } else {

                this.ViolationsOverallSummary.ApplyExploratoryFieldSpec(ec.NewChild("violationsOverallSummary"));

            }
        }
        else if (this.ViolationsOverallSummary != null && ec.Excludes("violationsOverallSummary",false))
        {
            this.ViolationsOverallSummary = null;
        }
    }


    #endregion

    } // class ViolationsEnvironmentSummaries
    
    #endregion

    public static class ListViolationsEnvironmentSummariesExtensions
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
            this List<ViolationsEnvironmentSummaries> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ViolationsEnvironmentSummaries> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ViolationsEnvironmentSummaries> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ViolationsEnvironmentSummaries());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ViolationsEnvironmentSummaries> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
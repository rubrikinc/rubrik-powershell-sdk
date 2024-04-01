// PatchNutanixMountV1Reply.cs
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
    #region PatchNutanixMountV1Reply
    public class PatchNutanixMountV1Reply: BaseType
    {
        #region members

        //      C# -> NutanixVmMountSummary? NutanixVmMountSummary
        // GraphQL -> nutanixVmMountSummary: NutanixVmMountSummary (type)
        [JsonProperty("nutanixVmMountSummary")]
        public NutanixVmMountSummary? NutanixVmMountSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PatchNutanixMountV1Reply";
    }

    public PatchNutanixMountV1Reply Set(
        NutanixVmMountSummary? NutanixVmMountSummary = null
    ) 
    {
        if ( NutanixVmMountSummary != null ) {
            this.NutanixVmMountSummary = NutanixVmMountSummary;
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
        //      C# -> NutanixVmMountSummary? NutanixVmMountSummary
        // GraphQL -> nutanixVmMountSummary: NutanixVmMountSummary (type)
        if (this.NutanixVmMountSummary != null) {
            var fspec = this.NutanixVmMountSummary.AsFieldSpec(conf.Child("nutanixVmMountSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixVmMountSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NutanixVmMountSummary? NutanixVmMountSummary
        // GraphQL -> nutanixVmMountSummary: NutanixVmMountSummary (type)
        if (ec.Includes("nutanixVmMountSummary",false))
        {
            if(this.NutanixVmMountSummary == null) {

                this.NutanixVmMountSummary = new NutanixVmMountSummary();
                this.NutanixVmMountSummary.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmMountSummary"));

            } else {

                this.NutanixVmMountSummary.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmMountSummary"));

            }
        }
        else if (this.NutanixVmMountSummary != null && ec.Excludes("nutanixVmMountSummary",false))
        {
            this.NutanixVmMountSummary = null;
        }
    }


    #endregion

    } // class PatchNutanixMountV1Reply
    
    #endregion

    public static class ListPatchNutanixMountV1ReplyExtensions
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
            this List<PatchNutanixMountV1Reply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PatchNutanixMountV1Reply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PatchNutanixMountV1Reply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PatchNutanixMountV1Reply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PatchNutanixMountV1Reply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
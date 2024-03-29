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
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<PatchNutanixMountV1Reply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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
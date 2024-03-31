// HypervScvmmUpdateReply.cs
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
    #region HypervScvmmUpdateReply
    public class HypervScvmmUpdateReply: BaseType
    {
        #region members

        //      C# -> HypervScvmmSummary? HypervScvmmSummary
        // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
        [JsonProperty("hypervScvmmSummary")]
        public HypervScvmmSummary? HypervScvmmSummary { get; set; }

        //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
        [JsonProperty("hypervScvmmUpdate")]
        public HypervScvmmUpdate? HypervScvmmUpdate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervScvmmUpdateReply";
    }

    public HypervScvmmUpdateReply Set(
        HypervScvmmSummary? HypervScvmmSummary = null,
        HypervScvmmUpdate? HypervScvmmUpdate = null
    ) 
    {
        if ( HypervScvmmSummary != null ) {
            this.HypervScvmmSummary = HypervScvmmSummary;
        }
        if ( HypervScvmmUpdate != null ) {
            this.HypervScvmmUpdate = HypervScvmmUpdate;
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
        //      C# -> HypervScvmmSummary? HypervScvmmSummary
        // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
        if (this.HypervScvmmSummary != null) {
            var fspec = this.HypervScvmmSummary.AsFieldSpec(conf.Child("hypervScvmmSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hypervScvmmSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
        if (this.HypervScvmmUpdate != null) {
            var fspec = this.HypervScvmmUpdate.AsFieldSpec(conf.Child("hypervScvmmUpdate"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hypervScvmmUpdate {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HypervScvmmSummary? HypervScvmmSummary
        // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
        if (ec.Includes("hypervScvmmSummary",false))
        {
            if(this.HypervScvmmSummary == null) {

                this.HypervScvmmSummary = new HypervScvmmSummary();
                this.HypervScvmmSummary.ApplyExploratoryFieldSpec(ec.NewChild("hypervScvmmSummary"));

            } else {

                this.HypervScvmmSummary.ApplyExploratoryFieldSpec(ec.NewChild("hypervScvmmSummary"));

            }
        }
        else if (this.HypervScvmmSummary != null && ec.Excludes("hypervScvmmSummary",false))
        {
            this.HypervScvmmSummary = null;
        }
        //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
        if (ec.Includes("hypervScvmmUpdate",false))
        {
            if(this.HypervScvmmUpdate == null) {

                this.HypervScvmmUpdate = new HypervScvmmUpdate();
                this.HypervScvmmUpdate.ApplyExploratoryFieldSpec(ec.NewChild("hypervScvmmUpdate"));

            } else {

                this.HypervScvmmUpdate.ApplyExploratoryFieldSpec(ec.NewChild("hypervScvmmUpdate"));

            }
        }
        else if (this.HypervScvmmUpdate != null && ec.Excludes("hypervScvmmUpdate",false))
        {
            this.HypervScvmmUpdate = null;
        }
    }


    #endregion

    } // class HypervScvmmUpdateReply
    
    #endregion

    public static class ListHypervScvmmUpdateReplyExtensions
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
            this List<HypervScvmmUpdateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervScvmmUpdateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervScvmmUpdateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervScvmmUpdateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervScvmmUpdateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
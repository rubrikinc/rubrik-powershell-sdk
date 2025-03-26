// NutanixVmSnapshotDetail.cs
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
    #region NutanixVmSnapshotDetail
    public class NutanixVmSnapshotDetail: BaseType
    {
        #region members

        //      C# -> NutanixVmSnapshotSummary? NutanixVmSnapshotSummary
        // GraphQL -> nutanixVmSnapshotSummary: NutanixVmSnapshotSummary (type)
        [JsonProperty("nutanixVmSnapshotSummary")]
        public NutanixVmSnapshotSummary? NutanixVmSnapshotSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmSnapshotDetail";
    }

    public NutanixVmSnapshotDetail Set(
        NutanixVmSnapshotSummary? NutanixVmSnapshotSummary = null
    ) 
    {
        if ( NutanixVmSnapshotSummary != null ) {
            this.NutanixVmSnapshotSummary = NutanixVmSnapshotSummary;
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
        //      C# -> NutanixVmSnapshotSummary? NutanixVmSnapshotSummary
        // GraphQL -> nutanixVmSnapshotSummary: NutanixVmSnapshotSummary (type)
        if (this.NutanixVmSnapshotSummary != null) {
            var fspec = this.NutanixVmSnapshotSummary.AsFieldSpec(conf.Child("nutanixVmSnapshotSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixVmSnapshotSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> NutanixVmSnapshotSummary? NutanixVmSnapshotSummary
        // GraphQL -> nutanixVmSnapshotSummary: NutanixVmSnapshotSummary (type)
        if (ec.Includes("nutanixVmSnapshotSummary",false))
        {
            if(this.NutanixVmSnapshotSummary == null) {

                this.NutanixVmSnapshotSummary = new NutanixVmSnapshotSummary();
                this.NutanixVmSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmSnapshotSummary"));

            } else {

                this.NutanixVmSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmSnapshotSummary"));

            }
        }
        else if (this.NutanixVmSnapshotSummary != null && ec.Excludes("nutanixVmSnapshotSummary",false))
        {
            this.NutanixVmSnapshotSummary = null;
        }
    }


    #endregion

    } // class NutanixVmSnapshotDetail
    
    #endregion

    public static class ListNutanixVmSnapshotDetailExtensions
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
            this List<NutanixVmSnapshotDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVmSnapshotDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmSnapshotDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmSnapshotDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmSnapshotDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
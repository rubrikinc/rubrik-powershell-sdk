// NutanixVmSnapshotSummary.cs
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
    #region NutanixVmSnapshotSummary
    public class NutanixVmSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.Int32? NicsInSnapshot
        // GraphQL -> nicsInSnapshot: Int (scalar)
        [JsonProperty("nicsInSnapshot")]
        public System.Int32? NicsInSnapshot { get; set; }

        //      C# -> List<System.String>? SnapshotNetworkUuids
        // GraphQL -> snapshotNetworkUuids: [String!]! (scalar)
        [JsonProperty("snapshotNetworkUuids")]
        public List<System.String>? SnapshotNetworkUuids { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmSnapshotSummary";
    }

    public NutanixVmSnapshotSummary Set(
        System.Int32? NicsInSnapshot = null,
        List<System.String>? SnapshotNetworkUuids = null,
        System.String? VmName = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( NicsInSnapshot != null ) {
            this.NicsInSnapshot = NicsInSnapshot;
        }
        if ( SnapshotNetworkUuids != null ) {
            this.SnapshotNetworkUuids = SnapshotNetworkUuids;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
        //      C# -> System.Int32? NicsInSnapshot
        // GraphQL -> nicsInSnapshot: Int (scalar)
        if (this.NicsInSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nicsInSnapshot\n" ;
            } else {
                s += ind + "nicsInSnapshot\n" ;
            }
        }
        //      C# -> List<System.String>? SnapshotNetworkUuids
        // GraphQL -> snapshotNetworkUuids: [String!]! (scalar)
        if (this.SnapshotNetworkUuids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotNetworkUuids\n" ;
            } else {
                s += ind + "snapshotNetworkUuids\n" ;
            }
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmName\n" ;
            } else {
                s += ind + "vmName\n" ;
            }
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(conf.Child("baseSnapshotSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseSnapshotSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NicsInSnapshot
        // GraphQL -> nicsInSnapshot: Int (scalar)
        if (ec.Includes("nicsInSnapshot",true))
        {
            if(this.NicsInSnapshot == null) {

                this.NicsInSnapshot = Int32.MinValue;

            } else {


            }
        }
        else if (this.NicsInSnapshot != null && ec.Excludes("nicsInSnapshot",true))
        {
            this.NicsInSnapshot = null;
        }
        //      C# -> List<System.String>? SnapshotNetworkUuids
        // GraphQL -> snapshotNetworkUuids: [String!]! (scalar)
        if (ec.Includes("snapshotNetworkUuids",true))
        {
            if(this.SnapshotNetworkUuids == null) {

                this.SnapshotNetworkUuids = new List<System.String>();

            } else {


            }
        }
        else if (this.SnapshotNetworkUuids != null && ec.Excludes("snapshotNetworkUuids",true))
        {
            this.SnapshotNetworkUuids = null;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (ec.Includes("vmName",true))
        {
            if(this.VmName == null) {

                this.VmName = "FETCH";

            } else {


            }
        }
        else if (this.VmName != null && ec.Excludes("vmName",true))
        {
            this.VmName = null;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (ec.Includes("baseSnapshotSummary",false))
        {
            if(this.BaseSnapshotSummary == null) {

                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            } else {

                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            }
        }
        else if (this.BaseSnapshotSummary != null && ec.Excludes("baseSnapshotSummary",false))
        {
            this.BaseSnapshotSummary = null;
        }
    }


    #endregion

    } // class NutanixVmSnapshotSummary
    
    #endregion

    public static class ListNutanixVmSnapshotSummaryExtensions
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
            this List<NutanixVmSnapshotSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVmSnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmSnapshotSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
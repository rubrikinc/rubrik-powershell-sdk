// UpdateHypervVirtualMachineSnapshotMountReply.cs
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
    #region UpdateHypervVirtualMachineSnapshotMountReply
    public class UpdateHypervVirtualMachineSnapshotMountReply: BaseType
    {
        #region members

        //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
        // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
        [JsonProperty("hypervVirtualMachineMountSummary")]
        public HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateHypervVirtualMachineSnapshotMountReply";
    }

    public UpdateHypervVirtualMachineSnapshotMountReply Set(
        HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary = null
    ) 
    {
        if ( HypervVirtualMachineMountSummary != null ) {
            this.HypervVirtualMachineMountSummary = HypervVirtualMachineMountSummary;
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
        //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
        // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
        if (this.HypervVirtualMachineMountSummary != null) {
            var fspec = this.HypervVirtualMachineMountSummary.AsFieldSpec(conf.Child("hypervVirtualMachineMountSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hypervVirtualMachineMountSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
        // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
        if (ec.Includes("hypervVirtualMachineMountSummary",false))
        {
            if(this.HypervVirtualMachineMountSummary == null) {

                this.HypervVirtualMachineMountSummary = new HypervVirtualMachineMountSummary();
                this.HypervVirtualMachineMountSummary.ApplyExploratoryFieldSpec(ec.NewChild("hypervVirtualMachineMountSummary"));

            } else {

                this.HypervVirtualMachineMountSummary.ApplyExploratoryFieldSpec(ec.NewChild("hypervVirtualMachineMountSummary"));

            }
        }
        else if (this.HypervVirtualMachineMountSummary != null && ec.Excludes("hypervVirtualMachineMountSummary",false))
        {
            this.HypervVirtualMachineMountSummary = null;
        }
    }


    #endregion

    } // class UpdateHypervVirtualMachineSnapshotMountReply
    
    #endregion

    public static class ListUpdateHypervVirtualMachineSnapshotMountReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<UpdateHypervVirtualMachineSnapshotMountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateHypervVirtualMachineSnapshotMountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateHypervVirtualMachineSnapshotMountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateHypervVirtualMachineSnapshotMountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateHypervVirtualMachineSnapshotMountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
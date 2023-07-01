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
        System.String? VmName = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( NicsInSnapshot != null ) {
            this.NicsInSnapshot = NicsInSnapshot;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? NicsInSnapshot
        // GraphQL -> nicsInSnapshot: Int (scalar)
        if (this.NicsInSnapshot != null) {
            s += ind + "nicsInSnapshot\n" ;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            s += ind + "vmName\n" ;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "baseSnapshotSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? NicsInSnapshot
        // GraphQL -> nicsInSnapshot: Int (scalar)
        if (this.NicsInSnapshot == null && Exploration.Includes(parent + ".nicsInSnapshot", true))
        {
            this.NicsInSnapshot = Int32.MinValue;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName == null && Exploration.Includes(parent + ".vmName", true))
        {
            this.VmName = "FETCH";
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary == null && Exploration.Includes(parent + ".baseSnapshotSummary"))
        {
            this.BaseSnapshotSummary = new BaseSnapshotSummary();
            this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(parent + ".baseSnapshotSummary");
        }
    }


    #endregion

    } // class NutanixVmSnapshotSummary
    
    #endregion

    public static class ListNutanixVmSnapshotSummaryExtensions
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
            this List<NutanixVmSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmSnapshotSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
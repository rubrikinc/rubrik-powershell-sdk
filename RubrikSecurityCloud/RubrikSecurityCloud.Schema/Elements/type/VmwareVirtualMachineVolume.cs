// VmwareVirtualMachineVolume.cs
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
    #region VmwareVirtualMachineVolume
    public class VmwareVirtualMachineVolume: BaseType
    {
        #region members

        //      C# -> System.Int64? CapacityKbs
        // GraphQL -> capacityKbs: Long! (scalar)
        [JsonProperty("capacityKbs")]
        public System.Int64? CapacityKbs { get; set; }

        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        [JsonProperty("key")]
        public System.Int32? Key { get; set; }

        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        [JsonProperty("label")]
        public System.String? Label { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareVirtualMachineVolume";
    }

    public VmwareVirtualMachineVolume Set(
        System.Int64? CapacityKbs = null,
        System.Int32? Key = null,
        System.String? Label = null
    ) 
    {
        if ( CapacityKbs != null ) {
            this.CapacityKbs = CapacityKbs;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( Label != null ) {
            this.Label = Label;
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
        //      C# -> System.Int64? CapacityKbs
        // GraphQL -> capacityKbs: Long! (scalar)
        if (this.CapacityKbs != null) {
            s += ind + "capacityKbs\n" ;
        }
        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label != null) {
            s += ind + "label\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? CapacityKbs
        // GraphQL -> capacityKbs: Long! (scalar)
        if (this.CapacityKbs == null && ec.Includes("capacityKbs",true))
        {
            this.CapacityKbs = new System.Int64();
        }
        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        if (this.Key == null && ec.Includes("key",true))
        {
            this.Key = Int32.MinValue;
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label == null && ec.Includes("label",true))
        {
            this.Label = "FETCH";
        }
    }


    #endregion

    } // class VmwareVirtualMachineVolume
    
    #endregion

    public static class ListVmwareVirtualMachineVolumeExtensions
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
            this List<VmwareVirtualMachineVolume> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVirtualMachineVolume> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVirtualMachineVolume());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VmwareVirtualMachineVolume> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? CapacityKbs
        // GraphQL -> capacityKbs: Long! (scalar)
        if (this.CapacityKbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacityKbs\n" ;
            } else {
                s += ind + "capacityKbs\n" ;
            }
        }
        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label != null) {
            if (conf.Flat) {
                s += conf.Prefix + "label\n" ;
            } else {
                s += ind + "label\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? CapacityKbs
        // GraphQL -> capacityKbs: Long! (scalar)
        if (ec.Includes("capacityKbs",true))
        {
            if(this.CapacityKbs == null) {

                this.CapacityKbs = new System.Int64();

            } else {


            }
        }
        else if (this.CapacityKbs != null && ec.Excludes("capacityKbs",true))
        {
            this.CapacityKbs = null;
        }
        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = Int32.MinValue;

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (ec.Includes("label",true))
        {
            if(this.Label == null) {

                this.Label = "FETCH";

            } else {


            }
        }
        else if (this.Label != null && ec.Excludes("label",true))
        {
            this.Label = null;
        }
    }


    #endregion

    } // class VmwareVirtualMachineVolume
    
    #endregion

    public static class ListVmwareVirtualMachineVolumeExtensions
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
            this List<VmwareVirtualMachineVolume> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareVirtualMachineVolume> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<VmwareVirtualMachineVolume> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
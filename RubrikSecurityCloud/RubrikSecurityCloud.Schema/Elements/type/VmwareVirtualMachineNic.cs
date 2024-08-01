// VmwareVirtualMachineNic.cs
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
    #region VmwareVirtualMachineNic
    public class VmwareVirtualMachineNic: BaseType
    {
        #region members

        //      C# -> System.String? DeviceLabel
        // GraphQL -> deviceLabel: String! (scalar)
        [JsonProperty("deviceLabel")]
        public System.String? DeviceLabel { get; set; }

        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        [JsonProperty("key")]
        public System.Int32? Key { get; set; }

        //      C# -> System.String? NetworkLabel
        // GraphQL -> networkLabel: String! (scalar)
        [JsonProperty("networkLabel")]
        public System.String? NetworkLabel { get; set; }

        //      C# -> List<System.String>? V4Addresses
        // GraphQL -> v4Addresses: [String!]! (scalar)
        [JsonProperty("v4Addresses")]
        public List<System.String>? V4Addresses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareVirtualMachineNic";
    }

    public VmwareVirtualMachineNic Set(
        System.String? DeviceLabel = null,
        System.Int32? Key = null,
        System.String? NetworkLabel = null,
        List<System.String>? V4Addresses = null
    ) 
    {
        if ( DeviceLabel != null ) {
            this.DeviceLabel = DeviceLabel;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( NetworkLabel != null ) {
            this.NetworkLabel = NetworkLabel;
        }
        if ( V4Addresses != null ) {
            this.V4Addresses = V4Addresses;
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
        //      C# -> System.String? DeviceLabel
        // GraphQL -> deviceLabel: String! (scalar)
        if (this.DeviceLabel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceLabel\n" ;
            } else {
                s += ind + "deviceLabel\n" ;
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
        //      C# -> System.String? NetworkLabel
        // GraphQL -> networkLabel: String! (scalar)
        if (this.NetworkLabel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkLabel\n" ;
            } else {
                s += ind + "networkLabel\n" ;
            }
        }
        //      C# -> List<System.String>? V4Addresses
        // GraphQL -> v4Addresses: [String!]! (scalar)
        if (this.V4Addresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "v4Addresses\n" ;
            } else {
                s += ind + "v4Addresses\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DeviceLabel
        // GraphQL -> deviceLabel: String! (scalar)
        if (ec.Includes("deviceLabel",true))
        {
            if(this.DeviceLabel == null) {

                this.DeviceLabel = "FETCH";

            } else {


            }
        }
        else if (this.DeviceLabel != null && ec.Excludes("deviceLabel",true))
        {
            this.DeviceLabel = null;
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
        //      C# -> System.String? NetworkLabel
        // GraphQL -> networkLabel: String! (scalar)
        if (ec.Includes("networkLabel",true))
        {
            if(this.NetworkLabel == null) {

                this.NetworkLabel = "FETCH";

            } else {


            }
        }
        else if (this.NetworkLabel != null && ec.Excludes("networkLabel",true))
        {
            this.NetworkLabel = null;
        }
        //      C# -> List<System.String>? V4Addresses
        // GraphQL -> v4Addresses: [String!]! (scalar)
        if (ec.Includes("v4Addresses",true))
        {
            if(this.V4Addresses == null) {

                this.V4Addresses = new List<System.String>();

            } else {


            }
        }
        else if (this.V4Addresses != null && ec.Excludes("v4Addresses",true))
        {
            this.V4Addresses = null;
        }
    }


    #endregion

    } // class VmwareVirtualMachineNic
    
    #endregion

    public static class ListVmwareVirtualMachineNicExtensions
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
            this List<VmwareVirtualMachineNic> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareVirtualMachineNic> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVirtualMachineNic> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVirtualMachineNic());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareVirtualMachineNic> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
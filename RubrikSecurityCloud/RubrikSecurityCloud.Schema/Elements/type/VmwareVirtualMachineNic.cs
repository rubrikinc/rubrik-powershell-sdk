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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? DeviceLabel
        // GraphQL -> deviceLabel: String! (scalar)
        if (this.DeviceLabel != null) {
            s += ind + "deviceLabel\n" ;
        }
        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> System.String? NetworkLabel
        // GraphQL -> networkLabel: String! (scalar)
        if (this.NetworkLabel != null) {
            s += ind + "networkLabel\n" ;
        }
        //      C# -> List<System.String>? V4Addresses
        // GraphQL -> v4Addresses: [String!]! (scalar)
        if (this.V4Addresses != null) {
            s += ind + "v4Addresses\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DeviceLabel
        // GraphQL -> deviceLabel: String! (scalar)
        if (this.DeviceLabel == null && Exploration.Includes(parent + ".deviceLabel", true))
        {
            this.DeviceLabel = "FETCH";
        }
        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        if (this.Key == null && Exploration.Includes(parent + ".key", true))
        {
            this.Key = Int32.MinValue;
        }
        //      C# -> System.String? NetworkLabel
        // GraphQL -> networkLabel: String! (scalar)
        if (this.NetworkLabel == null && Exploration.Includes(parent + ".networkLabel", true))
        {
            this.NetworkLabel = "FETCH";
        }
        //      C# -> List<System.String>? V4Addresses
        // GraphQL -> v4Addresses: [String!]! (scalar)
        if (this.V4Addresses == null && Exploration.Includes(parent + ".v4Addresses", true))
        {
            this.V4Addresses = new List<System.String>();
        }
    }


    #endregion

    } // class VmwareVirtualMachineNic
    
    #endregion

    public static class ListVmwareVirtualMachineNicExtensions
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
            this List<VmwareVirtualMachineNic> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVirtualMachineNic> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVirtualMachineNic());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
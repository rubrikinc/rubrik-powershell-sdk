// VmwareVmNetworkInterface.cs
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
    #region VmwareVmNetworkInterface
    public class VmwareVmNetworkInterface: BaseType
    {
        #region members

        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        [JsonProperty("macAddress")]
        public System.String? MacAddress { get; set; }

        //      C# -> List<System.String>? V4Addresses
        // GraphQL -> v4Addresses: [String!]! (scalar)
        [JsonProperty("v4Addresses")]
        public List<System.String>? V4Addresses { get; set; }

        //      C# -> List<System.String>? V6Addresses
        // GraphQL -> v6Addresses: [String!]! (scalar)
        [JsonProperty("v6Addresses")]
        public List<System.String>? V6Addresses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareVmNetworkInterface";
    }

    public VmwareVmNetworkInterface Set(
        System.String? MacAddress = null,
        List<System.String>? V4Addresses = null,
        List<System.String>? V6Addresses = null
    ) 
    {
        if ( MacAddress != null ) {
            this.MacAddress = MacAddress;
        }
        if ( V4Addresses != null ) {
            this.V4Addresses = V4Addresses;
        }
        if ( V6Addresses != null ) {
            this.V6Addresses = V6Addresses;
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
        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        if (this.MacAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "macAddress\n" ;
            } else {
                s += ind + "macAddress\n" ;
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
        //      C# -> List<System.String>? V6Addresses
        // GraphQL -> v6Addresses: [String!]! (scalar)
        if (this.V6Addresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "v6Addresses\n" ;
            } else {
                s += ind + "v6Addresses\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        if (ec.Includes("macAddress",true))
        {
            if(this.MacAddress == null) {

                this.MacAddress = "FETCH";

            } else {


            }
        }
        else if (this.MacAddress != null && ec.Excludes("macAddress",true))
        {
            this.MacAddress = null;
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
        //      C# -> List<System.String>? V6Addresses
        // GraphQL -> v6Addresses: [String!]! (scalar)
        if (ec.Includes("v6Addresses",true))
        {
            if(this.V6Addresses == null) {

                this.V6Addresses = new List<System.String>();

            } else {


            }
        }
        else if (this.V6Addresses != null && ec.Excludes("v6Addresses",true))
        {
            this.V6Addresses = null;
        }
    }


    #endregion

    } // class VmwareVmNetworkInterface
    
    #endregion

    public static class ListVmwareVmNetworkInterfaceExtensions
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
            this List<VmwareVmNetworkInterface> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VmwareVmNetworkInterface> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmNetworkInterface> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmNetworkInterface());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareVmNetworkInterface> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
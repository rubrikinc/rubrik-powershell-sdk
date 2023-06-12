// AzureNativeSubnet.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureNativeSubnet
    public class AzureNativeSubnet: BaseType
    {
        #region members

        //      C# -> List<System.String>? AddressPrefixes
        // GraphQL -> addressPrefixes: [String!]! (scalar)
        [JsonProperty("addressPrefixes")]
        public List<System.String>? AddressPrefixes { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> AzureNativeVirtualNetwork? Vnet
        // GraphQL -> vnet: AzureNativeVirtualNetwork! (type)
        [JsonProperty("vnet")]
        public AzureNativeVirtualNetwork? Vnet { get; set; }


        #endregion

    #region methods

    public AzureNativeSubnet Set(
        List<System.String>? AddressPrefixes = null,
        System.String? Name = null,
        System.String? NativeId = null,
        AzureNativeVirtualNetwork? Vnet = null
    ) 
    {
        if ( AddressPrefixes != null ) {
            this.AddressPrefixes = AddressPrefixes;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( Vnet != null ) {
            this.Vnet = Vnet;
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
        //      C# -> List<System.String>? AddressPrefixes
        // GraphQL -> addressPrefixes: [String!]! (scalar)
        if (this.AddressPrefixes != null) {
            s += ind + "addressPrefixes\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            s += ind + "nativeId\n" ;
        }
        //      C# -> AzureNativeVirtualNetwork? Vnet
        // GraphQL -> vnet: AzureNativeVirtualNetwork! (type)
        if (this.Vnet != null) {
            var fspec = this.Vnet.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vnet {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? AddressPrefixes
        // GraphQL -> addressPrefixes: [String!]! (scalar)
        if (this.AddressPrefixes == null && Exploration.Includes(parent + ".addressPrefixes", true))
        {
            this.AddressPrefixes = new List<System.String>();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId == null && Exploration.Includes(parent + ".nativeId", true))
        {
            this.NativeId = "FETCH";
        }
        //      C# -> AzureNativeVirtualNetwork? Vnet
        // GraphQL -> vnet: AzureNativeVirtualNetwork! (type)
        if (this.Vnet == null && Exploration.Includes(parent + ".vnet"))
        {
            this.Vnet = new AzureNativeVirtualNetwork();
            this.Vnet.ApplyExploratoryFieldSpec(parent + ".vnet");
        }
    }


    #endregion

    } // class AzureNativeSubnet
    
    #endregion

    public static class ListAzureNativeSubnetExtensions
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
            this List<AzureNativeSubnet> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeSubnet> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeSubnet());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
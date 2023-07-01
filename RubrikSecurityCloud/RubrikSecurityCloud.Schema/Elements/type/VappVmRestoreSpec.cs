// VappVmRestoreSpec.cs
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
    #region VappVmRestoreSpec
    public class VappVmRestoreSpec: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? StoragePolicyId
        // GraphQL -> storagePolicyId: String (scalar)
        [JsonProperty("storagePolicyId")]
        public System.String? StoragePolicyId { get; set; }

        //      C# -> System.String? VcdMoid
        // GraphQL -> vcdMoid: String! (scalar)
        [JsonProperty("vcdMoid")]
        public System.String? VcdMoid { get; set; }

        //      C# -> List<VappVmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
        [JsonProperty("networkConnections")]
        public List<VappVmNetworkConnection>? NetworkConnections { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappVmRestoreSpec";
    }

    public VappVmRestoreSpec Set(
        System.String? Name = null,
        System.String? StoragePolicyId = null,
        System.String? VcdMoid = null,
        List<VappVmNetworkConnection>? NetworkConnections = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( StoragePolicyId != null ) {
            this.StoragePolicyId = StoragePolicyId;
        }
        if ( VcdMoid != null ) {
            this.VcdMoid = VcdMoid;
        }
        if ( NetworkConnections != null ) {
            this.NetworkConnections = NetworkConnections;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? StoragePolicyId
        // GraphQL -> storagePolicyId: String (scalar)
        if (this.StoragePolicyId != null) {
            s += ind + "storagePolicyId\n" ;
        }
        //      C# -> System.String? VcdMoid
        // GraphQL -> vcdMoid: String! (scalar)
        if (this.VcdMoid != null) {
            s += ind + "vcdMoid\n" ;
        }
        //      C# -> List<VappVmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
        if (this.NetworkConnections != null) {
            var fspec = this.NetworkConnections.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "networkConnections {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? StoragePolicyId
        // GraphQL -> storagePolicyId: String (scalar)
        if (this.StoragePolicyId == null && Exploration.Includes(parent + ".storagePolicyId", true))
        {
            this.StoragePolicyId = "FETCH";
        }
        //      C# -> System.String? VcdMoid
        // GraphQL -> vcdMoid: String! (scalar)
        if (this.VcdMoid == null && Exploration.Includes(parent + ".vcdMoid", true))
        {
            this.VcdMoid = "FETCH";
        }
        //      C# -> List<VappVmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
        if (this.NetworkConnections == null && Exploration.Includes(parent + ".networkConnections"))
        {
            this.NetworkConnections = new List<VappVmNetworkConnection>();
            this.NetworkConnections.ApplyExploratoryFieldSpec(parent + ".networkConnections");
        }
    }


    #endregion

    } // class VappVmRestoreSpec
    
    #endregion

    public static class ListVappVmRestoreSpecExtensions
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
            this List<VappVmRestoreSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappVmRestoreSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VappVmRestoreSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
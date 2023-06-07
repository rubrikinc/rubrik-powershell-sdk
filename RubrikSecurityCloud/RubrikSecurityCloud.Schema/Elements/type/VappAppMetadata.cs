// VappAppMetadata.cs
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
    #region VappAppMetadata
    public class VappAppMetadata: BaseType
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        [JsonProperty("vcdVmMoid")]
        public System.String? VcdVmMoid { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> List<VmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
        [JsonProperty("networkConnections")]
        public List<VmNetworkConnection>? NetworkConnections { get; set; }


        #endregion

    #region methods

    public VappAppMetadata Set(
        System.String? SnapshotId = null,
        System.String? VcdVmMoid = null,
        System.String? VmName = null,
        List<VmNetworkConnection>? NetworkConnections = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( VcdVmMoid != null ) {
            this.VcdVmMoid = VcdVmMoid;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        if (this.VcdVmMoid != null) {
            s += ind + "vcdVmMoid\n" ;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            s += ind + "vmName\n" ;
        }
        //      C# -> List<VmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
        if (this.NetworkConnections != null) {
            s += ind + "networkConnections {\n" + this.NetworkConnections.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        if (this.VcdVmMoid == null && Exploration.Includes(parent + ".vcdVmMoid", true))
        {
            this.VcdVmMoid = "FETCH";
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName == null && Exploration.Includes(parent + ".vmName", true))
        {
            this.VmName = "FETCH";
        }
        //      C# -> List<VmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
        if (this.NetworkConnections == null && Exploration.Includes(parent + ".networkConnections"))
        {
            this.NetworkConnections = new List<VmNetworkConnection>();
            this.NetworkConnections.ApplyExploratoryFieldSpec(parent + ".networkConnections");
        }
    }


    #endregion

    } // class VappAppMetadata
    
    #endregion

    public static class ListVappAppMetadataExtensions
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
            this List<VappAppMetadata> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappAppMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VappAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
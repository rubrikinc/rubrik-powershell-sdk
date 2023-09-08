// VsphereVirtualDisk.cs
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
    #region VsphereVirtualDisk
    public class VsphereVirtualDisk: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DatastoreFid
        // GraphQL -> datastoreFid: String (scalar)
        [JsonProperty("datastoreFid")]
        public System.String? DatastoreFid { get; set; }

        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int (scalar)
        [JsonProperty("deviceKey")]
        public System.Int32? DeviceKey { get; set; }

        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
        [JsonProperty("excludeFromSnapshots")]
        public System.Boolean? ExcludeFromSnapshots { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? VirtualMachineId
        // GraphQL -> virtualMachineId: String! (scalar)
        [JsonProperty("virtualMachineId")]
        public System.String? VirtualMachineId { get; set; }

        //      C# -> VsphereDatastore? Datastore
        // GraphQL -> datastore: VsphereDatastore (type)
        [JsonProperty("datastore")]
        public VsphereDatastore? Datastore { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereVirtualDisk";
    }

    public VsphereVirtualDisk Set(
        System.String? CdmId = null,
        System.String? CdmVersion = null,
        System.String? ClusterUuid = null,
        System.String? DatastoreFid = null,
        System.Int32? DeviceKey = null,
        System.Boolean? ExcludeFromSnapshots = null,
        System.String? Fid = null,
        System.String? FileName = null,
        System.Int64? Size = null,
        System.String? VirtualMachineId = null,
        VsphereDatastore? Datastore = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DatastoreFid != null ) {
            this.DatastoreFid = DatastoreFid;
        }
        if ( DeviceKey != null ) {
            this.DeviceKey = DeviceKey;
        }
        if ( ExcludeFromSnapshots != null ) {
            this.ExcludeFromSnapshots = ExcludeFromSnapshots;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( VirtualMachineId != null ) {
            this.VirtualMachineId = VirtualMachineId;
        }
        if ( Datastore != null ) {
            this.Datastore = Datastore;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            s += ind + "cdmVersion\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? DatastoreFid
        // GraphQL -> datastoreFid: String (scalar)
        if (this.DatastoreFid != null) {
            s += ind + "datastoreFid\n" ;
        }
        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int (scalar)
        if (this.DeviceKey != null) {
            s += ind + "deviceKey\n" ;
        }
        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
        if (this.ExcludeFromSnapshots != null) {
            s += ind + "excludeFromSnapshots\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            s += ind + "fileName\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? VirtualMachineId
        // GraphQL -> virtualMachineId: String! (scalar)
        if (this.VirtualMachineId != null) {
            s += ind + "virtualMachineId\n" ;
        }
        //      C# -> VsphereDatastore? Datastore
        // GraphQL -> datastore: VsphereDatastore (type)
        if (this.Datastore != null) {
            var fspec = this.Datastore.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "datastore {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && ec.Includes("cdmId",true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion == null && ec.Includes("cdmVersion",true))
        {
            this.CdmVersion = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? DatastoreFid
        // GraphQL -> datastoreFid: String (scalar)
        if (this.DatastoreFid == null && ec.Includes("datastoreFid",true))
        {
            this.DatastoreFid = "FETCH";
        }
        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int (scalar)
        if (this.DeviceKey == null && ec.Includes("deviceKey",true))
        {
            this.DeviceKey = Int32.MinValue;
        }
        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
        if (this.ExcludeFromSnapshots == null && ec.Includes("excludeFromSnapshots",true))
        {
            this.ExcludeFromSnapshots = true;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid == null && ec.Includes("fid",true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName == null && ec.Includes("fileName",true))
        {
            this.FileName = "FETCH";
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size == null && ec.Includes("size",true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? VirtualMachineId
        // GraphQL -> virtualMachineId: String! (scalar)
        if (this.VirtualMachineId == null && ec.Includes("virtualMachineId",true))
        {
            this.VirtualMachineId = "FETCH";
        }
        //      C# -> VsphereDatastore? Datastore
        // GraphQL -> datastore: VsphereDatastore (type)
        if (this.Datastore == null && ec.Includes("datastore",false))
        {
            this.Datastore = new VsphereDatastore();
            this.Datastore.ApplyExploratoryFieldSpec(ec.NewChild("datastore"));
        }
    }


    #endregion

    } // class VsphereVirtualDisk
    
    #endregion

    public static class ListVsphereVirtualDiskExtensions
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
            this List<VsphereVirtualDisk> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVirtualDisk> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVirtualDisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VsphereVirtualDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmVersion\n" ;
            } else {
                s += ind + "cdmVersion\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? DatastoreFid
        // GraphQL -> datastoreFid: String (scalar)
        if (this.DatastoreFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreFid\n" ;
            } else {
                s += ind + "datastoreFid\n" ;
            }
        }
        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int (scalar)
        if (this.DeviceKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceKey\n" ;
            } else {
                s += ind + "deviceKey\n" ;
            }
        }
        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
        if (this.ExcludeFromSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludeFromSnapshots\n" ;
            } else {
                s += ind + "excludeFromSnapshots\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileName\n" ;
            } else {
                s += ind + "fileName\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> System.String? VirtualMachineId
        // GraphQL -> virtualMachineId: String! (scalar)
        if (this.VirtualMachineId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "virtualMachineId\n" ;
            } else {
                s += ind + "virtualMachineId\n" ;
            }
        }
        //      C# -> VsphereDatastore? Datastore
        // GraphQL -> datastore: VsphereDatastore (type)
        if (this.Datastore != null) {
            var fspec = this.Datastore.AsFieldSpec(conf.Child("datastore"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "datastore {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (ec.Includes("cdmVersion",true))
        {
            if(this.CdmVersion == null) {

                this.CdmVersion = "FETCH";

            } else {


            }
        }
        else if (this.CdmVersion != null && ec.Excludes("cdmVersion",true))
        {
            this.CdmVersion = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? DatastoreFid
        // GraphQL -> datastoreFid: String (scalar)
        if (ec.Includes("datastoreFid",true))
        {
            if(this.DatastoreFid == null) {

                this.DatastoreFid = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreFid != null && ec.Excludes("datastoreFid",true))
        {
            this.DatastoreFid = null;
        }
        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int (scalar)
        if (ec.Includes("deviceKey",true))
        {
            if(this.DeviceKey == null) {

                this.DeviceKey = Int32.MinValue;

            } else {


            }
        }
        else if (this.DeviceKey != null && ec.Excludes("deviceKey",true))
        {
            this.DeviceKey = null;
        }
        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
        if (ec.Includes("excludeFromSnapshots",true))
        {
            if(this.ExcludeFromSnapshots == null) {

                this.ExcludeFromSnapshots = true;

            } else {


            }
        }
        else if (this.ExcludeFromSnapshots != null && ec.Excludes("excludeFromSnapshots",true))
        {
            this.ExcludeFromSnapshots = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (ec.Includes("fileName",true))
        {
            if(this.FileName == null) {

                this.FileName = "FETCH";

            } else {


            }
        }
        else if (this.FileName != null && ec.Excludes("fileName",true))
        {
            this.FileName = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> System.String? VirtualMachineId
        // GraphQL -> virtualMachineId: String! (scalar)
        if (ec.Includes("virtualMachineId",true))
        {
            if(this.VirtualMachineId == null) {

                this.VirtualMachineId = "FETCH";

            } else {


            }
        }
        else if (this.VirtualMachineId != null && ec.Excludes("virtualMachineId",true))
        {
            this.VirtualMachineId = null;
        }
        //      C# -> VsphereDatastore? Datastore
        // GraphQL -> datastore: VsphereDatastore (type)
        if (ec.Includes("datastore",false))
        {
            if(this.Datastore == null) {

                this.Datastore = new VsphereDatastore();
                this.Datastore.ApplyExploratoryFieldSpec(ec.NewChild("datastore"));

            } else {

                this.Datastore.ApplyExploratoryFieldSpec(ec.NewChild("datastore"));

            }
        }
        else if (this.Datastore != null && ec.Excludes("datastore",false))
        {
            this.Datastore = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<VsphereVirtualDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
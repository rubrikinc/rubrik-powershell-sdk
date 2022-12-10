// VsphereVirtualDisk.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:07.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region VsphereVirtualDisk
    public class VsphereVirtualDisk: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? CdmVersion
            // GraphQL -> cdmVersion: String! (scalar)
            if (this.CdmVersion != null)
            {
                 s += ind + "cdmVersion\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? DatastoreFid
            // GraphQL -> datastoreFid: String (scalar)
            if (this.DatastoreFid != null)
            {
                 s += ind + "datastoreFid\n";

            }
            //      C# -> System.Int32? DeviceKey
            // GraphQL -> deviceKey: Int (scalar)
            if (this.DeviceKey != null)
            {
                 s += ind + "deviceKey\n";

            }
            //      C# -> System.Boolean? ExcludeFromSnapshots
            // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
            if (this.ExcludeFromSnapshots != null)
            {
                 s += ind + "excludeFromSnapshots\n";

            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: UUID! (scalar)
            if (this.Fid != null)
            {
                 s += ind + "fid\n";

            }
            //      C# -> System.String? FileName
            // GraphQL -> fileName: String! (scalar)
            if (this.FileName != null)
            {
                 s += ind + "fileName\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? VirtualMachineId
            // GraphQL -> virtualMachineId: String! (scalar)
            if (this.VirtualMachineId != null)
            {
                 s += ind + "virtualMachineId\n";

            }
            //      C# -> VsphereDatastore? Datastore
            // GraphQL -> datastore: VsphereDatastore (type)
            if (this.Datastore != null)
            {
                 s += ind + "datastore\n";

                 s += ind + "{\n" + 
                 this.Datastore.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? CdmVersion
            // GraphQL -> cdmVersion: String! (scalar)
            if (this.CdmVersion == null && Exploration.Includes(parent + ".cdmVersion$"))
            {
                this.CdmVersion = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? DatastoreFid
            // GraphQL -> datastoreFid: String (scalar)
            if (this.DatastoreFid == null && Exploration.Includes(parent + ".datastoreFid$"))
            {
                this.DatastoreFid = new System.String("FETCH");
            }
            //      C# -> System.Int32? DeviceKey
            // GraphQL -> deviceKey: Int (scalar)
            if (this.DeviceKey == null && Exploration.Includes(parent + ".deviceKey$"))
            {
                this.DeviceKey = new System.Int32();
            }
            //      C# -> System.Boolean? ExcludeFromSnapshots
            // GraphQL -> excludeFromSnapshots: Boolean! (scalar)
            if (this.ExcludeFromSnapshots == null && Exploration.Includes(parent + ".excludeFromSnapshots$"))
            {
                this.ExcludeFromSnapshots = new System.Boolean();
            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: UUID! (scalar)
            if (this.Fid == null && Exploration.Includes(parent + ".fid$"))
            {
                this.Fid = new System.String("FETCH");
            }
            //      C# -> System.String? FileName
            // GraphQL -> fileName: String! (scalar)
            if (this.FileName == null && Exploration.Includes(parent + ".fileName$"))
            {
                this.FileName = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? VirtualMachineId
            // GraphQL -> virtualMachineId: String! (scalar)
            if (this.VirtualMachineId == null && Exploration.Includes(parent + ".virtualMachineId$"))
            {
                this.VirtualMachineId = new System.String("FETCH");
            }
            //      C# -> VsphereDatastore? Datastore
            // GraphQL -> datastore: VsphereDatastore (type)
            if (this.Datastore == null && Exploration.Includes(parent + ".datastore"))
            {
                this.Datastore = new VsphereDatastore();
                this.Datastore.ApplyExploratoryFragment(parent + ".datastore");
            }
        }


    #endregion

    } // class VsphereVirtualDisk
    #endregion

    public static class ListVsphereVirtualDiskExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<VsphereVirtualDisk> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VsphereVirtualDisk> list, 
            String parent = "")
        {
            var item = new VsphereVirtualDisk();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
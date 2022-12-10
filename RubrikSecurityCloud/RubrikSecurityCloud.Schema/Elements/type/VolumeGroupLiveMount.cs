// VolumeGroupLiveMount.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
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
    #region VolumeGroupLiveMount
    public class VolumeGroupLiveMount: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String (scalar)
        [JsonProperty("mountPath")]
        public System.String? MountPath { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        [JsonProperty("mountTimestamp")]
        public DateTime? MountTimestamp { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String (scalar)
        [JsonProperty("nodeCompositeId")]
        public System.String? NodeCompositeId { get; set; }

        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String (scalar)
        [JsonProperty("nodeIp")]
        public System.String? NodeIp { get; set; }

        //      C# -> System.String? RestoreScriptPath
        // GraphQL -> restoreScriptPath: String (scalar)
        [JsonProperty("restoreScriptPath")]
        public System.String? RestoreScriptPath { get; set; }

        //      C# -> System.String? SmbShareName
        // GraphQL -> smbShareName: String (scalar)
        [JsonProperty("smbShareName")]
        public System.String? SmbShareName { get; set; }

        //      C# -> System.String? SourceVolumeGroupId
        // GraphQL -> sourceVolumeGroupId: String! (scalar)
        [JsonProperty("sourceVolumeGroupId")]
        public System.String? SourceVolumeGroupId { get; set; }

        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String (scalar)
        [JsonProperty("targetHostId")]
        public System.String? TargetHostId { get; set; }

        //      C# -> System.String? TargetHostName
        // GraphQL -> targetHostName: String (scalar)
        [JsonProperty("targetHostName")]
        public System.String? TargetHostName { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        [JsonProperty("authorizedOperations")]
        public AuthorizedOperations? AuthorizedOperations { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<MountedVolume>? MountedVolumes
        // GraphQL -> mountedVolumes: [MountedVolume!]! (type)
        [JsonProperty("mountedVolumes")]
        public List<MountedVolume>? MountedVolumes { get; set; }

        //      C# -> PhysicalHost? SourceHost
        // GraphQL -> sourceHost: PhysicalHost! (type)
        [JsonProperty("sourceHost")]
        public PhysicalHost? SourceHost { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }

        #endregion

    #region methods

    public VolumeGroupLiveMount Set(
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MountPath = null,
        System.String? MountRequestId = null,
        DateTime? MountTimestamp = null,
        System.String? Name = null,
        System.String? NodeCompositeId = null,
        System.String? NodeIp = null,
        System.String? RestoreScriptPath = null,
        System.String? SmbShareName = null,
        System.String? SourceVolumeGroupId = null,
        System.String? TargetHostId = null,
        System.String? TargetHostName = null,
        System.String? UnmountRequestId = null,
        AuthorizedOperations? AuthorizedOperations = null,
        Cluster? Cluster = null,
        List<MountedVolume>? MountedVolumes = null,
        PhysicalHost? SourceHost = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountPath != null ) {
            this.MountPath = MountPath;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountTimestamp != null ) {
            this.MountTimestamp = MountTimestamp;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NodeCompositeId != null ) {
            this.NodeCompositeId = NodeCompositeId;
        }
        if ( NodeIp != null ) {
            this.NodeIp = NodeIp;
        }
        if ( RestoreScriptPath != null ) {
            this.RestoreScriptPath = RestoreScriptPath;
        }
        if ( SmbShareName != null ) {
            this.SmbShareName = SmbShareName;
        }
        if ( SourceVolumeGroupId != null ) {
            this.SourceVolumeGroupId = SourceVolumeGroupId;
        }
        if ( TargetHostId != null ) {
            this.TargetHostId = TargetHostId;
        }
        if ( TargetHostName != null ) {
            this.TargetHostName = TargetHostName;
        }
        if ( UnmountRequestId != null ) {
            this.UnmountRequestId = UnmountRequestId;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( MountedVolumes != null ) {
            this.MountedVolumes = MountedVolumes;
        }
        if ( SourceHost != null ) {
            this.SourceHost = SourceHost;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady != null)
            {
                 s += ind + "isReady\n";

            }
            //      C# -> System.String? MountPath
            // GraphQL -> mountPath: String (scalar)
            if (this.MountPath != null)
            {
                 s += ind + "mountPath\n";

            }
            //      C# -> System.String? MountRequestId
            // GraphQL -> mountRequestId: String (scalar)
            if (this.MountRequestId != null)
            {
                 s += ind + "mountRequestId\n";

            }
            //      C# -> DateTime? MountTimestamp
            // GraphQL -> mountTimestamp: DateTime (scalar)
            if (this.MountTimestamp != null)
            {
                 s += ind + "mountTimestamp\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NodeCompositeId
            // GraphQL -> nodeCompositeId: String (scalar)
            if (this.NodeCompositeId != null)
            {
                 s += ind + "nodeCompositeId\n";

            }
            //      C# -> System.String? NodeIp
            // GraphQL -> nodeIp: String (scalar)
            if (this.NodeIp != null)
            {
                 s += ind + "nodeIp\n";

            }
            //      C# -> System.String? RestoreScriptPath
            // GraphQL -> restoreScriptPath: String (scalar)
            if (this.RestoreScriptPath != null)
            {
                 s += ind + "restoreScriptPath\n";

            }
            //      C# -> System.String? SmbShareName
            // GraphQL -> smbShareName: String (scalar)
            if (this.SmbShareName != null)
            {
                 s += ind + "smbShareName\n";

            }
            //      C# -> System.String? SourceVolumeGroupId
            // GraphQL -> sourceVolumeGroupId: String! (scalar)
            if (this.SourceVolumeGroupId != null)
            {
                 s += ind + "sourceVolumeGroupId\n";

            }
            //      C# -> System.String? TargetHostId
            // GraphQL -> targetHostId: String (scalar)
            if (this.TargetHostId != null)
            {
                 s += ind + "targetHostId\n";

            }
            //      C# -> System.String? TargetHostName
            // GraphQL -> targetHostName: String (scalar)
            if (this.TargetHostName != null)
            {
                 s += ind + "targetHostName\n";

            }
            //      C# -> System.String? UnmountRequestId
            // GraphQL -> unmountRequestId: String (scalar)
            if (this.UnmountRequestId != null)
            {
                 s += ind + "unmountRequestId\n";

            }
            //      C# -> AuthorizedOperations? AuthorizedOperations
            // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

                 s += ind + "{\n" + 
                 this.AuthorizedOperations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<MountedVolume>? MountedVolumes
            // GraphQL -> mountedVolumes: [MountedVolume!]! (type)
            if (this.MountedVolumes != null)
            {
                 s += ind + "mountedVolumes\n";

                 s += ind + "{\n" + 
                 this.MountedVolumes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PhysicalHost? SourceHost
            // GraphQL -> sourceHost: PhysicalHost! (type)
            if (this.SourceHost != null)
            {
                 s += ind + "sourceHost\n";

                 s += ind + "{\n" + 
                 this.SourceHost.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
            if (this.SourceSnapshot != null)
            {
                 s += ind + "sourceSnapshot\n";

                 s += ind + "{\n" + 
                 this.SourceSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady == null && Exploration.Includes(parent + ".isReady$"))
            {
                this.IsReady = new System.Boolean();
            }
            //      C# -> System.String? MountPath
            // GraphQL -> mountPath: String (scalar)
            if (this.MountPath == null && Exploration.Includes(parent + ".mountPath$"))
            {
                this.MountPath = new System.String("FETCH");
            }
            //      C# -> System.String? MountRequestId
            // GraphQL -> mountRequestId: String (scalar)
            if (this.MountRequestId == null && Exploration.Includes(parent + ".mountRequestId$"))
            {
                this.MountRequestId = new System.String("FETCH");
            }
            //      C# -> DateTime? MountTimestamp
            // GraphQL -> mountTimestamp: DateTime (scalar)
            if (this.MountTimestamp == null && Exploration.Includes(parent + ".mountTimestamp$"))
            {
                this.MountTimestamp = new DateTime();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NodeCompositeId
            // GraphQL -> nodeCompositeId: String (scalar)
            if (this.NodeCompositeId == null && Exploration.Includes(parent + ".nodeCompositeId$"))
            {
                this.NodeCompositeId = new System.String("FETCH");
            }
            //      C# -> System.String? NodeIp
            // GraphQL -> nodeIp: String (scalar)
            if (this.NodeIp == null && Exploration.Includes(parent + ".nodeIp$"))
            {
                this.NodeIp = new System.String("FETCH");
            }
            //      C# -> System.String? RestoreScriptPath
            // GraphQL -> restoreScriptPath: String (scalar)
            if (this.RestoreScriptPath == null && Exploration.Includes(parent + ".restoreScriptPath$"))
            {
                this.RestoreScriptPath = new System.String("FETCH");
            }
            //      C# -> System.String? SmbShareName
            // GraphQL -> smbShareName: String (scalar)
            if (this.SmbShareName == null && Exploration.Includes(parent + ".smbShareName$"))
            {
                this.SmbShareName = new System.String("FETCH");
            }
            //      C# -> System.String? SourceVolumeGroupId
            // GraphQL -> sourceVolumeGroupId: String! (scalar)
            if (this.SourceVolumeGroupId == null && Exploration.Includes(parent + ".sourceVolumeGroupId$"))
            {
                this.SourceVolumeGroupId = new System.String("FETCH");
            }
            //      C# -> System.String? TargetHostId
            // GraphQL -> targetHostId: String (scalar)
            if (this.TargetHostId == null && Exploration.Includes(parent + ".targetHostId$"))
            {
                this.TargetHostId = new System.String("FETCH");
            }
            //      C# -> System.String? TargetHostName
            // GraphQL -> targetHostName: String (scalar)
            if (this.TargetHostName == null && Exploration.Includes(parent + ".targetHostName$"))
            {
                this.TargetHostName = new System.String("FETCH");
            }
            //      C# -> System.String? UnmountRequestId
            // GraphQL -> unmountRequestId: String (scalar)
            if (this.UnmountRequestId == null && Exploration.Includes(parent + ".unmountRequestId$"))
            {
                this.UnmountRequestId = new System.String("FETCH");
            }
            //      C# -> AuthorizedOperations? AuthorizedOperations
            // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations"))
            {
                this.AuthorizedOperations = new AuthorizedOperations();
                this.AuthorizedOperations.ApplyExploratoryFragment(parent + ".authorizedOperations");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> List<MountedVolume>? MountedVolumes
            // GraphQL -> mountedVolumes: [MountedVolume!]! (type)
            if (this.MountedVolumes == null && Exploration.Includes(parent + ".mountedVolumes"))
            {
                this.MountedVolumes = new List<MountedVolume>();
                this.MountedVolumes.ApplyExploratoryFragment(parent + ".mountedVolumes");
            }
            //      C# -> PhysicalHost? SourceHost
            // GraphQL -> sourceHost: PhysicalHost! (type)
            if (this.SourceHost == null && Exploration.Includes(parent + ".sourceHost"))
            {
                this.SourceHost = new PhysicalHost();
                this.SourceHost.ApplyExploratoryFragment(parent + ".sourceHost");
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
            if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
            {
                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFragment(parent + ".sourceSnapshot");
            }
        }


    #endregion

    } // class VolumeGroupLiveMount
    #endregion

    public static class ListVolumeGroupLiveMountExtensions
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
            this List<VolumeGroupLiveMount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VolumeGroupLiveMount> list, 
            String parent = "")
        {
            var item = new VolumeGroupLiveMount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// VolumeGroupLiveMount.cs
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
    #region VolumeGroupLiveMount
    public class VolumeGroupLiveMount: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            s += ind + "isReady\n" ;
        }
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String (scalar)
        if (this.MountPath != null) {
            s += ind + "mountPath\n" ;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId != null) {
            s += ind + "mountRequestId\n" ;
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp != null) {
            s += ind + "mountTimestamp\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String (scalar)
        if (this.NodeCompositeId != null) {
            s += ind + "nodeCompositeId\n" ;
        }
        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String (scalar)
        if (this.NodeIp != null) {
            s += ind + "nodeIp\n" ;
        }
        //      C# -> System.String? RestoreScriptPath
        // GraphQL -> restoreScriptPath: String (scalar)
        if (this.RestoreScriptPath != null) {
            s += ind + "restoreScriptPath\n" ;
        }
        //      C# -> System.String? SmbShareName
        // GraphQL -> smbShareName: String (scalar)
        if (this.SmbShareName != null) {
            s += ind + "smbShareName\n" ;
        }
        //      C# -> System.String? SourceVolumeGroupId
        // GraphQL -> sourceVolumeGroupId: String! (scalar)
        if (this.SourceVolumeGroupId != null) {
            s += ind + "sourceVolumeGroupId\n" ;
        }
        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String (scalar)
        if (this.TargetHostId != null) {
            s += ind + "targetHostId\n" ;
        }
        //      C# -> System.String? TargetHostName
        // GraphQL -> targetHostName: String (scalar)
        if (this.TargetHostName != null) {
            s += ind + "targetHostName\n" ;
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId != null) {
            s += ind + "unmountRequestId\n" ;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            var fspec = this.AuthorizedOperations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "authorizedOperations {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<MountedVolume>? MountedVolumes
        // GraphQL -> mountedVolumes: [MountedVolume!]! (type)
        if (this.MountedVolumes != null) {
            var fspec = this.MountedVolumes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mountedVolumes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PhysicalHost? SourceHost
        // GraphQL -> sourceHost: PhysicalHost! (type)
        if (this.SourceHost != null) {
            var fspec = this.SourceHost.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceHost {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady == null && Exploration.Includes(parent + ".isReady", true))
        {
            this.IsReady = true;
        }
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String (scalar)
        if (this.MountPath == null && Exploration.Includes(parent + ".mountPath", true))
        {
            this.MountPath = "FETCH";
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId == null && Exploration.Includes(parent + ".mountRequestId", true))
        {
            this.MountRequestId = "FETCH";
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp == null && Exploration.Includes(parent + ".mountTimestamp", true))
        {
            this.MountTimestamp = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String (scalar)
        if (this.NodeCompositeId == null && Exploration.Includes(parent + ".nodeCompositeId", true))
        {
            this.NodeCompositeId = "FETCH";
        }
        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String (scalar)
        if (this.NodeIp == null && Exploration.Includes(parent + ".nodeIp", true))
        {
            this.NodeIp = "FETCH";
        }
        //      C# -> System.String? RestoreScriptPath
        // GraphQL -> restoreScriptPath: String (scalar)
        if (this.RestoreScriptPath == null && Exploration.Includes(parent + ".restoreScriptPath", true))
        {
            this.RestoreScriptPath = "FETCH";
        }
        //      C# -> System.String? SmbShareName
        // GraphQL -> smbShareName: String (scalar)
        if (this.SmbShareName == null && Exploration.Includes(parent + ".smbShareName", true))
        {
            this.SmbShareName = "FETCH";
        }
        //      C# -> System.String? SourceVolumeGroupId
        // GraphQL -> sourceVolumeGroupId: String! (scalar)
        if (this.SourceVolumeGroupId == null && Exploration.Includes(parent + ".sourceVolumeGroupId", true))
        {
            this.SourceVolumeGroupId = "FETCH";
        }
        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String (scalar)
        if (this.TargetHostId == null && Exploration.Includes(parent + ".targetHostId", true))
        {
            this.TargetHostId = "FETCH";
        }
        //      C# -> System.String? TargetHostName
        // GraphQL -> targetHostName: String (scalar)
        if (this.TargetHostName == null && Exploration.Includes(parent + ".targetHostName", true))
        {
            this.TargetHostName = "FETCH";
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId == null && Exploration.Includes(parent + ".unmountRequestId", true))
        {
            this.UnmountRequestId = "FETCH";
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations"))
        {
            this.AuthorizedOperations = new AuthorizedOperations();
            this.AuthorizedOperations.ApplyExploratoryFieldSpec(parent + ".authorizedOperations");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> List<MountedVolume>? MountedVolumes
        // GraphQL -> mountedVolumes: [MountedVolume!]! (type)
        if (this.MountedVolumes == null && Exploration.Includes(parent + ".mountedVolumes"))
        {
            this.MountedVolumes = new List<MountedVolume>();
            this.MountedVolumes.ApplyExploratoryFieldSpec(parent + ".mountedVolumes");
        }
        //      C# -> PhysicalHost? SourceHost
        // GraphQL -> sourceHost: PhysicalHost! (type)
        if (this.SourceHost == null && Exploration.Includes(parent + ".sourceHost"))
        {
            this.SourceHost = new PhysicalHost();
            this.SourceHost.ApplyExploratoryFieldSpec(parent + ".sourceHost");
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
        {
            this.SourceSnapshot = new CdmSnapshot();
            this.SourceSnapshot.ApplyExploratoryFieldSpec(parent + ".sourceSnapshot");
        }
    }


    #endregion

    } // class VolumeGroupLiveMount
    
    #endregion

    public static class ListVolumeGroupLiveMountExtensions
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
            this List<VolumeGroupLiveMount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VolumeGroupLiveMount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VolumeGroupLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
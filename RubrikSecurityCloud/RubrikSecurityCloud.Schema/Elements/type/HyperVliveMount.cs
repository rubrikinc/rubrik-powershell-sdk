// HyperVliveMount.cs
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
    #region HyperVliveMount
    public class HyperVliveMount: BaseType
    {
        #region members

        //      C# -> HypervMountedVmStatusType? MountedVmStatus
        // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
        [JsonProperty("mountedVmStatus")]
        public HypervMountedVmStatusType? MountedVmStatus { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        [JsonProperty("isVmReady")]
        public System.Boolean? IsVmReady { get; set; }

        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        [JsonProperty("mountSpec")]
        public System.String? MountSpec { get; set; }

        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        [JsonProperty("mountTime")]
        public DateTime? MountTime { get; set; }

        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: UUID! (scalar)
        [JsonProperty("mountedVmFid")]
        public System.String? MountedVmFid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ServerFid
        // GraphQL -> serverFid: UUID! (scalar)
        [JsonProperty("serverFid")]
        public System.String? ServerFid { get; set; }

        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        [JsonProperty("serverName")]
        public System.String? ServerName { get; set; }

        //      C# -> System.String? SourceVm
        // GraphQL -> sourceVm: String! (scalar)
        [JsonProperty("sourceVm")]
        public System.String? SourceVm { get; set; }

        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: UUID! (scalar)
        [JsonProperty("sourceVmFid")]
        public System.String? SourceVmFid { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }


        #endregion

    #region methods

    public HyperVliveMount Set(
        HypervMountedVmStatusType? MountedVmStatus = null,
        System.String? Id = null,
        System.Boolean? IsVmReady = null,
        System.String? MountSpec = null,
        DateTime? MountTime = null,
        System.String? MountedVmFid = null,
        System.String? Name = null,
        System.String? ServerFid = null,
        System.String? ServerName = null,
        System.String? SourceVm = null,
        System.String? SourceVmFid = null,
        Cluster? Cluster = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( MountedVmStatus != null ) {
            this.MountedVmStatus = MountedVmStatus;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsVmReady != null ) {
            this.IsVmReady = IsVmReady;
        }
        if ( MountSpec != null ) {
            this.MountSpec = MountSpec;
        }
        if ( MountTime != null ) {
            this.MountTime = MountTime;
        }
        if ( MountedVmFid != null ) {
            this.MountedVmFid = MountedVmFid;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ServerFid != null ) {
            this.ServerFid = ServerFid;
        }
        if ( ServerName != null ) {
            this.ServerName = ServerName;
        }
        if ( SourceVm != null ) {
            this.SourceVm = SourceVm;
        }
        if ( SourceVmFid != null ) {
            this.SourceVmFid = SourceVmFid;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> HypervMountedVmStatusType? MountedVmStatus
        // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
        if (this.MountedVmStatus != null) {
            s += ind + "mountedVmStatus\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        if (this.IsVmReady != null) {
            s += ind + "isVmReady\n" ;
        }
        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        if (this.MountSpec != null) {
            s += ind + "mountSpec\n" ;
        }
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (this.MountTime != null) {
            s += ind + "mountTime\n" ;
        }
        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: UUID! (scalar)
        if (this.MountedVmFid != null) {
            s += ind + "mountedVmFid\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ServerFid
        // GraphQL -> serverFid: UUID! (scalar)
        if (this.ServerFid != null) {
            s += ind + "serverFid\n" ;
        }
        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        if (this.ServerName != null) {
            s += ind + "serverName\n" ;
        }
        //      C# -> System.String? SourceVm
        // GraphQL -> sourceVm: String! (scalar)
        if (this.SourceVm != null) {
            s += ind + "sourceVm\n" ;
        }
        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: UUID! (scalar)
        if (this.SourceVmFid != null) {
            s += ind + "sourceVmFid\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        if (this.SourceSnapshot != null) {
            s += ind + "sourceSnapshot {\n" + this.SourceSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HypervMountedVmStatusType? MountedVmStatus
        // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
        if (this.MountedVmStatus == null && Exploration.Includes(parent + ".mountedVmStatus", true))
        {
            this.MountedVmStatus = new HypervMountedVmStatusType();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        if (this.IsVmReady == null && Exploration.Includes(parent + ".isVmReady", true))
        {
            this.IsVmReady = true;
        }
        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        if (this.MountSpec == null && Exploration.Includes(parent + ".mountSpec", true))
        {
            this.MountSpec = new System.String("FETCH");
        }
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (this.MountTime == null && Exploration.Includes(parent + ".mountTime", true))
        {
            this.MountTime = new DateTime();
        }
        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: UUID! (scalar)
        if (this.MountedVmFid == null && Exploration.Includes(parent + ".mountedVmFid", true))
        {
            this.MountedVmFid = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.String? ServerFid
        // GraphQL -> serverFid: UUID! (scalar)
        if (this.ServerFid == null && Exploration.Includes(parent + ".serverFid", true))
        {
            this.ServerFid = new System.String("FETCH");
        }
        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        if (this.ServerName == null && Exploration.Includes(parent + ".serverName", true))
        {
            this.ServerName = new System.String("FETCH");
        }
        //      C# -> System.String? SourceVm
        // GraphQL -> sourceVm: String! (scalar)
        if (this.SourceVm == null && Exploration.Includes(parent + ".sourceVm", true))
        {
            this.SourceVm = new System.String("FETCH");
        }
        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: UUID! (scalar)
        if (this.SourceVmFid == null && Exploration.Includes(parent + ".sourceVmFid", true))
        {
            this.SourceVmFid = new System.String("FETCH");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
        {
            this.SourceSnapshot = new CdmSnapshot();
            this.SourceSnapshot.ApplyExploratoryFieldSpec(parent + ".sourceSnapshot");
        }
    }


    #endregion

    } // class HyperVliveMount
    
    #endregion

    public static class ListHyperVliveMountExtensions
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
            this List<HyperVliveMount> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HyperVliveMount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HyperVliveMount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
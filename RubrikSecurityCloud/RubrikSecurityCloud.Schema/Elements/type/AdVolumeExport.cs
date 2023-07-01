// AdVolumeExport.cs
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
    #region AdVolumeExport
    public class AdVolumeExport: BaseType
    {
        #region members

        //      C# -> System.String? DomainControllerId
        // GraphQL -> domainControllerId: String! (scalar)
        [JsonProperty("domainControllerId")]
        public System.String? DomainControllerId { get; set; }

        //      C# -> System.String? DomainControllerName
        // GraphQL -> domainControllerName: String! (scalar)
        [JsonProperty("domainControllerName")]
        public System.String? DomainControllerName { get; set; }

        //      C# -> System.String? FloatingIp
        // GraphQL -> floatingIp: String (scalar)
        [JsonProperty("floatingIp")]
        public System.String? FloatingIp { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        [JsonProperty("internalTimestamp")]
        public System.Int64? InternalTimestamp { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> System.Boolean? IsUserVisible
        // GraphQL -> isUserVisible: Boolean! (scalar)
        [JsonProperty("isUserVisible")]
        public System.Boolean? IsUserVisible { get; set; }

        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        [JsonProperty("mountDir")]
        public System.String? MountDir { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        [JsonProperty("node")]
        public ClusterNode? Node { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AdVolumeExport";
    }

    public AdVolumeExport Set(
        System.String? DomainControllerId = null,
        System.String? DomainControllerName = null,
        System.String? FloatingIp = null,
        System.String? Id = null,
        System.Int64? InternalTimestamp = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsUserVisible = null,
        System.String? MountDir = null,
        Cluster? Cluster = null,
        ClusterNode? Node = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( DomainControllerId != null ) {
            this.DomainControllerId = DomainControllerId;
        }
        if ( DomainControllerName != null ) {
            this.DomainControllerName = DomainControllerName;
        }
        if ( FloatingIp != null ) {
            this.FloatingIp = FloatingIp;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( InternalTimestamp != null ) {
            this.InternalTimestamp = InternalTimestamp;
        }
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( IsUserVisible != null ) {
            this.IsUserVisible = IsUserVisible;
        }
        if ( MountDir != null ) {
            this.MountDir = MountDir;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Node != null ) {
            this.Node = Node;
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
        //      C# -> System.String? DomainControllerId
        // GraphQL -> domainControllerId: String! (scalar)
        if (this.DomainControllerId != null) {
            s += ind + "domainControllerId\n" ;
        }
        //      C# -> System.String? DomainControllerName
        // GraphQL -> domainControllerName: String! (scalar)
        if (this.DomainControllerName != null) {
            s += ind + "domainControllerName\n" ;
        }
        //      C# -> System.String? FloatingIp
        // GraphQL -> floatingIp: String (scalar)
        if (this.FloatingIp != null) {
            s += ind + "floatingIp\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        if (this.InternalTimestamp != null) {
            s += ind + "internalTimestamp\n" ;
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            s += ind + "isActive\n" ;
        }
        //      C# -> System.Boolean? IsUserVisible
        // GraphQL -> isUserVisible: Boolean! (scalar)
        if (this.IsUserVisible != null) {
            s += ind + "isUserVisible\n" ;
        }
        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        if (this.MountDir != null) {
            s += ind + "mountDir\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        if (this.Node != null) {
            var fspec = this.Node.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "node {\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.String? DomainControllerId
        // GraphQL -> domainControllerId: String! (scalar)
        if (this.DomainControllerId == null && Exploration.Includes(parent + ".domainControllerId", true))
        {
            this.DomainControllerId = "FETCH";
        }
        //      C# -> System.String? DomainControllerName
        // GraphQL -> domainControllerName: String! (scalar)
        if (this.DomainControllerName == null && Exploration.Includes(parent + ".domainControllerName", true))
        {
            this.DomainControllerName = "FETCH";
        }
        //      C# -> System.String? FloatingIp
        // GraphQL -> floatingIp: String (scalar)
        if (this.FloatingIp == null && Exploration.Includes(parent + ".floatingIp", true))
        {
            this.FloatingIp = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        if (this.InternalTimestamp == null && Exploration.Includes(parent + ".internalTimestamp", true))
        {
            this.InternalTimestamp = new System.Int64();
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive == null && Exploration.Includes(parent + ".isActive", true))
        {
            this.IsActive = true;
        }
        //      C# -> System.Boolean? IsUserVisible
        // GraphQL -> isUserVisible: Boolean! (scalar)
        if (this.IsUserVisible == null && Exploration.Includes(parent + ".isUserVisible", true))
        {
            this.IsUserVisible = true;
        }
        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        if (this.MountDir == null && Exploration.Includes(parent + ".mountDir", true))
        {
            this.MountDir = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        if (this.Node == null && Exploration.Includes(parent + ".node"))
        {
            this.Node = new ClusterNode();
            this.Node.ApplyExploratoryFieldSpec(parent + ".node");
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

    } // class AdVolumeExport
    
    #endregion

    public static class ListAdVolumeExportExtensions
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
            this List<AdVolumeExport> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AdVolumeExport> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AdVolumeExport());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
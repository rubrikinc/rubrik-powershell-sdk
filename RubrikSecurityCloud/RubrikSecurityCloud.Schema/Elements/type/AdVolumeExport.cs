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

        //      C# -> System.String? MountNodeIp
        // GraphQL -> mountNodeIp: String (scalar)
        [JsonProperty("mountNodeIp")]
        public System.String? MountNodeIp { get; set; }

        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        [JsonProperty("smbValidIps")]
        public List<System.String>? SmbValidIps { get; set; }

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
        System.String? MountNodeIp = null,
        List<System.String>? SmbValidIps = null,
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
        if ( MountNodeIp != null ) {
            this.MountNodeIp = MountNodeIp;
        }
        if ( SmbValidIps != null ) {
            this.SmbValidIps = SmbValidIps;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? DomainControllerId
        // GraphQL -> domainControllerId: String! (scalar)
        if (this.DomainControllerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainControllerId\n" ;
            } else {
                s += ind + "domainControllerId\n" ;
            }
        }
        //      C# -> System.String? DomainControllerName
        // GraphQL -> domainControllerName: String! (scalar)
        if (this.DomainControllerName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainControllerName\n" ;
            } else {
                s += ind + "domainControllerName\n" ;
            }
        }
        //      C# -> System.String? FloatingIp
        // GraphQL -> floatingIp: String (scalar)
        if (this.FloatingIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "floatingIp\n" ;
            } else {
                s += ind + "floatingIp\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        if (this.InternalTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "internalTimestamp\n" ;
            } else {
                s += ind + "internalTimestamp\n" ;
            }
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isActive\n" ;
            } else {
                s += ind + "isActive\n" ;
            }
        }
        //      C# -> System.Boolean? IsUserVisible
        // GraphQL -> isUserVisible: Boolean! (scalar)
        if (this.IsUserVisible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUserVisible\n" ;
            } else {
                s += ind + "isUserVisible\n" ;
            }
        }
        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        if (this.MountDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountDir\n" ;
            } else {
                s += ind + "mountDir\n" ;
            }
        }
        //      C# -> System.String? MountNodeIp
        // GraphQL -> mountNodeIp: String (scalar)
        if (this.MountNodeIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountNodeIp\n" ;
            } else {
                s += ind + "mountNodeIp\n" ;
            }
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (this.SmbValidIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbValidIps\n" ;
            } else {
                s += ind + "smbValidIps\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        if (this.Node != null) {
            var fspec = this.Node.AsFieldSpec(conf.Child("node"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "node" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(conf.Child("sourceSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DomainControllerId
        // GraphQL -> domainControllerId: String! (scalar)
        if (ec.Includes("domainControllerId",true))
        {
            if(this.DomainControllerId == null) {

                this.DomainControllerId = "FETCH";

            } else {


            }
        }
        else if (this.DomainControllerId != null && ec.Excludes("domainControllerId",true))
        {
            this.DomainControllerId = null;
        }
        //      C# -> System.String? DomainControllerName
        // GraphQL -> domainControllerName: String! (scalar)
        if (ec.Includes("domainControllerName",true))
        {
            if(this.DomainControllerName == null) {

                this.DomainControllerName = "FETCH";

            } else {


            }
        }
        else if (this.DomainControllerName != null && ec.Excludes("domainControllerName",true))
        {
            this.DomainControllerName = null;
        }
        //      C# -> System.String? FloatingIp
        // GraphQL -> floatingIp: String (scalar)
        if (ec.Includes("floatingIp",true))
        {
            if(this.FloatingIp == null) {

                this.FloatingIp = "FETCH";

            } else {


            }
        }
        else if (this.FloatingIp != null && ec.Excludes("floatingIp",true))
        {
            this.FloatingIp = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        if (ec.Includes("internalTimestamp",true))
        {
            if(this.InternalTimestamp == null) {

                this.InternalTimestamp = new System.Int64();

            } else {


            }
        }
        else if (this.InternalTimestamp != null && ec.Excludes("internalTimestamp",true))
        {
            this.InternalTimestamp = null;
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (ec.Includes("isActive",true))
        {
            if(this.IsActive == null) {

                this.IsActive = true;

            } else {


            }
        }
        else if (this.IsActive != null && ec.Excludes("isActive",true))
        {
            this.IsActive = null;
        }
        //      C# -> System.Boolean? IsUserVisible
        // GraphQL -> isUserVisible: Boolean! (scalar)
        if (ec.Includes("isUserVisible",true))
        {
            if(this.IsUserVisible == null) {

                this.IsUserVisible = true;

            } else {


            }
        }
        else if (this.IsUserVisible != null && ec.Excludes("isUserVisible",true))
        {
            this.IsUserVisible = null;
        }
        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        if (ec.Includes("mountDir",true))
        {
            if(this.MountDir == null) {

                this.MountDir = "FETCH";

            } else {


            }
        }
        else if (this.MountDir != null && ec.Excludes("mountDir",true))
        {
            this.MountDir = null;
        }
        //      C# -> System.String? MountNodeIp
        // GraphQL -> mountNodeIp: String (scalar)
        if (ec.Includes("mountNodeIp",true))
        {
            if(this.MountNodeIp == null) {

                this.MountNodeIp = "FETCH";

            } else {


            }
        }
        else if (this.MountNodeIp != null && ec.Excludes("mountNodeIp",true))
        {
            this.MountNodeIp = null;
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (ec.Includes("smbValidIps",true))
        {
            if(this.SmbValidIps == null) {

                this.SmbValidIps = new List<System.String>();

            } else {


            }
        }
        else if (this.SmbValidIps != null && ec.Excludes("smbValidIps",true))
        {
            this.SmbValidIps = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        if (ec.Includes("node",false))
        {
            if(this.Node == null) {

                this.Node = new ClusterNode();
                this.Node.ApplyExploratoryFieldSpec(ec.NewChild("node"));

            } else {

                this.Node.ApplyExploratoryFieldSpec(ec.NewChild("node"));

            }
        }
        else if (this.Node != null && ec.Excludes("node",false))
        {
            this.Node = null;
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (ec.Includes("sourceSnapshot",false))
        {
            if(this.SourceSnapshot == null) {

                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            } else {

                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            }
        }
        else if (this.SourceSnapshot != null && ec.Excludes("sourceSnapshot",false))
        {
            this.SourceSnapshot = null;
        }
    }


    #endregion

    } // class AdVolumeExport
    
    #endregion

    public static class ListAdVolumeExportExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AdVolumeExport> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AdVolumeExport> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AdVolumeExport> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AdVolumeExport());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AdVolumeExport> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
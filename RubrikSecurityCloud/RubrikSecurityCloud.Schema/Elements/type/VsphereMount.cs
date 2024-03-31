// VsphereMount.cs
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
    #region VsphereMount
    public class VsphereMount: BaseType
    {
        #region members

        //      C# -> VsphereMountStatus? Status
        // GraphQL -> status: VsphereMountStatus! (enum)
        [JsonProperty("status")]
        public VsphereMountStatus? Status { get; set; }

        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        [JsonProperty("attachingDiskCount")]
        public System.Int32? AttachingDiskCount { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        [JsonProperty("hasAttachingDisk")]
        public System.Boolean? HasAttachingDisk { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MigrateDatastoreRequestId
        // GraphQL -> migrateDatastoreRequestId: String (scalar)
        [JsonProperty("migrateDatastoreRequestId")]
        public System.String? MigrateDatastoreRequestId { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        [JsonProperty("mountTimestamp")]
        public DateTime? MountTimestamp { get; set; }

        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        [JsonProperty("newVmName")]
        public System.String? NewVmName { get; set; }

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

        //      C# -> VsphereHost? Host
        // GraphQL -> host: VsphereHost (type)
        [JsonProperty("host")]
        public VsphereHost? Host { get; set; }

        //      C# -> VsphereVm? NewVm
        // GraphQL -> newVm: VsphereVm (type)
        [JsonProperty("newVm")]
        public VsphereVm? NewVm { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }

        //      C# -> VsphereVm? SourceVm
        // GraphQL -> sourceVm: VsphereVm (type)
        [JsonProperty("sourceVm")]
        public VsphereVm? SourceVm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereMount";
    }

    public VsphereMount Set(
        VsphereMountStatus? Status = null,
        System.Int32? AttachingDiskCount = null,
        System.String? CdmId = null,
        System.String? ClusterName = null,
        System.Boolean? HasAttachingDisk = null,
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MigrateDatastoreRequestId = null,
        System.String? MountRequestId = null,
        DateTime? MountTimestamp = null,
        System.String? NewVmName = null,
        System.String? UnmountRequestId = null,
        AuthorizedOperations? AuthorizedOperations = null,
        Cluster? Cluster = null,
        VsphereHost? Host = null,
        VsphereVm? NewVm = null,
        CdmSnapshot? SourceSnapshot = null,
        VsphereVm? SourceVm = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( AttachingDiskCount != null ) {
            this.AttachingDiskCount = AttachingDiskCount;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( HasAttachingDisk != null ) {
            this.HasAttachingDisk = HasAttachingDisk;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MigrateDatastoreRequestId != null ) {
            this.MigrateDatastoreRequestId = MigrateDatastoreRequestId;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountTimestamp != null ) {
            this.MountTimestamp = MountTimestamp;
        }
        if ( NewVmName != null ) {
            this.NewVmName = NewVmName;
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
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( NewVm != null ) {
            this.NewVm = NewVm;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
        }
        if ( SourceVm != null ) {
            this.SourceVm = SourceVm;
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
        //      C# -> VsphereMountStatus? Status
        // GraphQL -> status: VsphereMountStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        if (this.AttachingDiskCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachingDiskCount\n" ;
            } else {
                s += ind + "attachingDiskCount\n" ;
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        if (this.HasAttachingDisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasAttachingDisk\n" ;
            } else {
                s += ind + "hasAttachingDisk\n" ;
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
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReady\n" ;
            } else {
                s += ind + "isReady\n" ;
            }
        }
        //      C# -> System.String? MigrateDatastoreRequestId
        // GraphQL -> migrateDatastoreRequestId: String (scalar)
        if (this.MigrateDatastoreRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "migrateDatastoreRequestId\n" ;
            } else {
                s += ind + "migrateDatastoreRequestId\n" ;
            }
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountRequestId\n" ;
            } else {
                s += ind + "mountRequestId\n" ;
            }
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountTimestamp\n" ;
            } else {
                s += ind + "mountTimestamp\n" ;
            }
        }
        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        if (this.NewVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newVmName\n" ;
            } else {
                s += ind + "newVmName\n" ;
            }
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unmountRequestId\n" ;
            } else {
                s += ind + "unmountRequestId\n" ;
            }
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            var fspec = this.AuthorizedOperations.AsFieldSpec(conf.Child("authorizedOperations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "authorizedOperations {\n" + fspec + ind + "}\n" ;
                }
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
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VsphereHost? Host
        // GraphQL -> host: VsphereHost (type)
        if (this.Host != null) {
            var fspec = this.Host.AsFieldSpec(conf.Child("host"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "host {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VsphereVm? NewVm
        // GraphQL -> newVm: VsphereVm (type)
        if (this.NewVm != null) {
            var fspec = this.NewVm.AsFieldSpec(conf.Child("newVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newVm {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(conf.Child("sourceSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VsphereVm? SourceVm
        // GraphQL -> sourceVm: VsphereVm (type)
        if (this.SourceVm != null) {
            var fspec = this.SourceVm.AsFieldSpec(conf.Child("sourceVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceVm {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VsphereMountStatus? Status
        // GraphQL -> status: VsphereMountStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new VsphereMountStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        if (ec.Includes("attachingDiskCount",true))
        {
            if(this.AttachingDiskCount == null) {

                this.AttachingDiskCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AttachingDiskCount != null && ec.Excludes("attachingDiskCount",true))
        {
            this.AttachingDiskCount = null;
        }
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
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        if (ec.Includes("hasAttachingDisk",true))
        {
            if(this.HasAttachingDisk == null) {

                this.HasAttachingDisk = true;

            } else {


            }
        }
        else if (this.HasAttachingDisk != null && ec.Excludes("hasAttachingDisk",true))
        {
            this.HasAttachingDisk = null;
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
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (ec.Includes("isReady",true))
        {
            if(this.IsReady == null) {

                this.IsReady = true;

            } else {


            }
        }
        else if (this.IsReady != null && ec.Excludes("isReady",true))
        {
            this.IsReady = null;
        }
        //      C# -> System.String? MigrateDatastoreRequestId
        // GraphQL -> migrateDatastoreRequestId: String (scalar)
        if (ec.Includes("migrateDatastoreRequestId",true))
        {
            if(this.MigrateDatastoreRequestId == null) {

                this.MigrateDatastoreRequestId = "FETCH";

            } else {


            }
        }
        else if (this.MigrateDatastoreRequestId != null && ec.Excludes("migrateDatastoreRequestId",true))
        {
            this.MigrateDatastoreRequestId = null;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (ec.Includes("mountRequestId",true))
        {
            if(this.MountRequestId == null) {

                this.MountRequestId = "FETCH";

            } else {


            }
        }
        else if (this.MountRequestId != null && ec.Excludes("mountRequestId",true))
        {
            this.MountRequestId = null;
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (ec.Includes("mountTimestamp",true))
        {
            if(this.MountTimestamp == null) {

                this.MountTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.MountTimestamp != null && ec.Excludes("mountTimestamp",true))
        {
            this.MountTimestamp = null;
        }
        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        if (ec.Includes("newVmName",true))
        {
            if(this.NewVmName == null) {

                this.NewVmName = "FETCH";

            } else {


            }
        }
        else if (this.NewVmName != null && ec.Excludes("newVmName",true))
        {
            this.NewVmName = null;
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (ec.Includes("unmountRequestId",true))
        {
            if(this.UnmountRequestId == null) {

                this.UnmountRequestId = "FETCH";

            } else {


            }
        }
        else if (this.UnmountRequestId != null && ec.Excludes("unmountRequestId",true))
        {
            this.UnmountRequestId = null;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (ec.Includes("authorizedOperations",false))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new AuthorizedOperations();
                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            } else {

                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",false))
        {
            this.AuthorizedOperations = null;
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
        //      C# -> VsphereHost? Host
        // GraphQL -> host: VsphereHost (type)
        if (ec.Includes("host",false))
        {
            if(this.Host == null) {

                this.Host = new VsphereHost();
                this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));

            } else {

                this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));

            }
        }
        else if (this.Host != null && ec.Excludes("host",false))
        {
            this.Host = null;
        }
        //      C# -> VsphereVm? NewVm
        // GraphQL -> newVm: VsphereVm (type)
        if (ec.Includes("newVm",false))
        {
            if(this.NewVm == null) {

                this.NewVm = new VsphereVm();
                this.NewVm.ApplyExploratoryFieldSpec(ec.NewChild("newVm"));

            } else {

                this.NewVm.ApplyExploratoryFieldSpec(ec.NewChild("newVm"));

            }
        }
        else if (this.NewVm != null && ec.Excludes("newVm",false))
        {
            this.NewVm = null;
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
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
        //      C# -> VsphereVm? SourceVm
        // GraphQL -> sourceVm: VsphereVm (type)
        if (ec.Includes("sourceVm",false))
        {
            if(this.SourceVm == null) {

                this.SourceVm = new VsphereVm();
                this.SourceVm.ApplyExploratoryFieldSpec(ec.NewChild("sourceVm"));

            } else {

                this.SourceVm.ApplyExploratoryFieldSpec(ec.NewChild("sourceVm"));

            }
        }
        else if (this.SourceVm != null && ec.Excludes("sourceVm",false))
        {
            this.SourceVm = null;
        }
    }


    #endregion

    } // class VsphereMount
    
    #endregion

    public static class ListVsphereMountExtensions
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
            this List<VsphereMount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereMount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereMount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereMount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
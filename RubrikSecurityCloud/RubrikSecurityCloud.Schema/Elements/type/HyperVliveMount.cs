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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region HyperVliveMount
    public class HyperVliveMount: BaseType
    {
        #region members

        //      C# -> HypervMountedVmStatusType? MountedVmStatus
        // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
        [JsonProperty("mountedVmStatus")]
        public HypervMountedVmStatusType? MountedVmStatus { get; set; }

        //      C# -> System.Int32? AttachedDiskCount
        // GraphQL -> attachedDiskCount: Int! (scalar)
        [JsonProperty("attachedDiskCount")]
        public System.Int32? AttachedDiskCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsDiskLevelMount
        // GraphQL -> isDiskLevelMount: Boolean! (scalar)
        [JsonProperty("isDiskLevelMount")]
        public System.Boolean? IsDiskLevelMount { get; set; }

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

        //      C# -> System.String? TargetVm
        // GraphQL -> targetVm: String (scalar)
        [JsonProperty("targetVm")]
        public System.String? TargetVm { get; set; }

        //      C# -> System.String? TargetVmFid
        // GraphQL -> targetVmFid: UUID (scalar)
        [JsonProperty("targetVmFid")]
        public System.String? TargetVmFid { get; set; }

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

    public override string GetGqlTypeName() {
        return "HyperVLiveMount";
    }

    public HyperVliveMount Set(
        HypervMountedVmStatusType? MountedVmStatus = null,
        System.Int32? AttachedDiskCount = null,
        System.String? Id = null,
        System.Boolean? IsDiskLevelMount = null,
        System.Boolean? IsVmReady = null,
        System.String? MountSpec = null,
        DateTime? MountTime = null,
        System.String? MountedVmFid = null,
        System.String? Name = null,
        System.String? ServerFid = null,
        System.String? ServerName = null,
        System.String? SourceVm = null,
        System.String? SourceVmFid = null,
        System.String? TargetVm = null,
        System.String? TargetVmFid = null,
        Cluster? Cluster = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( MountedVmStatus != null ) {
            this.MountedVmStatus = MountedVmStatus;
        }
        if ( AttachedDiskCount != null ) {
            this.AttachedDiskCount = AttachedDiskCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsDiskLevelMount != null ) {
            this.IsDiskLevelMount = IsDiskLevelMount;
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
        if ( TargetVm != null ) {
            this.TargetVm = TargetVm;
        }
        if ( TargetVmFid != null ) {
            this.TargetVmFid = TargetVmFid;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> HypervMountedVmStatusType? MountedVmStatus
        // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
        if (this.MountedVmStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmStatus\n" ;
            } else {
                s += ind + "mountedVmStatus\n" ;
            }
        }
        //      C# -> System.Int32? AttachedDiskCount
        // GraphQL -> attachedDiskCount: Int! (scalar)
        if (this.AttachedDiskCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachedDiskCount\n" ;
            } else {
                s += ind + "attachedDiskCount\n" ;
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
        //      C# -> System.Boolean? IsDiskLevelMount
        // GraphQL -> isDiskLevelMount: Boolean! (scalar)
        if (this.IsDiskLevelMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDiskLevelMount\n" ;
            } else {
                s += ind + "isDiskLevelMount\n" ;
            }
        }
        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        if (this.IsVmReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isVmReady\n" ;
            } else {
                s += ind + "isVmReady\n" ;
            }
        }
        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        if (this.MountSpec != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountSpec\n" ;
            } else {
                s += ind + "mountSpec\n" ;
            }
        }
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (this.MountTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountTime\n" ;
            } else {
                s += ind + "mountTime\n" ;
            }
        }
        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: UUID! (scalar)
        if (this.MountedVmFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmFid\n" ;
            } else {
                s += ind + "mountedVmFid\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? ServerFid
        // GraphQL -> serverFid: UUID! (scalar)
        if (this.ServerFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serverFid\n" ;
            } else {
                s += ind + "serverFid\n" ;
            }
        }
        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        if (this.ServerName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serverName\n" ;
            } else {
                s += ind + "serverName\n" ;
            }
        }
        //      C# -> System.String? SourceVm
        // GraphQL -> sourceVm: String! (scalar)
        if (this.SourceVm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVm\n" ;
            } else {
                s += ind + "sourceVm\n" ;
            }
        }
        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: UUID! (scalar)
        if (this.SourceVmFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVmFid\n" ;
            } else {
                s += ind + "sourceVmFid\n" ;
            }
        }
        //      C# -> System.String? TargetVm
        // GraphQL -> targetVm: String (scalar)
        if (this.TargetVm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetVm\n" ;
            } else {
                s += ind + "targetVm\n" ;
            }
        }
        //      C# -> System.String? TargetVmFid
        // GraphQL -> targetVmFid: UUID (scalar)
        if (this.TargetVmFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetVmFid\n" ;
            } else {
                s += ind + "targetVmFid\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(conf.Child("sourceSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HypervMountedVmStatusType? MountedVmStatus
        // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
        if (ec.Includes("mountedVmStatus",true))
        {
            if(this.MountedVmStatus == null) {

                this.MountedVmStatus = new HypervMountedVmStatusType();

            } else {


            }
        }
        else if (this.MountedVmStatus != null && ec.Excludes("mountedVmStatus",true))
        {
            this.MountedVmStatus = null;
        }
        //      C# -> System.Int32? AttachedDiskCount
        // GraphQL -> attachedDiskCount: Int! (scalar)
        if (ec.Includes("attachedDiskCount",true))
        {
            if(this.AttachedDiskCount == null) {

                this.AttachedDiskCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AttachedDiskCount != null && ec.Excludes("attachedDiskCount",true))
        {
            this.AttachedDiskCount = null;
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
        //      C# -> System.Boolean? IsDiskLevelMount
        // GraphQL -> isDiskLevelMount: Boolean! (scalar)
        if (ec.Includes("isDiskLevelMount",true))
        {
            if(this.IsDiskLevelMount == null) {

                this.IsDiskLevelMount = true;

            } else {


            }
        }
        else if (this.IsDiskLevelMount != null && ec.Excludes("isDiskLevelMount",true))
        {
            this.IsDiskLevelMount = null;
        }
        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        if (ec.Includes("isVmReady",true))
        {
            if(this.IsVmReady == null) {

                this.IsVmReady = true;

            } else {


            }
        }
        else if (this.IsVmReady != null && ec.Excludes("isVmReady",true))
        {
            this.IsVmReady = null;
        }
        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        if (ec.Includes("mountSpec",true))
        {
            if(this.MountSpec == null) {

                this.MountSpec = "FETCH";

            } else {


            }
        }
        else if (this.MountSpec != null && ec.Excludes("mountSpec",true))
        {
            this.MountSpec = null;
        }
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (ec.Includes("mountTime",true))
        {
            if(this.MountTime == null) {

                this.MountTime = new DateTime();

            } else {


            }
        }
        else if (this.MountTime != null && ec.Excludes("mountTime",true))
        {
            this.MountTime = null;
        }
        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: UUID! (scalar)
        if (ec.Includes("mountedVmFid",true))
        {
            if(this.MountedVmFid == null) {

                this.MountedVmFid = "FETCH";

            } else {


            }
        }
        else if (this.MountedVmFid != null && ec.Excludes("mountedVmFid",true))
        {
            this.MountedVmFid = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? ServerFid
        // GraphQL -> serverFid: UUID! (scalar)
        if (ec.Includes("serverFid",true))
        {
            if(this.ServerFid == null) {

                this.ServerFid = "FETCH";

            } else {


            }
        }
        else if (this.ServerFid != null && ec.Excludes("serverFid",true))
        {
            this.ServerFid = null;
        }
        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        if (ec.Includes("serverName",true))
        {
            if(this.ServerName == null) {

                this.ServerName = "FETCH";

            } else {


            }
        }
        else if (this.ServerName != null && ec.Excludes("serverName",true))
        {
            this.ServerName = null;
        }
        //      C# -> System.String? SourceVm
        // GraphQL -> sourceVm: String! (scalar)
        if (ec.Includes("sourceVm",true))
        {
            if(this.SourceVm == null) {

                this.SourceVm = "FETCH";

            } else {


            }
        }
        else if (this.SourceVm != null && ec.Excludes("sourceVm",true))
        {
            this.SourceVm = null;
        }
        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: UUID! (scalar)
        if (ec.Includes("sourceVmFid",true))
        {
            if(this.SourceVmFid == null) {

                this.SourceVmFid = "FETCH";

            } else {


            }
        }
        else if (this.SourceVmFid != null && ec.Excludes("sourceVmFid",true))
        {
            this.SourceVmFid = null;
        }
        //      C# -> System.String? TargetVm
        // GraphQL -> targetVm: String (scalar)
        if (ec.Includes("targetVm",true))
        {
            if(this.TargetVm == null) {

                this.TargetVm = "FETCH";

            } else {


            }
        }
        else if (this.TargetVm != null && ec.Excludes("targetVm",true))
        {
            this.TargetVm = null;
        }
        //      C# -> System.String? TargetVmFid
        // GraphQL -> targetVmFid: UUID (scalar)
        if (ec.Includes("targetVmFid",true))
        {
            if(this.TargetVmFid == null) {

                this.TargetVmFid = "FETCH";

            } else {


            }
        }
        else if (this.TargetVmFid != null && ec.Excludes("targetVmFid",true))
        {
            this.TargetVmFid = null;
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
    }


    #endregion

    } // class HyperVliveMount
    
    #endregion

    public static class ListHyperVliveMountExtensions
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
            this List<HyperVliveMount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HyperVliveMount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HyperVliveMount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HyperVliveMount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HyperVliveMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
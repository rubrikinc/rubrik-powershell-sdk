// KosmosWorkloadLiveMount.cs
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
    #region KosmosWorkloadLiveMount
    public class KosmosWorkloadLiveMount: BaseType
    {
        #region members

        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String! (scalar)
        [JsonProperty("hostMountPath")]
        public System.String? HostMountPath { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? MountCreateTime
        // GraphQL -> mountCreateTime: DateTime (scalar)
        [JsonProperty("mountCreateTime")]
        public DateTime? MountCreateTime { get; set; }

        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        [JsonProperty("subnetMask")]
        public System.String? SubnetMask { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        [JsonProperty("workloadName")]
        public System.String? WorkloadName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> PhysicalHost? MountedHost
        // GraphQL -> mountedHost: PhysicalHost (type)
        [JsonProperty("mountedHost")]
        public PhysicalHost? MountedHost { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KosmosWorkloadLiveMount";
    }

    public KosmosWorkloadLiveMount Set(
        System.String? HostMountPath = null,
        System.String? Id = null,
        DateTime? MountCreateTime = null,
        System.String? SubnetMask = null,
        System.String? WorkloadId = null,
        System.String? WorkloadName = null,
        Cluster? Cluster = null,
        PhysicalHost? MountedHost = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( HostMountPath != null ) {
            this.HostMountPath = HostMountPath;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( MountCreateTime != null ) {
            this.MountCreateTime = MountCreateTime;
        }
        if ( SubnetMask != null ) {
            this.SubnetMask = SubnetMask;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadName != null ) {
            this.WorkloadName = WorkloadName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( MountedHost != null ) {
            this.MountedHost = MountedHost;
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
        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String! (scalar)
        if (this.HostMountPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostMountPath\n" ;
            } else {
                s += ind + "hostMountPath\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? MountCreateTime
        // GraphQL -> mountCreateTime: DateTime (scalar)
        if (this.MountCreateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountCreateTime\n" ;
            } else {
                s += ind + "mountCreateTime\n" ;
            }
        }
        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        if (this.SubnetMask != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetMask\n" ;
            } else {
                s += ind + "subnetMask\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadName\n" ;
            } else {
                s += ind + "workloadName\n" ;
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
        //      C# -> PhysicalHost? MountedHost
        // GraphQL -> mountedHost: PhysicalHost (type)
        if (this.MountedHost != null) {
            var fspec = this.MountedHost.AsFieldSpec(conf.Child("mountedHost"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mountedHost" + " " + "{\n" + fspec + ind + "}\n" ;
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
                    s += ind + "sourceSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String! (scalar)
        if (ec.Includes("hostMountPath",true))
        {
            if(this.HostMountPath == null) {

                this.HostMountPath = "FETCH";

            } else {


            }
        }
        else if (this.HostMountPath != null && ec.Excludes("hostMountPath",true))
        {
            this.HostMountPath = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> DateTime? MountCreateTime
        // GraphQL -> mountCreateTime: DateTime (scalar)
        if (ec.Includes("mountCreateTime",true))
        {
            if(this.MountCreateTime == null) {

                this.MountCreateTime = new DateTime();

            } else {


            }
        }
        else if (this.MountCreateTime != null && ec.Excludes("mountCreateTime",true))
        {
            this.MountCreateTime = null;
        }
        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        if (ec.Includes("subnetMask",true))
        {
            if(this.SubnetMask == null) {

                this.SubnetMask = "FETCH";

            } else {


            }
        }
        else if (this.SubnetMask != null && ec.Excludes("subnetMask",true))
        {
            this.SubnetMask = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (ec.Includes("workloadName",true))
        {
            if(this.WorkloadName == null) {

                this.WorkloadName = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadName != null && ec.Excludes("workloadName",true))
        {
            this.WorkloadName = null;
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
        //      C# -> PhysicalHost? MountedHost
        // GraphQL -> mountedHost: PhysicalHost (type)
        if (ec.Includes("mountedHost",false))
        {
            if(this.MountedHost == null) {

                this.MountedHost = new PhysicalHost();
                this.MountedHost.ApplyExploratoryFieldSpec(ec.NewChild("mountedHost"));

            } else {

                this.MountedHost.ApplyExploratoryFieldSpec(ec.NewChild("mountedHost"));

            }
        }
        else if (this.MountedHost != null && ec.Excludes("mountedHost",false))
        {
            this.MountedHost = null;
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

    } // class KosmosWorkloadLiveMount
    
    #endregion

    public static class ListKosmosWorkloadLiveMountExtensions
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
            this List<KosmosWorkloadLiveMount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KosmosWorkloadLiveMount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KosmosWorkloadLiveMount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KosmosWorkloadLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KosmosWorkloadLiveMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
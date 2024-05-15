// VsphereProxyVmInfo.cs
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
    #region VsphereProxyVmInfo
    public class VsphereProxyVmInfo: BaseType
    {
        #region members

        //      C# -> HotAddProxyVmStatus? Status
        // GraphQL -> status: HotAddProxyVmStatus! (enum)
        [JsonProperty("status")]
        public HotAddProxyVmStatus? Status { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        [JsonProperty("computeClusterName")]
        public System.String? ComputeClusterName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        [JsonProperty("usedPortCount")]
        public System.Int32? UsedPortCount { get; set; }

        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        [JsonProperty("vcenterName")]
        public System.String? VcenterName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> VsphereProxyVmNetworkInfo? NetworkInfo
        // GraphQL -> networkInfo: VsphereProxyVmNetworkInfo (type)
        [JsonProperty("networkInfo")]
        public VsphereProxyVmNetworkInfo? NetworkInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereProxyVmInfo";
    }

    public VsphereProxyVmInfo Set(
        HotAddProxyVmStatus? Status = null,
        System.String? ClusterUuid = null,
        System.String? ComputeClusterName = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? UsedPortCount = null,
        System.String? VcenterName = null,
        Cluster? Cluster = null,
        VsphereProxyVmNetworkInfo? NetworkInfo = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( ComputeClusterName != null ) {
            this.ComputeClusterName = ComputeClusterName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( UsedPortCount != null ) {
            this.UsedPortCount = UsedPortCount;
        }
        if ( VcenterName != null ) {
            this.VcenterName = VcenterName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( NetworkInfo != null ) {
            this.NetworkInfo = NetworkInfo;
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
        //      C# -> HotAddProxyVmStatus? Status
        // GraphQL -> status: HotAddProxyVmStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
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
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (this.ComputeClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeClusterName\n" ;
            } else {
                s += ind + "computeClusterName\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        if (this.UsedPortCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedPortCount\n" ;
            } else {
                s += ind + "usedPortCount\n" ;
            }
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        if (this.VcenterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcenterName\n" ;
            } else {
                s += ind + "vcenterName\n" ;
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
        //      C# -> VsphereProxyVmNetworkInfo? NetworkInfo
        // GraphQL -> networkInfo: VsphereProxyVmNetworkInfo (type)
        if (this.NetworkInfo != null) {
            var fspec = this.NetworkInfo.AsFieldSpec(conf.Child("networkInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HotAddProxyVmStatus? Status
        // GraphQL -> status: HotAddProxyVmStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new HotAddProxyVmStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
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
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (ec.Includes("computeClusterName",true))
        {
            if(this.ComputeClusterName == null) {

                this.ComputeClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ComputeClusterName != null && ec.Excludes("computeClusterName",true))
        {
            this.ComputeClusterName = null;
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
        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        if (ec.Includes("usedPortCount",true))
        {
            if(this.UsedPortCount == null) {

                this.UsedPortCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UsedPortCount != null && ec.Excludes("usedPortCount",true))
        {
            this.UsedPortCount = null;
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        if (ec.Includes("vcenterName",true))
        {
            if(this.VcenterName == null) {

                this.VcenterName = "FETCH";

            } else {


            }
        }
        else if (this.VcenterName != null && ec.Excludes("vcenterName",true))
        {
            this.VcenterName = null;
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
        //      C# -> VsphereProxyVmNetworkInfo? NetworkInfo
        // GraphQL -> networkInfo: VsphereProxyVmNetworkInfo (type)
        if (ec.Includes("networkInfo",false))
        {
            if(this.NetworkInfo == null) {

                this.NetworkInfo = new VsphereProxyVmNetworkInfo();
                this.NetworkInfo.ApplyExploratoryFieldSpec(ec.NewChild("networkInfo"));

            } else {

                this.NetworkInfo.ApplyExploratoryFieldSpec(ec.NewChild("networkInfo"));

            }
        }
        else if (this.NetworkInfo != null && ec.Excludes("networkInfo",false))
        {
            this.NetworkInfo = null;
        }
    }


    #endregion

    } // class VsphereProxyVmInfo
    
    #endregion

    public static class ListVsphereProxyVmInfoExtensions
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
            this List<VsphereProxyVmInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereProxyVmInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereProxyVmInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereProxyVmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereProxyVmInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
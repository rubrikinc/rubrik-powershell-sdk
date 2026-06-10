// FusionComputeMountDetail.cs
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
    #region FusionComputeMountDetail
    public class FusionComputeMountDetail: BaseType
    {
        #region members

        //      C# -> FusionComputeVmStatus? VmStatus
        // GraphQL -> vmStatus: FusionComputeVmStatus! (enum)
        [JsonProperty("vmStatus")]
        public FusionComputeVmStatus? VmStatus { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterUrn
        // GraphQL -> clusterUrn: String! (scalar)
        [JsonProperty("clusterUrn")]
        public System.String? ClusterUrn { get; set; }

        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        [JsonProperty("datastoreName")]
        public System.String? DatastoreName { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostUrn
        // GraphQL -> hostUrn: String! (scalar)
        [JsonProperty("hostUrn")]
        public System.String? HostUrn { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountTimestamp
        // GraphQL -> mountTimestamp: String! (scalar)
        [JsonProperty("mountTimestamp")]
        public System.String? MountTimestamp { get; set; }

        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String! (scalar)
        [JsonProperty("mountedVmId")]
        public System.String? MountedVmId { get; set; }

        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String! (scalar)
        [JsonProperty("mountedVmName")]
        public System.String? MountedVmName { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String! (scalar)
        [JsonProperty("nasIp")]
        public System.String? NasIp { get; set; }

        //      C# -> System.String? NewVmUrn
        // GraphQL -> newVmUrn: String! (scalar)
        [JsonProperty("newVmUrn")]
        public System.String? NewVmUrn { get; set; }

        //      C# -> System.String? SiteUrn
        // GraphQL -> siteUrn: String! (scalar)
        [JsonProperty("siteUrn")]
        public System.String? SiteUrn { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: UUID! (scalar)
        [JsonProperty("sourceVmFid")]
        public System.String? SourceVmFid { get; set; }

        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        [JsonProperty("sourceVmId")]
        public System.String? SourceVmId { get; set; }

        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        [JsonProperty("sourceVmName")]
        public System.String? SourceVmName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FusionComputeMountDetail";
    }

    public FusionComputeMountDetail Set(
        FusionComputeVmStatus? VmStatus = null,
        System.String? CdmId = null,
        System.String? ClusterUrn = null,
        System.String? DatastoreName = null,
        System.String? Fid = null,
        System.String? HostName = null,
        System.String? HostUrn = null,
        System.Boolean? IsReady = null,
        System.String? MountTimestamp = null,
        System.String? MountedVmId = null,
        System.String? MountedVmName = null,
        System.String? Name = null,
        System.String? NasIp = null,
        System.String? NewVmUrn = null,
        System.String? SiteUrn = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotFid = null,
        System.String? SourceVmFid = null,
        System.String? SourceVmId = null,
        System.String? SourceVmName = null,
        Cluster? Cluster = null
    ) 
    {
        if ( VmStatus != null ) {
            this.VmStatus = VmStatus;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterUrn != null ) {
            this.ClusterUrn = ClusterUrn;
        }
        if ( DatastoreName != null ) {
            this.DatastoreName = DatastoreName;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( HostUrn != null ) {
            this.HostUrn = HostUrn;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountTimestamp != null ) {
            this.MountTimestamp = MountTimestamp;
        }
        if ( MountedVmId != null ) {
            this.MountedVmId = MountedVmId;
        }
        if ( MountedVmName != null ) {
            this.MountedVmName = MountedVmName;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NasIp != null ) {
            this.NasIp = NasIp;
        }
        if ( NewVmUrn != null ) {
            this.NewVmUrn = NewVmUrn;
        }
        if ( SiteUrn != null ) {
            this.SiteUrn = SiteUrn;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SourceVmFid != null ) {
            this.SourceVmFid = SourceVmFid;
        }
        if ( SourceVmId != null ) {
            this.SourceVmId = SourceVmId;
        }
        if ( SourceVmName != null ) {
            this.SourceVmName = SourceVmName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> FusionComputeVmStatus? VmStatus
        // GraphQL -> vmStatus: FusionComputeVmStatus! (enum)
        if (this.VmStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmStatus\n" ;
            } else {
                s += ind + "vmStatus\n" ;
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
        //      C# -> System.String? ClusterUrn
        // GraphQL -> clusterUrn: String! (scalar)
        if (this.ClusterUrn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUrn\n" ;
            } else {
                s += ind + "clusterUrn\n" ;
            }
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (this.DatastoreName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreName\n" ;
            } else {
                s += ind + "datastoreName\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? HostUrn
        // GraphQL -> hostUrn: String! (scalar)
        if (this.HostUrn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostUrn\n" ;
            } else {
                s += ind + "hostUrn\n" ;
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
        //      C# -> System.String? MountTimestamp
        // GraphQL -> mountTimestamp: String! (scalar)
        if (this.MountTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountTimestamp\n" ;
            } else {
                s += ind + "mountTimestamp\n" ;
            }
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String! (scalar)
        if (this.MountedVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmId\n" ;
            } else {
                s += ind + "mountedVmId\n" ;
            }
        }
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String! (scalar)
        if (this.MountedVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmName\n" ;
            } else {
                s += ind + "mountedVmName\n" ;
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
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String! (scalar)
        if (this.NasIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasIp\n" ;
            } else {
                s += ind + "nasIp\n" ;
            }
        }
        //      C# -> System.String? NewVmUrn
        // GraphQL -> newVmUrn: String! (scalar)
        if (this.NewVmUrn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newVmUrn\n" ;
            } else {
                s += ind + "newVmUrn\n" ;
            }
        }
        //      C# -> System.String? SiteUrn
        // GraphQL -> siteUrn: String! (scalar)
        if (this.SiteUrn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "siteUrn\n" ;
            } else {
                s += ind + "siteUrn\n" ;
            }
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotDate\n" ;
            } else {
                s += ind + "snapshotDate\n" ;
            }
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        if (this.SnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFid\n" ;
            } else {
                s += ind + "snapshotFid\n" ;
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
        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        if (this.SourceVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVmId\n" ;
            } else {
                s += ind + "sourceVmId\n" ;
            }
        }
        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        if (this.SourceVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVmName\n" ;
            } else {
                s += ind + "sourceVmName\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FusionComputeVmStatus? VmStatus
        // GraphQL -> vmStatus: FusionComputeVmStatus! (enum)
        if (ec.Includes("vmStatus",true))
        {
            if(this.VmStatus == null) {

                this.VmStatus = new FusionComputeVmStatus();

            } else {


            }
        }
        else if (this.VmStatus != null && ec.Excludes("vmStatus",true))
        {
            this.VmStatus = null;
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
        //      C# -> System.String? ClusterUrn
        // GraphQL -> clusterUrn: String! (scalar)
        if (ec.Includes("clusterUrn",true))
        {
            if(this.ClusterUrn == null) {

                this.ClusterUrn = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUrn != null && ec.Excludes("clusterUrn",true))
        {
            this.ClusterUrn = null;
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (ec.Includes("datastoreName",true))
        {
            if(this.DatastoreName == null) {

                this.DatastoreName = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreName != null && ec.Excludes("datastoreName",true))
        {
            this.DatastoreName = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? HostUrn
        // GraphQL -> hostUrn: String! (scalar)
        if (ec.Includes("hostUrn",true))
        {
            if(this.HostUrn == null) {

                this.HostUrn = "FETCH";

            } else {


            }
        }
        else if (this.HostUrn != null && ec.Excludes("hostUrn",true))
        {
            this.HostUrn = null;
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
        //      C# -> System.String? MountTimestamp
        // GraphQL -> mountTimestamp: String! (scalar)
        if (ec.Includes("mountTimestamp",true))
        {
            if(this.MountTimestamp == null) {

                this.MountTimestamp = "FETCH";

            } else {


            }
        }
        else if (this.MountTimestamp != null && ec.Excludes("mountTimestamp",true))
        {
            this.MountTimestamp = null;
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String! (scalar)
        if (ec.Includes("mountedVmId",true))
        {
            if(this.MountedVmId == null) {

                this.MountedVmId = "FETCH";

            } else {


            }
        }
        else if (this.MountedVmId != null && ec.Excludes("mountedVmId",true))
        {
            this.MountedVmId = null;
        }
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String! (scalar)
        if (ec.Includes("mountedVmName",true))
        {
            if(this.MountedVmName == null) {

                this.MountedVmName = "FETCH";

            } else {


            }
        }
        else if (this.MountedVmName != null && ec.Excludes("mountedVmName",true))
        {
            this.MountedVmName = null;
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
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String! (scalar)
        if (ec.Includes("nasIp",true))
        {
            if(this.NasIp == null) {

                this.NasIp = "FETCH";

            } else {


            }
        }
        else if (this.NasIp != null && ec.Excludes("nasIp",true))
        {
            this.NasIp = null;
        }
        //      C# -> System.String? NewVmUrn
        // GraphQL -> newVmUrn: String! (scalar)
        if (ec.Includes("newVmUrn",true))
        {
            if(this.NewVmUrn == null) {

                this.NewVmUrn = "FETCH";

            } else {


            }
        }
        else if (this.NewVmUrn != null && ec.Excludes("newVmUrn",true))
        {
            this.NewVmUrn = null;
        }
        //      C# -> System.String? SiteUrn
        // GraphQL -> siteUrn: String! (scalar)
        if (ec.Includes("siteUrn",true))
        {
            if(this.SiteUrn == null) {

                this.SiteUrn = "FETCH";

            } else {


            }
        }
        else if (this.SiteUrn != null && ec.Excludes("siteUrn",true))
        {
            this.SiteUrn = null;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (ec.Includes("snapshotDate",true))
        {
            if(this.SnapshotDate == null) {

                this.SnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotDate != null && ec.Excludes("snapshotDate",true))
        {
            this.SnapshotDate = null;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        if (ec.Includes("snapshotFid",true))
        {
            if(this.SnapshotFid == null) {

                this.SnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotFid != null && ec.Excludes("snapshotFid",true))
        {
            this.SnapshotFid = null;
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
        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        if (ec.Includes("sourceVmId",true))
        {
            if(this.SourceVmId == null) {

                this.SourceVmId = "FETCH";

            } else {


            }
        }
        else if (this.SourceVmId != null && ec.Excludes("sourceVmId",true))
        {
            this.SourceVmId = null;
        }
        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        if (ec.Includes("sourceVmName",true))
        {
            if(this.SourceVmName == null) {

                this.SourceVmName = "FETCH";

            } else {


            }
        }
        else if (this.SourceVmName != null && ec.Excludes("sourceVmName",true))
        {
            this.SourceVmName = null;
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
    }


    #endregion

    } // class FusionComputeMountDetail
    
    #endregion

    public static class ListFusionComputeMountDetailExtensions
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
            this List<FusionComputeMountDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FusionComputeMountDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FusionComputeMountDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FusionComputeMountDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FusionComputeMountDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
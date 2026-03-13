// ReclaimableClusterStatsData.cs
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
    #region ReclaimableClusterStatsData
    public class ReclaimableClusterStatsData: BaseType
    {
        #region members

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int64? DownloadedSnapshotsStorage
        // GraphQL -> downloadedSnapshotsStorage: Long! (scalar)
        [JsonProperty("downloadedSnapshotsStorage")]
        public System.Int64? DownloadedSnapshotsStorage { get; set; }

        //      C# -> System.Int64? OtherStorage
        // GraphQL -> otherStorage: Long! (scalar)
        [JsonProperty("otherStorage")]
        public System.Int64? OtherStorage { get; set; }

        //      C# -> System.Int64? RelicStorage
        // GraphQL -> relicStorage: Long! (scalar)
        [JsonProperty("relicStorage")]
        public System.Int64? RelicStorage { get; set; }

        //      C# -> System.Int64? TotalCapacity
        // GraphQL -> totalCapacity: Long! (scalar)
        [JsonProperty("totalCapacity")]
        public System.Int64? TotalCapacity { get; set; }

        //      C# -> System.Int64? TotalUsedStorage
        // GraphQL -> totalUsedStorage: Long! (scalar)
        [JsonProperty("totalUsedStorage")]
        public System.Int64? TotalUsedStorage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReclaimableClusterStatsData";
    }

    public ReclaimableClusterStatsData Set(
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.Int64? DownloadedSnapshotsStorage = null,
        System.Int64? OtherStorage = null,
        System.Int64? RelicStorage = null,
        System.Int64? TotalCapacity = null,
        System.Int64? TotalUsedStorage = null
    ) 
    {
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DownloadedSnapshotsStorage != null ) {
            this.DownloadedSnapshotsStorage = DownloadedSnapshotsStorage;
        }
        if ( OtherStorage != null ) {
            this.OtherStorage = OtherStorage;
        }
        if ( RelicStorage != null ) {
            this.RelicStorage = RelicStorage;
        }
        if ( TotalCapacity != null ) {
            this.TotalCapacity = TotalCapacity;
        }
        if ( TotalUsedStorage != null ) {
            this.TotalUsedStorage = TotalUsedStorage;
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
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
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
        //      C# -> System.Int64? DownloadedSnapshotsStorage
        // GraphQL -> downloadedSnapshotsStorage: Long! (scalar)
        if (this.DownloadedSnapshotsStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadedSnapshotsStorage\n" ;
            } else {
                s += ind + "downloadedSnapshotsStorage\n" ;
            }
        }
        //      C# -> System.Int64? OtherStorage
        // GraphQL -> otherStorage: Long! (scalar)
        if (this.OtherStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "otherStorage\n" ;
            } else {
                s += ind + "otherStorage\n" ;
            }
        }
        //      C# -> System.Int64? RelicStorage
        // GraphQL -> relicStorage: Long! (scalar)
        if (this.RelicStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relicStorage\n" ;
            } else {
                s += ind + "relicStorage\n" ;
            }
        }
        //      C# -> System.Int64? TotalCapacity
        // GraphQL -> totalCapacity: Long! (scalar)
        if (this.TotalCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCapacity\n" ;
            } else {
                s += ind + "totalCapacity\n" ;
            }
        }
        //      C# -> System.Int64? TotalUsedStorage
        // GraphQL -> totalUsedStorage: Long! (scalar)
        if (this.TotalUsedStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalUsedStorage\n" ;
            } else {
                s += ind + "totalUsedStorage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.Int64? DownloadedSnapshotsStorage
        // GraphQL -> downloadedSnapshotsStorage: Long! (scalar)
        if (ec.Includes("downloadedSnapshotsStorage",true))
        {
            if(this.DownloadedSnapshotsStorage == null) {

                this.DownloadedSnapshotsStorage = new System.Int64();

            } else {


            }
        }
        else if (this.DownloadedSnapshotsStorage != null && ec.Excludes("downloadedSnapshotsStorage",true))
        {
            this.DownloadedSnapshotsStorage = null;
        }
        //      C# -> System.Int64? OtherStorage
        // GraphQL -> otherStorage: Long! (scalar)
        if (ec.Includes("otherStorage",true))
        {
            if(this.OtherStorage == null) {

                this.OtherStorage = new System.Int64();

            } else {


            }
        }
        else if (this.OtherStorage != null && ec.Excludes("otherStorage",true))
        {
            this.OtherStorage = null;
        }
        //      C# -> System.Int64? RelicStorage
        // GraphQL -> relicStorage: Long! (scalar)
        if (ec.Includes("relicStorage",true))
        {
            if(this.RelicStorage == null) {

                this.RelicStorage = new System.Int64();

            } else {


            }
        }
        else if (this.RelicStorage != null && ec.Excludes("relicStorage",true))
        {
            this.RelicStorage = null;
        }
        //      C# -> System.Int64? TotalCapacity
        // GraphQL -> totalCapacity: Long! (scalar)
        if (ec.Includes("totalCapacity",true))
        {
            if(this.TotalCapacity == null) {

                this.TotalCapacity = new System.Int64();

            } else {


            }
        }
        else if (this.TotalCapacity != null && ec.Excludes("totalCapacity",true))
        {
            this.TotalCapacity = null;
        }
        //      C# -> System.Int64? TotalUsedStorage
        // GraphQL -> totalUsedStorage: Long! (scalar)
        if (ec.Includes("totalUsedStorage",true))
        {
            if(this.TotalUsedStorage == null) {

                this.TotalUsedStorage = new System.Int64();

            } else {


            }
        }
        else if (this.TotalUsedStorage != null && ec.Excludes("totalUsedStorage",true))
        {
            this.TotalUsedStorage = null;
        }
    }


    #endregion

    } // class ReclaimableClusterStatsData
    
    #endregion

    public static class ListReclaimableClusterStatsDataExtensions
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
            this List<ReclaimableClusterStatsData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReclaimableClusterStatsData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReclaimableClusterStatsData> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReclaimableClusterStatsData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReclaimableClusterStatsData> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
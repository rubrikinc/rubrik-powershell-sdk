// MosaicSnapshot.cs
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
    #region MosaicSnapshot
    public class MosaicSnapshot: BaseType
    {
        #region members

        //      C# -> MosaicSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public MosaicSnapshotType? SnapshotType { get; set; }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        [JsonProperty("slaDomain")]
        public RscInterface<SlaDomain> SlaDomain { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        [JsonProperty("dbInfo")]
        public System.String? DbInfo { get; set; }

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        [JsonProperty("jobDuration")]
        public System.Int32? JobDuration { get; set; }

        //      C# -> DateTime? Version
        // GraphQL -> version: DateTime! (scalar)
        [JsonProperty("version")]
        public DateTime? Version { get; set; }

        //      C# -> System.String? VersionState
        // GraphQL -> versionState: String (scalar)
        [JsonProperty("versionState")]
        public System.String? VersionState { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MosaicSnapshot";
    }

    public MosaicSnapshot Set(
        MosaicSnapshotType? SnapshotType = null,
        RscInterface<SlaDomain> SlaDomain = null,
        System.String? ClusterUuid = null,
        System.String? DbInfo = null,
        DateTime? ExpirationTime = null,
        System.String? Id = null,
        System.Int32? JobDuration = null,
        DateTime? Version = null,
        System.String? VersionState = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DbInfo != null ) {
            this.DbInfo = DbInfo;
        }
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( JobDuration != null ) {
            this.JobDuration = JobDuration;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( VersionState != null ) {
            this.VersionState = VersionState;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> MosaicSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain != null) {
            var fspec = this.SlaDomain.AsFieldSpec(conf.Child("slaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
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
        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        if (this.DbInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbInfo\n" ;
            } else {
                s += ind + "dbInfo\n" ;
            }
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationTime\n" ;
            } else {
                s += ind + "expirationTime\n" ;
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
        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        if (this.JobDuration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobDuration\n" ;
            } else {
                s += ind + "jobDuration\n" ;
            }
        }
        //      C# -> DateTime? Version
        // GraphQL -> version: DateTime! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> System.String? VersionState
        // GraphQL -> versionState: String (scalar)
        if (this.VersionState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versionState\n" ;
            } else {
                s += ind + "versionState\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MosaicSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = new MosaicSnapshotType();

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (ec.Includes("slaDomain",false))
        {
            if(this.SlaDomain == null) {

                this.SlaDomain = new RscInterface<SlaDomain>();
                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            } else {

                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            }
        }
        else if (this.SlaDomain != null && ec.Excludes("slaDomain",false))
        {
            this.SlaDomain = null;
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
        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        if (ec.Includes("dbInfo",true))
        {
            if(this.DbInfo == null) {

                this.DbInfo = "FETCH";

            } else {


            }
        }
        else if (this.DbInfo != null && ec.Excludes("dbInfo",true))
        {
            this.DbInfo = null;
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (ec.Includes("expirationTime",true))
        {
            if(this.ExpirationTime == null) {

                this.ExpirationTime = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationTime != null && ec.Excludes("expirationTime",true))
        {
            this.ExpirationTime = null;
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
        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        if (ec.Includes("jobDuration",true))
        {
            if(this.JobDuration == null) {

                this.JobDuration = Int32.MinValue;

            } else {


            }
        }
        else if (this.JobDuration != null && ec.Excludes("jobDuration",true))
        {
            this.JobDuration = null;
        }
        //      C# -> DateTime? Version
        // GraphQL -> version: DateTime! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new DateTime();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> System.String? VersionState
        // GraphQL -> versionState: String (scalar)
        if (ec.Includes("versionState",true))
        {
            if(this.VersionState == null) {

                this.VersionState = "FETCH";

            } else {


            }
        }
        else if (this.VersionState != null && ec.Excludes("versionState",true))
        {
            this.VersionState = null;
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
    }


    #endregion

    } // class MosaicSnapshot
    
    #endregion

    public static class ListMosaicSnapshotExtensions
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
            this List<MosaicSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MosaicSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MosaicSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
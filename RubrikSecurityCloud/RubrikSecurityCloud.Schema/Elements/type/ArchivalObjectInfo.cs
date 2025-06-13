// ArchivalObjectInfo.cs
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
    #region ArchivalObjectInfo
    public class ArchivalObjectInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? ArchivalLag
        // GraphQL -> archivalLag: Long! (scalar)
        [JsonProperty("archivalLag")]
        public System.Int64? ArchivalLag { get; set; }

        //      C# -> DateTime? LatestArchivedSnapshotDate
        // GraphQL -> latestArchivedSnapshotDate: DateTime (scalar)
        [JsonProperty("latestArchivedSnapshotDate")]
        public DateTime? LatestArchivedSnapshotDate { get; set; }

        //      C# -> System.Int64? NumActiveSnapshots
        // GraphQL -> numActiveSnapshots: Long! (scalar)
        [JsonProperty("numActiveSnapshots")]
        public System.Int64? NumActiveSnapshots { get; set; }

        //      C# -> System.String? ObjectLocation
        // GraphQL -> objectLocation: String! (scalar)
        [JsonProperty("objectLocation")]
        public System.String? ObjectLocation { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? ObjectStatus
        // GraphQL -> objectStatus: String! (scalar)
        [JsonProperty("objectStatus")]
        public System.String? ObjectStatus { get; set; }

        //      C# -> System.String? ObjectType
        // GraphQL -> objectType: String! (scalar)
        [JsonProperty("objectType")]
        public System.String? ObjectType { get; set; }

        //      C# -> System.String? SlaDomain
        // GraphQL -> slaDomain: String! (scalar)
        [JsonProperty("slaDomain")]
        public System.String? SlaDomain { get; set; }

        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        [JsonProperty("storageUsage")]
        public System.Int64? StorageUsage { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalObjectInfo";
    }

    public ArchivalObjectInfo Set(
        System.Int64? ArchivalLag = null,
        DateTime? LatestArchivedSnapshotDate = null,
        System.Int64? NumActiveSnapshots = null,
        System.String? ObjectLocation = null,
        System.String? ObjectName = null,
        System.String? ObjectStatus = null,
        System.String? ObjectType = null,
        System.String? SlaDomain = null,
        System.Int64? StorageUsage = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( ArchivalLag != null ) {
            this.ArchivalLag = ArchivalLag;
        }
        if ( LatestArchivedSnapshotDate != null ) {
            this.LatestArchivedSnapshotDate = LatestArchivedSnapshotDate;
        }
        if ( NumActiveSnapshots != null ) {
            this.NumActiveSnapshots = NumActiveSnapshots;
        }
        if ( ObjectLocation != null ) {
            this.ObjectLocation = ObjectLocation;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( ObjectStatus != null ) {
            this.ObjectStatus = ObjectStatus;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( StorageUsage != null ) {
            this.StorageUsage = StorageUsage;
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
        //      C# -> System.Int64? ArchivalLag
        // GraphQL -> archivalLag: Long! (scalar)
        if (this.ArchivalLag != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLag\n" ;
            } else {
                s += ind + "archivalLag\n" ;
            }
        }
        //      C# -> DateTime? LatestArchivedSnapshotDate
        // GraphQL -> latestArchivedSnapshotDate: DateTime (scalar)
        if (this.LatestArchivedSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestArchivedSnapshotDate\n" ;
            } else {
                s += ind + "latestArchivedSnapshotDate\n" ;
            }
        }
        //      C# -> System.Int64? NumActiveSnapshots
        // GraphQL -> numActiveSnapshots: Long! (scalar)
        if (this.NumActiveSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numActiveSnapshots\n" ;
            } else {
                s += ind + "numActiveSnapshots\n" ;
            }
        }
        //      C# -> System.String? ObjectLocation
        // GraphQL -> objectLocation: String! (scalar)
        if (this.ObjectLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectLocation\n" ;
            } else {
                s += ind + "objectLocation\n" ;
            }
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectName\n" ;
            } else {
                s += ind + "objectName\n" ;
            }
        }
        //      C# -> System.String? ObjectStatus
        // GraphQL -> objectStatus: String! (scalar)
        if (this.ObjectStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectStatus\n" ;
            } else {
                s += ind + "objectStatus\n" ;
            }
        }
        //      C# -> System.String? ObjectType
        // GraphQL -> objectType: String! (scalar)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.String? SlaDomain
        // GraphQL -> slaDomain: String! (scalar)
        if (this.SlaDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomain\n" ;
            } else {
                s += ind + "slaDomain\n" ;
            }
        }
        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        if (this.StorageUsage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageUsage\n" ;
            } else {
                s += ind + "storageUsage\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ArchivalLag
        // GraphQL -> archivalLag: Long! (scalar)
        if (ec.Includes("archivalLag",true))
        {
            if(this.ArchivalLag == null) {

                this.ArchivalLag = new System.Int64();

            } else {


            }
        }
        else if (this.ArchivalLag != null && ec.Excludes("archivalLag",true))
        {
            this.ArchivalLag = null;
        }
        //      C# -> DateTime? LatestArchivedSnapshotDate
        // GraphQL -> latestArchivedSnapshotDate: DateTime (scalar)
        if (ec.Includes("latestArchivedSnapshotDate",true))
        {
            if(this.LatestArchivedSnapshotDate == null) {

                this.LatestArchivedSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.LatestArchivedSnapshotDate != null && ec.Excludes("latestArchivedSnapshotDate",true))
        {
            this.LatestArchivedSnapshotDate = null;
        }
        //      C# -> System.Int64? NumActiveSnapshots
        // GraphQL -> numActiveSnapshots: Long! (scalar)
        if (ec.Includes("numActiveSnapshots",true))
        {
            if(this.NumActiveSnapshots == null) {

                this.NumActiveSnapshots = new System.Int64();

            } else {


            }
        }
        else if (this.NumActiveSnapshots != null && ec.Excludes("numActiveSnapshots",true))
        {
            this.NumActiveSnapshots = null;
        }
        //      C# -> System.String? ObjectLocation
        // GraphQL -> objectLocation: String! (scalar)
        if (ec.Includes("objectLocation",true))
        {
            if(this.ObjectLocation == null) {

                this.ObjectLocation = "FETCH";

            } else {


            }
        }
        else if (this.ObjectLocation != null && ec.Excludes("objectLocation",true))
        {
            this.ObjectLocation = null;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (ec.Includes("objectName",true))
        {
            if(this.ObjectName == null) {

                this.ObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ObjectName != null && ec.Excludes("objectName",true))
        {
            this.ObjectName = null;
        }
        //      C# -> System.String? ObjectStatus
        // GraphQL -> objectStatus: String! (scalar)
        if (ec.Includes("objectStatus",true))
        {
            if(this.ObjectStatus == null) {

                this.ObjectStatus = "FETCH";

            } else {


            }
        }
        else if (this.ObjectStatus != null && ec.Excludes("objectStatus",true))
        {
            this.ObjectStatus = null;
        }
        //      C# -> System.String? ObjectType
        // GraphQL -> objectType: String! (scalar)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = "FETCH";

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.String? SlaDomain
        // GraphQL -> slaDomain: String! (scalar)
        if (ec.Includes("slaDomain",true))
        {
            if(this.SlaDomain == null) {

                this.SlaDomain = "FETCH";

            } else {


            }
        }
        else if (this.SlaDomain != null && ec.Excludes("slaDomain",true))
        {
            this.SlaDomain = null;
        }
        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        if (ec.Includes("storageUsage",true))
        {
            if(this.StorageUsage == null) {

                this.StorageUsage = new System.Int64();

            } else {


            }
        }
        else if (this.StorageUsage != null && ec.Excludes("storageUsage",true))
        {
            this.StorageUsage = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String (scalar)
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

    } // class ArchivalObjectInfo
    
    #endregion

    public static class ListArchivalObjectInfoExtensions
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
            this List<ArchivalObjectInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalObjectInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalObjectInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalObjectInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalObjectInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
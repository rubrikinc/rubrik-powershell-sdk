// M365Snapshot.cs
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
    #region M365Snapshot
 
    public class M365Snapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> BackupEventStatus? BackupEventStatus
        // GraphQL -> backupEventStatus: BackupEventStatus (type)
        [JsonProperty("backupEventStatus")]
        public BackupEventStatus? BackupEventStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365Snapshot";
    }

    public M365Snapshot Set(
        System.String? SnapshotId = null,
        BackupEventStatus? BackupEventStatus = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( BackupEventStatus != null ) {
            this.BackupEventStatus = BackupEventStatus;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> BackupEventStatus? BackupEventStatus
        // GraphQL -> backupEventStatus: BackupEventStatus (type)
        if (this.BackupEventStatus != null) {
            var fspec = this.BackupEventStatus.AsFieldSpec(conf.Child("backupEventStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupEventStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> BackupEventStatus? BackupEventStatus
        // GraphQL -> backupEventStatus: BackupEventStatus (type)
        if (ec.Includes("backupEventStatus",false))
        {
            if(this.BackupEventStatus == null) {

                this.BackupEventStatus = new BackupEventStatus();
                this.BackupEventStatus.ApplyExploratoryFieldSpec(ec.NewChild("backupEventStatus"));

            } else {

                this.BackupEventStatus.ApplyExploratoryFieldSpec(ec.NewChild("backupEventStatus"));

            }
        }
        else if (this.BackupEventStatus != null && ec.Excludes("backupEventStatus",false))
        {
            this.BackupEventStatus = null;
        }
    }


    #endregion

    } // class M365Snapshot
    
    #endregion

    public static class ListM365SnapshotExtensions
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
            this List<M365Snapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<M365Snapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365Snapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365Snapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
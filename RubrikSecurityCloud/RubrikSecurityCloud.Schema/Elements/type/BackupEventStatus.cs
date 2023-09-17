// BackupEventStatus.cs
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
    #region BackupEventStatus
    public class BackupEventStatus: BaseType
    {
        #region members

        //      C# -> SnapshotServiceBackupStatus? Status
        // GraphQL -> status: SnapshotServiceBackupStatus! (enum)
        [JsonProperty("status")]
        public SnapshotServiceBackupStatus? Status { get; set; }

        //      C# -> System.Int64? SkippedItemCount
        // GraphQL -> skippedItemCount: Long! (scalar)
        [JsonProperty("skippedItemCount")]
        public System.Int64? SkippedItemCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BackupEventStatus";
    }

    public BackupEventStatus Set(
        SnapshotServiceBackupStatus? Status = null,
        System.Int64? SkippedItemCount = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SkippedItemCount != null ) {
            this.SkippedItemCount = SkippedItemCount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SnapshotServiceBackupStatus? Status
        // GraphQL -> status: SnapshotServiceBackupStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int64? SkippedItemCount
        // GraphQL -> skippedItemCount: Long! (scalar)
        if (this.SkippedItemCount != null) {
            s += ind + "skippedItemCount\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotServiceBackupStatus? Status
        // GraphQL -> status: SnapshotServiceBackupStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new SnapshotServiceBackupStatus();
        }
        //      C# -> System.Int64? SkippedItemCount
        // GraphQL -> skippedItemCount: Long! (scalar)
        if (this.SkippedItemCount == null && ec.Includes("skippedItemCount",true))
        {
            this.SkippedItemCount = new System.Int64();
        }
    }


    #endregion

    } // class BackupEventStatus
    
    #endregion

    public static class ListBackupEventStatusExtensions
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
            this List<BackupEventStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BackupEventStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupEventStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupEventStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
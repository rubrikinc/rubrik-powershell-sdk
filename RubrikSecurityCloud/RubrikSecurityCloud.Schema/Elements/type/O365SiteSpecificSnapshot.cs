// O365SiteSpecificSnapshot.cs
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
    #region O365SiteSpecificSnapshot
 
    public class O365SiteSpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> SnapshotServiceBackupStatus? BackupStatus
        // GraphQL -> backupStatus: SnapshotServiceBackupStatus! (enum)
        [JsonProperty("backupStatus")]
        public SnapshotServiceBackupStatus? BackupStatus { get; set; }

        //      C# -> System.Int32? PercentOfObjectsSkipped
        // GraphQL -> percentOfObjectsSkipped: Int! (scalar)
        [JsonProperty("percentOfObjectsSkipped")]
        public System.Int32? PercentOfObjectsSkipped { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365SiteSpecificSnapshot";
    }

    public O365SiteSpecificSnapshot Set(
        SnapshotServiceBackupStatus? BackupStatus = null,
        System.Int32? PercentOfObjectsSkipped = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( BackupStatus != null ) {
            this.BackupStatus = BackupStatus;
        }
        if ( PercentOfObjectsSkipped != null ) {
            this.PercentOfObjectsSkipped = PercentOfObjectsSkipped;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> SnapshotServiceBackupStatus? BackupStatus
        // GraphQL -> backupStatus: SnapshotServiceBackupStatus! (enum)
        if (this.BackupStatus != null) {
            s += ind + "backupStatus\n" ;
        }
        //      C# -> System.Int32? PercentOfObjectsSkipped
        // GraphQL -> percentOfObjectsSkipped: Int! (scalar)
        if (this.PercentOfObjectsSkipped != null) {
            s += ind + "percentOfObjectsSkipped\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotServiceBackupStatus? BackupStatus
        // GraphQL -> backupStatus: SnapshotServiceBackupStatus! (enum)
        if (this.BackupStatus == null && ec.Includes("backupStatus",true))
        {
            this.BackupStatus = new SnapshotServiceBackupStatus();
        }
        //      C# -> System.Int32? PercentOfObjectsSkipped
        // GraphQL -> percentOfObjectsSkipped: Int! (scalar)
        if (this.PercentOfObjectsSkipped == null && ec.Includes("percentOfObjectsSkipped",true))
        {
            this.PercentOfObjectsSkipped = Int32.MinValue;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
    }


    #endregion

    } // class O365SiteSpecificSnapshot
    
    #endregion

    public static class ListO365SiteSpecificSnapshotExtensions
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
            this List<O365SiteSpecificSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365SiteSpecificSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365SiteSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365SiteSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
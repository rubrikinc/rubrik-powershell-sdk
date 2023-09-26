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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SnapshotServiceBackupStatus? BackupStatus
        // GraphQL -> backupStatus: SnapshotServiceBackupStatus! (enum)
        if (this.BackupStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupStatus\n" ;
            } else {
                s += ind + "backupStatus\n" ;
            }
        }
        //      C# -> System.Int32? PercentOfObjectsSkipped
        // GraphQL -> percentOfObjectsSkipped: Int! (scalar)
        if (this.PercentOfObjectsSkipped != null) {
            if (conf.Flat) {
                s += conf.Prefix + "percentOfObjectsSkipped\n" ;
            } else {
                s += ind + "percentOfObjectsSkipped\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotServiceBackupStatus? BackupStatus
        // GraphQL -> backupStatus: SnapshotServiceBackupStatus! (enum)
        if (ec.Includes("backupStatus",true))
        {
            if(this.BackupStatus == null) {

                this.BackupStatus = new SnapshotServiceBackupStatus();

            } else {


            }
        }
        else if (this.BackupStatus != null && ec.Excludes("backupStatus",true))
        {
            this.BackupStatus = null;
        }
        //      C# -> System.Int32? PercentOfObjectsSkipped
        // GraphQL -> percentOfObjectsSkipped: Int! (scalar)
        if (ec.Includes("percentOfObjectsSkipped",true))
        {
            if(this.PercentOfObjectsSkipped == null) {

                this.PercentOfObjectsSkipped = Int32.MinValue;

            } else {


            }
        }
        else if (this.PercentOfObjectsSkipped != null && ec.Excludes("percentOfObjectsSkipped",true))
        {
            this.PercentOfObjectsSkipped = null;
        }
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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
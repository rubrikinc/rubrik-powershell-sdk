// Db2RecoverableRange.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region Db2RecoverableRange
    public class Db2RecoverableRange: IFragment
    {
        #region members
        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        [JsonProperty("baseSnapshotId")]
        public System.String? BaseSnapshotId { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DbId
        // GraphQL -> dbId: String! (scalar)
        [JsonProperty("dbId")]
        public System.String? DbId { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        #endregion

    #region methods

    public Db2RecoverableRange Set(
        System.String? BaseSnapshotId = null,
        System.String? CdmId = null,
        System.String? ClusterUuid = null,
        System.String? DbId = null,
        DateTime? EndTime = null,
        System.String? Fid = null,
        System.Boolean? IsArchived = null,
        DateTime? StartTime = null
    ) 
    {
        if ( BaseSnapshotId != null ) {
            this.BaseSnapshotId = BaseSnapshotId;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DbId != null ) {
            this.DbId = DbId;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? BaseSnapshotId
            // GraphQL -> baseSnapshotId: String (scalar)
            if (this.BaseSnapshotId != null)
            {
                 s += ind + "baseSnapshotId\n";

            }
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? DbId
            // GraphQL -> dbId: String! (scalar)
            if (this.DbId != null)
            {
                 s += ind + "dbId\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: String! (scalar)
            if (this.Fid != null)
            {
                 s += ind + "fid\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? BaseSnapshotId
            // GraphQL -> baseSnapshotId: String (scalar)
            if (this.BaseSnapshotId == null && Exploration.Includes(parent + ".baseSnapshotId$"))
            {
                this.BaseSnapshotId = new System.String("FETCH");
            }
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? DbId
            // GraphQL -> dbId: String! (scalar)
            if (this.DbId == null && Exploration.Includes(parent + ".dbId$"))
            {
                this.DbId = new System.String("FETCH");
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: String! (scalar)
            if (this.Fid == null && Exploration.Includes(parent + ".fid$"))
            {
                this.Fid = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new DateTime();
            }
        }


    #endregion

    } // class Db2RecoverableRange
    #endregion

    public static class ListDb2RecoverableRangeExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<Db2RecoverableRange> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2RecoverableRange> list, 
            String parent = "")
        {
            var item = new Db2RecoverableRange();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// OracleDatabaseLastValidationStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:56.
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
    #region OracleDatabaseLastValidationStatus
    public class OracleDatabaseLastValidationStatus: IFragment
    {
        #region members
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        [JsonProperty("eventId")]
        public System.String? EventId { get; set; }

        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        [JsonProperty("isSuccess")]
        public System.Boolean? IsSuccess { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? TimestampMs
        // GraphQL -> timestampMs: DateTime (scalar)
        [JsonProperty("timestampMs")]
        public DateTime? TimestampMs { get; set; }

        #endregion

    #region methods

    public OracleDatabaseLastValidationStatus Set(
        System.String? EventId = null,
        System.Boolean? IsSuccess = null,
        System.String? SnapshotId = null,
        DateTime? TimestampMs = null
    ) 
    {
        if ( EventId != null ) {
            this.EventId = EventId;
        }
        if ( IsSuccess != null ) {
            this.IsSuccess = IsSuccess;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( TimestampMs != null ) {
            this.TimestampMs = TimestampMs;
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
            //      C# -> System.String? EventId
            // GraphQL -> eventId: String! (scalar)
            if (this.EventId != null)
            {
                 s += ind + "eventId\n";

            }
            //      C# -> System.Boolean? IsSuccess
            // GraphQL -> isSuccess: Boolean! (scalar)
            if (this.IsSuccess != null)
            {
                 s += ind + "isSuccess\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> DateTime? TimestampMs
            // GraphQL -> timestampMs: DateTime (scalar)
            if (this.TimestampMs != null)
            {
                 s += ind + "timestampMs\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EventId
            // GraphQL -> eventId: String! (scalar)
            if (this.EventId == null && Exploration.Includes(parent + ".eventId$"))
            {
                this.EventId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsSuccess
            // GraphQL -> isSuccess: Boolean! (scalar)
            if (this.IsSuccess == null && Exploration.Includes(parent + ".isSuccess$"))
            {
                this.IsSuccess = new System.Boolean();
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> DateTime? TimestampMs
            // GraphQL -> timestampMs: DateTime (scalar)
            if (this.TimestampMs == null && Exploration.Includes(parent + ".timestampMs$"))
            {
                this.TimestampMs = new DateTime();
            }
        }


    #endregion

    } // class OracleDatabaseLastValidationStatus
    #endregion

    public static class ListOracleDatabaseLastValidationStatusExtensions
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
            this List<OracleDatabaseLastValidationStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleDatabaseLastValidationStatus> list, 
            String parent = "")
        {
            var item = new OracleDatabaseLastValidationStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
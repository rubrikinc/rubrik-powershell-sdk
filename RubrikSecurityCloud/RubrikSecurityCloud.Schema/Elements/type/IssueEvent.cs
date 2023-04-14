// IssueEvent.cs
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
    #region IssueEvent
    public class IssueEvent: IFragment
    {
        #region members
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? Timestamp
        // GraphQL -> timestamp: Long! (scalar)
        [JsonProperty("timestamp")]
        public System.Int64? Timestamp { get; set; }

        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        [JsonProperty("violations")]
        public System.Int32? Violations { get; set; }

        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        [JsonProperty("violationsDelta")]
        public System.Int32? ViolationsDelta { get; set; }

        //      C# -> IssueEventType? Type
        // GraphQL -> type: IssueEventType! (enum)
        [JsonProperty("type")]
        public IssueEventType? Type { get; set; }

        #endregion

    #region methods

    public IssueEvent Set(
        System.String? SnapshotFid = null,
        System.Int64? Timestamp = null,
        System.Int32? Violations = null,
        System.Int32? ViolationsDelta = null,
        IssueEventType? Type = null
    ) 
    {
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( Violations != null ) {
            this.Violations = Violations;
        }
        if ( ViolationsDelta != null ) {
            this.ViolationsDelta = ViolationsDelta;
        }
        if ( Type != null ) {
            this.Type = Type;
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
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid != null)
            {
                 s += ind + "snapshotFid\n";

            }
            //      C# -> System.Int64? Timestamp
            // GraphQL -> timestamp: Long! (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            //      C# -> System.Int32? Violations
            // GraphQL -> violations: Int! (scalar)
            if (this.Violations != null)
            {
                 s += ind + "violations\n";

            }
            //      C# -> System.Int32? ViolationsDelta
            // GraphQL -> violationsDelta: Int! (scalar)
            if (this.ViolationsDelta != null)
            {
                 s += ind + "violationsDelta\n";

            }
            //      C# -> IssueEventType? Type
            // GraphQL -> type: IssueEventType! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid$"))
            {
                this.SnapshotFid = new System.String("FETCH");
            }
            //      C# -> System.Int64? Timestamp
            // GraphQL -> timestamp: Long! (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new System.Int64();
            }
            //      C# -> System.Int32? Violations
            // GraphQL -> violations: Int! (scalar)
            if (this.Violations == null && Exploration.Includes(parent + ".violations$"))
            {
                this.Violations = new System.Int32();
            }
            //      C# -> System.Int32? ViolationsDelta
            // GraphQL -> violationsDelta: Int! (scalar)
            if (this.ViolationsDelta == null && Exploration.Includes(parent + ".violationsDelta$"))
            {
                this.ViolationsDelta = new System.Int32();
            }
            //      C# -> IssueEventType? Type
            // GraphQL -> type: IssueEventType! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new IssueEventType();
            }
        }


    #endregion

    } // class IssueEvent
    #endregion

    public static class ListIssueEventExtensions
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
            this List<IssueEvent> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<IssueEvent> list, 
            String parent = "")
        {
            var item = new IssueEvent();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
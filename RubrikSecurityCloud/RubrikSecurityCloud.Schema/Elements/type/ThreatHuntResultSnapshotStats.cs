// ThreatHuntResultSnapshotStats.cs
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
    #region ThreatHuntResultSnapshotStats
    public class ThreatHuntResultSnapshotStats: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        [JsonProperty("isExpired")]
        public System.Boolean? IsExpired { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        [JsonProperty("totalMatchedPaths")]
        public System.Int64? TotalMatchedPaths { get; set; }

        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        [JsonProperty("matchTypes")]
        public List<IndicatorOfCompromise>? MatchTypes { get; set; }

        //      C# -> MalwareScanInSnapshotStatus? Status
        // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
        [JsonProperty("status")]
        public MalwareScanInSnapshotStatus? Status { get; set; }

        #endregion

    #region methods

    public ThreatHuntResultSnapshotStats Set(
        System.Boolean? IsExpired = null,
        System.Boolean? IsQuarantined = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotFid = null,
        System.Int64? TotalMatchedPaths = null,
        List<IndicatorOfCompromise>? MatchTypes = null,
        MalwareScanInSnapshotStatus? Status = null
    ) 
    {
        if ( IsExpired != null ) {
            this.IsExpired = IsExpired;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( TotalMatchedPaths != null ) {
            this.TotalMatchedPaths = TotalMatchedPaths;
        }
        if ( MatchTypes != null ) {
            this.MatchTypes = MatchTypes;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.Boolean? IsExpired
            // GraphQL -> isExpired: Boolean! (scalar)
            if (this.IsExpired != null)
            {
                 s += ind + "isExpired\n";

            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined != null)
            {
                 s += ind + "isQuarantined\n";

            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate != null)
            {
                 s += ind + "snapshotDate\n";

            }
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid != null)
            {
                 s += ind + "snapshotFid\n";

            }
            //      C# -> System.Int64? TotalMatchedPaths
            // GraphQL -> totalMatchedPaths: Long! (scalar)
            if (this.TotalMatchedPaths != null)
            {
                 s += ind + "totalMatchedPaths\n";

            }
            //      C# -> List<IndicatorOfCompromise>? MatchTypes
            // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
            if (this.MatchTypes != null)
            {
                 s += ind + "matchTypes\n";

                 s += ind + "{\n" + 
                 this.MatchTypes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MalwareScanInSnapshotStatus? Status
            // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsExpired
            // GraphQL -> isExpired: Boolean! (scalar)
            if (this.IsExpired == null && Exploration.Includes(parent + ".isExpired$"))
            {
                this.IsExpired = new System.Boolean();
            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined$"))
            {
                this.IsQuarantined = new System.Boolean();
            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate$"))
            {
                this.SnapshotDate = new DateTime();
            }
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid$"))
            {
                this.SnapshotFid = new System.String("FETCH");
            }
            //      C# -> System.Int64? TotalMatchedPaths
            // GraphQL -> totalMatchedPaths: Long! (scalar)
            if (this.TotalMatchedPaths == null && Exploration.Includes(parent + ".totalMatchedPaths$"))
            {
                this.TotalMatchedPaths = new System.Int64();
            }
            //      C# -> List<IndicatorOfCompromise>? MatchTypes
            // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
            if (this.MatchTypes == null && Exploration.Includes(parent + ".matchTypes"))
            {
                this.MatchTypes = new List<IndicatorOfCompromise>();
                this.MatchTypes.ApplyExploratoryFragment(parent + ".matchTypes");
            }
            //      C# -> MalwareScanInSnapshotStatus? Status
            // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new MalwareScanInSnapshotStatus();
            }
        }


    #endregion

    } // class ThreatHuntResultSnapshotStats
    #endregion

    public static class ListThreatHuntResultSnapshotStatsExtensions
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
            this List<ThreatHuntResultSnapshotStats> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatHuntResultSnapshotStats> list, 
            String parent = "")
        {
            var item = new ThreatHuntResultSnapshotStats();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
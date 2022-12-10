// ThreatHuntSummaryReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:40.
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
    #region ThreatHuntSummaryReply
    public class ThreatHuntSummaryReply: IFragment
    {
        #region members
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        [JsonProperty("huntId")]
        public System.String? HuntId { get; set; }

        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig (type)
        [JsonProperty("config")]
        public ThreatHuntConfig? Config { get; set; }

        //      C# -> List<ThreatHuntResultObjectsSummary>? ObjectsSummary
        // GraphQL -> objectsSummary: [ThreatHuntResultObjectsSummary!]! (type)
        [JsonProperty("objectsSummary")]
        public List<ThreatHuntResultObjectsSummary>? ObjectsSummary { get; set; }

        //      C# -> ThreatHuntStats? Stats
        // GraphQL -> stats: ThreatHuntStats (type)
        [JsonProperty("stats")]
        public ThreatHuntStats? Stats { get; set; }

        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        [JsonProperty("status")]
        public ThreatHuntStatus? Status { get; set; }

        #endregion

    #region methods

    public ThreatHuntSummaryReply Set(
        System.String? HuntId = null,
        ThreatHuntConfig? Config = null,
        List<ThreatHuntResultObjectsSummary>? ObjectsSummary = null,
        ThreatHuntStats? Stats = null,
        ThreatHuntStatus? Status = null
    ) 
    {
        if ( HuntId != null ) {
            this.HuntId = HuntId;
        }
        if ( Config != null ) {
            this.Config = Config;
        }
        if ( ObjectsSummary != null ) {
            this.ObjectsSummary = ObjectsSummary;
        }
        if ( Stats != null ) {
            this.Stats = Stats;
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
            //      C# -> System.String? HuntId
            // GraphQL -> huntId: String! (scalar)
            if (this.HuntId != null)
            {
                 s += ind + "huntId\n";

            }
            //      C# -> ThreatHuntConfig? Config
            // GraphQL -> config: ThreatHuntConfig (type)
            if (this.Config != null)
            {
                 s += ind + "config\n";

                 s += ind + "{\n" + 
                 this.Config.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ThreatHuntResultObjectsSummary>? ObjectsSummary
            // GraphQL -> objectsSummary: [ThreatHuntResultObjectsSummary!]! (type)
            if (this.ObjectsSummary != null)
            {
                 s += ind + "objectsSummary\n";

                 s += ind + "{\n" + 
                 this.ObjectsSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ThreatHuntStats? Stats
            // GraphQL -> stats: ThreatHuntStats (type)
            if (this.Stats != null)
            {
                 s += ind + "stats\n";

                 s += ind + "{\n" + 
                 this.Stats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ThreatHuntStatus? Status
            // GraphQL -> status: ThreatHuntStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HuntId
            // GraphQL -> huntId: String! (scalar)
            if (this.HuntId == null && Exploration.Includes(parent + ".huntId$"))
            {
                this.HuntId = new System.String("FETCH");
            }
            //      C# -> ThreatHuntConfig? Config
            // GraphQL -> config: ThreatHuntConfig (type)
            if (this.Config == null && Exploration.Includes(parent + ".config"))
            {
                this.Config = new ThreatHuntConfig();
                this.Config.ApplyExploratoryFragment(parent + ".config");
            }
            //      C# -> List<ThreatHuntResultObjectsSummary>? ObjectsSummary
            // GraphQL -> objectsSummary: [ThreatHuntResultObjectsSummary!]! (type)
            if (this.ObjectsSummary == null && Exploration.Includes(parent + ".objectsSummary"))
            {
                this.ObjectsSummary = new List<ThreatHuntResultObjectsSummary>();
                this.ObjectsSummary.ApplyExploratoryFragment(parent + ".objectsSummary");
            }
            //      C# -> ThreatHuntStats? Stats
            // GraphQL -> stats: ThreatHuntStats (type)
            if (this.Stats == null && Exploration.Includes(parent + ".stats"))
            {
                this.Stats = new ThreatHuntStats();
                this.Stats.ApplyExploratoryFragment(parent + ".stats");
            }
            //      C# -> ThreatHuntStatus? Status
            // GraphQL -> status: ThreatHuntStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new ThreatHuntStatus();
            }
        }


    #endregion

    } // class ThreatHuntSummaryReply
    #endregion

    public static class ListThreatHuntSummaryReplyExtensions
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
            this List<ThreatHuntSummaryReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatHuntSummaryReply> list, 
            String parent = "")
        {
            var item = new ThreatHuntSummaryReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
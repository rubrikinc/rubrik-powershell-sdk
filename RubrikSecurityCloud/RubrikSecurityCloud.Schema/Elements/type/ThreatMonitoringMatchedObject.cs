// ThreatMonitoringMatchedObject.cs
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
    #region ThreatMonitoringMatchedObject
    public class ThreatMonitoringMatchedObject: IFragment
    {
        #region members
        //      C# -> System.Int64? FilesMatched
        // GraphQL -> filesMatched: Long! (scalar)
        [JsonProperty("filesMatched")]
        public System.Int64? FilesMatched { get; set; }

        //      C# -> DateTime? LastDetection
        // GraphQL -> lastDetection: DateTime (scalar)
        [JsonProperty("lastDetection")]
        public DateTime? LastDetection { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        #endregion

    #region methods

    public ThreatMonitoringMatchedObject Set(
        System.Int64? FilesMatched = null,
        DateTime? LastDetection = null,
        System.String? ObjectName = null,
        Cluster? Cluster = null,
        IndicatorOfCompromiseKind? MatchType = null
    ) 
    {
        if ( FilesMatched != null ) {
            this.FilesMatched = FilesMatched;
        }
        if ( LastDetection != null ) {
            this.LastDetection = LastDetection;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( MatchType != null ) {
            this.MatchType = MatchType;
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
            //      C# -> System.Int64? FilesMatched
            // GraphQL -> filesMatched: Long! (scalar)
            if (this.FilesMatched != null)
            {
                 s += ind + "filesMatched\n";

            }
            //      C# -> DateTime? LastDetection
            // GraphQL -> lastDetection: DateTime (scalar)
            if (this.LastDetection != null)
            {
                 s += ind + "lastDetection\n";

            }
            //      C# -> System.String? ObjectName
            // GraphQL -> objectName: String! (scalar)
            if (this.ObjectName != null)
            {
                 s += ind + "objectName\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> IndicatorOfCompromiseKind? MatchType
            // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
            if (this.MatchType != null)
            {
                 s += ind + "matchType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? FilesMatched
            // GraphQL -> filesMatched: Long! (scalar)
            if (this.FilesMatched == null && Exploration.Includes(parent + ".filesMatched$"))
            {
                this.FilesMatched = new System.Int64();
            }
            //      C# -> DateTime? LastDetection
            // GraphQL -> lastDetection: DateTime (scalar)
            if (this.LastDetection == null && Exploration.Includes(parent + ".lastDetection$"))
            {
                this.LastDetection = new DateTime();
            }
            //      C# -> System.String? ObjectName
            // GraphQL -> objectName: String! (scalar)
            if (this.ObjectName == null && Exploration.Includes(parent + ".objectName$"))
            {
                this.ObjectName = new System.String("FETCH");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> IndicatorOfCompromiseKind? MatchType
            // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
            if (this.MatchType == null && Exploration.Includes(parent + ".matchType$"))
            {
                this.MatchType = new IndicatorOfCompromiseKind();
            }
        }


    #endregion

    } // class ThreatMonitoringMatchedObject
    #endregion

    public static class ListThreatMonitoringMatchedObjectExtensions
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
            this List<ThreatMonitoringMatchedObject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatMonitoringMatchedObject> list, 
            String parent = "")
        {
            var item = new ThreatMonitoringMatchedObject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
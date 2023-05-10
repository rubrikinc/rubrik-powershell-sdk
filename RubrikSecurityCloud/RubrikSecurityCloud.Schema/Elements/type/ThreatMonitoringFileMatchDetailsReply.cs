// ThreatMonitoringFileMatchDetailsReply.cs
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
    #region ThreatMonitoringFileMatchDetailsReply
    public class ThreatMonitoringFileMatchDetailsReply: IFragment
    {
        #region members
        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        [JsonProperty("detectedSnapshotDate")]
        public DateTime? DetectedSnapshotDate { get; set; }

        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        [JsonProperty("intelSource")]
        public System.String? IntelSource { get; set; }

        //      C# -> System.String? IocAttribute
        // GraphQL -> iocAttribute: String! (scalar)
        [JsonProperty("iocAttribute")]
        public System.String? IocAttribute { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        //      C# -> List<SnapshotData>? SnapshotList
        // GraphQL -> snapshotList: [SnapshotData!]! (type)
        [JsonProperty("snapshotList")]
        public List<SnapshotData>? SnapshotList { get; set; }

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        #endregion

    #region methods

    public ThreatMonitoringFileMatchDetailsReply Set(
        DateTime? DetectedSnapshotDate = null,
        System.String? IntelSource = null,
        System.String? IocAttribute = null,
        System.Boolean? IsQuarantined = null,
        List<SnapshotData>? SnapshotList = null,
        IndicatorOfCompromiseKind? MatchType = null
    ) 
    {
        if ( DetectedSnapshotDate != null ) {
            this.DetectedSnapshotDate = DetectedSnapshotDate;
        }
        if ( IntelSource != null ) {
            this.IntelSource = IntelSource;
        }
        if ( IocAttribute != null ) {
            this.IocAttribute = IocAttribute;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
        }
        if ( SnapshotList != null ) {
            this.SnapshotList = SnapshotList;
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
            //      C# -> DateTime? DetectedSnapshotDate
            // GraphQL -> detectedSnapshotDate: DateTime (scalar)
            if (this.DetectedSnapshotDate != null)
            {
                 s += ind + "detectedSnapshotDate\n";

            }
            //      C# -> System.String? IntelSource
            // GraphQL -> intelSource: String! (scalar)
            if (this.IntelSource != null)
            {
                 s += ind + "intelSource\n";

            }
            //      C# -> System.String? IocAttribute
            // GraphQL -> iocAttribute: String! (scalar)
            if (this.IocAttribute != null)
            {
                 s += ind + "iocAttribute\n";

            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined != null)
            {
                 s += ind + "isQuarantined\n";

            }
            //      C# -> List<SnapshotData>? SnapshotList
            // GraphQL -> snapshotList: [SnapshotData!]! (type)
            if (this.SnapshotList != null)
            {
                 s += ind + "snapshotList\n";

                 s += ind + "{\n" + 
                 this.SnapshotList.AsFragment(indent+1) + 
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
            //      C# -> DateTime? DetectedSnapshotDate
            // GraphQL -> detectedSnapshotDate: DateTime (scalar)
            if (this.DetectedSnapshotDate == null && Exploration.Includes(parent + ".detectedSnapshotDate$"))
            {
                this.DetectedSnapshotDate = new DateTime();
            }
            //      C# -> System.String? IntelSource
            // GraphQL -> intelSource: String! (scalar)
            if (this.IntelSource == null && Exploration.Includes(parent + ".intelSource$"))
            {
                this.IntelSource = new System.String("FETCH");
            }
            //      C# -> System.String? IocAttribute
            // GraphQL -> iocAttribute: String! (scalar)
            if (this.IocAttribute == null && Exploration.Includes(parent + ".iocAttribute$"))
            {
                this.IocAttribute = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined$"))
            {
                this.IsQuarantined = new System.Boolean();
            }
            //      C# -> List<SnapshotData>? SnapshotList
            // GraphQL -> snapshotList: [SnapshotData!]! (type)
            if (this.SnapshotList == null && Exploration.Includes(parent + ".snapshotList"))
            {
                this.SnapshotList = new List<SnapshotData>();
                this.SnapshotList.ApplyExploratoryFragment(parent + ".snapshotList");
            }
            //      C# -> IndicatorOfCompromiseKind? MatchType
            // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
            if (this.MatchType == null && Exploration.Includes(parent + ".matchType$"))
            {
                this.MatchType = new IndicatorOfCompromiseKind();
            }
        }


    #endregion

    } // class ThreatMonitoringFileMatchDetailsReply
    #endregion

    public static class ListThreatMonitoringFileMatchDetailsReplyExtensions
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
            this List<ThreatMonitoringFileMatchDetailsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatMonitoringFileMatchDetailsReply> list, 
            String parent = "")
        {
            var item = new ThreatMonitoringFileMatchDetailsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
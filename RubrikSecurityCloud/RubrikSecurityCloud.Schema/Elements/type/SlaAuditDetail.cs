// SlaAuditDetail.cs
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
    #region SlaAuditDetail
    public class SlaAuditDetail: IFragment
    {
        #region members
        //      C# -> System.Boolean? ApplyToExistingSnapshots
        // GraphQL -> applyToExistingSnapshots: Boolean! (scalar)
        [JsonProperty("applyToExistingSnapshots")]
        public System.Boolean? ApplyToExistingSnapshots { get; set; }

        //      C# -> System.Boolean? ApplyToOndemandAndDownloadedSnapshots
        // GraphQL -> applyToOndemandAndDownloadedSnapshots: Boolean (scalar)
        [JsonProperty("applyToOndemandAndDownloadedSnapshots")]
        public System.Boolean? ApplyToOndemandAndDownloadedSnapshots { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        //      C# -> System.String? UserAction
        // GraphQL -> userAction: String! (scalar)
        [JsonProperty("userAction")]
        public System.String? UserAction { get; set; }

        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        [JsonProperty("userName")]
        public System.String? UserName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> SlaDomain? CurrentSlaSummary
        // GraphQL -> currentSlaSummary: SlaDomain (interface)
        [JsonProperty("currentSlaSummary")]
        public SlaDomain? CurrentSlaSummary { get; set; }

        //      C# -> SlaDomain? PreviousSlaSummary
        // GraphQL -> previousSlaSummary: SlaDomain (interface)
        [JsonProperty("previousSlaSummary")]
        public SlaDomain? PreviousSlaSummary { get; set; }

        #endregion

    #region methods

    public SlaAuditDetail Set(
        System.Boolean? ApplyToExistingSnapshots = null,
        System.Boolean? ApplyToOndemandAndDownloadedSnapshots = null,
        DateTime? Timestamp = null,
        System.String? UserAction = null,
        System.String? UserName = null,
        Cluster? Cluster = null,
        SlaDomain? CurrentSlaSummary = null,
        SlaDomain? PreviousSlaSummary = null
    ) 
    {
        if ( ApplyToExistingSnapshots != null ) {
            this.ApplyToExistingSnapshots = ApplyToExistingSnapshots;
        }
        if ( ApplyToOndemandAndDownloadedSnapshots != null ) {
            this.ApplyToOndemandAndDownloadedSnapshots = ApplyToOndemandAndDownloadedSnapshots;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( UserAction != null ) {
            this.UserAction = UserAction;
        }
        if ( UserName != null ) {
            this.UserName = UserName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( CurrentSlaSummary != null ) {
            this.CurrentSlaSummary = CurrentSlaSummary;
        }
        if ( PreviousSlaSummary != null ) {
            this.PreviousSlaSummary = PreviousSlaSummary;
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
            //      C# -> System.Boolean? ApplyToExistingSnapshots
            // GraphQL -> applyToExistingSnapshots: Boolean! (scalar)
            if (this.ApplyToExistingSnapshots != null)
            {
                 s += ind + "applyToExistingSnapshots\n";

            }
            //      C# -> System.Boolean? ApplyToOndemandAndDownloadedSnapshots
            // GraphQL -> applyToOndemandAndDownloadedSnapshots: Boolean (scalar)
            if (this.ApplyToOndemandAndDownloadedSnapshots != null)
            {
                 s += ind + "applyToOndemandAndDownloadedSnapshots\n";

            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            //      C# -> System.String? UserAction
            // GraphQL -> userAction: String! (scalar)
            if (this.UserAction != null)
            {
                 s += ind + "userAction\n";

            }
            //      C# -> System.String? UserName
            // GraphQL -> userName: String! (scalar)
            if (this.UserName != null)
            {
                 s += ind + "userName\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
                        //      C# -> SlaDomain? CurrentSlaSummary
            // GraphQL -> currentSlaSummary: SlaDomain (interface)
            if (this.CurrentSlaSummary != null)
            {
                s += ind + "currentSlaSummary\n";
                s += ind + "{\n";

                string typename = this.CurrentSlaSummary.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.CurrentSlaSummary.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? PreviousSlaSummary
            // GraphQL -> previousSlaSummary: SlaDomain (interface)
            if (this.PreviousSlaSummary != null)
            {
                s += ind + "previousSlaSummary\n";
                s += ind + "{\n";

                string typename = this.PreviousSlaSummary.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.PreviousSlaSummary.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? ApplyToExistingSnapshots
            // GraphQL -> applyToExistingSnapshots: Boolean! (scalar)
            if (this.ApplyToExistingSnapshots == null && Exploration.Includes(parent + ".applyToExistingSnapshots$"))
            {
                this.ApplyToExistingSnapshots = new System.Boolean();
            }
            //      C# -> System.Boolean? ApplyToOndemandAndDownloadedSnapshots
            // GraphQL -> applyToOndemandAndDownloadedSnapshots: Boolean (scalar)
            if (this.ApplyToOndemandAndDownloadedSnapshots == null && Exploration.Includes(parent + ".applyToOndemandAndDownloadedSnapshots$"))
            {
                this.ApplyToOndemandAndDownloadedSnapshots = new System.Boolean();
            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new DateTime();
            }
            //      C# -> System.String? UserAction
            // GraphQL -> userAction: String! (scalar)
            if (this.UserAction == null && Exploration.Includes(parent + ".userAction$"))
            {
                this.UserAction = new System.String("FETCH");
            }
            //      C# -> System.String? UserName
            // GraphQL -> userName: String! (scalar)
            if (this.UserName == null && Exploration.Includes(parent + ".userName$"))
            {
                this.UserName = new System.String("FETCH");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> SlaDomain? CurrentSlaSummary
            // GraphQL -> currentSlaSummary: SlaDomain (interface)
            if (this.CurrentSlaSummary == null && Exploration.Includes(parent + ".currentSlaSummary"))
            {
                this.CurrentSlaSummary = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.CurrentSlaSummary.ApplyExploratoryFragment(parent + ".currentSlaSummary");
            }
            //      C# -> SlaDomain? PreviousSlaSummary
            // GraphQL -> previousSlaSummary: SlaDomain (interface)
            if (this.PreviousSlaSummary == null && Exploration.Includes(parent + ".previousSlaSummary"))
            {
                this.PreviousSlaSummary = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.PreviousSlaSummary.ApplyExploratoryFragment(parent + ".previousSlaSummary");
            }
        }


    #endregion

    } // class SlaAuditDetail
    #endregion

    public static class ListSlaAuditDetailExtensions
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
            this List<SlaAuditDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaAuditDetail> list, 
            String parent = "")
        {
            var item = new SlaAuditDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
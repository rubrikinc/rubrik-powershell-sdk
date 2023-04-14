// ClusterState.cs
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
    #region ClusterState
    public class ClusterState: IFragment
    {
        #region members
        //      C# -> DateTime? ClusterRemovalCreatedAt
        // GraphQL -> clusterRemovalCreatedAt: DateTime (scalar)
        [JsonProperty("clusterRemovalCreatedAt")]
        public DateTime? ClusterRemovalCreatedAt { get; set; }

        //      C# -> DateTime? ClusterRemovalUpdatedAt
        // GraphQL -> clusterRemovalUpdatedAt: DateTime (scalar)
        [JsonProperty("clusterRemovalUpdatedAt")]
        public DateTime? ClusterRemovalUpdatedAt { get; set; }

        //      C# -> ClusterRemovalState? ClusterRemovalState
        // GraphQL -> clusterRemovalState: ClusterRemovalState! (enum)
        [JsonProperty("clusterRemovalState")]
        public ClusterRemovalState? ClusterRemovalState { get; set; }

        //      C# -> ClusterStatus? ConnectedState
        // GraphQL -> connectedState: ClusterStatus! (enum)
        [JsonProperty("connectedState")]
        public ClusterStatus? ConnectedState { get; set; }

        #endregion

    #region methods

    public ClusterState Set(
        DateTime? ClusterRemovalCreatedAt = null,
        DateTime? ClusterRemovalUpdatedAt = null,
        ClusterRemovalState? ClusterRemovalState = null,
        ClusterStatus? ConnectedState = null
    ) 
    {
        if ( ClusterRemovalCreatedAt != null ) {
            this.ClusterRemovalCreatedAt = ClusterRemovalCreatedAt;
        }
        if ( ClusterRemovalUpdatedAt != null ) {
            this.ClusterRemovalUpdatedAt = ClusterRemovalUpdatedAt;
        }
        if ( ClusterRemovalState != null ) {
            this.ClusterRemovalState = ClusterRemovalState;
        }
        if ( ConnectedState != null ) {
            this.ConnectedState = ConnectedState;
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
            //      C# -> DateTime? ClusterRemovalCreatedAt
            // GraphQL -> clusterRemovalCreatedAt: DateTime (scalar)
            if (this.ClusterRemovalCreatedAt != null)
            {
                 s += ind + "clusterRemovalCreatedAt\n";

            }
            //      C# -> DateTime? ClusterRemovalUpdatedAt
            // GraphQL -> clusterRemovalUpdatedAt: DateTime (scalar)
            if (this.ClusterRemovalUpdatedAt != null)
            {
                 s += ind + "clusterRemovalUpdatedAt\n";

            }
            //      C# -> ClusterRemovalState? ClusterRemovalState
            // GraphQL -> clusterRemovalState: ClusterRemovalState! (enum)
            if (this.ClusterRemovalState != null)
            {
                 s += ind + "clusterRemovalState\n";

            }
            //      C# -> ClusterStatus? ConnectedState
            // GraphQL -> connectedState: ClusterStatus! (enum)
            if (this.ConnectedState != null)
            {
                 s += ind + "connectedState\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? ClusterRemovalCreatedAt
            // GraphQL -> clusterRemovalCreatedAt: DateTime (scalar)
            if (this.ClusterRemovalCreatedAt == null && Exploration.Includes(parent + ".clusterRemovalCreatedAt$"))
            {
                this.ClusterRemovalCreatedAt = new DateTime();
            }
            //      C# -> DateTime? ClusterRemovalUpdatedAt
            // GraphQL -> clusterRemovalUpdatedAt: DateTime (scalar)
            if (this.ClusterRemovalUpdatedAt == null && Exploration.Includes(parent + ".clusterRemovalUpdatedAt$"))
            {
                this.ClusterRemovalUpdatedAt = new DateTime();
            }
            //      C# -> ClusterRemovalState? ClusterRemovalState
            // GraphQL -> clusterRemovalState: ClusterRemovalState! (enum)
            if (this.ClusterRemovalState == null && Exploration.Includes(parent + ".clusterRemovalState$"))
            {
                this.ClusterRemovalState = new ClusterRemovalState();
            }
            //      C# -> ClusterStatus? ConnectedState
            // GraphQL -> connectedState: ClusterStatus! (enum)
            if (this.ConnectedState == null && Exploration.Includes(parent + ".connectedState$"))
            {
                this.ConnectedState = new ClusterStatus();
            }
        }


    #endregion

    } // class ClusterState
    #endregion

    public static class ListClusterStateExtensions
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
            this List<ClusterState> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterState> list, 
            String parent = "")
        {
            var item = new ClusterState();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
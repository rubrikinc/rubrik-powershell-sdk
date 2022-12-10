// GlobalSlaSyncStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:13.
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
    #region GlobalSlaSyncStatus
    public class GlobalSlaSyncStatus: IFragment
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> SlaSyncStatus? SlaSyncStatus
        // GraphQL -> slaSyncStatus: SlaSyncStatus! (enum)
        [JsonProperty("slaSyncStatus")]
        public SlaSyncStatus? SlaSyncStatus { get; set; }

        #endregion

    #region methods

    public GlobalSlaSyncStatus Set(
        System.String? ClusterUuid = null,
        SlaSyncStatus? SlaSyncStatus = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( SlaSyncStatus != null ) {
            this.SlaSyncStatus = SlaSyncStatus;
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
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> SlaSyncStatus? SlaSyncStatus
            // GraphQL -> slaSyncStatus: SlaSyncStatus! (enum)
            if (this.SlaSyncStatus != null)
            {
                 s += ind + "slaSyncStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> SlaSyncStatus? SlaSyncStatus
            // GraphQL -> slaSyncStatus: SlaSyncStatus! (enum)
            if (this.SlaSyncStatus == null && Exploration.Includes(parent + ".slaSyncStatus$"))
            {
                this.SlaSyncStatus = new SlaSyncStatus();
            }
        }


    #endregion

    } // class GlobalSlaSyncStatus
    #endregion

    public static class ListGlobalSlaSyncStatusExtensions
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
            this List<GlobalSlaSyncStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GlobalSlaSyncStatus> list, 
            String parent = "")
        {
            var item = new GlobalSlaSyncStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
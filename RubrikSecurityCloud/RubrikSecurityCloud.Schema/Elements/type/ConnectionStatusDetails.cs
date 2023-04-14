// ConnectionStatusDetails.cs
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
    #region ConnectionStatusDetails
    public class ConnectionStatusDetails: IFragment
    {
        #region members
        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        [JsonProperty("sourceAndRubrik")]
        public ClusterConnectionStatus? SourceAndRubrik { get; set; }

        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        [JsonProperty("sourceAndTarget")]
        public ConnectionStatusType? SourceAndTarget { get; set; }

        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        [JsonProperty("targetAndRubrik")]
        public ClusterConnectionStatus? TargetAndRubrik { get; set; }

        #endregion

    #region methods

    public ConnectionStatusDetails Set(
        ClusterConnectionStatus? SourceAndRubrik = null,
        ConnectionStatusType? SourceAndTarget = null,
        ClusterConnectionStatus? TargetAndRubrik = null
    ) 
    {
        if ( SourceAndRubrik != null ) {
            this.SourceAndRubrik = SourceAndRubrik;
        }
        if ( SourceAndTarget != null ) {
            this.SourceAndTarget = SourceAndTarget;
        }
        if ( TargetAndRubrik != null ) {
            this.TargetAndRubrik = TargetAndRubrik;
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
            //      C# -> ClusterConnectionStatus? SourceAndRubrik
            // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
            if (this.SourceAndRubrik != null)
            {
                 s += ind + "sourceAndRubrik\n";

            }
            //      C# -> ConnectionStatusType? SourceAndTarget
            // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
            if (this.SourceAndTarget != null)
            {
                 s += ind + "sourceAndTarget\n";

            }
            //      C# -> ClusterConnectionStatus? TargetAndRubrik
            // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
            if (this.TargetAndRubrik != null)
            {
                 s += ind + "targetAndRubrik\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> ClusterConnectionStatus? SourceAndRubrik
            // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
            if (this.SourceAndRubrik == null && Exploration.Includes(parent + ".sourceAndRubrik$"))
            {
                this.SourceAndRubrik = new ClusterConnectionStatus();
            }
            //      C# -> ConnectionStatusType? SourceAndTarget
            // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
            if (this.SourceAndTarget == null && Exploration.Includes(parent + ".sourceAndTarget$"))
            {
                this.SourceAndTarget = new ConnectionStatusType();
            }
            //      C# -> ClusterConnectionStatus? TargetAndRubrik
            // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
            if (this.TargetAndRubrik == null && Exploration.Includes(parent + ".targetAndRubrik$"))
            {
                this.TargetAndRubrik = new ClusterConnectionStatus();
            }
        }


    #endregion

    } // class ConnectionStatusDetails
    #endregion

    public static class ListConnectionStatusDetailsExtensions
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
            this List<ConnectionStatusDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ConnectionStatusDetails> list, 
            String parent = "")
        {
            var item = new ConnectionStatusDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
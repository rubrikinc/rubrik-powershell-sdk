// ClusterHealthAggregation.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:21.
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
    #region ClusterHealthAggregation
    public class ClusterHealthAggregation: IFragment
    {
        #region members
        //      C# -> System.Int64? Fatal
        // GraphQL -> fatal: Long! (scalar)
        [JsonProperty("fatal")]
        public System.Int64? Fatal { get; set; }

        //      C# -> System.Int64? Ok
        // GraphQL -> ok: Long! (scalar)
        [JsonProperty("ok")]
        public System.Int64? Ok { get; set; }

        //      C# -> System.Int64? Warning
        // GraphQL -> warning: Long! (scalar)
        [JsonProperty("warning")]
        public System.Int64? Warning { get; set; }

        #endregion

    #region methods

    public ClusterHealthAggregation Set(
        System.Int64? Fatal = null,
        System.Int64? Ok = null,
        System.Int64? Warning = null
    ) 
    {
        if ( Fatal != null ) {
            this.Fatal = Fatal;
        }
        if ( Ok != null ) {
            this.Ok = Ok;
        }
        if ( Warning != null ) {
            this.Warning = Warning;
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
            //      C# -> System.Int64? Fatal
            // GraphQL -> fatal: Long! (scalar)
            if (this.Fatal != null)
            {
                 s += ind + "fatal\n";

            }
            //      C# -> System.Int64? Ok
            // GraphQL -> ok: Long! (scalar)
            if (this.Ok != null)
            {
                 s += ind + "ok\n";

            }
            //      C# -> System.Int64? Warning
            // GraphQL -> warning: Long! (scalar)
            if (this.Warning != null)
            {
                 s += ind + "warning\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? Fatal
            // GraphQL -> fatal: Long! (scalar)
            if (this.Fatal == null && Exploration.Includes(parent + ".fatal$"))
            {
                this.Fatal = new System.Int64();
            }
            //      C# -> System.Int64? Ok
            // GraphQL -> ok: Long! (scalar)
            if (this.Ok == null && Exploration.Includes(parent + ".ok$"))
            {
                this.Ok = new System.Int64();
            }
            //      C# -> System.Int64? Warning
            // GraphQL -> warning: Long! (scalar)
            if (this.Warning == null && Exploration.Includes(parent + ".warning$"))
            {
                this.Warning = new System.Int64();
            }
        }


    #endregion

    } // class ClusterHealthAggregation
    #endregion

    public static class ListClusterHealthAggregationExtensions
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
            this List<ClusterHealthAggregation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterHealthAggregation> list, 
            String parent = "")
        {
            var item = new ClusterHealthAggregation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
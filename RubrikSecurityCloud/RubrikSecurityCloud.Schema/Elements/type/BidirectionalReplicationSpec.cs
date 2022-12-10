// BidirectionalReplicationSpec.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    #region BidirectionalReplicationSpec
    public class BidirectionalReplicationSpec: IFragment
    {
        #region members
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
        // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
        [JsonProperty("replicationSpec1")]
        public UnidirectionalReplicationSpec? ReplicationSpec1 { get; set; }

        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
        // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
        [JsonProperty("replicationSpec2")]
        public UnidirectionalReplicationSpec? ReplicationSpec2 { get; set; }

        #endregion

    #region methods

    public BidirectionalReplicationSpec Set(
        UnidirectionalReplicationSpec? ReplicationSpec1 = null,
        UnidirectionalReplicationSpec? ReplicationSpec2 = null
    ) 
    {
        if ( ReplicationSpec1 != null ) {
            this.ReplicationSpec1 = ReplicationSpec1;
        }
        if ( ReplicationSpec2 != null ) {
            this.ReplicationSpec2 = ReplicationSpec2;
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
            //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
            // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
            if (this.ReplicationSpec1 != null)
            {
                 s += ind + "replicationSpec1\n";

                 s += ind + "{\n" + 
                 this.ReplicationSpec1.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
            // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
            if (this.ReplicationSpec2 != null)
            {
                 s += ind + "replicationSpec2\n";

                 s += ind + "{\n" + 
                 this.ReplicationSpec2.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
            // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
            if (this.ReplicationSpec1 == null && Exploration.Includes(parent + ".replicationSpec1"))
            {
                this.ReplicationSpec1 = new UnidirectionalReplicationSpec();
                this.ReplicationSpec1.ApplyExploratoryFragment(parent + ".replicationSpec1");
            }
            //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
            // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
            if (this.ReplicationSpec2 == null && Exploration.Includes(parent + ".replicationSpec2"))
            {
                this.ReplicationSpec2 = new UnidirectionalReplicationSpec();
                this.ReplicationSpec2.ApplyExploratoryFragment(parent + ".replicationSpec2");
            }
        }


    #endregion

    } // class BidirectionalReplicationSpec
    #endregion

    public static class ListBidirectionalReplicationSpecExtensions
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
            this List<BidirectionalReplicationSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BidirectionalReplicationSpec> list, 
            String parent = "")
        {
            var item = new BidirectionalReplicationSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
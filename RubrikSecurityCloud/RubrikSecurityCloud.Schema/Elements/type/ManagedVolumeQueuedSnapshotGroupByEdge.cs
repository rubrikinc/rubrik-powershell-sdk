// ManagedVolumeQueuedSnapshotGroupByEdge.cs
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
    #region ManagedVolumeQueuedSnapshotGroupByEdge
    public class ManagedVolumeQueuedSnapshotGroupByEdge: IFragment
    {
        #region members
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotGroupBy? Node
        // GraphQL -> node: ManagedVolumeQueuedSnapshotGroupBy! (type)
        [JsonProperty("node")]
        public ManagedVolumeQueuedSnapshotGroupBy? Node { get; set; }

        #endregion

    #region methods

    public ManagedVolumeQueuedSnapshotGroupByEdge Set(
        System.String? Cursor = null,
        ManagedVolumeQueuedSnapshotGroupBy? Node = null
    ) 
    {
        if ( Cursor != null ) {
            this.Cursor = Cursor;
        }
        if ( Node != null ) {
            this.Node = Node;
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
            //      C# -> System.String? Cursor
            // GraphQL -> cursor: String! (scalar)
            if (this.Cursor != null)
            {
                 s += ind + "cursor\n";

            }
            //      C# -> ManagedVolumeQueuedSnapshotGroupBy? Node
            // GraphQL -> node: ManagedVolumeQueuedSnapshotGroupBy! (type)
            if (this.Node != null)
            {
                 s += ind + "node\n";

                 s += ind + "{\n" + 
                 this.Node.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Cursor
            // GraphQL -> cursor: String! (scalar)
            if (this.Cursor == null && Exploration.Includes(parent + ".cursor$"))
            {
                this.Cursor = new System.String("FETCH");
            }
            //      C# -> ManagedVolumeQueuedSnapshotGroupBy? Node
            // GraphQL -> node: ManagedVolumeQueuedSnapshotGroupBy! (type)
            if (this.Node == null && Exploration.Includes(parent + ".node"))
            {
                this.Node = new ManagedVolumeQueuedSnapshotGroupBy();
                this.Node.ApplyExploratoryFragment(parent + ".node");
            }
        }


    #endregion

    } // class ManagedVolumeQueuedSnapshotGroupByEdge
    #endregion

    public static class ListManagedVolumeQueuedSnapshotGroupByEdgeExtensions
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
            this List<ManagedVolumeQueuedSnapshotGroupByEdge> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeQueuedSnapshotGroupByEdge> list, 
            String parent = "")
        {
            var item = new ManagedVolumeQueuedSnapshotGroupByEdge();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
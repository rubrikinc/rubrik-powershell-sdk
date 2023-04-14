// ManagedVolumeSnapshotSummary.cs
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
    #region ManagedVolumeSnapshotSummary
    public class ManagedVolumeSnapshotSummary: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsQueuedSnapshot
        // GraphQL -> isQueuedSnapshot: Boolean (scalar)
        [JsonProperty("isQueuedSnapshot")]
        public System.Boolean? IsQueuedSnapshot { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }

        //      C# -> ManagedVolumeSnapshotLinks? Links
        // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
        [JsonProperty("links")]
        public ManagedVolumeSnapshotLinks? Links { get; set; }

        #endregion

    #region methods

    public ManagedVolumeSnapshotSummary Set(
        System.Boolean? IsQueuedSnapshot = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null,
        ManagedVolumeSnapshotLinks? Links = null
    ) 
    {
        if ( IsQueuedSnapshot != null ) {
            this.IsQueuedSnapshot = IsQueuedSnapshot;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
        }
        if ( Links != null ) {
            this.Links = Links;
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
            //      C# -> System.Boolean? IsQueuedSnapshot
            // GraphQL -> isQueuedSnapshot: Boolean (scalar)
            if (this.IsQueuedSnapshot != null)
            {
                 s += ind + "isQueuedSnapshot\n";

            }
            //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
            // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
            if (this.BaseSnapshotSummary != null)
            {
                 s += ind + "baseSnapshotSummary\n";

                 s += ind + "{\n" + 
                 this.BaseSnapshotSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeSnapshotLinks? Links
            // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
            if (this.Links != null)
            {
                 s += ind + "links\n";

                 s += ind + "{\n" + 
                 this.Links.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsQueuedSnapshot
            // GraphQL -> isQueuedSnapshot: Boolean (scalar)
            if (this.IsQueuedSnapshot == null && Exploration.Includes(parent + ".isQueuedSnapshot$"))
            {
                this.IsQueuedSnapshot = new System.Boolean();
            }
            //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
            // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
            if (this.BaseSnapshotSummary == null && Exploration.Includes(parent + ".baseSnapshotSummary"))
            {
                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFragment(parent + ".baseSnapshotSummary");
            }
            //      C# -> ManagedVolumeSnapshotLinks? Links
            // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
            if (this.Links == null && Exploration.Includes(parent + ".links"))
            {
                this.Links = new ManagedVolumeSnapshotLinks();
                this.Links.ApplyExploratoryFragment(parent + ".links");
            }
        }


    #endregion

    } // class ManagedVolumeSnapshotSummary
    #endregion

    public static class ListManagedVolumeSnapshotSummaryExtensions
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
            this List<ManagedVolumeSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeSnapshotSummary> list, 
            String parent = "")
        {
            var item = new ManagedVolumeSnapshotSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
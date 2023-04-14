// ManagedVolumeSnapshotLinks.cs
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
    #region ManagedVolumeSnapshotLinks
    public class ManagedVolumeSnapshotLinks: IFragment
    {
        #region members
        //      C# -> Link? ExportLink
        // GraphQL -> exportLink: Link (type)
        [JsonProperty("exportLink")]
        public Link? ExportLink { get; set; }

        //      C# -> Link? Self
        // GraphQL -> self: Link (type)
        [JsonProperty("self")]
        public Link? Self { get; set; }

        #endregion

    #region methods

    public ManagedVolumeSnapshotLinks Set(
        Link? ExportLink = null,
        Link? Self = null
    ) 
    {
        if ( ExportLink != null ) {
            this.ExportLink = ExportLink;
        }
        if ( Self != null ) {
            this.Self = Self;
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
            //      C# -> Link? ExportLink
            // GraphQL -> exportLink: Link (type)
            if (this.ExportLink != null)
            {
                 s += ind + "exportLink\n";

                 s += ind + "{\n" + 
                 this.ExportLink.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Link? Self
            // GraphQL -> self: Link (type)
            if (this.Self != null)
            {
                 s += ind + "self\n";

                 s += ind + "{\n" + 
                 this.Self.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> Link? ExportLink
            // GraphQL -> exportLink: Link (type)
            if (this.ExportLink == null && Exploration.Includes(parent + ".exportLink"))
            {
                this.ExportLink = new Link();
                this.ExportLink.ApplyExploratoryFragment(parent + ".exportLink");
            }
            //      C# -> Link? Self
            // GraphQL -> self: Link (type)
            if (this.Self == null && Exploration.Includes(parent + ".self"))
            {
                this.Self = new Link();
                this.Self.ApplyExploratoryFragment(parent + ".self");
            }
        }


    #endregion

    } // class ManagedVolumeSnapshotLinks
    #endregion

    public static class ListManagedVolumeSnapshotLinksExtensions
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
            this List<ManagedVolumeSnapshotLinks> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeSnapshotLinks> list, 
            String parent = "")
        {
            var item = new ManagedVolumeSnapshotLinks();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
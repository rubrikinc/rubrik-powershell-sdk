// ListStoredDiskLocationsReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:34.
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
    #region ListStoredDiskLocationsReply
    public class ListStoredDiskLocationsReply: IFragment
    {
        #region members
        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        [JsonProperty("regions")]
        public List<System.String>? Regions { get; set; }

        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        [JsonProperty("zones")]
        public List<System.String>? Zones { get; set; }

        #endregion

    #region methods

    public ListStoredDiskLocationsReply Set(
        List<System.String>? Regions = null,
        List<System.String>? Zones = null
    ) 
    {
        if ( Regions != null ) {
            this.Regions = Regions;
        }
        if ( Zones != null ) {
            this.Zones = Zones;
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
            //      C# -> List<System.String>? Regions
            // GraphQL -> regions: [String!]! (scalar)
            if (this.Regions != null)
            {
                 s += ind + "regions\n";

            }
            //      C# -> List<System.String>? Zones
            // GraphQL -> zones: [String!]! (scalar)
            if (this.Zones != null)
            {
                 s += ind + "zones\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? Regions
            // GraphQL -> regions: [String!]! (scalar)
            if (this.Regions == null && Exploration.Includes(parent + ".regions$"))
            {
                this.Regions = new List<System.String>();
            }
            //      C# -> List<System.String>? Zones
            // GraphQL -> zones: [String!]! (scalar)
            if (this.Zones == null && Exploration.Includes(parent + ".zones$"))
            {
                this.Zones = new List<System.String>();
            }
        }


    #endregion

    } // class ListStoredDiskLocationsReply
    #endregion

    public static class ListListStoredDiskLocationsReplyExtensions
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
            this List<ListStoredDiskLocationsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ListStoredDiskLocationsReply> list, 
            String parent = "")
        {
            var item = new ListStoredDiskLocationsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
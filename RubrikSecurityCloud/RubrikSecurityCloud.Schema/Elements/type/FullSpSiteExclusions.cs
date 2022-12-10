// FullSpSiteExclusions.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:51.
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
    #region FullSpSiteExclusions
    public class FullSpSiteExclusions: IFragment
    {
        #region members
        //      C# -> System.String? SiteFid
        // GraphQL -> siteFid: String! (scalar)
        [JsonProperty("siteFid")]
        public System.String? SiteFid { get; set; }

        //      C# -> List<FullSpObjectExclusion>? ExcludedObjects
        // GraphQL -> excludedObjects: [FullSpObjectExclusion!]! (type)
        [JsonProperty("excludedObjects")]
        public List<FullSpObjectExclusion>? ExcludedObjects { get; set; }

        #endregion

    #region methods

    public FullSpSiteExclusions Set(
        System.String? SiteFid = null,
        List<FullSpObjectExclusion>? ExcludedObjects = null
    ) 
    {
        if ( SiteFid != null ) {
            this.SiteFid = SiteFid;
        }
        if ( ExcludedObjects != null ) {
            this.ExcludedObjects = ExcludedObjects;
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
            //      C# -> System.String? SiteFid
            // GraphQL -> siteFid: String! (scalar)
            if (this.SiteFid != null)
            {
                 s += ind + "siteFid\n";

            }
            //      C# -> List<FullSpObjectExclusion>? ExcludedObjects
            // GraphQL -> excludedObjects: [FullSpObjectExclusion!]! (type)
            if (this.ExcludedObjects != null)
            {
                 s += ind + "excludedObjects\n";

                 s += ind + "{\n" + 
                 this.ExcludedObjects.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SiteFid
            // GraphQL -> siteFid: String! (scalar)
            if (this.SiteFid == null && Exploration.Includes(parent + ".siteFid$"))
            {
                this.SiteFid = new System.String("FETCH");
            }
            //      C# -> List<FullSpObjectExclusion>? ExcludedObjects
            // GraphQL -> excludedObjects: [FullSpObjectExclusion!]! (type)
            if (this.ExcludedObjects == null && Exploration.Includes(parent + ".excludedObjects"))
            {
                this.ExcludedObjects = new List<FullSpObjectExclusion>();
                this.ExcludedObjects.ApplyExploratoryFragment(parent + ".excludedObjects");
            }
        }


    #endregion

    } // class FullSpSiteExclusions
    #endregion

    public static class ListFullSpSiteExclusionsExtensions
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
            this List<FullSpSiteExclusions> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FullSpSiteExclusions> list, 
            String parent = "")
        {
            var item = new FullSpSiteExclusions();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
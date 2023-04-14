// O365SharepointObject.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region O365SharepointObject
    public interface O365SharepointObject: IFragment
    {
        #region members
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        System.String? ObjectId { get; set; }

        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String! (scalar)
        [JsonProperty("parentId")]
        System.String? ParentId { get; set; }

        //      C# -> System.String? SiteChildId
        // GraphQL -> siteChildId: String! (scalar)
        [JsonProperty("siteChildId")]
        System.String? SiteChildId { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        System.String? Title { get; set; }

        //      C# -> System.String? PreferredDataLocation
        // GraphQL -> preferredDataLocation: String! (scalar)
        [JsonProperty("preferredDataLocation")]
        System.String? PreferredDataLocation { get; set; }

        #endregion

    } // class O365SharepointObject
    #endregion

    public static class ListO365SharepointObjectExtensions
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
            this List<O365SharepointObject> list,
            int indent=0)
        {
            string fragments = "";
            foreach (O365SharepointObject item in list) 
            {
                string typename = item.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);

                fragments += String.Format("... on {0}\n", typename);

                fragments += "{\n" +
                item.AsFragment(indent+1) +
                "}\n";
            }
            return fragments;
        }

        public static void ApplyExploratoryFragment(
            this List<O365SharepointObject> list, 
            String parent = "")
        {
            var item = (O365SharepointObject)InterfaceHelper.CreateInstanceOfFirstType(typeof(O365SharepointObject));
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
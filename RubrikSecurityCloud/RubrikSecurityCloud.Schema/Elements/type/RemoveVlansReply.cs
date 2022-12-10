// RemoveVlansReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:17.
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
    #region RemoveVlansReply
    public class RemoveVlansReply: IFragment
    {
        #region members
        //      C# -> List<System.Int32>? FailureVlanIds
        // GraphQL -> failureVlanIds: [Int!]! (scalar)
        [JsonProperty("failureVlanIds")]
        public List<System.Int32>? FailureVlanIds { get; set; }

        //      C# -> List<System.Int32>? SuccessVlanIds
        // GraphQL -> successVlanIds: [Int!]! (scalar)
        [JsonProperty("successVlanIds")]
        public List<System.Int32>? SuccessVlanIds { get; set; }

        #endregion

    #region methods

    public RemoveVlansReply Set(
        List<System.Int32>? FailureVlanIds = null,
        List<System.Int32>? SuccessVlanIds = null
    ) 
    {
        if ( FailureVlanIds != null ) {
            this.FailureVlanIds = FailureVlanIds;
        }
        if ( SuccessVlanIds != null ) {
            this.SuccessVlanIds = SuccessVlanIds;
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
            //      C# -> List<System.Int32>? FailureVlanIds
            // GraphQL -> failureVlanIds: [Int!]! (scalar)
            if (this.FailureVlanIds != null)
            {
                 s += ind + "failureVlanIds\n";

            }
            //      C# -> List<System.Int32>? SuccessVlanIds
            // GraphQL -> successVlanIds: [Int!]! (scalar)
            if (this.SuccessVlanIds != null)
            {
                 s += ind + "successVlanIds\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.Int32>? FailureVlanIds
            // GraphQL -> failureVlanIds: [Int!]! (scalar)
            if (this.FailureVlanIds == null && Exploration.Includes(parent + ".failureVlanIds$"))
            {
                this.FailureVlanIds = new List<System.Int32>();
            }
            //      C# -> List<System.Int32>? SuccessVlanIds
            // GraphQL -> successVlanIds: [Int!]! (scalar)
            if (this.SuccessVlanIds == null && Exploration.Includes(parent + ".successVlanIds$"))
            {
                this.SuccessVlanIds = new List<System.Int32>();
            }
        }


    #endregion

    } // class RemoveVlansReply
    #endregion

    public static class ListRemoveVlansReplyExtensions
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
            this List<RemoveVlansReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RemoveVlansReply> list, 
            String parent = "")
        {
            var item = new RemoveVlansReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
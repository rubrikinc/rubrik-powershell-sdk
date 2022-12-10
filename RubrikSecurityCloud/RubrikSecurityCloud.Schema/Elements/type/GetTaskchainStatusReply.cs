// GetTaskchainStatusReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:54.
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
    #region GetTaskchainStatusReply
    public class GetTaskchainStatusReply: IFragment
    {
        #region members
        //      C# -> Taskchain? Taskchain
        // GraphQL -> taskchain: Taskchain (type)
        [JsonProperty("taskchain")]
        public Taskchain? Taskchain { get; set; }

        #endregion

    #region methods

    public GetTaskchainStatusReply Set(
        Taskchain? Taskchain = null
    ) 
    {
        if ( Taskchain != null ) {
            this.Taskchain = Taskchain;
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
            //      C# -> Taskchain? Taskchain
            // GraphQL -> taskchain: Taskchain (type)
            if (this.Taskchain != null)
            {
                 s += ind + "taskchain\n";

                 s += ind + "{\n" + 
                 this.Taskchain.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> Taskchain? Taskchain
            // GraphQL -> taskchain: Taskchain (type)
            if (this.Taskchain == null && Exploration.Includes(parent + ".taskchain"))
            {
                this.Taskchain = new Taskchain();
                this.Taskchain.ApplyExploratoryFragment(parent + ".taskchain");
            }
        }


    #endregion

    } // class GetTaskchainStatusReply
    #endregion

    public static class ListGetTaskchainStatusReplyExtensions
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
            this List<GetTaskchainStatusReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetTaskchainStatusReply> list, 
            String parent = "")
        {
            var item = new GetTaskchainStatusReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
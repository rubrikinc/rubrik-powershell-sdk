// O365PdlGroup.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:31.
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
    #region O365PdlGroup
    public class O365PdlGroup: IFragment
    {
        #region members
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> O365PdlAndWorkloadPair? PdlAndWorkload
        // GraphQL -> pdlAndWorkload: O365PdlAndWorkloadPair! (type)
        [JsonProperty("pdlAndWorkload")]
        public O365PdlAndWorkloadPair? PdlAndWorkload { get; set; }

        #endregion

    #region methods

    public O365PdlGroup Set(
        System.String? GroupId = null,
        O365PdlAndWorkloadPair? PdlAndWorkload = null
    ) 
    {
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( PdlAndWorkload != null ) {
            this.PdlAndWorkload = PdlAndWorkload;
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
            //      C# -> System.String? GroupId
            // GraphQL -> groupId: UUID! (scalar)
            if (this.GroupId != null)
            {
                 s += ind + "groupId\n";

            }
            //      C# -> O365PdlAndWorkloadPair? PdlAndWorkload
            // GraphQL -> pdlAndWorkload: O365PdlAndWorkloadPair! (type)
            if (this.PdlAndWorkload != null)
            {
                 s += ind + "pdlAndWorkload\n";

                 s += ind + "{\n" + 
                 this.PdlAndWorkload.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? GroupId
            // GraphQL -> groupId: UUID! (scalar)
            if (this.GroupId == null && Exploration.Includes(parent + ".groupId$"))
            {
                this.GroupId = new System.String("FETCH");
            }
            //      C# -> O365PdlAndWorkloadPair? PdlAndWorkload
            // GraphQL -> pdlAndWorkload: O365PdlAndWorkloadPair! (type)
            if (this.PdlAndWorkload == null && Exploration.Includes(parent + ".pdlAndWorkload"))
            {
                this.PdlAndWorkload = new O365PdlAndWorkloadPair();
                this.PdlAndWorkload.ApplyExploratoryFragment(parent + ".pdlAndWorkload");
            }
        }


    #endregion

    } // class O365PdlGroup
    #endregion

    public static class ListO365PdlGroupExtensions
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
            this List<O365PdlGroup> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365PdlGroup> list, 
            String parent = "")
        {
            var item = new O365PdlGroup();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// GcpCloudAccountAddProjectsReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:22.
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
    #region GcpCloudAccountAddProjectsReply
    public class GcpCloudAccountAddProjectsReply: IFragment
    {
        #region members
        //      C# -> List<GcpCloudAccountAddProjectDetail>? Details
        // GraphQL -> details: [GcpCloudAccountAddProjectDetail!]! (type)
        [JsonProperty("details")]
        public List<GcpCloudAccountAddProjectDetail>? Details { get; set; }

        #endregion

    #region methods

    public GcpCloudAccountAddProjectsReply Set(
        List<GcpCloudAccountAddProjectDetail>? Details = null
    ) 
    {
        if ( Details != null ) {
            this.Details = Details;
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
            //      C# -> List<GcpCloudAccountAddProjectDetail>? Details
            // GraphQL -> details: [GcpCloudAccountAddProjectDetail!]! (type)
            if (this.Details != null)
            {
                 s += ind + "details\n";

                 s += ind + "{\n" + 
                 this.Details.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<GcpCloudAccountAddProjectDetail>? Details
            // GraphQL -> details: [GcpCloudAccountAddProjectDetail!]! (type)
            if (this.Details == null && Exploration.Includes(parent + ".details"))
            {
                this.Details = new List<GcpCloudAccountAddProjectDetail>();
                this.Details.ApplyExploratoryFragment(parent + ".details");
            }
        }


    #endregion

    } // class GcpCloudAccountAddProjectsReply
    #endregion

    public static class ListGcpCloudAccountAddProjectsReplyExtensions
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
            this List<GcpCloudAccountAddProjectsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpCloudAccountAddProjectsReply> list, 
            String parent = "")
        {
            var item = new GcpCloudAccountAddProjectsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
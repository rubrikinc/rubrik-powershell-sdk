// GcpCloudAccountUpgradeProjectsReply.cs
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
    #region GcpCloudAccountUpgradeProjectsReply
    public class GcpCloudAccountUpgradeProjectsReply: IFragment
    {
        #region members
        //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
        // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
        [JsonProperty("gcpProjectUpgradeStatuses")]
        public List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses { get; set; }

        #endregion

    #region methods

    public GcpCloudAccountUpgradeProjectsReply Set(
        List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses = null
    ) 
    {
        if ( GcpProjectUpgradeStatuses != null ) {
            this.GcpProjectUpgradeStatuses = GcpProjectUpgradeStatuses;
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
            //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
            // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
            if (this.GcpProjectUpgradeStatuses != null)
            {
                 s += ind + "gcpProjectUpgradeStatuses\n";

                 s += ind + "{\n" + 
                 this.GcpProjectUpgradeStatuses.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
            // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
            if (this.GcpProjectUpgradeStatuses == null && Exploration.Includes(parent + ".gcpProjectUpgradeStatuses"))
            {
                this.GcpProjectUpgradeStatuses = new List<GcpCloudAccountProjectUpgradeStatus>();
                this.GcpProjectUpgradeStatuses.ApplyExploratoryFragment(parent + ".gcpProjectUpgradeStatuses");
            }
        }


    #endregion

    } // class GcpCloudAccountUpgradeProjectsReply
    #endregion

    public static class ListGcpCloudAccountUpgradeProjectsReplyExtensions
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
            this List<GcpCloudAccountUpgradeProjectsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpCloudAccountUpgradeProjectsReply> list, 
            String parent = "")
        {
            var item = new GcpCloudAccountUpgradeProjectsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
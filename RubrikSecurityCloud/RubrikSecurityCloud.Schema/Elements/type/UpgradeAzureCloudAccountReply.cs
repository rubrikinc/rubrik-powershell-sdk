// UpgradeAzureCloudAccountReply.cs
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
    #region UpgradeAzureCloudAccountReply
    public class UpgradeAzureCloudAccountReply: IFragment
    {
        #region members
        //      C# -> List<UpgradeAzureCloudAccountStatus>? Status
        // GraphQL -> status: [UpgradeAzureCloudAccountStatus!]! (type)
        [JsonProperty("status")]
        public List<UpgradeAzureCloudAccountStatus>? Status { get; set; }

        #endregion

    #region methods

    public UpgradeAzureCloudAccountReply Set(
        List<UpgradeAzureCloudAccountStatus>? Status = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> List<UpgradeAzureCloudAccountStatus>? Status
            // GraphQL -> status: [UpgradeAzureCloudAccountStatus!]! (type)
            if (this.Status != null)
            {
                 s += ind + "status\n";

                 s += ind + "{\n" + 
                 this.Status.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<UpgradeAzureCloudAccountStatus>? Status
            // GraphQL -> status: [UpgradeAzureCloudAccountStatus!]! (type)
            if (this.Status == null && Exploration.Includes(parent + ".status"))
            {
                this.Status = new List<UpgradeAzureCloudAccountStatus>();
                this.Status.ApplyExploratoryFragment(parent + ".status");
            }
        }


    #endregion

    } // class UpgradeAzureCloudAccountReply
    #endregion

    public static class ListUpgradeAzureCloudAccountReplyExtensions
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
            this List<UpgradeAzureCloudAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpgradeAzureCloudAccountReply> list, 
            String parent = "")
        {
            var item = new UpgradeAzureCloudAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
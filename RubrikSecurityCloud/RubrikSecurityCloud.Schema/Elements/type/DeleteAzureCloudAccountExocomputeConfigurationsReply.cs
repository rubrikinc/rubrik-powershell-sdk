// DeleteAzureCloudAccountExocomputeConfigurationsReply.cs
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
    #region DeleteAzureCloudAccountExocomputeConfigurationsReply
    public class DeleteAzureCloudAccountExocomputeConfigurationsReply: IFragment
    {
        #region members
        //      C# -> List<System.String>? DeletionFailedIds
        // GraphQL -> deletionFailedIds: [String!]! (scalar)
        [JsonProperty("deletionFailedIds")]
        public List<System.String>? DeletionFailedIds { get; set; }

        //      C# -> List<System.String>? DeletionSuccessIds
        // GraphQL -> deletionSuccessIds: [String!]! (scalar)
        [JsonProperty("deletionSuccessIds")]
        public List<System.String>? DeletionSuccessIds { get; set; }

        #endregion

    #region methods

    public DeleteAzureCloudAccountExocomputeConfigurationsReply Set(
        List<System.String>? DeletionFailedIds = null,
        List<System.String>? DeletionSuccessIds = null
    ) 
    {
        if ( DeletionFailedIds != null ) {
            this.DeletionFailedIds = DeletionFailedIds;
        }
        if ( DeletionSuccessIds != null ) {
            this.DeletionSuccessIds = DeletionSuccessIds;
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
            //      C# -> List<System.String>? DeletionFailedIds
            // GraphQL -> deletionFailedIds: [String!]! (scalar)
            if (this.DeletionFailedIds != null)
            {
                 s += ind + "deletionFailedIds\n";

            }
            //      C# -> List<System.String>? DeletionSuccessIds
            // GraphQL -> deletionSuccessIds: [String!]! (scalar)
            if (this.DeletionSuccessIds != null)
            {
                 s += ind + "deletionSuccessIds\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? DeletionFailedIds
            // GraphQL -> deletionFailedIds: [String!]! (scalar)
            if (this.DeletionFailedIds == null && Exploration.Includes(parent + ".deletionFailedIds$"))
            {
                this.DeletionFailedIds = new List<System.String>();
            }
            //      C# -> List<System.String>? DeletionSuccessIds
            // GraphQL -> deletionSuccessIds: [String!]! (scalar)
            if (this.DeletionSuccessIds == null && Exploration.Includes(parent + ".deletionSuccessIds$"))
            {
                this.DeletionSuccessIds = new List<System.String>();
            }
        }


    #endregion

    } // class DeleteAzureCloudAccountExocomputeConfigurationsReply
    #endregion

    public static class ListDeleteAzureCloudAccountExocomputeConfigurationsReplyExtensions
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
            this List<DeleteAzureCloudAccountExocomputeConfigurationsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DeleteAzureCloudAccountExocomputeConfigurationsReply> list, 
            String parent = "")
        {
            var item = new DeleteAzureCloudAccountExocomputeConfigurationsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
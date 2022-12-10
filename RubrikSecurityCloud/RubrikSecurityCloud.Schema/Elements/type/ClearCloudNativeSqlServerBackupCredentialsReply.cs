// ClearCloudNativeSqlServerBackupCredentialsReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:16.
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
    #region ClearCloudNativeSqlServerBackupCredentialsReply
    public class ClearCloudNativeSqlServerBackupCredentialsReply: IFragment
    {
        #region members
        //      C# -> List<System.String>? FailedObjectIds
        // GraphQL -> failedObjectIds: [UUID!]! (scalar)
        [JsonProperty("failedObjectIds")]
        public List<System.String>? FailedObjectIds { get; set; }

        //      C# -> List<System.String>? SuccessObjectIds
        // GraphQL -> successObjectIds: [UUID!]! (scalar)
        [JsonProperty("successObjectIds")]
        public List<System.String>? SuccessObjectIds { get; set; }

        #endregion

    #region methods

    public ClearCloudNativeSqlServerBackupCredentialsReply Set(
        List<System.String>? FailedObjectIds = null,
        List<System.String>? SuccessObjectIds = null
    ) 
    {
        if ( FailedObjectIds != null ) {
            this.FailedObjectIds = FailedObjectIds;
        }
        if ( SuccessObjectIds != null ) {
            this.SuccessObjectIds = SuccessObjectIds;
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
            //      C# -> List<System.String>? FailedObjectIds
            // GraphQL -> failedObjectIds: [UUID!]! (scalar)
            if (this.FailedObjectIds != null)
            {
                 s += ind + "failedObjectIds\n";

            }
            //      C# -> List<System.String>? SuccessObjectIds
            // GraphQL -> successObjectIds: [UUID!]! (scalar)
            if (this.SuccessObjectIds != null)
            {
                 s += ind + "successObjectIds\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? FailedObjectIds
            // GraphQL -> failedObjectIds: [UUID!]! (scalar)
            if (this.FailedObjectIds == null && Exploration.Includes(parent + ".failedObjectIds$"))
            {
                this.FailedObjectIds = new List<System.String>();
            }
            //      C# -> List<System.String>? SuccessObjectIds
            // GraphQL -> successObjectIds: [UUID!]! (scalar)
            if (this.SuccessObjectIds == null && Exploration.Includes(parent + ".successObjectIds$"))
            {
                this.SuccessObjectIds = new List<System.String>();
            }
        }


    #endregion

    } // class ClearCloudNativeSqlServerBackupCredentialsReply
    #endregion

    public static class ListClearCloudNativeSqlServerBackupCredentialsReplyExtensions
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
            this List<ClearCloudNativeSqlServerBackupCredentialsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClearCloudNativeSqlServerBackupCredentialsReply> list, 
            String parent = "")
        {
            var item = new ClearCloudNativeSqlServerBackupCredentialsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
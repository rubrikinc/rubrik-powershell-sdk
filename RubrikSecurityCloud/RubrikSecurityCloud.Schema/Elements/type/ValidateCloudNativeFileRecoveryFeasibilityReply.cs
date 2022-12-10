// ValidateCloudNativeFileRecoveryFeasibilityReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:19.
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
    #region ValidateCloudNativeFileRecoveryFeasibilityReply
    public class ValidateCloudNativeFileRecoveryFeasibilityReply: IFragment
    {
        #region members
        //      C# -> List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility
        // GraphQL -> snapshotFileRecoveryFeasibility: [CloudNativeFileRecoveryFeasibility!]! (type)
        [JsonProperty("snapshotFileRecoveryFeasibility")]
        public List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility { get; set; }

        #endregion

    #region methods

    public ValidateCloudNativeFileRecoveryFeasibilityReply Set(
        List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility = null
    ) 
    {
        if ( SnapshotFileRecoveryFeasibility != null ) {
            this.SnapshotFileRecoveryFeasibility = SnapshotFileRecoveryFeasibility;
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
            //      C# -> List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility
            // GraphQL -> snapshotFileRecoveryFeasibility: [CloudNativeFileRecoveryFeasibility!]! (type)
            if (this.SnapshotFileRecoveryFeasibility != null)
            {
                 s += ind + "snapshotFileRecoveryFeasibility\n";

                 s += ind + "{\n" + 
                 this.SnapshotFileRecoveryFeasibility.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility
            // GraphQL -> snapshotFileRecoveryFeasibility: [CloudNativeFileRecoveryFeasibility!]! (type)
            if (this.SnapshotFileRecoveryFeasibility == null && Exploration.Includes(parent + ".snapshotFileRecoveryFeasibility"))
            {
                this.SnapshotFileRecoveryFeasibility = new List<CloudNativeFileRecoveryFeasibility>();
                this.SnapshotFileRecoveryFeasibility.ApplyExploratoryFragment(parent + ".snapshotFileRecoveryFeasibility");
            }
        }


    #endregion

    } // class ValidateCloudNativeFileRecoveryFeasibilityReply
    #endregion

    public static class ListValidateCloudNativeFileRecoveryFeasibilityReplyExtensions
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
            this List<ValidateCloudNativeFileRecoveryFeasibilityReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ValidateCloudNativeFileRecoveryFeasibilityReply> list, 
            String parent = "")
        {
            var item = new ValidateCloudNativeFileRecoveryFeasibilityReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
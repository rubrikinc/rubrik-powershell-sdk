// SlaManagedVolumeDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:29.
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
    #region SlaManagedVolumeDetail
    public class SlaManagedVolumeDetail: IFragment
    {
        #region members
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        [JsonProperty("channelHostMountPaths")]
        public List<System.String>? ChannelHostMountPaths { get; set; }

        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        [JsonProperty("shouldCancelBackupOnPreBackupScriptFailure")]
        public System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure { get; set; }

        //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
        // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
        [JsonProperty("backupScriptDetails")]
        public SlaManagedVolumeScriptSummary? BackupScriptDetails { get; set; }

        //      C# -> SlaManagedVolumeHostSummary? HostDetails
        // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
        [JsonProperty("hostDetails")]
        public SlaManagedVolumeHostSummary? HostDetails { get; set; }

        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
        // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
        [JsonProperty("postBackupScriptOnBackupFailureDetails")]
        public SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails { get; set; }

        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
        // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
        [JsonProperty("postBackupScriptOnBackupSuccessDetails")]
        public SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails { get; set; }

        //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
        // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
        [JsonProperty("preBackupScriptDetails")]
        public SlaManagedVolumeScriptSummary? PreBackupScriptDetails { get; set; }

        #endregion

    #region methods

    public SlaManagedVolumeDetail Set(
        List<System.String>? ChannelHostMountPaths = null,
        System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure = null,
        SlaManagedVolumeScriptSummary? BackupScriptDetails = null,
        SlaManagedVolumeHostSummary? HostDetails = null,
        SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails = null,
        SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails = null,
        SlaManagedVolumeScriptSummary? PreBackupScriptDetails = null
    ) 
    {
        if ( ChannelHostMountPaths != null ) {
            this.ChannelHostMountPaths = ChannelHostMountPaths;
        }
        if ( ShouldCancelBackupOnPreBackupScriptFailure != null ) {
            this.ShouldCancelBackupOnPreBackupScriptFailure = ShouldCancelBackupOnPreBackupScriptFailure;
        }
        if ( BackupScriptDetails != null ) {
            this.BackupScriptDetails = BackupScriptDetails;
        }
        if ( HostDetails != null ) {
            this.HostDetails = HostDetails;
        }
        if ( PostBackupScriptOnBackupFailureDetails != null ) {
            this.PostBackupScriptOnBackupFailureDetails = PostBackupScriptOnBackupFailureDetails;
        }
        if ( PostBackupScriptOnBackupSuccessDetails != null ) {
            this.PostBackupScriptOnBackupSuccessDetails = PostBackupScriptOnBackupSuccessDetails;
        }
        if ( PreBackupScriptDetails != null ) {
            this.PreBackupScriptDetails = PreBackupScriptDetails;
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
            //      C# -> List<System.String>? ChannelHostMountPaths
            // GraphQL -> channelHostMountPaths: [String!]! (scalar)
            if (this.ChannelHostMountPaths != null)
            {
                 s += ind + "channelHostMountPaths\n";

            }
            //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
            // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
            if (this.ShouldCancelBackupOnPreBackupScriptFailure != null)
            {
                 s += ind + "shouldCancelBackupOnPreBackupScriptFailure\n";

            }
            //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
            // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
            if (this.BackupScriptDetails != null)
            {
                 s += ind + "backupScriptDetails\n";

                 s += ind + "{\n" + 
                 this.BackupScriptDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaManagedVolumeHostSummary? HostDetails
            // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
            if (this.HostDetails != null)
            {
                 s += ind + "hostDetails\n";

                 s += ind + "{\n" + 
                 this.HostDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
            // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
            if (this.PostBackupScriptOnBackupFailureDetails != null)
            {
                 s += ind + "postBackupScriptOnBackupFailureDetails\n";

                 s += ind + "{\n" + 
                 this.PostBackupScriptOnBackupFailureDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
            // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
            if (this.PostBackupScriptOnBackupSuccessDetails != null)
            {
                 s += ind + "postBackupScriptOnBackupSuccessDetails\n";

                 s += ind + "{\n" + 
                 this.PostBackupScriptOnBackupSuccessDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
            // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
            if (this.PreBackupScriptDetails != null)
            {
                 s += ind + "preBackupScriptDetails\n";

                 s += ind + "{\n" + 
                 this.PreBackupScriptDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ChannelHostMountPaths
            // GraphQL -> channelHostMountPaths: [String!]! (scalar)
            if (this.ChannelHostMountPaths == null && Exploration.Includes(parent + ".channelHostMountPaths$"))
            {
                this.ChannelHostMountPaths = new List<System.String>();
            }
            //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
            // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
            if (this.ShouldCancelBackupOnPreBackupScriptFailure == null && Exploration.Includes(parent + ".shouldCancelBackupOnPreBackupScriptFailure$"))
            {
                this.ShouldCancelBackupOnPreBackupScriptFailure = new System.Boolean();
            }
            //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
            // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
            if (this.BackupScriptDetails == null && Exploration.Includes(parent + ".backupScriptDetails"))
            {
                this.BackupScriptDetails = new SlaManagedVolumeScriptSummary();
                this.BackupScriptDetails.ApplyExploratoryFragment(parent + ".backupScriptDetails");
            }
            //      C# -> SlaManagedVolumeHostSummary? HostDetails
            // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
            if (this.HostDetails == null && Exploration.Includes(parent + ".hostDetails"))
            {
                this.HostDetails = new SlaManagedVolumeHostSummary();
                this.HostDetails.ApplyExploratoryFragment(parent + ".hostDetails");
            }
            //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
            // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
            if (this.PostBackupScriptOnBackupFailureDetails == null && Exploration.Includes(parent + ".postBackupScriptOnBackupFailureDetails"))
            {
                this.PostBackupScriptOnBackupFailureDetails = new SlaManagedVolumeScriptSummary();
                this.PostBackupScriptOnBackupFailureDetails.ApplyExploratoryFragment(parent + ".postBackupScriptOnBackupFailureDetails");
            }
            //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
            // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
            if (this.PostBackupScriptOnBackupSuccessDetails == null && Exploration.Includes(parent + ".postBackupScriptOnBackupSuccessDetails"))
            {
                this.PostBackupScriptOnBackupSuccessDetails = new SlaManagedVolumeScriptSummary();
                this.PostBackupScriptOnBackupSuccessDetails.ApplyExploratoryFragment(parent + ".postBackupScriptOnBackupSuccessDetails");
            }
            //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
            // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
            if (this.PreBackupScriptDetails == null && Exploration.Includes(parent + ".preBackupScriptDetails"))
            {
                this.PreBackupScriptDetails = new SlaManagedVolumeScriptSummary();
                this.PreBackupScriptDetails.ApplyExploratoryFragment(parent + ".preBackupScriptDetails");
            }
        }


    #endregion

    } // class SlaManagedVolumeDetail
    #endregion

    public static class ListSlaManagedVolumeDetailExtensions
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
            this List<SlaManagedVolumeDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaManagedVolumeDetail> list, 
            String parent = "")
        {
            var item = new SlaManagedVolumeDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
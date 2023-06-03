// SlaManagedVolumeDetail.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SlaManagedVolumeDetail
    public class SlaManagedVolumeDetail: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        if (this.ChannelHostMountPaths != null) {
            s += ind + "channelHostMountPaths\n" ;
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure != null) {
            s += ind + "shouldCancelBackupOnPreBackupScriptFailure\n" ;
        }
        //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
        // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.BackupScriptDetails != null) {
            s += ind + "backupScriptDetails {\n" + this.BackupScriptDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaManagedVolumeHostSummary? HostDetails
        // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
        if (this.HostDetails != null) {
            s += ind + "hostDetails {\n" + this.HostDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
        // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupFailureDetails != null) {
            s += ind + "postBackupScriptOnBackupFailureDetails {\n" + this.PostBackupScriptOnBackupFailureDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
        // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupSuccessDetails != null) {
            s += ind + "postBackupScriptOnBackupSuccessDetails {\n" + this.PostBackupScriptOnBackupSuccessDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
        // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PreBackupScriptDetails != null) {
            s += ind + "preBackupScriptDetails {\n" + this.PreBackupScriptDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        if (this.ChannelHostMountPaths == null && Exploration.Includes(parent + ".channelHostMountPaths", true))
        {
            this.ChannelHostMountPaths = new List<System.String>();
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure == null && Exploration.Includes(parent + ".shouldCancelBackupOnPreBackupScriptFailure", true))
        {
            this.ShouldCancelBackupOnPreBackupScriptFailure = true;
        }
        //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
        // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.BackupScriptDetails == null && Exploration.Includes(parent + ".backupScriptDetails"))
        {
            this.BackupScriptDetails = new SlaManagedVolumeScriptSummary();
            this.BackupScriptDetails.ApplyExploratoryFieldSpec(parent + ".backupScriptDetails");
        }
        //      C# -> SlaManagedVolumeHostSummary? HostDetails
        // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
        if (this.HostDetails == null && Exploration.Includes(parent + ".hostDetails"))
        {
            this.HostDetails = new SlaManagedVolumeHostSummary();
            this.HostDetails.ApplyExploratoryFieldSpec(parent + ".hostDetails");
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
        // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupFailureDetails == null && Exploration.Includes(parent + ".postBackupScriptOnBackupFailureDetails"))
        {
            this.PostBackupScriptOnBackupFailureDetails = new SlaManagedVolumeScriptSummary();
            this.PostBackupScriptOnBackupFailureDetails.ApplyExploratoryFieldSpec(parent + ".postBackupScriptOnBackupFailureDetails");
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
        // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupSuccessDetails == null && Exploration.Includes(parent + ".postBackupScriptOnBackupSuccessDetails"))
        {
            this.PostBackupScriptOnBackupSuccessDetails = new SlaManagedVolumeScriptSummary();
            this.PostBackupScriptOnBackupSuccessDetails.ApplyExploratoryFieldSpec(parent + ".postBackupScriptOnBackupSuccessDetails");
        }
        //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
        // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PreBackupScriptDetails == null && Exploration.Includes(parent + ".preBackupScriptDetails"))
        {
            this.PreBackupScriptDetails = new SlaManagedVolumeScriptSummary();
            this.PreBackupScriptDetails.ApplyExploratoryFieldSpec(parent + ".preBackupScriptDetails");
        }
    }


    #endregion

    } // class SlaManagedVolumeDetail
    
    #endregion

    public static class ListSlaManagedVolumeDetailExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<SlaManagedVolumeDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaManagedVolumeDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaManagedVolumeDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
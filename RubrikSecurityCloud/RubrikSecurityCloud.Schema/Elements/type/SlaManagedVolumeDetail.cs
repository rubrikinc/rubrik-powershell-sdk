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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region SlaManagedVolumeDetail
    public class SlaManagedVolumeDetail: BaseType
    {
        #region members

        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        [JsonProperty("channelHostMountPaths")]
        public List<System.String>? ChannelHostMountPaths { get; set; }

        //      C# -> System.Boolean? IsLogExportEnabled
        // GraphQL -> isLogExportEnabled: Boolean (scalar)
        [JsonProperty("isLogExportEnabled")]
        public System.Boolean? IsLogExportEnabled { get; set; }

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

        //      C# -> SlaManagedVolumeLogExportSummary? LogExportSummary
        // GraphQL -> logExportSummary: SlaManagedVolumeLogExportSummary (type)
        [JsonProperty("logExportSummary")]
        public SlaManagedVolumeLogExportSummary? LogExportSummary { get; set; }

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

    public override string GetGqlTypeName() {
        return "SlaManagedVolumeDetail";
    }

    public SlaManagedVolumeDetail Set(
        List<System.String>? ChannelHostMountPaths = null,
        System.Boolean? IsLogExportEnabled = null,
        System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure = null,
        SlaManagedVolumeScriptSummary? BackupScriptDetails = null,
        SlaManagedVolumeHostSummary? HostDetails = null,
        SlaManagedVolumeLogExportSummary? LogExportSummary = null,
        SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails = null,
        SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails = null,
        SlaManagedVolumeScriptSummary? PreBackupScriptDetails = null
    ) 
    {
        if ( ChannelHostMountPaths != null ) {
            this.ChannelHostMountPaths = ChannelHostMountPaths;
        }
        if ( IsLogExportEnabled != null ) {
            this.IsLogExportEnabled = IsLogExportEnabled;
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
        if ( LogExportSummary != null ) {
            this.LogExportSummary = LogExportSummary;
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
        //      C# -> System.Boolean? IsLogExportEnabled
        // GraphQL -> isLogExportEnabled: Boolean (scalar)
        if (this.IsLogExportEnabled != null) {
            s += ind + "isLogExportEnabled\n" ;
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure != null) {
            s += ind + "shouldCancelBackupOnPreBackupScriptFailure\n" ;
        }
        //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
        // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.BackupScriptDetails != null) {
            var fspec = this.BackupScriptDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "backupScriptDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaManagedVolumeHostSummary? HostDetails
        // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
        if (this.HostDetails != null) {
            var fspec = this.HostDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hostDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaManagedVolumeLogExportSummary? LogExportSummary
        // GraphQL -> logExportSummary: SlaManagedVolumeLogExportSummary (type)
        if (this.LogExportSummary != null) {
            var fspec = this.LogExportSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logExportSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
        // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupFailureDetails != null) {
            var fspec = this.PostBackupScriptOnBackupFailureDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "postBackupScriptOnBackupFailureDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
        // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupSuccessDetails != null) {
            var fspec = this.PostBackupScriptOnBackupSuccessDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "postBackupScriptOnBackupSuccessDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
        // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PreBackupScriptDetails != null) {
            var fspec = this.PreBackupScriptDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "preBackupScriptDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        if (this.ChannelHostMountPaths == null && ec.Includes("channelHostMountPaths",true))
        {
            this.ChannelHostMountPaths = new List<System.String>();
        }
        //      C# -> System.Boolean? IsLogExportEnabled
        // GraphQL -> isLogExportEnabled: Boolean (scalar)
        if (this.IsLogExportEnabled == null && ec.Includes("isLogExportEnabled",true))
        {
            this.IsLogExportEnabled = true;
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure == null && ec.Includes("shouldCancelBackupOnPreBackupScriptFailure",true))
        {
            this.ShouldCancelBackupOnPreBackupScriptFailure = true;
        }
        //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
        // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.BackupScriptDetails == null && ec.Includes("backupScriptDetails",false))
        {
            this.BackupScriptDetails = new SlaManagedVolumeScriptSummary();
            this.BackupScriptDetails.ApplyExploratoryFieldSpec(ec.NewChild("backupScriptDetails"));
        }
        //      C# -> SlaManagedVolumeHostSummary? HostDetails
        // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
        if (this.HostDetails == null && ec.Includes("hostDetails",false))
        {
            this.HostDetails = new SlaManagedVolumeHostSummary();
            this.HostDetails.ApplyExploratoryFieldSpec(ec.NewChild("hostDetails"));
        }
        //      C# -> SlaManagedVolumeLogExportSummary? LogExportSummary
        // GraphQL -> logExportSummary: SlaManagedVolumeLogExportSummary (type)
        if (this.LogExportSummary == null && ec.Includes("logExportSummary",false))
        {
            this.LogExportSummary = new SlaManagedVolumeLogExportSummary();
            this.LogExportSummary.ApplyExploratoryFieldSpec(ec.NewChild("logExportSummary"));
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
        // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupFailureDetails == null && ec.Includes("postBackupScriptOnBackupFailureDetails",false))
        {
            this.PostBackupScriptOnBackupFailureDetails = new SlaManagedVolumeScriptSummary();
            this.PostBackupScriptOnBackupFailureDetails.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScriptOnBackupFailureDetails"));
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
        // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupSuccessDetails == null && ec.Includes("postBackupScriptOnBackupSuccessDetails",false))
        {
            this.PostBackupScriptOnBackupSuccessDetails = new SlaManagedVolumeScriptSummary();
            this.PostBackupScriptOnBackupSuccessDetails.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScriptOnBackupSuccessDetails"));
        }
        //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
        // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PreBackupScriptDetails == null && ec.Includes("preBackupScriptDetails",false))
        {
            this.PreBackupScriptDetails = new SlaManagedVolumeScriptSummary();
            this.PreBackupScriptDetails.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScriptDetails"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaManagedVolumeDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaManagedVolumeDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SlaManagedVolumeDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
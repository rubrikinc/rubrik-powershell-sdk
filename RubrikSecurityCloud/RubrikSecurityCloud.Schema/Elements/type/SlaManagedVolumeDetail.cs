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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        if (this.ChannelHostMountPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "channelHostMountPaths\n" ;
            } else {
                s += ind + "channelHostMountPaths\n" ;
            }
        }
        //      C# -> System.Boolean? IsLogExportEnabled
        // GraphQL -> isLogExportEnabled: Boolean (scalar)
        if (this.IsLogExportEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLogExportEnabled\n" ;
            } else {
                s += ind + "isLogExportEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldCancelBackupOnPreBackupScriptFailure\n" ;
            } else {
                s += ind + "shouldCancelBackupOnPreBackupScriptFailure\n" ;
            }
        }
        //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
        // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.BackupScriptDetails != null) {
            var fspec = this.BackupScriptDetails.AsFieldSpec(conf.Child("backupScriptDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupScriptDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaManagedVolumeHostSummary? HostDetails
        // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
        if (this.HostDetails != null) {
            var fspec = this.HostDetails.AsFieldSpec(conf.Child("hostDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaManagedVolumeLogExportSummary? LogExportSummary
        // GraphQL -> logExportSummary: SlaManagedVolumeLogExportSummary (type)
        if (this.LogExportSummary != null) {
            var fspec = this.LogExportSummary.AsFieldSpec(conf.Child("logExportSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logExportSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
        // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupFailureDetails != null) {
            var fspec = this.PostBackupScriptOnBackupFailureDetails.AsFieldSpec(conf.Child("postBackupScriptOnBackupFailureDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postBackupScriptOnBackupFailureDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
        // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PostBackupScriptOnBackupSuccessDetails != null) {
            var fspec = this.PostBackupScriptOnBackupSuccessDetails.AsFieldSpec(conf.Child("postBackupScriptOnBackupSuccessDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postBackupScriptOnBackupSuccessDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
        // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (this.PreBackupScriptDetails != null) {
            var fspec = this.PreBackupScriptDetails.AsFieldSpec(conf.Child("preBackupScriptDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "preBackupScriptDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        if (ec.Includes("channelHostMountPaths",true))
        {
            if(this.ChannelHostMountPaths == null) {

                this.ChannelHostMountPaths = new List<System.String>();

            } else {


            }
        }
        else if (this.ChannelHostMountPaths != null && ec.Excludes("channelHostMountPaths",true))
        {
            this.ChannelHostMountPaths = null;
        }
        //      C# -> System.Boolean? IsLogExportEnabled
        // GraphQL -> isLogExportEnabled: Boolean (scalar)
        if (ec.Includes("isLogExportEnabled",true))
        {
            if(this.IsLogExportEnabled == null) {

                this.IsLogExportEnabled = true;

            } else {


            }
        }
        else if (this.IsLogExportEnabled != null && ec.Excludes("isLogExportEnabled",true))
        {
            this.IsLogExportEnabled = null;
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        if (ec.Includes("shouldCancelBackupOnPreBackupScriptFailure",true))
        {
            if(this.ShouldCancelBackupOnPreBackupScriptFailure == null) {

                this.ShouldCancelBackupOnPreBackupScriptFailure = true;

            } else {


            }
        }
        else if (this.ShouldCancelBackupOnPreBackupScriptFailure != null && ec.Excludes("shouldCancelBackupOnPreBackupScriptFailure",true))
        {
            this.ShouldCancelBackupOnPreBackupScriptFailure = null;
        }
        //      C# -> SlaManagedVolumeScriptSummary? BackupScriptDetails
        // GraphQL -> backupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (ec.Includes("backupScriptDetails",false))
        {
            if(this.BackupScriptDetails == null) {

                this.BackupScriptDetails = new SlaManagedVolumeScriptSummary();
                this.BackupScriptDetails.ApplyExploratoryFieldSpec(ec.NewChild("backupScriptDetails"));

            } else {

                this.BackupScriptDetails.ApplyExploratoryFieldSpec(ec.NewChild("backupScriptDetails"));

            }
        }
        else if (this.BackupScriptDetails != null && ec.Excludes("backupScriptDetails",false))
        {
            this.BackupScriptDetails = null;
        }
        //      C# -> SlaManagedVolumeHostSummary? HostDetails
        // GraphQL -> hostDetails: SlaManagedVolumeHostSummary (type)
        if (ec.Includes("hostDetails",false))
        {
            if(this.HostDetails == null) {

                this.HostDetails = new SlaManagedVolumeHostSummary();
                this.HostDetails.ApplyExploratoryFieldSpec(ec.NewChild("hostDetails"));

            } else {

                this.HostDetails.ApplyExploratoryFieldSpec(ec.NewChild("hostDetails"));

            }
        }
        else if (this.HostDetails != null && ec.Excludes("hostDetails",false))
        {
            this.HostDetails = null;
        }
        //      C# -> SlaManagedVolumeLogExportSummary? LogExportSummary
        // GraphQL -> logExportSummary: SlaManagedVolumeLogExportSummary (type)
        if (ec.Includes("logExportSummary",false))
        {
            if(this.LogExportSummary == null) {

                this.LogExportSummary = new SlaManagedVolumeLogExportSummary();
                this.LogExportSummary.ApplyExploratoryFieldSpec(ec.NewChild("logExportSummary"));

            } else {

                this.LogExportSummary.ApplyExploratoryFieldSpec(ec.NewChild("logExportSummary"));

            }
        }
        else if (this.LogExportSummary != null && ec.Excludes("logExportSummary",false))
        {
            this.LogExportSummary = null;
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupFailureDetails
        // GraphQL -> postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary (type)
        if (ec.Includes("postBackupScriptOnBackupFailureDetails",false))
        {
            if(this.PostBackupScriptOnBackupFailureDetails == null) {

                this.PostBackupScriptOnBackupFailureDetails = new SlaManagedVolumeScriptSummary();
                this.PostBackupScriptOnBackupFailureDetails.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScriptOnBackupFailureDetails"));

            } else {

                this.PostBackupScriptOnBackupFailureDetails.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScriptOnBackupFailureDetails"));

            }
        }
        else if (this.PostBackupScriptOnBackupFailureDetails != null && ec.Excludes("postBackupScriptOnBackupFailureDetails",false))
        {
            this.PostBackupScriptOnBackupFailureDetails = null;
        }
        //      C# -> SlaManagedVolumeScriptSummary? PostBackupScriptOnBackupSuccessDetails
        // GraphQL -> postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary (type)
        if (ec.Includes("postBackupScriptOnBackupSuccessDetails",false))
        {
            if(this.PostBackupScriptOnBackupSuccessDetails == null) {

                this.PostBackupScriptOnBackupSuccessDetails = new SlaManagedVolumeScriptSummary();
                this.PostBackupScriptOnBackupSuccessDetails.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScriptOnBackupSuccessDetails"));

            } else {

                this.PostBackupScriptOnBackupSuccessDetails.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScriptOnBackupSuccessDetails"));

            }
        }
        else if (this.PostBackupScriptOnBackupSuccessDetails != null && ec.Excludes("postBackupScriptOnBackupSuccessDetails",false))
        {
            this.PostBackupScriptOnBackupSuccessDetails = null;
        }
        //      C# -> SlaManagedVolumeScriptSummary? PreBackupScriptDetails
        // GraphQL -> preBackupScriptDetails: SlaManagedVolumeScriptSummary (type)
        if (ec.Includes("preBackupScriptDetails",false))
        {
            if(this.PreBackupScriptDetails == null) {

                this.PreBackupScriptDetails = new SlaManagedVolumeScriptSummary();
                this.PreBackupScriptDetails.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScriptDetails"));

            } else {

                this.PreBackupScriptDetails.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScriptDetails"));

            }
        }
        else if (this.PreBackupScriptDetails != null && ec.Excludes("preBackupScriptDetails",false))
        {
            this.PreBackupScriptDetails = null;
        }
    }


    #endregion

    } // class SlaManagedVolumeDetail
    
    #endregion

    public static class ListSlaManagedVolumeDetailExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SlaManagedVolumeDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaManagedVolumeDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SlaManagedVolumeDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// ManagedVolumeSlaClientConfig.cs
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
    #region ManagedVolumeSlaClientConfig
    public class ManagedVolumeSlaClientConfig: BaseType
    {
        #region members

        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        [JsonProperty("channelHostMountPaths")]
        public List<System.String>? ChannelHostMountPaths { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
        [JsonProperty("shouldCancelBackupOnPreBackupScriptFailure")]
        public System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
        // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
        [JsonProperty("backupScript")]
        public ManagedVolumeSlaScriptConfig? BackupScript { get; set; }

        //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
        // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        [JsonProperty("failedPostBackupScript")]
        public ManagedVolumeSlaScriptConfig? FailedPostBackupScript { get; set; }

        //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
        // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
        [JsonProperty("preBackupScript")]
        public ManagedVolumeSlaScriptConfig? PreBackupScript { get; set; }

        //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
        // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        [JsonProperty("successfulPostBackupScript")]
        public ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeSlaClientConfig";
    }

    public ManagedVolumeSlaClientConfig Set(
        List<System.String>? ChannelHostMountPaths = null,
        System.String? HostId = null,
        System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure = null,
        System.String? Username = null,
        ManagedVolumeSlaScriptConfig? BackupScript = null,
        ManagedVolumeSlaScriptConfig? FailedPostBackupScript = null,
        ManagedVolumeSlaScriptConfig? PreBackupScript = null,
        ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript = null
    ) 
    {
        if ( ChannelHostMountPaths != null ) {
            this.ChannelHostMountPaths = ChannelHostMountPaths;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( ShouldCancelBackupOnPreBackupScriptFailure != null ) {
            this.ShouldCancelBackupOnPreBackupScriptFailure = ShouldCancelBackupOnPreBackupScriptFailure;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( BackupScript != null ) {
            this.BackupScript = BackupScript;
        }
        if ( FailedPostBackupScript != null ) {
            this.FailedPostBackupScript = FailedPostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( SuccessfulPostBackupScript != null ) {
            this.SuccessfulPostBackupScript = SuccessfulPostBackupScript;
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
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldCancelBackupOnPreBackupScriptFailure\n" ;
            } else {
                s += ind + "shouldCancelBackupOnPreBackupScriptFailure\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
        // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
        if (this.BackupScript != null) {
            var fspec = this.BackupScript.AsFieldSpec(conf.Child("backupScript"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
        // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.FailedPostBackupScript != null) {
            var fspec = this.FailedPostBackupScript.AsFieldSpec(conf.Child("failedPostBackupScript"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failedPostBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
        // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(conf.Child("preBackupScript"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "preBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
        // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.SuccessfulPostBackupScript != null) {
            var fspec = this.SuccessfulPostBackupScript.AsFieldSpec(conf.Child("successfulPostBackupScript"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "successfulPostBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
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
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
        // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
        if (ec.Includes("backupScript",false))
        {
            if(this.BackupScript == null) {

                this.BackupScript = new ManagedVolumeSlaScriptConfig();
                this.BackupScript.ApplyExploratoryFieldSpec(ec.NewChild("backupScript"));

            } else {

                this.BackupScript.ApplyExploratoryFieldSpec(ec.NewChild("backupScript"));

            }
        }
        else if (this.BackupScript != null && ec.Excludes("backupScript",false))
        {
            this.BackupScript = null;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
        // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (ec.Includes("failedPostBackupScript",false))
        {
            if(this.FailedPostBackupScript == null) {

                this.FailedPostBackupScript = new ManagedVolumeSlaScriptConfig();
                this.FailedPostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("failedPostBackupScript"));

            } else {

                this.FailedPostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("failedPostBackupScript"));

            }
        }
        else if (this.FailedPostBackupScript != null && ec.Excludes("failedPostBackupScript",false))
        {
            this.FailedPostBackupScript = null;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
        // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (ec.Includes("preBackupScript",false))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = new ManagedVolumeSlaScriptConfig();
                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            } else {

                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            }
        }
        else if (this.PreBackupScript != null && ec.Excludes("preBackupScript",false))
        {
            this.PreBackupScript = null;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
        // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (ec.Includes("successfulPostBackupScript",false))
        {
            if(this.SuccessfulPostBackupScript == null) {

                this.SuccessfulPostBackupScript = new ManagedVolumeSlaScriptConfig();
                this.SuccessfulPostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("successfulPostBackupScript"));

            } else {

                this.SuccessfulPostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("successfulPostBackupScript"));

            }
        }
        else if (this.SuccessfulPostBackupScript != null && ec.Excludes("successfulPostBackupScript",false))
        {
            this.SuccessfulPostBackupScript = null;
        }
    }


    #endregion

    } // class ManagedVolumeSlaClientConfig
    
    #endregion

    public static class ListManagedVolumeSlaClientConfigExtensions
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
            this List<ManagedVolumeSlaClientConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeSlaClientConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSlaClientConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSlaClientConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSlaClientConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
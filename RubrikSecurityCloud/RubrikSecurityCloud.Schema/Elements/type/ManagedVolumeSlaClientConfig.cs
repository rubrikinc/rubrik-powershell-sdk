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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        if (this.ChannelHostMountPaths != null) {
            s += ind + "channelHostMountPaths\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure != null) {
            s += ind + "shouldCancelBackupOnPreBackupScriptFailure\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
        // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
        if (this.BackupScript != null) {
            var fspec = this.BackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "backupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
        // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.FailedPostBackupScript != null) {
            var fspec = this.FailedPostBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failedPostBackupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
        // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "preBackupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
        // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.SuccessfulPostBackupScript != null) {
            var fspec = this.SuccessfulPostBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "successfulPostBackupScript {\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId == null && ec.Includes("hostId",true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure == null && ec.Includes("shouldCancelBackupOnPreBackupScriptFailure",true))
        {
            this.ShouldCancelBackupOnPreBackupScriptFailure = true;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && ec.Includes("username",true))
        {
            this.Username = "FETCH";
        }
        //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
        // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
        if (this.BackupScript == null && ec.Includes("backupScript",false))
        {
            this.BackupScript = new ManagedVolumeSlaScriptConfig();
            this.BackupScript.ApplyExploratoryFieldSpec(ec.NewChild("backupScript"));
        }
        //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
        // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.FailedPostBackupScript == null && ec.Includes("failedPostBackupScript",false))
        {
            this.FailedPostBackupScript = new ManagedVolumeSlaScriptConfig();
            this.FailedPostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("failedPostBackupScript"));
        }
        //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
        // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.PreBackupScript == null && ec.Includes("preBackupScript",false))
        {
            this.PreBackupScript = new ManagedVolumeSlaScriptConfig();
            this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));
        }
        //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
        // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.SuccessfulPostBackupScript == null && ec.Includes("successfulPostBackupScript",false))
        {
            this.SuccessfulPostBackupScript = new ManagedVolumeSlaScriptConfig();
            this.SuccessfulPostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("successfulPostBackupScript"));
        }
    }


    #endregion

    } // class ManagedVolumeSlaClientConfig
    
    #endregion

    public static class ListManagedVolumeSlaClientConfigExtensions
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
            this List<ManagedVolumeSlaClientConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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
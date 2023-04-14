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

namespace Rubrik.SecurityCloud.Types
{
    #region ManagedVolumeSlaClientConfig
    public class ManagedVolumeSlaClientConfig: IFragment
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
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String! (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
            // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
            if (this.ShouldCancelBackupOnPreBackupScriptFailure != null)
            {
                 s += ind + "shouldCancelBackupOnPreBackupScriptFailure\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
            // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
            if (this.BackupScript != null)
            {
                 s += ind + "backupScript\n";

                 s += ind + "{\n" + 
                 this.BackupScript.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
            // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
            if (this.FailedPostBackupScript != null)
            {
                 s += ind + "failedPostBackupScript\n";

                 s += ind + "{\n" + 
                 this.FailedPostBackupScript.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
            // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
            if (this.PreBackupScript != null)
            {
                 s += ind + "preBackupScript\n";

                 s += ind + "{\n" + 
                 this.PreBackupScript.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
            // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
            if (this.SuccessfulPostBackupScript != null)
            {
                 s += ind + "successfulPostBackupScript\n";

                 s += ind + "{\n" + 
                 this.SuccessfulPostBackupScript.AsFragment(indent+1) + 
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
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String! (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
            // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
            if (this.ShouldCancelBackupOnPreBackupScriptFailure == null && Exploration.Includes(parent + ".shouldCancelBackupOnPreBackupScriptFailure$"))
            {
                this.ShouldCancelBackupOnPreBackupScriptFailure = new System.Boolean();
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
            //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
            // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
            if (this.BackupScript == null && Exploration.Includes(parent + ".backupScript"))
            {
                this.BackupScript = new ManagedVolumeSlaScriptConfig();
                this.BackupScript.ApplyExploratoryFragment(parent + ".backupScript");
            }
            //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
            // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
            if (this.FailedPostBackupScript == null && Exploration.Includes(parent + ".failedPostBackupScript"))
            {
                this.FailedPostBackupScript = new ManagedVolumeSlaScriptConfig();
                this.FailedPostBackupScript.ApplyExploratoryFragment(parent + ".failedPostBackupScript");
            }
            //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
            // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
            if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript"))
            {
                this.PreBackupScript = new ManagedVolumeSlaScriptConfig();
                this.PreBackupScript.ApplyExploratoryFragment(parent + ".preBackupScript");
            }
            //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
            // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
            if (this.SuccessfulPostBackupScript == null && Exploration.Includes(parent + ".successfulPostBackupScript"))
            {
                this.SuccessfulPostBackupScript = new ManagedVolumeSlaScriptConfig();
                this.SuccessfulPostBackupScript.ApplyExploratoryFragment(parent + ".successfulPostBackupScript");
            }
        }


    #endregion

    } // class ManagedVolumeSlaClientConfig
    #endregion

    public static class ListManagedVolumeSlaClientConfigExtensions
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
            this List<ManagedVolumeSlaClientConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeSlaClientConfig> list, 
            String parent = "")
        {
            var item = new ManagedVolumeSlaClientConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// CreateCrossAccountReplicationPairReply.cs
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
    #region CreateCrossAccountReplicationPairReply
    public class CreateCrossAccountReplicationPairReply: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReplicationTargetPauseEnabled
        // GraphQL -> isReplicationTargetPauseEnabled: Boolean (scalar)
        [JsonProperty("isReplicationTargetPauseEnabled")]
        public System.Boolean? IsReplicationTargetPauseEnabled { get; set; }

        //      C# -> System.Boolean? IsRetentionLockEnabledLocation
        // GraphQL -> isRetentionLockEnabledLocation: Boolean (scalar)
        [JsonProperty("isRetentionLockEnabledLocation")]
        public System.Boolean? IsRetentionLockEnabledLocation { get; set; }

        //      C# -> System.String? ReplicationSetup
        // GraphQL -> replicationSetup: String! (scalar)
        [JsonProperty("replicationSetup")]
        public System.String? ReplicationSetup { get; set; }

        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        [JsonProperty("targetClusterAddress")]
        public System.String? TargetClusterAddress { get; set; }

        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String (scalar)
        [JsonProperty("targetClusterName")]
        public System.String? TargetClusterName { get; set; }

        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: String (scalar)
        [JsonProperty("targetClusterUuid")]
        public System.String? TargetClusterUuid { get; set; }

        //      C# -> NatGatewayInfo? TargetGateway
        // GraphQL -> targetGateway: NatGatewayInfo (type)
        [JsonProperty("targetGateway")]
        public NatGatewayInfo? TargetGateway { get; set; }

        #endregion

    #region methods

    public CreateCrossAccountReplicationPairReply Set(
        System.String? Id = null,
        System.Boolean? IsReplicationTargetPauseEnabled = null,
        System.Boolean? IsRetentionLockEnabledLocation = null,
        System.String? ReplicationSetup = null,
        System.String? TargetClusterAddress = null,
        System.String? TargetClusterName = null,
        System.String? TargetClusterUuid = null,
        NatGatewayInfo? TargetGateway = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReplicationTargetPauseEnabled != null ) {
            this.IsReplicationTargetPauseEnabled = IsReplicationTargetPauseEnabled;
        }
        if ( IsRetentionLockEnabledLocation != null ) {
            this.IsRetentionLockEnabledLocation = IsRetentionLockEnabledLocation;
        }
        if ( ReplicationSetup != null ) {
            this.ReplicationSetup = ReplicationSetup;
        }
        if ( TargetClusterAddress != null ) {
            this.TargetClusterAddress = TargetClusterAddress;
        }
        if ( TargetClusterName != null ) {
            this.TargetClusterName = TargetClusterName;
        }
        if ( TargetClusterUuid != null ) {
            this.TargetClusterUuid = TargetClusterUuid;
        }
        if ( TargetGateway != null ) {
            this.TargetGateway = TargetGateway;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsReplicationTargetPauseEnabled
            // GraphQL -> isReplicationTargetPauseEnabled: Boolean (scalar)
            if (this.IsReplicationTargetPauseEnabled != null)
            {
                 s += ind + "isReplicationTargetPauseEnabled\n";

            }
            //      C# -> System.Boolean? IsRetentionLockEnabledLocation
            // GraphQL -> isRetentionLockEnabledLocation: Boolean (scalar)
            if (this.IsRetentionLockEnabledLocation != null)
            {
                 s += ind + "isRetentionLockEnabledLocation\n";

            }
            //      C# -> System.String? ReplicationSetup
            // GraphQL -> replicationSetup: String! (scalar)
            if (this.ReplicationSetup != null)
            {
                 s += ind + "replicationSetup\n";

            }
            //      C# -> System.String? TargetClusterAddress
            // GraphQL -> targetClusterAddress: String (scalar)
            if (this.TargetClusterAddress != null)
            {
                 s += ind + "targetClusterAddress\n";

            }
            //      C# -> System.String? TargetClusterName
            // GraphQL -> targetClusterName: String (scalar)
            if (this.TargetClusterName != null)
            {
                 s += ind + "targetClusterName\n";

            }
            //      C# -> System.String? TargetClusterUuid
            // GraphQL -> targetClusterUuid: String (scalar)
            if (this.TargetClusterUuid != null)
            {
                 s += ind + "targetClusterUuid\n";

            }
            //      C# -> NatGatewayInfo? TargetGateway
            // GraphQL -> targetGateway: NatGatewayInfo (type)
            if (this.TargetGateway != null)
            {
                 s += ind + "targetGateway\n";

                 s += ind + "{\n" + 
                 this.TargetGateway.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsReplicationTargetPauseEnabled
            // GraphQL -> isReplicationTargetPauseEnabled: Boolean (scalar)
            if (this.IsReplicationTargetPauseEnabled == null && Exploration.Includes(parent + ".isReplicationTargetPauseEnabled$"))
            {
                this.IsReplicationTargetPauseEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRetentionLockEnabledLocation
            // GraphQL -> isRetentionLockEnabledLocation: Boolean (scalar)
            if (this.IsRetentionLockEnabledLocation == null && Exploration.Includes(parent + ".isRetentionLockEnabledLocation$"))
            {
                this.IsRetentionLockEnabledLocation = new System.Boolean();
            }
            //      C# -> System.String? ReplicationSetup
            // GraphQL -> replicationSetup: String! (scalar)
            if (this.ReplicationSetup == null && Exploration.Includes(parent + ".replicationSetup$"))
            {
                this.ReplicationSetup = new System.String("FETCH");
            }
            //      C# -> System.String? TargetClusterAddress
            // GraphQL -> targetClusterAddress: String (scalar)
            if (this.TargetClusterAddress == null && Exploration.Includes(parent + ".targetClusterAddress$"))
            {
                this.TargetClusterAddress = new System.String("FETCH");
            }
            //      C# -> System.String? TargetClusterName
            // GraphQL -> targetClusterName: String (scalar)
            if (this.TargetClusterName == null && Exploration.Includes(parent + ".targetClusterName$"))
            {
                this.TargetClusterName = new System.String("FETCH");
            }
            //      C# -> System.String? TargetClusterUuid
            // GraphQL -> targetClusterUuid: String (scalar)
            if (this.TargetClusterUuid == null && Exploration.Includes(parent + ".targetClusterUuid$"))
            {
                this.TargetClusterUuid = new System.String("FETCH");
            }
            //      C# -> NatGatewayInfo? TargetGateway
            // GraphQL -> targetGateway: NatGatewayInfo (type)
            if (this.TargetGateway == null && Exploration.Includes(parent + ".targetGateway"))
            {
                this.TargetGateway = new NatGatewayInfo();
                this.TargetGateway.ApplyExploratoryFragment(parent + ".targetGateway");
            }
        }


    #endregion

    } // class CreateCrossAccountReplicationPairReply
    #endregion

    public static class ListCreateCrossAccountReplicationPairReplyExtensions
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
            this List<CreateCrossAccountReplicationPairReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CreateCrossAccountReplicationPairReply> list, 
            String parent = "")
        {
            var item = new CreateCrossAccountReplicationPairReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
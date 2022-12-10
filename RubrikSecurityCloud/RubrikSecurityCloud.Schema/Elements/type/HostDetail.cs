// HostDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:36.
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
    #region HostDetail
    public class HostDetail: IFragment
    {
        #region members
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        [JsonProperty("agentId")]
        public System.String? AgentId { get; set; }

        //      C# -> System.Boolean? CompressionEnabled
        // GraphQL -> compressionEnabled: Boolean (scalar)
        [JsonProperty("compressionEnabled")]
        public System.Boolean? CompressionEnabled { get; set; }

        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean (scalar)
        [JsonProperty("isOracleHost")]
        public System.Boolean? IsOracleHost { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Boolean? MssqlCbtDriverInstalled
        // GraphQL -> mssqlCbtDriverInstalled: Boolean! (scalar)
        [JsonProperty("mssqlCbtDriverInstalled")]
        public System.Boolean? MssqlCbtDriverInstalled { get; set; }

        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        [JsonProperty("oracleQueryUser")]
        public System.String? OracleQueryUser { get; set; }

        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        [JsonProperty("oracleSysDbaUser")]
        public System.String? OracleSysDbaUser { get; set; }

        //      C# -> HostSummary? HostSummary
        // GraphQL -> hostSummary: HostSummary (type)
        [JsonProperty("hostSummary")]
        public HostSummary? HostSummary { get; set; }

        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        [JsonProperty("hostVfdDriverState")]
        public HostVfdState? HostVfdDriverState { get; set; }

        //      C# -> HostVfdInstallConfig? HostVfdEnabled
        // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
        [JsonProperty("hostVfdEnabled")]
        public HostVfdInstallConfig? HostVfdEnabled { get; set; }

        #endregion

    #region methods

    public HostDetail Set(
        System.String? AgentId = null,
        System.Boolean? CompressionEnabled = null,
        System.Boolean? IsOracleHost = null,
        System.Boolean? IsRelic = null,
        System.Boolean? MssqlCbtDriverInstalled = null,
        System.String? OracleQueryUser = null,
        System.String? OracleSysDbaUser = null,
        HostSummary? HostSummary = null,
        HostVfdState? HostVfdDriverState = null,
        HostVfdInstallConfig? HostVfdEnabled = null
    ) 
    {
        if ( AgentId != null ) {
            this.AgentId = AgentId;
        }
        if ( CompressionEnabled != null ) {
            this.CompressionEnabled = CompressionEnabled;
        }
        if ( IsOracleHost != null ) {
            this.IsOracleHost = IsOracleHost;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( MssqlCbtDriverInstalled != null ) {
            this.MssqlCbtDriverInstalled = MssqlCbtDriverInstalled;
        }
        if ( OracleQueryUser != null ) {
            this.OracleQueryUser = OracleQueryUser;
        }
        if ( OracleSysDbaUser != null ) {
            this.OracleSysDbaUser = OracleSysDbaUser;
        }
        if ( HostSummary != null ) {
            this.HostSummary = HostSummary;
        }
        if ( HostVfdDriverState != null ) {
            this.HostVfdDriverState = HostVfdDriverState;
        }
        if ( HostVfdEnabled != null ) {
            this.HostVfdEnabled = HostVfdEnabled;
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
            //      C# -> System.String? AgentId
            // GraphQL -> agentId: String (scalar)
            if (this.AgentId != null)
            {
                 s += ind + "agentId\n";

            }
            //      C# -> System.Boolean? CompressionEnabled
            // GraphQL -> compressionEnabled: Boolean (scalar)
            if (this.CompressionEnabled != null)
            {
                 s += ind + "compressionEnabled\n";

            }
            //      C# -> System.Boolean? IsOracleHost
            // GraphQL -> isOracleHost: Boolean (scalar)
            if (this.IsOracleHost != null)
            {
                 s += ind + "isOracleHost\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.Boolean? MssqlCbtDriverInstalled
            // GraphQL -> mssqlCbtDriverInstalled: Boolean! (scalar)
            if (this.MssqlCbtDriverInstalled != null)
            {
                 s += ind + "mssqlCbtDriverInstalled\n";

            }
            //      C# -> System.String? OracleQueryUser
            // GraphQL -> oracleQueryUser: String (scalar)
            if (this.OracleQueryUser != null)
            {
                 s += ind + "oracleQueryUser\n";

            }
            //      C# -> System.String? OracleSysDbaUser
            // GraphQL -> oracleSysDbaUser: String (scalar)
            if (this.OracleSysDbaUser != null)
            {
                 s += ind + "oracleSysDbaUser\n";

            }
            //      C# -> HostSummary? HostSummary
            // GraphQL -> hostSummary: HostSummary (type)
            if (this.HostSummary != null)
            {
                 s += ind + "hostSummary\n";

                 s += ind + "{\n" + 
                 this.HostSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HostVfdState? HostVfdDriverState
            // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
            if (this.HostVfdDriverState != null)
            {
                 s += ind + "hostVfdDriverState\n";

            }
            //      C# -> HostVfdInstallConfig? HostVfdEnabled
            // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
            if (this.HostVfdEnabled != null)
            {
                 s += ind + "hostVfdEnabled\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AgentId
            // GraphQL -> agentId: String (scalar)
            if (this.AgentId == null && Exploration.Includes(parent + ".agentId$"))
            {
                this.AgentId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? CompressionEnabled
            // GraphQL -> compressionEnabled: Boolean (scalar)
            if (this.CompressionEnabled == null && Exploration.Includes(parent + ".compressionEnabled$"))
            {
                this.CompressionEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsOracleHost
            // GraphQL -> isOracleHost: Boolean (scalar)
            if (this.IsOracleHost == null && Exploration.Includes(parent + ".isOracleHost$"))
            {
                this.IsOracleHost = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.Boolean? MssqlCbtDriverInstalled
            // GraphQL -> mssqlCbtDriverInstalled: Boolean! (scalar)
            if (this.MssqlCbtDriverInstalled == null && Exploration.Includes(parent + ".mssqlCbtDriverInstalled$"))
            {
                this.MssqlCbtDriverInstalled = new System.Boolean();
            }
            //      C# -> System.String? OracleQueryUser
            // GraphQL -> oracleQueryUser: String (scalar)
            if (this.OracleQueryUser == null && Exploration.Includes(parent + ".oracleQueryUser$"))
            {
                this.OracleQueryUser = new System.String("FETCH");
            }
            //      C# -> System.String? OracleSysDbaUser
            // GraphQL -> oracleSysDbaUser: String (scalar)
            if (this.OracleSysDbaUser == null && Exploration.Includes(parent + ".oracleSysDbaUser$"))
            {
                this.OracleSysDbaUser = new System.String("FETCH");
            }
            //      C# -> HostSummary? HostSummary
            // GraphQL -> hostSummary: HostSummary (type)
            if (this.HostSummary == null && Exploration.Includes(parent + ".hostSummary"))
            {
                this.HostSummary = new HostSummary();
                this.HostSummary.ApplyExploratoryFragment(parent + ".hostSummary");
            }
            //      C# -> HostVfdState? HostVfdDriverState
            // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
            if (this.HostVfdDriverState == null && Exploration.Includes(parent + ".hostVfdDriverState$"))
            {
                this.HostVfdDriverState = new HostVfdState();
            }
            //      C# -> HostVfdInstallConfig? HostVfdEnabled
            // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
            if (this.HostVfdEnabled == null && Exploration.Includes(parent + ".hostVfdEnabled$"))
            {
                this.HostVfdEnabled = new HostVfdInstallConfig();
            }
        }


    #endregion

    } // class HostDetail
    #endregion

    public static class ListHostDetailExtensions
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
            this List<HostDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HostDetail> list, 
            String parent = "")
        {
            var item = new HostDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
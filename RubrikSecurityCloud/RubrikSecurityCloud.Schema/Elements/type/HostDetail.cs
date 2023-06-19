// HostDetail.cs
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
    #region HostDetail
    public class HostDetail: BaseType
    {
        #region members

        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        [JsonProperty("hostVfdDriverState")]
        public HostVfdState? HostVfdDriverState { get; set; }

        //      C# -> HostVfdInstallConfig? HostVfdEnabled
        // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
        [JsonProperty("hostVfdEnabled")]
        public HostVfdInstallConfig? HostVfdEnabled { get; set; }

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

        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        [JsonProperty("isRefreshPaused")]
        public System.Boolean? IsRefreshPaused { get; set; }

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


        #endregion

    #region methods

    public HostDetail Set(
        HostVfdState? HostVfdDriverState = null,
        HostVfdInstallConfig? HostVfdEnabled = null,
        System.String? AgentId = null,
        System.Boolean? CompressionEnabled = null,
        System.Boolean? IsOracleHost = null,
        System.Boolean? IsRefreshPaused = null,
        System.Boolean? IsRelic = null,
        System.Boolean? MssqlCbtDriverInstalled = null,
        System.String? OracleQueryUser = null,
        System.String? OracleSysDbaUser = null,
        HostSummary? HostSummary = null
    ) 
    {
        if ( HostVfdDriverState != null ) {
            this.HostVfdDriverState = HostVfdDriverState;
        }
        if ( HostVfdEnabled != null ) {
            this.HostVfdEnabled = HostVfdEnabled;
        }
        if ( AgentId != null ) {
            this.AgentId = AgentId;
        }
        if ( CompressionEnabled != null ) {
            this.CompressionEnabled = CompressionEnabled;
        }
        if ( IsOracleHost != null ) {
            this.IsOracleHost = IsOracleHost;
        }
        if ( IsRefreshPaused != null ) {
            this.IsRefreshPaused = IsRefreshPaused;
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (this.HostVfdDriverState != null) {
            s += ind + "hostVfdDriverState\n" ;
        }
        //      C# -> HostVfdInstallConfig? HostVfdEnabled
        // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
        if (this.HostVfdEnabled != null) {
            s += ind + "hostVfdEnabled\n" ;
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (this.AgentId != null) {
            s += ind + "agentId\n" ;
        }
        //      C# -> System.Boolean? CompressionEnabled
        // GraphQL -> compressionEnabled: Boolean (scalar)
        if (this.CompressionEnabled != null) {
            s += ind + "compressionEnabled\n" ;
        }
        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean (scalar)
        if (this.IsOracleHost != null) {
            s += ind + "isOracleHost\n" ;
        }
        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        if (this.IsRefreshPaused != null) {
            s += ind + "isRefreshPaused\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.Boolean? MssqlCbtDriverInstalled
        // GraphQL -> mssqlCbtDriverInstalled: Boolean! (scalar)
        if (this.MssqlCbtDriverInstalled != null) {
            s += ind + "mssqlCbtDriverInstalled\n" ;
        }
        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        if (this.OracleQueryUser != null) {
            s += ind + "oracleQueryUser\n" ;
        }
        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        if (this.OracleSysDbaUser != null) {
            s += ind + "oracleSysDbaUser\n" ;
        }
        //      C# -> HostSummary? HostSummary
        // GraphQL -> hostSummary: HostSummary (type)
        if (this.HostSummary != null) {
            var fspec = this.HostSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hostSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (this.HostVfdDriverState == null && Exploration.Includes(parent + ".hostVfdDriverState", true))
        {
            this.HostVfdDriverState = new HostVfdState();
        }
        //      C# -> HostVfdInstallConfig? HostVfdEnabled
        // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
        if (this.HostVfdEnabled == null && Exploration.Includes(parent + ".hostVfdEnabled", true))
        {
            this.HostVfdEnabled = new HostVfdInstallConfig();
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (this.AgentId == null && Exploration.Includes(parent + ".agentId", true))
        {
            this.AgentId = "FETCH";
        }
        //      C# -> System.Boolean? CompressionEnabled
        // GraphQL -> compressionEnabled: Boolean (scalar)
        if (this.CompressionEnabled == null && Exploration.Includes(parent + ".compressionEnabled", true))
        {
            this.CompressionEnabled = true;
        }
        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean (scalar)
        if (this.IsOracleHost == null && Exploration.Includes(parent + ".isOracleHost", true))
        {
            this.IsOracleHost = true;
        }
        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        if (this.IsRefreshPaused == null && Exploration.Includes(parent + ".isRefreshPaused", true))
        {
            this.IsRefreshPaused = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.Boolean? MssqlCbtDriverInstalled
        // GraphQL -> mssqlCbtDriverInstalled: Boolean! (scalar)
        if (this.MssqlCbtDriverInstalled == null && Exploration.Includes(parent + ".mssqlCbtDriverInstalled", true))
        {
            this.MssqlCbtDriverInstalled = true;
        }
        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        if (this.OracleQueryUser == null && Exploration.Includes(parent + ".oracleQueryUser", true))
        {
            this.OracleQueryUser = "FETCH";
        }
        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        if (this.OracleSysDbaUser == null && Exploration.Includes(parent + ".oracleSysDbaUser", true))
        {
            this.OracleSysDbaUser = "FETCH";
        }
        //      C# -> HostSummary? HostSummary
        // GraphQL -> hostSummary: HostSummary (type)
        if (this.HostSummary == null && Exploration.Includes(parent + ".hostSummary"))
        {
            this.HostSummary = new HostSummary();
            this.HostSummary.ApplyExploratoryFieldSpec(parent + ".hostSummary");
        }
    }


    #endregion

    } // class HostDetail
    
    #endregion

    public static class ListHostDetailExtensions
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
            this List<HostDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HostDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
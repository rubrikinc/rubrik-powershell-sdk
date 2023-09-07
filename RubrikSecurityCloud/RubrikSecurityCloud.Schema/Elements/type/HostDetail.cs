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

        //      C# -> System.String? HostDomainId
        // GraphQL -> hostDomainId: String (scalar)
        [JsonProperty("hostDomainId")]
        public System.String? HostDomainId { get; set; }

        //      C# -> System.String? HostDomainName
        // GraphQL -> hostDomainName: String (scalar)
        [JsonProperty("hostDomainName")]
        public System.String? HostDomainName { get; set; }

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

    public override string GetGqlTypeName() {
        return "HostDetail";
    }

    public HostDetail Set(
        HostVfdState? HostVfdDriverState = null,
        HostVfdInstallConfig? HostVfdEnabled = null,
        System.String? AgentId = null,
        System.Boolean? CompressionEnabled = null,
        System.String? HostDomainId = null,
        System.String? HostDomainName = null,
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
        if ( HostDomainId != null ) {
            this.HostDomainId = HostDomainId;
        }
        if ( HostDomainName != null ) {
            this.HostDomainName = HostDomainName;
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
        //      C# -> System.String? HostDomainId
        // GraphQL -> hostDomainId: String (scalar)
        if (this.HostDomainId != null) {
            s += ind + "hostDomainId\n" ;
        }
        //      C# -> System.String? HostDomainName
        // GraphQL -> hostDomainName: String (scalar)
        if (this.HostDomainName != null) {
            s += ind + "hostDomainName\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (this.HostVfdDriverState == null && ec.Includes("hostVfdDriverState",true))
        {
            this.HostVfdDriverState = new HostVfdState();
        }
        //      C# -> HostVfdInstallConfig? HostVfdEnabled
        // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
        if (this.HostVfdEnabled == null && ec.Includes("hostVfdEnabled",true))
        {
            this.HostVfdEnabled = new HostVfdInstallConfig();
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (this.AgentId == null && ec.Includes("agentId",true))
        {
            this.AgentId = "FETCH";
        }
        //      C# -> System.Boolean? CompressionEnabled
        // GraphQL -> compressionEnabled: Boolean (scalar)
        if (this.CompressionEnabled == null && ec.Includes("compressionEnabled",true))
        {
            this.CompressionEnabled = true;
        }
        //      C# -> System.String? HostDomainId
        // GraphQL -> hostDomainId: String (scalar)
        if (this.HostDomainId == null && ec.Includes("hostDomainId",true))
        {
            this.HostDomainId = "FETCH";
        }
        //      C# -> System.String? HostDomainName
        // GraphQL -> hostDomainName: String (scalar)
        if (this.HostDomainName == null && ec.Includes("hostDomainName",true))
        {
            this.HostDomainName = "FETCH";
        }
        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean (scalar)
        if (this.IsOracleHost == null && ec.Includes("isOracleHost",true))
        {
            this.IsOracleHost = true;
        }
        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        if (this.IsRefreshPaused == null && ec.Includes("isRefreshPaused",true))
        {
            this.IsRefreshPaused = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && ec.Includes("isRelic",true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.Boolean? MssqlCbtDriverInstalled
        // GraphQL -> mssqlCbtDriverInstalled: Boolean! (scalar)
        if (this.MssqlCbtDriverInstalled == null && ec.Includes("mssqlCbtDriverInstalled",true))
        {
            this.MssqlCbtDriverInstalled = true;
        }
        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        if (this.OracleQueryUser == null && ec.Includes("oracleQueryUser",true))
        {
            this.OracleQueryUser = "FETCH";
        }
        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        if (this.OracleSysDbaUser == null && ec.Includes("oracleSysDbaUser",true))
        {
            this.OracleSysDbaUser = "FETCH";
        }
        //      C# -> HostSummary? HostSummary
        // GraphQL -> hostSummary: HostSummary (type)
        if (this.HostSummary == null && ec.Includes("hostSummary",false))
        {
            this.HostSummary = new HostSummary();
            this.HostSummary.ApplyExploratoryFieldSpec(ec.NewChild("hostSummary"));
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
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<HostDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
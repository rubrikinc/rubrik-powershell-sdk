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

        //      C# -> System.String? MssqlSddCertificateId
        // GraphQL -> mssqlSddCertificateId: String (scalar)
        [JsonProperty("mssqlSddCertificateId")]
        public System.String? MssqlSddCertificateId { get; set; }

        //      C# -> System.String? MssqlSddUsername
        // GraphQL -> mssqlSddUsername: String (scalar)
        [JsonProperty("mssqlSddUsername")]
        public System.String? MssqlSddUsername { get; set; }

        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        [JsonProperty("oracleQueryUser")]
        public System.String? OracleQueryUser { get; set; }

        //      C# -> System.String? OracleSddUsername
        // GraphQL -> oracleSddUsername: String (scalar)
        [JsonProperty("oracleSddUsername")]
        public System.String? OracleSddUsername { get; set; }

        //      C# -> System.String? OracleSddWalletPath
        // GraphQL -> oracleSddWalletPath: String (scalar)
        [JsonProperty("oracleSddWalletPath")]
        public System.String? OracleSddWalletPath { get; set; }

        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        [JsonProperty("oracleSysDbaUser")]
        public System.String? OracleSysDbaUser { get; set; }

        //      C# -> ActiveDirectoryAdditionalInfo? ActiveDirectoryAdditionalInfo
        // GraphQL -> activeDirectoryAdditionalInfo: ActiveDirectoryAdditionalInfo (type)
        [JsonProperty("activeDirectoryAdditionalInfo")]
        public ActiveDirectoryAdditionalInfo? ActiveDirectoryAdditionalInfo { get; set; }

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
        System.String? MssqlSddCertificateId = null,
        System.String? MssqlSddUsername = null,
        System.String? OracleQueryUser = null,
        System.String? OracleSddUsername = null,
        System.String? OracleSddWalletPath = null,
        System.String? OracleSysDbaUser = null,
        ActiveDirectoryAdditionalInfo? ActiveDirectoryAdditionalInfo = null,
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
        if ( MssqlSddCertificateId != null ) {
            this.MssqlSddCertificateId = MssqlSddCertificateId;
        }
        if ( MssqlSddUsername != null ) {
            this.MssqlSddUsername = MssqlSddUsername;
        }
        if ( OracleQueryUser != null ) {
            this.OracleQueryUser = OracleQueryUser;
        }
        if ( OracleSddUsername != null ) {
            this.OracleSddUsername = OracleSddUsername;
        }
        if ( OracleSddWalletPath != null ) {
            this.OracleSddWalletPath = OracleSddWalletPath;
        }
        if ( OracleSysDbaUser != null ) {
            this.OracleSysDbaUser = OracleSysDbaUser;
        }
        if ( ActiveDirectoryAdditionalInfo != null ) {
            this.ActiveDirectoryAdditionalInfo = ActiveDirectoryAdditionalInfo;
        }
        if ( HostSummary != null ) {
            this.HostSummary = HostSummary;
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
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (this.HostVfdDriverState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostVfdDriverState\n" ;
            } else {
                s += ind + "hostVfdDriverState\n" ;
            }
        }
        //      C# -> HostVfdInstallConfig? HostVfdEnabled
        // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
        if (this.HostVfdEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostVfdEnabled\n" ;
            } else {
                s += ind + "hostVfdEnabled\n" ;
            }
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (this.AgentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "agentId\n" ;
            } else {
                s += ind + "agentId\n" ;
            }
        }
        //      C# -> System.Boolean? CompressionEnabled
        // GraphQL -> compressionEnabled: Boolean (scalar)
        if (this.CompressionEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "compressionEnabled\n" ;
            } else {
                s += ind + "compressionEnabled\n" ;
            }
        }
        //      C# -> System.String? HostDomainId
        // GraphQL -> hostDomainId: String (scalar)
        if (this.HostDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostDomainId\n" ;
            } else {
                s += ind + "hostDomainId\n" ;
            }
        }
        //      C# -> System.String? HostDomainName
        // GraphQL -> hostDomainName: String (scalar)
        if (this.HostDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostDomainName\n" ;
            } else {
                s += ind + "hostDomainName\n" ;
            }
        }
        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean (scalar)
        if (this.IsOracleHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOracleHost\n" ;
            } else {
                s += ind + "isOracleHost\n" ;
            }
        }
        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        if (this.IsRefreshPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRefreshPaused\n" ;
            } else {
                s += ind + "isRefreshPaused\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.Boolean? MssqlCbtDriverInstalled
        // GraphQL -> mssqlCbtDriverInstalled: Boolean! (scalar)
        if (this.MssqlCbtDriverInstalled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlCbtDriverInstalled\n" ;
            } else {
                s += ind + "mssqlCbtDriverInstalled\n" ;
            }
        }
        //      C# -> System.String? MssqlSddCertificateId
        // GraphQL -> mssqlSddCertificateId: String (scalar)
        if (this.MssqlSddCertificateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlSddCertificateId\n" ;
            } else {
                s += ind + "mssqlSddCertificateId\n" ;
            }
        }
        //      C# -> System.String? MssqlSddUsername
        // GraphQL -> mssqlSddUsername: String (scalar)
        if (this.MssqlSddUsername != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlSddUsername\n" ;
            } else {
                s += ind + "mssqlSddUsername\n" ;
            }
        }
        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        if (this.OracleQueryUser != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oracleQueryUser\n" ;
            } else {
                s += ind + "oracleQueryUser\n" ;
            }
        }
        //      C# -> System.String? OracleSddUsername
        // GraphQL -> oracleSddUsername: String (scalar)
        if (this.OracleSddUsername != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oracleSddUsername\n" ;
            } else {
                s += ind + "oracleSddUsername\n" ;
            }
        }
        //      C# -> System.String? OracleSddWalletPath
        // GraphQL -> oracleSddWalletPath: String (scalar)
        if (this.OracleSddWalletPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oracleSddWalletPath\n" ;
            } else {
                s += ind + "oracleSddWalletPath\n" ;
            }
        }
        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        if (this.OracleSysDbaUser != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oracleSysDbaUser\n" ;
            } else {
                s += ind + "oracleSysDbaUser\n" ;
            }
        }
        //      C# -> ActiveDirectoryAdditionalInfo? ActiveDirectoryAdditionalInfo
        // GraphQL -> activeDirectoryAdditionalInfo: ActiveDirectoryAdditionalInfo (type)
        if (this.ActiveDirectoryAdditionalInfo != null) {
            var fspec = this.ActiveDirectoryAdditionalInfo.AsFieldSpec(conf.Child("activeDirectoryAdditionalInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activeDirectoryAdditionalInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HostSummary? HostSummary
        // GraphQL -> hostSummary: HostSummary (type)
        if (this.HostSummary != null) {
            var fspec = this.HostSummary.AsFieldSpec(conf.Child("hostSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (ec.Includes("hostVfdDriverState",true))
        {
            if(this.HostVfdDriverState == null) {

                this.HostVfdDriverState = new HostVfdState();

            } else {


            }
        }
        else if (this.HostVfdDriverState != null && ec.Excludes("hostVfdDriverState",true))
        {
            this.HostVfdDriverState = null;
        }
        //      C# -> HostVfdInstallConfig? HostVfdEnabled
        // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
        if (ec.Includes("hostVfdEnabled",true))
        {
            if(this.HostVfdEnabled == null) {

                this.HostVfdEnabled = new HostVfdInstallConfig();

            } else {


            }
        }
        else if (this.HostVfdEnabled != null && ec.Excludes("hostVfdEnabled",true))
        {
            this.HostVfdEnabled = null;
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (ec.Includes("agentId",true))
        {
            if(this.AgentId == null) {

                this.AgentId = "FETCH";

            } else {


            }
        }
        else if (this.AgentId != null && ec.Excludes("agentId",true))
        {
            this.AgentId = null;
        }
        //      C# -> System.Boolean? CompressionEnabled
        // GraphQL -> compressionEnabled: Boolean (scalar)
        if (ec.Includes("compressionEnabled",true))
        {
            if(this.CompressionEnabled == null) {

                this.CompressionEnabled = true;

            } else {


            }
        }
        else if (this.CompressionEnabled != null && ec.Excludes("compressionEnabled",true))
        {
            this.CompressionEnabled = null;
        }
        //      C# -> System.String? HostDomainId
        // GraphQL -> hostDomainId: String (scalar)
        if (ec.Includes("hostDomainId",true))
        {
            if(this.HostDomainId == null) {

                this.HostDomainId = "FETCH";

            } else {


            }
        }
        else if (this.HostDomainId != null && ec.Excludes("hostDomainId",true))
        {
            this.HostDomainId = null;
        }
        //      C# -> System.String? HostDomainName
        // GraphQL -> hostDomainName: String (scalar)
        if (ec.Includes("hostDomainName",true))
        {
            if(this.HostDomainName == null) {

                this.HostDomainName = "FETCH";

            } else {


            }
        }
        else if (this.HostDomainName != null && ec.Excludes("hostDomainName",true))
        {
            this.HostDomainName = null;
        }
        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean (scalar)
        if (ec.Includes("isOracleHost",true))
        {
            if(this.IsOracleHost == null) {

                this.IsOracleHost = true;

            } else {


            }
        }
        else if (this.IsOracleHost != null && ec.Excludes("isOracleHost",true))
        {
            this.IsOracleHost = null;
        }
        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        if (ec.Includes("isRefreshPaused",true))
        {
            if(this.IsRefreshPaused == null) {

                this.IsRefreshPaused = true;

            } else {


            }
        }
        else if (this.IsRefreshPaused != null && ec.Excludes("isRefreshPaused",true))
        {
            this.IsRefreshPaused = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.Boolean? MssqlCbtDriverInstalled
        // GraphQL -> mssqlCbtDriverInstalled: Boolean! (scalar)
        if (ec.Includes("mssqlCbtDriverInstalled",true))
        {
            if(this.MssqlCbtDriverInstalled == null) {

                this.MssqlCbtDriverInstalled = true;

            } else {


            }
        }
        else if (this.MssqlCbtDriverInstalled != null && ec.Excludes("mssqlCbtDriverInstalled",true))
        {
            this.MssqlCbtDriverInstalled = null;
        }
        //      C# -> System.String? MssqlSddCertificateId
        // GraphQL -> mssqlSddCertificateId: String (scalar)
        if (ec.Includes("mssqlSddCertificateId",true))
        {
            if(this.MssqlSddCertificateId == null) {

                this.MssqlSddCertificateId = "FETCH";

            } else {


            }
        }
        else if (this.MssqlSddCertificateId != null && ec.Excludes("mssqlSddCertificateId",true))
        {
            this.MssqlSddCertificateId = null;
        }
        //      C# -> System.String? MssqlSddUsername
        // GraphQL -> mssqlSddUsername: String (scalar)
        if (ec.Includes("mssqlSddUsername",true))
        {
            if(this.MssqlSddUsername == null) {

                this.MssqlSddUsername = "FETCH";

            } else {


            }
        }
        else if (this.MssqlSddUsername != null && ec.Excludes("mssqlSddUsername",true))
        {
            this.MssqlSddUsername = null;
        }
        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        if (ec.Includes("oracleQueryUser",true))
        {
            if(this.OracleQueryUser == null) {

                this.OracleQueryUser = "FETCH";

            } else {


            }
        }
        else if (this.OracleQueryUser != null && ec.Excludes("oracleQueryUser",true))
        {
            this.OracleQueryUser = null;
        }
        //      C# -> System.String? OracleSddUsername
        // GraphQL -> oracleSddUsername: String (scalar)
        if (ec.Includes("oracleSddUsername",true))
        {
            if(this.OracleSddUsername == null) {

                this.OracleSddUsername = "FETCH";

            } else {


            }
        }
        else if (this.OracleSddUsername != null && ec.Excludes("oracleSddUsername",true))
        {
            this.OracleSddUsername = null;
        }
        //      C# -> System.String? OracleSddWalletPath
        // GraphQL -> oracleSddWalletPath: String (scalar)
        if (ec.Includes("oracleSddWalletPath",true))
        {
            if(this.OracleSddWalletPath == null) {

                this.OracleSddWalletPath = "FETCH";

            } else {


            }
        }
        else if (this.OracleSddWalletPath != null && ec.Excludes("oracleSddWalletPath",true))
        {
            this.OracleSddWalletPath = null;
        }
        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        if (ec.Includes("oracleSysDbaUser",true))
        {
            if(this.OracleSysDbaUser == null) {

                this.OracleSysDbaUser = "FETCH";

            } else {


            }
        }
        else if (this.OracleSysDbaUser != null && ec.Excludes("oracleSysDbaUser",true))
        {
            this.OracleSysDbaUser = null;
        }
        //      C# -> ActiveDirectoryAdditionalInfo? ActiveDirectoryAdditionalInfo
        // GraphQL -> activeDirectoryAdditionalInfo: ActiveDirectoryAdditionalInfo (type)
        if (ec.Includes("activeDirectoryAdditionalInfo",false))
        {
            if(this.ActiveDirectoryAdditionalInfo == null) {

                this.ActiveDirectoryAdditionalInfo = new ActiveDirectoryAdditionalInfo();
                this.ActiveDirectoryAdditionalInfo.ApplyExploratoryFieldSpec(ec.NewChild("activeDirectoryAdditionalInfo"));

            } else {

                this.ActiveDirectoryAdditionalInfo.ApplyExploratoryFieldSpec(ec.NewChild("activeDirectoryAdditionalInfo"));

            }
        }
        else if (this.ActiveDirectoryAdditionalInfo != null && ec.Excludes("activeDirectoryAdditionalInfo",false))
        {
            this.ActiveDirectoryAdditionalInfo = null;
        }
        //      C# -> HostSummary? HostSummary
        // GraphQL -> hostSummary: HostSummary (type)
        if (ec.Includes("hostSummary",false))
        {
            if(this.HostSummary == null) {

                this.HostSummary = new HostSummary();
                this.HostSummary.ApplyExploratoryFieldSpec(ec.NewChild("hostSummary"));

            } else {

                this.HostSummary.ApplyExploratoryFieldSpec(ec.NewChild("hostSummary"));

            }
        }
        else if (this.HostSummary != null && ec.Excludes("hostSummary",false))
        {
            this.HostSummary = null;
        }
    }


    #endregion

    } // class HostDetail
    
    #endregion

    public static class ListHostDetailExtensions
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
            this List<HostDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HostDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HostDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HostDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
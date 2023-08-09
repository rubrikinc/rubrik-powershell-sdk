// HostSummary.cs
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
    #region HostSummary
    public class HostSummary: BaseType
    {
        #region members

        //      C# -> MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus
        // GraphQL -> mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType (enum)
        [JsonProperty("mssqlCbtEffectiveStatus")]
        public MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus { get; set; }

        //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
        // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
        [JsonProperty("mssqlCbtEnabled")]
        public MssqlCbtStatusType? MssqlCbtEnabled { get; set; }

        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        [JsonProperty("alias")]
        public System.String? Alias { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        [JsonProperty("isRefreshPaused")]
        public System.Boolean? IsRefreshPaused { get; set; }

        //      C# -> System.Int64? LastRefreshTimeStamp
        // GraphQL -> lastRefreshTimeStamp: Long (scalar)
        [JsonProperty("lastRefreshTimeStamp")]
        public System.Int64? LastRefreshTimeStamp { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        [JsonProperty("operatingSystem")]
        public System.String? OperatingSystem { get; set; }

        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        [JsonProperty("operatingSystemType")]
        public System.String? OperatingSystemType { get; set; }

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String (scalar)
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }

        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String (scalar)
        [JsonProperty("organizationName")]
        public System.String? OrganizationName { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> HdfsBaseConfig? HdfsBaseConfig
        // GraphQL -> hdfsBaseConfig: HdfsBaseConfig (type)
        [JsonProperty("hdfsBaseConfig")]
        public HdfsBaseConfig? HdfsBaseConfig { get; set; }

        //      C# -> NasBaseConfig? NasBaseConfig
        // GraphQL -> nasBaseConfig: NasBaseConfig (type)
        [JsonProperty("nasBaseConfig")]
        public NasBaseConfig? NasBaseConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HostSummary";
    }

    public HostSummary Set(
        MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus = null,
        MssqlCbtStatusType? MssqlCbtEnabled = null,
        System.String? Alias = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.Boolean? IsRefreshPaused = null,
        System.Int64? LastRefreshTimeStamp = null,
        System.String? Name = null,
        System.String? OperatingSystem = null,
        System.String? OperatingSystemType = null,
        System.String? OrganizationId = null,
        System.String? OrganizationName = null,
        System.String? PrimaryClusterId = null,
        System.String? Status = null,
        HdfsBaseConfig? HdfsBaseConfig = null,
        NasBaseConfig? NasBaseConfig = null
    ) 
    {
        if ( MssqlCbtEffectiveStatus != null ) {
            this.MssqlCbtEffectiveStatus = MssqlCbtEffectiveStatus;
        }
        if ( MssqlCbtEnabled != null ) {
            this.MssqlCbtEnabled = MssqlCbtEnabled;
        }
        if ( Alias != null ) {
            this.Alias = Alias;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRefreshPaused != null ) {
            this.IsRefreshPaused = IsRefreshPaused;
        }
        if ( LastRefreshTimeStamp != null ) {
            this.LastRefreshTimeStamp = LastRefreshTimeStamp;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OperatingSystem != null ) {
            this.OperatingSystem = OperatingSystem;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( OrganizationId != null ) {
            this.OrganizationId = OrganizationId;
        }
        if ( OrganizationName != null ) {
            this.OrganizationName = OrganizationName;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HdfsBaseConfig != null ) {
            this.HdfsBaseConfig = HdfsBaseConfig;
        }
        if ( NasBaseConfig != null ) {
            this.NasBaseConfig = NasBaseConfig;
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
        //      C# -> MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus
        // GraphQL -> mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType (enum)
        if (this.MssqlCbtEffectiveStatus != null) {
            s += ind + "mssqlCbtEffectiveStatus\n" ;
        }
        //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
        // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
        if (this.MssqlCbtEnabled != null) {
            s += ind + "mssqlCbtEnabled\n" ;
        }
        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        if (this.Alias != null) {
            s += ind + "alias\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        if (this.IsRefreshPaused != null) {
            s += ind + "isRefreshPaused\n" ;
        }
        //      C# -> System.Int64? LastRefreshTimeStamp
        // GraphQL -> lastRefreshTimeStamp: Long (scalar)
        if (this.LastRefreshTimeStamp != null) {
            s += ind + "lastRefreshTimeStamp\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        if (this.OperatingSystem != null) {
            s += ind + "operatingSystem\n" ;
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        if (this.OperatingSystemType != null) {
            s += ind + "operatingSystemType\n" ;
        }
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String (scalar)
        if (this.OrganizationId != null) {
            s += ind + "organizationId\n" ;
        }
        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String (scalar)
        if (this.OrganizationName != null) {
            s += ind + "organizationName\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> HdfsBaseConfig? HdfsBaseConfig
        // GraphQL -> hdfsBaseConfig: HdfsBaseConfig (type)
        if (this.HdfsBaseConfig != null) {
            var fspec = this.HdfsBaseConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hdfsBaseConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NasBaseConfig? NasBaseConfig
        // GraphQL -> nasBaseConfig: NasBaseConfig (type)
        if (this.NasBaseConfig != null) {
            var fspec = this.NasBaseConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nasBaseConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus
        // GraphQL -> mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType (enum)
        if (this.MssqlCbtEffectiveStatus == null && Exploration.Includes(parent + ".mssqlCbtEffectiveStatus", true))
        {
            this.MssqlCbtEffectiveStatus = new MssqlCbtEffectiveStatusType();
        }
        //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
        // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
        if (this.MssqlCbtEnabled == null && Exploration.Includes(parent + ".mssqlCbtEnabled", true))
        {
            this.MssqlCbtEnabled = new MssqlCbtStatusType();
        }
        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        if (this.Alias == null && Exploration.Includes(parent + ".alias", true))
        {
            this.Alias = "FETCH";
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        if (this.IsRefreshPaused == null && Exploration.Includes(parent + ".isRefreshPaused", true))
        {
            this.IsRefreshPaused = true;
        }
        //      C# -> System.Int64? LastRefreshTimeStamp
        // GraphQL -> lastRefreshTimeStamp: Long (scalar)
        if (this.LastRefreshTimeStamp == null && Exploration.Includes(parent + ".lastRefreshTimeStamp", true))
        {
            this.LastRefreshTimeStamp = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        if (this.OperatingSystem == null && Exploration.Includes(parent + ".operatingSystem", true))
        {
            this.OperatingSystem = "FETCH";
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType", true))
        {
            this.OperatingSystemType = "FETCH";
        }
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String (scalar)
        if (this.OrganizationId == null && Exploration.Includes(parent + ".organizationId", true))
        {
            this.OrganizationId = "FETCH";
        }
        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String (scalar)
        if (this.OrganizationName == null && Exploration.Includes(parent + ".organizationName", true))
        {
            this.OrganizationName = "FETCH";
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
        //      C# -> HdfsBaseConfig? HdfsBaseConfig
        // GraphQL -> hdfsBaseConfig: HdfsBaseConfig (type)
        if (this.HdfsBaseConfig == null && Exploration.Includes(parent + ".hdfsBaseConfig"))
        {
            this.HdfsBaseConfig = new HdfsBaseConfig();
            this.HdfsBaseConfig.ApplyExploratoryFieldSpec(parent + ".hdfsBaseConfig");
        }
        //      C# -> NasBaseConfig? NasBaseConfig
        // GraphQL -> nasBaseConfig: NasBaseConfig (type)
        if (this.NasBaseConfig == null && Exploration.Includes(parent + ".nasBaseConfig"))
        {
            this.NasBaseConfig = new NasBaseConfig();
            this.NasBaseConfig.ApplyExploratoryFieldSpec(parent + ".nasBaseConfig");
        }
    }


    #endregion

    } // class HostSummary
    
    #endregion

    public static class ListHostSummaryExtensions
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
            this List<HostSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HostSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HostSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
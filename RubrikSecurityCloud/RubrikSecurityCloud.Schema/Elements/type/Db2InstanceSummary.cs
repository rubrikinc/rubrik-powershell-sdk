// Db2InstanceSummary.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region Db2InstanceSummary
    public class Db2InstanceSummary: BaseType
    {
        #region members

        //      C# -> Db2InstanceSummaryStatus? Status
        // GraphQL -> status: Db2InstanceSummaryStatus! (enum)
        [JsonProperty("status")]
        public Db2InstanceSummaryStatus? Status { get; set; }

        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!]! (scalar)
        [JsonProperty("databaseIds")]
        public List<System.String>? DatabaseIds { get; set; }

        //      C# -> List<System.String>? HadrDatabaseIds
        // GraphQL -> hadrDatabaseIds: [String!]! (scalar)
        [JsonProperty("hadrDatabaseIds")]
        public List<System.String>? HadrDatabaseIds { get; set; }

        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [String!]! (scalar)
        [JsonProperty("hostIds")]
        public List<System.String>? HostIds { get; set; }

        //      C# -> List<System.String>? HostNames
        // GraphQL -> hostNames: [String!]! (scalar)
        [JsonProperty("hostNames")]
        public List<System.String>? HostNames { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? LastRefreshTime
        // GraphQL -> lastRefreshTime: String! (scalar)
        [JsonProperty("lastRefreshTime")]
        public System.String? LastRefreshTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: String! (scalar)
        [JsonProperty("primaryClusterUuid")]
        public System.String? PrimaryClusterUuid { get; set; }

        //      C# -> System.String? ProtectionDate
        // GraphQL -> protectionDate: String! (scalar)
        [JsonProperty("protectionDate")]
        public System.String? ProtectionDate { get; set; }

        //      C# -> List<System.String>? RelicDatabaseIds
        // GraphQL -> relicDatabaseIds: [String!]! (scalar)
        [JsonProperty("relicDatabaseIds")]
        public List<System.String>? RelicDatabaseIds { get; set; }

        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        [JsonProperty("slaDomainId")]
        public System.String? SlaDomainId { get; set; }

        //      C# -> System.String? SlaType
        // GraphQL -> slaType: String! (scalar)
        [JsonProperty("slaType")]
        public System.String? SlaType { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }


        #endregion

    #region methods

    public Db2InstanceSummary Set(
        Db2InstanceSummaryStatus? Status = null,
        List<System.String>? DatabaseIds = null,
        List<System.String>? HadrDatabaseIds = null,
        List<System.String>? HostIds = null,
        List<System.String>? HostNames = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.String? LastRefreshTime = null,
        System.String? Name = null,
        System.String? PrimaryClusterUuid = null,
        System.String? ProtectionDate = null,
        List<System.String>? RelicDatabaseIds = null,
        System.String? SlaDomainId = null,
        System.String? SlaType = null,
        System.String? StatusMessage = null,
        System.String? Username = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( DatabaseIds != null ) {
            this.DatabaseIds = DatabaseIds;
        }
        if ( HadrDatabaseIds != null ) {
            this.HadrDatabaseIds = HadrDatabaseIds;
        }
        if ( HostIds != null ) {
            this.HostIds = HostIds;
        }
        if ( HostNames != null ) {
            this.HostNames = HostNames;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterUuid != null ) {
            this.PrimaryClusterUuid = PrimaryClusterUuid;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( RelicDatabaseIds != null ) {
            this.RelicDatabaseIds = RelicDatabaseIds;
        }
        if ( SlaDomainId != null ) {
            this.SlaDomainId = SlaDomainId;
        }
        if ( SlaType != null ) {
            this.SlaType = SlaType;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( Username != null ) {
            this.Username = Username;
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
        //      C# -> Db2InstanceSummaryStatus? Status
        // GraphQL -> status: Db2InstanceSummaryStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!]! (scalar)
        if (this.DatabaseIds != null) {
            s += ind + "databaseIds\n" ;
        }
        //      C# -> List<System.String>? HadrDatabaseIds
        // GraphQL -> hadrDatabaseIds: [String!]! (scalar)
        if (this.HadrDatabaseIds != null) {
            s += ind + "hadrDatabaseIds\n" ;
        }
        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [String!]! (scalar)
        if (this.HostIds != null) {
            s += ind + "hostIds\n" ;
        }
        //      C# -> List<System.String>? HostNames
        // GraphQL -> hostNames: [String!]! (scalar)
        if (this.HostNames != null) {
            s += ind + "hostNames\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.String? LastRefreshTime
        // GraphQL -> lastRefreshTime: String! (scalar)
        if (this.LastRefreshTime != null) {
            s += ind + "lastRefreshTime\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: String! (scalar)
        if (this.PrimaryClusterUuid != null) {
            s += ind + "primaryClusterUuid\n" ;
        }
        //      C# -> System.String? ProtectionDate
        // GraphQL -> protectionDate: String! (scalar)
        if (this.ProtectionDate != null) {
            s += ind + "protectionDate\n" ;
        }
        //      C# -> List<System.String>? RelicDatabaseIds
        // GraphQL -> relicDatabaseIds: [String!]! (scalar)
        if (this.RelicDatabaseIds != null) {
            s += ind + "relicDatabaseIds\n" ;
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId != null) {
            s += ind + "slaDomainId\n" ;
        }
        //      C# -> System.String? SlaType
        // GraphQL -> slaType: String! (scalar)
        if (this.SlaType != null) {
            s += ind + "slaType\n" ;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage != null) {
            s += ind + "statusMessage\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Db2InstanceSummaryStatus? Status
        // GraphQL -> status: Db2InstanceSummaryStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new Db2InstanceSummaryStatus();
        }
        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!]! (scalar)
        if (this.DatabaseIds == null && Exploration.Includes(parent + ".databaseIds", true))
        {
            this.DatabaseIds = new List<System.String>();
        }
        //      C# -> List<System.String>? HadrDatabaseIds
        // GraphQL -> hadrDatabaseIds: [String!]! (scalar)
        if (this.HadrDatabaseIds == null && Exploration.Includes(parent + ".hadrDatabaseIds", true))
        {
            this.HadrDatabaseIds = new List<System.String>();
        }
        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [String!]! (scalar)
        if (this.HostIds == null && Exploration.Includes(parent + ".hostIds", true))
        {
            this.HostIds = new List<System.String>();
        }
        //      C# -> List<System.String>? HostNames
        // GraphQL -> hostNames: [String!]! (scalar)
        if (this.HostNames == null && Exploration.Includes(parent + ".hostNames", true))
        {
            this.HostNames = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.String? LastRefreshTime
        // GraphQL -> lastRefreshTime: String! (scalar)
        if (this.LastRefreshTime == null && Exploration.Includes(parent + ".lastRefreshTime", true))
        {
            this.LastRefreshTime = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: String! (scalar)
        if (this.PrimaryClusterUuid == null && Exploration.Includes(parent + ".primaryClusterUuid", true))
        {
            this.PrimaryClusterUuid = "FETCH";
        }
        //      C# -> System.String? ProtectionDate
        // GraphQL -> protectionDate: String! (scalar)
        if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate", true))
        {
            this.ProtectionDate = "FETCH";
        }
        //      C# -> List<System.String>? RelicDatabaseIds
        // GraphQL -> relicDatabaseIds: [String!]! (scalar)
        if (this.RelicDatabaseIds == null && Exploration.Includes(parent + ".relicDatabaseIds", true))
        {
            this.RelicDatabaseIds = new List<System.String>();
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId == null && Exploration.Includes(parent + ".slaDomainId", true))
        {
            this.SlaDomainId = "FETCH";
        }
        //      C# -> System.String? SlaType
        // GraphQL -> slaType: String! (scalar)
        if (this.SlaType == null && Exploration.Includes(parent + ".slaType", true))
        {
            this.SlaType = "FETCH";
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage == null && Exploration.Includes(parent + ".statusMessage", true))
        {
            this.StatusMessage = "FETCH";
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = "FETCH";
        }
    }


    #endregion

    } // class Db2InstanceSummary
    
    #endregion

    public static class ListDb2InstanceSummaryExtensions
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
            this List<Db2InstanceSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2InstanceSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2InstanceSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
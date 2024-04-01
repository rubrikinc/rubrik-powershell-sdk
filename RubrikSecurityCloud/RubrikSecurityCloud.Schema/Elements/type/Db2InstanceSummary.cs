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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "Db2InstanceSummary";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> Db2InstanceSummaryStatus? Status
        // GraphQL -> status: Db2InstanceSummaryStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!]! (scalar)
        if (this.DatabaseIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseIds\n" ;
            } else {
                s += ind + "databaseIds\n" ;
            }
        }
        //      C# -> List<System.String>? HadrDatabaseIds
        // GraphQL -> hadrDatabaseIds: [String!]! (scalar)
        if (this.HadrDatabaseIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hadrDatabaseIds\n" ;
            } else {
                s += ind + "hadrDatabaseIds\n" ;
            }
        }
        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [String!]! (scalar)
        if (this.HostIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostIds\n" ;
            } else {
                s += ind + "hostIds\n" ;
            }
        }
        //      C# -> List<System.String>? HostNames
        // GraphQL -> hostNames: [String!]! (scalar)
        if (this.HostNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostNames\n" ;
            } else {
                s += ind + "hostNames\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.String? LastRefreshTime
        // GraphQL -> lastRefreshTime: String! (scalar)
        if (this.LastRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshTime\n" ;
            } else {
                s += ind + "lastRefreshTime\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: String! (scalar)
        if (this.PrimaryClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterUuid\n" ;
            } else {
                s += ind + "primaryClusterUuid\n" ;
            }
        }
        //      C# -> System.String? ProtectionDate
        // GraphQL -> protectionDate: String! (scalar)
        if (this.ProtectionDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDate\n" ;
            } else {
                s += ind + "protectionDate\n" ;
            }
        }
        //      C# -> List<System.String>? RelicDatabaseIds
        // GraphQL -> relicDatabaseIds: [String!]! (scalar)
        if (this.RelicDatabaseIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relicDatabaseIds\n" ;
            } else {
                s += ind + "relicDatabaseIds\n" ;
            }
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomainId\n" ;
            } else {
                s += ind + "slaDomainId\n" ;
            }
        }
        //      C# -> System.String? SlaType
        // GraphQL -> slaType: String! (scalar)
        if (this.SlaType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaType\n" ;
            } else {
                s += ind + "slaType\n" ;
            }
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessage\n" ;
            } else {
                s += ind + "statusMessage\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Db2InstanceSummaryStatus? Status
        // GraphQL -> status: Db2InstanceSummaryStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new Db2InstanceSummaryStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!]! (scalar)
        if (ec.Includes("databaseIds",true))
        {
            if(this.DatabaseIds == null) {

                this.DatabaseIds = new List<System.String>();

            } else {


            }
        }
        else if (this.DatabaseIds != null && ec.Excludes("databaseIds",true))
        {
            this.DatabaseIds = null;
        }
        //      C# -> List<System.String>? HadrDatabaseIds
        // GraphQL -> hadrDatabaseIds: [String!]! (scalar)
        if (ec.Includes("hadrDatabaseIds",true))
        {
            if(this.HadrDatabaseIds == null) {

                this.HadrDatabaseIds = new List<System.String>();

            } else {


            }
        }
        else if (this.HadrDatabaseIds != null && ec.Excludes("hadrDatabaseIds",true))
        {
            this.HadrDatabaseIds = null;
        }
        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [String!]! (scalar)
        if (ec.Includes("hostIds",true))
        {
            if(this.HostIds == null) {

                this.HostIds = new List<System.String>();

            } else {


            }
        }
        else if (this.HostIds != null && ec.Excludes("hostIds",true))
        {
            this.HostIds = null;
        }
        //      C# -> List<System.String>? HostNames
        // GraphQL -> hostNames: [String!]! (scalar)
        if (ec.Includes("hostNames",true))
        {
            if(this.HostNames == null) {

                this.HostNames = new List<System.String>();

            } else {


            }
        }
        else if (this.HostNames != null && ec.Excludes("hostNames",true))
        {
            this.HostNames = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.String? LastRefreshTime
        // GraphQL -> lastRefreshTime: String! (scalar)
        if (ec.Includes("lastRefreshTime",true))
        {
            if(this.LastRefreshTime == null) {

                this.LastRefreshTime = "FETCH";

            } else {


            }
        }
        else if (this.LastRefreshTime != null && ec.Excludes("lastRefreshTime",true))
        {
            this.LastRefreshTime = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: String! (scalar)
        if (ec.Includes("primaryClusterUuid",true))
        {
            if(this.PrimaryClusterUuid == null) {

                this.PrimaryClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterUuid != null && ec.Excludes("primaryClusterUuid",true))
        {
            this.PrimaryClusterUuid = null;
        }
        //      C# -> System.String? ProtectionDate
        // GraphQL -> protectionDate: String! (scalar)
        if (ec.Includes("protectionDate",true))
        {
            if(this.ProtectionDate == null) {

                this.ProtectionDate = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDate != null && ec.Excludes("protectionDate",true))
        {
            this.ProtectionDate = null;
        }
        //      C# -> List<System.String>? RelicDatabaseIds
        // GraphQL -> relicDatabaseIds: [String!]! (scalar)
        if (ec.Includes("relicDatabaseIds",true))
        {
            if(this.RelicDatabaseIds == null) {

                this.RelicDatabaseIds = new List<System.String>();

            } else {


            }
        }
        else if (this.RelicDatabaseIds != null && ec.Excludes("relicDatabaseIds",true))
        {
            this.RelicDatabaseIds = null;
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (ec.Includes("slaDomainId",true))
        {
            if(this.SlaDomainId == null) {

                this.SlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.SlaDomainId != null && ec.Excludes("slaDomainId",true))
        {
            this.SlaDomainId = null;
        }
        //      C# -> System.String? SlaType
        // GraphQL -> slaType: String! (scalar)
        if (ec.Includes("slaType",true))
        {
            if(this.SlaType == null) {

                this.SlaType = "FETCH";

            } else {


            }
        }
        else if (this.SlaType != null && ec.Excludes("slaType",true))
        {
            this.SlaType = null;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (ec.Includes("statusMessage",true))
        {
            if(this.StatusMessage == null) {

                this.StatusMessage = "FETCH";

            } else {


            }
        }
        else if (this.StatusMessage != null && ec.Excludes("statusMessage",true))
        {
            this.StatusMessage = null;
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
    }


    #endregion

    } // class Db2InstanceSummary
    
    #endregion

    public static class ListDb2InstanceSummaryExtensions
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
            this List<Db2InstanceSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Db2InstanceSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Db2InstanceSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2InstanceSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Db2InstanceSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
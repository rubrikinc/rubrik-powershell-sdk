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

        //      C# -> HostRbsConnectionStatus? StatusEnum
        // GraphQL -> statusEnum: HostRbsConnectionStatus (enum)
        [JsonProperty("statusEnum")]
        public HostRbsConnectionStatus? StatusEnum { get; set; }

        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        [JsonProperty("agentId")]
        public System.String? AgentId { get; set; }

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

        //      C# -> VolumeGroupDetailInfo? VolumeGroupInfo
        // GraphQL -> volumeGroupInfo: VolumeGroupDetailInfo (type)
        [JsonProperty("volumeGroupInfo")]
        public VolumeGroupDetailInfo? VolumeGroupInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HostSummary";
    }

    public HostSummary Set(
        MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus = null,
        MssqlCbtStatusType? MssqlCbtEnabled = null,
        HostRbsConnectionStatus? StatusEnum = null,
        System.String? AgentId = null,
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
        NasBaseConfig? NasBaseConfig = null,
        VolumeGroupDetailInfo? VolumeGroupInfo = null
    ) 
    {
        if ( MssqlCbtEffectiveStatus != null ) {
            this.MssqlCbtEffectiveStatus = MssqlCbtEffectiveStatus;
        }
        if ( MssqlCbtEnabled != null ) {
            this.MssqlCbtEnabled = MssqlCbtEnabled;
        }
        if ( StatusEnum != null ) {
            this.StatusEnum = StatusEnum;
        }
        if ( AgentId != null ) {
            this.AgentId = AgentId;
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
        if ( VolumeGroupInfo != null ) {
            this.VolumeGroupInfo = VolumeGroupInfo;
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
        //      C# -> MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus
        // GraphQL -> mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType (enum)
        if (this.MssqlCbtEffectiveStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlCbtEffectiveStatus\n" ;
            } else {
                s += ind + "mssqlCbtEffectiveStatus\n" ;
            }
        }
        //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
        // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
        if (this.MssqlCbtEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlCbtEnabled\n" ;
            } else {
                s += ind + "mssqlCbtEnabled\n" ;
            }
        }
        //      C# -> HostRbsConnectionStatus? StatusEnum
        // GraphQL -> statusEnum: HostRbsConnectionStatus (enum)
        if (this.StatusEnum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusEnum\n" ;
            } else {
                s += ind + "statusEnum\n" ;
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
        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        if (this.Alias != null) {
            if (conf.Flat) {
                s += conf.Prefix + "alias\n" ;
            } else {
                s += ind + "alias\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
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
        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        if (this.IsRefreshPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRefreshPaused\n" ;
            } else {
                s += ind + "isRefreshPaused\n" ;
            }
        }
        //      C# -> System.Int64? LastRefreshTimeStamp
        // GraphQL -> lastRefreshTimeStamp: Long (scalar)
        if (this.LastRefreshTimeStamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshTimeStamp\n" ;
            } else {
                s += ind + "lastRefreshTimeStamp\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        if (this.OperatingSystem != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystem\n" ;
            } else {
                s += ind + "operatingSystem\n" ;
            }
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        if (this.OperatingSystemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystemType\n" ;
            } else {
                s += ind + "operatingSystemType\n" ;
            }
        }
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String (scalar)
        if (this.OrganizationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organizationId\n" ;
            } else {
                s += ind + "organizationId\n" ;
            }
        }
        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String (scalar)
        if (this.OrganizationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organizationName\n" ;
            } else {
                s += ind + "organizationName\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> HdfsBaseConfig? HdfsBaseConfig
        // GraphQL -> hdfsBaseConfig: HdfsBaseConfig (type)
        if (this.HdfsBaseConfig != null) {
            var fspec = this.HdfsBaseConfig.AsFieldSpec(conf.Child("hdfsBaseConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hdfsBaseConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NasBaseConfig? NasBaseConfig
        // GraphQL -> nasBaseConfig: NasBaseConfig (type)
        if (this.NasBaseConfig != null) {
            var fspec = this.NasBaseConfig.AsFieldSpec(conf.Child("nasBaseConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nasBaseConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VolumeGroupDetailInfo? VolumeGroupInfo
        // GraphQL -> volumeGroupInfo: VolumeGroupDetailInfo (type)
        if (this.VolumeGroupInfo != null) {
            var fspec = this.VolumeGroupInfo.AsFieldSpec(conf.Child("volumeGroupInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumeGroupInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> MssqlCbtEffectiveStatusType? MssqlCbtEffectiveStatus
        // GraphQL -> mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType (enum)
        if (ec.Includes("mssqlCbtEffectiveStatus",true))
        {
            if(this.MssqlCbtEffectiveStatus == null) {

                this.MssqlCbtEffectiveStatus = new MssqlCbtEffectiveStatusType();

            } else {


            }
        }
        else if (this.MssqlCbtEffectiveStatus != null && ec.Excludes("mssqlCbtEffectiveStatus",true))
        {
            this.MssqlCbtEffectiveStatus = null;
        }
        //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
        // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
        if (ec.Includes("mssqlCbtEnabled",true))
        {
            if(this.MssqlCbtEnabled == null) {

                this.MssqlCbtEnabled = new MssqlCbtStatusType();

            } else {


            }
        }
        else if (this.MssqlCbtEnabled != null && ec.Excludes("mssqlCbtEnabled",true))
        {
            this.MssqlCbtEnabled = null;
        }
        //      C# -> HostRbsConnectionStatus? StatusEnum
        // GraphQL -> statusEnum: HostRbsConnectionStatus (enum)
        if (ec.Includes("statusEnum",true))
        {
            if(this.StatusEnum == null) {

                this.StatusEnum = new HostRbsConnectionStatus();

            } else {


            }
        }
        else if (this.StatusEnum != null && ec.Excludes("statusEnum",true))
        {
            this.StatusEnum = null;
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
        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        if (ec.Includes("alias",true))
        {
            if(this.Alias == null) {

                this.Alias = "FETCH";

            } else {


            }
        }
        else if (this.Alias != null && ec.Excludes("alias",true))
        {
            this.Alias = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
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
        //      C# -> System.Int64? LastRefreshTimeStamp
        // GraphQL -> lastRefreshTimeStamp: Long (scalar)
        if (ec.Includes("lastRefreshTimeStamp",true))
        {
            if(this.LastRefreshTimeStamp == null) {

                this.LastRefreshTimeStamp = new System.Int64();

            } else {


            }
        }
        else if (this.LastRefreshTimeStamp != null && ec.Excludes("lastRefreshTimeStamp",true))
        {
            this.LastRefreshTimeStamp = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
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
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        if (ec.Includes("operatingSystem",true))
        {
            if(this.OperatingSystem == null) {

                this.OperatingSystem = "FETCH";

            } else {


            }
        }
        else if (this.OperatingSystem != null && ec.Excludes("operatingSystem",true))
        {
            this.OperatingSystem = null;
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        if (ec.Includes("operatingSystemType",true))
        {
            if(this.OperatingSystemType == null) {

                this.OperatingSystemType = "FETCH";

            } else {


            }
        }
        else if (this.OperatingSystemType != null && ec.Excludes("operatingSystemType",true))
        {
            this.OperatingSystemType = null;
        }
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String (scalar)
        if (ec.Includes("organizationId",true))
        {
            if(this.OrganizationId == null) {

                this.OrganizationId = "FETCH";

            } else {


            }
        }
        else if (this.OrganizationId != null && ec.Excludes("organizationId",true))
        {
            this.OrganizationId = null;
        }
        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String (scalar)
        if (ec.Includes("organizationName",true))
        {
            if(this.OrganizationName == null) {

                this.OrganizationName = "FETCH";

            } else {


            }
        }
        else if (this.OrganizationName != null && ec.Excludes("organizationName",true))
        {
            this.OrganizationName = null;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> HdfsBaseConfig? HdfsBaseConfig
        // GraphQL -> hdfsBaseConfig: HdfsBaseConfig (type)
        if (ec.Includes("hdfsBaseConfig",false))
        {
            if(this.HdfsBaseConfig == null) {

                this.HdfsBaseConfig = new HdfsBaseConfig();
                this.HdfsBaseConfig.ApplyExploratoryFieldSpec(ec.NewChild("hdfsBaseConfig"));

            } else {

                this.HdfsBaseConfig.ApplyExploratoryFieldSpec(ec.NewChild("hdfsBaseConfig"));

            }
        }
        else if (this.HdfsBaseConfig != null && ec.Excludes("hdfsBaseConfig",false))
        {
            this.HdfsBaseConfig = null;
        }
        //      C# -> NasBaseConfig? NasBaseConfig
        // GraphQL -> nasBaseConfig: NasBaseConfig (type)
        if (ec.Includes("nasBaseConfig",false))
        {
            if(this.NasBaseConfig == null) {

                this.NasBaseConfig = new NasBaseConfig();
                this.NasBaseConfig.ApplyExploratoryFieldSpec(ec.NewChild("nasBaseConfig"));

            } else {

                this.NasBaseConfig.ApplyExploratoryFieldSpec(ec.NewChild("nasBaseConfig"));

            }
        }
        else if (this.NasBaseConfig != null && ec.Excludes("nasBaseConfig",false))
        {
            this.NasBaseConfig = null;
        }
        //      C# -> VolumeGroupDetailInfo? VolumeGroupInfo
        // GraphQL -> volumeGroupInfo: VolumeGroupDetailInfo (type)
        if (ec.Includes("volumeGroupInfo",false))
        {
            if(this.VolumeGroupInfo == null) {

                this.VolumeGroupInfo = new VolumeGroupDetailInfo();
                this.VolumeGroupInfo.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupInfo"));

            } else {

                this.VolumeGroupInfo.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupInfo"));

            }
        }
        else if (this.VolumeGroupInfo != null && ec.Excludes("volumeGroupInfo",false))
        {
            this.VolumeGroupInfo = null;
        }
    }


    #endregion

    } // class HostSummary
    
    #endregion

    public static class ListHostSummaryExtensions
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
            this List<HostSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HostSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HostSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HostSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
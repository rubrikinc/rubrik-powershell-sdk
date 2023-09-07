// AzureO365ExocomputeCluster.cs
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
    #region AzureO365ExocomputeCluster
    public class AzureO365ExocomputeCluster: BaseType
    {
        #region members

        //      C# -> O365AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: O365AzureCloudType! (enum)
        [JsonProperty("azureCloudType")]
        public O365AzureCloudType? AzureCloudType { get; set; }

        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        [JsonProperty("hostType")]
        public AzureHostType? HostType { get; set; }

        //      C# -> AzureHostType? KmsHostType
        // GraphQL -> kmsHostType: AzureHostType! (enum)
        [JsonProperty("kmsHostType")]
        public AzureHostType? KmsHostType { get; set; }

        //      C# -> SaasFeature? SaasFeature
        // GraphQL -> saasFeature: SaasFeature! (enum)
        [JsonProperty("saasFeature")]
        public SaasFeature? SaasFeature { get; set; }

        //      C# -> System.String? AcrId
        // GraphQL -> acrId: String! (scalar)
        [JsonProperty("acrId")]
        public System.String? AcrId { get; set; }

        //      C# -> System.String? AksId
        // GraphQL -> aksId: String! (scalar)
        [JsonProperty("aksId")]
        public System.String? AksId { get; set; }

        //      C# -> System.String? AksVersion
        // GraphQL -> aksVersion: String! (scalar)
        [JsonProperty("aksVersion")]
        public System.String? AksVersion { get; set; }

        //      C# -> System.String? AzureAppId
        // GraphQL -> azureAppId: String! (scalar)
        [JsonProperty("azureAppId")]
        public System.String? AzureAppId { get; set; }

        //      C# -> System.String? ColossusBackupStorageAccountId
        // GraphQL -> colossusBackupStorageAccountId: String! (scalar)
        [JsonProperty("colossusBackupStorageAccountId")]
        public System.String? ColossusBackupStorageAccountId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsProvisioned
        // GraphQL -> isProvisioned: Boolean! (scalar)
        [JsonProperty("isProvisioned")]
        public System.Boolean? IsProvisioned { get; set; }

        //      C# -> DateTime? KekBackupStartTime
        // GraphQL -> kekBackupStartTime: DateTime (scalar)
        [JsonProperty("kekBackupStartTime")]
        public DateTime? KekBackupStartTime { get; set; }

        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        [JsonProperty("kmsId")]
        public System.String? KmsId { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.String? OrgStatus
        // GraphQL -> orgStatus: String! (scalar)
        [JsonProperty("orgStatus")]
        public System.String? OrgStatus { get; set; }

        //      C# -> System.String? OrgTenantId
        // GraphQL -> orgTenantId: String! (scalar)
        [JsonProperty("orgTenantId")]
        public System.String? OrgTenantId { get; set; }

        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        [JsonProperty("polarisAccount")]
        public System.String? PolarisAccount { get; set; }

        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        [JsonProperty("regionName")]
        public System.String? RegionName { get; set; }

        //      C# -> System.String? SetupConfiguration
        // GraphQL -> setupConfiguration: String! (scalar)
        [JsonProperty("setupConfiguration")]
        public System.String? SetupConfiguration { get; set; }

        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String! (scalar)
        [JsonProperty("storageId")]
        public System.String? StorageId { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> ZeusDatabaseIds? DatabaseIds
        // GraphQL -> databaseIds: ZeusDatabaseIds (type)
        [JsonProperty("databaseIds")]
        public ZeusDatabaseIds? DatabaseIds { get; set; }

        //      C# -> KmsSpec? KmsSpec
        // GraphQL -> kmsSpec: KmsSpec (type)
        [JsonProperty("kmsSpec")]
        public KmsSpec? KmsSpec { get; set; }

        //      C# -> ScaleRuntime? ScaleRuntime
        // GraphQL -> scaleRuntime: ScaleRuntime (type)
        [JsonProperty("scaleRuntime")]
        public ScaleRuntime? ScaleRuntime { get; set; }

        //      C# -> ExocomputeStorageAccountIds? StorageIds
        // GraphQL -> storageIds: ExocomputeStorageAccountIds (type)
        [JsonProperty("storageIds")]
        public ExocomputeStorageAccountIds? StorageIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureO365ExocomputeCluster";
    }

    public AzureO365ExocomputeCluster Set(
        O365AzureCloudType? AzureCloudType = null,
        AzureHostType? HostType = null,
        AzureHostType? KmsHostType = null,
        SaasFeature? SaasFeature = null,
        System.String? AcrId = null,
        System.String? AksId = null,
        System.String? AksVersion = null,
        System.String? AzureAppId = null,
        System.String? ColossusBackupStorageAccountId = null,
        System.String? GroupName = null,
        System.String? Id = null,
        System.Boolean? IsProvisioned = null,
        DateTime? KekBackupStartTime = null,
        System.String? KmsId = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.String? OrgStatus = null,
        System.String? OrgTenantId = null,
        System.String? PolarisAccount = null,
        System.String? RegionName = null,
        System.String? SetupConfiguration = null,
        System.String? StorageId = null,
        System.String? SubscriptionId = null,
        System.String? TenantId = null,
        ZeusDatabaseIds? DatabaseIds = null,
        KmsSpec? KmsSpec = null,
        ScaleRuntime? ScaleRuntime = null,
        ExocomputeStorageAccountIds? StorageIds = null
    ) 
    {
        if ( AzureCloudType != null ) {
            this.AzureCloudType = AzureCloudType;
        }
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( KmsHostType != null ) {
            this.KmsHostType = KmsHostType;
        }
        if ( SaasFeature != null ) {
            this.SaasFeature = SaasFeature;
        }
        if ( AcrId != null ) {
            this.AcrId = AcrId;
        }
        if ( AksId != null ) {
            this.AksId = AksId;
        }
        if ( AksVersion != null ) {
            this.AksVersion = AksVersion;
        }
        if ( AzureAppId != null ) {
            this.AzureAppId = AzureAppId;
        }
        if ( ColossusBackupStorageAccountId != null ) {
            this.ColossusBackupStorageAccountId = ColossusBackupStorageAccountId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsProvisioned != null ) {
            this.IsProvisioned = IsProvisioned;
        }
        if ( KekBackupStartTime != null ) {
            this.KekBackupStartTime = KekBackupStartTime;
        }
        if ( KmsId != null ) {
            this.KmsId = KmsId;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( OrgStatus != null ) {
            this.OrgStatus = OrgStatus;
        }
        if ( OrgTenantId != null ) {
            this.OrgTenantId = OrgTenantId;
        }
        if ( PolarisAccount != null ) {
            this.PolarisAccount = PolarisAccount;
        }
        if ( RegionName != null ) {
            this.RegionName = RegionName;
        }
        if ( SetupConfiguration != null ) {
            this.SetupConfiguration = SetupConfiguration;
        }
        if ( StorageId != null ) {
            this.StorageId = StorageId;
        }
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( DatabaseIds != null ) {
            this.DatabaseIds = DatabaseIds;
        }
        if ( KmsSpec != null ) {
            this.KmsSpec = KmsSpec;
        }
        if ( ScaleRuntime != null ) {
            this.ScaleRuntime = ScaleRuntime;
        }
        if ( StorageIds != null ) {
            this.StorageIds = StorageIds;
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
        //      C# -> O365AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: O365AzureCloudType! (enum)
        if (this.AzureCloudType != null) {
            s += ind + "azureCloudType\n" ;
        }
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType != null) {
            s += ind + "hostType\n" ;
        }
        //      C# -> AzureHostType? KmsHostType
        // GraphQL -> kmsHostType: AzureHostType! (enum)
        if (this.KmsHostType != null) {
            s += ind + "kmsHostType\n" ;
        }
        //      C# -> SaasFeature? SaasFeature
        // GraphQL -> saasFeature: SaasFeature! (enum)
        if (this.SaasFeature != null) {
            s += ind + "saasFeature\n" ;
        }
        //      C# -> System.String? AcrId
        // GraphQL -> acrId: String! (scalar)
        if (this.AcrId != null) {
            s += ind + "acrId\n" ;
        }
        //      C# -> System.String? AksId
        // GraphQL -> aksId: String! (scalar)
        if (this.AksId != null) {
            s += ind + "aksId\n" ;
        }
        //      C# -> System.String? AksVersion
        // GraphQL -> aksVersion: String! (scalar)
        if (this.AksVersion != null) {
            s += ind + "aksVersion\n" ;
        }
        //      C# -> System.String? AzureAppId
        // GraphQL -> azureAppId: String! (scalar)
        if (this.AzureAppId != null) {
            s += ind + "azureAppId\n" ;
        }
        //      C# -> System.String? ColossusBackupStorageAccountId
        // GraphQL -> colossusBackupStorageAccountId: String! (scalar)
        if (this.ColossusBackupStorageAccountId != null) {
            s += ind + "colossusBackupStorageAccountId\n" ;
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName != null) {
            s += ind + "groupName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsProvisioned
        // GraphQL -> isProvisioned: Boolean! (scalar)
        if (this.IsProvisioned != null) {
            s += ind + "isProvisioned\n" ;
        }
        //      C# -> DateTime? KekBackupStartTime
        // GraphQL -> kekBackupStartTime: DateTime (scalar)
        if (this.KekBackupStartTime != null) {
            s += ind + "kekBackupStartTime\n" ;
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (this.KmsId != null) {
            s += ind + "kmsId\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName != null) {
            s += ind + "orgName\n" ;
        }
        //      C# -> System.String? OrgStatus
        // GraphQL -> orgStatus: String! (scalar)
        if (this.OrgStatus != null) {
            s += ind + "orgStatus\n" ;
        }
        //      C# -> System.String? OrgTenantId
        // GraphQL -> orgTenantId: String! (scalar)
        if (this.OrgTenantId != null) {
            s += ind + "orgTenantId\n" ;
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (this.PolarisAccount != null) {
            s += ind + "polarisAccount\n" ;
        }
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        if (this.RegionName != null) {
            s += ind + "regionName\n" ;
        }
        //      C# -> System.String? SetupConfiguration
        // GraphQL -> setupConfiguration: String! (scalar)
        if (this.SetupConfiguration != null) {
            s += ind + "setupConfiguration\n" ;
        }
        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String! (scalar)
        if (this.StorageId != null) {
            s += ind + "storageId\n" ;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            s += ind + "subscriptionId\n" ;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            s += ind + "tenantId\n" ;
        }
        //      C# -> ZeusDatabaseIds? DatabaseIds
        // GraphQL -> databaseIds: ZeusDatabaseIds (type)
        if (this.DatabaseIds != null) {
            var fspec = this.DatabaseIds.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "databaseIds {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> KmsSpec? KmsSpec
        // GraphQL -> kmsSpec: KmsSpec (type)
        if (this.KmsSpec != null) {
            var fspec = this.KmsSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "kmsSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ScaleRuntime? ScaleRuntime
        // GraphQL -> scaleRuntime: ScaleRuntime (type)
        if (this.ScaleRuntime != null) {
            var fspec = this.ScaleRuntime.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "scaleRuntime {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ExocomputeStorageAccountIds? StorageIds
        // GraphQL -> storageIds: ExocomputeStorageAccountIds (type)
        if (this.StorageIds != null) {
            var fspec = this.StorageIds.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "storageIds {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: O365AzureCloudType! (enum)
        if (this.AzureCloudType == null && ec.Includes("azureCloudType",true))
        {
            this.AzureCloudType = new O365AzureCloudType();
        }
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType == null && ec.Includes("hostType",true))
        {
            this.HostType = new AzureHostType();
        }
        //      C# -> AzureHostType? KmsHostType
        // GraphQL -> kmsHostType: AzureHostType! (enum)
        if (this.KmsHostType == null && ec.Includes("kmsHostType",true))
        {
            this.KmsHostType = new AzureHostType();
        }
        //      C# -> SaasFeature? SaasFeature
        // GraphQL -> saasFeature: SaasFeature! (enum)
        if (this.SaasFeature == null && ec.Includes("saasFeature",true))
        {
            this.SaasFeature = new SaasFeature();
        }
        //      C# -> System.String? AcrId
        // GraphQL -> acrId: String! (scalar)
        if (this.AcrId == null && ec.Includes("acrId",true))
        {
            this.AcrId = "FETCH";
        }
        //      C# -> System.String? AksId
        // GraphQL -> aksId: String! (scalar)
        if (this.AksId == null && ec.Includes("aksId",true))
        {
            this.AksId = "FETCH";
        }
        //      C# -> System.String? AksVersion
        // GraphQL -> aksVersion: String! (scalar)
        if (this.AksVersion == null && ec.Includes("aksVersion",true))
        {
            this.AksVersion = "FETCH";
        }
        //      C# -> System.String? AzureAppId
        // GraphQL -> azureAppId: String! (scalar)
        if (this.AzureAppId == null && ec.Includes("azureAppId",true))
        {
            this.AzureAppId = "FETCH";
        }
        //      C# -> System.String? ColossusBackupStorageAccountId
        // GraphQL -> colossusBackupStorageAccountId: String! (scalar)
        if (this.ColossusBackupStorageAccountId == null && ec.Includes("colossusBackupStorageAccountId",true))
        {
            this.ColossusBackupStorageAccountId = "FETCH";
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName == null && ec.Includes("groupName",true))
        {
            this.GroupName = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsProvisioned
        // GraphQL -> isProvisioned: Boolean! (scalar)
        if (this.IsProvisioned == null && ec.Includes("isProvisioned",true))
        {
            this.IsProvisioned = true;
        }
        //      C# -> DateTime? KekBackupStartTime
        // GraphQL -> kekBackupStartTime: DateTime (scalar)
        if (this.KekBackupStartTime == null && ec.Includes("kekBackupStartTime",true))
        {
            this.KekBackupStartTime = new DateTime();
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (this.KmsId == null && ec.Includes("kmsId",true))
        {
            this.KmsId = "FETCH";
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && ec.Includes("orgId",true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName == null && ec.Includes("orgName",true))
        {
            this.OrgName = "FETCH";
        }
        //      C# -> System.String? OrgStatus
        // GraphQL -> orgStatus: String! (scalar)
        if (this.OrgStatus == null && ec.Includes("orgStatus",true))
        {
            this.OrgStatus = "FETCH";
        }
        //      C# -> System.String? OrgTenantId
        // GraphQL -> orgTenantId: String! (scalar)
        if (this.OrgTenantId == null && ec.Includes("orgTenantId",true))
        {
            this.OrgTenantId = "FETCH";
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (this.PolarisAccount == null && ec.Includes("polarisAccount",true))
        {
            this.PolarisAccount = "FETCH";
        }
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        if (this.RegionName == null && ec.Includes("regionName",true))
        {
            this.RegionName = "FETCH";
        }
        //      C# -> System.String? SetupConfiguration
        // GraphQL -> setupConfiguration: String! (scalar)
        if (this.SetupConfiguration == null && ec.Includes("setupConfiguration",true))
        {
            this.SetupConfiguration = "FETCH";
        }
        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String! (scalar)
        if (this.StorageId == null && ec.Includes("storageId",true))
        {
            this.StorageId = "FETCH";
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId == null && ec.Includes("subscriptionId",true))
        {
            this.SubscriptionId = "FETCH";
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId == null && ec.Includes("tenantId",true))
        {
            this.TenantId = "FETCH";
        }
        //      C# -> ZeusDatabaseIds? DatabaseIds
        // GraphQL -> databaseIds: ZeusDatabaseIds (type)
        if (this.DatabaseIds == null && ec.Includes("databaseIds",false))
        {
            this.DatabaseIds = new ZeusDatabaseIds();
            this.DatabaseIds.ApplyExploratoryFieldSpec(ec.NewChild("databaseIds"));
        }
        //      C# -> KmsSpec? KmsSpec
        // GraphQL -> kmsSpec: KmsSpec (type)
        if (this.KmsSpec == null && ec.Includes("kmsSpec",false))
        {
            this.KmsSpec = new KmsSpec();
            this.KmsSpec.ApplyExploratoryFieldSpec(ec.NewChild("kmsSpec"));
        }
        //      C# -> ScaleRuntime? ScaleRuntime
        // GraphQL -> scaleRuntime: ScaleRuntime (type)
        if (this.ScaleRuntime == null && ec.Includes("scaleRuntime",false))
        {
            this.ScaleRuntime = new ScaleRuntime();
            this.ScaleRuntime.ApplyExploratoryFieldSpec(ec.NewChild("scaleRuntime"));
        }
        //      C# -> ExocomputeStorageAccountIds? StorageIds
        // GraphQL -> storageIds: ExocomputeStorageAccountIds (type)
        if (this.StorageIds == null && ec.Includes("storageIds",false))
        {
            this.StorageIds = new ExocomputeStorageAccountIds();
            this.StorageIds.ApplyExploratoryFieldSpec(ec.NewChild("storageIds"));
        }
    }


    #endregion

    } // class AzureO365ExocomputeCluster
    
    #endregion

    public static class ListAzureO365ExocomputeClusterExtensions
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
            this List<AzureO365ExocomputeCluster> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureO365ExocomputeCluster> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureO365ExocomputeCluster());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureO365ExocomputeCluster> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
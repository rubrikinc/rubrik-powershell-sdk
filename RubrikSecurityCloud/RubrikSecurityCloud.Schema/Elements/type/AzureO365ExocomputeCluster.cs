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

        //      C# -> List<System.String>? AksLbIps
        // GraphQL -> aksLbIps: [String!]! (scalar)
        [JsonProperty("aksLbIps")]
        public List<System.String>? AksLbIps { get; set; }

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

        //      C# -> System.String? ExocomputeInternalStorageAccountId
        // GraphQL -> exocomputeInternalStorageAccountId: String! (scalar)
        [JsonProperty("exocomputeInternalStorageAccountId")]
        public System.String? ExocomputeInternalStorageAccountId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsOnMultiTenantHost
        // GraphQL -> isOnMultiTenantHost: Boolean! (scalar)
        [JsonProperty("isOnMultiTenantHost")]
        public System.Boolean? IsOnMultiTenantHost { get; set; }

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

        //      C# -> System.Int32? ShardPoolType
        // GraphQL -> shardPoolType: Int! (scalar)
        [JsonProperty("shardPoolType")]
        public System.Int32? ShardPoolType { get; set; }

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

        //      C# -> MultiTenantHostSpec? MultiTenantHostSpec
        // GraphQL -> multiTenantHostSpec: MultiTenantHostSpec (type)
        [JsonProperty("multiTenantHostSpec")]
        public MultiTenantHostSpec? MultiTenantHostSpec { get; set; }

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
        List<System.String>? AksLbIps = null,
        System.String? AksVersion = null,
        System.String? AzureAppId = null,
        System.String? ColossusBackupStorageAccountId = null,
        System.String? ExocomputeInternalStorageAccountId = null,
        System.String? GroupName = null,
        System.String? Id = null,
        System.Boolean? IsOnMultiTenantHost = null,
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
        System.Int32? ShardPoolType = null,
        System.String? StorageId = null,
        System.String? SubscriptionId = null,
        System.String? TenantId = null,
        ZeusDatabaseIds? DatabaseIds = null,
        KmsSpec? KmsSpec = null,
        MultiTenantHostSpec? MultiTenantHostSpec = null,
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
        if ( AksLbIps != null ) {
            this.AksLbIps = AksLbIps;
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
        if ( ExocomputeInternalStorageAccountId != null ) {
            this.ExocomputeInternalStorageAccountId = ExocomputeInternalStorageAccountId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsOnMultiTenantHost != null ) {
            this.IsOnMultiTenantHost = IsOnMultiTenantHost;
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
        if ( ShardPoolType != null ) {
            this.ShardPoolType = ShardPoolType;
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
        if ( MultiTenantHostSpec != null ) {
            this.MultiTenantHostSpec = MultiTenantHostSpec;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> O365AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: O365AzureCloudType! (enum)
        if (this.AzureCloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureCloudType\n" ;
            } else {
                s += ind + "azureCloudType\n" ;
            }
        }
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostType\n" ;
            } else {
                s += ind + "hostType\n" ;
            }
        }
        //      C# -> AzureHostType? KmsHostType
        // GraphQL -> kmsHostType: AzureHostType! (enum)
        if (this.KmsHostType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsHostType\n" ;
            } else {
                s += ind + "kmsHostType\n" ;
            }
        }
        //      C# -> SaasFeature? SaasFeature
        // GraphQL -> saasFeature: SaasFeature! (enum)
        if (this.SaasFeature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "saasFeature\n" ;
            } else {
                s += ind + "saasFeature\n" ;
            }
        }
        //      C# -> System.String? AcrId
        // GraphQL -> acrId: String! (scalar)
        if (this.AcrId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "acrId\n" ;
            } else {
                s += ind + "acrId\n" ;
            }
        }
        //      C# -> System.String? AksId
        // GraphQL -> aksId: String! (scalar)
        if (this.AksId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aksId\n" ;
            } else {
                s += ind + "aksId\n" ;
            }
        }
        //      C# -> List<System.String>? AksLbIps
        // GraphQL -> aksLbIps: [String!]! (scalar)
        if (this.AksLbIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aksLbIps\n" ;
            } else {
                s += ind + "aksLbIps\n" ;
            }
        }
        //      C# -> System.String? AksVersion
        // GraphQL -> aksVersion: String! (scalar)
        if (this.AksVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aksVersion\n" ;
            } else {
                s += ind + "aksVersion\n" ;
            }
        }
        //      C# -> System.String? AzureAppId
        // GraphQL -> azureAppId: String! (scalar)
        if (this.AzureAppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureAppId\n" ;
            } else {
                s += ind + "azureAppId\n" ;
            }
        }
        //      C# -> System.String? ColossusBackupStorageAccountId
        // GraphQL -> colossusBackupStorageAccountId: String! (scalar)
        if (this.ColossusBackupStorageAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "colossusBackupStorageAccountId\n" ;
            } else {
                s += ind + "colossusBackupStorageAccountId\n" ;
            }
        }
        //      C# -> System.String? ExocomputeInternalStorageAccountId
        // GraphQL -> exocomputeInternalStorageAccountId: String! (scalar)
        if (this.ExocomputeInternalStorageAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exocomputeInternalStorageAccountId\n" ;
            } else {
                s += ind + "exocomputeInternalStorageAccountId\n" ;
            }
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupName\n" ;
            } else {
                s += ind + "groupName\n" ;
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
        //      C# -> System.Boolean? IsOnMultiTenantHost
        // GraphQL -> isOnMultiTenantHost: Boolean! (scalar)
        if (this.IsOnMultiTenantHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnMultiTenantHost\n" ;
            } else {
                s += ind + "isOnMultiTenantHost\n" ;
            }
        }
        //      C# -> System.Boolean? IsProvisioned
        // GraphQL -> isProvisioned: Boolean! (scalar)
        if (this.IsProvisioned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isProvisioned\n" ;
            } else {
                s += ind + "isProvisioned\n" ;
            }
        }
        //      C# -> DateTime? KekBackupStartTime
        // GraphQL -> kekBackupStartTime: DateTime (scalar)
        if (this.KekBackupStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kekBackupStartTime\n" ;
            } else {
                s += ind + "kekBackupStartTime\n" ;
            }
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (this.KmsId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsId\n" ;
            } else {
                s += ind + "kmsId\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgName\n" ;
            } else {
                s += ind + "orgName\n" ;
            }
        }
        //      C# -> System.String? OrgStatus
        // GraphQL -> orgStatus: String! (scalar)
        if (this.OrgStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgStatus\n" ;
            } else {
                s += ind + "orgStatus\n" ;
            }
        }
        //      C# -> System.String? OrgTenantId
        // GraphQL -> orgTenantId: String! (scalar)
        if (this.OrgTenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgTenantId\n" ;
            } else {
                s += ind + "orgTenantId\n" ;
            }
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (this.PolarisAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "polarisAccount\n" ;
            } else {
                s += ind + "polarisAccount\n" ;
            }
        }
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        if (this.RegionName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regionName\n" ;
            } else {
                s += ind + "regionName\n" ;
            }
        }
        //      C# -> System.String? SetupConfiguration
        // GraphQL -> setupConfiguration: String! (scalar)
        if (this.SetupConfiguration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "setupConfiguration\n" ;
            } else {
                s += ind + "setupConfiguration\n" ;
            }
        }
        //      C# -> System.Int32? ShardPoolType
        // GraphQL -> shardPoolType: Int! (scalar)
        if (this.ShardPoolType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shardPoolType\n" ;
            } else {
                s += ind + "shardPoolType\n" ;
            }
        }
        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String! (scalar)
        if (this.StorageId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageId\n" ;
            } else {
                s += ind + "storageId\n" ;
            }
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionId\n" ;
            } else {
                s += ind + "subscriptionId\n" ;
            }
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        //      C# -> ZeusDatabaseIds? DatabaseIds
        // GraphQL -> databaseIds: ZeusDatabaseIds (type)
        if (this.DatabaseIds != null) {
            var fspec = this.DatabaseIds.AsFieldSpec(conf.Child("databaseIds"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "databaseIds" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> KmsSpec? KmsSpec
        // GraphQL -> kmsSpec: KmsSpec (type)
        if (this.KmsSpec != null) {
            var fspec = this.KmsSpec.AsFieldSpec(conf.Child("kmsSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "kmsSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MultiTenantHostSpec? MultiTenantHostSpec
        // GraphQL -> multiTenantHostSpec: MultiTenantHostSpec (type)
        if (this.MultiTenantHostSpec != null) {
            var fspec = this.MultiTenantHostSpec.AsFieldSpec(conf.Child("multiTenantHostSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "multiTenantHostSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ScaleRuntime? ScaleRuntime
        // GraphQL -> scaleRuntime: ScaleRuntime (type)
        if (this.ScaleRuntime != null) {
            var fspec = this.ScaleRuntime.AsFieldSpec(conf.Child("scaleRuntime"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "scaleRuntime" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ExocomputeStorageAccountIds? StorageIds
        // GraphQL -> storageIds: ExocomputeStorageAccountIds (type)
        if (this.StorageIds != null) {
            var fspec = this.StorageIds.AsFieldSpec(conf.Child("storageIds"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "storageIds" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: O365AzureCloudType! (enum)
        if (ec.Includes("azureCloudType",true))
        {
            if(this.AzureCloudType == null) {

                this.AzureCloudType = new O365AzureCloudType();

            } else {


            }
        }
        else if (this.AzureCloudType != null && ec.Excludes("azureCloudType",true))
        {
            this.AzureCloudType = null;
        }
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (ec.Includes("hostType",true))
        {
            if(this.HostType == null) {

                this.HostType = new AzureHostType();

            } else {


            }
        }
        else if (this.HostType != null && ec.Excludes("hostType",true))
        {
            this.HostType = null;
        }
        //      C# -> AzureHostType? KmsHostType
        // GraphQL -> kmsHostType: AzureHostType! (enum)
        if (ec.Includes("kmsHostType",true))
        {
            if(this.KmsHostType == null) {

                this.KmsHostType = new AzureHostType();

            } else {


            }
        }
        else if (this.KmsHostType != null && ec.Excludes("kmsHostType",true))
        {
            this.KmsHostType = null;
        }
        //      C# -> SaasFeature? SaasFeature
        // GraphQL -> saasFeature: SaasFeature! (enum)
        if (ec.Includes("saasFeature",true))
        {
            if(this.SaasFeature == null) {

                this.SaasFeature = new SaasFeature();

            } else {


            }
        }
        else if (this.SaasFeature != null && ec.Excludes("saasFeature",true))
        {
            this.SaasFeature = null;
        }
        //      C# -> System.String? AcrId
        // GraphQL -> acrId: String! (scalar)
        if (ec.Includes("acrId",true))
        {
            if(this.AcrId == null) {

                this.AcrId = "FETCH";

            } else {


            }
        }
        else if (this.AcrId != null && ec.Excludes("acrId",true))
        {
            this.AcrId = null;
        }
        //      C# -> System.String? AksId
        // GraphQL -> aksId: String! (scalar)
        if (ec.Includes("aksId",true))
        {
            if(this.AksId == null) {

                this.AksId = "FETCH";

            } else {


            }
        }
        else if (this.AksId != null && ec.Excludes("aksId",true))
        {
            this.AksId = null;
        }
        //      C# -> List<System.String>? AksLbIps
        // GraphQL -> aksLbIps: [String!]! (scalar)
        if (ec.Includes("aksLbIps",true))
        {
            if(this.AksLbIps == null) {

                this.AksLbIps = new List<System.String>();

            } else {


            }
        }
        else if (this.AksLbIps != null && ec.Excludes("aksLbIps",true))
        {
            this.AksLbIps = null;
        }
        //      C# -> System.String? AksVersion
        // GraphQL -> aksVersion: String! (scalar)
        if (ec.Includes("aksVersion",true))
        {
            if(this.AksVersion == null) {

                this.AksVersion = "FETCH";

            } else {


            }
        }
        else if (this.AksVersion != null && ec.Excludes("aksVersion",true))
        {
            this.AksVersion = null;
        }
        //      C# -> System.String? AzureAppId
        // GraphQL -> azureAppId: String! (scalar)
        if (ec.Includes("azureAppId",true))
        {
            if(this.AzureAppId == null) {

                this.AzureAppId = "FETCH";

            } else {


            }
        }
        else if (this.AzureAppId != null && ec.Excludes("azureAppId",true))
        {
            this.AzureAppId = null;
        }
        //      C# -> System.String? ColossusBackupStorageAccountId
        // GraphQL -> colossusBackupStorageAccountId: String! (scalar)
        if (ec.Includes("colossusBackupStorageAccountId",true))
        {
            if(this.ColossusBackupStorageAccountId == null) {

                this.ColossusBackupStorageAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ColossusBackupStorageAccountId != null && ec.Excludes("colossusBackupStorageAccountId",true))
        {
            this.ColossusBackupStorageAccountId = null;
        }
        //      C# -> System.String? ExocomputeInternalStorageAccountId
        // GraphQL -> exocomputeInternalStorageAccountId: String! (scalar)
        if (ec.Includes("exocomputeInternalStorageAccountId",true))
        {
            if(this.ExocomputeInternalStorageAccountId == null) {

                this.ExocomputeInternalStorageAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ExocomputeInternalStorageAccountId != null && ec.Excludes("exocomputeInternalStorageAccountId",true))
        {
            this.ExocomputeInternalStorageAccountId = null;
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (ec.Includes("groupName",true))
        {
            if(this.GroupName == null) {

                this.GroupName = "FETCH";

            } else {


            }
        }
        else if (this.GroupName != null && ec.Excludes("groupName",true))
        {
            this.GroupName = null;
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
        //      C# -> System.Boolean? IsOnMultiTenantHost
        // GraphQL -> isOnMultiTenantHost: Boolean! (scalar)
        if (ec.Includes("isOnMultiTenantHost",true))
        {
            if(this.IsOnMultiTenantHost == null) {

                this.IsOnMultiTenantHost = true;

            } else {


            }
        }
        else if (this.IsOnMultiTenantHost != null && ec.Excludes("isOnMultiTenantHost",true))
        {
            this.IsOnMultiTenantHost = null;
        }
        //      C# -> System.Boolean? IsProvisioned
        // GraphQL -> isProvisioned: Boolean! (scalar)
        if (ec.Includes("isProvisioned",true))
        {
            if(this.IsProvisioned == null) {

                this.IsProvisioned = true;

            } else {


            }
        }
        else if (this.IsProvisioned != null && ec.Excludes("isProvisioned",true))
        {
            this.IsProvisioned = null;
        }
        //      C# -> DateTime? KekBackupStartTime
        // GraphQL -> kekBackupStartTime: DateTime (scalar)
        if (ec.Includes("kekBackupStartTime",true))
        {
            if(this.KekBackupStartTime == null) {

                this.KekBackupStartTime = new DateTime();

            } else {


            }
        }
        else if (this.KekBackupStartTime != null && ec.Excludes("kekBackupStartTime",true))
        {
            this.KekBackupStartTime = null;
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (ec.Includes("kmsId",true))
        {
            if(this.KmsId == null) {

                this.KmsId = "FETCH";

            } else {


            }
        }
        else if (this.KmsId != null && ec.Excludes("kmsId",true))
        {
            this.KmsId = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (ec.Includes("orgName",true))
        {
            if(this.OrgName == null) {

                this.OrgName = "FETCH";

            } else {


            }
        }
        else if (this.OrgName != null && ec.Excludes("orgName",true))
        {
            this.OrgName = null;
        }
        //      C# -> System.String? OrgStatus
        // GraphQL -> orgStatus: String! (scalar)
        if (ec.Includes("orgStatus",true))
        {
            if(this.OrgStatus == null) {

                this.OrgStatus = "FETCH";

            } else {


            }
        }
        else if (this.OrgStatus != null && ec.Excludes("orgStatus",true))
        {
            this.OrgStatus = null;
        }
        //      C# -> System.String? OrgTenantId
        // GraphQL -> orgTenantId: String! (scalar)
        if (ec.Includes("orgTenantId",true))
        {
            if(this.OrgTenantId == null) {

                this.OrgTenantId = "FETCH";

            } else {


            }
        }
        else if (this.OrgTenantId != null && ec.Excludes("orgTenantId",true))
        {
            this.OrgTenantId = null;
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (ec.Includes("polarisAccount",true))
        {
            if(this.PolarisAccount == null) {

                this.PolarisAccount = "FETCH";

            } else {


            }
        }
        else if (this.PolarisAccount != null && ec.Excludes("polarisAccount",true))
        {
            this.PolarisAccount = null;
        }
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        if (ec.Includes("regionName",true))
        {
            if(this.RegionName == null) {

                this.RegionName = "FETCH";

            } else {


            }
        }
        else if (this.RegionName != null && ec.Excludes("regionName",true))
        {
            this.RegionName = null;
        }
        //      C# -> System.String? SetupConfiguration
        // GraphQL -> setupConfiguration: String! (scalar)
        if (ec.Includes("setupConfiguration",true))
        {
            if(this.SetupConfiguration == null) {

                this.SetupConfiguration = "FETCH";

            } else {


            }
        }
        else if (this.SetupConfiguration != null && ec.Excludes("setupConfiguration",true))
        {
            this.SetupConfiguration = null;
        }
        //      C# -> System.Int32? ShardPoolType
        // GraphQL -> shardPoolType: Int! (scalar)
        if (ec.Includes("shardPoolType",true))
        {
            if(this.ShardPoolType == null) {

                this.ShardPoolType = Int32.MinValue;

            } else {


            }
        }
        else if (this.ShardPoolType != null && ec.Excludes("shardPoolType",true))
        {
            this.ShardPoolType = null;
        }
        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String! (scalar)
        if (ec.Includes("storageId",true))
        {
            if(this.StorageId == null) {

                this.StorageId = "FETCH";

            } else {


            }
        }
        else if (this.StorageId != null && ec.Excludes("storageId",true))
        {
            this.StorageId = null;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (ec.Includes("subscriptionId",true))
        {
            if(this.SubscriptionId == null) {

                this.SubscriptionId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionId != null && ec.Excludes("subscriptionId",true))
        {
            this.SubscriptionId = null;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (ec.Includes("tenantId",true))
        {
            if(this.TenantId == null) {

                this.TenantId = "FETCH";

            } else {


            }
        }
        else if (this.TenantId != null && ec.Excludes("tenantId",true))
        {
            this.TenantId = null;
        }
        //      C# -> ZeusDatabaseIds? DatabaseIds
        // GraphQL -> databaseIds: ZeusDatabaseIds (type)
        if (ec.Includes("databaseIds",false))
        {
            if(this.DatabaseIds == null) {

                this.DatabaseIds = new ZeusDatabaseIds();
                this.DatabaseIds.ApplyExploratoryFieldSpec(ec.NewChild("databaseIds"));

            } else {

                this.DatabaseIds.ApplyExploratoryFieldSpec(ec.NewChild("databaseIds"));

            }
        }
        else if (this.DatabaseIds != null && ec.Excludes("databaseIds",false))
        {
            this.DatabaseIds = null;
        }
        //      C# -> KmsSpec? KmsSpec
        // GraphQL -> kmsSpec: KmsSpec (type)
        if (ec.Includes("kmsSpec",false))
        {
            if(this.KmsSpec == null) {

                this.KmsSpec = new KmsSpec();
                this.KmsSpec.ApplyExploratoryFieldSpec(ec.NewChild("kmsSpec"));

            } else {

                this.KmsSpec.ApplyExploratoryFieldSpec(ec.NewChild("kmsSpec"));

            }
        }
        else if (this.KmsSpec != null && ec.Excludes("kmsSpec",false))
        {
            this.KmsSpec = null;
        }
        //      C# -> MultiTenantHostSpec? MultiTenantHostSpec
        // GraphQL -> multiTenantHostSpec: MultiTenantHostSpec (type)
        if (ec.Includes("multiTenantHostSpec",false))
        {
            if(this.MultiTenantHostSpec == null) {

                this.MultiTenantHostSpec = new MultiTenantHostSpec();
                this.MultiTenantHostSpec.ApplyExploratoryFieldSpec(ec.NewChild("multiTenantHostSpec"));

            } else {

                this.MultiTenantHostSpec.ApplyExploratoryFieldSpec(ec.NewChild("multiTenantHostSpec"));

            }
        }
        else if (this.MultiTenantHostSpec != null && ec.Excludes("multiTenantHostSpec",false))
        {
            this.MultiTenantHostSpec = null;
        }
        //      C# -> ScaleRuntime? ScaleRuntime
        // GraphQL -> scaleRuntime: ScaleRuntime (type)
        if (ec.Includes("scaleRuntime",false))
        {
            if(this.ScaleRuntime == null) {

                this.ScaleRuntime = new ScaleRuntime();
                this.ScaleRuntime.ApplyExploratoryFieldSpec(ec.NewChild("scaleRuntime"));

            } else {

                this.ScaleRuntime.ApplyExploratoryFieldSpec(ec.NewChild("scaleRuntime"));

            }
        }
        else if (this.ScaleRuntime != null && ec.Excludes("scaleRuntime",false))
        {
            this.ScaleRuntime = null;
        }
        //      C# -> ExocomputeStorageAccountIds? StorageIds
        // GraphQL -> storageIds: ExocomputeStorageAccountIds (type)
        if (ec.Includes("storageIds",false))
        {
            if(this.StorageIds == null) {

                this.StorageIds = new ExocomputeStorageAccountIds();
                this.StorageIds.ApplyExploratoryFieldSpec(ec.NewChild("storageIds"));

            } else {

                this.StorageIds.ApplyExploratoryFieldSpec(ec.NewChild("storageIds"));

            }
        }
        else if (this.StorageIds != null && ec.Excludes("storageIds",false))
        {
            this.StorageIds = null;
        }
    }


    #endregion

    } // class AzureO365ExocomputeCluster
    
    #endregion

    public static class ListAzureO365ExocomputeClusterExtensions
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
            this List<AzureO365ExocomputeCluster> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureO365ExocomputeCluster> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<AzureO365ExocomputeCluster> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
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

namespace Rubrik.SecurityCloud.Types
{
    #region AzureO365ExocomputeCluster
    public class AzureO365ExocomputeCluster: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public AzureO365ExocomputeCluster Set(
        System.String? AcrId = null,
        System.String? AksId = null,
        System.String? AksVersion = null,
        System.String? AzureAppId = null,
        System.String? GroupName = null,
        System.String? Id = null,
        System.Boolean? IsProvisioned = null,
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
        KmsSpec? KmsSpec = null,
        ScaleRuntime? ScaleRuntime = null,
        ExocomputeStorageAccountIds? StorageIds = null,
        O365AzureCloudType? AzureCloudType = null,
        AzureHostType? HostType = null,
        AzureHostType? KmsHostType = null,
        SaasFeature? SaasFeature = null
    ) 
    {
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
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsProvisioned != null ) {
            this.IsProvisioned = IsProvisioned;
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
        if ( KmsSpec != null ) {
            this.KmsSpec = KmsSpec;
        }
        if ( ScaleRuntime != null ) {
            this.ScaleRuntime = ScaleRuntime;
        }
        if ( StorageIds != null ) {
            this.StorageIds = StorageIds;
        }
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AcrId
            // GraphQL -> acrId: String! (scalar)
            if (this.AcrId != null)
            {
                 s += ind + "acrId\n";

            }
            //      C# -> System.String? AksId
            // GraphQL -> aksId: String! (scalar)
            if (this.AksId != null)
            {
                 s += ind + "aksId\n";

            }
            //      C# -> System.String? AksVersion
            // GraphQL -> aksVersion: String! (scalar)
            if (this.AksVersion != null)
            {
                 s += ind + "aksVersion\n";

            }
            //      C# -> System.String? AzureAppId
            // GraphQL -> azureAppId: String! (scalar)
            if (this.AzureAppId != null)
            {
                 s += ind + "azureAppId\n";

            }
            //      C# -> System.String? GroupName
            // GraphQL -> groupName: String! (scalar)
            if (this.GroupName != null)
            {
                 s += ind + "groupName\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsProvisioned
            // GraphQL -> isProvisioned: Boolean! (scalar)
            if (this.IsProvisioned != null)
            {
                 s += ind + "isProvisioned\n";

            }
            //      C# -> System.String? KmsId
            // GraphQL -> kmsId: String! (scalar)
            if (this.KmsId != null)
            {
                 s += ind + "kmsId\n";

            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId != null)
            {
                 s += ind + "orgId\n";

            }
            //      C# -> System.String? OrgName
            // GraphQL -> orgName: String! (scalar)
            if (this.OrgName != null)
            {
                 s += ind + "orgName\n";

            }
            //      C# -> System.String? OrgStatus
            // GraphQL -> orgStatus: String! (scalar)
            if (this.OrgStatus != null)
            {
                 s += ind + "orgStatus\n";

            }
            //      C# -> System.String? OrgTenantId
            // GraphQL -> orgTenantId: String! (scalar)
            if (this.OrgTenantId != null)
            {
                 s += ind + "orgTenantId\n";

            }
            //      C# -> System.String? PolarisAccount
            // GraphQL -> polarisAccount: String! (scalar)
            if (this.PolarisAccount != null)
            {
                 s += ind + "polarisAccount\n";

            }
            //      C# -> System.String? RegionName
            // GraphQL -> regionName: String! (scalar)
            if (this.RegionName != null)
            {
                 s += ind + "regionName\n";

            }
            //      C# -> System.String? SetupConfiguration
            // GraphQL -> setupConfiguration: String! (scalar)
            if (this.SetupConfiguration != null)
            {
                 s += ind + "setupConfiguration\n";

            }
            //      C# -> System.String? StorageId
            // GraphQL -> storageId: String! (scalar)
            if (this.StorageId != null)
            {
                 s += ind + "storageId\n";

            }
            //      C# -> System.String? SubscriptionId
            // GraphQL -> subscriptionId: String! (scalar)
            if (this.SubscriptionId != null)
            {
                 s += ind + "subscriptionId\n";

            }
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId != null)
            {
                 s += ind + "tenantId\n";

            }
            //      C# -> KmsSpec? KmsSpec
            // GraphQL -> kmsSpec: KmsSpec (type)
            if (this.KmsSpec != null)
            {
                 s += ind + "kmsSpec\n";

                 s += ind + "{\n" + 
                 this.KmsSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ScaleRuntime? ScaleRuntime
            // GraphQL -> scaleRuntime: ScaleRuntime (type)
            if (this.ScaleRuntime != null)
            {
                 s += ind + "scaleRuntime\n";

                 s += ind + "{\n" + 
                 this.ScaleRuntime.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ExocomputeStorageAccountIds? StorageIds
            // GraphQL -> storageIds: ExocomputeStorageAccountIds (type)
            if (this.StorageIds != null)
            {
                 s += ind + "storageIds\n";

                 s += ind + "{\n" + 
                 this.StorageIds.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> O365AzureCloudType? AzureCloudType
            // GraphQL -> azureCloudType: O365AzureCloudType! (enum)
            if (this.AzureCloudType != null)
            {
                 s += ind + "azureCloudType\n";

            }
            //      C# -> AzureHostType? HostType
            // GraphQL -> hostType: AzureHostType! (enum)
            if (this.HostType != null)
            {
                 s += ind + "hostType\n";

            }
            //      C# -> AzureHostType? KmsHostType
            // GraphQL -> kmsHostType: AzureHostType! (enum)
            if (this.KmsHostType != null)
            {
                 s += ind + "kmsHostType\n";

            }
            //      C# -> SaasFeature? SaasFeature
            // GraphQL -> saasFeature: SaasFeature! (enum)
            if (this.SaasFeature != null)
            {
                 s += ind + "saasFeature\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AcrId
            // GraphQL -> acrId: String! (scalar)
            if (this.AcrId == null && Exploration.Includes(parent + ".acrId$"))
            {
                this.AcrId = new System.String("FETCH");
            }
            //      C# -> System.String? AksId
            // GraphQL -> aksId: String! (scalar)
            if (this.AksId == null && Exploration.Includes(parent + ".aksId$"))
            {
                this.AksId = new System.String("FETCH");
            }
            //      C# -> System.String? AksVersion
            // GraphQL -> aksVersion: String! (scalar)
            if (this.AksVersion == null && Exploration.Includes(parent + ".aksVersion$"))
            {
                this.AksVersion = new System.String("FETCH");
            }
            //      C# -> System.String? AzureAppId
            // GraphQL -> azureAppId: String! (scalar)
            if (this.AzureAppId == null && Exploration.Includes(parent + ".azureAppId$"))
            {
                this.AzureAppId = new System.String("FETCH");
            }
            //      C# -> System.String? GroupName
            // GraphQL -> groupName: String! (scalar)
            if (this.GroupName == null && Exploration.Includes(parent + ".groupName$"))
            {
                this.GroupName = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsProvisioned
            // GraphQL -> isProvisioned: Boolean! (scalar)
            if (this.IsProvisioned == null && Exploration.Includes(parent + ".isProvisioned$"))
            {
                this.IsProvisioned = new System.Boolean();
            }
            //      C# -> System.String? KmsId
            // GraphQL -> kmsId: String! (scalar)
            if (this.KmsId == null && Exploration.Includes(parent + ".kmsId$"))
            {
                this.KmsId = new System.String("FETCH");
            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId == null && Exploration.Includes(parent + ".orgId$"))
            {
                this.OrgId = new System.String("FETCH");
            }
            //      C# -> System.String? OrgName
            // GraphQL -> orgName: String! (scalar)
            if (this.OrgName == null && Exploration.Includes(parent + ".orgName$"))
            {
                this.OrgName = new System.String("FETCH");
            }
            //      C# -> System.String? OrgStatus
            // GraphQL -> orgStatus: String! (scalar)
            if (this.OrgStatus == null && Exploration.Includes(parent + ".orgStatus$"))
            {
                this.OrgStatus = new System.String("FETCH");
            }
            //      C# -> System.String? OrgTenantId
            // GraphQL -> orgTenantId: String! (scalar)
            if (this.OrgTenantId == null && Exploration.Includes(parent + ".orgTenantId$"))
            {
                this.OrgTenantId = new System.String("FETCH");
            }
            //      C# -> System.String? PolarisAccount
            // GraphQL -> polarisAccount: String! (scalar)
            if (this.PolarisAccount == null && Exploration.Includes(parent + ".polarisAccount$"))
            {
                this.PolarisAccount = new System.String("FETCH");
            }
            //      C# -> System.String? RegionName
            // GraphQL -> regionName: String! (scalar)
            if (this.RegionName == null && Exploration.Includes(parent + ".regionName$"))
            {
                this.RegionName = new System.String("FETCH");
            }
            //      C# -> System.String? SetupConfiguration
            // GraphQL -> setupConfiguration: String! (scalar)
            if (this.SetupConfiguration == null && Exploration.Includes(parent + ".setupConfiguration$"))
            {
                this.SetupConfiguration = new System.String("FETCH");
            }
            //      C# -> System.String? StorageId
            // GraphQL -> storageId: String! (scalar)
            if (this.StorageId == null && Exploration.Includes(parent + ".storageId$"))
            {
                this.StorageId = new System.String("FETCH");
            }
            //      C# -> System.String? SubscriptionId
            // GraphQL -> subscriptionId: String! (scalar)
            if (this.SubscriptionId == null && Exploration.Includes(parent + ".subscriptionId$"))
            {
                this.SubscriptionId = new System.String("FETCH");
            }
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId == null && Exploration.Includes(parent + ".tenantId$"))
            {
                this.TenantId = new System.String("FETCH");
            }
            //      C# -> KmsSpec? KmsSpec
            // GraphQL -> kmsSpec: KmsSpec (type)
            if (this.KmsSpec == null && Exploration.Includes(parent + ".kmsSpec"))
            {
                this.KmsSpec = new KmsSpec();
                this.KmsSpec.ApplyExploratoryFragment(parent + ".kmsSpec");
            }
            //      C# -> ScaleRuntime? ScaleRuntime
            // GraphQL -> scaleRuntime: ScaleRuntime (type)
            if (this.ScaleRuntime == null && Exploration.Includes(parent + ".scaleRuntime"))
            {
                this.ScaleRuntime = new ScaleRuntime();
                this.ScaleRuntime.ApplyExploratoryFragment(parent + ".scaleRuntime");
            }
            //      C# -> ExocomputeStorageAccountIds? StorageIds
            // GraphQL -> storageIds: ExocomputeStorageAccountIds (type)
            if (this.StorageIds == null && Exploration.Includes(parent + ".storageIds"))
            {
                this.StorageIds = new ExocomputeStorageAccountIds();
                this.StorageIds.ApplyExploratoryFragment(parent + ".storageIds");
            }
            //      C# -> O365AzureCloudType? AzureCloudType
            // GraphQL -> azureCloudType: O365AzureCloudType! (enum)
            if (this.AzureCloudType == null && Exploration.Includes(parent + ".azureCloudType$"))
            {
                this.AzureCloudType = new O365AzureCloudType();
            }
            //      C# -> AzureHostType? HostType
            // GraphQL -> hostType: AzureHostType! (enum)
            if (this.HostType == null && Exploration.Includes(parent + ".hostType$"))
            {
                this.HostType = new AzureHostType();
            }
            //      C# -> AzureHostType? KmsHostType
            // GraphQL -> kmsHostType: AzureHostType! (enum)
            if (this.KmsHostType == null && Exploration.Includes(parent + ".kmsHostType$"))
            {
                this.KmsHostType = new AzureHostType();
            }
            //      C# -> SaasFeature? SaasFeature
            // GraphQL -> saasFeature: SaasFeature! (enum)
            if (this.SaasFeature == null && Exploration.Includes(parent + ".saasFeature$"))
            {
                this.SaasFeature = new SaasFeature();
            }
        }


    #endregion

    } // class AzureO365ExocomputeCluster
    #endregion

    public static class ListAzureO365ExocomputeClusterExtensions
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
            this List<AzureO365ExocomputeCluster> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureO365ExocomputeCluster> list, 
            String parent = "")
        {
            var item = new AzureO365ExocomputeCluster();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
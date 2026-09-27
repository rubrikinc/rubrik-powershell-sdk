// K8sClusterSummary.cs
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
    #region K8sClusterSummary
    public class K8sClusterSummary: BaseType
    {
        #region members

        //      C# -> System.String? BackupSubnetCidr
        // GraphQL -> backupSubnetCidr: String (scalar)
        [JsonProperty("backupSubnetCidr")]
        public System.String? BackupSubnetCidr { get; set; }

        //      C# -> System.String? DataPathTransport
        // GraphQL -> dataPathTransport: String (scalar)
        [JsonProperty("dataPathTransport")]
        public System.String? DataPathTransport { get; set; }

        //      C# -> System.String? Distribution
        // GraphQL -> distribution: String (scalar)
        [JsonProperty("distribution")]
        public System.String? Distribution { get; set; }

        //      C# -> System.String? EffectiveSlaId
        // GraphQL -> effectiveSlaId: String (scalar)
        [JsonProperty("effectiveSlaId")]
        public System.String? EffectiveSlaId { get; set; }

        //      C# -> System.String? EffectiveSlaSource
        // GraphQL -> effectiveSlaSource: String (scalar)
        [JsonProperty("effectiveSlaSource")]
        public System.String? EffectiveSlaSource { get; set; }

        //      C# -> System.String? EffectiveSlaType
        // GraphQL -> effectiveSlaType: String (scalar)
        [JsonProperty("effectiveSlaType")]
        public System.String? EffectiveSlaType { get; set; }

        //      C# -> System.String? HelmStatus
        // GraphQL -> helmStatus: String (scalar)
        [JsonProperty("helmStatus")]
        public System.String? HelmStatus { get; set; }

        //      C# -> System.String? HelmVersion
        // GraphQL -> helmVersion: String (scalar)
        [JsonProperty("helmVersion")]
        public System.String? HelmVersion { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? K8Sversion
        // GraphQL -> k8SVersion: String (scalar)
        [JsonProperty("k8SVersion")]
        public System.String? K8Sversion { get; set; }

        //      C# -> System.String? KubevirtVersion
        // GraphQL -> kubevirtVersion: String (scalar)
        [JsonProperty("kubevirtVersion")]
        public System.String? KubevirtVersion { get; set; }

        //      C# -> System.String? KuprServerProxyPodMultusIp
        // GraphQL -> kuprServerProxyPodMultusIp: String (scalar)
        [JsonProperty("kuprServerProxyPodMultusIp")]
        public System.String? KuprServerProxyPodMultusIp { get; set; }

        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        [JsonProperty("lastRefreshTime")]
        public DateTime? LastRefreshTime { get; set; }

        //      C# -> System.String? LoadbalancerIpDns
        // GraphQL -> loadbalancerIpDns: String (scalar)
        [JsonProperty("loadbalancerIpDns")]
        public System.String? LoadbalancerIpDns { get; set; }

        //      C# -> System.Int32? MaxConcurrentAgents
        // GraphQL -> maxConcurrentAgents: Int (scalar)
        [JsonProperty("maxConcurrentAgents")]
        public System.Int32? MaxConcurrentAgents { get; set; }

        //      C# -> System.Int32? MaxPvcsPerAgent
        // GraphQL -> maxPvcsPerAgent: Int (scalar)
        [JsonProperty("maxPvcsPerAgent")]
        public System.Int32? MaxPvcsPerAgent { get; set; }

        //      C# -> System.String? NadName
        // GraphQL -> nadName: String (scalar)
        [JsonProperty("nadName")]
        public System.String? NadName { get; set; }

        //      C# -> System.String? NadNamespace
        // GraphQL -> nadNamespace: String (scalar)
        [JsonProperty("nadNamespace")]
        public System.String? NadNamespace { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NamespaceCount
        // GraphQL -> namespaceCount: Int (scalar)
        [JsonProperty("namespaceCount")]
        public System.Int32? NamespaceCount { get; set; }

        //      C# -> System.Int32? NumLabels
        // GraphQL -> numLabels: Int (scalar)
        [JsonProperty("numLabels")]
        public System.Int32? NumLabels { get; set; }

        //      C# -> System.Int32? NumProtectionSets
        // GraphQL -> numProtectionSets: Int (scalar)
        [JsonProperty("numProtectionSets")]
        public System.Int32? NumProtectionSets { get; set; }

        //      C# -> System.Int32? NumVms
        // GraphQL -> numVms: Int (scalar)
        [JsonProperty("numVms")]
        public System.Int32? NumVms { get; set; }

        //      C# -> System.String? OnboardingType
        // GraphQL -> onboardingType: String (scalar)
        [JsonProperty("onboardingType")]
        public System.String? OnboardingType { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? PvcGroupingStrategy
        // GraphQL -> pvcGroupingStrategy: String (scalar)
        [JsonProperty("pvcGroupingStrategy")]
        public System.String? PvcGroupingStrategy { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        [JsonProperty("registry")]
        public System.String? Registry { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.String? Transport
        // GraphQL -> transport: String (scalar)
        [JsonProperty("transport")]
        public System.String? Transport { get; set; }

        //      C# -> ServiceAccountInfo? CrdServiceAccountInfo
        // GraphQL -> crdServiceAccountInfo: ServiceAccountInfo (type)
        [JsonProperty("crdServiceAccountInfo")]
        public ServiceAccountInfo? CrdServiceAccountInfo { get; set; }

        //      C# -> KuprServerProxyConfig? KuprServerProxyConfig
        // GraphQL -> kuprServerProxyConfig: KuprServerProxyConfig (type)
        [JsonProperty("kuprServerProxyConfig")]
        public KuprServerProxyConfig? KuprServerProxyConfig { get; set; }

        //      C# -> ServiceAccountInfo? OnboardingServiceAccountInfo
        // GraphQL -> onboardingServiceAccountInfo: ServiceAccountInfo (type)
        [JsonProperty("onboardingServiceAccountInfo")]
        public ServiceAccountInfo? OnboardingServiceAccountInfo { get; set; }

        //      C# -> List<K8sWorkloadComponentSummary>? Workloads
        // GraphQL -> workloads: [K8sWorkloadComponentSummary!]! (type)
        [JsonProperty("workloads")]
        public List<K8sWorkloadComponentSummary>? Workloads { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sClusterSummary";
    }

    public K8sClusterSummary Set(
        System.String? BackupSubnetCidr = null,
        System.String? DataPathTransport = null,
        System.String? Distribution = null,
        System.String? EffectiveSlaId = null,
        System.String? EffectiveSlaSource = null,
        System.String? EffectiveSlaType = null,
        System.String? HelmStatus = null,
        System.String? HelmVersion = null,
        System.String? Id = null,
        System.String? K8Sversion = null,
        System.String? KubevirtVersion = null,
        System.String? KuprServerProxyPodMultusIp = null,
        DateTime? LastRefreshTime = null,
        System.String? LoadbalancerIpDns = null,
        System.Int32? MaxConcurrentAgents = null,
        System.Int32? MaxPvcsPerAgent = null,
        System.String? NadName = null,
        System.String? NadNamespace = null,
        System.String? Name = null,
        System.Int32? NamespaceCount = null,
        System.Int32? NumLabels = null,
        System.Int32? NumProtectionSets = null,
        System.Int32? NumVms = null,
        System.String? OnboardingType = null,
        System.Int32? Port = null,
        System.String? PvcGroupingStrategy = null,
        System.String? Region = null,
        System.String? Registry = null,
        System.String? Status = null,
        System.String? Transport = null,
        ServiceAccountInfo? CrdServiceAccountInfo = null,
        KuprServerProxyConfig? KuprServerProxyConfig = null,
        ServiceAccountInfo? OnboardingServiceAccountInfo = null,
        List<K8sWorkloadComponentSummary>? Workloads = null
    ) 
    {
        if ( BackupSubnetCidr != null ) {
            this.BackupSubnetCidr = BackupSubnetCidr;
        }
        if ( DataPathTransport != null ) {
            this.DataPathTransport = DataPathTransport;
        }
        if ( Distribution != null ) {
            this.Distribution = Distribution;
        }
        if ( EffectiveSlaId != null ) {
            this.EffectiveSlaId = EffectiveSlaId;
        }
        if ( EffectiveSlaSource != null ) {
            this.EffectiveSlaSource = EffectiveSlaSource;
        }
        if ( EffectiveSlaType != null ) {
            this.EffectiveSlaType = EffectiveSlaType;
        }
        if ( HelmStatus != null ) {
            this.HelmStatus = HelmStatus;
        }
        if ( HelmVersion != null ) {
            this.HelmVersion = HelmVersion;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( K8Sversion != null ) {
            this.K8Sversion = K8Sversion;
        }
        if ( KubevirtVersion != null ) {
            this.KubevirtVersion = KubevirtVersion;
        }
        if ( KuprServerProxyPodMultusIp != null ) {
            this.KuprServerProxyPodMultusIp = KuprServerProxyPodMultusIp;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( LoadbalancerIpDns != null ) {
            this.LoadbalancerIpDns = LoadbalancerIpDns;
        }
        if ( MaxConcurrentAgents != null ) {
            this.MaxConcurrentAgents = MaxConcurrentAgents;
        }
        if ( MaxPvcsPerAgent != null ) {
            this.MaxPvcsPerAgent = MaxPvcsPerAgent;
        }
        if ( NadName != null ) {
            this.NadName = NadName;
        }
        if ( NadNamespace != null ) {
            this.NadNamespace = NadNamespace;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NamespaceCount != null ) {
            this.NamespaceCount = NamespaceCount;
        }
        if ( NumLabels != null ) {
            this.NumLabels = NumLabels;
        }
        if ( NumProtectionSets != null ) {
            this.NumProtectionSets = NumProtectionSets;
        }
        if ( NumVms != null ) {
            this.NumVms = NumVms;
        }
        if ( OnboardingType != null ) {
            this.OnboardingType = OnboardingType;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( PvcGroupingStrategy != null ) {
            this.PvcGroupingStrategy = PvcGroupingStrategy;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Registry != null ) {
            this.Registry = Registry;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Transport != null ) {
            this.Transport = Transport;
        }
        if ( CrdServiceAccountInfo != null ) {
            this.CrdServiceAccountInfo = CrdServiceAccountInfo;
        }
        if ( KuprServerProxyConfig != null ) {
            this.KuprServerProxyConfig = KuprServerProxyConfig;
        }
        if ( OnboardingServiceAccountInfo != null ) {
            this.OnboardingServiceAccountInfo = OnboardingServiceAccountInfo;
        }
        if ( Workloads != null ) {
            this.Workloads = Workloads;
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
        //      C# -> System.String? BackupSubnetCidr
        // GraphQL -> backupSubnetCidr: String (scalar)
        if (this.BackupSubnetCidr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupSubnetCidr\n" ;
            } else {
                s += ind + "backupSubnetCidr\n" ;
            }
        }
        //      C# -> System.String? DataPathTransport
        // GraphQL -> dataPathTransport: String (scalar)
        if (this.DataPathTransport != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataPathTransport\n" ;
            } else {
                s += ind + "dataPathTransport\n" ;
            }
        }
        //      C# -> System.String? Distribution
        // GraphQL -> distribution: String (scalar)
        if (this.Distribution != null) {
            if (conf.Flat) {
                s += conf.Prefix + "distribution\n" ;
            } else {
                s += ind + "distribution\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaId
        // GraphQL -> effectiveSlaId: String (scalar)
        if (this.EffectiveSlaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaId\n" ;
            } else {
                s += ind + "effectiveSlaId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaSource
        // GraphQL -> effectiveSlaSource: String (scalar)
        if (this.EffectiveSlaSource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaSource\n" ;
            } else {
                s += ind + "effectiveSlaSource\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaType
        // GraphQL -> effectiveSlaType: String (scalar)
        if (this.EffectiveSlaType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaType\n" ;
            } else {
                s += ind + "effectiveSlaType\n" ;
            }
        }
        //      C# -> System.String? HelmStatus
        // GraphQL -> helmStatus: String (scalar)
        if (this.HelmStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "helmStatus\n" ;
            } else {
                s += ind + "helmStatus\n" ;
            }
        }
        //      C# -> System.String? HelmVersion
        // GraphQL -> helmVersion: String (scalar)
        if (this.HelmVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "helmVersion\n" ;
            } else {
                s += ind + "helmVersion\n" ;
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
        //      C# -> System.String? K8Sversion
        // GraphQL -> k8SVersion: String (scalar)
        if (this.K8Sversion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "k8SVersion\n" ;
            } else {
                s += ind + "k8SVersion\n" ;
            }
        }
        //      C# -> System.String? KubevirtVersion
        // GraphQL -> kubevirtVersion: String (scalar)
        if (this.KubevirtVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kubevirtVersion\n" ;
            } else {
                s += ind + "kubevirtVersion\n" ;
            }
        }
        //      C# -> System.String? KuprServerProxyPodMultusIp
        // GraphQL -> kuprServerProxyPodMultusIp: String (scalar)
        if (this.KuprServerProxyPodMultusIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kuprServerProxyPodMultusIp\n" ;
            } else {
                s += ind + "kuprServerProxyPodMultusIp\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshTime\n" ;
            } else {
                s += ind + "lastRefreshTime\n" ;
            }
        }
        //      C# -> System.String? LoadbalancerIpDns
        // GraphQL -> loadbalancerIpDns: String (scalar)
        if (this.LoadbalancerIpDns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "loadbalancerIpDns\n" ;
            } else {
                s += ind + "loadbalancerIpDns\n" ;
            }
        }
        //      C# -> System.Int32? MaxConcurrentAgents
        // GraphQL -> maxConcurrentAgents: Int (scalar)
        if (this.MaxConcurrentAgents != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxConcurrentAgents\n" ;
            } else {
                s += ind + "maxConcurrentAgents\n" ;
            }
        }
        //      C# -> System.Int32? MaxPvcsPerAgent
        // GraphQL -> maxPvcsPerAgent: Int (scalar)
        if (this.MaxPvcsPerAgent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxPvcsPerAgent\n" ;
            } else {
                s += ind + "maxPvcsPerAgent\n" ;
            }
        }
        //      C# -> System.String? NadName
        // GraphQL -> nadName: String (scalar)
        if (this.NadName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nadName\n" ;
            } else {
                s += ind + "nadName\n" ;
            }
        }
        //      C# -> System.String? NadNamespace
        // GraphQL -> nadNamespace: String (scalar)
        if (this.NadNamespace != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nadNamespace\n" ;
            } else {
                s += ind + "nadNamespace\n" ;
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
        //      C# -> System.Int32? NamespaceCount
        // GraphQL -> namespaceCount: Int (scalar)
        if (this.NamespaceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "namespaceCount\n" ;
            } else {
                s += ind + "namespaceCount\n" ;
            }
        }
        //      C# -> System.Int32? NumLabels
        // GraphQL -> numLabels: Int (scalar)
        if (this.NumLabels != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numLabels\n" ;
            } else {
                s += ind + "numLabels\n" ;
            }
        }
        //      C# -> System.Int32? NumProtectionSets
        // GraphQL -> numProtectionSets: Int (scalar)
        if (this.NumProtectionSets != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numProtectionSets\n" ;
            } else {
                s += ind + "numProtectionSets\n" ;
            }
        }
        //      C# -> System.Int32? NumVms
        // GraphQL -> numVms: Int (scalar)
        if (this.NumVms != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numVms\n" ;
            } else {
                s += ind + "numVms\n" ;
            }
        }
        //      C# -> System.String? OnboardingType
        // GraphQL -> onboardingType: String (scalar)
        if (this.OnboardingType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onboardingType\n" ;
            } else {
                s += ind + "onboardingType\n" ;
            }
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        if (this.Port != null) {
            if (conf.Flat) {
                s += conf.Prefix + "port\n" ;
            } else {
                s += ind + "port\n" ;
            }
        }
        //      C# -> System.String? PvcGroupingStrategy
        // GraphQL -> pvcGroupingStrategy: String (scalar)
        if (this.PvcGroupingStrategy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pvcGroupingStrategy\n" ;
            } else {
                s += ind + "pvcGroupingStrategy\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        if (this.Registry != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registry\n" ;
            } else {
                s += ind + "registry\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Transport
        // GraphQL -> transport: String (scalar)
        if (this.Transport != null) {
            if (conf.Flat) {
                s += conf.Prefix + "transport\n" ;
            } else {
                s += ind + "transport\n" ;
            }
        }
        //      C# -> ServiceAccountInfo? CrdServiceAccountInfo
        // GraphQL -> crdServiceAccountInfo: ServiceAccountInfo (type)
        if (this.CrdServiceAccountInfo != null) {
            var fspec = this.CrdServiceAccountInfo.AsFieldSpec(conf.Child("crdServiceAccountInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crdServiceAccountInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> KuprServerProxyConfig? KuprServerProxyConfig
        // GraphQL -> kuprServerProxyConfig: KuprServerProxyConfig (type)
        if (this.KuprServerProxyConfig != null) {
            var fspec = this.KuprServerProxyConfig.AsFieldSpec(conf.Child("kuprServerProxyConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "kuprServerProxyConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ServiceAccountInfo? OnboardingServiceAccountInfo
        // GraphQL -> onboardingServiceAccountInfo: ServiceAccountInfo (type)
        if (this.OnboardingServiceAccountInfo != null) {
            var fspec = this.OnboardingServiceAccountInfo.AsFieldSpec(conf.Child("onboardingServiceAccountInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onboardingServiceAccountInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<K8sWorkloadComponentSummary>? Workloads
        // GraphQL -> workloads: [K8sWorkloadComponentSummary!]! (type)
        if (this.Workloads != null) {
            var fspec = this.Workloads.AsFieldSpec(conf.Child("workloads"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloads" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? BackupSubnetCidr
        // GraphQL -> backupSubnetCidr: String (scalar)
        if (ec.Includes("backupSubnetCidr",true))
        {
            if(this.BackupSubnetCidr == null) {

                this.BackupSubnetCidr = "FETCH";

            } else {


            }
        }
        else if (this.BackupSubnetCidr != null && ec.Excludes("backupSubnetCidr",true))
        {
            this.BackupSubnetCidr = null;
        }
        //      C# -> System.String? DataPathTransport
        // GraphQL -> dataPathTransport: String (scalar)
        if (ec.Includes("dataPathTransport",true))
        {
            if(this.DataPathTransport == null) {

                this.DataPathTransport = "FETCH";

            } else {


            }
        }
        else if (this.DataPathTransport != null && ec.Excludes("dataPathTransport",true))
        {
            this.DataPathTransport = null;
        }
        //      C# -> System.String? Distribution
        // GraphQL -> distribution: String (scalar)
        if (ec.Includes("distribution",true))
        {
            if(this.Distribution == null) {

                this.Distribution = "FETCH";

            } else {


            }
        }
        else if (this.Distribution != null && ec.Excludes("distribution",true))
        {
            this.Distribution = null;
        }
        //      C# -> System.String? EffectiveSlaId
        // GraphQL -> effectiveSlaId: String (scalar)
        if (ec.Includes("effectiveSlaId",true))
        {
            if(this.EffectiveSlaId == null) {

                this.EffectiveSlaId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaId != null && ec.Excludes("effectiveSlaId",true))
        {
            this.EffectiveSlaId = null;
        }
        //      C# -> System.String? EffectiveSlaSource
        // GraphQL -> effectiveSlaSource: String (scalar)
        if (ec.Includes("effectiveSlaSource",true))
        {
            if(this.EffectiveSlaSource == null) {

                this.EffectiveSlaSource = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaSource != null && ec.Excludes("effectiveSlaSource",true))
        {
            this.EffectiveSlaSource = null;
        }
        //      C# -> System.String? EffectiveSlaType
        // GraphQL -> effectiveSlaType: String (scalar)
        if (ec.Includes("effectiveSlaType",true))
        {
            if(this.EffectiveSlaType == null) {

                this.EffectiveSlaType = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaType != null && ec.Excludes("effectiveSlaType",true))
        {
            this.EffectiveSlaType = null;
        }
        //      C# -> System.String? HelmStatus
        // GraphQL -> helmStatus: String (scalar)
        if (ec.Includes("helmStatus",true))
        {
            if(this.HelmStatus == null) {

                this.HelmStatus = "FETCH";

            } else {


            }
        }
        else if (this.HelmStatus != null && ec.Excludes("helmStatus",true))
        {
            this.HelmStatus = null;
        }
        //      C# -> System.String? HelmVersion
        // GraphQL -> helmVersion: String (scalar)
        if (ec.Includes("helmVersion",true))
        {
            if(this.HelmVersion == null) {

                this.HelmVersion = "FETCH";

            } else {


            }
        }
        else if (this.HelmVersion != null && ec.Excludes("helmVersion",true))
        {
            this.HelmVersion = null;
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
        //      C# -> System.String? K8Sversion
        // GraphQL -> k8SVersion: String (scalar)
        if (ec.Includes("k8SVersion",true))
        {
            if(this.K8Sversion == null) {

                this.K8Sversion = "FETCH";

            } else {


            }
        }
        else if (this.K8Sversion != null && ec.Excludes("k8SVersion",true))
        {
            this.K8Sversion = null;
        }
        //      C# -> System.String? KubevirtVersion
        // GraphQL -> kubevirtVersion: String (scalar)
        if (ec.Includes("kubevirtVersion",true))
        {
            if(this.KubevirtVersion == null) {

                this.KubevirtVersion = "FETCH";

            } else {


            }
        }
        else if (this.KubevirtVersion != null && ec.Excludes("kubevirtVersion",true))
        {
            this.KubevirtVersion = null;
        }
        //      C# -> System.String? KuprServerProxyPodMultusIp
        // GraphQL -> kuprServerProxyPodMultusIp: String (scalar)
        if (ec.Includes("kuprServerProxyPodMultusIp",true))
        {
            if(this.KuprServerProxyPodMultusIp == null) {

                this.KuprServerProxyPodMultusIp = "FETCH";

            } else {


            }
        }
        else if (this.KuprServerProxyPodMultusIp != null && ec.Excludes("kuprServerProxyPodMultusIp",true))
        {
            this.KuprServerProxyPodMultusIp = null;
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (ec.Includes("lastRefreshTime",true))
        {
            if(this.LastRefreshTime == null) {

                this.LastRefreshTime = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshTime != null && ec.Excludes("lastRefreshTime",true))
        {
            this.LastRefreshTime = null;
        }
        //      C# -> System.String? LoadbalancerIpDns
        // GraphQL -> loadbalancerIpDns: String (scalar)
        if (ec.Includes("loadbalancerIpDns",true))
        {
            if(this.LoadbalancerIpDns == null) {

                this.LoadbalancerIpDns = "FETCH";

            } else {


            }
        }
        else if (this.LoadbalancerIpDns != null && ec.Excludes("loadbalancerIpDns",true))
        {
            this.LoadbalancerIpDns = null;
        }
        //      C# -> System.Int32? MaxConcurrentAgents
        // GraphQL -> maxConcurrentAgents: Int (scalar)
        if (ec.Includes("maxConcurrentAgents",true))
        {
            if(this.MaxConcurrentAgents == null) {

                this.MaxConcurrentAgents = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxConcurrentAgents != null && ec.Excludes("maxConcurrentAgents",true))
        {
            this.MaxConcurrentAgents = null;
        }
        //      C# -> System.Int32? MaxPvcsPerAgent
        // GraphQL -> maxPvcsPerAgent: Int (scalar)
        if (ec.Includes("maxPvcsPerAgent",true))
        {
            if(this.MaxPvcsPerAgent == null) {

                this.MaxPvcsPerAgent = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxPvcsPerAgent != null && ec.Excludes("maxPvcsPerAgent",true))
        {
            this.MaxPvcsPerAgent = null;
        }
        //      C# -> System.String? NadName
        // GraphQL -> nadName: String (scalar)
        if (ec.Includes("nadName",true))
        {
            if(this.NadName == null) {

                this.NadName = "FETCH";

            } else {


            }
        }
        else if (this.NadName != null && ec.Excludes("nadName",true))
        {
            this.NadName = null;
        }
        //      C# -> System.String? NadNamespace
        // GraphQL -> nadNamespace: String (scalar)
        if (ec.Includes("nadNamespace",true))
        {
            if(this.NadNamespace == null) {

                this.NadNamespace = "FETCH";

            } else {


            }
        }
        else if (this.NadNamespace != null && ec.Excludes("nadNamespace",true))
        {
            this.NadNamespace = null;
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
        //      C# -> System.Int32? NamespaceCount
        // GraphQL -> namespaceCount: Int (scalar)
        if (ec.Includes("namespaceCount",true))
        {
            if(this.NamespaceCount == null) {

                this.NamespaceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NamespaceCount != null && ec.Excludes("namespaceCount",true))
        {
            this.NamespaceCount = null;
        }
        //      C# -> System.Int32? NumLabels
        // GraphQL -> numLabels: Int (scalar)
        if (ec.Includes("numLabels",true))
        {
            if(this.NumLabels == null) {

                this.NumLabels = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumLabels != null && ec.Excludes("numLabels",true))
        {
            this.NumLabels = null;
        }
        //      C# -> System.Int32? NumProtectionSets
        // GraphQL -> numProtectionSets: Int (scalar)
        if (ec.Includes("numProtectionSets",true))
        {
            if(this.NumProtectionSets == null) {

                this.NumProtectionSets = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumProtectionSets != null && ec.Excludes("numProtectionSets",true))
        {
            this.NumProtectionSets = null;
        }
        //      C# -> System.Int32? NumVms
        // GraphQL -> numVms: Int (scalar)
        if (ec.Includes("numVms",true))
        {
            if(this.NumVms == null) {

                this.NumVms = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumVms != null && ec.Excludes("numVms",true))
        {
            this.NumVms = null;
        }
        //      C# -> System.String? OnboardingType
        // GraphQL -> onboardingType: String (scalar)
        if (ec.Includes("onboardingType",true))
        {
            if(this.OnboardingType == null) {

                this.OnboardingType = "FETCH";

            } else {


            }
        }
        else if (this.OnboardingType != null && ec.Excludes("onboardingType",true))
        {
            this.OnboardingType = null;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        if (ec.Includes("port",true))
        {
            if(this.Port == null) {

                this.Port = Int32.MinValue;

            } else {


            }
        }
        else if (this.Port != null && ec.Excludes("port",true))
        {
            this.Port = null;
        }
        //      C# -> System.String? PvcGroupingStrategy
        // GraphQL -> pvcGroupingStrategy: String (scalar)
        if (ec.Includes("pvcGroupingStrategy",true))
        {
            if(this.PvcGroupingStrategy == null) {

                this.PvcGroupingStrategy = "FETCH";

            } else {


            }
        }
        else if (this.PvcGroupingStrategy != null && ec.Excludes("pvcGroupingStrategy",true))
        {
            this.PvcGroupingStrategy = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        if (ec.Includes("registry",true))
        {
            if(this.Registry == null) {

                this.Registry = "FETCH";

            } else {


            }
        }
        else if (this.Registry != null && ec.Excludes("registry",true))
        {
            this.Registry = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
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
        //      C# -> System.String? Transport
        // GraphQL -> transport: String (scalar)
        if (ec.Includes("transport",true))
        {
            if(this.Transport == null) {

                this.Transport = "FETCH";

            } else {


            }
        }
        else if (this.Transport != null && ec.Excludes("transport",true))
        {
            this.Transport = null;
        }
        //      C# -> ServiceAccountInfo? CrdServiceAccountInfo
        // GraphQL -> crdServiceAccountInfo: ServiceAccountInfo (type)
        if (ec.Includes("crdServiceAccountInfo",false))
        {
            if(this.CrdServiceAccountInfo == null) {

                this.CrdServiceAccountInfo = new ServiceAccountInfo();
                this.CrdServiceAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("crdServiceAccountInfo"));

            } else {

                this.CrdServiceAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("crdServiceAccountInfo"));

            }
        }
        else if (this.CrdServiceAccountInfo != null && ec.Excludes("crdServiceAccountInfo",false))
        {
            this.CrdServiceAccountInfo = null;
        }
        //      C# -> KuprServerProxyConfig? KuprServerProxyConfig
        // GraphQL -> kuprServerProxyConfig: KuprServerProxyConfig (type)
        if (ec.Includes("kuprServerProxyConfig",false))
        {
            if(this.KuprServerProxyConfig == null) {

                this.KuprServerProxyConfig = new KuprServerProxyConfig();
                this.KuprServerProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("kuprServerProxyConfig"));

            } else {

                this.KuprServerProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("kuprServerProxyConfig"));

            }
        }
        else if (this.KuprServerProxyConfig != null && ec.Excludes("kuprServerProxyConfig",false))
        {
            this.KuprServerProxyConfig = null;
        }
        //      C# -> ServiceAccountInfo? OnboardingServiceAccountInfo
        // GraphQL -> onboardingServiceAccountInfo: ServiceAccountInfo (type)
        if (ec.Includes("onboardingServiceAccountInfo",false))
        {
            if(this.OnboardingServiceAccountInfo == null) {

                this.OnboardingServiceAccountInfo = new ServiceAccountInfo();
                this.OnboardingServiceAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("onboardingServiceAccountInfo"));

            } else {

                this.OnboardingServiceAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("onboardingServiceAccountInfo"));

            }
        }
        else if (this.OnboardingServiceAccountInfo != null && ec.Excludes("onboardingServiceAccountInfo",false))
        {
            this.OnboardingServiceAccountInfo = null;
        }
        //      C# -> List<K8sWorkloadComponentSummary>? Workloads
        // GraphQL -> workloads: [K8sWorkloadComponentSummary!]! (type)
        if (ec.Includes("workloads",false))
        {
            if(this.Workloads == null) {

                this.Workloads = new List<K8sWorkloadComponentSummary>();
                this.Workloads.ApplyExploratoryFieldSpec(ec.NewChild("workloads"));

            } else {

                this.Workloads.ApplyExploratoryFieldSpec(ec.NewChild("workloads"));

            }
        }
        else if (this.Workloads != null && ec.Excludes("workloads",false))
        {
            this.Workloads = null;
        }
    }


    #endregion

    } // class K8sClusterSummary
    
    #endregion

    public static class ListK8sClusterSummaryExtensions
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
            this List<K8sClusterSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sClusterSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sClusterSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sClusterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sClusterSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
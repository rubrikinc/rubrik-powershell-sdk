// JobInfoRequestDetails.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region JobInfoRequestDetails

    public class JobInfoRequestDetails: IInput
    {
        #region members

        //      C# -> UnmountInfo? UnmountInfo
        // GraphQL -> unmountInfo: UnmountInfo (input)
        [JsonProperty("unmountInfo")]
        public UnmountInfo? UnmountInfo { get; set; }

        //      C# -> QueryMountInfo? QueryMountInfo
        // GraphQL -> queryMountInfo: QueryMountInfo (input)
        [JsonProperty("queryMountInfo")]
        public QueryMountInfo? QueryMountInfo { get; set; }

        //      C# -> PollerSapHanaSystemInfo? SapHanaSystemInfo
        // GraphQL -> sapHanaSystemInfo: PollerSapHanaSystemInfo (input)
        [JsonProperty("sapHanaSystemInfo")]
        public PollerSapHanaSystemInfo? SapHanaSystemInfo { get; set; }

        //      C# -> ArchivalLocationInfo? ArchivalLocationInfo
        // GraphQL -> archivalLocationInfo: ArchivalLocationInfo (input)
        [JsonProperty("archivalLocationInfo")]
        public ArchivalLocationInfo? ArchivalLocationInfo { get; set; }

        //      C# -> MosaicSourceInfo? MosaicSourceInfo
        // GraphQL -> mosaicSourceInfo: MosaicSourceInfo (input)
        [JsonProperty("mosaicSourceInfo")]
        public MosaicSourceInfo? MosaicSourceInfo { get; set; }

        //      C# -> SnapshotFileDownloadInfo? SnapshotFileDownloadInfo
        // GraphQL -> snapshotFileDownloadInfo: SnapshotFileDownloadInfo (input)
        [JsonProperty("snapshotFileDownloadInfo")]
        public SnapshotFileDownloadInfo? SnapshotFileDownloadInfo { get; set; }

        //      C# -> MosaicStorageLocationInfo? MosaicStorageLocationInfo
        // GraphQL -> mosaicStorageLocationInfo: MosaicStorageLocationInfo (input)
        [JsonProperty("mosaicStorageLocationInfo")]
        public MosaicStorageLocationInfo? MosaicStorageLocationInfo { get; set; }

        //      C# -> PendingSlaInfo? PendingSlaInfo
        // GraphQL -> pendingSlaInfo: PendingSlaInfo (input)
        [JsonProperty("pendingSlaInfo")]
        public PendingSlaInfo? PendingSlaInfo { get; set; }

        //      C# -> VolumeGroupUnmountInfo? VolumeGroupUnmountInfo
        // GraphQL -> volumeGroupUnmountInfo: VolumeGroupUnmountInfo (input)
        [JsonProperty("volumeGroupUnmountInfo")]
        public VolumeGroupUnmountInfo? VolumeGroupUnmountInfo { get; set; }

        //      C# -> Db2InstanceInfo? Db2InstanceInfo
        // GraphQL -> db2InstanceInfo: Db2InstanceInfo (input)
        [JsonProperty("db2InstanceInfo")]
        public Db2InstanceInfo? Db2InstanceInfo { get; set; }

        //      C# -> MssqlDbInfo? MssqlDbInfo
        // GraphQL -> mssqlDbInfo: MssqlDbInfo (input)
        [JsonProperty("mssqlDbInfo")]
        public MssqlDbInfo? MssqlDbInfo { get; set; }

        //      C# -> LogShippingInfo? LogShippingInfo
        // GraphQL -> logShippingInfo: LogShippingInfo (input)
        [JsonProperty("logShippingInfo")]
        public LogShippingInfo? LogShippingInfo { get; set; }

        //      C# -> AddManagedVolumeInfo? AddManagedVolumeInfo
        // GraphQL -> addManagedVolumeInfo: AddManagedVolumeInfo (input)
        [JsonProperty("addManagedVolumeInfo")]
        public AddManagedVolumeInfo? AddManagedVolumeInfo { get; set; }

        //      C# -> TakeManagedVolumeOnDemandSnapshotInfo? TakeManagedVolumeOnDemandSnapshotInfo
        // GraphQL -> takeManagedVolumeOnDemandSnapshotInfo: TakeManagedVolumeOnDemandSnapshotInfo (input)
        [JsonProperty("takeManagedVolumeOnDemandSnapshotInfo")]
        public TakeManagedVolumeOnDemandSnapshotInfo? TakeManagedVolumeOnDemandSnapshotInfo { get; set; }

        //      C# -> BeginManagedVolumeSnapshotInfo? BeginManagedVolumeSnapshotInfo
        // GraphQL -> beginManagedVolumeSnapshotInfo: BeginManagedVolumeSnapshotInfo (input)
        [JsonProperty("beginManagedVolumeSnapshotInfo")]
        public BeginManagedVolumeSnapshotInfo? BeginManagedVolumeSnapshotInfo { get; set; }

        //      C# -> EndManagedVolumeSnapshotInfo? EndManagedVolumeSnapshotInfo
        // GraphQL -> endManagedVolumeSnapshotInfo: EndManagedVolumeSnapshotInfo (input)
        [JsonProperty("endManagedVolumeSnapshotInfo")]
        public EndManagedVolumeSnapshotInfo? EndManagedVolumeSnapshotInfo { get; set; }

        //      C# -> ResizeManagedVolumeInfo? ResizeManagedVolumeInfo
        // GraphQL -> resizeManagedVolumeInfo: ResizeManagedVolumeInfo (input)
        [JsonProperty("resizeManagedVolumeInfo")]
        public ResizeManagedVolumeInfo? ResizeManagedVolumeInfo { get; set; }

        //      C# -> ExportManagedVolumeSnapshotInfo? ExportManagedVolumeSnapshotInfo
        // GraphQL -> exportManagedVolumeSnapshotInfo: ExportManagedVolumeSnapshotInfo (input)
        [JsonProperty("exportManagedVolumeSnapshotInfo")]
        public ExportManagedVolumeSnapshotInfo? ExportManagedVolumeSnapshotInfo { get; set; }

        //      C# -> OracleExportInfo? OracleExportInfo
        // GraphQL -> oracleExportInfo: OracleExportInfo (input)
        [JsonProperty("oracleExportInfo")]
        public OracleExportInfo? OracleExportInfo { get; set; }

        //      C# -> SapHanaDatabaseInfo? SapHanaDatabaseInfo
        // GraphQL -> sapHanaDatabaseInfo: SapHanaDatabaseInfo (input)
        [JsonProperty("sapHanaDatabaseInfo")]
        public SapHanaDatabaseInfo? SapHanaDatabaseInfo { get; set; }

        //      C# -> ExportVcdVappSnapshotInfo? ExportVcdVappSnapshotInfo
        // GraphQL -> exportVcdVappSnapshotInfo: ExportVcdVappSnapshotInfo (input)
        [JsonProperty("exportVcdVappSnapshotInfo")]
        public ExportVcdVappSnapshotInfo? ExportVcdVappSnapshotInfo { get; set; }

        //      C# -> LiveMountRelocateInfo? LiveMountRelocateInfo
        // GraphQL -> liveMountRelocateInfo: LiveMountRelocateInfo (input)
        [JsonProperty("liveMountRelocateInfo")]
        public LiveMountRelocateInfo? LiveMountRelocateInfo { get; set; }

        //      C# -> MongoSourceInfo? MongoSourceInfo
        // GraphQL -> mongoSourceInfo: MongoSourceInfo (input)
        [JsonProperty("mongoSourceInfo")]
        public MongoSourceInfo? MongoSourceInfo { get; set; }

        //      C# -> HypervMountSnapshotInfo? HypervMountSnapshotInfo
        // GraphQL -> hypervMountSnapshotInfo: HypervMountSnapshotInfo (input)
        [JsonProperty("hypervMountSnapshotInfo")]
        public HypervMountSnapshotInfo? HypervMountSnapshotInfo { get; set; }

        //      C# -> WebCertificateInfo? WebCertificateInfo
        // GraphQL -> webCertificateInfo: WebCertificateInfo (input)
        [JsonProperty("webCertificateInfo")]
        public WebCertificateInfo? WebCertificateInfo { get; set; }

        //      C# -> Db2DatabaseInfo? Db2DatabaseInfo
        // GraphQL -> db2DatabaseInfo: Db2DatabaseInfo (input)
        [JsonProperty("db2DatabaseInfo")]
        public Db2DatabaseInfo? Db2DatabaseInfo { get; set; }

        //      C# -> MongoCollectionsInfo? MongoCollectionsInfo
        // GraphQL -> mongoCollectionsInfo: MongoCollectionsInfo (input)
        [JsonProperty("mongoCollectionsInfo")]
        public MongoCollectionsInfo? MongoCollectionsInfo { get; set; }

        //      C# -> VsphereFileRestoreInfo? VsphereFileRestoreInfo
        // GraphQL -> vsphereFileRestoreInfo: VsphereFileRestoreInfo (input)
        [JsonProperty("vsphereFileRestoreInfo")]
        public VsphereFileRestoreInfo? VsphereFileRestoreInfo { get; set; }

        //      C# -> ConfigureManagedVolumeLogExportInfo? ConfigureManagedVolumeLogExportInfo
        // GraphQL -> configureManagedVolumeLogExportInfo: ConfigureManagedVolumeLogExportInfo (input)
        [JsonProperty("configureManagedVolumeLogExportInfo")]
        public ConfigureManagedVolumeLogExportInfo? ConfigureManagedVolumeLogExportInfo { get; set; }

        //      C# -> DownloadSnapshotFromLocationInfo? DownloadSnapshotFromLocationInfo
        // GraphQL -> downloadSnapshotFromLocationInfo: DownloadSnapshotFromLocationInfo (input)
        [JsonProperty("downloadSnapshotFromLocationInfo")]
        public DownloadSnapshotFromLocationInfo? DownloadSnapshotFromLocationInfo { get; set; }

        //      C# -> RegisterdHostInfo? RegisteredHostInfo
        // GraphQL -> registeredHostInfo: RegisterdHostInfo (input)
        [JsonProperty("registeredHostInfo")]
        public RegisterdHostInfo? RegisteredHostInfo { get; set; }

        //      C# -> RegisterOracleHostsInfo? RegisterOracleHostsInfo
        // GraphQL -> registerOracleHostsInfo: RegisterOracleHostsInfo (input)
        [JsonProperty("registerOracleHostsInfo")]
        public RegisterOracleHostsInfo? RegisterOracleHostsInfo { get; set; }

        //      C# -> LlmFunctionCallInfo? LlmInfo
        // GraphQL -> llmInfo: LlmFunctionCallInfo (input)
        [JsonProperty("llmInfo")]
        public LlmFunctionCallInfo? LlmInfo { get; set; }

        //      C# -> HostMakePrimaryInfo? HostMakePrimaryInfo
        // GraphQL -> hostMakePrimaryInfo: HostMakePrimaryInfo (input)
        [JsonProperty("hostMakePrimaryInfo")]
        public HostMakePrimaryInfo? HostMakePrimaryInfo { get; set; }

        //      C# -> VcenterDiagnosticRefreshInfo? VcenterDiagnosticRefreshInfo
        // GraphQL -> vcenterDiagnosticRefreshInfo: VcenterDiagnosticRefreshInfo (input)
        [JsonProperty("vcenterDiagnosticRefreshInfo")]
        public VcenterDiagnosticRefreshInfo? VcenterDiagnosticRefreshInfo { get; set; }

        //      C# -> PostgresDbClusterInfo? PostgresDbClusterInfo
        // GraphQL -> postgresDbClusterInfo: PostgresDbClusterInfo (input)
        [JsonProperty("postgresDbClusterInfo")]
        public PostgresDbClusterInfo? PostgresDbClusterInfo { get; set; }

        //      C# -> HostsInfo? HostsInfo
        // GraphQL -> hostsInfo: HostsInfo (input)
        [JsonProperty("hostsInfo")]
        public HostsInfo? HostsInfo { get; set; }

        //      C# -> VsphereVmMakePrimaryInfo? VsphereVmMakePrimaryInfo
        // GraphQL -> vsphereVmMakePrimaryInfo: VsphereVmMakePrimaryInfo (input)
        [JsonProperty("vsphereVmMakePrimaryInfo")]
        public VsphereVmMakePrimaryInfo? VsphereVmMakePrimaryInfo { get; set; }

        //      C# -> MssqlAddHostOperation? MssqlAddHost
        // GraphQL -> mssqlAddHost: MssqlAddHostOperation (input)
        [JsonProperty("mssqlAddHost")]
        public MssqlAddHostOperation? MssqlAddHost { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class JobInfoRequestDetails
    #endregion

} // namespace RubrikSecurityCloud.Types
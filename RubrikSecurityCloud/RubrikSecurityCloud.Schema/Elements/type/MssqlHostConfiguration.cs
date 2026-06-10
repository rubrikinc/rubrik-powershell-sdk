// MssqlHostConfiguration.cs
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
    #region MssqlHostConfiguration
    public class MssqlHostConfiguration: BaseType
    {
        #region members

        //      C# -> HostConfigurationPropertyEnabled? CopyLogsToHostDuringLiveMount
        // GraphQL -> copyLogsToHostDuringLiveMount: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("copyLogsToHostDuringLiveMount")]
        public HostConfigurationPropertyEnabled? CopyLogsToHostDuringLiveMount { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? EnableDatabaseBatchSnapshots
        // GraphQL -> enableDatabaseBatchSnapshots: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("enableDatabaseBatchSnapshots")]
        public HostConfigurationPropertyEnabled? EnableDatabaseBatchSnapshots { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? EnableGroupFetch
        // GraphQL -> enableGroupFetch: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("enableGroupFetch")]
        public HostConfigurationPropertyEnabled? EnableGroupFetch { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? EnableMssqlMultiNodeBackup
        // GraphQL -> enableMssqlMultiNodeBackup: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("enableMssqlMultiNodeBackup")]
        public HostConfigurationPropertyEnabled? EnableMssqlMultiNodeBackup { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? EnableMssqlMultiNodeRestore
        // GraphQL -> enableMssqlMultiNodeRestore: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("enableMssqlMultiNodeRestore")]
        public HostConfigurationPropertyEnabled? EnableMssqlMultiNodeRestore { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? EnableVdi
        // GraphQL -> enableVdi: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("enableVdi")]
        public HostConfigurationPropertyEnabled? EnableVdi { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? EnableVdiDb
        // GraphQL -> enableVdiDb: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("enableVdiDb")]
        public HostConfigurationPropertyEnabled? EnableVdiDb { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? MssqlAllowDirtyReadForDbSizeQuery
        // GraphQL -> mssqlAllowDirtyReadForDbSizeQuery: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("mssqlAllowDirtyReadForDbSizeQuery")]
        public HostConfigurationPropertyEnabled? MssqlAllowDirtyReadForDbSizeQuery { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? MssqlEnableCleanupOnRestoreFailure
        // GraphQL -> mssqlEnableCleanupOnRestoreFailure: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("mssqlEnableCleanupOnRestoreFailure")]
        public HostConfigurationPropertyEnabled? MssqlEnableCleanupOnRestoreFailure { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? MssqlUseDmFileSpaceUsage
        // GraphQL -> mssqlUseDmFileSpaceUsage: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("mssqlUseDmFileSpaceUsage")]
        public HostConfigurationPropertyEnabled? MssqlUseDmFileSpaceUsage { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? UseAf2ForHighDataFileCount
        // GraphQL -> useAf2ForHighDataFileCount: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("useAf2ForHighDataFileCount")]
        public HostConfigurationPropertyEnabled? UseAf2ForHighDataFileCount { get; set; }

        //      C# -> HostConfigurationPropertyEnabled? UseDefaultBackupLocation
        // GraphQL -> useDefaultBackupLocation: HostConfigurationPropertyEnabled (enum)
        [JsonProperty("useDefaultBackupLocation")]
        public HostConfigurationPropertyEnabled? UseDefaultBackupLocation { get; set; }

        //      C# -> System.Int32? Af2MinimumFileCount
        // GraphQL -> af2MinimumFileCount: Int (scalar)
        [JsonProperty("af2MinimumFileCount")]
        public System.Int32? Af2MinimumFileCount { get; set; }

        //      C# -> System.Int32? CbtMaxMemoryUsageInMb
        // GraphQL -> cbtMaxMemoryUsageInMb: Int (scalar)
        [JsonProperty("cbtMaxMemoryUsageInMb")]
        public System.Int32? CbtMaxMemoryUsageInMb { get; set; }

        //      C# -> System.Int32? CmdPipeBufferSizeInKb
        // GraphQL -> cmdPipeBufferSizeInKb: Int (scalar)
        [JsonProperty("cmdPipeBufferSizeInKb")]
        public System.Int32? CmdPipeBufferSizeInKb { get; set; }

        //      C# -> System.Int32? FileRestoreReadParallelism
        // GraphQL -> fileRestoreReadParallelism: Int (scalar)
        [JsonProperty("fileRestoreReadParallelism")]
        public System.Int32? FileRestoreReadParallelism { get; set; }

        //      C# -> System.Int32? FileRestoreWriteParallelism
        // GraphQL -> fileRestoreWriteParallelism: Int (scalar)
        [JsonProperty("fileRestoreWriteParallelism")]
        public System.Int32? FileRestoreWriteParallelism { get; set; }

        //      C# -> System.Int32? FileTransferParallelism
        // GraphQL -> fileTransferParallelism: Int (scalar)
        [JsonProperty("fileTransferParallelism")]
        public System.Int32? FileTransferParallelism { get; set; }

        //      C# -> System.Int32? MaxDbLoadSizeInBytes
        // GraphQL -> maxDbLoadSizeInBytes: Int (scalar)
        [JsonProperty("maxDbLoadSizeInBytes")]
        public System.Int32? MaxDbLoadSizeInBytes { get; set; }

        //      C# -> System.Int32? MaxNodesForMultiNodeBackup
        // GraphQL -> maxNodesForMultiNodeBackup: Int (scalar)
        [JsonProperty("maxNodesForMultiNodeBackup")]
        public System.Int32? MaxNodesForMultiNodeBackup { get; set; }

        //      C# -> System.Int32? MaxNodesForMultiNodeRestore
        // GraphQL -> maxNodesForMultiNodeRestore: Int (scalar)
        [JsonProperty("maxNodesForMultiNodeRestore")]
        public System.Int32? MaxNodesForMultiNodeRestore { get; set; }

        //      C# -> System.Int32? MssqlDatabaseQueryTimeout
        // GraphQL -> mssqlDatabaseQueryTimeout: Int (scalar)
        [JsonProperty("mssqlDatabaseQueryTimeout")]
        public System.Int32? MssqlDatabaseQueryTimeout { get; set; }

        //      C# -> System.Int32? MssqlDefaultMaxDataStreamsPerDatabase
        // GraphQL -> mssqlDefaultMaxDataStreamsPerDatabase: Int (scalar)
        [JsonProperty("mssqlDefaultMaxDataStreamsPerDatabase")]
        public System.Int32? MssqlDefaultMaxDataStreamsPerDatabase { get; set; }

        //      C# -> System.Int32? MultiNodeRestoreMaxDataStreamsPerNode
        // GraphQL -> multiNodeRestoreMaxDataStreamsPerNode: Int (scalar)
        [JsonProperty("multiNodeRestoreMaxDataStreamsPerNode")]
        public System.Int32? MultiNodeRestoreMaxDataStreamsPerNode { get; set; }

        //      C# -> System.Int32? PhysicalHostDatabaseRestoreThrottleMaxRefCount
        // GraphQL -> physicalHostDatabaseRestoreThrottleMaxRefCount: Int (scalar)
        [JsonProperty("physicalHostDatabaseRestoreThrottleMaxRefCount")]
        public System.Int32? PhysicalHostDatabaseRestoreThrottleMaxRefCount { get; set; }

        //      C# -> System.Int32? PhysicalHostLogBackupThrottleMaxRefCount
        // GraphQL -> physicalHostLogBackupThrottleMaxRefCount: Int (scalar)
        [JsonProperty("physicalHostLogBackupThrottleMaxRefCount")]
        public System.Int32? PhysicalHostLogBackupThrottleMaxRefCount { get; set; }

        //      C# -> System.Int32? ThrottlePhysicalHostMaxRefCount
        // GraphQL -> throttlePhysicalHostMaxRefCount: Int (scalar)
        [JsonProperty("throttlePhysicalHostMaxRefCount")]
        public System.Int32? ThrottlePhysicalHostMaxRefCount { get; set; }

        //      C# -> System.Int32? VdiRestoreMaxTimeoutInMinutes
        // GraphQL -> vdiRestoreMaxTimeoutInMinutes: Int (scalar)
        [JsonProperty("vdiRestoreMaxTimeoutInMinutes")]
        public System.Int32? VdiRestoreMaxTimeoutInMinutes { get; set; }

        //      C# -> System.Int32? VdiRestoreTimeoutInSecondsPerGb
        // GraphQL -> vdiRestoreTimeoutInSecondsPerGb: Int (scalar)
        [JsonProperty("vdiRestoreTimeoutInSecondsPerGb")]
        public System.Int32? VdiRestoreTimeoutInSecondsPerGb { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlHostConfiguration";
    }

    public MssqlHostConfiguration Set(
        HostConfigurationPropertyEnabled? CopyLogsToHostDuringLiveMount = null,
        HostConfigurationPropertyEnabled? EnableDatabaseBatchSnapshots = null,
        HostConfigurationPropertyEnabled? EnableGroupFetch = null,
        HostConfigurationPropertyEnabled? EnableMssqlMultiNodeBackup = null,
        HostConfigurationPropertyEnabled? EnableMssqlMultiNodeRestore = null,
        HostConfigurationPropertyEnabled? EnableVdi = null,
        HostConfigurationPropertyEnabled? EnableVdiDb = null,
        HostConfigurationPropertyEnabled? MssqlAllowDirtyReadForDbSizeQuery = null,
        HostConfigurationPropertyEnabled? MssqlEnableCleanupOnRestoreFailure = null,
        HostConfigurationPropertyEnabled? MssqlUseDmFileSpaceUsage = null,
        HostConfigurationPropertyEnabled? UseAf2ForHighDataFileCount = null,
        HostConfigurationPropertyEnabled? UseDefaultBackupLocation = null,
        System.Int32? Af2MinimumFileCount = null,
        System.Int32? CbtMaxMemoryUsageInMb = null,
        System.Int32? CmdPipeBufferSizeInKb = null,
        System.Int32? FileRestoreReadParallelism = null,
        System.Int32? FileRestoreWriteParallelism = null,
        System.Int32? FileTransferParallelism = null,
        System.Int32? MaxDbLoadSizeInBytes = null,
        System.Int32? MaxNodesForMultiNodeBackup = null,
        System.Int32? MaxNodesForMultiNodeRestore = null,
        System.Int32? MssqlDatabaseQueryTimeout = null,
        System.Int32? MssqlDefaultMaxDataStreamsPerDatabase = null,
        System.Int32? MultiNodeRestoreMaxDataStreamsPerNode = null,
        System.Int32? PhysicalHostDatabaseRestoreThrottleMaxRefCount = null,
        System.Int32? PhysicalHostLogBackupThrottleMaxRefCount = null,
        System.Int32? ThrottlePhysicalHostMaxRefCount = null,
        System.Int32? VdiRestoreMaxTimeoutInMinutes = null,
        System.Int32? VdiRestoreTimeoutInSecondsPerGb = null
    ) 
    {
        if ( CopyLogsToHostDuringLiveMount != null ) {
            this.CopyLogsToHostDuringLiveMount = CopyLogsToHostDuringLiveMount;
        }
        if ( EnableDatabaseBatchSnapshots != null ) {
            this.EnableDatabaseBatchSnapshots = EnableDatabaseBatchSnapshots;
        }
        if ( EnableGroupFetch != null ) {
            this.EnableGroupFetch = EnableGroupFetch;
        }
        if ( EnableMssqlMultiNodeBackup != null ) {
            this.EnableMssqlMultiNodeBackup = EnableMssqlMultiNodeBackup;
        }
        if ( EnableMssqlMultiNodeRestore != null ) {
            this.EnableMssqlMultiNodeRestore = EnableMssqlMultiNodeRestore;
        }
        if ( EnableVdi != null ) {
            this.EnableVdi = EnableVdi;
        }
        if ( EnableVdiDb != null ) {
            this.EnableVdiDb = EnableVdiDb;
        }
        if ( MssqlAllowDirtyReadForDbSizeQuery != null ) {
            this.MssqlAllowDirtyReadForDbSizeQuery = MssqlAllowDirtyReadForDbSizeQuery;
        }
        if ( MssqlEnableCleanupOnRestoreFailure != null ) {
            this.MssqlEnableCleanupOnRestoreFailure = MssqlEnableCleanupOnRestoreFailure;
        }
        if ( MssqlUseDmFileSpaceUsage != null ) {
            this.MssqlUseDmFileSpaceUsage = MssqlUseDmFileSpaceUsage;
        }
        if ( UseAf2ForHighDataFileCount != null ) {
            this.UseAf2ForHighDataFileCount = UseAf2ForHighDataFileCount;
        }
        if ( UseDefaultBackupLocation != null ) {
            this.UseDefaultBackupLocation = UseDefaultBackupLocation;
        }
        if ( Af2MinimumFileCount != null ) {
            this.Af2MinimumFileCount = Af2MinimumFileCount;
        }
        if ( CbtMaxMemoryUsageInMb != null ) {
            this.CbtMaxMemoryUsageInMb = CbtMaxMemoryUsageInMb;
        }
        if ( CmdPipeBufferSizeInKb != null ) {
            this.CmdPipeBufferSizeInKb = CmdPipeBufferSizeInKb;
        }
        if ( FileRestoreReadParallelism != null ) {
            this.FileRestoreReadParallelism = FileRestoreReadParallelism;
        }
        if ( FileRestoreWriteParallelism != null ) {
            this.FileRestoreWriteParallelism = FileRestoreWriteParallelism;
        }
        if ( FileTransferParallelism != null ) {
            this.FileTransferParallelism = FileTransferParallelism;
        }
        if ( MaxDbLoadSizeInBytes != null ) {
            this.MaxDbLoadSizeInBytes = MaxDbLoadSizeInBytes;
        }
        if ( MaxNodesForMultiNodeBackup != null ) {
            this.MaxNodesForMultiNodeBackup = MaxNodesForMultiNodeBackup;
        }
        if ( MaxNodesForMultiNodeRestore != null ) {
            this.MaxNodesForMultiNodeRestore = MaxNodesForMultiNodeRestore;
        }
        if ( MssqlDatabaseQueryTimeout != null ) {
            this.MssqlDatabaseQueryTimeout = MssqlDatabaseQueryTimeout;
        }
        if ( MssqlDefaultMaxDataStreamsPerDatabase != null ) {
            this.MssqlDefaultMaxDataStreamsPerDatabase = MssqlDefaultMaxDataStreamsPerDatabase;
        }
        if ( MultiNodeRestoreMaxDataStreamsPerNode != null ) {
            this.MultiNodeRestoreMaxDataStreamsPerNode = MultiNodeRestoreMaxDataStreamsPerNode;
        }
        if ( PhysicalHostDatabaseRestoreThrottleMaxRefCount != null ) {
            this.PhysicalHostDatabaseRestoreThrottleMaxRefCount = PhysicalHostDatabaseRestoreThrottleMaxRefCount;
        }
        if ( PhysicalHostLogBackupThrottleMaxRefCount != null ) {
            this.PhysicalHostLogBackupThrottleMaxRefCount = PhysicalHostLogBackupThrottleMaxRefCount;
        }
        if ( ThrottlePhysicalHostMaxRefCount != null ) {
            this.ThrottlePhysicalHostMaxRefCount = ThrottlePhysicalHostMaxRefCount;
        }
        if ( VdiRestoreMaxTimeoutInMinutes != null ) {
            this.VdiRestoreMaxTimeoutInMinutes = VdiRestoreMaxTimeoutInMinutes;
        }
        if ( VdiRestoreTimeoutInSecondsPerGb != null ) {
            this.VdiRestoreTimeoutInSecondsPerGb = VdiRestoreTimeoutInSecondsPerGb;
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
        //      C# -> HostConfigurationPropertyEnabled? CopyLogsToHostDuringLiveMount
        // GraphQL -> copyLogsToHostDuringLiveMount: HostConfigurationPropertyEnabled (enum)
        if (this.CopyLogsToHostDuringLiveMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "copyLogsToHostDuringLiveMount\n" ;
            } else {
                s += ind + "copyLogsToHostDuringLiveMount\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableDatabaseBatchSnapshots
        // GraphQL -> enableDatabaseBatchSnapshots: HostConfigurationPropertyEnabled (enum)
        if (this.EnableDatabaseBatchSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableDatabaseBatchSnapshots\n" ;
            } else {
                s += ind + "enableDatabaseBatchSnapshots\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableGroupFetch
        // GraphQL -> enableGroupFetch: HostConfigurationPropertyEnabled (enum)
        if (this.EnableGroupFetch != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableGroupFetch\n" ;
            } else {
                s += ind + "enableGroupFetch\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableMssqlMultiNodeBackup
        // GraphQL -> enableMssqlMultiNodeBackup: HostConfigurationPropertyEnabled (enum)
        if (this.EnableMssqlMultiNodeBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableMssqlMultiNodeBackup\n" ;
            } else {
                s += ind + "enableMssqlMultiNodeBackup\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableMssqlMultiNodeRestore
        // GraphQL -> enableMssqlMultiNodeRestore: HostConfigurationPropertyEnabled (enum)
        if (this.EnableMssqlMultiNodeRestore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableMssqlMultiNodeRestore\n" ;
            } else {
                s += ind + "enableMssqlMultiNodeRestore\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableVdi
        // GraphQL -> enableVdi: HostConfigurationPropertyEnabled (enum)
        if (this.EnableVdi != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableVdi\n" ;
            } else {
                s += ind + "enableVdi\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableVdiDb
        // GraphQL -> enableVdiDb: HostConfigurationPropertyEnabled (enum)
        if (this.EnableVdiDb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableVdiDb\n" ;
            } else {
                s += ind + "enableVdiDb\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? MssqlAllowDirtyReadForDbSizeQuery
        // GraphQL -> mssqlAllowDirtyReadForDbSizeQuery: HostConfigurationPropertyEnabled (enum)
        if (this.MssqlAllowDirtyReadForDbSizeQuery != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlAllowDirtyReadForDbSizeQuery\n" ;
            } else {
                s += ind + "mssqlAllowDirtyReadForDbSizeQuery\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? MssqlEnableCleanupOnRestoreFailure
        // GraphQL -> mssqlEnableCleanupOnRestoreFailure: HostConfigurationPropertyEnabled (enum)
        if (this.MssqlEnableCleanupOnRestoreFailure != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlEnableCleanupOnRestoreFailure\n" ;
            } else {
                s += ind + "mssqlEnableCleanupOnRestoreFailure\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? MssqlUseDmFileSpaceUsage
        // GraphQL -> mssqlUseDmFileSpaceUsage: HostConfigurationPropertyEnabled (enum)
        if (this.MssqlUseDmFileSpaceUsage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlUseDmFileSpaceUsage\n" ;
            } else {
                s += ind + "mssqlUseDmFileSpaceUsage\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? UseAf2ForHighDataFileCount
        // GraphQL -> useAf2ForHighDataFileCount: HostConfigurationPropertyEnabled (enum)
        if (this.UseAf2ForHighDataFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "useAf2ForHighDataFileCount\n" ;
            } else {
                s += ind + "useAf2ForHighDataFileCount\n" ;
            }
        }
        //      C# -> HostConfigurationPropertyEnabled? UseDefaultBackupLocation
        // GraphQL -> useDefaultBackupLocation: HostConfigurationPropertyEnabled (enum)
        if (this.UseDefaultBackupLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "useDefaultBackupLocation\n" ;
            } else {
                s += ind + "useDefaultBackupLocation\n" ;
            }
        }
        //      C# -> System.Int32? Af2MinimumFileCount
        // GraphQL -> af2MinimumFileCount: Int (scalar)
        if (this.Af2MinimumFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "af2MinimumFileCount\n" ;
            } else {
                s += ind + "af2MinimumFileCount\n" ;
            }
        }
        //      C# -> System.Int32? CbtMaxMemoryUsageInMb
        // GraphQL -> cbtMaxMemoryUsageInMb: Int (scalar)
        if (this.CbtMaxMemoryUsageInMb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cbtMaxMemoryUsageInMb\n" ;
            } else {
                s += ind + "cbtMaxMemoryUsageInMb\n" ;
            }
        }
        //      C# -> System.Int32? CmdPipeBufferSizeInKb
        // GraphQL -> cmdPipeBufferSizeInKb: Int (scalar)
        if (this.CmdPipeBufferSizeInKb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cmdPipeBufferSizeInKb\n" ;
            } else {
                s += ind + "cmdPipeBufferSizeInKb\n" ;
            }
        }
        //      C# -> System.Int32? FileRestoreReadParallelism
        // GraphQL -> fileRestoreReadParallelism: Int (scalar)
        if (this.FileRestoreReadParallelism != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileRestoreReadParallelism\n" ;
            } else {
                s += ind + "fileRestoreReadParallelism\n" ;
            }
        }
        //      C# -> System.Int32? FileRestoreWriteParallelism
        // GraphQL -> fileRestoreWriteParallelism: Int (scalar)
        if (this.FileRestoreWriteParallelism != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileRestoreWriteParallelism\n" ;
            } else {
                s += ind + "fileRestoreWriteParallelism\n" ;
            }
        }
        //      C# -> System.Int32? FileTransferParallelism
        // GraphQL -> fileTransferParallelism: Int (scalar)
        if (this.FileTransferParallelism != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileTransferParallelism\n" ;
            } else {
                s += ind + "fileTransferParallelism\n" ;
            }
        }
        //      C# -> System.Int32? MaxDbLoadSizeInBytes
        // GraphQL -> maxDbLoadSizeInBytes: Int (scalar)
        if (this.MaxDbLoadSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxDbLoadSizeInBytes\n" ;
            } else {
                s += ind + "maxDbLoadSizeInBytes\n" ;
            }
        }
        //      C# -> System.Int32? MaxNodesForMultiNodeBackup
        // GraphQL -> maxNodesForMultiNodeBackup: Int (scalar)
        if (this.MaxNodesForMultiNodeBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxNodesForMultiNodeBackup\n" ;
            } else {
                s += ind + "maxNodesForMultiNodeBackup\n" ;
            }
        }
        //      C# -> System.Int32? MaxNodesForMultiNodeRestore
        // GraphQL -> maxNodesForMultiNodeRestore: Int (scalar)
        if (this.MaxNodesForMultiNodeRestore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxNodesForMultiNodeRestore\n" ;
            } else {
                s += ind + "maxNodesForMultiNodeRestore\n" ;
            }
        }
        //      C# -> System.Int32? MssqlDatabaseQueryTimeout
        // GraphQL -> mssqlDatabaseQueryTimeout: Int (scalar)
        if (this.MssqlDatabaseQueryTimeout != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlDatabaseQueryTimeout\n" ;
            } else {
                s += ind + "mssqlDatabaseQueryTimeout\n" ;
            }
        }
        //      C# -> System.Int32? MssqlDefaultMaxDataStreamsPerDatabase
        // GraphQL -> mssqlDefaultMaxDataStreamsPerDatabase: Int (scalar)
        if (this.MssqlDefaultMaxDataStreamsPerDatabase != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mssqlDefaultMaxDataStreamsPerDatabase\n" ;
            } else {
                s += ind + "mssqlDefaultMaxDataStreamsPerDatabase\n" ;
            }
        }
        //      C# -> System.Int32? MultiNodeRestoreMaxDataStreamsPerNode
        // GraphQL -> multiNodeRestoreMaxDataStreamsPerNode: Int (scalar)
        if (this.MultiNodeRestoreMaxDataStreamsPerNode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "multiNodeRestoreMaxDataStreamsPerNode\n" ;
            } else {
                s += ind + "multiNodeRestoreMaxDataStreamsPerNode\n" ;
            }
        }
        //      C# -> System.Int32? PhysicalHostDatabaseRestoreThrottleMaxRefCount
        // GraphQL -> physicalHostDatabaseRestoreThrottleMaxRefCount: Int (scalar)
        if (this.PhysicalHostDatabaseRestoreThrottleMaxRefCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalHostDatabaseRestoreThrottleMaxRefCount\n" ;
            } else {
                s += ind + "physicalHostDatabaseRestoreThrottleMaxRefCount\n" ;
            }
        }
        //      C# -> System.Int32? PhysicalHostLogBackupThrottleMaxRefCount
        // GraphQL -> physicalHostLogBackupThrottleMaxRefCount: Int (scalar)
        if (this.PhysicalHostLogBackupThrottleMaxRefCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalHostLogBackupThrottleMaxRefCount\n" ;
            } else {
                s += ind + "physicalHostLogBackupThrottleMaxRefCount\n" ;
            }
        }
        //      C# -> System.Int32? ThrottlePhysicalHostMaxRefCount
        // GraphQL -> throttlePhysicalHostMaxRefCount: Int (scalar)
        if (this.ThrottlePhysicalHostMaxRefCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "throttlePhysicalHostMaxRefCount\n" ;
            } else {
                s += ind + "throttlePhysicalHostMaxRefCount\n" ;
            }
        }
        //      C# -> System.Int32? VdiRestoreMaxTimeoutInMinutes
        // GraphQL -> vdiRestoreMaxTimeoutInMinutes: Int (scalar)
        if (this.VdiRestoreMaxTimeoutInMinutes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vdiRestoreMaxTimeoutInMinutes\n" ;
            } else {
                s += ind + "vdiRestoreMaxTimeoutInMinutes\n" ;
            }
        }
        //      C# -> System.Int32? VdiRestoreTimeoutInSecondsPerGb
        // GraphQL -> vdiRestoreTimeoutInSecondsPerGb: Int (scalar)
        if (this.VdiRestoreTimeoutInSecondsPerGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vdiRestoreTimeoutInSecondsPerGb\n" ;
            } else {
                s += ind + "vdiRestoreTimeoutInSecondsPerGb\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HostConfigurationPropertyEnabled? CopyLogsToHostDuringLiveMount
        // GraphQL -> copyLogsToHostDuringLiveMount: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("copyLogsToHostDuringLiveMount",true))
        {
            if(this.CopyLogsToHostDuringLiveMount == null) {

                this.CopyLogsToHostDuringLiveMount = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.CopyLogsToHostDuringLiveMount != null && ec.Excludes("copyLogsToHostDuringLiveMount",true))
        {
            this.CopyLogsToHostDuringLiveMount = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableDatabaseBatchSnapshots
        // GraphQL -> enableDatabaseBatchSnapshots: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("enableDatabaseBatchSnapshots",true))
        {
            if(this.EnableDatabaseBatchSnapshots == null) {

                this.EnableDatabaseBatchSnapshots = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.EnableDatabaseBatchSnapshots != null && ec.Excludes("enableDatabaseBatchSnapshots",true))
        {
            this.EnableDatabaseBatchSnapshots = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableGroupFetch
        // GraphQL -> enableGroupFetch: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("enableGroupFetch",true))
        {
            if(this.EnableGroupFetch == null) {

                this.EnableGroupFetch = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.EnableGroupFetch != null && ec.Excludes("enableGroupFetch",true))
        {
            this.EnableGroupFetch = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableMssqlMultiNodeBackup
        // GraphQL -> enableMssqlMultiNodeBackup: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("enableMssqlMultiNodeBackup",true))
        {
            if(this.EnableMssqlMultiNodeBackup == null) {

                this.EnableMssqlMultiNodeBackup = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.EnableMssqlMultiNodeBackup != null && ec.Excludes("enableMssqlMultiNodeBackup",true))
        {
            this.EnableMssqlMultiNodeBackup = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableMssqlMultiNodeRestore
        // GraphQL -> enableMssqlMultiNodeRestore: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("enableMssqlMultiNodeRestore",true))
        {
            if(this.EnableMssqlMultiNodeRestore == null) {

                this.EnableMssqlMultiNodeRestore = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.EnableMssqlMultiNodeRestore != null && ec.Excludes("enableMssqlMultiNodeRestore",true))
        {
            this.EnableMssqlMultiNodeRestore = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableVdi
        // GraphQL -> enableVdi: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("enableVdi",true))
        {
            if(this.EnableVdi == null) {

                this.EnableVdi = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.EnableVdi != null && ec.Excludes("enableVdi",true))
        {
            this.EnableVdi = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? EnableVdiDb
        // GraphQL -> enableVdiDb: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("enableVdiDb",true))
        {
            if(this.EnableVdiDb == null) {

                this.EnableVdiDb = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.EnableVdiDb != null && ec.Excludes("enableVdiDb",true))
        {
            this.EnableVdiDb = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? MssqlAllowDirtyReadForDbSizeQuery
        // GraphQL -> mssqlAllowDirtyReadForDbSizeQuery: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("mssqlAllowDirtyReadForDbSizeQuery",true))
        {
            if(this.MssqlAllowDirtyReadForDbSizeQuery == null) {

                this.MssqlAllowDirtyReadForDbSizeQuery = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.MssqlAllowDirtyReadForDbSizeQuery != null && ec.Excludes("mssqlAllowDirtyReadForDbSizeQuery",true))
        {
            this.MssqlAllowDirtyReadForDbSizeQuery = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? MssqlEnableCleanupOnRestoreFailure
        // GraphQL -> mssqlEnableCleanupOnRestoreFailure: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("mssqlEnableCleanupOnRestoreFailure",true))
        {
            if(this.MssqlEnableCleanupOnRestoreFailure == null) {

                this.MssqlEnableCleanupOnRestoreFailure = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.MssqlEnableCleanupOnRestoreFailure != null && ec.Excludes("mssqlEnableCleanupOnRestoreFailure",true))
        {
            this.MssqlEnableCleanupOnRestoreFailure = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? MssqlUseDmFileSpaceUsage
        // GraphQL -> mssqlUseDmFileSpaceUsage: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("mssqlUseDmFileSpaceUsage",true))
        {
            if(this.MssqlUseDmFileSpaceUsage == null) {

                this.MssqlUseDmFileSpaceUsage = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.MssqlUseDmFileSpaceUsage != null && ec.Excludes("mssqlUseDmFileSpaceUsage",true))
        {
            this.MssqlUseDmFileSpaceUsage = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? UseAf2ForHighDataFileCount
        // GraphQL -> useAf2ForHighDataFileCount: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("useAf2ForHighDataFileCount",true))
        {
            if(this.UseAf2ForHighDataFileCount == null) {

                this.UseAf2ForHighDataFileCount = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.UseAf2ForHighDataFileCount != null && ec.Excludes("useAf2ForHighDataFileCount",true))
        {
            this.UseAf2ForHighDataFileCount = null;
        }
        //      C# -> HostConfigurationPropertyEnabled? UseDefaultBackupLocation
        // GraphQL -> useDefaultBackupLocation: HostConfigurationPropertyEnabled (enum)
        if (ec.Includes("useDefaultBackupLocation",true))
        {
            if(this.UseDefaultBackupLocation == null) {

                this.UseDefaultBackupLocation = new HostConfigurationPropertyEnabled();

            } else {


            }
        }
        else if (this.UseDefaultBackupLocation != null && ec.Excludes("useDefaultBackupLocation",true))
        {
            this.UseDefaultBackupLocation = null;
        }
        //      C# -> System.Int32? Af2MinimumFileCount
        // GraphQL -> af2MinimumFileCount: Int (scalar)
        if (ec.Includes("af2MinimumFileCount",true))
        {
            if(this.Af2MinimumFileCount == null) {

                this.Af2MinimumFileCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Af2MinimumFileCount != null && ec.Excludes("af2MinimumFileCount",true))
        {
            this.Af2MinimumFileCount = null;
        }
        //      C# -> System.Int32? CbtMaxMemoryUsageInMb
        // GraphQL -> cbtMaxMemoryUsageInMb: Int (scalar)
        if (ec.Includes("cbtMaxMemoryUsageInMb",true))
        {
            if(this.CbtMaxMemoryUsageInMb == null) {

                this.CbtMaxMemoryUsageInMb = Int32.MinValue;

            } else {


            }
        }
        else if (this.CbtMaxMemoryUsageInMb != null && ec.Excludes("cbtMaxMemoryUsageInMb",true))
        {
            this.CbtMaxMemoryUsageInMb = null;
        }
        //      C# -> System.Int32? CmdPipeBufferSizeInKb
        // GraphQL -> cmdPipeBufferSizeInKb: Int (scalar)
        if (ec.Includes("cmdPipeBufferSizeInKb",true))
        {
            if(this.CmdPipeBufferSizeInKb == null) {

                this.CmdPipeBufferSizeInKb = Int32.MinValue;

            } else {


            }
        }
        else if (this.CmdPipeBufferSizeInKb != null && ec.Excludes("cmdPipeBufferSizeInKb",true))
        {
            this.CmdPipeBufferSizeInKb = null;
        }
        //      C# -> System.Int32? FileRestoreReadParallelism
        // GraphQL -> fileRestoreReadParallelism: Int (scalar)
        if (ec.Includes("fileRestoreReadParallelism",true))
        {
            if(this.FileRestoreReadParallelism == null) {

                this.FileRestoreReadParallelism = Int32.MinValue;

            } else {


            }
        }
        else if (this.FileRestoreReadParallelism != null && ec.Excludes("fileRestoreReadParallelism",true))
        {
            this.FileRestoreReadParallelism = null;
        }
        //      C# -> System.Int32? FileRestoreWriteParallelism
        // GraphQL -> fileRestoreWriteParallelism: Int (scalar)
        if (ec.Includes("fileRestoreWriteParallelism",true))
        {
            if(this.FileRestoreWriteParallelism == null) {

                this.FileRestoreWriteParallelism = Int32.MinValue;

            } else {


            }
        }
        else if (this.FileRestoreWriteParallelism != null && ec.Excludes("fileRestoreWriteParallelism",true))
        {
            this.FileRestoreWriteParallelism = null;
        }
        //      C# -> System.Int32? FileTransferParallelism
        // GraphQL -> fileTransferParallelism: Int (scalar)
        if (ec.Includes("fileTransferParallelism",true))
        {
            if(this.FileTransferParallelism == null) {

                this.FileTransferParallelism = Int32.MinValue;

            } else {


            }
        }
        else if (this.FileTransferParallelism != null && ec.Excludes("fileTransferParallelism",true))
        {
            this.FileTransferParallelism = null;
        }
        //      C# -> System.Int32? MaxDbLoadSizeInBytes
        // GraphQL -> maxDbLoadSizeInBytes: Int (scalar)
        if (ec.Includes("maxDbLoadSizeInBytes",true))
        {
            if(this.MaxDbLoadSizeInBytes == null) {

                this.MaxDbLoadSizeInBytes = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxDbLoadSizeInBytes != null && ec.Excludes("maxDbLoadSizeInBytes",true))
        {
            this.MaxDbLoadSizeInBytes = null;
        }
        //      C# -> System.Int32? MaxNodesForMultiNodeBackup
        // GraphQL -> maxNodesForMultiNodeBackup: Int (scalar)
        if (ec.Includes("maxNodesForMultiNodeBackup",true))
        {
            if(this.MaxNodesForMultiNodeBackup == null) {

                this.MaxNodesForMultiNodeBackup = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxNodesForMultiNodeBackup != null && ec.Excludes("maxNodesForMultiNodeBackup",true))
        {
            this.MaxNodesForMultiNodeBackup = null;
        }
        //      C# -> System.Int32? MaxNodesForMultiNodeRestore
        // GraphQL -> maxNodesForMultiNodeRestore: Int (scalar)
        if (ec.Includes("maxNodesForMultiNodeRestore",true))
        {
            if(this.MaxNodesForMultiNodeRestore == null) {

                this.MaxNodesForMultiNodeRestore = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxNodesForMultiNodeRestore != null && ec.Excludes("maxNodesForMultiNodeRestore",true))
        {
            this.MaxNodesForMultiNodeRestore = null;
        }
        //      C# -> System.Int32? MssqlDatabaseQueryTimeout
        // GraphQL -> mssqlDatabaseQueryTimeout: Int (scalar)
        if (ec.Includes("mssqlDatabaseQueryTimeout",true))
        {
            if(this.MssqlDatabaseQueryTimeout == null) {

                this.MssqlDatabaseQueryTimeout = Int32.MinValue;

            } else {


            }
        }
        else if (this.MssqlDatabaseQueryTimeout != null && ec.Excludes("mssqlDatabaseQueryTimeout",true))
        {
            this.MssqlDatabaseQueryTimeout = null;
        }
        //      C# -> System.Int32? MssqlDefaultMaxDataStreamsPerDatabase
        // GraphQL -> mssqlDefaultMaxDataStreamsPerDatabase: Int (scalar)
        if (ec.Includes("mssqlDefaultMaxDataStreamsPerDatabase",true))
        {
            if(this.MssqlDefaultMaxDataStreamsPerDatabase == null) {

                this.MssqlDefaultMaxDataStreamsPerDatabase = Int32.MinValue;

            } else {


            }
        }
        else if (this.MssqlDefaultMaxDataStreamsPerDatabase != null && ec.Excludes("mssqlDefaultMaxDataStreamsPerDatabase",true))
        {
            this.MssqlDefaultMaxDataStreamsPerDatabase = null;
        }
        //      C# -> System.Int32? MultiNodeRestoreMaxDataStreamsPerNode
        // GraphQL -> multiNodeRestoreMaxDataStreamsPerNode: Int (scalar)
        if (ec.Includes("multiNodeRestoreMaxDataStreamsPerNode",true))
        {
            if(this.MultiNodeRestoreMaxDataStreamsPerNode == null) {

                this.MultiNodeRestoreMaxDataStreamsPerNode = Int32.MinValue;

            } else {


            }
        }
        else if (this.MultiNodeRestoreMaxDataStreamsPerNode != null && ec.Excludes("multiNodeRestoreMaxDataStreamsPerNode",true))
        {
            this.MultiNodeRestoreMaxDataStreamsPerNode = null;
        }
        //      C# -> System.Int32? PhysicalHostDatabaseRestoreThrottleMaxRefCount
        // GraphQL -> physicalHostDatabaseRestoreThrottleMaxRefCount: Int (scalar)
        if (ec.Includes("physicalHostDatabaseRestoreThrottleMaxRefCount",true))
        {
            if(this.PhysicalHostDatabaseRestoreThrottleMaxRefCount == null) {

                this.PhysicalHostDatabaseRestoreThrottleMaxRefCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.PhysicalHostDatabaseRestoreThrottleMaxRefCount != null && ec.Excludes("physicalHostDatabaseRestoreThrottleMaxRefCount",true))
        {
            this.PhysicalHostDatabaseRestoreThrottleMaxRefCount = null;
        }
        //      C# -> System.Int32? PhysicalHostLogBackupThrottleMaxRefCount
        // GraphQL -> physicalHostLogBackupThrottleMaxRefCount: Int (scalar)
        if (ec.Includes("physicalHostLogBackupThrottleMaxRefCount",true))
        {
            if(this.PhysicalHostLogBackupThrottleMaxRefCount == null) {

                this.PhysicalHostLogBackupThrottleMaxRefCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.PhysicalHostLogBackupThrottleMaxRefCount != null && ec.Excludes("physicalHostLogBackupThrottleMaxRefCount",true))
        {
            this.PhysicalHostLogBackupThrottleMaxRefCount = null;
        }
        //      C# -> System.Int32? ThrottlePhysicalHostMaxRefCount
        // GraphQL -> throttlePhysicalHostMaxRefCount: Int (scalar)
        if (ec.Includes("throttlePhysicalHostMaxRefCount",true))
        {
            if(this.ThrottlePhysicalHostMaxRefCount == null) {

                this.ThrottlePhysicalHostMaxRefCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ThrottlePhysicalHostMaxRefCount != null && ec.Excludes("throttlePhysicalHostMaxRefCount",true))
        {
            this.ThrottlePhysicalHostMaxRefCount = null;
        }
        //      C# -> System.Int32? VdiRestoreMaxTimeoutInMinutes
        // GraphQL -> vdiRestoreMaxTimeoutInMinutes: Int (scalar)
        if (ec.Includes("vdiRestoreMaxTimeoutInMinutes",true))
        {
            if(this.VdiRestoreMaxTimeoutInMinutes == null) {

                this.VdiRestoreMaxTimeoutInMinutes = Int32.MinValue;

            } else {


            }
        }
        else if (this.VdiRestoreMaxTimeoutInMinutes != null && ec.Excludes("vdiRestoreMaxTimeoutInMinutes",true))
        {
            this.VdiRestoreMaxTimeoutInMinutes = null;
        }
        //      C# -> System.Int32? VdiRestoreTimeoutInSecondsPerGb
        // GraphQL -> vdiRestoreTimeoutInSecondsPerGb: Int (scalar)
        if (ec.Includes("vdiRestoreTimeoutInSecondsPerGb",true))
        {
            if(this.VdiRestoreTimeoutInSecondsPerGb == null) {

                this.VdiRestoreTimeoutInSecondsPerGb = Int32.MinValue;

            } else {


            }
        }
        else if (this.VdiRestoreTimeoutInSecondsPerGb != null && ec.Excludes("vdiRestoreTimeoutInSecondsPerGb",true))
        {
            this.VdiRestoreTimeoutInSecondsPerGb = null;
        }
    }


    #endregion

    } // class MssqlHostConfiguration
    
    #endregion

    public static class ListMssqlHostConfigurationExtensions
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
            this List<MssqlHostConfiguration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlHostConfiguration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlHostConfiguration> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlHostConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlHostConfiguration> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
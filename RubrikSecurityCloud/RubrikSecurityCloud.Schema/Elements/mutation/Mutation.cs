// Mutation.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region Mutation
    public class Mutation
    {
        #region members
        //      C# -> System.Boolean? AddInventoryWorkloads
        // GraphQL -> addInventoryWorkloads: Boolean! (scalar)
        public static string AddInventoryWorkloads(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("addInventoryWorkloads" + args + "\n");
        }

        //      C# -> System.Boolean? RemoveInventoryWorkloads
        // GraphQL -> removeInventoryWorkloads: Boolean! (scalar)
        public static string RemoveInventoryWorkloads(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removeInventoryWorkloads" + args + "\n");
        }

        //      C# -> LambdaSettings? UpdateLambdaSettings
        // GraphQL -> updateLambdaSettings: LambdaSettings! (type)
        public static string UpdateLambdaSettings(
            ref LambdaSettings? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "anomalyThreshold"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "ransomwareThreshold"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "isAnomalyAlertEnabled"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new LambdaSettings() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateLambdaSettings" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateWebhookReply? CreateWebhook
        // GraphQL -> createWebhook: CreateWebhookReply! (type)
        public static string CreateWebhook(
            ref CreateWebhookReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateWebhookReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createWebhook" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateWebhookReply? UpdateWebhook
        // GraphQL -> updateWebhook: UpdateWebhookReply! (type)
        public static string UpdateWebhook(
            ref UpdateWebhookReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateWebhookReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateWebhook" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteWebhook
        // GraphQL -> deleteWebhook: Void (scalar)
        public static string DeleteWebhook(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteWebhook" + args + "\n");
        }

        //      C# -> TestExistingWebhookReply? TestExistingWebhook
        // GraphQL -> testExistingWebhook: TestExistingWebhookReply! (type)
        public static string TestExistingWebhook(
            ref TestExistingWebhookReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TestExistingWebhookReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "testExistingWebhook" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TestWebhookReply? TestWebhook
        // GraphQL -> testWebhook: TestWebhookReply! (type)
        public static string TestWebhook(
            ref TestWebhookReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TestWebhookReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "testWebhook" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? CancelActivitySeries
        // GraphQL -> cancelActivitySeries: Boolean! (scalar)
        public static string CancelActivitySeries(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("cancelActivitySeries" + args + "\n");
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeEc2InstanceSnapshotsJob
        // GraphQL -> startAwsNativeEc2InstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeEc2InstanceSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startAwsNativeEc2InstanceSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartRecoverS3SnapshotJob
        // GraphQL -> startRecoverS3SnapshotJob: AsyncJobStatus! (type)
        public static string StartRecoverS3SnapshotJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startRecoverS3SnapshotJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartRestoreAwsNativeEc2InstanceSnapshotJob
        // GraphQL -> startRestoreAwsNativeEc2InstanceSnapshotJob: AsyncJobStatus! (type)
        public static string StartRestoreAwsNativeEc2InstanceSnapshotJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startRestoreAwsNativeEc2InstanceSnapshotJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAwsNativeAccountsJob
        // GraphQL -> startRefreshAwsNativeAccountsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAwsNativeAccountsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startRefreshAwsNativeAccountsJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAwsNativeEbsVolumeSnapshotsJob
        // GraphQL -> startCreateAwsNativeEbsVolumeSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAwsNativeEbsVolumeSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startCreateAwsNativeEbsVolumeSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartAwsNativeAccountDisableJob
        // GraphQL -> startAwsNativeAccountDisableJob: AsyncJobStatus! (type)
        public static string StartAwsNativeAccountDisableJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startAwsNativeAccountDisableJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartEc2InstanceSnapshotExportJob
        // GraphQL -> startEc2InstanceSnapshotExportJob: AsyncJobStatus! (type)
        public static string StartEc2InstanceSnapshotExportJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startEc2InstanceSnapshotExportJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportRdsInstanceJob
        // GraphQL -> startExportRdsInstanceJob: AsyncJobStatus! (type)
        public static string StartExportRdsInstanceJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startExportRdsInstanceJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAwsNativeEbsVolumeSnapshotJob
        // GraphQL -> startExportAwsNativeEbsVolumeSnapshotJob: AsyncJobStatus! (type)
        public static string StartExportAwsNativeEbsVolumeSnapshotJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startExportAwsNativeEbsVolumeSnapshotJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? ExcludeAwsNativeEbsVolumesFromSnapshot
        // GraphQL -> excludeAwsNativeEbsVolumesFromSnapshot: Void (scalar)
        public static string ExcludeAwsNativeEbsVolumesFromSnapshot(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("excludeAwsNativeEbsVolumesFromSnapshot" + args + "\n");
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeRdsInstanceSnapshotsJob
        // GraphQL -> startAwsNativeRdsInstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeRdsInstanceSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startAwsNativeRdsInstanceSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAzureNativeSubscriptionsJob
        // GraphQL -> startRefreshAzureNativeSubscriptionsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAzureNativeSubscriptionsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startRefreshAzureNativeSubscriptionsJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartRestoreAzureNativeVirtualMachineJob
        // GraphQL -> startRestoreAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartRestoreAzureNativeVirtualMachineJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startRestoreAzureNativeVirtualMachineJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeVirtualMachineJob
        // GraphQL -> startExportAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeVirtualMachineJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startExportAzureNativeVirtualMachineJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? ExcludeAzureNativeManagedDisksFromSnapshot
        // GraphQL -> excludeAzureNativeManagedDisksFromSnapshot: Void (scalar)
        public static string ExcludeAzureNativeManagedDisksFromSnapshot(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("excludeAzureNativeManagedDisksFromSnapshot" + args + "\n");
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeVirtualMachineSnapshotsJob
        // GraphQL -> startCreateAzureNativeVirtualMachineSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeVirtualMachineSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startCreateAzureNativeVirtualMachineSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartDisableAzureNativeSubscriptionProtectionJob
        // GraphQL -> startDisableAzureNativeSubscriptionProtectionJob: AsyncJobStatus! (type)
        public static string StartDisableAzureNativeSubscriptionProtectionJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startDisableAzureNativeSubscriptionProtectionJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeManagedDiskSnapshotsJob
        // GraphQL -> startCreateAzureNativeManagedDiskSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeManagedDiskSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startCreateAzureNativeManagedDiskSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeManagedDiskJob
        // GraphQL -> startExportAzureNativeManagedDiskJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeManagedDiskJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startExportAzureNativeManagedDiskJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlDatabaseDbJob
        // GraphQL -> startExportAzureSqlDatabaseDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlDatabaseDbJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startExportAzureSqlDatabaseDbJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlManagedInstanceDbJob
        // GraphQL -> startExportAzureSqlManagedInstanceDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlManagedInstanceDbJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startExportAzureSqlManagedInstanceDbJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? RecoverCassandraSource
        // GraphQL -> recoverCassandraSource: MosaicAsyncResponse! (type)
        public static string RecoverCassandraSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "recoverCassandraSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? CreateCassandraSource
        // GraphQL -> createCassandraSource: MosaicAsyncResponse! (type)
        public static string CreateCassandraSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createCassandraSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? UpdateCassandraSource
        // GraphQL -> updateCassandraSource: MosaicAsyncResponse! (type)
        public static string UpdateCassandraSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateCassandraSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? DeleteCassandraSource
        // GraphQL -> deleteCassandraSource: MosaicAsyncResponse! (type)
        public static string DeleteCassandraSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteCassandraSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SlaAssignResult? AssignProtection
        // GraphQL -> assignProtection: SlaAssignResult! (type)
        public static string AssignProtection(
            ref SlaAssignResult? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SlaAssignResult() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "assignProtection" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteCassandraSources
        // GraphQL -> bulkDeleteCassandraSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteCassandraSources(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkDeleteCassandraSources" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Csr? GenerateCsr
        // GraphQL -> generateCsr: Csr! (type)
        public static string GenerateCsr(
            ref Csr? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "name"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "hostnames"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "organization"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "organizationUnit"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "country"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "state"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "city"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "email"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "surname"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "userId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Csr() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "generateCsr" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? UpdateCertificate
        // GraphQL -> updateCertificate: Boolean! (scalar)
        public static string UpdateCertificate(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "certificateId"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "name"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "description"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "certificate"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateCertificate" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteCertificate
        // GraphQL -> deleteCertificate: Boolean! (scalar)
        public static string DeleteCertificate(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "certificateId"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCertificate" + args + "\n");
        }

        //      C# -> System.String? DeleteCsr
        // GraphQL -> deleteCsr: Void (scalar)
        public static string DeleteCsr(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCsr" + args + "\n");
        }

        //      C# -> CreateCloudNativeTagRuleReply? CreateCloudNativeTagRule
        // GraphQL -> createCloudNativeTagRule: CreateCloudNativeTagRuleReply! (type)
        public static string CreateCloudNativeTagRule(
            ref CreateCloudNativeTagRuleReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeTagRuleReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createCloudNativeTagRule" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeLabelRuleReply? CreateCloudNativeLabelRule
        // GraphQL -> createCloudNativeLabelRule: CreateCloudNativeLabelRuleReply! (type)
        public static string CreateCloudNativeLabelRule(
            ref CreateCloudNativeLabelRuleReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeLabelRuleReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createCloudNativeLabelRule" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateCloudNativeTagRule
        // GraphQL -> updateCloudNativeTagRule: Void (scalar)
        public static string UpdateCloudNativeTagRule(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateCloudNativeTagRule" + args + "\n");
        }

        //      C# -> System.String? UpdateCloudNativeLabelRule
        // GraphQL -> updateCloudNativeLabelRule: Void (scalar)
        public static string UpdateCloudNativeLabelRule(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateCloudNativeLabelRule" + args + "\n");
        }

        //      C# -> System.String? DeleteCloudNativeTagRule
        // GraphQL -> deleteCloudNativeTagRule: Void (scalar)
        public static string DeleteCloudNativeTagRule(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCloudNativeTagRule" + args + "\n");
        }

        //      C# -> System.String? DeleteCloudNativeLabelRule
        // GraphQL -> deleteCloudNativeLabelRule: Void (scalar)
        public static string DeleteCloudNativeLabelRule(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCloudNativeLabelRule" + args + "\n");
        }

        //      C# -> UpdateCloudNativeIndexingStatusReply? UpdateCloudNativeIndexingStatus
        // GraphQL -> updateCloudNativeIndexingStatus: UpdateCloudNativeIndexingStatusReply! (type)
        public static string UpdateCloudNativeIndexingStatus(
            ref UpdateCloudNativeIndexingStatusReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateCloudNativeIndexingStatusReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateCloudNativeIndexingStatus" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartCloudNativeSnapshotsIndexJob
        // GraphQL -> startCloudNativeSnapshotsIndexJob: BatchAsyncJobStatus! (type)
        public static string StartCloudNativeSnapshotsIndexJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startCloudNativeSnapshotsIndexJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadFilesReply? CloudNativeDownloadFiles
        // GraphQL -> cloudNativeDownloadFiles: DownloadFilesReply! (type)
        public static string CloudNativeDownloadFiles(
            ref DownloadFilesReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadFilesReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "cloudNativeDownloadFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddVmAppConsistentSpecsReply? AddVmAppConsistentSpecs
        // GraphQL -> addVmAppConsistentSpecs: AddVmAppConsistentSpecsReply! (type)
        public static string AddVmAppConsistentSpecs(
            ref AddVmAppConsistentSpecsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddVmAppConsistentSpecsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addVmAppConsistentSpecs" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> EnableDisableAppConsistencyReply? EnableDisableAppConsistency
        // GraphQL -> enableDisableAppConsistency: EnableDisableAppConsistencyReply! (type)
        public static string EnableDisableAppConsistency(
            ref EnableDisableAppConsistencyReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new EnableDisableAppConsistencyReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "enableDisableAppConsistency" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CloudNativeCheckRbaConnectivityReply? CloudNativeCheckRbaConnectivity
        // GraphQL -> cloudNativeCheckRbaConnectivity: CloudNativeCheckRbaConnectivityReply! (type)
        public static string CloudNativeCheckRbaConnectivity(
            ref CloudNativeCheckRbaConnectivityReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CloudNativeCheckRbaConnectivityReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "cloudNativeCheckRbaConnectivity" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddCloudNativeSqlServerBackupCredentialsReply? AddCloudNativeSqlServerBackupCredentials
        // GraphQL -> addCloudNativeSqlServerBackupCredentials: AddCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string AddCloudNativeSqlServerBackupCredentials(
            ref AddCloudNativeSqlServerBackupCredentialsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddCloudNativeSqlServerBackupCredentialsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addCloudNativeSqlServerBackupCredentials" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ClearCloudNativeSqlServerBackupCredentialsReply? ClearCloudNativeSqlServerBackupCredentials
        // GraphQL -> clearCloudNativeSqlServerBackupCredentials: ClearCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string ClearCloudNativeSqlServerBackupCredentials(
            ref ClearCloudNativeSqlServerBackupCredentialsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClearCloudNativeSqlServerBackupCredentialsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "clearCloudNativeSqlServerBackupCredentials" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? SetupCloudNativeSqlServerBackup
        // GraphQL -> setupCloudNativeSqlServerBackup: BatchAsyncJobStatus! (type)
        public static string SetupCloudNativeSqlServerBackup(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "setupCloudNativeSqlServerBackup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? UploadDatabaseSnapshotToBlobstore
        // GraphQL -> uploadDatabaseSnapshotToBlobstore: AsyncJobStatus! (type)
        public static string UploadDatabaseSnapshotToBlobstore(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "uploadDatabaseSnapshotToBlobstore" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? AddNodesToCloudCluster
        // GraphQL -> addNodesToCloudCluster: CcProvisionJobReply! (type)
        public static string AddNodesToCloudCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addNodesToCloudCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RegisterCloudClusterReply? RegisterCloudCluster
        // GraphQL -> registerCloudCluster: RegisterCloudClusterReply! (type)
        public static string RegisterCloudCluster(
            ref RegisterCloudClusterReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RegisterCloudClusterReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "registerCloudCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? RemoveCloudClusterNodes
        // GraphQL -> removeCloudClusterNodes: CcProvisionJobReply! (type)
        public static string RemoveCloudClusterNodes(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "removeCloudClusterNodes" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateTunnelStatusReply? UpdateTunnelStatus
        // GraphQL -> updateTunnelStatus: UpdateTunnelStatusReply! (type)
        public static string UpdateTunnelStatus(
            ref UpdateTunnelStatusReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateTunnelStatusReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateTunnelStatus" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateClusterDefaultAddressReply? UpdateClusterDefaultAddress
        // GraphQL -> updateClusterDefaultAddress: UpdateClusterDefaultAddressReply! (type)
        public static string UpdateClusterDefaultAddress(
            ref UpdateClusterDefaultAddressReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateClusterDefaultAddressReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateClusterDefaultAddress" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GlobalManagerConnectivity? RefreshGlobalManagerConnectivityStatus
        // GraphQL -> refreshGlobalManagerConnectivityStatus: GlobalManagerConnectivity! (type)
        public static string RefreshGlobalManagerConnectivityStatus(
            ref GlobalManagerConnectivity? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "clusterUuid"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GlobalManagerConnectivity() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshGlobalManagerConnectivityStatus" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateBadDiskLedStatusReply? UpdateBadDiskLedStatus
        // GraphQL -> updateBadDiskLedStatus: UpdateBadDiskLedStatusReply! (type)
        public static string UpdateBadDiskLedStatus(
            ref UpdateBadDiskLedStatusReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateBadDiskLedStatusReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateBadDiskLedStatus" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateHealthMonitorPolicyStatusReply? UpdateHealthMonitorPolicyStatus
        // GraphQL -> updateHealthMonitorPolicyStatus: UpdateHealthMonitorPolicyStatusReply! (type)
        public static string UpdateHealthMonitorPolicyStatus(
            ref UpdateHealthMonitorPolicyStatusReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateHealthMonitorPolicyStatusReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateHealthMonitorPolicyStatus" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GetHealthMonitorPolicyStatusReply? GetHealthMonitorPolicyStatus
        // GraphQL -> getHealthMonitorPolicyStatus: GetHealthMonitorPolicyStatusReply! (type)
        public static string GetHealthMonitorPolicyStatus(
            ref GetHealthMonitorPolicyStatusReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetHealthMonitorPolicyStatusReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "getHealthMonitorPolicyStatus" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? ResizeDisk
        // GraphQL -> resizeDisk: ResponseSuccess! (type)
        public static string ResizeDisk(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "resizeDisk" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Cluster? UpdateClusterLocation
        // GraphQL -> updateClusterLocation: Cluster! (type)
        public static string UpdateClusterLocation(
            ref Cluster? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "clusterUuid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "clusterLocation"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Cluster() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateClusterLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? UpdateClusterNtpServers
        // GraphQL -> updateClusterNtpServers: ResponseSuccess! (type)
        public static string UpdateClusterNtpServers(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateClusterNtpServers" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? AddVlan
        // GraphQL -> addVlan: ResponseSuccess! (type)
        public static string AddVlan(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addVlan" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RemoveVlansReply? RemoveVlans
        // GraphQL -> removeVlans: RemoveVlansReply! (type)
        public static string RemoveVlans(
            ref RemoveVlansReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RemoveVlansReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "removeVlans" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? UpdateDnsServersAndSearchDomains
        // GraphQL -> updateDnsServersAndSearchDomains: ResponseSuccess! (type)
        public static string UpdateDnsServersAndSearchDomains(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateDnsServersAndSearchDomains" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateFloatingIpsReply? UpdateFloatingIps
        // GraphQL -> updateFloatingIps: UpdateFloatingIpsReply! (type)
        public static string UpdateFloatingIps(
            ref UpdateFloatingIpsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateFloatingIpsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateFloatingIps" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateProxyConfigReply? UpdateProxyConfig
        // GraphQL -> updateProxyConfig: UpdateProxyConfigReply! (type)
        public static string UpdateProxyConfig(
            ref UpdateProxyConfigReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateProxyConfigReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateProxyConfig" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? RemoveProxyConfig
        // GraphQL -> removeProxyConfig: ResponseSuccess! (type)
        public static string RemoveProxyConfig(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "removeProxyConfig" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DiskInfo? SetupDisk
        // GraphQL -> setupDisk: DiskInfo! (type)
        public static string SetupDisk(
            ref DiskInfo? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DiskInfo() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "setupDisk" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? RemoveDisk
        // GraphQL -> removeDisk: ResponseSuccess! (type)
        public static string RemoveDisk(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "removeDisk" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddClusterNodesReply? AddClusterNodes
        // GraphQL -> addClusterNodes: AddClusterNodesReply! (type)
        public static string AddClusterNodes(
            ref AddClusterNodesReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "addClusterNodesInput"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddClusterNodesReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addClusterNodes" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? RemoveClusterNodes
        // GraphQL -> removeClusterNodes: CcProvisionJobReply! (type)
        public static string RemoveClusterNodes(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "removeClusterNodes" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateClusterSettingsReply? UpdateClusterSettings
        // GraphQL -> updateClusterSettings: UpdateClusterSettingsReply! (type)
        public static string UpdateClusterSettings(
            ref UpdateClusterSettingsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateClusterSettingsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateClusterSettings" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ModifyIpmiReply? ModifyIpmi
        // GraphQL -> modifyIpmi: ModifyIpmiReply! (type)
        public static string ModifyIpmi(
            ref ModifyIpmiReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ModifyIpmiReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "modifyIpmi" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? SetWebSignedCertificate
        // GraphQL -> setWebSignedCertificate: AsyncRequestStatus! (type)
        public static string SetWebSignedCertificate(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "setWebSignedCertificate" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddClusterCertificateReply? AddClusterCertificate
        // GraphQL -> addClusterCertificate: AddClusterCertificateReply! (type)
        public static string AddClusterCertificate(
            ref AddClusterCertificateReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddClusterCertificateReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addClusterCertificate" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DeleteFailedClusterOperationJobDataReply? DeleteFailedClusterOperationJobData
        // GraphQL -> deleteFailedClusterOperationJobData: DeleteFailedClusterOperationJobDataReply! (type)
        public static string DeleteFailedClusterOperationJobData(
            ref DeleteFailedClusterOperationJobDataReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DeleteFailedClusterOperationJobDataReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteFailedClusterOperationJobData" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? GenerateSupportBundle
        // GraphQL -> generateSupportBundle: AsyncRequestStatus! (type)
        public static string GenerateSupportBundle(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "generateSupportBundle" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GenerateConfigProtectionRestoreFormReply? GenerateConfigProtectionRestoreForm
        // GraphQL -> generateConfigProtectionRestoreForm: GenerateConfigProtectionRestoreFormReply! (type)
        public static string GenerateConfigProtectionRestoreForm(
            ref GenerateConfigProtectionRestoreFormReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GenerateConfigProtectionRestoreFormReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "generateConfigProtectionRestoreForm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CloudAccount? CreateAwsAccount
        // GraphQL -> createAwsAccount: CloudAccount! (interface)
        public static string CreateAwsAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (CloudAccount)InterfaceHelper.CreateInstanceOfFirstType(typeof(CloudAccount)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAwsAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CloudAccount? UpdateAwsAccount
        // GraphQL -> updateAwsAccount: CloudAccount! (interface)
        public static string UpdateAwsAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (CloudAccount)InterfaceHelper.CreateInstanceOfFirstType(typeof(CloudAccount)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAwsAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CloudAccount? CreateAzureAccount
        // GraphQL -> createAzureAccount: CloudAccount! (interface)
        public static string CreateAzureAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (CloudAccount)InterfaceHelper.CreateInstanceOfFirstType(typeof(CloudAccount)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAzureAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CloudAccount? UpdateAzureAccount
        // GraphQL -> updateAzureAccount: CloudAccount! (interface)
        public static string UpdateAzureAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (CloudAccount)InterfaceHelper.CreateInstanceOfFirstType(typeof(CloudAccount)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAzureAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TargetMapping? CreateManualTargetMapping
        // GraphQL -> createManualTargetMapping: TargetMapping! (type)
        public static string CreateManualTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createManualTargetMapping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TargetMapping? CreateAutomaticAwsTargetMapping
        // GraphQL -> createAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAwsTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAutomaticAwsTargetMapping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TargetMapping? CreateAutomaticAzureTargetMapping
        // GraphQL -> createAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAzureTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAutomaticAzureTargetMapping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TargetMapping? CreateAutomaticRcsTargetMapping
        // GraphQL -> createAutomaticRcsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticRcsTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAutomaticRcsTargetMapping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<Target>? CreateRcvLocationsFromTemplate
        // GraphQL -> createRcvLocationsFromTemplate: [Target!]! (interface)
        public static string CreateRcvLocationsFromTemplate(
            ref List<Target>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<Target>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createRcvLocationsFromTemplate" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeAwsStorageSettingReply? CreateCloudNativeAwsStorageSetting
        // GraphQL -> createCloudNativeAwsStorageSetting: CreateCloudNativeAwsStorageSettingReply! (type)
        public static string CreateCloudNativeAwsStorageSetting(
            ref CreateCloudNativeAwsStorageSettingReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeAwsStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createCloudNativeAwsStorageSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeAzureStorageSettingReply? CreateCloudNativeAzureStorageSetting
        // GraphQL -> createCloudNativeAzureStorageSetting: CreateCloudNativeAzureStorageSettingReply! (type)
        public static string CreateCloudNativeAzureStorageSetting(
            ref CreateCloudNativeAzureStorageSettingReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeAzureStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createCloudNativeAzureStorageSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeRcvAzureStorageSettingReply? CreateCloudNativeRcvAzureStorageSetting
        // GraphQL -> createCloudNativeRcvAzureStorageSetting: CreateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string CreateCloudNativeRcvAzureStorageSetting(
            ref CreateCloudNativeRcvAzureStorageSettingReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeRcvAzureStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createCloudNativeRcvAzureStorageSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TargetMapping? UpdateManualTargetMapping
        // GraphQL -> updateManualTargetMapping: TargetMapping! (type)
        public static string UpdateManualTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateManualTargetMapping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TargetMapping? UpdateAutomaticAwsTargetMapping
        // GraphQL -> updateAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAwsTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAutomaticAwsTargetMapping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TargetMapping? UpdateAutomaticAzureTargetMapping
        // GraphQL -> updateAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAzureTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAutomaticAzureTargetMapping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TargetMapping? UpdateRcsAutomaticTargetMapping
        // GraphQL -> updateRcsAutomaticTargetMapping: TargetMapping! (type)
        public static string UpdateRcsAutomaticTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateRcsAutomaticTargetMapping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TriggerCloudComputeConnectivityCheck
        // GraphQL -> triggerCloudComputeConnectivityCheck: AsyncRequestStatus! (type)
        public static string TriggerCloudComputeConnectivityCheck(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "triggerCloudComputeConnectivityCheck" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateCloudNativeAwsStorageSettingReply? UpdateCloudNativeAwsStorageSetting
        // GraphQL -> updateCloudNativeAwsStorageSetting: UpdateCloudNativeAwsStorageSettingReply! (type)
        public static string UpdateCloudNativeAwsStorageSetting(
            ref UpdateCloudNativeAwsStorageSettingReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateCloudNativeAwsStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateCloudNativeAwsStorageSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateCloudNativeAzureStorageSettingReply? UpdateCloudNativeAzureStorageSetting
        // GraphQL -> updateCloudNativeAzureStorageSetting: UpdateCloudNativeAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeAzureStorageSetting(
            ref UpdateCloudNativeAzureStorageSettingReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateCloudNativeAzureStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateCloudNativeAzureStorageSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateCloudNativeRcvAzureStorageSettingReply? UpdateCloudNativeRcvAzureStorageSetting
        // GraphQL -> updateCloudNativeRcvAzureStorageSetting: UpdateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeRcvAzureStorageSetting(
            ref UpdateCloudNativeRcvAzureStorageSettingReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateCloudNativeRcvAzureStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateCloudNativeRcvAzureStorageSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteTargetMapping
        // GraphQL -> deleteTargetMapping: Void (scalar)
        public static string DeleteTargetMapping(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteTargetMapping" + args + "\n");
        }

        //      C# -> System.String? DeleteReplicationPair
        // GraphQL -> deleteReplicationPair: Void (scalar)
        public static string DeleteReplicationPair(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteReplicationPair" + args + "\n");
        }

        //      C# -> Target? CreateAwsTarget
        // GraphQL -> createAwsTarget: Target! (interface)
        public static string CreateAwsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAwsTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? UpdateAwsTarget
        // GraphQL -> updateAwsTarget: Target! (interface)
        public static string UpdateAwsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAwsTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateAzureTarget
        // GraphQL -> createAzureTarget: Target! (interface)
        public static string CreateAzureTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAzureTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? UpdateAzureTarget
        // GraphQL -> updateAzureTarget: Target! (interface)
        public static string UpdateAzureTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAzureTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateNfsTarget
        // GraphQL -> createNfsTarget: Target! (interface)
        public static string CreateNfsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createNfsTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? UpdateNfsTarget
        // GraphQL -> updateNfsTarget: Target! (interface)
        public static string UpdateNfsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateNfsTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateRcsTarget
        // GraphQL -> createRcsTarget: Target! (interface)
        public static string CreateRcsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createRcsTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? UpdateRcvTarget
        // GraphQL -> updateRcvTarget: Target! (interface)
        public static string UpdateRcvTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateRcvTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateS3CompatibleTarget
        // GraphQL -> createS3CompatibleTarget: Target! (interface)
        public static string CreateS3CompatibleTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createS3CompatibleTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? UpdateS3CompatibleTarget
        // GraphQL -> updateS3CompatibleTarget: Target! (interface)
        public static string UpdateS3CompatibleTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateS3CompatibleTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateGcpTarget
        // GraphQL -> createGcpTarget: Target! (interface)
        public static string CreateGcpTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createGcpTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? UpdateGcpTarget
        // GraphQL -> updateGcpTarget: Target! (interface)
        public static string UpdateGcpTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateGcpTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateGcpReaderTarget
        // GraphQL -> createGcpReaderTarget: Target! (interface)
        public static string CreateGcpReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createGcpReaderTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? UpdateGlacierTarget
        // GraphQL -> updateGlacierTarget: Target! (interface)
        public static string UpdateGlacierTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateGlacierTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateGlacierReaderTarget
        // GraphQL -> createGlacierReaderTarget: Target! (interface)
        public static string CreateGlacierReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createGlacierReaderTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateAwsReaderTarget
        // GraphQL -> createAwsReaderTarget: Target! (interface)
        public static string CreateAwsReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAwsReaderTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateAzureReaderTarget
        // GraphQL -> createAzureReaderTarget: Target! (interface)
        public static string CreateAzureReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAzureReaderTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateNfsReaderTarget
        // GraphQL -> createNfsReaderTarget: Target! (interface)
        public static string CreateNfsReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createNfsReaderTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateS3CompatibleReaderTarget
        // GraphQL -> createS3CompatibleReaderTarget: Target! (interface)
        public static string CreateS3CompatibleReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createS3CompatibleReaderTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateRcsReaderTarget
        // GraphQL -> createRcsReaderTarget: Target! (interface)
        public static string CreateRcsReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createRcsReaderTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteTarget
        // GraphQL -> deleteTarget: Void (scalar)
        public static string DeleteTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteTarget" + args + "\n");
        }

        //      C# -> PauseTargetReply? PauseTarget
        // GraphQL -> pauseTarget: PauseTargetReply! (type)
        public static string PauseTarget(
            ref PauseTargetReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PauseTargetReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "pauseTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResumeTargetReply? ResumeTarget
        // GraphQL -> resumeTarget: ResumeTargetReply! (type)
        public static string ResumeTarget(
            ref ResumeTargetReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResumeTargetReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "resumeTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DisableTargetReply? DisableTarget
        // GraphQL -> disableTarget: DisableTargetReply! (type)
        public static string DisableTarget(
            ref DisableTargetReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DisableTargetReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "disableTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> EnableTargetReply? EnableTarget
        // GraphQL -> enableTarget: EnableTargetReply! (type)
        public static string EnableTarget(
            ref EnableTargetReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new EnableTargetReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "enableTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? RefreshReaderTarget
        // GraphQL -> refreshReaderTarget: Void (scalar)
        public static string RefreshReaderTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("refreshReaderTarget" + args + "\n");
        }

        //      C# -> System.String? PromoteReaderTarget
        // GraphQL -> promoteReaderTarget: Void (scalar)
        public static string PromoteReaderTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("promoteReaderTarget" + args + "\n");
        }

        //      C# -> AwsComputeSettings? CreateAwsComputeSetting
        // GraphQL -> createAwsComputeSetting: AwsComputeSettings! (type)
        public static string CreateAwsComputeSetting(
            ref AwsComputeSettings? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsComputeSettings() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAwsComputeSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AwsComputeSettings? UpdateAwsComputeSetting
        // GraphQL -> updateAwsComputeSetting: AwsComputeSettings! (type)
        public static string UpdateAwsComputeSetting(
            ref AwsComputeSettings? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsComputeSettings() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAwsComputeSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteAwsComputeSetting
        // GraphQL -> deleteAwsComputeSetting: Void (scalar)
        public static string DeleteAwsComputeSetting(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteAwsComputeSetting" + args + "\n");
        }

        //      C# -> System.String? CreateReplicationPair
        // GraphQL -> createReplicationPair: Void (scalar)
        public static string CreateReplicationPair(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createReplicationPair" + args + "\n");
        }

        //      C# -> System.String? UpdateReplicationTarget
        // GraphQL -> updateReplicationTarget: Void (scalar)
        public static string UpdateReplicationTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateReplicationTarget" + args + "\n");
        }

        //      C# -> UpdateNetworkThrottleReply? UpdateNetworkThrottle
        // GraphQL -> updateNetworkThrottle: UpdateNetworkThrottleReply! (type)
        public static string UpdateNetworkThrottle(
            ref UpdateNetworkThrottleReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateNetworkThrottleReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateNetworkThrottle" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? EnableReplicationPause
        // GraphQL -> enableReplicationPause: ResponseSuccess! (type)
        public static string EnableReplicationPause(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "enableReplicationPause" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DisableReplicationPause
        // GraphQL -> disableReplicationPause: ResponseSuccess! (type)
        public static string DisableReplicationPause(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "disableReplicationPause" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? AddMosaicStore
        // GraphQL -> addMosaicStore: MosaicAsyncResponse! (type)
        public static string AddMosaicStore(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addMosaicStore" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? UpdateMosaicStore
        // GraphQL -> updateMosaicStore: MosaicAsyncResponse! (type)
        public static string UpdateMosaicStore(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateMosaicStore" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? DeleteMosaicStore
        // GraphQL -> deleteMosaicStore: MosaicAsyncResponse! (type)
        public static string DeleteMosaicStore(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteMosaicStore" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateRcvPrivateEndpointApprovalRequestReply? CreateRcvPrivateEndpointApprovalRequest
        // GraphQL -> createRcvPrivateEndpointApprovalRequest: CreateRcvPrivateEndpointApprovalRequestReply! (type)
        public static string CreateRcvPrivateEndpointApprovalRequest(
            ref CreateRcvPrivateEndpointApprovalRequestReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateRcvPrivateEndpointApprovalRequestReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createRcvPrivateEndpointApprovalRequest" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? RemovePrivateEndpointConnection
        // GraphQL -> removePrivateEndpointConnection: Void (scalar)
        public static string RemovePrivateEndpointConnection(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removePrivateEndpointConnection" + args + "\n");
        }

        //      C# -> Target? CreateTapeTarget
        // GraphQL -> createTapeTarget: Target! (interface)
        public static string CreateTapeTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createTapeTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? UpdateTapeTarget
        // GraphQL -> updateTapeTarget: Target! (interface)
        public static string UpdateTapeTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateTapeTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Target? CreateTapeReaderTarget
        // GraphQL -> createTapeReaderTarget: Target! (interface)
        public static string CreateTapeReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target)) ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createTapeReaderTarget" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ValidateAndCreateAwsCloudAccountReply? ValidateAndCreateAwsCloudAccount
        // GraphQL -> validateAndCreateAwsCloudAccount: ValidateAndCreateAwsCloudAccountReply! (type)
        public static string ValidateAndCreateAwsCloudAccount(
            ref ValidateAndCreateAwsCloudAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateAndCreateAwsCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "validateAndCreateAwsCloudAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> FinalizeAwsCloudAccountProtectionReply? FinalizeAwsCloudAccountProtection
        // GraphQL -> finalizeAwsCloudAccountProtection: FinalizeAwsCloudAccountProtectionReply! (type)
        public static string FinalizeAwsCloudAccountProtection(
            ref FinalizeAwsCloudAccountProtectionReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FinalizeAwsCloudAccountProtectionReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "finalizeAwsCloudAccountProtection" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> PrepareAwsCloudAccountDeletionReply? PrepareAwsCloudAccountDeletion
        // GraphQL -> prepareAwsCloudAccountDeletion: PrepareAwsCloudAccountDeletionReply! (type)
        public static string PrepareAwsCloudAccountDeletion(
            ref PrepareAwsCloudAccountDeletionReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PrepareAwsCloudAccountDeletionReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "prepareAwsCloudAccountDeletion" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> FinalizeAwsCloudAccountDeletionReply? FinalizeAwsCloudAccountDeletion
        // GraphQL -> finalizeAwsCloudAccountDeletion: FinalizeAwsCloudAccountDeletionReply! (type)
        public static string FinalizeAwsCloudAccountDeletion(
            ref FinalizeAwsCloudAccountDeletionReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FinalizeAwsCloudAccountDeletionReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "finalizeAwsCloudAccountDeletion" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateAwsCloudAccountFeatureReply? UpdateAwsCloudAccountFeature
        // GraphQL -> updateAwsCloudAccountFeature: UpdateAwsCloudAccountFeatureReply! (type)
        public static string UpdateAwsCloudAccountFeature(
            ref UpdateAwsCloudAccountFeatureReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateAwsCloudAccountFeatureReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAwsCloudAccountFeature" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateAwsCloudAccount
        // GraphQL -> updateAwsCloudAccount: Void (scalar)
        public static string UpdateAwsCloudAccount(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateAwsCloudAccount" + args + "\n");
        }

        //      C# -> PrepareFeatureUpdateForAwsCloudAccountReply? PrepareFeatureUpdateForAwsCloudAccount
        // GraphQL -> prepareFeatureUpdateForAwsCloudAccount: PrepareFeatureUpdateForAwsCloudAccountReply! (type)
        public static string PrepareFeatureUpdateForAwsCloudAccount(
            ref PrepareFeatureUpdateForAwsCloudAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PrepareFeatureUpdateForAwsCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "prepareFeatureUpdateForAwsCloudAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ListCidrsForComputeSettingReply? ListCidrsForComputeSetting
        // GraphQL -> listCidrsForComputeSetting: ListCidrsForComputeSettingReply! (type)
        public static string ListCidrsForComputeSetting(
            ref ListCidrsForComputeSettingReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ListCidrsForComputeSettingReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "listCidrsForComputeSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateAwsExocomputeConfigsReply? CreateAwsExocomputeConfigs
        // GraphQL -> createAwsExocomputeConfigs: CreateAwsExocomputeConfigsReply! (type)
        public static string CreateAwsExocomputeConfigs(
            ref CreateAwsExocomputeConfigsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateAwsExocomputeConfigsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAwsExocomputeConfigs" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DeleteAwsExocomputeConfigsReply? DeleteAwsExocomputeConfigs
        // GraphQL -> deleteAwsExocomputeConfigs: DeleteAwsExocomputeConfigsReply! (type)
        public static string DeleteAwsExocomputeConfigs(
            ref DeleteAwsExocomputeConfigsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DeleteAwsExocomputeConfigsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteAwsExocomputeConfigs" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> StartAzureCloudAccountOauthReply? StartAzureCloudAccountOauth
        // GraphQL -> startAzureCloudAccountOauth: StartAzureCloudAccountOauthReply! (type)
        public static string StartAzureCloudAccountOauth(
            ref StartAzureCloudAccountOauthReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new StartAzureCloudAccountOauthReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startAzureCloudAccountOauth" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CompleteAzureCloudAccountOauthReply? CompleteAzureCloudAccountOauth
        // GraphQL -> completeAzureCloudAccountOauth: CompleteAzureCloudAccountOauthReply! (type)
        public static string CompleteAzureCloudAccountOauth(
            ref CompleteAzureCloudAccountOauthReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CompleteAzureCloudAccountOauthReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "completeAzureCloudAccountOauth" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? SetAzureCloudAccountCustomerAppCredentials
        // GraphQL -> setAzureCloudAccountCustomerAppCredentials: Boolean! (scalar)
        public static string SetAzureCloudAccountCustomerAppCredentials(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setAzureCloudAccountCustomerAppCredentials" + args + "\n");
        }

        //      C# -> AddAzureCloudAccountReply? AddAzureCloudAccount
        // GraphQL -> addAzureCloudAccount: AddAzureCloudAccountReply! (type)
        public static string AddAzureCloudAccount(
            ref AddAzureCloudAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddAzureCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addAzureCloudAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddAzureCloudAccountWithoutOauthReply? AddAzureCloudAccountWithoutOauth
        // GraphQL -> addAzureCloudAccountWithoutOauth: AddAzureCloudAccountWithoutOauthReply! (type)
        public static string AddAzureCloudAccountWithoutOauth(
            ref AddAzureCloudAccountWithoutOauthReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddAzureCloudAccountWithoutOauthReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addAzureCloudAccountWithoutOauth" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DeleteAzureCloudAccountReply? DeleteAzureCloudAccount
        // GraphQL -> deleteAzureCloudAccount: DeleteAzureCloudAccountReply! (type)
        public static string DeleteAzureCloudAccount(
            ref DeleteAzureCloudAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DeleteAzureCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteAzureCloudAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DeleteAzureCloudAccountWithoutOauthReply? DeleteAzureCloudAccountWithoutOauth
        // GraphQL -> deleteAzureCloudAccountWithoutOauth: DeleteAzureCloudAccountWithoutOauthReply! (type)
        public static string DeleteAzureCloudAccountWithoutOauth(
            ref DeleteAzureCloudAccountWithoutOauthReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DeleteAzureCloudAccountWithoutOauthReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteAzureCloudAccountWithoutOauth" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpgradeAzureCloudAccountReply? UpgradeAzureCloudAccount
        // GraphQL -> upgradeAzureCloudAccount: UpgradeAzureCloudAccountReply! (type)
        public static string UpgradeAzureCloudAccount(
            ref UpgradeAzureCloudAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpgradeAzureCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "upgradeAzureCloudAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateCustomerAppPermissionForAzureSql
        // GraphQL -> updateCustomerAppPermissionForAzureSql: Void (scalar)
        public static string UpdateCustomerAppPermissionForAzureSql(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateCustomerAppPermissionForAzureSql" + args + "\n");
        }

        //      C# -> BatchAsyncJobStatus? StartDisableAzureCloudAccountJob
        // GraphQL -> startDisableAzureCloudAccountJob: BatchAsyncJobStatus! (type)
        public static string StartDisableAzureCloudAccountJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startDisableAzureCloudAccountJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateAzureCloudAccountReply? UpdateAzureCloudAccount
        // GraphQL -> updateAzureCloudAccount: UpdateAzureCloudAccountReply! (type)
        public static string UpdateAzureCloudAccount(
            ref UpdateAzureCloudAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateAzureCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAzureCloudAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MapAzureCloudAccountToPersistentStorageLocationReply? MapAzureCloudAccountToPersistentStorageLocation
        // GraphQL -> mapAzureCloudAccountToPersistentStorageLocation: MapAzureCloudAccountToPersistentStorageLocationReply! (type)
        public static string MapAzureCloudAccountToPersistentStorageLocation(
            ref MapAzureCloudAccountToPersistentStorageLocationReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MapAzureCloudAccountToPersistentStorageLocationReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "mapAzureCloudAccountToPersistentStorageLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddAzureCloudAccountExocomputeConfigurationsReply? AddAzureCloudAccountExocomputeConfigurations
        // GraphQL -> addAzureCloudAccountExocomputeConfigurations: AddAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string AddAzureCloudAccountExocomputeConfigurations(
            ref AddAzureCloudAccountExocomputeConfigurationsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddAzureCloudAccountExocomputeConfigurationsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addAzureCloudAccountExocomputeConfigurations" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DeleteAzureCloudAccountExocomputeConfigurationsReply? DeleteAzureCloudAccountExocomputeConfigurations
        // GraphQL -> deleteAzureCloudAccountExocomputeConfigurations: DeleteAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string DeleteAzureCloudAccountExocomputeConfigurations(
            ref DeleteAzureCloudAccountExocomputeConfigurationsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DeleteAzureCloudAccountExocomputeConfigurationsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteAzureCloudAccountExocomputeConfigurations" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MapAzureCloudAccountExocomputeSubscriptionReply? MapAzureCloudAccountExocomputeSubscription
        // GraphQL -> mapAzureCloudAccountExocomputeSubscription: MapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string MapAzureCloudAccountExocomputeSubscription(
            ref MapAzureCloudAccountExocomputeSubscriptionReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MapAzureCloudAccountExocomputeSubscriptionReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "mapAzureCloudAccountExocomputeSubscription" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UnmapAzureCloudAccountExocomputeSubscriptionReply? UnmapAzureCloudAccountExocomputeSubscription
        // GraphQL -> unmapAzureCloudAccountExocomputeSubscription: UnmapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string UnmapAzureCloudAccountExocomputeSubscription(
            ref UnmapAzureCloudAccountExocomputeSubscriptionReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UnmapAzureCloudAccountExocomputeSubscriptionReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "unmapAzureCloudAccountExocomputeSubscription" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpgradeAzureCloudAccountPermissionsWithoutOauthReply? UpgradeAzureCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeAzureCloudAccountPermissionsWithoutOauth: UpgradeAzureCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeAzureCloudAccountPermissionsWithoutOauth(
            ref UpgradeAzureCloudAccountPermissionsWithoutOauthReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpgradeAzureCloudAccountPermissionsWithoutOauthReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "upgradeAzureCloudAccountPermissionsWithoutOauth" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountOauthInitiateReply? GcpCloudAccountOauthInitiate
        // GraphQL -> gcpCloudAccountOauthInitiate: GcpCloudAccountOauthInitiateReply! (type)
        public static string GcpCloudAccountOauthInitiate(
            ref GcpCloudAccountOauthInitiateReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountOauthInitiateReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpCloudAccountOauthInitiate" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountOauthCompleteReply? GcpCloudAccountOauthComplete
        // GraphQL -> gcpCloudAccountOauthComplete: GcpCloudAccountOauthCompleteReply! (type)
        public static string GcpCloudAccountOauthComplete(
            ref GcpCloudAccountOauthCompleteReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountOauthCompleteReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpCloudAccountOauthComplete" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountAddProjectsReply? GcpCloudAccountAddProjects
        // GraphQL -> gcpCloudAccountAddProjects: GcpCloudAccountAddProjectsReply! (type)
        public static string GcpCloudAccountAddProjects(
            ref GcpCloudAccountAddProjectsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountAddProjectsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpCloudAccountAddProjects" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? GcpCloudAccountAddManualAuthProject
        // GraphQL -> gcpCloudAccountAddManualAuthProject: Boolean! (scalar)
        public static string GcpCloudAccountAddManualAuthProject(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("gcpCloudAccountAddManualAuthProject" + args + "\n");
        }

        //      C# -> GcpCloudAccountDeleteProjectsReply? GcpCloudAccountDeleteProjects
        // GraphQL -> gcpCloudAccountDeleteProjects: GcpCloudAccountDeleteProjectsReply! (type)
        public static string GcpCloudAccountDeleteProjects(
            ref GcpCloudAccountDeleteProjectsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountDeleteProjectsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpCloudAccountDeleteProjects" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountUpgradeProjectsReply? GcpCloudAccountUpgradeProjects
        // GraphQL -> gcpCloudAccountUpgradeProjects: GcpCloudAccountUpgradeProjectsReply! (type)
        public static string GcpCloudAccountUpgradeProjects(
            ref GcpCloudAccountUpgradeProjectsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountUpgradeProjectsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpCloudAccountUpgradeProjects" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? GcpSetDefaultServiceAccountJwtConfig
        // GraphQL -> gcpSetDefaultServiceAccountJwtConfig: Boolean! (scalar)
        public static string GcpSetDefaultServiceAccountJwtConfig(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("gcpSetDefaultServiceAccountJwtConfig" + args + "\n");
        }

        //      C# -> AsyncJobStatus? StartAwsExocomputeDisableJob
        // GraphQL -> startAwsExocomputeDisableJob: AsyncJobStatus! (type)
        public static string StartAwsExocomputeDisableJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startAwsExocomputeDisableJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpgradeGcpCloudAccountPermissionsWithoutOauthReply? UpgradeGcpCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeGcpCloudAccountPermissionsWithoutOauth: UpgradeGcpCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeGcpCloudAccountPermissionsWithoutOauth(
            ref UpgradeGcpCloudAccountPermissionsWithoutOauthReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpgradeGcpCloudAccountPermissionsWithoutOauthReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "upgradeGcpCloudAccountPermissionsWithoutOauth" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddAwsIamUserBasedCloudAccountReply? AddAwsIamUserBasedCloudAccount
        // GraphQL -> addAwsIamUserBasedCloudAccount: AddAwsIamUserBasedCloudAccountReply! (type)
        public static string AddAwsIamUserBasedCloudAccount(
            ref AddAwsIamUserBasedCloudAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddAwsIamUserBasedCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addAwsIamUserBasedCloudAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? UpgradeAwsIamUserBasedCloudAccountPermissions
        // GraphQL -> upgradeAwsIamUserBasedCloudAccountPermissions: Boolean! (scalar)
        public static string UpgradeAwsIamUserBasedCloudAccountPermissions(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("upgradeAwsIamUserBasedCloudAccountPermissions" + args + "\n");
        }

        //      C# -> System.Boolean? UpgradeAwsCloudAccountFeaturesWithoutCft
        // GraphQL -> upgradeAwsCloudAccountFeaturesWithoutCft: Boolean! (scalar)
        public static string UpgradeAwsCloudAccountFeaturesWithoutCft(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("upgradeAwsCloudAccountFeaturesWithoutCft" + args + "\n");
        }

        //      C# -> AddAwsAuthenticationServerBasedCloudAccountReply? AddAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> addAwsAuthenticationServerBasedCloudAccount: AddAwsAuthenticationServerBasedCloudAccountReply! (type)
        public static string AddAwsAuthenticationServerBasedCloudAccount(
            ref AddAwsAuthenticationServerBasedCloudAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddAwsAuthenticationServerBasedCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addAwsAuthenticationServerBasedCloudAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? PatchAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> patchAwsAuthenticationServerBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsAuthenticationServerBasedCloudAccount(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("patchAwsAuthenticationServerBasedCloudAccount" + args + "\n");
        }

        //      C# -> System.Boolean? PatchAwsIamUserBasedCloudAccount
        // GraphQL -> patchAwsIamUserBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsIamUserBasedCloudAccount(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("patchAwsIamUserBasedCloudAccount" + args + "\n");
        }

        //      C# -> TriggerExocomputeHealthCheckReply? TriggerExocomputeHealthCheck
        // GraphQL -> triggerExocomputeHealthCheck: TriggerExocomputeHealthCheckReply! (type)
        public static string TriggerExocomputeHealthCheck(
            ref TriggerExocomputeHealthCheckReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TriggerExocomputeHealthCheckReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "triggerExocomputeHealthCheck" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> StartCrawlReply? StartCrawl
        // GraphQL -> startCrawl: StartCrawlReply! (type)
        public static string StartCrawl(
            ref StartCrawlReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "name"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "resources"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "analyzerGroups"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "extWhiteList"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new StartCrawlReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startCrawl" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? ArchiveCrawl
        // GraphQL -> archiveCrawl: String! (scalar)
        public static string ArchiveCrawl(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "crawlId"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("archiveCrawl" + args + "\n");
        }

        //      C# -> Analyzer? CreateCustomAnalyzer
        // GraphQL -> createCustomAnalyzer: Analyzer! (type)
        public static string CreateCustomAnalyzer(
            ref Analyzer? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Analyzer() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createCustomAnalyzer" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeactivateCustomAnalyzer
        // GraphQL -> deactivateCustomAnalyzer: String! (scalar)
        public static string DeactivateCustomAnalyzer(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "analyzerId"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deactivateCustomAnalyzer" + args + "\n");
        }

        //      C# -> RunCustomAnalyzerReply? RunCustomAnalyzer
        // GraphQL -> runCustomAnalyzer: RunCustomAnalyzerReply! (type)
        public static string RunCustomAnalyzer(
            ref RunCustomAnalyzerReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RunCustomAnalyzerReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "runCustomAnalyzer" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> Analyzer? UpdateCustomAnalyzer
        // GraphQL -> updateCustomAnalyzer: Analyzer! (type)
        public static string UpdateCustomAnalyzer(
            ref Analyzer? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Analyzer() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateCustomAnalyzer" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ClassificationPolicyDetail? CreatePolicy
        // GraphQL -> createPolicy: ClassificationPolicyDetail! (type)
        public static string CreatePolicy(
            ref ClassificationPolicyDetail? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClassificationPolicyDetail() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createPolicy" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ClassificationPolicyDetail? UpdatePolicy
        // GraphQL -> updatePolicy: ClassificationPolicyDetail! (type)
        public static string UpdatePolicy(
            ref ClassificationPolicyDetail? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClassificationPolicyDetail() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updatePolicy" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<System.String>? DeactivatePolicy
        // GraphQL -> deactivatePolicy: [String!]! (scalar)
        public static string DeactivatePolicy(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "policyId"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "runAsync"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deactivatePolicy" + args + "\n");
        }

        //      C# -> System.String? AddPolicyObjects
        // GraphQL -> addPolicyObjects: String! (scalar)
        public static string AddPolicyObjects(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "policyIds"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "objectIds"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("addPolicyObjects" + args + "\n");
        }

        //      C# -> List<System.String>? RemovePolicyObjects
        // GraphQL -> removePolicyObjects: [String!]! (scalar)
        public static string RemovePolicyObjects(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "policyIds"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "objectIds"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "runAsync"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removePolicyObjects" + args + "\n");
        }

        //      C# -> SeedInitialPoliciesReply? SeedInitialPolicies
        // GraphQL -> seedInitialPolicies: SeedInitialPoliciesReply! (type)
        public static string SeedInitialPolicies(
            ref SeedInitialPoliciesReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new SeedInitialPoliciesReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "seedInitialPolicies" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SeedEnabledPoliciesReply? SeedEnabledPolicies
        // GraphQL -> seedEnabledPolicies: SeedEnabledPoliciesReply! (type)
        public static string SeedEnabledPolicies(
            ref SeedEnabledPoliciesReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new SeedEnabledPoliciesReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "seedEnabledPolicies" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadResultsCsvReply? DownloadResultsCsv
        // GraphQL -> downloadResultsCsv: DownloadResultsCsvReply! (type)
        public static string DownloadResultsCsv(
            ref DownloadResultsCsvReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "crawlId"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "downloadFilter"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadResultsCsvReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadResultsCsv" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadSnapshotResultsCsv
        // GraphQL -> downloadSnapshotResultsCsv: DownloadCsvReply! (type)
        public static string DownloadSnapshotResultsCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "snappableFid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "snapshotFid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "downloadFilter"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadSnapshotResultsCsv" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateWhitelistedAnalyzers
        // GraphQL -> updateWhitelistedAnalyzers: String! (scalar)
        public static string UpdateWhitelistedAnalyzers(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "stdPath"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "snappableFid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "snapshotFid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "analyzerIds"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "runAsync"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateWhitelistedAnalyzers" + args + "\n");
        }

        //      C# -> Cluster? UpdatePreviewerClusterConfig
        // GraphQL -> updatePreviewerClusterConfig: Cluster! (type)
        public static string UpdatePreviewerClusterConfig(
            ref Cluster? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "previewerClusterConfig"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Cluster() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updatePreviewerClusterConfig" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateAutoEnablePolicyClusterConfigReply? UpdateAutoEnablePolicyClusterConfig
        // GraphQL -> updateAutoEnablePolicyClusterConfig: UpdateAutoEnablePolicyClusterConfigReply! (type)
        public static string UpdateAutoEnablePolicyClusterConfig(
            ref UpdateAutoEnablePolicyClusterConfigReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateAutoEnablePolicyClusterConfigReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateAutoEnablePolicyClusterConfig" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadObjectFilesCsv
        // GraphQL -> downloadObjectFilesCsv: DownloadCsvReply! (type)
        public static string DownloadObjectFilesCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadObjectFilesCsv" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadUserActivityCsv
        // GraphQL -> downloadUserActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserActivityCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadUserActivityCsv" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadUserFileActivityCsv
        // GraphQL -> downloadUserFileActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserFileActivityCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadUserFileActivityCsv" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadObjectsListCsv
        // GraphQL -> downloadObjectsListCsv: DownloadCsvReply! (type)
        public static string DownloadObjectsListCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadObjectsListCsv" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateEventDigestReply? UpdateEventDigest
        // GraphQL -> updateEventDigest: UpdateEventDigestReply! (type)
        public static string UpdateEventDigest(
            ref UpdateEventDigestReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateEventDigestReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateEventDigest" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteEventDigest
        // GraphQL -> deleteEventDigest: Void (scalar)
        public static string DeleteEventDigest(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteEventDigest" + args + "\n");
        }

        //      C# -> AddDb2InstanceReply? AddDb2Instance
        // GraphQL -> addDb2Instance: AddDb2InstanceReply! (type)
        public static string AddDb2Instance(
            ref AddDb2InstanceReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddDb2InstanceReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addDb2Instance" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Instance
        // GraphQL -> deleteDb2Instance: AsyncRequestStatus! (type)
        public static string DeleteDb2Instance(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteDb2Instance" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DiscoverDb2Instance
        // GraphQL -> discoverDb2Instance: AsyncRequestStatus! (type)
        public static string DiscoverDb2Instance(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "discoverDb2Instance" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> PatchDb2InstanceReply? PatchDb2Instance
        // GraphQL -> patchDb2Instance: PatchDb2InstanceReply! (type)
        public static string PatchDb2Instance(
            ref PatchDb2InstanceReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PatchDb2InstanceReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "patchDb2Instance" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandDb2Backup
        // GraphQL -> createOnDemandDb2Backup: AsyncRequestStatus! (type)
        public static string CreateOnDemandDb2Backup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOnDemandDb2Backup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadDb2Snapshot
        // GraphQL -> downloadDb2Snapshot: AsyncRequestStatus! (type)
        public static string DownloadDb2Snapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadDb2Snapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadDb2SnapshotsForPointInTimeRecovery
        // GraphQL -> downloadDb2SnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadDb2SnapshotsForPointInTimeRecovery(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadDb2SnapshotsForPointInTimeRecovery" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedDb2Snapshots
        // GraphQL -> expireDownloadedDb2Snapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedDb2Snapshots(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "expireDownloadedDb2Snapshots" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshDb2Database
        // GraphQL -> refreshDb2Database: AsyncRequestStatus! (type)
        public static string RefreshDb2Database(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshDb2Database" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Database
        // GraphQL -> deleteDb2Database: AsyncRequestStatus! (type)
        public static string DeleteDb2Database(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteDb2Database" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateFailoverClusterReply? CreateFailoverCluster
        // GraphQL -> createFailoverCluster: CreateFailoverClusterReply! (type)
        public static string CreateFailoverCluster(
            ref CreateFailoverClusterReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateFailoverClusterReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createFailoverCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateFailoverClusterReply? UpdateFailoverCluster
        // GraphQL -> updateFailoverCluster: UpdateFailoverClusterReply! (type)
        public static string UpdateFailoverCluster(
            ref UpdateFailoverClusterReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateFailoverClusterReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateFailoverCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteFailoverCluster
        // GraphQL -> deleteFailoverCluster: ResponseSuccess! (type)
        public static string DeleteFailoverCluster(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteFailoverCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverCluster
        // GraphQL -> bulkDeleteFailoverCluster: ResponseSuccess! (type)
        public static string BulkDeleteFailoverCluster(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkDeleteFailoverCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteFailoverClusterApp
        // GraphQL -> deleteFailoverClusterApp: ResponseSuccess! (type)
        public static string DeleteFailoverClusterApp(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteFailoverClusterApp" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverClusterApp
        // GraphQL -> bulkDeleteFailoverClusterApp: ResponseSuccess! (type)
        public static string BulkDeleteFailoverClusterApp(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkDeleteFailoverClusterApp" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateFailoverClusterAppReply? CreateFailoverClusterApp
        // GraphQL -> createFailoverClusterApp: CreateFailoverClusterAppReply! (type)
        public static string CreateFailoverClusterApp(
            ref CreateFailoverClusterAppReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateFailoverClusterAppReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createFailoverClusterApp" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateFailoverClusterAppReply? UpdateFailoverClusterApp
        // GraphQL -> updateFailoverClusterApp: UpdateFailoverClusterAppReply! (type)
        public static string UpdateFailoverClusterApp(
            ref UpdateFailoverClusterAppReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateFailoverClusterAppReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateFailoverClusterApp" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? FilesetRecoverFiles
        // GraphQL -> filesetRecoverFiles: AsyncRequestStatus! (type)
        public static string FilesetRecoverFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "filesetRecoverFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkCreateFilesetsReply? BulkCreateFilesets
        // GraphQL -> bulkCreateFilesets: BulkCreateFilesetsReply! (type)
        public static string BulkCreateFilesets(
            ref BulkCreateFilesetsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkCreateFilesetsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkCreateFilesets" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkCreateNasFilesetsReply? BulkCreateNasFilesets
        // GraphQL -> bulkCreateNasFilesets: BulkCreateNasFilesetsReply! (type)
        public static string BulkCreateNasFilesets(
            ref BulkCreateNasFilesetsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkCreateNasFilesetsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkCreateNasFilesets" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteFileset
        // GraphQL -> bulkDeleteFileset: ResponseSuccess! (type)
        public static string BulkDeleteFileset(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkDeleteFileset" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? FilesetDownloadSnapshotFiles
        // GraphQL -> filesetDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetDownloadSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "filesetDownloadSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? FilesetExportSnapshotFiles
        // GraphQL -> filesetExportSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetExportSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "filesetExportSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteFilesetTemplate
        // GraphQL -> bulkDeleteFilesetTemplate: ResponseSuccess! (type)
        public static string BulkDeleteFilesetTemplate(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkDeleteFilesetTemplate" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkUpdateFilesetTemplateReply? BulkUpdateFilesetTemplate
        // GraphQL -> bulkUpdateFilesetTemplate: BulkUpdateFilesetTemplateReply! (type)
        public static string BulkUpdateFilesetTemplate(
            ref BulkUpdateFilesetTemplateReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateFilesetTemplateReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkUpdateFilesetTemplate" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkCreateFilesetTemplatesReply? BulkCreateFilesetTemplates
        // GraphQL -> bulkCreateFilesetTemplates: BulkCreateFilesetTemplatesReply! (type)
        public static string BulkCreateFilesetTemplates(
            ref BulkCreateFilesetTemplatesReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkCreateFilesetTemplatesReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkCreateFilesetTemplates" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteFilesetSnapshots
        // GraphQL -> deleteFilesetSnapshots: ResponseSuccess! (type)
        public static string DeleteFilesetSnapshots(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteFilesetSnapshots" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateFilesetSnapshot
        // GraphQL -> createFilesetSnapshot: AsyncRequestStatus! (type)
        public static string CreateFilesetSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createFilesetSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshot
        // GraphQL -> downloadFilesetSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadFilesetSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshotFromLocation
        // GraphQL -> downloadFilesetSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadFilesetSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> StopJobInstanceReply? StopJobInstance
        // GraphQL -> stopJobInstance: StopJobInstanceReply! (type)
        public static string StopJobInstance(
            ref StopJobInstanceReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new StopJobInstanceReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "stopJobInstance" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? StopJobInstanceFromEventSeries
        // GraphQL -> stopJobInstanceFromEventSeries: Void (scalar)
        public static string StopJobInstanceFromEventSeries(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("stopJobInstanceFromEventSeries" + args + "\n");
        }

        //      C# -> BatchAsyncJobStatus? GcpNativeRefreshProjects
        // GraphQL -> gcpNativeRefreshProjects: BatchAsyncJobStatus! (type)
        public static string GcpNativeRefreshProjects(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpNativeRefreshProjects" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? GcpNativeExportGceInstance
        // GraphQL -> gcpNativeExportGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeExportGceInstance(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpNativeExportGceInstance" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? GcpNativeRestoreGceInstance
        // GraphQL -> gcpNativeRestoreGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeRestoreGceInstance(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpNativeRestoreGceInstance" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? GcpNativeDisableProject
        // GraphQL -> gcpNativeDisableProject: AsyncJobStatus! (type)
        public static string GcpNativeDisableProject(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpNativeDisableProject" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? GcpNativeExcludeDisksFromInstanceSnapshot
        // GraphQL -> gcpNativeExcludeDisksFromInstanceSnapshot: Void (scalar)
        public static string GcpNativeExcludeDisksFromInstanceSnapshot(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("gcpNativeExcludeDisksFromInstanceSnapshot" + args + "\n");
        }

        //      C# -> AsyncJobStatus? GcpNativeExportDisk
        // GraphQL -> gcpNativeExportDisk: AsyncJobStatus! (type)
        public static string GcpNativeExportDisk(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "gcpNativeExportDisk" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GlobalSlaReply? CreateGlobalSla
        // GraphQL -> createGlobalSla: GlobalSlaReply! (type)
        public static string CreateGlobalSla(
            ref GlobalSlaReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GlobalSlaReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createGlobalSla" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GlobalSlaReply? UpdateGlobalSla
        // GraphQL -> updateGlobalSla: GlobalSlaReply! (type)
        public static string UpdateGlobalSla(
            ref GlobalSlaReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GlobalSlaReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateGlobalSla" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SlaAssignResult? AssignSla
        // GraphQL -> assignSla: SlaAssignResult! (type)
        public static string AssignSla(
            ref SlaAssignResult? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SlaAssignResult() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "assignSla" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RegisterHypervScvmm
        // GraphQL -> registerHypervScvmm: AsyncRequestStatus! (type)
        public static string RegisterHypervScvmm(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "registerHypervScvmm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> HypervScvmmUpdateReply? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdateReply! (type)
        public static string HypervScvmmUpdate(
            ref HypervScvmmUpdateReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HypervScvmmUpdateReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "hypervScvmmUpdate" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? HypervScvmmDelete
        // GraphQL -> hypervScvmmDelete: ResponseSuccess! (type)
        public static string HypervScvmmDelete(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "hypervScvmmDelete" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshHypervScvmm
        // GraphQL -> refreshHypervScvmm: AsyncRequestStatus! (type)
        public static string RefreshHypervScvmm(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshHypervScvmm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? HypervOnDemandSnapshot
        // GraphQL -> hypervOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string HypervOnDemandSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "hypervOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? HypervDeleteAllSnapshots
        // GraphQL -> hypervDeleteAllSnapshots: RequestSuccess! (type)
        public static string HypervDeleteAllSnapshots(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "hypervDeleteAllSnapshots" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportHypervVirtualMachine
        // GraphQL -> exportHypervVirtualMachine: AsyncRequestStatus! (type)
        public static string ExportHypervVirtualMachine(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportHypervVirtualMachine" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshotFiles
        // GraphQL -> downloadHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadHypervVirtualMachineSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? InstantRecoverHypervVirtualMachineSnapshot
        // GraphQL -> instantRecoverHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverHypervVirtualMachineSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "instantRecoverHypervVirtualMachineSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreHypervVirtualMachineSnapshotFiles
        // GraphQL -> restoreHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreHypervVirtualMachineSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreHypervVirtualMachineSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? RegisterAgentHypervVirtualMachine
        // GraphQL -> registerAgentHypervVirtualMachine: RequestSuccess! (type)
        public static string RegisterAgentHypervVirtualMachine(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "registerAgentHypervVirtualMachine" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteHypervVirtualMachineSnapshot
        // GraphQL -> deleteHypervVirtualMachineSnapshot: RequestSuccess! (type)
        public static string DeleteHypervVirtualMachineSnapshot(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteHypervVirtualMachineSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshot
        // GraphQL -> downloadHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadHypervVirtualMachineSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateHypervVirtualMachineSnapshotMount
        // GraphQL -> createHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string CreateHypervVirtualMachineSnapshotMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createHypervVirtualMachineSnapshotMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateHypervVirtualMachineSnapshotMountReply? UpdateHypervVirtualMachineSnapshotMount
        // GraphQL -> updateHypervVirtualMachineSnapshotMount: UpdateHypervVirtualMachineSnapshotMountReply! (type)
        public static string UpdateHypervVirtualMachineSnapshotMount(
            ref UpdateHypervVirtualMachineSnapshotMountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateHypervVirtualMachineSnapshotMountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateHypervVirtualMachineSnapshotMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteHypervVirtualMachineSnapshotMount
        // GraphQL -> deleteHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteHypervVirtualMachineSnapshotMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteHypervVirtualMachineSnapshotMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshHypervServer
        // GraphQL -> refreshHypervServer: AsyncRequestStatus! (type)
        public static string RefreshHypervServer(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshHypervServer" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchOnDemandBackupHypervVmReply? BatchOnDemandBackupHypervVm
        // GraphQL -> batchOnDemandBackupHypervVm: BatchOnDemandBackupHypervVmReply! (type)
        public static string BatchOnDemandBackupHypervVm(
            ref BatchOnDemandBackupHypervVmReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchOnDemandBackupHypervVmReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "batchOnDemandBackupHypervVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchExportHypervVmReply? BatchExportHypervVm
        // GraphQL -> batchExportHypervVm: BatchExportHypervVmReply! (type)
        public static string BatchExportHypervVm(
            ref BatchExportHypervVmReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchExportHypervVmReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "batchExportHypervVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchMountHypervVmReply? BatchMountHypervVm
        // GraphQL -> batchMountHypervVm: BatchMountHypervVmReply! (type)
        public static string BatchMountHypervVm(
            ref BatchMountHypervVmReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchMountHypervVmReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "batchMountHypervVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchInstantRecoverHypervVmReply? BatchInstantRecoverHypervVm
        // GraphQL -> batchInstantRecoverHypervVm: BatchInstantRecoverHypervVmReply! (type)
        public static string BatchInstantRecoverHypervVm(
            ref BatchInstantRecoverHypervVmReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchInstantRecoverHypervVmReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "batchInstantRecoverHypervVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateHypervVirtualMachineReply? UpdateHypervVirtualMachine
        // GraphQL -> updateHypervVirtualMachine: UpdateHypervVirtualMachineReply! (type)
        public static string UpdateHypervVirtualMachine(
            ref UpdateHypervVirtualMachineReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateHypervVirtualMachineReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateHypervVirtualMachine" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadHypervSnapshotFromLocation
        // GraphQL -> downloadHypervSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadHypervSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadHypervSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateK8sClusterReply? CreateK8sCluster
        // GraphQL -> createK8sCluster: CreateK8sClusterReply! (type)
        public static string CreateK8sCluster(
            ref CreateK8sClusterReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateK8sClusterReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createK8sCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RefreshK8sCluster
        // GraphQL -> refreshK8sCluster: CreateOnDemandJobReply! (type)
        public static string RefreshK8sCluster(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshK8sCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ArchiveK8sClusterReply? ArchiveK8sCluster
        // GraphQL -> archiveK8sCluster: ArchiveK8sClusterReply! (type)
        public static string ArchiveK8sCluster(
            ref ArchiveK8sClusterReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ArchiveK8sClusterReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "archiveK8sCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? CreateK8sNamespaceSnapshots
        // GraphQL -> createK8sNamespaceSnapshots: [CreateOnDemandJobReply!]! (type)
        public static string CreateK8sNamespaceSnapshots(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createK8sNamespaceSnapshots" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreK8sNamespace
        // GraphQL -> restoreK8sNamespace: CreateOnDemandJobReply! (type)
        public static string RestoreK8sNamespace(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreK8sNamespace" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? ExportK8sNamespace
        // GraphQL -> exportK8sNamespace: CreateOnDemandJobReply! (type)
        public static string ExportK8sNamespace(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportK8sNamespace" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateK8sAgentManifestReply? CreateK8sAgentManifest
        // GraphQL -> createK8sAgentManifest: CreateK8sAgentManifestReply! (type)
        public static string CreateK8sAgentManifest(
            ref CreateK8sAgentManifestReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateK8sAgentManifestReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createK8sAgentManifest" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> EnableAutomaticFmdUploadReply? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: EnableAutomaticFmdUploadReply! (type)
        public static string EnableAutomaticFmdUpload(
            ref EnableAutomaticFmdUploadReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new EnableAutomaticFmdUploadReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "enableAutomaticFmdUpload" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? EnableThreatMonitoring
        // GraphQL -> enableThreatMonitoring: Void (scalar)
        public static string EnableThreatMonitoring(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("enableThreatMonitoring" + args + "\n");
        }

        //      C# -> TriggerRansomwareDetectionReply? TriggerRansomwareDetection
        // GraphQL -> triggerRansomwareDetection: TriggerRansomwareDetectionReply! (type)
        public static string TriggerRansomwareDetection(
            ref TriggerRansomwareDetectionReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TriggerRansomwareDetectionReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "triggerRansomwareDetection" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SetWorkloadAlertSettingReply? SetWorkloadAlertSetting
        // GraphQL -> setWorkloadAlertSetting: SetWorkloadAlertSettingReply! (type)
        public static string SetWorkloadAlertSetting(
            ref SetWorkloadAlertSettingReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SetWorkloadAlertSettingReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "setWorkloadAlertSetting" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> StartThreatHuntReply? StartThreatHunt
        // GraphQL -> startThreatHunt: StartThreatHuntReply! (type)
        public static string StartThreatHunt(
            ref StartThreatHuntReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new StartThreatHuntReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startThreatHunt" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? CancelThreatHunt
        // GraphQL -> cancelThreatHunt: Void (scalar)
        public static string CancelThreatHunt(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("cancelThreatHunt" + args + "\n");
        }

        //      C# -> BatchQuarantineSnapshotReply? BatchQuarantineSnapshot
        // GraphQL -> batchQuarantineSnapshot: BatchQuarantineSnapshotReply! (type)
        public static string BatchQuarantineSnapshot(
            ref BatchQuarantineSnapshotReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchQuarantineSnapshotReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "batchQuarantineSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchReleaseFromQuarantineSnapshotReply? BatchReleaseFromQuarantineSnapshot
        // GraphQL -> batchReleaseFromQuarantineSnapshot: BatchReleaseFromQuarantineSnapshotReply! (type)
        public static string BatchReleaseFromQuarantineSnapshot(
            ref BatchReleaseFromQuarantineSnapshotReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchReleaseFromQuarantineSnapshotReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "batchReleaseFromQuarantineSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadThreatHuntCsvReply? DownloadThreatHuntCsv
        // GraphQL -> downloadThreatHuntCsv: DownloadThreatHuntCsvReply! (type)
        public static string DownloadThreatHuntCsv(
            ref DownloadThreatHuntCsvReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadThreatHuntCsvReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadThreatHuntCsv" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateLdapIntegration
        // GraphQL -> updateLdapIntegration: String! (scalar)
        public static string UpdateLdapIntegration(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "id"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "name"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "bindUserName"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "bindUserPassword"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "baseDn"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "trustedCerts"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "dynamicDnsName"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "ldapServers"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "userSearchFilter"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "userNameAttr"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "groupMembershipAttr"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "groupSearchFilter"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "groupMemberAttr"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateLdapIntegration" + args + "\n");
        }

        //      C# -> System.Boolean? RemoveLdapIntegration
        // GraphQL -> removeLdapIntegration: Boolean! (scalar)
        public static string RemoveLdapIntegration(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "id"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removeLdapIntegration" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteLdapPrincipals
        // GraphQL -> deleteLdapPrincipals: Boolean! (scalar)
        public static string DeleteLdapPrincipals(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "principalIds"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteLdapPrincipals" + args + "\n");
        }

        //      C# -> UpdateManagedVolumeReply? UpdateManagedVolume
        // GraphQL -> updateManagedVolume: UpdateManagedVolumeReply! (type)
        public static string UpdateManagedVolume(
            ref UpdateManagedVolumeReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateManagedVolumeReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateManagedVolume" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddManagedVolumeReply? AddManagedVolume
        // GraphQL -> addManagedVolume: AddManagedVolumeReply! (type)
        public static string AddManagedVolume(
            ref AddManagedVolumeReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddManagedVolumeReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addManagedVolume" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DeleteManagedVolumeReply? DeleteManagedVolume
        // GraphQL -> deleteManagedVolume: DeleteManagedVolumeReply! (type)
        public static string DeleteManagedVolume(
            ref DeleteManagedVolumeReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DeleteManagedVolumeReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteManagedVolume" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TakeManagedVolumeOnDemandSnapshot
        // GraphQL -> takeManagedVolumeOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string TakeManagedVolumeOnDemandSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "takeManagedVolumeOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BeginManagedVolumeSnapshotReply? BeginManagedVolumeSnapshot
        // GraphQL -> beginManagedVolumeSnapshot: BeginManagedVolumeSnapshotReply! (type)
        public static string BeginManagedVolumeSnapshot(
            ref BeginManagedVolumeSnapshotReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BeginManagedVolumeSnapshotReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "beginManagedVolumeSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportManagedVolumeSnapshot
        // GraphQL -> exportManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportManagedVolumeSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportManagedVolumeSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportSlaManagedVolumeSnapshot
        // GraphQL -> exportSlaManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportSlaManagedVolumeSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportSlaManagedVolumeSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteManagedVolumeSnapshotExport
        // GraphQL -> deleteManagedVolumeSnapshotExport: AsyncRequestStatus! (type)
        public static string DeleteManagedVolumeSnapshotExport(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteManagedVolumeSnapshotExport" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> EndManagedVolumeSnapshotReply? EndManagedVolumeSnapshot
        // GraphQL -> endManagedVolumeSnapshot: EndManagedVolumeSnapshotReply! (type)
        public static string EndManagedVolumeSnapshot(
            ref EndManagedVolumeSnapshotReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new EndManagedVolumeSnapshotReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "endManagedVolumeSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ResizeManagedVolume
        // GraphQL -> resizeManagedVolume: AsyncRequestStatus! (type)
        public static string ResizeManagedVolume(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "resizeManagedVolume" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadManagedVolumeFiles
        // GraphQL -> downloadManagedVolumeFiles: AsyncRequestStatus! (type)
        public static string DownloadManagedVolumeFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadManagedVolumeFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? UpdateIpWhitelist
        // GraphQL -> updateIpWhitelist: Boolean! (scalar)
        public static string UpdateIpWhitelist(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "whitelistMode"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "ipCidrs"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateIpWhitelist" + args + "\n");
        }

        //      C# -> System.Boolean? SetIpWhitelistEnabled
        // GraphQL -> setIpWhitelistEnabled: Boolean! (scalar)
        public static string SetIpWhitelistEnabled(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "enabled"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setIpWhitelistEnabled" + args + "\n");
        }

        //      C# -> AddMongoSourceReply? AddMongoSource
        // GraphQL -> addMongoSource: AddMongoSourceReply! (type)
        public static string AddMongoSource(
            ref AddMongoSourceReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddMongoSourceReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addMongoSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteMongoSource
        // GraphQL -> deleteMongoSource: AsyncRequestStatus! (type)
        public static string DeleteMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteMongoSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DiscoverMongoSource
        // GraphQL -> discoverMongoSource: AsyncRequestStatus! (type)
        public static string DiscoverMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "discoverMongoSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? PatchMongoSource
        // GraphQL -> patchMongoSource: AsyncRequestStatus! (type)
        public static string PatchMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "patchMongoSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RetryAddMongoSource
        // GraphQL -> retryAddMongoSource: AsyncRequestStatus! (type)
        public static string RetryAddMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "retryAddMongoSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? AssignSlaToMongoDbCollection
        // GraphQL -> assignSlaToMongoDbCollection: AsyncRequestStatus! (type)
        public static string AssignSlaToMongoDbCollection(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "assignSlaToMongoDbCollection" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RecoverMongoSource
        // GraphQL -> recoverMongoSource: AsyncRequestStatus! (type)
        public static string RecoverMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "recoverMongoSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? CreateMongodbSource
        // GraphQL -> createMongodbSource: MosaicAsyncResponse! (type)
        public static string CreateMongodbSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createMongodbSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? UpdateMongodbSource
        // GraphQL -> updateMongodbSource: MosaicAsyncResponse! (type)
        public static string UpdateMongodbSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateMongodbSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? DeleteMongodbSource
        // GraphQL -> deleteMongodbSource: MosaicAsyncResponse! (type)
        public static string DeleteMongodbSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteMongodbSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteMongodbSources
        // GraphQL -> bulkDeleteMongodbSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteMongodbSources(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkDeleteMongodbSources" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? RecoverMongodbSource
        // GraphQL -> recoverMongodbSource: MosaicAsyncResponse! (type)
        public static string RecoverMongodbSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "recoverMongodbSource" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BrowseMssqlDatabaseSnapshotReply? BrowseMssqlDatabaseSnapshot
        // GraphQL -> browseMssqlDatabaseSnapshot: BrowseMssqlDatabaseSnapshotReply! (type)
        public static string BrowseMssqlDatabaseSnapshot(
            ref BrowseMssqlDatabaseSnapshotReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BrowseMssqlDatabaseSnapshotReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "browseMssqlDatabaseSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportMssqlDatabase
        // GraphQL -> exportMssqlDatabase: AsyncRequestStatus! (type)
        public static string ExportMssqlDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportMssqlDatabase" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreMssqlDatabase
        // GraphQL -> restoreMssqlDatabase: AsyncRequestStatus! (type)
        public static string RestoreMssqlDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreMssqlDatabase" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkUpdateMssqlDbsReply? BulkUpdateMssqlDbs
        // GraphQL -> bulkUpdateMssqlDbs: BulkUpdateMssqlDbsReply! (type)
        public static string BulkUpdateMssqlDbs(
            ref BulkUpdateMssqlDbsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateMssqlDbsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkUpdateMssqlDbs" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TakeMssqlLogBackup
        // GraphQL -> takeMssqlLogBackup: AsyncRequestStatus! (type)
        public static string TakeMssqlLogBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "takeMssqlLogBackup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandMssqlBackup
        // GraphQL -> createOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandMssqlBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOnDemandMssqlBackup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteMssqlDbSnapshots
        // GraphQL -> deleteMssqlDbSnapshots: ResponseSuccess! (type)
        public static string DeleteMssqlDbSnapshots(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteMssqlDbSnapshots" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteMssqlLiveMount
        // GraphQL -> deleteMssqlLiveMount: AsyncRequestStatus! (type)
        public static string DeleteMssqlLiveMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteMssqlLiveMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? BulkCreateOnDemandMssqlBackup
        // GraphQL -> bulkCreateOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string BulkCreateOnDemandMssqlBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkCreateOnDemandMssqlBackup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLiveMount
        // GraphQL -> createMssqlLiveMount: AsyncRequestStatus! (type)
        public static string CreateMssqlLiveMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createMssqlLiveMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateMssqlLogShippingConfigurationReply? UpdateMssqlLogShippingConfiguration
        // GraphQL -> updateMssqlLogShippingConfiguration: UpdateMssqlLogShippingConfigurationReply! (type)
        public static string UpdateMssqlLogShippingConfiguration(
            ref UpdateMssqlLogShippingConfigurationReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateMssqlLogShippingConfigurationReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateMssqlLogShippingConfiguration" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseFilesFromArchivalLocation
        // GraphQL -> downloadMssqlDatabaseFilesFromArchivalLocation: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseFilesFromArchivalLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadMssqlDatabaseFilesFromArchivalLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseBackupFiles
        // GraphQL -> downloadMssqlDatabaseBackupFiles: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseBackupFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadMssqlDatabaseBackupFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? AssignMssqlSlaDomainProperties
        // GraphQL -> assignMssqlSlaDomainProperties: ResponseSuccess! (type)
        public static string AssignMssqlSlaDomainProperties(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "assignMssqlSlaDomainProperties" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateMssqlDefaultPropertiesReply? UpdateMssqlDefaultProperties
        // GraphQL -> updateMssqlDefaultProperties: UpdateMssqlDefaultPropertiesReply! (type)
        public static string UpdateMssqlDefaultProperties(
            ref UpdateMssqlDefaultPropertiesReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateMssqlDefaultPropertiesReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateMssqlDefaultProperties" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLogShippingConfiguration
        // GraphQL -> createMssqlLogShippingConfiguration: AsyncRequestStatus! (type)
        public static string CreateMssqlLogShippingConfiguration(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createMssqlLogShippingConfiguration" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AssignMssqlSlaDomainPropertiesAsyncReply? AssignMssqlSlaDomainPropertiesAsync
        // GraphQL -> assignMssqlSlaDomainPropertiesAsync: AssignMssqlSlaDomainPropertiesAsyncReply! (type)
        public static string AssignMssqlSlaDomainPropertiesAsync(
            ref AssignMssqlSlaDomainPropertiesAsyncReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AssignMssqlSlaDomainPropertiesAsyncReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "assignMssqlSlaDomainPropertiesAsync" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ReseedLogShippingSecondary
        // GraphQL -> reseedLogShippingSecondary: AsyncRequestStatus! (type)
        public static string ReseedLogShippingSecondary(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "reseedLogShippingSecondary" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteLogShipping
        // GraphQL -> deleteLogShipping: AsyncRequestStatus! (type)
        public static string DeleteLogShipping(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteLogShipping" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateOrgSecurityPolicy
        // GraphQL -> updateOrgSecurityPolicy: Void (scalar)
        public static string UpdateOrgSecurityPolicy(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateOrgSecurityPolicy" + args + "\n");
        }

        //      C# -> CreateOrgSwitchSessionReply? CreateOrgSwitchSession
        // GraphQL -> createOrgSwitchSession: CreateOrgSwitchSessionReply! (type)
        public static string CreateOrgSwitchSession(
            ref CreateOrgSwitchSessionReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOrgSwitchSessionReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOrgSwitchSession" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOrgReply? CreateOrg
        // GraphQL -> createOrg: CreateOrgReply! (type)
        public static string CreateOrg(
            ref CreateOrgReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOrgReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOrg" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateOrgReply? UpdateOrg
        // GraphQL -> updateOrg: UpdateOrgReply! (type)
        public static string UpdateOrg(
            ref UpdateOrgReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateOrgReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateOrg" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? DeleteOrg
        // GraphQL -> deleteOrg: Boolean! (scalar)
        public static string DeleteOrg(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteOrg" + args + "\n");
        }

        //      C# -> O365SaasSetupKickoffReply? O365SaaSsetupKickoff
        // GraphQL -> o365SaaSSetupKickoff: O365SaasSetupKickoffReply! (type)
        public static string O365SaaSsetupKickoff(
            ref O365SaasSetupKickoffReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SaasSetupKickoffReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "o365SaaSSetupKickoff" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? AddAdGroupsToHierarchy
        // GraphQL -> addAdGroupsToHierarchy: RequestStatus! (type)
        public static string AddAdGroupsToHierarchy(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addAdGroupsToHierarchy" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? DeleteAdGroupsFromHierarchy
        // GraphQL -> deleteAdGroupsFromHierarchy: RequestStatus! (type)
        public static string DeleteAdGroupsFromHierarchy(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteAdGroupsFromHierarchy" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> O365PdlGroupsReply? O365PdlGroups
        // GraphQL -> o365PdlGroups: O365PdlGroupsReply! (type)
        public static string O365PdlGroups(
            ref O365PdlGroupsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365PdlGroupsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "o365PdlGroups" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddConfiguredGroupToHierarchyReply? AddConfiguredGroupToHierarchy
        // GraphQL -> addConfiguredGroupToHierarchy: AddConfiguredGroupToHierarchyReply! (type)
        public static string AddConfiguredGroupToHierarchy(
            ref AddConfiguredGroupToHierarchyReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddConfiguredGroupToHierarchyReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addConfiguredGroupToHierarchy" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateConfiguredGroup
        // GraphQL -> updateConfiguredGroup: Void (scalar)
        public static string UpdateConfiguredGroup(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateConfiguredGroup" + args + "\n");
        }

        //      C# -> AddO365OrgResponse? O365SaasSetupComplete
        // GraphQL -> o365SaasSetupComplete: AddO365OrgResponse! (type)
        public static string O365SaasSetupComplete(
            ref AddO365OrgResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddO365OrgResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "o365SaasSetupComplete" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> O365SetupKickoffResp? O365SetupKickoff
        // GraphQL -> o365SetupKickoff: O365SetupKickoffResp! (type)
        public static string O365SetupKickoff(
            ref O365SetupKickoffResp? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SetupKickoffResp() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "o365SetupKickoff" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddO365OrgResponse? AddO365Org
        // GraphQL -> addO365Org: AddO365OrgResponse! (type)
        public static string AddO365Org(
            ref AddO365OrgResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddO365OrgResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addO365Org" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> O365OauthConsentKickoffReply? O365OauthConsentKickoff
        // GraphQL -> o365OauthConsentKickoff: O365OauthConsentKickoffReply! (type)
        public static string O365OauthConsentKickoff(
            ref O365OauthConsentKickoffReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OauthConsentKickoffReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "o365OauthConsentKickoff" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> O365OauthConsentCompleteReply? O365OauthConsentComplete
        // GraphQL -> o365OauthConsentComplete: O365OauthConsentCompleteReply! (type)
        public static string O365OauthConsentComplete(
            ref O365OauthConsentCompleteReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OauthConsentCompleteReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "o365OauthConsentComplete" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateO365AppKickoffResp? CreateO365AppKickoff
        // GraphQL -> createO365AppKickoff: CreateO365AppKickoffResp! (type)
        public static string CreateO365AppKickoff(
            ref CreateO365AppKickoffResp? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateO365AppKickoffResp() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createO365AppKickoff" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? CreateO365AppComplete
        // GraphQL -> createO365AppComplete: RequestStatus! (type)
        public static string CreateO365AppComplete(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createO365AppComplete" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? InsertCustomerO365App
        // GraphQL -> insertCustomerO365App: RequestStatus! (type)
        public static string InsertCustomerO365App(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "insertCustomerO365App" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateO365AppAuthStatusReply? UpdateO365AppAuthStatus
        // GraphQL -> updateO365AppAuthStatus: UpdateO365AppAuthStatusReply! (type)
        public static string UpdateO365AppAuthStatus(
            ref UpdateO365AppAuthStatusReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateO365AppAuthStatusReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateO365AppAuthStatus" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateO365AppPermissions
        // GraphQL -> updateO365AppPermissions: Void (scalar)
        public static string UpdateO365AppPermissions(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateO365AppPermissions" + args + "\n");
        }

        //      C# -> RequestStatus? DeleteO365AzureApp
        // GraphQL -> deleteO365AzureApp: RequestStatus! (type)
        public static string DeleteO365AzureApp(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "o365AppClientId"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "o365AppType"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteO365AzureApp" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Mailbox
        // GraphQL -> backupO365Mailbox: BatchAsyncJobStatus! (type)
        public static string BackupO365Mailbox(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "mailboxIds"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupO365Mailbox" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Mailbox
        // GraphQL -> backupM365Mailbox: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Mailbox(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupM365Mailbox" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Onedrive
        // GraphQL -> backupO365Onedrive: BatchAsyncJobStatus! (type)
        public static string BackupO365Onedrive(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupO365Onedrive" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Onedrive
        // GraphQL -> backupM365Onedrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Onedrive(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupM365Onedrive" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? BackupO365SharepointDrive
        // GraphQL -> backupO365SharepointDrive: BatchAsyncJobStatus! (type)
        public static string BackupO365SharepointDrive(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupO365SharepointDrive" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365SharepointDrive
        // GraphQL -> backupM365SharepointDrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365SharepointDrive(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupM365SharepointDrive" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharepointList
        // GraphQL -> backupO365SharepointList: CreateOnDemandJobReply! (type)
        public static string BackupO365SharepointList(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupO365SharepointList" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharePointSite
        // GraphQL -> backupO365SharePointSite: CreateOnDemandJobReply! (type)
        public static string BackupO365SharePointSite(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupO365SharePointSite" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Team
        // GraphQL -> backupO365Team: BatchAsyncJobStatus! (type)
        public static string BackupO365Team(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupO365Team" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Team
        // GraphQL -> backupM365Team: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Team(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "backupM365Team" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsFiles
        // GraphQL -> restoreO365TeamsFiles: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsFiles(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreO365TeamsFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsConversations
        // GraphQL -> restoreO365TeamsConversations: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsConversations(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreO365TeamsConversations" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Snappable
        // GraphQL -> restoreO365Snappable: CreateOnDemandJobReply! (type)
        public static string RestoreO365Snappable(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreO365Snappable" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RefreshO365Org
        // GraphQL -> refreshO365Org: CreateOnDemandJobReply! (type)
        public static string RefreshO365Org(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "orgId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshO365Org" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? DeleteO365Org
        // GraphQL -> deleteO365Org: CreateOnDemandJobReply! (type)
        public static string DeleteO365Org(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "orgId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteO365Org" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Mailbox
        // GraphQL -> restoreO365Mailbox: CreateOnDemandJobReply! (type)
        public static string RestoreO365Mailbox(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "restoreConfig"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreO365Mailbox" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? ExportO365Mailbox
        // GraphQL -> exportO365Mailbox: CreateOnDemandJobReply! (type)
        public static string ExportO365Mailbox(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "exportConfig"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportO365Mailbox" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AzureOauthConsentKickoffReply? AzureOauthConsentKickoff
        // GraphQL -> azureOauthConsentKickoff: AzureOauthConsentKickoffReply! (type)
        public static string AzureOauthConsentKickoff(
            ref AzureOauthConsentKickoffReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureOauthConsentKickoffReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "azureOauthConsentKickoff" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? AzureOauthConsentComplete
        // GraphQL -> azureOauthConsentComplete: RequestStatus! (type)
        public static string AzureOauthConsentComplete(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "azureOauthConsentComplete" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? SetO365ServiceAccount
        // GraphQL -> setO365ServiceAccount: RequestStatus! (type)
        public static string SetO365ServiceAccount(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "username"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "appPassword"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "orgId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "setO365ServiceAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? EnableO365SharePoint
        // GraphQL -> enableO365SharePoint: RequestStatus! (type)
        public static string EnableO365SharePoint(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "enableO365SharePoint" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? EnableO365Teams
        // GraphQL -> enableO365Teams: RequestStatus! (type)
        public static string EnableO365Teams(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "exocomputeClusterId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "enableO365Teams" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestStatus? DeleteO365ServiceAccount
        // GraphQL -> deleteO365ServiceAccount: RequestStatus! (type)
        public static string DeleteO365ServiceAccount(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "orgId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteO365ServiceAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SetupAzureO365ExocomputeResp? SetupAzureO365Exocompute
        // GraphQL -> setupAzureO365Exocompute: SetupAzureO365ExocomputeResp! (type)
        public static string SetupAzureO365Exocompute(
            ref SetupAzureO365ExocomputeResp? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "tenantId"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "subscriptionId"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "exocomputeConfig"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SetupAzureO365ExocomputeResp() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "setupAzureO365Exocompute" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? WarmSearchCache
        // GraphQL -> warmSearchCache: Boolean! (scalar)
        public static string WarmSearchCache(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("warmSearchCache" + args + "\n");
        }

        //      C# -> RequestStatus? CancelTaskchain
        // GraphQL -> cancelTaskchain: RequestStatus! (type)
        public static string CancelTaskchain(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "taskchainId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "cancelTaskchain" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateO365OrgCustomNameReply? UpdateO365OrgCustomName
        // GraphQL -> updateO365OrgCustomName: UpdateO365OrgCustomNameReply! (type)
        public static string UpdateO365OrgCustomName(
            ref UpdateO365OrgCustomNameReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateO365OrgCustomNameReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateO365OrgCustomName" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? ExcludeSharepointObjectsFromProtection
        // GraphQL -> excludeSharepointObjectsFromProtection: Void (scalar)
        public static string ExcludeSharepointObjectsFromProtection(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("excludeSharepointObjectsFromProtection" + args + "\n");
        }

        //      C# -> ValidateAndSaveCustomerKmsInfoReply? ValidateAndSaveCustomerKmsInfo
        // GraphQL -> validateAndSaveCustomerKmsInfo: ValidateAndSaveCustomerKmsInfoReply! (type)
        public static string ValidateAndSaveCustomerKmsInfo(
            ref ValidateAndSaveCustomerKmsInfoReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateAndSaveCustomerKmsInfoReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "validateAndSaveCustomerKmsInfo" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateAzureSaasAppAadReply? CreateAzureSaasAppAad
        // GraphQL -> createAzureSaasAppAad: CreateAzureSaasAppAadReply! (type)
        public static string CreateAzureSaasAppAad(
            ref CreateAzureSaasAppAadReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateAzureSaasAppAadReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAzureSaasAppAad" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkUpdateOracleHostsReply? BulkUpdateOracleHosts
        // GraphQL -> bulkUpdateOracleHosts: BulkUpdateOracleHostsReply! (type)
        public static string BulkUpdateOracleHosts(
            ref BulkUpdateOracleHostsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateOracleHostsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkUpdateOracleHosts" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshOracleDatabase
        // GraphQL -> refreshOracleDatabase: AsyncRequestStatus! (type)
        public static string RefreshOracleDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshOracleDatabase" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> OracleDbDetail? UpdateOracleDataGuardGroup
        // GraphQL -> updateOracleDataGuardGroup: OracleDbDetail! (type)
        public static string UpdateOracleDataGuardGroup(
            ref OracleDbDetail? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleDbDetail() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateOracleDataGuardGroup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteAllOracleDatabaseSnapshots
        // GraphQL -> deleteAllOracleDatabaseSnapshots: Void (scalar)
        public static string DeleteAllOracleDatabaseSnapshots(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteAllOracleDatabaseSnapshots" + args + "\n");
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleDatabaseSnapshot
        // GraphQL -> takeOnDemandOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleDatabaseSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "takeOnDemandOracleDatabaseSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleLogSnapshot
        // GraphQL -> takeOnDemandOracleLogSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleLogSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "takeOnDemandOracleLogSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkUpdateOracleRacsReply? BulkUpdateOracleRacs
        // GraphQL -> bulkUpdateOracleRacs: BulkUpdateOracleRacsReply! (type)
        public static string BulkUpdateOracleRacs(
            ref BulkUpdateOracleRacsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateOracleRacsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkUpdateOracleRacs" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportOracleTablespace
        // GraphQL -> exportOracleTablespace: AsyncRequestStatus! (type)
        public static string ExportOracleTablespace(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportOracleTablespace" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ValidateOracleAcoFileReply? ValidateOracleAcoFile
        // GraphQL -> validateOracleAcoFile: ValidateOracleAcoFileReply! (type)
        public static string ValidateOracleAcoFile(
            ref ValidateOracleAcoFileReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateOracleAcoFileReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "validateOracleAcoFile" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ValidateOracleDatabaseBackups
        // GraphQL -> validateOracleDatabaseBackups: AsyncRequestStatus! (type)
        public static string ValidateOracleDatabaseBackups(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "validateOracleDatabaseBackups" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkUpdateOracleDatabasesReply? BulkUpdateOracleDatabases
        // GraphQL -> bulkUpdateOracleDatabases: BulkUpdateOracleDatabasesReply! (type)
        public static string BulkUpdateOracleDatabases(
            ref BulkUpdateOracleDatabasesReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateOracleDatabasesReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkUpdateOracleDatabases" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? InstantRecoverOracleSnapshot
        // GraphQL -> instantRecoverOracleSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverOracleSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "instantRecoverOracleSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? MountOracleDatabase
        // GraphQL -> mountOracleDatabase: AsyncRequestStatus! (type)
        public static string MountOracleDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "mountOracleDatabase" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportOracleDatabase
        // GraphQL -> exportOracleDatabase: AsyncRequestStatus! (type)
        public static string ExportOracleDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportOracleDatabase" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOraclePdbRestore
        // GraphQL -> createOraclePdbRestore: AsyncRequestStatus! (type)
        public static string CreateOraclePdbRestore(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOraclePdbRestore" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadOracleDatabaseSnapshot
        // GraphQL -> downloadOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string DownloadOracleDatabaseSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadOracleDatabaseSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteOracleMount
        // GraphQL -> deleteOracleMount: AsyncRequestStatus! (type)
        public static string DeleteOracleMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteOracleMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreOracleLogs
        // GraphQL -> restoreOracleLogs: AsyncRequestStatus! (type)
        public static string RestoreOracleLogs(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreOracleLogs" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RegisterNasSystemReply? RegisterNasSystem
        // GraphQL -> registerNasSystem: RegisterNasSystemReply! (type)
        public static string RegisterNasSystem(
            ref RegisterNasSystemReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RegisterNasSystemReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "registerNasSystem" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateNasSystemReply? UpdateNasSystem
        // GraphQL -> updateNasSystem: UpdateNasSystemReply! (type)
        public static string UpdateNasSystem(
            ref UpdateNasSystemReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateNasSystemReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateNasSystem" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteNasSystem
        // GraphQL -> deleteNasSystem: AsyncRequestStatus! (type)
        public static string DeleteNasSystem(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteNasSystem" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? BulkDeleteNasSystems
        // GraphQL -> bulkDeleteNasSystems: BatchAsyncRequestStatus! (type)
        public static string BulkDeleteNasSystems(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkDeleteNasSystems" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RefreshNasSystemsReply? RefreshNasSystems
        // GraphQL -> refreshNasSystems: RefreshNasSystemsReply! (type)
        public static string RefreshNasSystems(
            ref RefreshNasSystemsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RefreshNasSystemsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshNasSystems" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateNasShares
        // GraphQL -> updateNasShares: Void (scalar)
        public static string UpdateNasShares(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateNasShares" + args + "\n");
        }

        //      C# -> ResponseSuccess? HideRevealNasShares
        // GraphQL -> hideRevealNasShares: ResponseSuccess! (type)
        public static string HideRevealNasShares(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "hideRevealNasShares" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? HideRevealNasNamespaces
        // GraphQL -> hideRevealNasNamespaces: Void (scalar)
        public static string HideRevealNasNamespaces(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("hideRevealNasNamespaces" + args + "\n");
        }

        //      C# -> UpdateSnmpConfigReply? UpdateSnmpConfig
        // GraphQL -> updateSnmpConfig: UpdateSnmpConfigReply! (type)
        public static string UpdateSnmpConfig(
            ref UpdateSnmpConfigReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateSnmpConfigReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateSnmpConfig" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddSyslogExportRuleReply? AddSyslogExportRule
        // GraphQL -> addSyslogExportRule: AddSyslogExportRuleReply! (type)
        public static string AddSyslogExportRule(
            ref AddSyslogExportRuleReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddSyslogExportRuleReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addSyslogExportRule" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateSyslogExportRuleReply? UpdateSyslogExportRule
        // GraphQL -> updateSyslogExportRule: UpdateSyslogExportRuleReply! (type)
        public static string UpdateSyslogExportRule(
            ref UpdateSyslogExportRuleReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateSyslogExportRuleReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateSyslogExportRule" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteSyslogExportRule
        // GraphQL -> deleteSyslogExportRule: Void (scalar)
        public static string DeleteSyslogExportRule(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteSyslogExportRule" + args + "\n");
        }

        //      C# -> TestSyslogExportRuleReply? TestSyslogExportRule
        // GraphQL -> testSyslogExportRule: TestSyslogExportRuleReply! (type)
        public static string TestSyslogExportRule(
            ref TestSyslogExportRuleReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TestSyslogExportRuleReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "testSyslogExportRule" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateNutanixCluster
        // GraphQL -> createNutanixCluster: AsyncRequestStatus! (type)
        public static string CreateNutanixCluster(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createNutanixCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshNutanixCluster
        // GraphQL -> refreshNutanixCluster: AsyncRequestStatus! (type)
        public static string RefreshNutanixCluster(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshNutanixCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateNutanixClusterReply? UpdateNutanixCluster
        // GraphQL -> updateNutanixCluster: UpdateNutanixClusterReply! (type)
        public static string UpdateNutanixCluster(
            ref UpdateNutanixClusterReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateNutanixClusterReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateNutanixCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixCluster
        // GraphQL -> deleteNutanixCluster: AsyncRequestStatus! (type)
        public static string DeleteNutanixCluster(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteNutanixCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? RegisterAgentNutanixVm
        // GraphQL -> registerAgentNutanixVm: RequestSuccess! (type)
        public static string RegisterAgentNutanixVm(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "registerAgentNutanixVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? UpdateNutanixVm
        // GraphQL -> updateNutanixVm: Void (scalar)
        public static string UpdateNutanixVm(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateNutanixVm" + args + "\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandNutanixBackup
        // GraphQL -> createOnDemandNutanixBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandNutanixBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOnDemandNutanixBackup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshots
        // GraphQL -> deleteNutanixSnapshots: RequestSuccess! (type)
        public static string DeleteNutanixSnapshots(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteNutanixSnapshots" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? MountNutanixSnapshotV1
        // GraphQL -> mountNutanixSnapshotV1: AsyncRequestStatus! (type)
        public static string MountNutanixSnapshotV1(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "mountNutanixSnapshotV1" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> PatchNutanixMountV1Reply? PatchNutanixMountV1
        // GraphQL -> patchNutanixMountV1: PatchNutanixMountV1Reply! (type)
        public static string PatchNutanixMountV1(
            ref PatchNutanixMountV1Reply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PatchNutanixMountV1Reply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "patchNutanixMountV1" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixMountV1
        // GraphQL -> deleteNutanixMountV1: AsyncRequestStatus! (type)
        public static string DeleteNutanixMountV1(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteNutanixMountV1" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? MigrateNutanixMountV1
        // GraphQL -> migrateNutanixMountV1: AsyncRequestStatus! (type)
        public static string MigrateNutanixMountV1(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "migrateNutanixMountV1" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshot
        // GraphQL -> deleteNutanixSnapshot: RequestSuccess! (type)
        public static string DeleteNutanixSnapshot(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreFilesNutanixSnapshot
        // GraphQL -> restoreFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string RestoreFilesNutanixSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreFilesNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadFilesNutanixSnapshot
        // GraphQL -> downloadFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesNutanixSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadFilesNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportNutanixSnapshot
        // GraphQL -> exportNutanixSnapshot: AsyncRequestStatus! (type)
        public static string ExportNutanixSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "exportNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixSnapshot
        // GraphQL -> downloadNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadNutanixSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchExportNutanixVmReply? BatchExportNutanixVm
        // GraphQL -> batchExportNutanixVm: BatchExportNutanixVmReply! (type)
        public static string BatchExportNutanixVm(
            ref BatchExportNutanixVmReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchExportNutanixVmReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "batchExportNutanixVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchMountNutanixVmReply? BatchMountNutanixVm
        // GraphQL -> batchMountNutanixVm: BatchMountNutanixVmReply! (type)
        public static string BatchMountNutanixVm(
            ref BatchMountNutanixVmReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchMountNutanixVmReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "batchMountNutanixVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixVmFromLocation
        // GraphQL -> downloadNutanixVmFromLocation: AsyncRequestStatus! (type)
        public static string DownloadNutanixVmFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadNutanixVmFromLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkOnDemandSnapshotNutanixVmReply? BulkOnDemandSnapshotNutanixVm
        // GraphQL -> bulkOnDemandSnapshotNutanixVm: BulkOnDemandSnapshotNutanixVmReply! (type)
        public static string BulkOnDemandSnapshotNutanixVm(
            ref BulkOnDemandSnapshotNutanixVmReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkOnDemandSnapshotNutanixVmReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkOnDemandSnapshotNutanixVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkUpdateHostReply? BulkUpdateHost
        // GraphQL -> bulkUpdateHost: BulkUpdateHostReply! (type)
        public static string BulkUpdateHost(
            ref BulkUpdateHostReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateHostReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkUpdateHost" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteHost
        // GraphQL -> bulkDeleteHost: ResponseSuccess! (type)
        public static string BulkDeleteHost(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkDeleteHost" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkRegisterHostReply? BulkRegisterHost
        // GraphQL -> bulkRegisterHost: BulkRegisterHostReply! (type)
        public static string BulkRegisterHost(
            ref BulkRegisterHostReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkRegisterHostReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkRegisterHost" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RefreshHostReply? RefreshHost
        // GraphQL -> refreshHost: RefreshHostReply! (type)
        public static string RefreshHost(
            ref RefreshHostReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RefreshHostReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshHost" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BulkRefreshHostsReply? BulkRefreshHosts
        // GraphQL -> bulkRefreshHosts: BulkRefreshHostsReply! (type)
        public static string BulkRefreshHosts(
            ref BulkRefreshHostsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkRefreshHostsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkRefreshHosts" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateCertificateHostReply? UpdateCertificateHost
        // GraphQL -> updateCertificateHost: UpdateCertificateHostReply! (type)
        public static string UpdateCertificateHost(
            ref UpdateCertificateHostReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateCertificateHostReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateCertificateHost" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ChangeVfdOnHostReply? ChangeVfdOnHost
        // GraphQL -> changeVfdOnHost: ChangeVfdOnHostReply! (type)
        public static string ChangeVfdOnHost(
            ref ChangeVfdOnHostReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ChangeVfdOnHostReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "changeVfdOnHost" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? UpdateRoleAssignments
        // GraphQL -> updateRoleAssignments: Boolean! (scalar)
        public static string UpdateRoleAssignments(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "userIds"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "groupIds"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "roleIds"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateRoleAssignments" + args + "\n");
        }

        //      C# -> System.Boolean? AddRoleAssignments
        // GraphQL -> addRoleAssignments: Boolean! (scalar)
        public static string AddRoleAssignments(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "userIds"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "groupIds"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "roleIds"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("addRoleAssignments" + args + "\n");
        }

        //      C# -> System.String? RevokeAllOrgRoles
        // GraphQL -> revokeAllOrgRoles: Void (scalar)
        public static string RevokeAllOrgRoles(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("revokeAllOrgRoles" + args + "\n");
        }

        //      C# -> System.Boolean? BatchDeassignRoleFromUserGroups
        // GraphQL -> batchDeassignRoleFromUserGroups: Boolean! (scalar)
        public static string BatchDeassignRoleFromUserGroups(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "userGroupToRoles"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("batchDeassignRoleFromUserGroups" + args + "\n");
        }

        //      C# -> System.Boolean? InviteSsoGroup
        // GraphQL -> inviteSsoGroup: Boolean! (scalar)
        public static string InviteSsoGroup(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("inviteSsoGroup" + args + "\n");
        }

        //      C# -> System.String? CreateRole
        // GraphQL -> createRole: UUID! (scalar)
        public static string CreateRole(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "name"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "description"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "permissions"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createRole" + args + "\n");
        }

        //      C# -> System.String? MutateRole
        // GraphQL -> mutateRole: UUID! (scalar)
        public static string MutateRole(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "roleId"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "name"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "description"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "permissions"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "protectableClusters"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("mutateRole" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateRole
        // GraphQL -> updateRole: Boolean! (scalar)
        public static string UpdateRole(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "roleId"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "name"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "description"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "permissions"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateRole" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteRole
        // GraphQL -> deleteRole: Boolean! (scalar)
        public static string DeleteRole(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "roleId"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteRole" + args + "\n");
        }

        //      C# -> CreateCustomReportReply? CreateCustomReport
        // GraphQL -> createCustomReport: CreateCustomReportReply! (type)
        public static string CreateCustomReport(
            ref CreateCustomReportReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateCustomReportReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createCustomReport" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateCustomReportReply? UpdateCustomReport
        // GraphQL -> updateCustomReport: UpdateCustomReportReply! (type)
        public static string UpdateCustomReport(
            ref UpdateCustomReportReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateCustomReportReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateCustomReport" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteCustomReport
        // GraphQL -> deleteCustomReport: Void (scalar)
        public static string DeleteCustomReport(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCustomReport" + args + "\n");
        }

        //      C# -> CreateScheduledReportReply? CreateScheduledReport
        // GraphQL -> createScheduledReport: CreateScheduledReportReply! (type)
        public static string CreateScheduledReport(
            ref CreateScheduledReportReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateScheduledReportReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createScheduledReport" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateScheduledReportReply? UpdateScheduledReport
        // GraphQL -> updateScheduledReport: UpdateScheduledReportReply! (type)
        public static string UpdateScheduledReport(
            ref UpdateScheduledReportReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateScheduledReportReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateScheduledReport" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteScheduledReport
        // GraphQL -> deleteScheduledReport: Void (scalar)
        public static string DeleteScheduledReport(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteScheduledReport" + args + "\n");
        }

        //      C# -> AsyncDownloadReply? SendScheduledReportAsync
        // GraphQL -> sendScheduledReportAsync: AsyncDownloadReply! (type)
        public static string SendScheduledReportAsync(
            ref AsyncDownloadReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncDownloadReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "sendScheduledReportAsync" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncDownloadReply? DownloadReportCsvAsync
        // GraphQL -> downloadReportCsvAsync: AsyncDownloadReply! (type)
        public static string DownloadReportCsvAsync(
            ref AsyncDownloadReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncDownloadReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadReportCsvAsync" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncDownloadReply? DownloadReportPdfAsync
        // GraphQL -> downloadReportPdfAsync: AsyncDownloadReply! (type)
        public static string DownloadReportPdfAsync(
            ref AsyncDownloadReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncDownloadReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadReportPdfAsync" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? CreateUser
        // GraphQL -> createUser: String! (scalar)
        public static string CreateUser(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "email"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "roleIds"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createUser" + args + "\n");
        }

        //      C# -> System.String? CreateUserWithPassword
        // GraphQL -> createUserWithPassword: String! (scalar)
        public static string CreateUserWithPassword(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createUserWithPassword" + args + "\n");
        }

        //      C# -> System.Boolean? ChangePassword
        // GraphQL -> changePassword: Boolean! (scalar)
        public static string ChangePassword(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("changePassword" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateAccountOwner
        // GraphQL -> updateAccountOwner: Boolean! (scalar)
        public static string UpdateAccountOwner(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "userId"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateAccountOwner" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteUsersFromAccount
        // GraphQL -> deleteUsersFromAccount: Boolean! (scalar)
        public static string DeleteUsersFromAccount(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "ids"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteUsersFromAccount" + args + "\n");
        }

        //      C# -> System.Boolean? RemoveCdmCluster
        // GraphQL -> removeCdmCluster: Boolean! (scalar)
        public static string RemoveCdmCluster(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "clusterUuid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "isForce"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "expireInDays"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removeCdmCluster" + args + "\n");
        }

        //      C# -> UserDownloadUrl? GetDownloadUrl
        // GraphQL -> getDownloadUrl: UserDownloadUrl! (type)
        public static string GetDownloadUrl(
            ref UserDownloadUrl? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "downloadId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UserDownloadUrl() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "getDownloadUrl" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> GenerateTotpSecretReply? GenerateTotpSecret
        // GraphQL -> generateTotpSecret: GenerateTotpSecretReply! (type)
        public static string GenerateTotpSecret(
            ref GenerateTotpSecretReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "userId"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GenerateTotpSecretReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "generateTotpSecret" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? SetTotpConfig
        // GraphQL -> setTotpConfig: Boolean! (scalar)
        public static string SetTotpConfig(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setTotpConfig" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteTotpConfig
        // GraphQL -> deleteTotpConfig: Boolean! (scalar)
        public static string DeleteTotpConfig(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "userId"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteTotpConfig" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteTotpConfigs
        // GraphQL -> deleteTotpConfigs: Boolean! (scalar)
        public static string DeleteTotpConfigs(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteTotpConfigs" + args + "\n");
        }

        //      C# -> System.Boolean? SetUserLevelTotpEnforcement
        // GraphQL -> setUserLevelTotpEnforcement: Boolean! (scalar)
        public static string SetUserLevelTotpEnforcement(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setUserLevelTotpEnforcement" + args + "\n");
        }

        //      C# -> System.Boolean? SetMfaSetting
        // GraphQL -> setMfaSetting: Boolean! (scalar)
        public static string SetMfaSetting(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setMfaSetting" + args + "\n");
        }

        //      C# -> System.Boolean? SetLdapMfaSetting
        // GraphQL -> setLdapMfaSetting: Boolean! (scalar)
        public static string SetLdapMfaSetting(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setLdapMfaSetting" + args + "\n");
        }

        //      C# -> ClusterRegistrationToken? GenerateClusterRegistrationToken
        // GraphQL -> generateClusterRegistrationToken: ClusterRegistrationToken! (type)
        public static string GenerateClusterRegistrationToken(
            ref ClusterRegistrationToken? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterRegistrationToken() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "generateClusterRegistrationToken" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateLockoutConfigReply? UpdateLockoutConfig
        // GraphQL -> updateLockoutConfig: UpdateLockoutConfigReply! (type)
        public static string UpdateLockoutConfig(
            ref UpdateLockoutConfigReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateLockoutConfigReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateLockoutConfig" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? LockUsersByAdmin
        // GraphQL -> lockUsersByAdmin: Void (scalar)
        public static string LockUsersByAdmin(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("lockUsersByAdmin" + args + "\n");
        }

        //      C# -> System.String? UnlockUsersByAdmin
        // GraphQL -> unlockUsersByAdmin: Void (scalar)
        public static string UnlockUsersByAdmin(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("unlockUsersByAdmin" + args + "\n");
        }

        //      C# -> System.String? UpdateAuthDomainUsersHiddenStatus
        // GraphQL -> updateAuthDomainUsersHiddenStatus: Void (scalar)
        public static string UpdateAuthDomainUsersHiddenStatus(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateAuthDomainUsersHiddenStatus" + args + "\n");
        }

        //      C# -> System.String? UpgradeToRsc
        // GraphQL -> upgradeToRsc: Void (scalar)
        public static string UpgradeToRsc(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("upgradeToRsc" + args + "\n");
        }

        //      C# -> System.String? SetSsoCertificate
        // GraphQL -> setSsoCertificate: Void (scalar)
        public static string SetSsoCertificate(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setSsoCertificate" + args + "\n");
        }

        //      C# -> AddSapHanaSystemReply? AddSapHanaSystem
        // GraphQL -> addSapHanaSystem: AddSapHanaSystemReply! (type)
        public static string AddSapHanaSystem(
            ref AddSapHanaSystemReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddSapHanaSystemReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addSapHanaSystem" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandSapHanaBackup
        // GraphQL -> createOnDemandSapHanaBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandSapHanaBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOnDemandSapHanaBackup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteSapHanaSystem
        // GraphQL -> deleteSapHanaSystem: AsyncRequestStatus! (type)
        public static string DeleteSapHanaSystem(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteSapHanaSystem" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateSapHanaSystemRefresh
        // GraphQL -> createSapHanaSystemRefresh: AsyncRequestStatus! (type)
        public static string CreateSapHanaSystemRefresh(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createSapHanaSystemRefresh" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteSapHanaDbSnapshot
        // GraphQL -> deleteSapHanaDbSnapshot: ResponseSuccess! (type)
        public static string DeleteSapHanaDbSnapshot(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteSapHanaDbSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> PatchSapHanaSystemReply? PatchSapHanaSystem
        // GraphQL -> patchSapHanaSystem: PatchSapHanaSystemReply! (type)
        public static string PatchSapHanaSystem(
            ref PatchSapHanaSystemReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PatchSapHanaSystemReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "patchSapHanaSystem" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshot
        // GraphQL -> downloadSapHanaSnapshot: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadSapHanaSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotFromLocation
        // GraphQL -> downloadSapHanaSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadSapHanaSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotsForPointInTimeRecovery
        // GraphQL -> downloadSapHanaSnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotsForPointInTimeRecovery(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadSapHanaSnapshotsForPointInTimeRecovery" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedSapHanaSnapshots
        // GraphQL -> expireDownloadedSapHanaSnapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedSapHanaSnapshots(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "expireDownloadedSapHanaSnapshots" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ConfigureSapHanaRestore
        // GraphQL -> configureSapHanaRestore: AsyncRequestStatus! (type)
        public static string ConfigureSapHanaRestore(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "configureSapHanaRestore" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? UnconfigureSapHanaRestore
        // GraphQL -> unconfigureSapHanaRestore: AsyncRequestStatus! (type)
        public static string UnconfigureSapHanaRestore(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "unconfigureSapHanaRestore" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateServiceAccountReply? CreateServiceAccount
        // GraphQL -> createServiceAccount: CreateServiceAccountReply! (type)
        public static string CreateServiceAccount(
            ref CreateServiceAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateServiceAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createServiceAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? DeleteServiceAccountsFromAccount
        // GraphQL -> deleteServiceAccountsFromAccount: Boolean! (scalar)
        public static string DeleteServiceAccountsFromAccount(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteServiceAccountsFromAccount" + args + "\n");
        }

        //      C# -> UpdateServiceAccountReply? UpdateServiceAccount
        // GraphQL -> updateServiceAccount: UpdateServiceAccountReply! (type)
        public static string UpdateServiceAccount(
            ref UpdateServiceAccountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateServiceAccountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateServiceAccount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RotateServiceAccountSecretReply? RotateServiceAccountSecret
        // GraphQL -> rotateServiceAccountSecret: RotateServiceAccountSecretReply! (type)
        public static string RotateServiceAccountSecret(
            ref RotateServiceAccountSecretReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RotateServiceAccountSecretReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "rotateServiceAccountSecret" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddStorageArraysReply? AddStorageArrays
        // GraphQL -> addStorageArrays: AddStorageArraysReply! (type)
        public static string AddStorageArrays(
            ref AddStorageArraysReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addStorageArrays" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RefreshStorageArraysReply? RefreshStorageArrays
        // GraphQL -> refreshStorageArrays: RefreshStorageArraysReply! (type)
        public static string RefreshStorageArrays(
            ref RefreshStorageArraysReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RefreshStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshStorageArrays" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateStorageArraysReply? UpdateStorageArrays
        // GraphQL -> updateStorageArrays: UpdateStorageArraysReply! (type)
        public static string UpdateStorageArrays(
            ref UpdateStorageArraysReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateStorageArrays" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DeleteStorageArraysReply? DeleteStorageArrays
        // GraphQL -> deleteStorageArrays: DeleteStorageArraysReply! (type)
        public static string DeleteStorageArrays(
            ref DeleteStorageArraysReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DeleteStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteStorageArrays" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateVappsInstantRecoveryReply? CreateVappsInstantRecovery
        // GraphQL -> createVappsInstantRecovery: CreateVappsInstantRecoveryReply! (type)
        public static string CreateVappsInstantRecovery(
            ref CreateVappsInstantRecoveryReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateVappsInstantRecoveryReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createVappsInstantRecovery" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateVolumeGroupReply? UpdateVolumeGroup
        // GraphQL -> updateVolumeGroup: UpdateVolumeGroupReply! (type)
        public static string UpdateVolumeGroup(
            ref UpdateVolumeGroupReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateVolumeGroupReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateVolumeGroup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreVolumeGroupSnapshotFiles
        // GraphQL -> restoreVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreVolumeGroupSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "restoreVolumeGroupSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandVolumeGroupBackup
        // GraphQL -> createOnDemandVolumeGroupBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandVolumeGroupBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOnDemandVolumeGroupBackup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFiles
        // GraphQL -> downloadVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadVolumeGroupSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? StartVolumeGroupMount
        // GraphQL -> startVolumeGroupMount: AsyncRequestStatus! (type)
        public static string StartVolumeGroupMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startVolumeGroupMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteVolumeGroupMount
        // GraphQL -> deleteVolumeGroupMount: AsyncRequestStatus! (type)
        public static string DeleteVolumeGroupMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteVolumeGroupMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateDownloadSnapshotForVolumeGroup
        // GraphQL -> createDownloadSnapshotForVolumeGroup: AsyncRequestStatus! (type)
        public static string CreateDownloadSnapshotForVolumeGroup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createDownloadSnapshotForVolumeGroup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFromLocation
        // GraphQL -> downloadVolumeGroupSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadVolumeGroupSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmRecoverFiles
        // GraphQL -> vsphereVmRecoverFiles: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmRecoverFiles(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmRecoverFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmRecoverFilesNew
        // GraphQL -> vsphereVmRecoverFilesNew: AsyncRequestStatus! (type)
        public static string VsphereVmRecoverFilesNew(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmRecoverFilesNew" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? VsphereVmRegisterAgent
        // GraphQL -> vsphereVmRegisterAgent: RequestSuccess! (type)
        public static string VsphereVmRegisterAgent(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmRegisterAgent" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereOnDemandSnapshot
        // GraphQL -> vsphereOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string VsphereOnDemandSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereBulkOnDemandSnapshot
        // GraphQL -> vsphereBulkOnDemandSnapshot: BatchAsyncRequestStatus! (type)
        public static string VsphereBulkOnDemandSnapshot(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereBulkOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshot
        // GraphQL -> vsphereVmDownloadSnapshot: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmDownloadSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV2
        // GraphQL -> vsphereVmExportSnapshotV2: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmExportSnapshotV2" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV3
        // GraphQL -> vsphereVmExportSnapshotV3: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV3(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmExportSnapshotV3" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExport
        // GraphQL -> vsphereVmBatchExport: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExport(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmBatchExport" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInPlaceRecovery
        // GraphQL -> vsphereVmInitiateInPlaceRecovery: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInPlaceRecovery(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmInitiateInPlaceRecovery" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotWithDownloadFromCloud
        // GraphQL -> vsphereVmExportSnapshotWithDownloadFromCloud: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotWithDownloadFromCloud(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmExportSnapshotWithDownloadFromCloud" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchInPlaceRecovery
        // GraphQL -> vsphereVmBatchInPlaceRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchInPlaceRecovery(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmBatchInPlaceRecovery" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? VsphereVmDeleteSnapshot
        // GraphQL -> vsphereVmDeleteSnapshot: Void (scalar)
        public static string VsphereVmDeleteSnapshot(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("vsphereVmDeleteSnapshot" + args + "\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInstantRecoveryV2
        // GraphQL -> vsphereVmInitiateInstantRecoveryV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInstantRecoveryV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmInitiateInstantRecoveryV2" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchInstantRecovery
        // GraphQL -> vsphereVmInitiateBatchInstantRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchInstantRecovery(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmInitiateBatchInstantRecovery" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateDiskMount
        // GraphQL -> vsphereVmInitiateDiskMount: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateDiskMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmInitiateDiskMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateLiveMountV2
        // GraphQL -> vsphereVmInitiateLiveMountV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateLiveMountV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmInitiateLiveMountV2" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchLiveMountV2
        // GraphQL -> vsphereVmInitiateBatchLiveMountV2: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchLiveMountV2(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmInitiateBatchLiveMountV2" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> VsphereVmPowerOnOffLiveMountReply? VsphereVmPowerOnOffLiveMount
        // GraphQL -> vsphereVmPowerOnOffLiveMount: VsphereVmPowerOnOffLiveMountReply! (type)
        public static string VsphereVmPowerOnOffLiveMount(
            ref VsphereVmPowerOnOffLiveMountReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereVmPowerOnOffLiveMountReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmPowerOnOffLiveMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteVsphereLiveMount
        // GraphQL -> deleteVsphereLiveMount: AsyncRequestStatus! (type)
        public static string DeleteVsphereLiveMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteVsphereLiveMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> VsphereVmListEsxiDatastoresReply? VsphereVmListEsxiDatastores
        // GraphQL -> vsphereVmListEsxiDatastores: VsphereVmListEsxiDatastoresReply! (type)
        public static string VsphereVmListEsxiDatastores(
            ref VsphereVmListEsxiDatastoresReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereVmListEsxiDatastoresReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmListEsxiDatastores" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereExportSnapshotToStandaloneHostV2
        // GraphQL -> vsphereExportSnapshotToStandaloneHostV2: AsyncRequestStatus! (type)
        public static string VsphereExportSnapshotToStandaloneHostV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereExportSnapshotToStandaloneHostV2" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateVsphereVcenterReply? CreateVsphereVcenter
        // GraphQL -> createVsphereVcenter: CreateVsphereVcenterReply! (type)
        public static string CreateVsphereVcenter(
            ref CreateVsphereVcenterReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateVsphereVcenterReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createVsphereVcenter" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereDeleteVcenter
        // GraphQL -> vsphereDeleteVcenter: AsyncRequestStatus! (type)
        public static string VsphereDeleteVcenter(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereDeleteVcenter" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadVsphereVirtualMachineFiles
        // GraphQL -> downloadVsphereVirtualMachineFiles: AsyncRequestStatus! (type)
        public static string DownloadVsphereVirtualMachineFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadVsphereVirtualMachineFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshVsphereVcenter
        // GraphQL -> refreshVsphereVcenter: AsyncRequestStatus! (type)
        public static string RefreshVsphereVcenter(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "refreshVsphereVcenter" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateVcenterReply? UpdateVcenter
        // GraphQL -> updateVcenter: UpdateVcenterReply! (type)
        public static string UpdateVcenter(
            ref UpdateVcenterReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateVcenterReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateVcenter" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocate
        // GraphQL -> vsphereVmMountRelocate: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocate(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmMountRelocate" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocateV2
        // GraphQL -> vsphereVmMountRelocateV2: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocateV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmMountRelocateV2" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? VsphereExcludeVmDisks
        // GraphQL -> vsphereExcludeVmDisks: RequestSuccess! (type)
        public static string VsphereExcludeVmDisks(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereExcludeVmDisks" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshotFiles
        // GraphQL -> vsphereVmDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vsphereVmDownloadSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateGuestCredentialReply? CreateGuestCredential
        // GraphQL -> createGuestCredential: CreateGuestCredentialReply! (type)
        public static string CreateGuestCredential(
            ref CreateGuestCredentialReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateGuestCredentialReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createGuestCredential" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateGuestCredentialReply? UpdateGuestCredential
        // GraphQL -> updateGuestCredential: UpdateGuestCredentialReply! (type)
        public static string UpdateGuestCredential(
            ref UpdateGuestCredentialReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateGuestCredentialReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateGuestCredential" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.Boolean? DeleteGuestCredentialById
        // GraphQL -> deleteGuestCredentialById: Boolean! (scalar)
        public static string DeleteGuestCredentialById(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteGuestCredentialById" + args + "\n");
        }

        //      C# -> AsyncRequestStatus? VmwareDownloadSnapshotFromLocation
        // GraphQL -> vmwareDownloadSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string VmwareDownloadSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "vmwareDownloadSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddNetwork
        // GraphQL -> updateVcenterHotAddNetwork: RequestSuccess! (type)
        public static string UpdateVcenterHotAddNetwork(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateVcenterHotAddNetwork" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UpdateVsphereVm
        // GraphQL -> updateVsphereVm: RequestSuccess! (type)
        public static string UpdateVsphereVm(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateVsphereVm" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddBandwidth
        // GraphQL -> updateVcenterHotAddBandwidth: RequestSuccess! (type)
        public static string UpdateVcenterHotAddBandwidth(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateVcenterHotAddBandwidth" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CreateVsphereAdvancedTagReply? CreateVsphereAdvancedTag
        // GraphQL -> createVsphereAdvancedTag: CreateVsphereAdvancedTagReply! (type)
        public static string CreateVsphereAdvancedTag(
            ref CreateVsphereAdvancedTagReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CreateVsphereAdvancedTagReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createVsphereAdvancedTag" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteVsphereAdvancedTag
        // GraphQL -> deleteVsphereAdvancedTag: RequestSuccess! (type)
        public static string DeleteVsphereAdvancedTag(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteVsphereAdvancedTag" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> UpdateVsphereAdvancedTagReply? UpdateVsphereAdvancedTag
        // GraphQL -> updateVsphereAdvancedTag: UpdateVsphereAdvancedTagReply! (type)
        public static string UpdateVsphereAdvancedTag(
            ref UpdateVsphereAdvancedTagReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateVsphereAdvancedTagReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "updateVsphereAdvancedTag" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SetDatastoreFreespaceThresholdsReply? SetDatastoreFreespaceThresholds
        // GraphQL -> setDatastoreFreespaceThresholds: SetDatastoreFreespaceThresholdsReply! (type)
        public static string SetDatastoreFreespaceThresholds(
            ref SetDatastoreFreespaceThresholdsReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SetDatastoreFreespaceThresholdsReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "setDatastoreFreespaceThresholds" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UpgradeIoFilter
        // GraphQL -> upgradeIoFilter: RequestSuccess! (type)
        public static string UpgradeIoFilter(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "upgradeIoFilter" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? InstallIoFilter
        // GraphQL -> installIoFilter: RequestSuccess! (type)
        public static string InstallIoFilter(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "installIoFilter" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UninstallIoFilter
        // GraphQL -> uninstallIoFilter: RequestSuccess! (type)
        public static string UninstallIoFilter(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "uninstallIoFilter" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> DownloadPackageReply? RetryDownloadPackageJob
        // GraphQL -> retryDownloadPackageJob: DownloadPackageReply! (type)
        public static string RetryDownloadPackageJob(
            ref DownloadPackageReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "clusterUuid"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadPackageReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "retryDownloadPackageJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<DownloadPackageReplyWithUuid>? StartDownloadPackageBatchJob
        // GraphQL -> startDownloadPackageBatchJob: [DownloadPackageReplyWithUuid!]! (type)
        public static string StartDownloadPackageBatchJob(
            ref List<DownloadPackageReplyWithUuid>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "listClusterUuid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "downloadVersion"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "packageUrl"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "md5checksum"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "size"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<DownloadPackageReplyWithUuid>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startDownloadPackageBatchJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? StartUpgradeBatchJob
        // GraphQL -> startUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string StartUpgradeBatchJob(
            ref List<UpgradeJobReplyWithUuid>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "listClusterUuid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "mode"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "action"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "version"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "contextTag"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<UpgradeJobReplyWithUuid>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startUpgradeBatchJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? ScheduleUpgradeBatchJob
        // GraphQL -> scheduleUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string ScheduleUpgradeBatchJob(
            ref List<UpgradeJobReplyWithUuid>? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "listClusterUuid"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "mode"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "action"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "version"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "scheduleAt"); 
            args += "\n";
            args += String.Format("{0}: ${0}", "contextTag"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<UpgradeJobReplyWithUuid>() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "scheduleUpgradeBatchJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CancelJobReply? CancelScheduledUpgrade
        // GraphQL -> cancelScheduledUpgrade: CancelJobReply! (type)
        public static string CancelScheduledUpgrade(
            ref CancelJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "clusterUuid"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CancelJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "cancelScheduledUpgrade" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CancelJobReply? CancelDownloadPackage
        // GraphQL -> cancelDownloadPackage: CancelJobReply! (type)
        public static string CancelDownloadPackage(
            ref CancelJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "clusterUuid"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CancelJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "cancelDownloadPackage" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> PrechecksJobReply? StartPeriodicUpgradePrechecksOnDemandJob
        // GraphQL -> startPeriodicUpgradePrechecksOnDemandJob: PrechecksJobReply! (type)
        public static string StartPeriodicUpgradePrechecksOnDemandJob(
            ref PrechecksJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "clusterUuid"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PrechecksJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "startPeriodicUpgradePrechecksOnDemandJob" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SupportPortalLoginReply? SupportPortalLogin
        // GraphQL -> supportPortalLogin: SupportPortalLoginReply! (type)
        public static string SupportPortalLogin(
            ref SupportPortalLoginReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SupportPortalLoginReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "supportPortalLogin" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SupportPortalLogoutReply? LogoutFromRubrikSupportPortal
        // GraphQL -> logoutFromRubrikSupportPortal: SupportPortalLogoutReply! (type)
        public static string LogoutFromRubrikSupportPortal(
            ref SupportPortalLogoutReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new SupportPortalLogoutReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "logoutFromRubrikSupportPortal" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> SetUpgradeTypeReply? SetUpgradeType
        // GraphQL -> setUpgradeType: SetUpgradeTypeReply! (type)
        public static string SetUpgradeType(
            ref SetUpgradeTypeReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SetUpgradeTypeReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "setUpgradeType" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? CreateAzureCluster
        // GraphQL -> createAzureCluster: CcProvisionJobReply! (type)
        public static string CreateAzureCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAzureCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? DeleteAzureCluster
        // GraphQL -> deleteAzureCluster: CcProvisionJobReply! (type)
        public static string DeleteAzureCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteAzureCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? CreateAwsCluster
        // GraphQL -> createAwsCluster: CcProvisionJobReply! (type)
        public static string CreateAwsCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createAwsCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? DeleteAwsCluster
        // GraphQL -> deleteAwsCluster: CcProvisionJobReply! (type)
        public static string DeleteAwsCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteAwsCluster" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> TakeOnDemandSnapshotReply? TakeOnDemandSnapshot
        // GraphQL -> takeOnDemandSnapshot: TakeOnDemandSnapshotReply! (type)
        public static string TakeOnDemandSnapshot(
            ref TakeOnDemandSnapshotReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TakeOnDemandSnapshotReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "takeOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandExchangeBackup
        // GraphQL -> createOnDemandExchangeBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandExchangeBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createOnDemandExchangeBackup" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> V1BulkUpdateExchangeDagResponse? BulkUpdateExchangeDag
        // GraphQL -> bulkUpdateExchangeDag: V1BulkUpdateExchangeDagResponse! (type)
        public static string BulkUpdateExchangeDag(
            ref V1BulkUpdateExchangeDagResponse? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new V1BulkUpdateExchangeDagResponse() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "bulkUpdateExchangeDag" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateExchangeMount
        // GraphQL -> createExchangeMount: AsyncRequestStatus! (type)
        public static string CreateExchangeMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "createExchangeMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteExchangeSnapshotMount
        // GraphQL -> deleteExchangeSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteExchangeSnapshotMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "deleteExchangeSnapshotMount" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadExchangeSnapshot
        // GraphQL -> downloadExchangeSnapshot: AsyncRequestStatus! (type)
        public static string DownloadExchangeSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "downloadExchangeSnapshot" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? ResolveVolumeGroupsConflict
        // GraphQL -> resolveVolumeGroupsConflict: RequestSuccess! (type)
        public static string ResolveVolumeGroupsConflict(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "resolveVolumeGroupsConflict" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AddAndJoinSmbDomainReply? AddAndJoinSmbDomain
        // GraphQL -> addAndJoinSmbDomain: AddAndJoinSmbDomainReply! (type)
        public static string AddAndJoinSmbDomain(
            ref AddAndJoinSmbDomainReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AddAndJoinSmbDomainReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "addAndJoinSmbDomain" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? JoinSmbDomain
        // GraphQL -> joinSmbDomain: Void (scalar)
        public static string JoinSmbDomain(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("joinSmbDomain" + args + "\n");
        }

        //      C# -> PutSmbConfigurationReply? PutSmbConfiguration
        // GraphQL -> putSmbConfiguration: PutSmbConfigurationReply! (type)
        public static string PutSmbConfiguration(
            ref PutSmbConfigurationReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PutSmbConfigurationReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "putSmbConfiguration" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> System.String? DeleteSmbDomain
        // GraphQL -> deleteSmbDomain: Void (scalar)
        public static string DeleteSmbDomain(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteSmbDomain" + args + "\n");
        }

        //      C# -> System.String? EnableSupportUserAccess
        // GraphQL -> enableSupportUserAccess: Void (scalar)
        public static string EnableSupportUserAccess(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("enableSupportUserAccess" + args + "\n");
        }

        //      C# -> System.String? DisableSupportUserAccess
        // GraphQL -> disableSupportUserAccess: Void (scalar)
        public static string DisableSupportUserAccess(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("disableSupportUserAccess" + args + "\n");
        }

        //      C# -> System.String? UpdateSupportUserAccess
        // GraphQL -> updateSupportUserAccess: Void (scalar)
        public static string UpdateSupportUserAccess(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateSupportUserAccess" + args + "\n");
        }

        //      C# -> SendPdfReportReply? SendPdfReport
        // GraphQL -> sendPdfReport: SendPdfReportReply! (type)
        public static string SendPdfReport(
            ref SendPdfReportReply? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SendPdfReportReply() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "sendPdfReport" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectPath
        // GraphQL -> recoverCloudDirectPath: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectPath(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "";
            args += "\n(";
            args += "\n";
            args += String.Format("{0}: ${0}", "input"); 
            args += "\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFragment();
            }
            return new string(
                "recoverCloudDirectPath" + args + "{\n" +
                cmdletReply.AsFragment(1) +
                "}\n");
        }

        #endregion

    } // class Mutation
    #endregion
}
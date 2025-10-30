// New-RscMutationReport.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 8
    /// operations in the 'Report' API domain:
    /// CreateScheduled, DeleteCustom, DeleteScheduledReport, SendPdf, SendScheduledReportAsync, StartClusterMigrationJob, UpdateDatabaseLogingPropertiesForCluster, or UpdateScheduledReport.
    /// </summary>
    /// <description>
    /// New-RscMutationReport creates a new
    /// mutation object for operations
    /// in the 'Report' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 8 operations
    /// in the 'Report' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateScheduled, DeleteCustom, DeleteScheduledReport, SendPdf, SendScheduledReportAsync, StartClusterMigrationJob, UpdateDatabaseLogingPropertiesForCluster, or UpdateScheduledReport.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationReport -CreateScheduled).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationReport -CreateScheduled).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateScheduled operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: CreateScheduled
    /// 
    /// $query = New-RscMutationReport -Operation CreateScheduled
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	reportId = $someInt
    /// 	# REQUIRED
    /// 	title = $someString
    /// 	# OPTIONAL
    /// 	dailyTime = $someDateTime
    /// 	# OPTIONAL
    /// 	weeklyTime = $someDateTime
    /// 	# OPTIONAL
    /// 	monthlyDate = $someInt
    /// 	# OPTIONAL
    /// 	monthlyTime = $someDateTime
    /// 	# REQUIRED
    /// 	rubrikRecipientUserIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	nonRubrikRecipientEmails = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	updateCreator = $someBoolean
    /// 	# OPTIONAL
    /// 	timeZone = $someString
    /// 	# OPTIONAL
    /// 	showChartsInEmailBody = $someBoolean
    /// 	# OPTIONAL
    /// 	weeklyDays = @(
    /// 		$someWeekDay # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WeekDay]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	attachmentTypes = @(
    /// 		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateScheduledReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCustom operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DeleteCustom
    /// 
    /// $query = New-RscMutationReport -Operation DeleteCustom
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteScheduledReport operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DeleteScheduledReport
    /// 
    /// $query = New-RscMutationReport -Operation DeleteScheduledReport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# OPTIONAL
    /// 	reportId = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SendPdf operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SendPdf
    /// 
    /// $query = New-RscMutationReport -Operation SendPdf
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	rubrikRecipientUserIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	nonRubrikRecipientEmailIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	password = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SendPdfReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SendScheduledReportAsync operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SendScheduledReportAsync
    /// 
    /// $query = New-RscMutationReport -Operation SendScheduledReportAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	rubrikUserIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	reportId = $someInt
    /// 	# OPTIONAL
    /// 	nonRubrikUserEmails = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	attachmentTypes = @(
    /// 		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	showChartsInEmailBody = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncDownloadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartClusterMigrationJob operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: StartClusterMigrationJob
    /// 
    /// $query = New-RscMutationReport -Operation StartClusterMigrationJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	shouldDeleteCdmSchedules = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartClusterReportMigrationJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateDatabaseLogingPropertiesForCluster operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: UpdateDatabaseLogingPropertiesForCluster
    /// 
    /// $query = New-RscMutationReport -Operation UpdateDatabaseLogingPropertiesForCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	properties = @{
    /// 		# OPTIONAL
    /// 		enableDelayNotification = $someBoolean
    /// 		# OPTIONAL
    /// 		logDelayThresholdInMin = $someInt64
    /// 		# OPTIONAL
    /// 		logDelayNotificationFrequencyInMin = $someInt64
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DbLogReportProperties
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateScheduledReport operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: UpdateScheduledReport
    /// 
    /// $query = New-RscMutationReport -Operation UpdateScheduledReport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		reportId = $someInt
    /// 		# REQUIRED
    /// 		title = $someString
    /// 		# OPTIONAL
    /// 		dailyTime = $someDateTime
    /// 		# OPTIONAL
    /// 		weeklyTime = $someDateTime
    /// 		# OPTIONAL
    /// 		monthlyDate = $someInt
    /// 		# OPTIONAL
    /// 		monthlyTime = $someDateTime
    /// 		# REQUIRED
    /// 		rubrikRecipientUserIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		nonRubrikRecipientEmails = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		timeZone = $someString
    /// 		# OPTIONAL
    /// 		showChartsInEmailBody = $someBoolean
    /// 		# OPTIONAL
    /// 		updateCreator = $someBoolean
    /// 		# OPTIONAL
    /// 		weeklyDays = @(
    /// 			$someWeekDay # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WeekDay]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		attachmentTypes = @(
    /// 			$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateScheduledReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationReport",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationReport : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreateScheduled",
                "DeleteCustom",
                "DeleteScheduledReport",
                "SendPdf",
                "SendScheduledReportAsync",
                "StartClusterMigrationJob",
                "UpdateDatabaseLogingPropertiesForCluster",
                "UpdateScheduledReport",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "CreateScheduled":
                        this.ProcessRecord_CreateScheduled();
                        break;
                    case "DeleteCustom":
                        this.ProcessRecord_DeleteCustom();
                        break;
                    case "DeleteScheduledReport":
                        this.ProcessRecord_DeleteScheduledReport();
                        break;
                    case "SendPdf":
                        this.ProcessRecord_SendPdf();
                        break;
                    case "SendScheduledReportAsync":
                        this.ProcessRecord_SendScheduledReportAsync();
                        break;
                    case "StartClusterMigrationJob":
                        this.ProcessRecord_StartClusterMigrationJob();
                        break;
                    case "UpdateDatabaseLogingPropertiesForCluster":
                        this.ProcessRecord_UpdateDatabaseLogingPropertiesForCluster();
                        break;
                    case "UpdateScheduledReport":
                        this.ProcessRecord_UpdateScheduledReport();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // createScheduledReport.
        internal void ProcessRecord_CreateScheduled()
        {
            this._logger.name += " -CreateScheduled";
            // Create new graphql operation createScheduledReport
            InitMutationCreateScheduledReport();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCustomReport.
        internal void ProcessRecord_DeleteCustom()
        {
            this._logger.name += " -DeleteCustom";
            // Create new graphql operation deleteCustomReport
            InitMutationDeleteCustomReport();
        }

        // This parameter set invokes a single graphql operation:
        // deleteScheduledReport.
        internal void ProcessRecord_DeleteScheduledReport()
        {
            this._logger.name += " -DeleteScheduledReport";
            // Create new graphql operation deleteScheduledReport
            InitMutationDeleteScheduledReport();
        }

        // This parameter set invokes a single graphql operation:
        // sendPdfReport.
        internal void ProcessRecord_SendPdf()
        {
            this._logger.name += " -SendPdf";
            // Create new graphql operation sendPdfReport
            InitMutationSendPdfReport();
        }

        // This parameter set invokes a single graphql operation:
        // sendScheduledReportAsync.
        internal void ProcessRecord_SendScheduledReportAsync()
        {
            this._logger.name += " -SendScheduledReportAsync";
            // Create new graphql operation sendScheduledReportAsync
            InitMutationSendScheduledReportAsync();
        }

        // This parameter set invokes a single graphql operation:
        // startClusterReportMigrationJob.
        internal void ProcessRecord_StartClusterMigrationJob()
        {
            this._logger.name += " -StartClusterMigrationJob";
            // Create new graphql operation startClusterReportMigrationJob
            InitMutationStartClusterReportMigrationJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateDatabaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_UpdateDatabaseLogingPropertiesForCluster()
        {
            this._logger.name += " -UpdateDatabaseLogingPropertiesForCluster";
            // Create new graphql operation updateDatabaseLogReportingPropertiesForCluster
            InitMutationUpdateDatabaseLogReportingPropertiesForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateScheduledReport.
        internal void ProcessRecord_UpdateScheduledReport()
        {
            this._logger.name += " -UpdateScheduledReport";
            // Create new graphql operation updateScheduledReport
            InitMutationUpdateScheduledReport();
        }


        // Create new GraphQL Mutation:
        // createScheduledReport(input: CreateScheduledReportInput!): CreateScheduledReportReply!
        internal void InitMutationCreateScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateScheduledReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateScheduledReport",
                "($input: CreateScheduledReportInput!)",
                "CreateScheduledReportReply",
                Mutation.CreateScheduledReport,
                Mutation.CreateScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	reportId = $someInt
	# REQUIRED
	title = $someString
	# OPTIONAL
	dailyTime = $someDateTime
	# OPTIONAL
	weeklyTime = $someDateTime
	# OPTIONAL
	monthlyDate = $someInt
	# OPTIONAL
	monthlyTime = $someDateTime
	# REQUIRED
	rubrikRecipientUserIds = @(
		$someString
	)
	# REQUIRED
	nonRubrikRecipientEmails = @(
		$someString
	)
	# OPTIONAL
	updateCreator = $someBoolean
	# OPTIONAL
	timeZone = $someString
	# OPTIONAL
	showChartsInEmailBody = $someBoolean
	# OPTIONAL
	weeklyDays = @(
		$someWeekDay # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WeekDay]) for enum values.
	)
	# OPTIONAL
	attachmentTypes = @(
		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCustomReport(input: DeleteCustomReportInput!): Void
        internal void InitMutationDeleteCustomReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCustomReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCustomReport",
                "($input: DeleteCustomReportInput!)",
                "System.String",
                Mutation.DeleteCustomReport,
                Mutation.DeleteCustomReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteScheduledReport(input: DeleteScheduledReportInput!): Void
        internal void InitMutationDeleteScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteScheduledReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteScheduledReport",
                "($input: DeleteScheduledReportInput!)",
                "System.String",
                Mutation.DeleteScheduledReport,
                Mutation.DeleteScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
	# OPTIONAL
	reportId = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // sendPdfReport(input: SendPdfReportInput!): SendPdfReportReply!
        internal void InitMutationSendPdfReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SendPdfReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendPdfReport",
                "($input: SendPdfReportInput!)",
                "SendPdfReportReply",
                Mutation.SendPdfReport,
                Mutation.SendPdfReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	rubrikRecipientUserIds = @(
		$someString
	)
	# REQUIRED
	nonRubrikRecipientEmailIds = @(
		$someString
	)
	# REQUIRED
	password = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // sendScheduledReportAsync(input: SendScheduledReportAsyncInput!): AsyncDownloadReply!
        internal void InitMutationSendScheduledReportAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SendScheduledReportAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendScheduledReportAsync",
                "($input: SendScheduledReportAsyncInput!)",
                "AsyncDownloadReply",
                Mutation.SendScheduledReportAsync,
                Mutation.SendScheduledReportAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	rubrikUserIds = @(
		$someString
	)
	# REQUIRED
	reportId = $someInt
	# OPTIONAL
	nonRubrikUserEmails = @(
		$someString
	)
	# OPTIONAL
	attachmentTypes = @(
		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
	)
	# OPTIONAL
	showChartsInEmailBody = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // startClusterReportMigrationJob(input: StartClusterReportMigrationJobInput!): StartClusterReportMigrationJobReply!
        internal void InitMutationStartClusterReportMigrationJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartClusterReportMigrationJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartClusterReportMigrationJob",
                "($input: StartClusterReportMigrationJobInput!)",
                "StartClusterReportMigrationJobReply",
                Mutation.StartClusterReportMigrationJob,
                Mutation.StartClusterReportMigrationJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterUuid = $someString
	# OPTIONAL
	shouldDeleteCdmSchedules = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateDatabaseLogReportingPropertiesForCluster(input: UpdateDatabaseLogReportingPropertiesForClusterInput!): DbLogReportProperties!
        internal void InitMutationUpdateDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDatabaseLogReportingPropertiesForClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateDatabaseLogReportingPropertiesForCluster",
                "($input: UpdateDatabaseLogReportingPropertiesForClusterInput!)",
                "DbLogReportProperties",
                Mutation.UpdateDatabaseLogReportingPropertiesForCluster,
                Mutation.UpdateDatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	properties = @{
		# OPTIONAL
		enableDelayNotification = $someBoolean
		# OPTIONAL
		logDelayThresholdInMin = $someInt64
		# OPTIONAL
		logDelayNotificationFrequencyInMin = $someInt64
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateScheduledReport(input: UpdateScheduledReportInput!): UpdateScheduledReportReply!
        internal void InitMutationUpdateScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateScheduledReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateScheduledReport",
                "($input: UpdateScheduledReportInput!)",
                "UpdateScheduledReportReply",
                Mutation.UpdateScheduledReport,
                Mutation.UpdateScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
	# REQUIRED
	config = @{
		# REQUIRED
		reportId = $someInt
		# REQUIRED
		title = $someString
		# OPTIONAL
		dailyTime = $someDateTime
		# OPTIONAL
		weeklyTime = $someDateTime
		# OPTIONAL
		monthlyDate = $someInt
		# OPTIONAL
		monthlyTime = $someDateTime
		# REQUIRED
		rubrikRecipientUserIds = @(
			$someString
		)
		# REQUIRED
		nonRubrikRecipientEmails = @(
			$someString
		)
		# OPTIONAL
		timeZone = $someString
		# OPTIONAL
		showChartsInEmailBody = $someBoolean
		# OPTIONAL
		updateCreator = $someBoolean
		# OPTIONAL
		weeklyDays = @(
			$someWeekDay # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WeekDay]) for enum values.
		)
		# OPTIONAL
		attachmentTypes = @(
			$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
		)
	}
}"
            );
        }


    } // class New_RscMutationReport
}
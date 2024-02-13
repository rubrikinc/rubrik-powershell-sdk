// New-RscMutationRansomware.cs
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
    /// Create a new RscQuery object for any of the 2
    /// operations in the 'Ransomware' API domain:
    /// BulkUpdateInvestigationStatus, or TriggerDetection.
    /// </summary>
    /// <description>
    /// New-RscMutationRansomware creates a new
    /// mutation object for operations
    /// in the 'Ransomware' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 2 operations
    /// in the 'Ransomware' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BulkUpdateInvestigationStatus, or TriggerDetection.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationRansomware -BulkUpdateInvestigationStatus).Info().
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
    /// (New-RscMutationRansomware -BulkUpdateInvestigationStatus).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkUpdateInvestigationStatus operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: BulkUpdateInvestigationStatus
    /// 
    /// $query = New-RscMutationRansomware -BulkUpdateInvestigationStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	entities = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			entityType = $someDataThreatAnalyticsEnablementEntity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataThreatAnalyticsEnablementEntity]) for enum values.
    /// 			# REQUIRED
    /// 			entityId = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	isRansomwareMonitoringEnabled = $someBoolean
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
    /// Runs the TriggerDetection operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: TriggerDetection
    /// 
    /// $query = New-RscMutationRansomware -TriggerDetection
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	managedId = $someString
    /// 	# OPTIONAL
    /// 	previousSnapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TriggerRansomwareDetectionReply
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
        "RscMutationRansomware",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationRansomware : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BulkUpdateInvestigationStatus",
                "TriggerDetection",
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
                    case "BulkUpdateInvestigationStatus":
                        this.ProcessRecord_BulkUpdateInvestigationStatus();
                        break;
                    case "TriggerDetection":
                        this.ProcessRecord_TriggerDetection();
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
        // bulkUpdateRansomwareInvestigationStatus.
        internal void ProcessRecord_BulkUpdateInvestigationStatus()
        {
            this._logger.name += " -BulkUpdateInvestigationStatus";
            // Create new graphql operation bulkUpdateRansomwareInvestigationStatus
            InitMutationBulkUpdateRansomwareInvestigationStatus();
        }

        // This parameter set invokes a single graphql operation:
        // triggerRansomwareDetection.
        internal void ProcessRecord_TriggerDetection()
        {
            this._logger.name += " -TriggerDetection";
            // Create new graphql operation triggerRansomwareDetection
            InitMutationTriggerRansomwareDetection();
        }


        // Create new GraphQL Mutation:
        // bulkUpdateRansomwareInvestigationStatus(input: BulkUpdateRansomwareInvestigationEnabledInput!): Void
        internal void InitMutationBulkUpdateRansomwareInvestigationStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateRansomwareInvestigationEnabledInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateRansomwareInvestigationStatus",
                "($input: BulkUpdateRansomwareInvestigationEnabledInput!)",
                "System.String",
                Mutation.BulkUpdateRansomwareInvestigationStatus_ObjectFieldSpec,
                Mutation.BulkUpdateRansomwareInvestigationStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	entities = @(
		@{
			# REQUIRED
			entityType = $someDataThreatAnalyticsEnablementEntity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataThreatAnalyticsEnablementEntity]) for enum values.
			# REQUIRED
			entityId = $someString
		}
	)
	# REQUIRED
	isRansomwareMonitoringEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // triggerRansomwareDetection(input: TriggerRansomwareDetectionInput!): TriggerRansomwareDetectionReply!
        internal void InitMutationTriggerRansomwareDetection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TriggerRansomwareDetectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTriggerRansomwareDetection",
                "($input: TriggerRansomwareDetectionInput!)",
                "TriggerRansomwareDetectionReply",
                Mutation.TriggerRansomwareDetection_ObjectFieldSpec,
                Mutation.TriggerRansomwareDetectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterUuid = $someString
	# OPTIONAL
	snapshotId = $someString
	# OPTIONAL
	managedId = $someString
	# OPTIONAL
	previousSnapshotId = $someString
}"
            );
        }


    } // class New_RscMutationRansomware
}
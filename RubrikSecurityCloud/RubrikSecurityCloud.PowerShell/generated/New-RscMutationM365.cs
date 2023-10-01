// New-RscMutationM365.cs
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
    /// Create a new RscQuery object for any of the 4
    /// operations in the 'Microsoft 365' API domain:
    /// BackupMailbox, BackupOnedrive, BackupSharepointDrive, or BackupTeam.
    /// </summary>
    /// <description>
    /// New-RscMutationM365 creates a new
    /// mutation object for operations
    /// in the 'Microsoft 365' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Microsoft 365' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BackupMailbox, BackupOnedrive, BackupSharepointDrive, or BackupTeam.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationM365 -BackupMailbox).Info().
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
    /// (New-RscMutationM365 -BackupMailbox).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BackupMailbox operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: BackupMailbox
    /// 
    /// $query = New-RscMutationM365 -BackupMailbox
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupOnedrive operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: BackupOnedrive
    /// 
    /// $query = New-RscMutationM365 -BackupOnedrive
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupSharepointDrive operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: BackupSharepointDrive
    /// 
    /// $query = New-RscMutationM365 -BackupSharepointDrive
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupTeam operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: BackupTeam
    /// 
    /// $query = New-RscMutationM365 -BackupTeam
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
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
        "RscMutationM365",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationM365 : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BackupMailbox",
                "BackupOnedrive",
                "BackupSharepointDrive",
                "BackupTeam",
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
                    case "BackupMailbox":
                        this.ProcessRecord_BackupMailbox();
                        break;
                    case "BackupOnedrive":
                        this.ProcessRecord_BackupOnedrive();
                        break;
                    case "BackupSharepointDrive":
                        this.ProcessRecord_BackupSharepointDrive();
                        break;
                    case "BackupTeam":
                        this.ProcessRecord_BackupTeam();
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
        // backupM365Mailbox.
        internal void ProcessRecord_BackupMailbox()
        {
            this._logger.name += " -BackupMailbox";
            // Create new graphql operation backupM365Mailbox
            InitMutationBackupM365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // backupM365Onedrive.
        internal void ProcessRecord_BackupOnedrive()
        {
            this._logger.name += " -BackupOnedrive";
            // Create new graphql operation backupM365Onedrive
            InitMutationBackupM365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupM365SharepointDrive.
        internal void ProcessRecord_BackupSharepointDrive()
        {
            this._logger.name += " -BackupSharepointDrive";
            // Create new graphql operation backupM365SharepointDrive
            InitMutationBackupM365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupM365Team.
        internal void ProcessRecord_BackupTeam()
        {
            this._logger.name += " -BackupTeam";
            // Create new graphql operation backupM365Team
            InitMutationBackupM365Team();
        }


        // Create new GraphQL Mutation:
        // backupM365Mailbox(input: BackupM365MailboxInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationBackupM365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupM365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupM365Mailbox",
                "($input: BackupM365MailboxInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.BackupM365Mailbox_ObjectFieldSpec,
                Mutation.BackupM365MailboxFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupM365Onedrive(input: BackupM365OnedriveInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationBackupM365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupM365OnedriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupM365Onedrive",
                "($input: BackupM365OnedriveInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.BackupM365Onedrive_ObjectFieldSpec,
                Mutation.BackupM365OnedriveFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupM365SharepointDrive(input: BackupM365SharepointDriveInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationBackupM365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupM365SharepointDriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupM365SharepointDrive",
                "($input: BackupM365SharepointDriveInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.BackupM365SharepointDrive_ObjectFieldSpec,
                Mutation.BackupM365SharepointDriveFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupM365Team(input: BackupM365TeamInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationBackupM365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupM365TeamInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupM365Team",
                "($input: BackupM365TeamInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.BackupM365Team_ObjectFieldSpec,
                Mutation.BackupM365TeamFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadUuids = @(
		$someString
	)
}"
            );
        }


    } // class New_RscMutationM365
}
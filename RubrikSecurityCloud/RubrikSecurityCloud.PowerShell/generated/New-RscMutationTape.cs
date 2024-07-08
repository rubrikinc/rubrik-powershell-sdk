// New-RscMutationTape.cs
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
    /// Create a new RscQuery object for any of the 3
    /// operations in the 'Tape' API domain:
    /// CreateReaderTarget, CreateTarget, or UpdateTarget.
    /// </summary>
    /// <description>
    /// New-RscMutationTape creates a new
    /// mutation object for operations
    /// in the 'Tape' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 3 operations
    /// in the 'Tape' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateReaderTarget, CreateTarget, or UpdateTarget.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationTape -CreateReaderTarget).Info().
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
    /// (New-RscMutationTape -CreateReaderTarget).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateReaderTarget operation
    /// of the 'Tape' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Tape
    /// # API Operation: CreateReaderTarget
    /// 
    /// $query = New-RscMutationTape -CreateReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	hostName = $someString
    /// 	# REQUIRED
    /// 	hostPort = $someInt
    /// 	# REQUIRED
    /// 	integralVolumeName = $someString
    /// 	# REQUIRED
    /// 	destinationFolderName = $someString
    /// 	# REQUIRED
    /// 	username = $someString
    /// 	# REQUIRED
    /// 	password = $someString
    /// 	# REQUIRED
    /// 	encryptionPassword = $someString
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateTarget operation
    /// of the 'Tape' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Tape
    /// # API Operation: CreateTarget
    /// 
    /// $query = New-RscMutationTape -CreateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	hostName = $someString
    /// 	# REQUIRED
    /// 	hostPort = $someInt
    /// 	# REQUIRED
    /// 	integralVolumeName = $someString
    /// 	# REQUIRED
    /// 	destinationFolderName = $someString
    /// 	# REQUIRED
    /// 	username = $someString
    /// 	# REQUIRED
    /// 	password = $someString
    /// 	# REQUIRED
    /// 	encryptionPassword = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateTarget operation
    /// of the 'Tape' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Tape
    /// # API Operation: UpdateTarget
    /// 
    /// $query = New-RscMutationTape -UpdateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	hostName = $someString
    /// 	# OPTIONAL
    /// 	hostPort = $someInt
    /// 	# OPTIONAL
    /// 	username = $someString
    /// 	# OPTIONAL
    /// 	password = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
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
        "RscMutationTape",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationTape : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreateReaderTarget",
                "CreateTarget",
                "UpdateTarget",
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
                    case "CreateReaderTarget":
                        this.ProcessRecord_CreateReaderTarget();
                        break;
                    case "CreateTarget":
                        this.ProcessRecord_CreateTarget();
                        break;
                    case "UpdateTarget":
                        this.ProcessRecord_UpdateTarget();
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
        // createTapeReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Create new graphql operation createTapeReaderTarget
            InitMutationCreateTapeReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createTapeTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Create new graphql operation createTapeTarget
            InitMutationCreateTapeTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateTapeTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateTapeTarget
            InitMutationUpdateTapeTarget();
        }


        // Create new GraphQL Mutation:
        // createTapeReaderTarget(input: CreateTapeReaderTargetInput!): Target!
        internal void InitMutationCreateTapeReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateTapeReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateTapeReaderTarget",
                "($input: CreateTapeReaderTargetInput!)",
                "Target",
                Mutation.CreateTapeReaderTarget,
                Mutation.CreateTapeReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	hostName = $someString
	# REQUIRED
	hostPort = $someInt
	# REQUIRED
	integralVolumeName = $someString
	# REQUIRED
	destinationFolderName = $someString
	# REQUIRED
	username = $someString
	# REQUIRED
	password = $someString
	# REQUIRED
	encryptionPassword = $someString
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createTapeTarget(input: CreateTapeTargetInput!): Target!
        internal void InitMutationCreateTapeTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateTapeTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateTapeTarget",
                "($input: CreateTapeTargetInput!)",
                "Target",
                Mutation.CreateTapeTarget,
                Mutation.CreateTapeTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	hostName = $someString
	# REQUIRED
	hostPort = $someInt
	# REQUIRED
	integralVolumeName = $someString
	# REQUIRED
	destinationFolderName = $someString
	# REQUIRED
	username = $someString
	# REQUIRED
	password = $someString
	# REQUIRED
	encryptionPassword = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateTapeTarget(input: UpdateTapeTargetInput!): Target!
        internal void InitMutationUpdateTapeTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateTapeTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateTapeTarget",
                "($input: UpdateTapeTargetInput!)",
                "Target",
                Mutation.UpdateTapeTarget,
                Mutation.UpdateTapeTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	hostName = $someString
	# OPTIONAL
	hostPort = $someInt
	# OPTIONAL
	username = $someString
	# OPTIONAL
	password = $someString
}"
            );
        }


    } // class New_RscMutationTape
}
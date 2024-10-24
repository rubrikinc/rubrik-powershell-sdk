// New-RscMutationNfs.cs
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
    /// operations in the 'NFS' API domain:
    /// CreateReaderTarget, CreateTarget, or UpdateTarget.
    /// </summary>
    /// <description>
    /// New-RscMutationNfs creates a new
    /// mutation object for operations
    /// in the 'NFS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 3 operations
    /// in the 'NFS' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateReaderTarget, CreateTarget, or UpdateTarget.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationNfs -CreateReaderTarget).Info().
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
    /// (New-RscMutationNfs -CreateReaderTarget).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateReaderTarget operation
    /// of the 'NFS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nfs
    /// # API Operation: CreateReaderTarget
    /// 
    /// $query = New-RscMutationNfs -Operation CreateReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	host = $someString
    /// 	# REQUIRED
    /// 	exportDir = $someString
    /// 	# OPTIONAL
    /// 	nfsVersion = $someInt
    /// 	# REQUIRED
    /// 	nfsAuthType = $someAuthTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthTypeEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	otherNfsOptions = $someString
    /// 	# REQUIRED
    /// 	fileLockPeriodInSeconds = $someInt
    /// 	# REQUIRED
    /// 	destinationFolder = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
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
    /// of the 'NFS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nfs
    /// # API Operation: CreateTarget
    /// 
    /// $query = New-RscMutationNfs -Operation CreateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	host = $someString
    /// 	# REQUIRED
    /// 	exportDir = $someString
    /// 	# OPTIONAL
    /// 	nfsVersion = $someInt
    /// 	# REQUIRED
    /// 	nfsAuthType = $someAuthTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthTypeEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	otherNfsOptions = $someString
    /// 	# REQUIRED
    /// 	fileLockPeriodInSeconds = $someInt
    /// 	# REQUIRED
    /// 	destinationFolder = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
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
    /// of the 'NFS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nfs
    /// # API Operation: UpdateTarget
    /// 
    /// $query = New-RscMutationNfs -Operation UpdateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	host = $someString
    /// 	# OPTIONAL
    /// 	exportDir = $someString
    /// 	# OPTIONAL
    /// 	nfsAuthType = $someAuthTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthTypeEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	fileLockPeriodInSeconds = $someInt
    /// 	# OPTIONAL
    /// 	isConsolidationEnabled = $someBoolean
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
        "RscMutationNfs",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationNfs : RscGqlPSCmdlet
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
        // createNfsReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Create new graphql operation createNfsReaderTarget
            InitMutationCreateNfsReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createNfsTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Create new graphql operation createNfsTarget
            InitMutationCreateNfsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateNfsTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateNfsTarget
            InitMutationUpdateNfsTarget();
        }


        // Create new GraphQL Mutation:
        // createNfsReaderTarget(input: CreateNfsReaderTargetInput!): Target!
        internal void InitMutationCreateNfsReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNfsReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateNfsReaderTarget",
                "($input: CreateNfsReaderTargetInput!)",
                "Target",
                Mutation.CreateNfsReaderTarget,
                Mutation.CreateNfsReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	host = $someString
	# REQUIRED
	exportDir = $someString
	# OPTIONAL
	nfsVersion = $someInt
	# REQUIRED
	nfsAuthType = $someAuthTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthTypeEnum]) for enum values.
	# OPTIONAL
	otherNfsOptions = $someString
	# REQUIRED
	fileLockPeriodInSeconds = $someInt
	# REQUIRED
	destinationFolder = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	encryptionPassword = $someString
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createNfsTarget(input: CreateNfsTargetInput!): Target!
        internal void InitMutationCreateNfsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNfsTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateNfsTarget",
                "($input: CreateNfsTargetInput!)",
                "Target",
                Mutation.CreateNfsTarget,
                Mutation.CreateNfsTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	host = $someString
	# REQUIRED
	exportDir = $someString
	# OPTIONAL
	nfsVersion = $someInt
	# REQUIRED
	nfsAuthType = $someAuthTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthTypeEnum]) for enum values.
	# OPTIONAL
	otherNfsOptions = $someString
	# REQUIRED
	fileLockPeriodInSeconds = $someInt
	# REQUIRED
	destinationFolder = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	encryptionPassword = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNfsTarget(input: UpdateNfsTargetInput!): Target!
        internal void InitMutationUpdateNfsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNfsTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNfsTarget",
                "($input: UpdateNfsTargetInput!)",
                "Target",
                Mutation.UpdateNfsTarget,
                Mutation.UpdateNfsTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	host = $someString
	# OPTIONAL
	exportDir = $someString
	# OPTIONAL
	nfsAuthType = $someAuthTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthTypeEnum]) for enum values.
	# OPTIONAL
	fileLockPeriodInSeconds = $someInt
	# OPTIONAL
	isConsolidationEnabled = $someBoolean
}"
            );
        }


    } // class New_RscMutationNfs
}
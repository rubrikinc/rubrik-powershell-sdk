// New-RscMutationServiceAccount.cs
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
    /// operations in the 'Service Account' API domain:
    /// Create, Delete, Rotate, or Update.
    /// </summary>
    /// <description>
    /// New-RscMutationServiceAccount creates a new
    /// mutation object for operations
    /// in the 'Service Account' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Service Account' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Create, Delete, Rotate, or Update.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationServiceAccount -Create).Info().
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
    /// (New-RscMutationServiceAccount -Create).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Create operation
    /// of the 'Service Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ServiceAccount
    /// # API Operation: Create
    /// 
    /// $query = New-RscMutationServiceAccount -Operation Create
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	roleIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateServiceAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Delete operation
    /// of the 'Service Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ServiceAccount
    /// # API Operation: Delete
    /// 
    /// $query = New-RscMutationServiceAccount -Operation Delete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Rotate operation
    /// of the 'Service Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ServiceAccount
    /// # API Operation: Rotate
    /// 
    /// $query = New-RscMutationServiceAccount -Operation Rotate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RotateServiceAccountSecretReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Update operation
    /// of the 'Service Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ServiceAccount
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationServiceAccount -Operation Update
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateServiceAccountReply
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
        "RscMutationServiceAccount",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationServiceAccount : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Create",
                "Delete",
                "Rotate",
                "Update",
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
                    case "Create":
                        this.ProcessRecord_Create();
                        break;
                    case "Delete":
                        this.ProcessRecord_Delete();
                        break;
                    case "Rotate":
                        this.ProcessRecord_Rotate();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
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
        // createServiceAccount.
        internal void ProcessRecord_Create()
        {
            this._logger.name += " -Create";
            // Create new graphql operation createServiceAccount
            InitMutationCreateServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteServiceAccountsFromAccount.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Create new graphql operation deleteServiceAccountsFromAccount
            InitMutationDeleteServiceAccountsFromAccount();
        }

        // This parameter set invokes a single graphql operation:
        // rotateServiceAccountSecret.
        internal void ProcessRecord_Rotate()
        {
            this._logger.name += " -Rotate";
            // Create new graphql operation rotateServiceAccountSecret
            InitMutationRotateServiceAccountSecret();
        }

        // This parameter set invokes a single graphql operation:
        // updateServiceAccount.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateServiceAccount
            InitMutationUpdateServiceAccount();
        }


        // Create new GraphQL Mutation:
        // createServiceAccount(input: CreateServiceAccountInput!): CreateServiceAccountReply!
        internal void InitMutationCreateServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateServiceAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateServiceAccount",
                "($input: CreateServiceAccountInput!)",
                "CreateServiceAccountReply",
                Mutation.CreateServiceAccount,
                Mutation.CreateServiceAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# OPTIONAL
	description = $someString
	# REQUIRED
	roleIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteServiceAccountsFromAccount(input: DeleteServiceAccountsFromAccountInput!): Boolean!
        internal void InitMutationDeleteServiceAccountsFromAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteServiceAccountsFromAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteServiceAccountsFromAccount",
                "($input: DeleteServiceAccountsFromAccountInput!)",
                "System.Boolean",
                Mutation.DeleteServiceAccountsFromAccount,
                Mutation.DeleteServiceAccountsFromAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // rotateServiceAccountSecret(input: RotateServiceAccountSecretInput!): RotateServiceAccountSecretReply!
        internal void InitMutationRotateServiceAccountSecret()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RotateServiceAccountSecretInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRotateServiceAccountSecret",
                "($input: RotateServiceAccountSecretInput!)",
                "RotateServiceAccountSecretReply",
                Mutation.RotateServiceAccountSecret,
                Mutation.RotateServiceAccountSecretFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateServiceAccount(input: UpdateServiceAccountInput!): UpdateServiceAccountReply!
        internal void InitMutationUpdateServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateServiceAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateServiceAccount",
                "($input: UpdateServiceAccountInput!)",
                "UpdateServiceAccountReply",
                Mutation.UpdateServiceAccount,
                Mutation.UpdateServiceAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	description = $someString
}"
            );
        }


    } // class New_RscMutationServiceAccount
}
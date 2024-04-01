// New-RscMutationCrossAccount.cs
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
    /// operations in the 'Cross Account' API domain:
    /// AddCrossAccountServiceConsumer, CreateCrossAccountPair, CreateCrossAccountRegOauthPayload, or DeleteCrossAccountPair.
    /// </summary>
    /// <description>
    /// New-RscMutationCrossAccount creates a new
    /// mutation object for operations
    /// in the 'Cross Account' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Cross Account' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddCrossAccountServiceConsumer, CreateCrossAccountPair, CreateCrossAccountRegOauthPayload, or DeleteCrossAccountPair.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationCrossAccount -AddCrossAccountServiceConsumer).Info().
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
    /// (New-RscMutationCrossAccount -AddCrossAccountServiceConsumer).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddCrossAccountServiceConsumer operation
    /// of the 'Cross Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CrossAccount
    /// # API Operation: AddCrossAccountServiceConsumer
    /// 
    /// $query = New-RscMutationCrossAccount -AddCrossAccountServiceConsumer
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	crossAccountId = $someString
    /// 	# REQUIRED
    /// 	fqdn = $someString
    /// 	# REQUIRED
    /// 	serviceConsumerSa = @{
    /// 		# OPTIONAL
    /// 		clientId = $someString
    /// 		# OPTIONAL
    /// 		clientSecret = $someString
    /// 		# OPTIONAL
    /// 		accessTokenUrl = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	isRefresh = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddCrossAccountServiceConsumerReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCrossAccountPair operation
    /// of the 'Cross Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CrossAccount
    /// # API Operation: CreateCrossAccountPair
    /// 
    /// $query = New-RscMutationCrossAccount -CreateCrossAccountPair
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	code = $someString
    /// 	# REQUIRED
    /// 	state = $someString
    /// 	# REQUIRED
    /// 	fqdn = $someString
    /// 	# OPTIONAL
    /// 	isRefresh = $someBoolean
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
    /// Runs the CreateCrossAccountRegOauthPayload operation
    /// of the 'Cross Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CrossAccount
    /// # API Operation: CreateCrossAccountRegOauthPayload
    /// 
    /// $query = New-RscMutationCrossAccount -CreateCrossAccountRegOauthPayload
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	fqdn = $someString
    /// 	# OPTIONAL
    /// 	isRefresh = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCrossAccountRegOauthPayloadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCrossAccountPair operation
    /// of the 'Cross Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CrossAccount
    /// # API Operation: DeleteCrossAccountPair
    /// 
    /// $query = New-RscMutationCrossAccount -DeleteCrossAccountPair
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	crossAccountId = $someString
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationCrossAccount",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationCrossAccount : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddCrossAccountServiceConsumer",
                "CreateCrossAccountPair",
                "CreateCrossAccountRegOauthPayload",
                "DeleteCrossAccountPair",
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
                    case "AddCrossAccountServiceConsumer":
                        this.ProcessRecord_AddCrossAccountServiceConsumer();
                        break;
                    case "CreateCrossAccountPair":
                        this.ProcessRecord_CreateCrossAccountPair();
                        break;
                    case "CreateCrossAccountRegOauthPayload":
                        this.ProcessRecord_CreateCrossAccountRegOauthPayload();
                        break;
                    case "DeleteCrossAccountPair":
                        this.ProcessRecord_DeleteCrossAccountPair();
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
        // addCrossAccountServiceConsumer.
        internal void ProcessRecord_AddCrossAccountServiceConsumer()
        {
            this._logger.name += " -AddCrossAccountServiceConsumer";
            // Create new graphql operation addCrossAccountServiceConsumer
            InitMutationAddCrossAccountServiceConsumer();
        }

        // This parameter set invokes a single graphql operation:
        // createCrossAccountPair.
        internal void ProcessRecord_CreateCrossAccountPair()
        {
            this._logger.name += " -CreateCrossAccountPair";
            // Create new graphql operation createCrossAccountPair
            InitMutationCreateCrossAccountPair();
        }

        // This parameter set invokes a single graphql operation:
        // createCrossAccountRegOauthPayload.
        internal void ProcessRecord_CreateCrossAccountRegOauthPayload()
        {
            this._logger.name += " -CreateCrossAccountRegOauthPayload";
            // Create new graphql operation createCrossAccountRegOauthPayload
            InitMutationCreateCrossAccountRegOauthPayload();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCrossAccountPair.
        internal void ProcessRecord_DeleteCrossAccountPair()
        {
            this._logger.name += " -DeleteCrossAccountPair";
            // Create new graphql operation deleteCrossAccountPair
            InitMutationDeleteCrossAccountPair();
        }


        // Create new GraphQL Mutation:
        // addCrossAccountServiceConsumer(input: AddCrossAccountServiceConsumerInput!): AddCrossAccountServiceConsumerReply!
        internal void InitMutationAddCrossAccountServiceConsumer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddCrossAccountServiceConsumerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddCrossAccountServiceConsumer",
                "($input: AddCrossAccountServiceConsumerInput!)",
                "AddCrossAccountServiceConsumerReply",
                Mutation.AddCrossAccountServiceConsumer_ObjectFieldSpec,
                Mutation.AddCrossAccountServiceConsumerFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	crossAccountId = $someString
	# REQUIRED
	fqdn = $someString
	# REQUIRED
	serviceConsumerSa = @{
		# OPTIONAL
		clientId = $someString
		# OPTIONAL
		clientSecret = $someString
		# OPTIONAL
		accessTokenUrl = $someString
	}
	# OPTIONAL
	isRefresh = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCrossAccountPair(input: CreateCrossAccountPairInput!): Void
        internal void InitMutationCreateCrossAccountPair()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCrossAccountPairInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCrossAccountPair",
                "($input: CreateCrossAccountPairInput!)",
                "System.String",
                Mutation.CreateCrossAccountPair_ObjectFieldSpec,
                Mutation.CreateCrossAccountPairFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	code = $someString
	# REQUIRED
	state = $someString
	# REQUIRED
	fqdn = $someString
	# OPTIONAL
	isRefresh = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCrossAccountRegOauthPayload(input: CreateCrossAccountRegOauthPayloadInput!): CreateCrossAccountRegOauthPayloadReply!
        internal void InitMutationCreateCrossAccountRegOauthPayload()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCrossAccountRegOauthPayloadInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCrossAccountRegOauthPayload",
                "($input: CreateCrossAccountRegOauthPayloadInput!)",
                "CreateCrossAccountRegOauthPayloadReply",
                Mutation.CreateCrossAccountRegOauthPayload_ObjectFieldSpec,
                Mutation.CreateCrossAccountRegOauthPayloadFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	fqdn = $someString
	# OPTIONAL
	isRefresh = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCrossAccountPair(input: DeleteCrossAccountPairInput!): Void
        internal void InitMutationDeleteCrossAccountPair()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCrossAccountPairInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCrossAccountPair",
                "($input: DeleteCrossAccountPairInput!)",
                "System.String",
                Mutation.DeleteCrossAccountPair_ObjectFieldSpec,
                Mutation.DeleteCrossAccountPairFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	crossAccountId = $someString
}"
            );
        }


    } // class New_RscMutationCrossAccount
}
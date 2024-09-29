// New-RscMutationWebhook.cs
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
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'Webhook' API domain:
    /// Create, Delete, DeleteV2, Test, TestExisting, or Update.
    /// </summary>
    /// <description>
    /// New-RscMutationWebhook creates a new
    /// mutation object for operations
    /// in the 'Webhook' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Webhook' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Create, Delete, DeleteV2, Test, TestExisting, or Update.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationWebhook -Create).Info().
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
    /// (New-RscMutationWebhook -Create).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Create operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: Create
    /// 
    /// $query = New-RscMutationWebhook -Create
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	serverCertificate = $someString
    /// 	# OPTIONAL
    /// 	serviceAccountId = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	url = $someString
    /// 	# REQUIRED
    /// 	subscriptionType = @{
    /// 		# OPTIONAL
    /// 		eventTypes = @(
    /// 			$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		auditTypes = @(
    /// 			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypes = @(
    /// 			$someEventObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isSubscribedToAllEvents = $someBoolean
    /// 		# OPTIONAL
    /// 		isSubscribedToAllAudits = $someBoolean
    /// 		# OPTIONAL
    /// 		isSubscribedToAllObjectTypes = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	subscriptionSeverity = @{
    /// 		# OPTIONAL
    /// 		eventSeverities = @(
    /// 			$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		auditSeverities = @(
    /// 			$someUserAuditSeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditSeverityEnum]) for enum values.
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	providerType = $someProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProviderType]) for enum values.
    /// 	# OPTIONAL
    /// 	authInfo = @{
    /// 		# REQUIRED
    /// 		authType = $someAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthenticationType]) for enum values.
    /// 		# OPTIONAL
    /// 		token = $someString
    /// 		# OPTIONAL
    /// 		userCredentials = @{
    /// 			# REQUIRED
    /// 			username = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		customHeader = @{
    /// 			# REQUIRED
    /// 			headerKey = $someString
    /// 			# REQUIRED
    /// 			headerValue = $someString
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateWebhookReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Delete operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: Delete
    /// 
    /// $query = New-RscMutationWebhook -Delete
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
    /// Runs the DeleteV2 operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: DeleteV2
    /// 
    /// $query = New-RscMutationWebhook -DeleteV2
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
    /// Runs the Test operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: Test
    /// 
    /// $query = New-RscMutationWebhook -Test
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	serverCertificate = $someString
    /// 	# REQUIRED
    /// 	providerType = $someProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProviderType]) for enum values.
    /// 	# OPTIONAL
    /// 	authInfo = @{
    /// 		# REQUIRED
    /// 		authType = $someAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthenticationType]) for enum values.
    /// 		# OPTIONAL
    /// 		token = $someString
    /// 		# OPTIONAL
    /// 		userCredentials = @{
    /// 			# REQUIRED
    /// 			username = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		customHeader = @{
    /// 			# REQUIRED
    /// 			headerKey = $someString
    /// 			# REQUIRED
    /// 			headerValue = $someString
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	url = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TestWebhookReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TestExisting operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: TestExisting
    /// 
    /// $query = New-RscMutationWebhook -TestExisting
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
    /// Write-Host $result.GetType().Name # prints: TestExistingWebhookReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Update operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationWebhook -Update
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	serverCertificate = $someString
    /// 	# OPTIONAL
    /// 	serviceAccountId = $someString
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# OPTIONAL
    /// 	subscriptionType = @{
    /// 		# OPTIONAL
    /// 		eventTypes = @(
    /// 			$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		auditTypes = @(
    /// 			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypes = @(
    /// 			$someEventObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isSubscribedToAllEvents = $someBoolean
    /// 		# OPTIONAL
    /// 		isSubscribedToAllAudits = $someBoolean
    /// 		# OPTIONAL
    /// 		isSubscribedToAllObjectTypes = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	subscriptionSeverity = @{
    /// 		# OPTIONAL
    /// 		eventSeverities = @(
    /// 			$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		auditSeverities = @(
    /// 			$someUserAuditSeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditSeverityEnum]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	providerType = $someProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProviderType]) for enum values.
    /// 	# OPTIONAL
    /// 	authInfo = @{
    /// 		# REQUIRED
    /// 		authType = $someAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthenticationType]) for enum values.
    /// 		# OPTIONAL
    /// 		token = $someString
    /// 		# OPTIONAL
    /// 		userCredentials = @{
    /// 			# REQUIRED
    /// 			username = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		customHeader = @{
    /// 			# REQUIRED
    /// 			headerKey = $someString
    /// 			# REQUIRED
    /// 			headerValue = $someString
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	status = $someWebhookStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WebhookStatus]) for enum values.
    /// 	# OPTIONAL
    /// 	url = $someString
    /// 	# OPTIONAL
    /// 	shouldSendTestEvent = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateWebhookReply
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
        "RscMutationWebhook",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationWebhook : RscGqlPSCmdlet
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
                "DeleteV2",
                "Test",
                "TestExisting",
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
                    case "DeleteV2":
                        this.ProcessRecord_DeleteV2();
                        break;
                    case "Test":
                        this.ProcessRecord_Test();
                        break;
                    case "TestExisting":
                        this.ProcessRecord_TestExisting();
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
        // createWebhook.
        internal void ProcessRecord_Create()
        {
            this._logger.name += " -Create";
            // Create new graphql operation createWebhook
            InitMutationCreateWebhook();
        }

        // This parameter set invokes a single graphql operation:
        // deleteWebhook.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Create new graphql operation deleteWebhook
            InitMutationDeleteWebhook();
        }

        // This parameter set invokes a single graphql operation:
        // deleteWebhookV2.
        internal void ProcessRecord_DeleteV2()
        {
            this._logger.name += " -DeleteV2";
            // Create new graphql operation deleteWebhookV2
            InitMutationDeleteWebhookV2();
        }

        // This parameter set invokes a single graphql operation:
        // testWebhook.
        internal void ProcessRecord_Test()
        {
            this._logger.name += " -Test";
            // Create new graphql operation testWebhook
            InitMutationTestWebhook();
        }

        // This parameter set invokes a single graphql operation:
        // testExistingWebhook.
        internal void ProcessRecord_TestExisting()
        {
            this._logger.name += " -TestExisting";
            // Create new graphql operation testExistingWebhook
            InitMutationTestExistingWebhook();
        }

        // This parameter set invokes a single graphql operation:
        // updateWebhook.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateWebhook
            InitMutationUpdateWebhook();
        }


        // Create new GraphQL Mutation:
        // createWebhook(input: CreateWebhookInput!): CreateWebhookReply!
        internal void InitMutationCreateWebhook()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateWebhookInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateWebhook",
                "($input: CreateWebhookInput!)",
                "CreateWebhookReply",
                Mutation.CreateWebhook,
                Mutation.CreateWebhookFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	description = $someString
	# OPTIONAL
	serverCertificate = $someString
	# OPTIONAL
	serviceAccountId = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	url = $someString
	# REQUIRED
	subscriptionType = @{
		# OPTIONAL
		eventTypes = @(
			$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
		)
		# OPTIONAL
		auditTypes = @(
			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
		)
		# OPTIONAL
		objectTypes = @(
			$someEventObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
		)
		# OPTIONAL
		isSubscribedToAllEvents = $someBoolean
		# OPTIONAL
		isSubscribedToAllAudits = $someBoolean
		# OPTIONAL
		isSubscribedToAllObjectTypes = $someBoolean
	}
	# REQUIRED
	subscriptionSeverity = @{
		# OPTIONAL
		eventSeverities = @(
			$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
		)
		# OPTIONAL
		auditSeverities = @(
			$someUserAuditSeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditSeverityEnum]) for enum values.
		)
	}
	# REQUIRED
	providerType = $someProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProviderType]) for enum values.
	# OPTIONAL
	authInfo = @{
		# REQUIRED
		authType = $someAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthenticationType]) for enum values.
		# OPTIONAL
		token = $someString
		# OPTIONAL
		userCredentials = @{
			# REQUIRED
			username = $someString
			# REQUIRED
			password = $someString
		}
		# OPTIONAL
		customHeader = @{
			# REQUIRED
			headerKey = $someString
			# REQUIRED
			headerValue = $someString
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteWebhook(input: DeleteWebhookInput!): Void
        internal void InitMutationDeleteWebhook()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteWebhookInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteWebhook",
                "($input: DeleteWebhookInput!)",
                "System.String",
                Mutation.DeleteWebhook,
                Mutation.DeleteWebhookFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteWebhookV2(input: DeleteWebhookV2Input!): Void
        internal void InitMutationDeleteWebhookV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteWebhookV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteWebhookV2",
                "($input: DeleteWebhookV2Input!)",
                "System.String",
                Mutation.DeleteWebhookV2,
                Mutation.DeleteWebhookV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // testWebhook(input: TestWebhookInput!): TestWebhookReply!
        internal void InitMutationTestWebhook()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TestWebhookInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTestWebhook",
                "($input: TestWebhookInput!)",
                "TestWebhookReply",
                Mutation.TestWebhook,
                Mutation.TestWebhookFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	serverCertificate = $someString
	# REQUIRED
	providerType = $someProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProviderType]) for enum values.
	# OPTIONAL
	authInfo = @{
		# REQUIRED
		authType = $someAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthenticationType]) for enum values.
		# OPTIONAL
		token = $someString
		# OPTIONAL
		userCredentials = @{
			# REQUIRED
			username = $someString
			# REQUIRED
			password = $someString
		}
		# OPTIONAL
		customHeader = @{
			# REQUIRED
			headerKey = $someString
			# REQUIRED
			headerValue = $someString
		}
	}
	# REQUIRED
	url = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // testExistingWebhook(input: TestExistingWebhookInput!): TestExistingWebhookReply!
        internal void InitMutationTestExistingWebhook()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TestExistingWebhookInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTestExistingWebhook",
                "($input: TestExistingWebhookInput!)",
                "TestExistingWebhookReply",
                Mutation.TestExistingWebhook,
                Mutation.TestExistingWebhookFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateWebhook(input: UpdateWebhookInput!): UpdateWebhookReply!
        internal void InitMutationUpdateWebhook()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateWebhookInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateWebhook",
                "($input: UpdateWebhookInput!)",
                "UpdateWebhookReply",
                Mutation.UpdateWebhook,
                Mutation.UpdateWebhookFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	serverCertificate = $someString
	# OPTIONAL
	serviceAccountId = $someString
	# REQUIRED
	id = $someInt
	# OPTIONAL
	subscriptionType = @{
		# OPTIONAL
		eventTypes = @(
			$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
		)
		# OPTIONAL
		auditTypes = @(
			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
		)
		# OPTIONAL
		objectTypes = @(
			$someEventObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
		)
		# OPTIONAL
		isSubscribedToAllEvents = $someBoolean
		# OPTIONAL
		isSubscribedToAllAudits = $someBoolean
		# OPTIONAL
		isSubscribedToAllObjectTypes = $someBoolean
	}
	# OPTIONAL
	subscriptionSeverity = @{
		# OPTIONAL
		eventSeverities = @(
			$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
		)
		# OPTIONAL
		auditSeverities = @(
			$someUserAuditSeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditSeverityEnum]) for enum values.
		)
	}
	# OPTIONAL
	providerType = $someProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProviderType]) for enum values.
	# OPTIONAL
	authInfo = @{
		# REQUIRED
		authType = $someAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuthenticationType]) for enum values.
		# OPTIONAL
		token = $someString
		# OPTIONAL
		userCredentials = @{
			# REQUIRED
			username = $someString
			# REQUIRED
			password = $someString
		}
		# OPTIONAL
		customHeader = @{
			# REQUIRED
			headerKey = $someString
			# REQUIRED
			headerValue = $someString
		}
	}
	# OPTIONAL
	status = $someWebhookStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WebhookStatus]) for enum values.
	# OPTIONAL
	url = $someString
	# OPTIONAL
	shouldSendTestEvent = $someBoolean
}"
            );
        }


    } // class New_RscMutationWebhook
}
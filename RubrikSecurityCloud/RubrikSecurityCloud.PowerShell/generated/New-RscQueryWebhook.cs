// New-RscQueryWebhook.cs
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
    /// Create a new RscQuery object for any of the 5
    /// operations in the 'Webhook' API domain:
    /// ById, MessageTemplateById, MessageTemplates, V2, or Webhook.
    /// </summary>
    /// <description>
    /// New-RscQueryWebhook creates a new
    /// query object for operations
    /// in the 'Webhook' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 5 operations
    /// in the 'Webhook' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ById, MessageTemplateById, MessageTemplates, V2, or Webhook.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryWebhook -ById).Info().
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
    /// (New-RscQueryWebhook -ById).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ById operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: ById
    /// 
    /// $query = New-RscQueryWebhook -Operation ById
    /// 
    /// # REQUIRED
    /// $query.Var.input = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: WebhookV2
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MessageTemplateById operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: MessageTemplateById
    /// 
    /// $query = New-RscQueryWebhook -Operation MessageTemplateById
    /// 
    /// # REQUIRED
    /// $query.Var.input = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: WebhookMessageTemplate
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MessageTemplates operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: MessageTemplates
    /// 
    /// $query = New-RscQueryWebhook -Operation MessageTemplates
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	recordType = $someTemplateRecordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TemplateRecordType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;WebhookMessageTemplate&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the V2 operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: V2
    /// 
    /// $query = New-RscQueryWebhook -Operation V2
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;WebhookV2&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Webhook operation
    /// of the 'Webhook' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Webhook
    /// # API Operation: Webhook
    /// 
    /// $query = New-RscQueryWebhook -Operation Webhook
    /// 
    /// # OPTIONAL
    /// $query.Var.name = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: WebhookConnection
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
        "RscQueryWebhook",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryWebhook : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ById",
                "MessageTemplateById",
                "MessageTemplates",
                "V2",
                "Webhook",
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
                    case "ById":
                        this.ProcessRecord_ById();
                        break;
                    case "MessageTemplateById":
                        this.ProcessRecord_MessageTemplateById();
                        break;
                    case "MessageTemplates":
                        this.ProcessRecord_MessageTemplates();
                        break;
                    case "V2":
                        this.ProcessRecord_V2();
                        break;
                    case "Webhook":
                        this.ProcessRecord_Webhook();
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
        // webhookById.
        internal void ProcessRecord_ById()
        {
            this._logger.name += " -ById";
            // Create new graphql operation webhookById
            InitQueryWebhookById();
        }

        // This parameter set invokes a single graphql operation:
        // webhookMessageTemplateById.
        internal void ProcessRecord_MessageTemplateById()
        {
            this._logger.name += " -MessageTemplateById";
            // Create new graphql operation webhookMessageTemplateById
            InitQueryWebhookMessageTemplateById();
        }

        // This parameter set invokes a single graphql operation:
        // allWebhookMessageTemplates.
        internal void ProcessRecord_MessageTemplates()
        {
            this._logger.name += " -MessageTemplates";
            // Create new graphql operation allWebhookMessageTemplates
            InitQueryAllWebhookMessageTemplates();
        }

        // This parameter set invokes a single graphql operation:
        // allWebhooksV2.
        internal void ProcessRecord_V2()
        {
            this._logger.name += " -V2";
            // Create new graphql operation allWebhooksV2
            InitQueryAllWebhooksV2();
        }

        // This parameter set invokes a single graphql operation:
        // allWebhooks.
        internal void ProcessRecord_Webhook()
        {
            this._logger.name += " -Webhook";
            // Create new graphql operation allWebhooks
            InitQueryAllWebhooks();
        }


        // Create new GraphQL Query:
        // webhookById(input: Int!): WebhookV2
        internal void InitQueryWebhookById()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryWebhookById",
                "($input: Int!)",
                "WebhookV2",
                Query.WebhookById,
                Query.WebhookByIdFieldSpec,
                @"# REQUIRED
$query.Var.input = $someInt"
            );
        }

        // Create new GraphQL Query:
        // webhookMessageTemplateById(input: Int!): WebhookMessageTemplate
        internal void InitQueryWebhookMessageTemplateById()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryWebhookMessageTemplateById",
                "($input: Int!)",
                "WebhookMessageTemplate",
                Query.WebhookMessageTemplateById,
                Query.WebhookMessageTemplateByIdFieldSpec,
                @"# REQUIRED
$query.Var.input = $someInt"
            );
        }

        // Create new GraphQL Query:
        // allWebhookMessageTemplates(input: WebhookMessageTemplatesReqInput!): [WebhookMessageTemplate!]!
        internal void InitQueryAllWebhookMessageTemplates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "WebhookMessageTemplatesReqInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllWebhookMessageTemplates",
                "($input: WebhookMessageTemplatesReqInput!)",
                "List<WebhookMessageTemplate>",
                Query.AllWebhookMessageTemplates,
                Query.AllWebhookMessageTemplatesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	recordType = $someTemplateRecordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TemplateRecordType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // allWebhooksV2: [WebhookV2!]!
        internal void InitQueryAllWebhooksV2()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllWebhooksV2",
                "",
                "List<WebhookV2>",
                Query.AllWebhooksV2,
                Query.AllWebhooksV2FieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allWebhooks(name: String): WebhookConnection!
        internal void InitQueryAllWebhooks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("name", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllWebhooks",
                "($name: String)",
                "WebhookConnection",
                Query.AllWebhooks,
                Query.AllWebhooksFieldSpec,
                @"# OPTIONAL
$query.Var.name = $someString"
            );
        }


    } // class New_RscQueryWebhook
}
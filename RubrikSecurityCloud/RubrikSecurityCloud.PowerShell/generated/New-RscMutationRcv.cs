// New-RscMutationRcv.cs
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
    /// operations in the 'RCV' API domain:
    /// CreateLocationsFromTemplate, CreatePrivateEndpointApprovalRequest, or UpdateTarget.
    /// </summary>
    /// <description>
    /// New-RscMutationRcv creates a new
    /// mutation object for operations
    /// in the 'RCV' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 3 operations
    /// in the 'RCV' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateLocationsFromTemplate, CreatePrivateEndpointApprovalRequest, or UpdateTarget.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationRcv -CreateLocationsFromTemplate).Info().
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
    /// (New-RscMutationRcv -CreateLocationsFromTemplate).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateLocationsFromTemplate operation
    /// of the 'RCV' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcv
    /// # API Operation: CreateLocationsFromTemplate
    /// 
    /// $query = New-RscMutationRcv -CreateLocationsFromTemplate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	region = $someRcsRegionEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsRegionEnumType]) for enum values.
    /// 	# REQUIRED
    /// 	tier = $someRcsTierEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsTierEnumType]) for enum values.
    /// 	# OPTIONAL
    /// 	lockDurationDays = $someInt64
    /// 	# OPTIONAL
    /// 	clusterUuidList = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	ipMapping = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			ips = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	shouldBypassProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	rsaKey = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Target&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreatePrivateEndpointApprovalRequest operation
    /// of the 'RCV' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcv
    /// # API Operation: CreatePrivateEndpointApprovalRequest
    /// 
    /// $query = New-RscMutationRcv -CreatePrivateEndpointApprovalRequest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	locationId = $someString
    /// 	# REQUIRED
    /// 	privateEndpointId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateRcvPrivateEndpointApprovalRequestReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateTarget operation
    /// of the 'RCV' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcv
    /// # API Operation: UpdateTarget
    /// 
    /// $query = New-RscMutationRcv -UpdateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	lockDurationDays = $someInt64
    /// 	# OPTIONAL
    /// 	ipMapping = @{
    /// 		# REQUIRED
    /// 		clusterUuid = $someString
    /// 		# REQUIRED
    /// 		ips = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	shouldBypassProxy = $someBoolean
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
        "RscMutationRcv",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationRcv : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreateLocationsFromTemplate",
                "CreatePrivateEndpointApprovalRequest",
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
                    case "CreateLocationsFromTemplate":
                        this.ProcessRecord_CreateLocationsFromTemplate();
                        break;
                    case "CreatePrivateEndpointApprovalRequest":
                        this.ProcessRecord_CreatePrivateEndpointApprovalRequest();
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
        // createRcvLocationsFromTemplate.
        internal void ProcessRecord_CreateLocationsFromTemplate()
        {
            this._logger.name += " -CreateLocationsFromTemplate";
            // Create new graphql operation createRcvLocationsFromTemplate
            InitMutationCreateRcvLocationsFromTemplate();
        }

        // This parameter set invokes a single graphql operation:
        // createRcvPrivateEndpointApprovalRequest.
        internal void ProcessRecord_CreatePrivateEndpointApprovalRequest()
        {
            this._logger.name += " -CreatePrivateEndpointApprovalRequest";
            // Create new graphql operation createRcvPrivateEndpointApprovalRequest
            InitMutationCreateRcvPrivateEndpointApprovalRequest();
        }

        // This parameter set invokes a single graphql operation:
        // updateRcvTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateRcvTarget
            InitMutationUpdateRcvTarget();
        }


        // Create new GraphQL Mutation:
        // createRcvLocationsFromTemplate(input: CreateRcvLocationsFromTemplateInput!): [Target!]!
        internal void InitMutationCreateRcvLocationsFromTemplate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateRcvLocationsFromTemplateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRcvLocationsFromTemplate",
                "($input: CreateRcvLocationsFromTemplateInput!)",
                "List<Target>",
                Mutation.CreateRcvLocationsFromTemplate_ObjectFieldSpec,
                Mutation.CreateRcvLocationsFromTemplateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	region = $someRcsRegionEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsRegionEnumType]) for enum values.
	# REQUIRED
	tier = $someRcsTierEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsTierEnumType]) for enum values.
	# OPTIONAL
	lockDurationDays = $someInt64
	# OPTIONAL
	clusterUuidList = @(
		$someString
	)
	# OPTIONAL
	ipMapping = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			ips = @(
				$someString
			)
		}
	)
	# OPTIONAL
	shouldBypassProxy = $someBoolean
	# OPTIONAL
	rsaKey = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createRcvPrivateEndpointApprovalRequest(input: CreateRcvPrivateEndpointApprovalRequestInput!): CreateRcvPrivateEndpointApprovalRequestReply!
        internal void InitMutationCreateRcvPrivateEndpointApprovalRequest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateRcvPrivateEndpointApprovalRequestInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRcvPrivateEndpointApprovalRequest",
                "($input: CreateRcvPrivateEndpointApprovalRequestInput!)",
                "CreateRcvPrivateEndpointApprovalRequestReply",
                Mutation.CreateRcvPrivateEndpointApprovalRequest_ObjectFieldSpec,
                Mutation.CreateRcvPrivateEndpointApprovalRequestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	locationId = $someString
	# REQUIRED
	privateEndpointId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateRcvTarget(input: UpdateRcvTargetInput!): Target!
        internal void InitMutationUpdateRcvTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateRcvTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateRcvTarget",
                "($input: UpdateRcvTargetInput!)",
                "Target",
                Mutation.UpdateRcvTarget_ObjectFieldSpec,
                Mutation.UpdateRcvTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# REQUIRED
	lockDurationDays = $someInt64
	# OPTIONAL
	ipMapping = @{
		# REQUIRED
		clusterUuid = $someString
		# REQUIRED
		ips = @(
			$someString
		)
	}
	# OPTIONAL
	shouldBypassProxy = $someBoolean
}"
            );
        }


    } // class New_RscMutationRcv
}
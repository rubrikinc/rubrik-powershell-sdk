// New-RscMutationReplication.cs
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
    /// operations in the 'Replication' API domain:
    /// CreatePair, DeletePair, DisablePause, EnablePause, UpdateNetworkThrottleBypass, or UpdateTarget.
    /// </summary>
    /// <description>
    /// New-RscMutationReplication creates a new
    /// mutation object for operations
    /// in the 'Replication' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Replication' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreatePair, DeletePair, DisablePause, EnablePause, UpdateNetworkThrottleBypass, or UpdateTarget.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationReplication -CreatePair).Info().
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
    /// (New-RscMutationReplication -CreatePair).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreatePair operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: CreatePair
    /// 
    /// $query = New-RscMutationReplication -CreatePair
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	sourceGateway = @{
    /// 		# REQUIRED
    /// 		address = $someString
    /// 		# REQUIRED
    /// 		ports = @(
    /// 			$someInt
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	targetGateway = @{
    /// 		# REQUIRED
    /// 		address = $someString
    /// 		# REQUIRED
    /// 		ports = @(
    /// 			$someInt
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	targetNetworkInterface = @{
    /// 		# OPTIONAL
    /// 		type = $someReplicationInterfaceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationInterfaceType]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	sourceClusterUuid = $someString
    /// 	# REQUIRED
    /// 	targetClusterUuid = $someString
    /// 	# REQUIRED
    /// 	setupType = $someReplicationSetupType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationSetupType]) for enum values.
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
    /// Runs the DeletePair operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: DeletePair
    /// 
    /// $query = New-RscMutationReplication -DeletePair
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sourceClusterUuid = $someString
    /// 	# REQUIRED
    /// 	targetClusterUuid = $someString
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
    /// Runs the DisablePause operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: DisablePause
    /// 
    /// $query = New-RscMutationReplication -DisablePause
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	disablePerLocationPause = @{
    /// 		# REQUIRED
    /// 		shouldSkipOldSnapshots = $someBoolean
    /// 		# REQUIRED
    /// 		sourceClusterUuids = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnablePause operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: EnablePause
    /// 
    /// $query = New-RscMutationReplication -EnablePause
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	enablePerLocationPause = @{
    /// 		# OPTIONAL
    /// 		shouldPauseImmediately = $someBoolean
    /// 		# REQUIRED
    /// 		shouldCancelImmediately = $someBoolean
    /// 		# REQUIRED
    /// 		sourceClusterUuids = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateNetworkThrottleBypass operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: UpdateNetworkThrottleBypass
    /// 
    /// $query = New-RscMutationReplication -UpdateNetworkThrottleBypass
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		shouldBypassReplicationThrottle = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateTarget operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: UpdateTarget
    /// 
    /// $query = New-RscMutationReplication -UpdateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	sourceGateway = @{
    /// 		# REQUIRED
    /// 		address = $someString
    /// 		# REQUIRED
    /// 		ports = @(
    /// 			$someInt
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	targetGateway = @{
    /// 		# REQUIRED
    /// 		address = $someString
    /// 		# REQUIRED
    /// 		ports = @(
    /// 			$someInt
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	targetNetworkInterface = @{
    /// 		# OPTIONAL
    /// 		type = $someReplicationInterfaceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationInterfaceType]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	sourceClusterUuid = $someString
    /// 	# REQUIRED
    /// 	targetClusterUuid = $someString
    /// 	# REQUIRED
    /// 	setupType = $someReplicationSetupType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationSetupType]) for enum values.
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
        "RscMutationReplication",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationReplication : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreatePair",
                "DeletePair",
                "DisablePause",
                "EnablePause",
                "UpdateNetworkThrottleBypass",
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
                    case "CreatePair":
                        this.ProcessRecord_CreatePair();
                        break;
                    case "DeletePair":
                        this.ProcessRecord_DeletePair();
                        break;
                    case "DisablePause":
                        this.ProcessRecord_DisablePause();
                        break;
                    case "EnablePause":
                        this.ProcessRecord_EnablePause();
                        break;
                    case "UpdateNetworkThrottleBypass":
                        this.ProcessRecord_UpdateNetworkThrottleBypass();
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
        // createReplicationPair.
        internal void ProcessRecord_CreatePair()
        {
            this._logger.name += " -CreatePair";
            // Create new graphql operation createReplicationPair
            InitMutationCreateReplicationPair();
        }

        // This parameter set invokes a single graphql operation:
        // deleteReplicationPair.
        internal void ProcessRecord_DeletePair()
        {
            this._logger.name += " -DeletePair";
            // Create new graphql operation deleteReplicationPair
            InitMutationDeleteReplicationPair();
        }

        // This parameter set invokes a single graphql operation:
        // disableReplicationPause.
        internal void ProcessRecord_DisablePause()
        {
            this._logger.name += " -DisablePause";
            // Create new graphql operation disableReplicationPause
            InitMutationDisableReplicationPause();
        }

        // This parameter set invokes a single graphql operation:
        // enableReplicationPause.
        internal void ProcessRecord_EnablePause()
        {
            this._logger.name += " -EnablePause";
            // Create new graphql operation enableReplicationPause
            InitMutationEnableReplicationPause();
        }

        // This parameter set invokes a single graphql operation:
        // updateReplicationNetworkThrottleBypass.
        internal void ProcessRecord_UpdateNetworkThrottleBypass()
        {
            this._logger.name += " -UpdateNetworkThrottleBypass";
            // Create new graphql operation updateReplicationNetworkThrottleBypass
            InitMutationUpdateReplicationNetworkThrottleBypass();
        }

        // This parameter set invokes a single graphql operation:
        // updateReplicationTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateReplicationTarget
            InitMutationUpdateReplicationTarget();
        }


        // Create new GraphQL Mutation:
        // createReplicationPair(input: CreateReplicationPairInput!): Void
        internal void InitMutationCreateReplicationPair()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateReplicationPairInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateReplicationPair",
                "($input: CreateReplicationPairInput!)",
                "System.String",
                Mutation.CreateReplicationPair_ObjectFieldSpec,
                Mutation.CreateReplicationPairFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	sourceGateway = @{
		# REQUIRED
		address = $someString
		# REQUIRED
		ports = @(
			$someInt
		)
	}
	# OPTIONAL
	targetGateway = @{
		# REQUIRED
		address = $someString
		# REQUIRED
		ports = @(
			$someInt
		)
	}
	# OPTIONAL
	targetNetworkInterface = @{
		# OPTIONAL
		type = $someReplicationInterfaceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationInterfaceType]) for enum values.
	}
	# REQUIRED
	sourceClusterUuid = $someString
	# REQUIRED
	targetClusterUuid = $someString
	# REQUIRED
	setupType = $someReplicationSetupType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationSetupType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteReplicationPair(input: DeleteReplicationPairInput!): Void
        internal void InitMutationDeleteReplicationPair()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteReplicationPairInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteReplicationPair",
                "($input: DeleteReplicationPairInput!)",
                "System.String",
                Mutation.DeleteReplicationPair_ObjectFieldSpec,
                Mutation.DeleteReplicationPairFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sourceClusterUuid = $someString
	# REQUIRED
	targetClusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // disableReplicationPause(input: DisableReplicationPauseInput!): ResponseSuccess!
        internal void InitMutationDisableReplicationPause()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DisableReplicationPauseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDisableReplicationPause",
                "($input: DisableReplicationPauseInput!)",
                "ResponseSuccess",
                Mutation.DisableReplicationPause_ObjectFieldSpec,
                Mutation.DisableReplicationPauseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	disablePerLocationPause = @{
		# REQUIRED
		shouldSkipOldSnapshots = $someBoolean
		# REQUIRED
		sourceClusterUuids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableReplicationPause(input: EnablePerLocationPauseInputVariable!): ResponseSuccess!
        internal void InitMutationEnableReplicationPause()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnablePerLocationPauseInputVariable!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableReplicationPause",
                "($input: EnablePerLocationPauseInputVariable!)",
                "ResponseSuccess",
                Mutation.EnableReplicationPause_ObjectFieldSpec,
                Mutation.EnableReplicationPauseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	enablePerLocationPause = @{
		# OPTIONAL
		shouldPauseImmediately = $someBoolean
		# REQUIRED
		shouldCancelImmediately = $someBoolean
		# REQUIRED
		sourceClusterUuids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateReplicationNetworkThrottleBypass(input: UpdateReplicationNetworkThrottleBypassInput!): ResponseSuccess!
        internal void InitMutationUpdateReplicationNetworkThrottleBypass()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateReplicationNetworkThrottleBypassInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateReplicationNetworkThrottleBypass",
                "($input: UpdateReplicationNetworkThrottleBypassInput!)",
                "ResponseSuccess",
                Mutation.UpdateReplicationNetworkThrottleBypass_ObjectFieldSpec,
                Mutation.UpdateReplicationNetworkThrottleBypassFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		shouldBypassReplicationThrottle = $someBoolean
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateReplicationTarget(input: UpdateReplicationTargetInput!): Void
        internal void InitMutationUpdateReplicationTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateReplicationTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateReplicationTarget",
                "($input: UpdateReplicationTargetInput!)",
                "System.String",
                Mutation.UpdateReplicationTarget_ObjectFieldSpec,
                Mutation.UpdateReplicationTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	sourceGateway = @{
		# REQUIRED
		address = $someString
		# REQUIRED
		ports = @(
			$someInt
		)
	}
	# OPTIONAL
	targetGateway = @{
		# REQUIRED
		address = $someString
		# REQUIRED
		ports = @(
			$someInt
		)
	}
	# OPTIONAL
	targetNetworkInterface = @{
		# OPTIONAL
		type = $someReplicationInterfaceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationInterfaceType]) for enum values.
	}
	# REQUIRED
	sourceClusterUuid = $someString
	# REQUIRED
	targetClusterUuid = $someString
	# REQUIRED
	setupType = $someReplicationSetupType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationSetupType]) for enum values.
}"
            );
        }


    } // class New_RscMutationReplication
}
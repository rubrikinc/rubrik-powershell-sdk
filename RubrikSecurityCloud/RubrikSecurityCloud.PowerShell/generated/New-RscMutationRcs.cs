// New-RscMutationRcs.cs
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
    /// operations in the 'RCS' API domain:
    /// CreateAutomaticRcsTargetMapping, CreateRcsReaderTarget, CreateRcsTarget, or UpdateRcsAutomaticTargetMapping.
    /// </summary>
    /// <description>
    /// New-RscMutationRcs creates a new
    /// mutation object for operations
    /// in the 'RCS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'RCS' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateAutomaticRcsTargetMapping, CreateRcsReaderTarget, CreateRcsTarget, or UpdateRcsAutomaticTargetMapping.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationRcs -CreateAutomaticRcsTargetMapping).Info().
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
    /// (New-RscMutationRcs -CreateAutomaticRcsTargetMapping).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateAutomaticRcsTargetMapping operation
    /// of the 'RCS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcs
    /// # API Operation: CreateAutomaticRcsTargetMapping
    /// 
    /// $query = New-RscMutationRcs -CreateAutomaticRcsTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	region = $someRcsRegionEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsRegionEnumType]) for enum values.
    /// 	# OPTIONAL
    /// 	rsaKey = $someString
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
    /// 	redundancy = $someRcvRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvRedundancy]) for enum values.
    /// 	# OPTIONAL
    /// 	azureKeyVaultKey = @{
    /// 		# REQUIRED
    /// 		kmsKeyVaultId = $someString
    /// 		# REQUIRED
    /// 		keyName = $someString
    /// 		# REQUIRED
    /// 		keyVersion = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateRcsReaderTarget operation
    /// of the 'RCS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcs
    /// # API Operation: CreateRcsReaderTarget
    /// 
    /// $query = New-RscMutationRcs -CreateRcsReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	readerLocationName = $someString
    /// 	# REQUIRED
    /// 	rcsArchivalLocationName = $someString
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
    /// Runs the CreateRcsTarget operation
    /// of the 'RCS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcs
    /// # API Operation: CreateRcsTarget
    /// 
    /// $query = New-RscMutationRcs -CreateRcsTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	tier = $someRcsTierEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsTierEnumType]) for enum values.
    /// 	# REQUIRED
    /// 	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	rsaKey = $someString
    /// 	# REQUIRED
    /// 	region = $someRcsRegionEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsRegionEnumType]) for enum values.
    /// 	# REQUIRED
    /// 	spaceUsageAlertThreshold = $someInt
    /// 	# REQUIRED
    /// 	lockDurationDays = $someInt64
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
    /// <example>
    /// Runs the UpdateRcsAutomaticTargetMapping operation
    /// of the 'RCS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcs
    /// # API Operation: UpdateRcsAutomaticTargetMapping
    /// 
    /// $query = New-RscMutationRcs -UpdateRcsAutomaticTargetMapping
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
    /// 	clusterUuidList = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	shouldBypassProxy = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
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
        "RscMutationRcs",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationRcs : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreateAutomaticRcsTargetMapping",
                "CreateRcsReaderTarget",
                "CreateRcsTarget",
                "UpdateRcsAutomaticTargetMapping",
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
                    case "CreateAutomaticRcsTargetMapping":
                        this.ProcessRecord_CreateAutomaticRcsTargetMapping();
                        break;
                    case "CreateRcsReaderTarget":
                        this.ProcessRecord_CreateRcsReaderTarget();
                        break;
                    case "CreateRcsTarget":
                        this.ProcessRecord_CreateRcsTarget();
                        break;
                    case "UpdateRcsAutomaticTargetMapping":
                        this.ProcessRecord_UpdateRcsAutomaticTargetMapping();
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
        // createAutomaticRcsTargetMapping.
        internal void ProcessRecord_CreateAutomaticRcsTargetMapping()
        {
            this._logger.name += " -CreateAutomaticRcsTargetMapping";
            // Create new graphql operation createAutomaticRcsTargetMapping
            InitMutationCreateAutomaticRcsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createRcsReaderTarget.
        internal void ProcessRecord_CreateRcsReaderTarget()
        {
            this._logger.name += " -CreateRcsReaderTarget";
            // Create new graphql operation createRcsReaderTarget
            InitMutationCreateRcsReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createRcsTarget.
        internal void ProcessRecord_CreateRcsTarget()
        {
            this._logger.name += " -CreateRcsTarget";
            // Create new graphql operation createRcsTarget
            InitMutationCreateRcsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateRcsAutomaticTargetMapping.
        internal void ProcessRecord_UpdateRcsAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateRcsAutomaticTargetMapping";
            // Create new graphql operation updateRcsAutomaticTargetMapping
            InitMutationUpdateRcsAutomaticTargetMapping();
        }


        // Create new GraphQL Mutation:
        // createAutomaticRcsTargetMapping(input: CreateAutomaticRcsTargetMappingInput!): TargetMapping!
        internal void InitMutationCreateAutomaticRcsTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticRcsTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAutomaticRcsTargetMapping",
                "($input: CreateAutomaticRcsTargetMappingInput!)",
                "TargetMapping",
                Mutation.CreateAutomaticRcsTargetMapping,
                Mutation.CreateAutomaticRcsTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	region = $someRcsRegionEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsRegionEnumType]) for enum values.
	# OPTIONAL
	rsaKey = $someString
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
	redundancy = $someRcvRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvRedundancy]) for enum values.
	# OPTIONAL
	azureKeyVaultKey = @{
		# REQUIRED
		kmsKeyVaultId = $someString
		# REQUIRED
		keyName = $someString
		# REQUIRED
		keyVersion = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createRcsReaderTarget(input: CreateRcsReaderTargetInput!): Target!
        internal void InitMutationCreateRcsReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateRcsReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRcsReaderTarget",
                "($input: CreateRcsReaderTargetInput!)",
                "Target",
                Mutation.CreateRcsReaderTarget,
                Mutation.CreateRcsReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	readerLocationName = $someString
	# REQUIRED
	rcsArchivalLocationName = $someString
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createRcsTarget(input: CreateRcsTargetInput!): Target!
        internal void InitMutationCreateRcsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateRcsTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRcsTarget",
                "($input: CreateRcsTargetInput!)",
                "Target",
                Mutation.CreateRcsTarget,
                Mutation.CreateRcsTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	tier = $someRcsTierEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsTierEnumType]) for enum values.
	# REQUIRED
	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = $someString
	# REQUIRED
	region = $someRcsRegionEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsRegionEnumType]) for enum values.
	# REQUIRED
	spaceUsageAlertThreshold = $someInt
	# REQUIRED
	lockDurationDays = $someInt64
	# OPTIONAL
	shouldBypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateRcsAutomaticTargetMapping(input: UpdateRcsAutomaticTargetMappingInput!): TargetMapping!
        internal void InitMutationUpdateRcsAutomaticTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateRcsAutomaticTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateRcsAutomaticTargetMapping",
                "($input: UpdateRcsAutomaticTargetMappingInput!)",
                "TargetMapping",
                Mutation.UpdateRcsAutomaticTargetMapping,
                Mutation.UpdateRcsAutomaticTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# REQUIRED
	lockDurationDays = $someInt64
	# OPTIONAL
	clusterUuidList = @(
		$someString
	)
	# OPTIONAL
	shouldBypassProxy = $someBoolean
}"
            );
        }


    } // class New_RscMutationRcs
}
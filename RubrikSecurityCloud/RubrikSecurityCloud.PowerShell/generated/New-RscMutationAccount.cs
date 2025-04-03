// New-RscMutationAccount.cs
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
    /// Create a new RscQuery object for any of the 14
    /// operations in the 'Account' API domain:
    /// CreateOrg, CreateOrgSwitchSession, CreateRole, CreateUser, CreateUserWithPassword, DeleteOrg, DeleteRole, DeleteTotpConfig, DeleteTotpConfigs, DeleteUsers, GenerateTotpSecret, MutateRole, UpdateOrg, or UpdateRole.
    /// </summary>
    /// <description>
    /// New-RscMutationAccount creates a new
    /// mutation object for operations
    /// in the 'Account' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 14 operations
    /// in the 'Account' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateOrg, CreateOrgSwitchSession, CreateRole, CreateUser, CreateUserWithPassword, DeleteOrg, DeleteRole, DeleteTotpConfig, DeleteTotpConfigs, DeleteUsers, GenerateTotpSecret, MutateRole, UpdateOrg, or UpdateRole.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationAccount -CreateOrg).Info().
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
    /// (New-RscMutationAccount -CreateOrg).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateOrg operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: CreateOrg
    /// 
    /// $query = New-RscMutationAccount -Operation CreateOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	fullName = $someString
    /// 	# REQUIRED
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	authDomainConfig = $someTenantAuthDomainConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TenantAuthDomainConfig]) for enum values.
    /// 	# REQUIRED
    /// 	shouldEnforceMfaForAll = $someBoolean
    /// 	# REQUIRED
    /// 	isEnvoyRequired = $someBoolean
    /// 	# REQUIRED
    /// 	allowedClusters = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	existingUsers = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	userInvites = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			email = $someString
    /// 			# REQUIRED
    /// 			note = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	permissions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 			# REQUIRED
    /// 			objectsForHierarchyTypes = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					objectIds = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	selfServicePermissions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			inventoryRoot = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
    /// 			# REQUIRED
    /// 			inventoryWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			# REQUIRED
    /// 			operations = @(
    /// 				$someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			hierarchyRoot = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	existingSsoGroups = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	newSsoGroups = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 			# OPTIONAL
    /// 			authDomainId = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	isServiceAccountEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	isServiceAccountDisabled = $someBoolean
    /// 	# OPTIONAL
    /// 	isInheritIpAllowlistDisabled = $someBoolean
    /// 	# OPTIONAL
    /// 	crossAccountCapabilities = @(
    /// 		$someCrossAccountCapability # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CrossAccountCapability]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOrgReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateOrgSwitchSession operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: CreateOrgSwitchSession
    /// 
    /// $query = New-RscMutationAccount -Operation CreateOrgSwitchSession
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOrgSwitchSessionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateRole operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: CreateRole
    /// 
    /// $query = New-RscMutationAccount -Operation CreateRole
    /// 
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.description = $someString
    /// # OPTIONAL
    /// $query.Var.isSynced = $someBoolean
    /// # REQUIRED
    /// $query.Var.permissions = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 		# REQUIRED
    /// 		objectsForHierarchyTypes = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				objectIds = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			}
    /// 		)
    /// }
    /// )
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
    /// Runs the CreateUser operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: CreateUser
    /// 
    /// $query = New-RscMutationAccount -Operation CreateUser
    /// 
    /// # REQUIRED
    /// $query.Var.email = $someString
    /// # REQUIRED
    /// $query.Var.roleIds = @(
    /// 	$someString
    /// )
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
    /// Runs the CreateUserWithPassword operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: CreateUserWithPassword
    /// 
    /// $query = New-RscMutationAccount -Operation CreateUserWithPassword
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	email = $someString
    /// 	# OPTIONAL
    /// 	password = $someString
    /// 	# OPTIONAL
    /// 	roleIds = @(
    /// 		$someString
    /// 	)
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
    /// Runs the DeleteOrg operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: DeleteOrg
    /// 
    /// $query = New-RscMutationAccount -Operation DeleteOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	organizationId = $someString
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
    /// Runs the DeleteRole operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: DeleteRole
    /// 
    /// $query = New-RscMutationAccount -Operation DeleteRole
    /// 
    /// # REQUIRED
    /// $query.Var.roleId = $someString
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
    /// Runs the DeleteTotpConfig operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: DeleteTotpConfig
    /// 
    /// $query = New-RscMutationAccount -Operation DeleteTotpConfig
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
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
    /// Runs the DeleteTotpConfigs operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: DeleteTotpConfigs
    /// 
    /// $query = New-RscMutationAccount -Operation DeleteTotpConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	userIds = @(
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
    /// Runs the DeleteUsers operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: DeleteUsers
    /// 
    /// $query = New-RscMutationAccount -Operation DeleteUsers
    /// 
    /// # REQUIRED
    /// $query.Var.ids = @(
    /// 	$someString
    /// )
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
    /// Runs the GenerateTotpSecret operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: GenerateTotpSecret
    /// 
    /// $query = New-RscMutationAccount -Operation GenerateTotpSecret
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GenerateTotpSecretReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MutateRole operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: MutateRole
    /// 
    /// $query = New-RscMutationAccount -Operation MutateRole
    /// 
    /// # OPTIONAL
    /// $query.Var.roleId = $someString
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.description = $someString
    /// # REQUIRED
    /// $query.Var.permissions = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 		# REQUIRED
    /// 		objectsForHierarchyTypes = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				objectIds = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			}
    /// 		)
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.protectableClusters = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.isSynced = $someBoolean
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
    /// Runs the UpdateOrg operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: UpdateOrg
    /// 
    /// $query = New-RscMutationAccount -Operation UpdateOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	organizationId = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	fullName = $someString
    /// 	# REQUIRED
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	authDomainConfig = $someTenantAuthDomainConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TenantAuthDomainConfig]) for enum values.
    /// 	# REQUIRED
    /// 	shouldEnforceMfaForAll = $someBoolean
    /// 	# REQUIRED
    /// 	isEnvoyRequired = $someBoolean
    /// 	# REQUIRED
    /// 	allowedClusters = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	existingUsers = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	userInvites = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			email = $someString
    /// 			# REQUIRED
    /// 			note = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	permissions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 			# REQUIRED
    /// 			objectsForHierarchyTypes = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					objectIds = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	selfServicePermissions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			inventoryRoot = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
    /// 			# REQUIRED
    /// 			inventoryWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			# REQUIRED
    /// 			operations = @(
    /// 				$someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			hierarchyRoot = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	existingSsoGroups = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	newSsoGroups = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 			# OPTIONAL
    /// 			authDomainId = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	isServiceAccountEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	isServiceAccountDisabled = $someBoolean
    /// 	# OPTIONAL
    /// 	isInheritIpAllowlistDisabled = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldKeepGlobalIpAllowlist = $someBoolean
    /// 	# OPTIONAL
    /// 	crossAccountCapabilities = @(
    /// 		$someCrossAccountCapability # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CrossAccountCapability]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateOrgReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateRole operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: UpdateRole
    /// 
    /// $query = New-RscMutationAccount -Operation UpdateRole
    /// 
    /// # REQUIRED
    /// $query.Var.roleId = $someString
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.description = $someString
    /// # OPTIONAL
    /// $query.Var.isSynced = $someBoolean
    /// # REQUIRED
    /// $query.Var.permissions = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 		# REQUIRED
    /// 		objectsForHierarchyTypes = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				objectIds = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			}
    /// 		)
    /// }
    /// )
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationAccount",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationAccount : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreateOrg",
                "CreateOrgSwitchSession",
                "CreateRole",
                "CreateUser",
                "CreateUserWithPassword",
                "DeleteOrg",
                "DeleteRole",
                "DeleteTotpConfig",
                "DeleteTotpConfigs",
                "DeleteUsers",
                "GenerateTotpSecret",
                "MutateRole",
                "UpdateOrg",
                "UpdateRole",
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
                    case "CreateOrg":
                        this.ProcessRecord_CreateOrg();
                        break;
                    case "CreateOrgSwitchSession":
                        this.ProcessRecord_CreateOrgSwitchSession();
                        break;
                    case "CreateRole":
                        this.ProcessRecord_CreateRole();
                        break;
                    case "CreateUser":
                        this.ProcessRecord_CreateUser();
                        break;
                    case "CreateUserWithPassword":
                        this.ProcessRecord_CreateUserWithPassword();
                        break;
                    case "DeleteOrg":
                        this.ProcessRecord_DeleteOrg();
                        break;
                    case "DeleteRole":
                        this.ProcessRecord_DeleteRole();
                        break;
                    case "DeleteTotpConfig":
                        this.ProcessRecord_DeleteTotpConfig();
                        break;
                    case "DeleteTotpConfigs":
                        this.ProcessRecord_DeleteTotpConfigs();
                        break;
                    case "DeleteUsers":
                        this.ProcessRecord_DeleteUsers();
                        break;
                    case "GenerateTotpSecret":
                        this.ProcessRecord_GenerateTotpSecret();
                        break;
                    case "MutateRole":
                        this.ProcessRecord_MutateRole();
                        break;
                    case "UpdateOrg":
                        this.ProcessRecord_UpdateOrg();
                        break;
                    case "UpdateRole":
                        this.ProcessRecord_UpdateRole();
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
        // createOrg.
        internal void ProcessRecord_CreateOrg()
        {
            this._logger.name += " -CreateOrg";
            // Create new graphql operation createOrg
            InitMutationCreateOrg();
        }

        // This parameter set invokes a single graphql operation:
        // createOrgSwitchSession.
        internal void ProcessRecord_CreateOrgSwitchSession()
        {
            this._logger.name += " -CreateOrgSwitchSession";
            // Create new graphql operation createOrgSwitchSession
            InitMutationCreateOrgSwitchSession();
        }

        // This parameter set invokes a single graphql operation:
        // createRole.
        internal void ProcessRecord_CreateRole()
        {
            this._logger.name += " -CreateRole";
            // Create new graphql operation createRole
            InitMutationCreateRole();
        }

        // This parameter set invokes a single graphql operation:
        // createUser.
        internal void ProcessRecord_CreateUser()
        {
            this._logger.name += " -CreateUser";
            // Create new graphql operation createUser
            InitMutationCreateUser();
        }

        // This parameter set invokes a single graphql operation:
        // createUserWithPassword.
        internal void ProcessRecord_CreateUserWithPassword()
        {
            this._logger.name += " -CreateUserWithPassword";
            // Create new graphql operation createUserWithPassword
            InitMutationCreateUserWithPassword();
        }

        // This parameter set invokes a single graphql operation:
        // deleteOrg.
        internal void ProcessRecord_DeleteOrg()
        {
            this._logger.name += " -DeleteOrg";
            // Create new graphql operation deleteOrg
            InitMutationDeleteOrg();
        }

        // This parameter set invokes a single graphql operation:
        // deleteRole.
        internal void ProcessRecord_DeleteRole()
        {
            this._logger.name += " -DeleteRole";
            // Create new graphql operation deleteRole
            InitMutationDeleteRole();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTotpConfig.
        internal void ProcessRecord_DeleteTotpConfig()
        {
            this._logger.name += " -DeleteTotpConfig";
            // Create new graphql operation deleteTotpConfig
            InitMutationDeleteTotpConfig();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTotpConfigs.
        internal void ProcessRecord_DeleteTotpConfigs()
        {
            this._logger.name += " -DeleteTotpConfigs";
            // Create new graphql operation deleteTotpConfigs
            InitMutationDeleteTotpConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // deleteUsersFromAccount.
        internal void ProcessRecord_DeleteUsers()
        {
            this._logger.name += " -DeleteUsers";
            // Create new graphql operation deleteUsersFromAccount
            InitMutationDeleteUsersFromAccount();
        }

        // This parameter set invokes a single graphql operation:
        // generateTotpSecret.
        internal void ProcessRecord_GenerateTotpSecret()
        {
            this._logger.name += " -GenerateTotpSecret";
            // Create new graphql operation generateTotpSecret
            InitMutationGenerateTotpSecret();
        }

        // This parameter set invokes a single graphql operation:
        // mutateRole.
        internal void ProcessRecord_MutateRole()
        {
            this._logger.name += " -MutateRole";
            // Create new graphql operation mutateRole
            InitMutationMutateRole();
        }

        // This parameter set invokes a single graphql operation:
        // updateOrg.
        internal void ProcessRecord_UpdateOrg()
        {
            this._logger.name += " -UpdateOrg";
            // Create new graphql operation updateOrg
            InitMutationUpdateOrg();
        }

        // This parameter set invokes a single graphql operation:
        // updateRole.
        internal void ProcessRecord_UpdateRole()
        {
            this._logger.name += " -UpdateRole";
            // Create new graphql operation updateRole
            InitMutationUpdateRole();
        }


        // Create new GraphQL Mutation:
        // createOrg(input: CreateOrgInput!): CreateOrgReply!
        internal void InitMutationCreateOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOrg",
                "($input: CreateOrgInput!)",
                "CreateOrgReply",
                Mutation.CreateOrg,
                Mutation.CreateOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	fullName = $someString
	# REQUIRED
	description = $someString
	# REQUIRED
	authDomainConfig = $someTenantAuthDomainConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TenantAuthDomainConfig]) for enum values.
	# REQUIRED
	shouldEnforceMfaForAll = $someBoolean
	# REQUIRED
	isEnvoyRequired = $someBoolean
	# REQUIRED
	allowedClusters = @(
		$someString
	)
	# OPTIONAL
	existingUsers = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	userInvites = @(
		@{
			# REQUIRED
			email = $someString
			# REQUIRED
			note = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# REQUIRED
	permissions = @(
		@{
			# REQUIRED
			operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
			# REQUIRED
			objectsForHierarchyTypes = @(
				@{
					# REQUIRED
					objectIds = @(
						$someString
					)
					# REQUIRED
					snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
				}
			)
		}
	)
	# REQUIRED
	selfServicePermissions = @(
		@{
			# OPTIONAL
			inventoryRoot = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
			# REQUIRED
			inventoryWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			# REQUIRED
			operations = @(
				$someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
			)
			# OPTIONAL
			hierarchyRoot = $someString
		}
	)
	# OPTIONAL
	existingSsoGroups = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	newSsoGroups = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
			# OPTIONAL
			authDomainId = $someString
		}
	)
	# OPTIONAL
	isServiceAccountEnabled = $someBoolean
	# OPTIONAL
	isServiceAccountDisabled = $someBoolean
	# OPTIONAL
	isInheritIpAllowlistDisabled = $someBoolean
	# OPTIONAL
	crossAccountCapabilities = @(
		$someCrossAccountCapability # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CrossAccountCapability]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOrgSwitchSession(input: CreateOrgSwitchSessionInput!): CreateOrgSwitchSessionReply!
        internal void InitMutationCreateOrgSwitchSession()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOrgSwitchSessionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOrgSwitchSession",
                "($input: CreateOrgSwitchSessionInput!)",
                "CreateOrgSwitchSessionReply",
                Mutation.CreateOrgSwitchSession,
                Mutation.CreateOrgSwitchSessionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createRole(
        //     name: String!
        //     description: String!
        //     isSynced: Boolean
        //     permissions: [PermissionInput!]!
        //   ): UUID!
        internal void InitMutationCreateRole()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("name", "String!"),
                Tuple.Create("description", "String!"),
                Tuple.Create("isSynced", "Boolean"),
                Tuple.Create("permissions", "[PermissionInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRole",
                "($name: String!,$description: String!,$isSynced: Boolean,$permissions: [PermissionInput!]!)",
                "System.String",
                Mutation.CreateRole,
                Mutation.CreateRoleFieldSpec,
                @"# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.description = $someString
# OPTIONAL
$query.Var.isSynced = $someBoolean
# REQUIRED
$query.Var.permissions = @(
	@{
		# REQUIRED
		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
		# REQUIRED
		objectsForHierarchyTypes = @(
			@{
				# REQUIRED
				objectIds = @(
					$someString
				)
				# REQUIRED
				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			}
		)
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // createUser(email: String!, roleIds: [String!]!): String!
        internal void InitMutationCreateUser()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("email", "String!"),
                Tuple.Create("roleIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateUser",
                "($email: String!,$roleIds: [String!]!)",
                "System.String",
                Mutation.CreateUser,
                Mutation.CreateUserFieldSpec,
                @"# REQUIRED
$query.Var.email = $someString
# REQUIRED
$query.Var.roleIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // createUserWithPassword(input: CreateUserWithPasswordInput!): String!
        internal void InitMutationCreateUserWithPassword()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateUserWithPasswordInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateUserWithPassword",
                "($input: CreateUserWithPasswordInput!)",
                "System.String",
                Mutation.CreateUserWithPassword,
                Mutation.CreateUserWithPasswordFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	email = $someString
	# OPTIONAL
	password = $someString
	# OPTIONAL
	roleIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteOrg(input: DeleteOrgInput!): Boolean!
        internal void InitMutationDeleteOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteOrg",
                "($input: DeleteOrgInput!)",
                "System.Boolean",
                Mutation.DeleteOrg,
                Mutation.DeleteOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	organizationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteRole(roleId: String!): Boolean!
        internal void InitMutationDeleteRole()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteRole",
                "($roleId: String!)",
                "System.Boolean",
                Mutation.DeleteRole,
                Mutation.DeleteRoleFieldSpec,
                @"# REQUIRED
$query.Var.roleId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTotpConfig(userId: String!): Boolean!
        internal void InitMutationDeleteTotpConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTotpConfig",
                "($userId: String!)",
                "System.Boolean",
                Mutation.DeleteTotpConfig,
                Mutation.DeleteTotpConfigFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTotpConfigs(input: DeleteTotpConfigsInput!): Boolean!
        internal void InitMutationDeleteTotpConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteTotpConfigsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTotpConfigs",
                "($input: DeleteTotpConfigsInput!)",
                "System.Boolean",
                Mutation.DeleteTotpConfigs,
                Mutation.DeleteTotpConfigsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	userIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteUsersFromAccount(ids: [String!]!): Boolean!
        internal void InitMutationDeleteUsersFromAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteUsersFromAccount",
                "($ids: [String!]!)",
                "System.Boolean",
                Mutation.DeleteUsersFromAccount,
                Mutation.DeleteUsersFromAccountFieldSpec,
                @"# REQUIRED
$query.Var.ids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // generateTotpSecret(userId: String!): GenerateTotpSecretReply!
        internal void InitMutationGenerateTotpSecret()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGenerateTotpSecret",
                "($userId: String!)",
                "GenerateTotpSecretReply",
                Mutation.GenerateTotpSecret,
                Mutation.GenerateTotpSecretFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // mutateRole(
        //     roleId: String
        //     name: String!
        //     description: String!
        //     permissions: [PermissionInput!]!
        //     protectableClusters: [String!]!
        //     isSynced: Boolean
        //   ): UUID!
        internal void InitMutationMutateRole()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleId", "String"),
                Tuple.Create("name", "String!"),
                Tuple.Create("description", "String!"),
                Tuple.Create("permissions", "[PermissionInput!]!"),
                Tuple.Create("protectableClusters", "[String!]!"),
                Tuple.Create("isSynced", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMutateRole",
                "($roleId: String,$name: String!,$description: String!,$permissions: [PermissionInput!]!,$protectableClusters: [String!]!,$isSynced: Boolean)",
                "System.String",
                Mutation.MutateRole,
                Mutation.MutateRoleFieldSpec,
                @"# OPTIONAL
$query.Var.roleId = $someString
# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.description = $someString
# REQUIRED
$query.Var.permissions = @(
	@{
		# REQUIRED
		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
		# REQUIRED
		objectsForHierarchyTypes = @(
			@{
				# REQUIRED
				objectIds = @(
					$someString
				)
				# REQUIRED
				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			}
		)
}
)
# REQUIRED
$query.Var.protectableClusters = @(
	$someString
)
# OPTIONAL
$query.Var.isSynced = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // updateOrg(input: UpdateOrgInput!): UpdateOrgReply!
        internal void InitMutationUpdateOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateOrg",
                "($input: UpdateOrgInput!)",
                "UpdateOrgReply",
                Mutation.UpdateOrg,
                Mutation.UpdateOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	organizationId = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	fullName = $someString
	# REQUIRED
	description = $someString
	# REQUIRED
	authDomainConfig = $someTenantAuthDomainConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TenantAuthDomainConfig]) for enum values.
	# REQUIRED
	shouldEnforceMfaForAll = $someBoolean
	# REQUIRED
	isEnvoyRequired = $someBoolean
	# REQUIRED
	allowedClusters = @(
		$someString
	)
	# OPTIONAL
	existingUsers = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	userInvites = @(
		@{
			# REQUIRED
			email = $someString
			# REQUIRED
			note = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# REQUIRED
	permissions = @(
		@{
			# REQUIRED
			operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
			# REQUIRED
			objectsForHierarchyTypes = @(
				@{
					# REQUIRED
					objectIds = @(
						$someString
					)
					# REQUIRED
					snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
				}
			)
		}
	)
	# REQUIRED
	selfServicePermissions = @(
		@{
			# OPTIONAL
			inventoryRoot = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
			# REQUIRED
			inventoryWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			# REQUIRED
			operations = @(
				$someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
			)
			# OPTIONAL
			hierarchyRoot = $someString
		}
	)
	# OPTIONAL
	existingSsoGroups = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	newSsoGroups = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
			# OPTIONAL
			authDomainId = $someString
		}
	)
	# OPTIONAL
	isServiceAccountEnabled = $someBoolean
	# OPTIONAL
	isServiceAccountDisabled = $someBoolean
	# OPTIONAL
	isInheritIpAllowlistDisabled = $someBoolean
	# OPTIONAL
	shouldKeepGlobalIpAllowlist = $someBoolean
	# OPTIONAL
	crossAccountCapabilities = @(
		$someCrossAccountCapability # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CrossAccountCapability]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateRole(
        //     roleId: String!
        //     name: String!
        //     description: String!
        //     isSynced: Boolean
        //     permissions: [PermissionInput!]!
        //   ): Boolean!
        internal void InitMutationUpdateRole()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleId", "String!"),
                Tuple.Create("name", "String!"),
                Tuple.Create("description", "String!"),
                Tuple.Create("isSynced", "Boolean"),
                Tuple.Create("permissions", "[PermissionInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateRole",
                "($roleId: String!,$name: String!,$description: String!,$isSynced: Boolean,$permissions: [PermissionInput!]!)",
                "System.Boolean",
                Mutation.UpdateRole,
                Mutation.UpdateRoleFieldSpec,
                @"# REQUIRED
$query.Var.roleId = $someString
# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.description = $someString
# OPTIONAL
$query.Var.isSynced = $someBoolean
# REQUIRED
$query.Var.permissions = @(
	@{
		# REQUIRED
		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
		# REQUIRED
		objectsForHierarchyTypes = @(
			@{
				# REQUIRED
				objectIds = @(
					$someString
				)
				# REQUIRED
				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			}
		)
}
)"
            );
        }


    } // class New_RscMutationAccount
}
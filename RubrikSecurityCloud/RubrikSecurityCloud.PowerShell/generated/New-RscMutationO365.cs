// New-RscMutationO365.cs
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
    /// Create a new RscQuery object for any of the 33
    /// operations in the 'Office 365' API domain:
    /// AddOrg, BackupMailbox, BackupOnedrive, BackupSharePointSite, BackupSharepointDrive, BackupSharepointList, BackupTeam, CreateAppComplete, CreateAppKickoff, DeleteAzureApp, DeleteOrg, DeleteServiceAccount, EnableSharePoint, EnableTeams, ExportMailbox, ExportMailboxV2, InsertCustomerApp, OauthConsentComplete, OauthConsentKickoff, PdlGroups, RefreshOrg, RestoreMailbox, RestoreMailboxV2, RestoreSnappable, RestoreTeamsConversations, RestoreTeamsFiles, SaaSSetupKickoff, SaasSetupComplete, SetServiceAccount, SetupKickoff, UpdateAppAuthStatus, UpdateAppPermissions, or UpdateOrgCustomName.
    /// </summary>
    /// <description>
    /// New-RscMutationO365 creates a new
    /// mutation object for operations
    /// in the 'Office 365' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 33 operations
    /// in the 'Office 365' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddOrg, BackupMailbox, BackupOnedrive, BackupSharePointSite, BackupSharepointDrive, BackupSharepointList, BackupTeam, CreateAppComplete, CreateAppKickoff, DeleteAzureApp, DeleteOrg, DeleteServiceAccount, EnableSharePoint, EnableTeams, ExportMailbox, ExportMailboxV2, InsertCustomerApp, OauthConsentComplete, OauthConsentKickoff, PdlGroups, RefreshOrg, RestoreMailbox, RestoreMailboxV2, RestoreSnappable, RestoreTeamsConversations, RestoreTeamsFiles, SaaSSetupKickoff, SaasSetupComplete, SetServiceAccount, SetupKickoff, UpdateAppAuthStatus, UpdateAppPermissions, or UpdateOrgCustomName.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationO365 -AddOrg).Info().
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
    /// (New-RscMutationO365 -AddOrg).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddOrg operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: AddOrg
    /// 
    /// $query = New-RscMutationO365 -AddOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tenantId = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// 	# REQUIRED
    /// 	exocomputeClusterId = $someString
    /// 	# REQUIRED
    /// 	appTypes = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddO365OrgResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupMailbox operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: BackupMailbox
    /// 
    /// $query = New-RscMutationO365 -BackupMailbox
    /// 
    /// # REQUIRED
    /// $query.Var.mailboxIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupOnedrive operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: BackupOnedrive
    /// 
    /// $query = New-RscMutationO365 -BackupOnedrive
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snappableUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupSharePointSite operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: BackupSharePointSite
    /// 
    /// $query = New-RscMutationO365 -BackupSharePointSite
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	siteFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupSharepointDrive operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: BackupSharepointDrive
    /// 
    /// $query = New-RscMutationO365 -BackupSharepointDrive
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snappableUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupSharepointList operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: BackupSharepointList
    /// 
    /// $query = New-RscMutationO365 -BackupSharepointList
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snappableUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupTeam operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: BackupTeam
    /// 
    /// $query = New-RscMutationO365 -BackupTeam
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snappableUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAppComplete operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: CreateAppComplete
    /// 
    /// $query = New-RscMutationO365 -CreateAppComplete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	appClientId = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// 	# REQUIRED
    /// 	tenantId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAppKickoff operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: CreateAppKickoff
    /// 
    /// $query = New-RscMutationO365 -CreateAppKickoff
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	appType = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateO365AppKickoffResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteAzureApp operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: DeleteAzureApp
    /// 
    /// $query = New-RscMutationO365 -DeleteAzureApp
    /// 
    /// # REQUIRED
    /// $query.Var.o365AppClientId = $someString
    /// # REQUIRED
    /// $query.Var.o365AppType = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteOrg operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: DeleteOrg
    /// 
    /// $query = New-RscMutationO365 -DeleteOrg
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteServiceAccount operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: DeleteServiceAccount
    /// 
    /// $query = New-RscMutationO365 -DeleteServiceAccount
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableSharePoint operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: EnableSharePoint
    /// 
    /// $query = New-RscMutationO365 -EnableSharePoint
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	exocomputeClusterId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableTeams operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: EnableTeams
    /// 
    /// $query = New-RscMutationO365 -EnableTeams
    /// 
    /// # REQUIRED
    /// $query.Var.exocomputeClusterId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExportMailbox operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: ExportMailbox
    /// 
    /// $query = New-RscMutationO365 -ExportMailbox
    /// 
    /// # REQUIRED
    /// $query.Var.exportConfig = @{
    /// 	# OPTIONAL
    /// 	orgUuid = $someString
    /// 	# REQUIRED
    /// 	fromMailboxUuid = $someString
    /// 	# REQUIRED
    /// 	toMailboxUuid = $someString
    /// 	# OPTIONAL
    /// 	snapshotUuid = $someString
    /// 	# REQUIRED
    /// 	exportConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			SnapshotUUID = $someString
    /// 			# OPTIONAL
    /// 			EmailID = $someString
    /// 			# OPTIONAL
    /// 			FolderID = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
    /// 	# OPTIONAL
    /// 	inplaceRestoreConfig = @{
    /// 		# REQUIRED
    /// 		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	skipRifItems = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExportMailboxV2 operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: ExportMailboxV2
    /// 
    /// $query = New-RscMutationO365 -ExportMailboxV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	orgUuid = $someString
    /// 	# REQUIRED
    /// 	fromMailboxUuid = $someString
    /// 	# REQUIRED
    /// 	toMailboxUuid = $someString
    /// 	# OPTIONAL
    /// 	snapshotUuid = $someString
    /// 	# REQUIRED
    /// 	exportConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			SnapshotUUID = $someString
    /// 			# OPTIONAL
    /// 			EmailID = $someString
    /// 			# OPTIONAL
    /// 			FolderID = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
    /// 	# OPTIONAL
    /// 	inplaceRestoreConfig = @{
    /// 		# REQUIRED
    /// 		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	skipRifItems = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InsertCustomerApp operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: InsertCustomerApp
    /// 
    /// $query = New-RscMutationO365 -InsertCustomerApp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	appType = $someString
    /// 	# REQUIRED
    /// 	appClientId = $someString
    /// 	# REQUIRED
    /// 	appClientSecret = $someString
    /// 	# REQUIRED
    /// 	subscriptionId = $someString
    /// 	# OPTIONAL
    /// 	base64AppCertificate = $someString
    /// 	# OPTIONAL
    /// 	base64AppPrivateKey = $someString
    /// 	# OPTIONAL
    /// 	updateAppCredentials = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OauthConsentComplete operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: OauthConsentComplete
    /// 
    /// $query = New-RscMutationO365 -OauthConsentComplete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tenantId = $someString
    /// 	# REQUIRED
    /// 	code = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// 	# REQUIRED
    /// 	redirectUrl = $someString
    /// 	# REQUIRED
    /// 	resourceNaturalId = $someString
    /// 	# OPTIONAL
    /// 	resourceId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365OauthConsentCompleteReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OauthConsentKickoff operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: OauthConsentKickoff
    /// 
    /// $query = New-RscMutationO365 -OauthConsentKickoff
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	appType = $someString
    /// 	# OPTIONAL
    /// 	resourceId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365OauthConsentKickoffReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PdlGroups operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: PdlGroups
    /// 
    /// $query = New-RscMutationO365 -PdlGroups
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	pdlAndWorkloadPairs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			pdl = $someString
    /// 			# REQUIRED
    /// 			workload = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365PdlGroupsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshOrg operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: RefreshOrg
    /// 
    /// $query = New-RscMutationO365 -RefreshOrg
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreMailbox operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: RestoreMailbox
    /// 
    /// $query = New-RscMutationO365 -RestoreMailbox
    /// 
    /// # REQUIRED
    /// $query.Var.restoreConfig = @{
    /// 	# OPTIONAL
    /// 	orgUuid = $someString
    /// 	# REQUIRED
    /// 	mailboxUuid = $someString
    /// 	# OPTIONAL
    /// 	snapshotUuid = $someString
    /// 	# REQUIRED
    /// 	restoreConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			SnapshotUUID = $someString
    /// 			# OPTIONAL
    /// 			EmailID = $someString
    /// 			# OPTIONAL
    /// 			FolderID = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
    /// 	# OPTIONAL
    /// 	inplaceRestoreConfig = @{
    /// 		# REQUIRED
    /// 		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	skipRifItems = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreMailboxV2 operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: RestoreMailboxV2
    /// 
    /// $query = New-RscMutationO365 -RestoreMailboxV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	orgUuid = $someString
    /// 	# REQUIRED
    /// 	mailboxUuid = $someString
    /// 	# OPTIONAL
    /// 	snapshotUuid = $someString
    /// 	# REQUIRED
    /// 	restoreConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			SnapshotUUID = $someString
    /// 			# OPTIONAL
    /// 			EmailID = $someString
    /// 			# OPTIONAL
    /// 			FolderID = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
    /// 	# OPTIONAL
    /// 	inplaceRestoreConfig = @{
    /// 		# REQUIRED
    /// 		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	skipRifItems = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreSnappable operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: RestoreSnappable
    /// 
    /// $query = New-RscMutationO365 -RestoreSnappable
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snappableType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
    /// 	# REQUIRED
    /// 	sourceSnappableUuid = $someString
    /// 	# REQUIRED
    /// 	destinationSnappableUuid = $someString
    /// 	# REQUIRED
    /// 	restoreConfig = @{
    /// 		# OPTIONAL
    /// 		destinationOrgUuid = $someString
    /// 		# OPTIONAL
    /// 		SharePointDriveRestoreConfig = @{
    /// 			# REQUIRED
    /// 			driveRestoreConfig = @{
    /// 				# REQUIRED
    /// 				filesToRestore = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						fileId = $someString
    /// 						# REQUIRED
    /// 						fileName = $someString
    /// 						# REQUIRED
    /// 						fileSnapshotsToRestore = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								snapshotId = $someString
    /// 								# REQUIRED
    /// 								snapshotNum = $someInt
    /// 								# REQUIRED
    /// 								fileSize = $someInt64
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						channelInfo = @{
    /// 							# REQUIRED
    /// 							TeamID = $someString
    /// 							# OPTIONAL
    /// 							ChannelID = $someString
    /// 							# OPTIONAL
    /// 							ChannelName = $someString
    /// 							# OPTIONAL
    /// 							ChannelFolderName = $someString
    /// 							# OPTIONAL
    /// 							ChannelNaturalId = $someString
    /// 							# REQUIRED
    /// 							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 						}
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				foldersToRestore = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						folderId = $someString
    /// 						# REQUIRED
    /// 						folderName = $someString
    /// 						# REQUIRED
    /// 						folderSize = $someInt64
    /// 						# REQUIRED
    /// 						snapshotId = $someString
    /// 						# REQUIRED
    /// 						snapshotNum = $someInt
    /// 						# OPTIONAL
    /// 						channelInfo = @{
    /// 							# REQUIRED
    /// 							TeamID = $someString
    /// 							# OPTIONAL
    /// 							ChannelID = $someString
    /// 							# OPTIONAL
    /// 							ChannelName = $someString
    /// 							# OPTIONAL
    /// 							ChannelFolderName = $someString
    /// 							# OPTIONAL
    /// 							ChannelNaturalId = $someString
    /// 							# REQUIRED
    /// 							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 						}
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				restoreFolderPath = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			docLibName = $someString
    /// 			# OPTIONAL
    /// 			parentSiteUuid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		sharePointListRestoreConfig = @{
    /// 			# REQUIRED
    /// 			itemsToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					itemId = $someString
    /// 					# REQUIRED
    /// 					itemName = $someString
    /// 					# REQUIRED
    /// 					itemSnapshotsToRestore = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							snapshotId = $someString
    /// 							# REQUIRED
    /// 							snapshotNum = $someInt
    /// 						}
    /// 					)
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			foldersToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					folderId = $someString
    /// 					# REQUIRED
    /// 					folderName = $someString
    /// 					# REQUIRED
    /// 					folderSize = $someInt64
    /// 					# REQUIRED
    /// 					snapshotId = $someString
    /// 					# REQUIRED
    /// 					snapshotNum = $someInt
    /// 					# OPTIONAL
    /// 					channelInfo = @{
    /// 						# REQUIRED
    /// 						TeamID = $someString
    /// 						# OPTIONAL
    /// 						ChannelID = $someString
    /// 						# OPTIONAL
    /// 						ChannelName = $someString
    /// 						# OPTIONAL
    /// 						ChannelFolderName = $someString
    /// 						# OPTIONAL
    /// 						ChannelNaturalId = $someString
    /// 						# REQUIRED
    /// 						channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 					}
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			restoreFolderPath = $someString
    /// 			# OPTIONAL
    /// 			listName = $someString
    /// 			# OPTIONAL
    /// 			parentSiteUuid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		sharePointFullRestoreConfig = @{
    /// 			# OPTIONAL
    /// 			spObjectToRestore = @{
    /// 				# REQUIRED
    /// 				objectSharepointId = $someString
    /// 				# OPTIONAL
    /// 				objectId = $someString
    /// 				# REQUIRED
    /// 				objectName = $someString
    /// 				# OPTIONAL
    /// 				objectType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
    /// 				# REQUIRED
    /// 				snapshotId = $someString
    /// 				# REQUIRED
    /// 				snapshotNum = $someInt
    /// 				# OPTIONAL
    /// 				siteOwnerEmail = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			spItemsToRestore = @{
    /// 				# REQUIRED
    /// 				sharepointId = $someString
    /// 				# OPTIONAL
    /// 				objectId = $someString
    /// 				# OPTIONAL
    /// 				snappableType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
    /// 				# REQUIRED
    /// 				listItems = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						itemId = $someString
    /// 						# REQUIRED
    /// 						itemName = $someString
    /// 						# REQUIRED
    /// 						itemSnapshotsToRestore = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								snapshotId = $someString
    /// 								# REQUIRED
    /// 								snapshotNum = $someInt
    /// 							}
    /// 						)
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				folderItems = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						folderId = $someString
    /// 						# REQUIRED
    /// 						folderName = $someString
    /// 						# REQUIRED
    /// 						folderSize = $someInt64
    /// 						# REQUIRED
    /// 						snapshotId = $someString
    /// 						# REQUIRED
    /// 						snapshotNum = $someInt
    /// 						# OPTIONAL
    /// 						channelInfo = @{
    /// 							# REQUIRED
    /// 							TeamID = $someString
    /// 							# OPTIONAL
    /// 							ChannelID = $someString
    /// 							# OPTIONAL
    /// 							ChannelName = $someString
    /// 							# OPTIONAL
    /// 							ChannelFolderName = $someString
    /// 							# OPTIONAL
    /// 							ChannelNaturalId = $someString
    /// 							# REQUIRED
    /// 							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 						}
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				fileItems = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						fileId = $someString
    /// 						# REQUIRED
    /// 						fileName = $someString
    /// 						# REQUIRED
    /// 						fileSnapshotsToRestore = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								snapshotId = $someString
    /// 								# REQUIRED
    /// 								snapshotNum = $someInt
    /// 								# REQUIRED
    /// 								fileSize = $someInt64
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						channelInfo = @{
    /// 							# REQUIRED
    /// 							TeamID = $someString
    /// 							# OPTIONAL
    /// 							ChannelID = $someString
    /// 							# OPTIONAL
    /// 							ChannelName = $someString
    /// 							# OPTIONAL
    /// 							ChannelFolderName = $someString
    /// 							# OPTIONAL
    /// 							ChannelNaturalId = $someString
    /// 							# REQUIRED
    /// 							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 						}
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				arePageLibraryItems = $someBoolean
    /// 			}
    /// 			# OPTIONAL
    /// 			targetObjectUuid = $someString
    /// 			# OPTIONAL
    /// 			targetObjectType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
    /// 			# REQUIRED
    /// 			shouldCreateNewObject = $someBoolean
    /// 			# OPTIONAL
    /// 			newObjectType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
    /// 			# OPTIONAL
    /// 			newObjectName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		OneDriveRestoreConfig = @{
    /// 			# REQUIRED
    /// 			filesToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					fileId = $someString
    /// 					# REQUIRED
    /// 					fileName = $someString
    /// 					# REQUIRED
    /// 					fileSnapshotsToRestore = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							snapshotId = $someString
    /// 							# REQUIRED
    /// 							snapshotNum = $someInt
    /// 							# REQUIRED
    /// 							fileSize = $someInt64
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					channelInfo = @{
    /// 						# REQUIRED
    /// 						TeamID = $someString
    /// 						# OPTIONAL
    /// 						ChannelID = $someString
    /// 						# OPTIONAL
    /// 						ChannelName = $someString
    /// 						# OPTIONAL
    /// 						ChannelFolderName = $someString
    /// 						# OPTIONAL
    /// 						ChannelNaturalId = $someString
    /// 						# REQUIRED
    /// 						channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 					}
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			foldersToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					folderId = $someString
    /// 					# REQUIRED
    /// 					folderName = $someString
    /// 					# REQUIRED
    /// 					folderSize = $someInt64
    /// 					# REQUIRED
    /// 					snapshotId = $someString
    /// 					# REQUIRED
    /// 					snapshotNum = $someInt
    /// 					# OPTIONAL
    /// 					channelInfo = @{
    /// 						# REQUIRED
    /// 						TeamID = $someString
    /// 						# OPTIONAL
    /// 						ChannelID = $someString
    /// 						# OPTIONAL
    /// 						ChannelName = $someString
    /// 						# OPTIONAL
    /// 						ChannelFolderName = $someString
    /// 						# OPTIONAL
    /// 						ChannelNaturalId = $someString
    /// 						# REQUIRED
    /// 						channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 					}
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			restoreFolderPath = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		TeamsRestoreConfig = @{
    /// 			# OPTIONAL
    /// 			filesRestoreConfig = @{
    /// 				# REQUIRED
    /// 				filesToRestore = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						fileId = $someString
    /// 						# REQUIRED
    /// 						fileName = $someString
    /// 						# REQUIRED
    /// 						fileSnapshotsToRestore = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								snapshotId = $someString
    /// 								# REQUIRED
    /// 								snapshotNum = $someInt
    /// 								# REQUIRED
    /// 								fileSize = $someInt64
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						channelInfo = @{
    /// 							# REQUIRED
    /// 							TeamID = $someString
    /// 							# OPTIONAL
    /// 							ChannelID = $someString
    /// 							# OPTIONAL
    /// 							ChannelName = $someString
    /// 							# OPTIONAL
    /// 							ChannelFolderName = $someString
    /// 							# OPTIONAL
    /// 							ChannelNaturalId = $someString
    /// 							# REQUIRED
    /// 							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 						}
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				foldersToRestore = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						folderId = $someString
    /// 						# REQUIRED
    /// 						folderName = $someString
    /// 						# REQUIRED
    /// 						folderSize = $someInt64
    /// 						# REQUIRED
    /// 						snapshotId = $someString
    /// 						# REQUIRED
    /// 						snapshotNum = $someInt
    /// 						# OPTIONAL
    /// 						channelInfo = @{
    /// 							# REQUIRED
    /// 							TeamID = $someString
    /// 							# OPTIONAL
    /// 							ChannelID = $someString
    /// 							# OPTIONAL
    /// 							ChannelName = $someString
    /// 							# OPTIONAL
    /// 							ChannelFolderName = $someString
    /// 							# OPTIONAL
    /// 							ChannelNaturalId = $someString
    /// 							# REQUIRED
    /// 							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 						}
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				restoreFolderPath = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			conversationsRestoreConfig = @{
    /// 				# OPTIONAL
    /// 				SearchFilter = @{
    /// 					# OPTIONAL
    /// 					PostedTime = @{
    /// 						# OPTIONAL
    /// 						FromTime = $someInt64
    /// 						# OPTIONAL
    /// 						UntilTime = $someInt64
    /// 					}
    /// 					# OPTIONAL
    /// 					PostedBy = $someString
    /// 					# OPTIONAL
    /// 					SnapshotId = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				ChannelInfoForFullRestore = @{
    /// 					# REQUIRED
    /// 					TeamID = $someString
    /// 					# OPTIONAL
    /// 					ChannelID = $someString
    /// 					# OPTIONAL
    /// 					ChannelName = $someString
    /// 					# OPTIONAL
    /// 					ChannelFolderName = $someString
    /// 					# OPTIONAL
    /// 					ChannelFolderId = $someString
    /// 					# OPTIONAL
    /// 					ChannelNaturalId = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				RefreshTokenEncrypted = $someString
    /// 				# REQUIRED
    /// 				O365AppID = $someString
    /// 				# REQUIRED
    /// 				ChannelsToRestore = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						TeamID = $someString
    /// 						# OPTIONAL
    /// 						ChannelID = $someString
    /// 						# OPTIONAL
    /// 						ChannelName = $someString
    /// 						# OPTIONAL
    /// 						ChannelFolderName = $someString
    /// 						# OPTIONAL
    /// 						ChannelFolderId = $someString
    /// 						# OPTIONAL
    /// 						ChannelNaturalId = $someString
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				ShouldRestoreFileAttachments = $someBoolean
    /// 			}
    /// 			# OPTIONAL
    /// 			destChannelInfo = @{
    /// 				# REQUIRED
    /// 				TeamID = $someString
    /// 				# OPTIONAL
    /// 				ChannelID = $someString
    /// 				# OPTIONAL
    /// 				ChannelName = $someString
    /// 				# OPTIONAL
    /// 				ChannelFolderName = $someString
    /// 				# OPTIONAL
    /// 				ChannelNaturalId = $someString
    /// 				# REQUIRED
    /// 				channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 			}
    /// 			# REQUIRED
    /// 			shouldCreateDestChannel = $someBoolean
    /// 			# REQUIRED
    /// 			channelType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 			# REQUIRED
    /// 			restoreLatestPermissions = $someBoolean
    /// 			# REQUIRED
    /// 			snapshotSequenceNum = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		MailboxRestoreConfig = @{
    /// 			# OPTIONAL
    /// 			SnapshotUUID = $someString
    /// 			# REQUIRED
    /// 			RestoreConfigs = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					SnapshotUUID = $someString
    /// 					# OPTIONAL
    /// 					EmailID = $someString
    /// 					# OPTIONAL
    /// 					FolderID = $someString
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			skipRifItems = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		calendarRestoreConfig = @{
    /// 			# REQUIRED
    /// 			eventsToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					eventId = $someString
    /// 					# REQUIRED
    /// 					snapshotId = $someString
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			calendarsToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					calendarId = $someString
    /// 					# REQUIRED
    /// 					snapshotId = $someString
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			calendarGroupsToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					calendarGroupId = $someString
    /// 					# REQUIRED
    /// 					snapshotId = $someString
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			skipRifItems = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		contactsRestoreConfig = @{
    /// 			# REQUIRED
    /// 			contactsToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					contactId = $someString
    /// 					# REQUIRED
    /// 					snapshotId = $someString
    /// 					# REQUIRED
    /// 					snapshotNum = $someInt
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			contactFoldersToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					contactFolderId = $someString
    /// 					# REQUIRED
    /// 					snapshotId = $someString
    /// 					# REQUIRED
    /// 					snapshotNum = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			skipRifItems = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		inplaceRestoreConfig = @{
    /// 			# REQUIRED
    /// 			nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		failedItemsRecoveryConfig = @{
    /// 			# REQUIRED
    /// 			failedItemsInstanceId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		relicRestoreConfig = @{
    /// 			# OPTIONAL
    /// 			unused = $someBoolean
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreTeamsConversations operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: RestoreTeamsConversations
    /// 
    /// $query = New-RscMutationO365 -RestoreTeamsConversations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	teamUuid = $someString
    /// 	# OPTIONAL
    /// 	destTeamsChannelInfo = @{
    /// 		# REQUIRED
    /// 		TeamID = $someString
    /// 		# OPTIONAL
    /// 		ChannelID = $someString
    /// 		# OPTIONAL
    /// 		ChannelName = $someString
    /// 		# OPTIONAL
    /// 		ChannelFolderName = $someString
    /// 		# OPTIONAL
    /// 		ChannelNaturalId = $someString
    /// 		# REQUIRED
    /// 		channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	shouldCreateDestChannel = $someBoolean
    /// 	# OPTIONAL
    /// 	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
    /// 	# OPTIONAL
    /// 	inplaceRestoreConfig = @{
    /// 		# REQUIRED
    /// 		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	channelInfoForFullRestore = @{
    /// 		# REQUIRED
    /// 		naturalId = $someString
    /// 		# OPTIONAL
    /// 		channelId = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		folderId = $someString
    /// 		# REQUIRED
    /// 		membershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	shouldRestoreFileAttachments = $someBoolean
    /// 	# REQUIRED
    /// 	teamChannels = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			naturalId = $someString
    /// 			# OPTIONAL
    /// 			channelId = $someString
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			folderId = $someString
    /// 			# REQUIRED
    /// 			membershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	teamsConversationsSearchFilter = @{
    /// 		# OPTIONAL
    /// 		postedTime = @{
    /// 			# OPTIONAL
    /// 			fromTime = $someDateTime
    /// 			# OPTIONAL
    /// 			untilTime = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		channelNaturalId = $someString
    /// 		# OPTIONAL
    /// 		postedBy = $someString
    /// 		# OPTIONAL
    /// 		snapshotId = $someString
    /// 		# OPTIONAL
    /// 		parentId = $someString
    /// 		# OPTIONAL
    /// 		convId = $someString
    /// 		# OPTIONAL
    /// 		snapshotNum = $someInt
    /// 		# OPTIONAL
    /// 		includeArchived = $someBoolean
    /// 		# OPTIONAL
    /// 		fetchAllPostSenders = $someString
    /// 		# OPTIONAL
    /// 		skipPostsAttachments = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	refreshTokenEncrypted = $someString
    /// 	# REQUIRED
    /// 	o365AppId = $someString
    /// 	# REQUIRED
    /// 	channelRecoveryType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 	# REQUIRED
    /// 	recoverWithLatestPermissions = $someBoolean
    /// 	# REQUIRED
    /// 	snapshotSequenceNum = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreTeamsFiles operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: RestoreTeamsFiles
    /// 
    /// $query = New-RscMutationO365 -RestoreTeamsFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	filesToRestore = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			fileId = $someString
    /// 			# REQUIRED
    /// 			fileName = $someString
    /// 			# REQUIRED
    /// 			fileSnapshotsToRestore = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					snapshotId = $someString
    /// 					# REQUIRED
    /// 					snapshotNum = $someInt
    /// 					# REQUIRED
    /// 					fileSize = $someInt64
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			channelInfo = @{
    /// 				# REQUIRED
    /// 				TeamID = $someString
    /// 				# OPTIONAL
    /// 				ChannelID = $someString
    /// 				# OPTIONAL
    /// 				ChannelName = $someString
    /// 				# OPTIONAL
    /// 				ChannelFolderName = $someString
    /// 				# OPTIONAL
    /// 				ChannelNaturalId = $someString
    /// 				# REQUIRED
    /// 				channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 			}
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	foldersToRestore = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			folderId = $someString
    /// 			# REQUIRED
    /// 			folderName = $someString
    /// 			# REQUIRED
    /// 			folderSize = $someInt64
    /// 			# REQUIRED
    /// 			snapshotId = $someString
    /// 			# REQUIRED
    /// 			snapshotNum = $someInt
    /// 			# OPTIONAL
    /// 			channelInfo = @{
    /// 				# REQUIRED
    /// 				TeamID = $someString
    /// 				# OPTIONAL
    /// 				ChannelID = $someString
    /// 				# OPTIONAL
    /// 				ChannelName = $someString
    /// 				# OPTIONAL
    /// 				ChannelFolderName = $someString
    /// 				# OPTIONAL
    /// 				ChannelNaturalId = $someString
    /// 				# REQUIRED
    /// 				channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	destTeamsChannelInfo = @{
    /// 		# REQUIRED
    /// 		TeamID = $someString
    /// 		# OPTIONAL
    /// 		ChannelID = $someString
    /// 		# OPTIONAL
    /// 		ChannelName = $someString
    /// 		# OPTIONAL
    /// 		ChannelFolderName = $someString
    /// 		# OPTIONAL
    /// 		ChannelNaturalId = $someString
    /// 		# REQUIRED
    /// 		channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	shouldCreateDestChannel = $someBoolean
    /// 	# REQUIRED
    /// 	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
    /// 	# OPTIONAL
    /// 	inplaceRestoreConfig = @{
    /// 		# REQUIRED
    /// 		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	channelRecoveryType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 	# REQUIRED
    /// 	recoverWithLatestPermissions = $someBoolean
    /// 	# REQUIRED
    /// 	snapshotSequenceNum = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SaaSSetupKickoff operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: SaaSSetupKickoff
    /// 
    /// $query = New-RscMutationO365 -SaaSSetupKickoff
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365SaasSetupKickoffReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SaasSetupComplete operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: SaasSetupComplete
    /// 
    /// $query = New-RscMutationO365 -SaasSetupComplete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tenantId = $someString
    /// 	# REQUIRED
    /// 	regionName = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// 	# REQUIRED
    /// 	appTypes = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	kmsSpec = @{
    /// 		# OPTIONAL
    /// 		cloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
    /// 		# OPTIONAL
    /// 		tenantId = $someString
    /// 		# OPTIONAL
    /// 		kmsId = $someString
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecret = $someString
    /// 		# OPTIONAL
    /// 		keyName = $someString
    /// 		# OPTIONAL
    /// 		kekNameColossus = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	storeBackupInSameRegionAsData = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddO365OrgResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetServiceAccount operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: SetServiceAccount
    /// 
    /// $query = New-RscMutationO365 -SetServiceAccount
    /// 
    /// # REQUIRED
    /// $query.Var.username = $someString
    /// # REQUIRED
    /// $query.Var.appPassword = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetupKickoff operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: SetupKickoff
    /// 
    /// $query = New-RscMutationO365 -SetupKickoff
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365SetupKickoffResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAppAuthStatus operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: UpdateAppAuthStatus
    /// 
    /// $query = New-RscMutationO365 -UpdateAppAuthStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	o365OrgId = $someString
    /// 	# REQUIRED
    /// 	o365AppId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateO365AppAuthStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAppPermissions operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: UpdateAppPermissions
    /// 
    /// $query = New-RscMutationO365 -UpdateAppPermissions
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	o365AppType = $someO365AppType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AppType]) for enum values.
    /// 	# REQUIRED
    /// 	o365AppId = $someString
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
    /// Runs the UpdateOrgCustomName operation
    /// of the 'Office 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    O365
    /// # API Operation: UpdateOrgCustomName
    /// 
    /// $query = New-RscMutationO365 -UpdateOrgCustomName
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgUuid = $someString
    /// 	# REQUIRED
    /// 	customName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateO365OrgCustomNameReply
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
        "RscMutationO365",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationO365 : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddOrg",
                "BackupMailbox",
                "BackupOnedrive",
                "BackupSharePointSite",
                "BackupSharepointDrive",
                "BackupSharepointList",
                "BackupTeam",
                "CreateAppComplete",
                "CreateAppKickoff",
                "DeleteAzureApp",
                "DeleteOrg",
                "DeleteServiceAccount",
                "EnableSharePoint",
                "EnableTeams",
                "ExportMailbox",
                "ExportMailboxV2",
                "InsertCustomerApp",
                "OauthConsentComplete",
                "OauthConsentKickoff",
                "PdlGroups",
                "RefreshOrg",
                "RestoreMailbox",
                "RestoreMailboxV2",
                "RestoreSnappable",
                "RestoreTeamsConversations",
                "RestoreTeamsFiles",
                "SaaSSetupKickoff",
                "SaasSetupComplete",
                "SetServiceAccount",
                "SetupKickoff",
                "UpdateAppAuthStatus",
                "UpdateAppPermissions",
                "UpdateOrgCustomName",
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
                    case "AddOrg":
                        this.ProcessRecord_AddOrg();
                        break;
                    case "BackupMailbox":
                        this.ProcessRecord_BackupMailbox();
                        break;
                    case "BackupOnedrive":
                        this.ProcessRecord_BackupOnedrive();
                        break;
                    case "BackupSharePointSite":
                        this.ProcessRecord_BackupSharePointSite();
                        break;
                    case "BackupSharepointDrive":
                        this.ProcessRecord_BackupSharepointDrive();
                        break;
                    case "BackupSharepointList":
                        this.ProcessRecord_BackupSharepointList();
                        break;
                    case "BackupTeam":
                        this.ProcessRecord_BackupTeam();
                        break;
                    case "CreateAppComplete":
                        this.ProcessRecord_CreateAppComplete();
                        break;
                    case "CreateAppKickoff":
                        this.ProcessRecord_CreateAppKickoff();
                        break;
                    case "DeleteAzureApp":
                        this.ProcessRecord_DeleteAzureApp();
                        break;
                    case "DeleteOrg":
                        this.ProcessRecord_DeleteOrg();
                        break;
                    case "DeleteServiceAccount":
                        this.ProcessRecord_DeleteServiceAccount();
                        break;
                    case "EnableSharePoint":
                        this.ProcessRecord_EnableSharePoint();
                        break;
                    case "EnableTeams":
                        this.ProcessRecord_EnableTeams();
                        break;
                    case "ExportMailbox":
                        this.ProcessRecord_ExportMailbox();
                        break;
                    case "ExportMailboxV2":
                        this.ProcessRecord_ExportMailboxV2();
                        break;
                    case "InsertCustomerApp":
                        this.ProcessRecord_InsertCustomerApp();
                        break;
                    case "OauthConsentComplete":
                        this.ProcessRecord_OauthConsentComplete();
                        break;
                    case "OauthConsentKickoff":
                        this.ProcessRecord_OauthConsentKickoff();
                        break;
                    case "PdlGroups":
                        this.ProcessRecord_PdlGroups();
                        break;
                    case "RefreshOrg":
                        this.ProcessRecord_RefreshOrg();
                        break;
                    case "RestoreMailbox":
                        this.ProcessRecord_RestoreMailbox();
                        break;
                    case "RestoreMailboxV2":
                        this.ProcessRecord_RestoreMailboxV2();
                        break;
                    case "RestoreSnappable":
                        this.ProcessRecord_RestoreSnappable();
                        break;
                    case "RestoreTeamsConversations":
                        this.ProcessRecord_RestoreTeamsConversations();
                        break;
                    case "RestoreTeamsFiles":
                        this.ProcessRecord_RestoreTeamsFiles();
                        break;
                    case "SaaSSetupKickoff":
                        this.ProcessRecord_SaaSSetupKickoff();
                        break;
                    case "SaasSetupComplete":
                        this.ProcessRecord_SaasSetupComplete();
                        break;
                    case "SetServiceAccount":
                        this.ProcessRecord_SetServiceAccount();
                        break;
                    case "SetupKickoff":
                        this.ProcessRecord_SetupKickoff();
                        break;
                    case "UpdateAppAuthStatus":
                        this.ProcessRecord_UpdateAppAuthStatus();
                        break;
                    case "UpdateAppPermissions":
                        this.ProcessRecord_UpdateAppPermissions();
                        break;
                    case "UpdateOrgCustomName":
                        this.ProcessRecord_UpdateOrgCustomName();
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
        // addO365Org.
        internal void ProcessRecord_AddOrg()
        {
            this._logger.name += " -AddOrg";
            // Create new graphql operation addO365Org
            InitMutationAddO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Mailbox.
        internal void ProcessRecord_BackupMailbox()
        {
            this._logger.name += " -BackupMailbox";
            // Create new graphql operation backupO365Mailbox
            InitMutationBackupO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Onedrive.
        internal void ProcessRecord_BackupOnedrive()
        {
            this._logger.name += " -BackupOnedrive";
            // Create new graphql operation backupO365Onedrive
            InitMutationBackupO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharePointSite.
        internal void ProcessRecord_BackupSharePointSite()
        {
            this._logger.name += " -BackupSharePointSite";
            // Create new graphql operation backupO365SharePointSite
            InitMutationBackupO365SharePointSite();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointDrive.
        internal void ProcessRecord_BackupSharepointDrive()
        {
            this._logger.name += " -BackupSharepointDrive";
            // Create new graphql operation backupO365SharepointDrive
            InitMutationBackupO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointList.
        internal void ProcessRecord_BackupSharepointList()
        {
            this._logger.name += " -BackupSharepointList";
            // Create new graphql operation backupO365SharepointList
            InitMutationBackupO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Team.
        internal void ProcessRecord_BackupTeam()
        {
            this._logger.name += " -BackupTeam";
            // Create new graphql operation backupO365Team
            InitMutationBackupO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppComplete.
        internal void ProcessRecord_CreateAppComplete()
        {
            this._logger.name += " -CreateAppComplete";
            // Create new graphql operation createO365AppComplete
            InitMutationCreateO365AppComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppKickoff.
        internal void ProcessRecord_CreateAppKickoff()
        {
            this._logger.name += " -CreateAppKickoff";
            // Create new graphql operation createO365AppKickoff
            InitMutationCreateO365AppKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365AzureApp.
        internal void ProcessRecord_DeleteAzureApp()
        {
            this._logger.name += " -DeleteAzureApp";
            // Create new graphql operation deleteO365AzureApp
            InitMutationDeleteO365AzureApp();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365Org.
        internal void ProcessRecord_DeleteOrg()
        {
            this._logger.name += " -DeleteOrg";
            // Create new graphql operation deleteO365Org
            InitMutationDeleteO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365ServiceAccount.
        internal void ProcessRecord_DeleteServiceAccount()
        {
            this._logger.name += " -DeleteServiceAccount";
            // Create new graphql operation deleteO365ServiceAccount
            InitMutationDeleteO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365SharePoint.
        internal void ProcessRecord_EnableSharePoint()
        {
            this._logger.name += " -EnableSharePoint";
            // Create new graphql operation enableO365SharePoint
            InitMutationEnableO365SharePoint();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365Teams.
        internal void ProcessRecord_EnableTeams()
        {
            this._logger.name += " -EnableTeams";
            // Create new graphql operation enableO365Teams
            InitMutationEnableO365Teams();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365Mailbox.
        internal void ProcessRecord_ExportMailbox()
        {
            this._logger.name += " -ExportMailbox";
            // Create new graphql operation exportO365Mailbox
            InitMutationExportO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365MailboxV2.
        internal void ProcessRecord_ExportMailboxV2()
        {
            this._logger.name += " -ExportMailboxV2";
            // Create new graphql operation exportO365MailboxV2
            InitMutationExportO365MailboxV2();
        }

        // This parameter set invokes a single graphql operation:
        // insertCustomerO365App.
        internal void ProcessRecord_InsertCustomerApp()
        {
            this._logger.name += " -InsertCustomerApp";
            // Create new graphql operation insertCustomerO365App
            InitMutationInsertCustomerO365App();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentComplete.
        internal void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Create new graphql operation o365OauthConsentComplete
            InitMutationO365OauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentKickoff.
        internal void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Create new graphql operation o365OauthConsentKickoff
            InitMutationO365OauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365PdlGroups.
        internal void ProcessRecord_PdlGroups()
        {
            this._logger.name += " -PdlGroups";
            // Create new graphql operation o365PdlGroups
            InitMutationO365PdlGroups();
        }

        // This parameter set invokes a single graphql operation:
        // refreshO365Org.
        internal void ProcessRecord_RefreshOrg()
        {
            this._logger.name += " -RefreshOrg";
            // Create new graphql operation refreshO365Org
            InitMutationRefreshO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Mailbox.
        internal void ProcessRecord_RestoreMailbox()
        {
            this._logger.name += " -RestoreMailbox";
            // Create new graphql operation restoreO365Mailbox
            InitMutationRestoreO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365MailboxV2.
        internal void ProcessRecord_RestoreMailboxV2()
        {
            this._logger.name += " -RestoreMailboxV2";
            // Create new graphql operation restoreO365MailboxV2
            InitMutationRestoreO365MailboxV2();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Snappable.
        internal void ProcessRecord_RestoreSnappable()
        {
            this._logger.name += " -RestoreSnappable";
            // Create new graphql operation restoreO365Snappable
            InitMutationRestoreO365Snappable();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsConversations.
        internal void ProcessRecord_RestoreTeamsConversations()
        {
            this._logger.name += " -RestoreTeamsConversations";
            // Create new graphql operation restoreO365TeamsConversations
            InitMutationRestoreO365TeamsConversations();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsFiles.
        internal void ProcessRecord_RestoreTeamsFiles()
        {
            this._logger.name += " -RestoreTeamsFiles";
            // Create new graphql operation restoreO365TeamsFiles
            InitMutationRestoreO365TeamsFiles();
        }

        // This parameter set invokes a single graphql operation:
        // o365SaaSSetupKickoff.
        internal void ProcessRecord_SaaSSetupKickoff()
        {
            this._logger.name += " -SaaSSetupKickoff";
            // Create new graphql operation o365SaaSSetupKickoff
            InitMutationO365SaaSsetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365SaasSetupComplete.
        internal void ProcessRecord_SaasSetupComplete()
        {
            this._logger.name += " -SaasSetupComplete";
            // Create new graphql operation o365SaasSetupComplete
            InitMutationO365SaasSetupComplete();
        }

        // This parameter set invokes a single graphql operation:
        // setO365ServiceAccount.
        internal void ProcessRecord_SetServiceAccount()
        {
            this._logger.name += " -SetServiceAccount";
            // Create new graphql operation setO365ServiceAccount
            InitMutationSetO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // o365SetupKickoff.
        internal void ProcessRecord_SetupKickoff()
        {
            this._logger.name += " -SetupKickoff";
            // Create new graphql operation o365SetupKickoff
            InitMutationO365SetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppAuthStatus.
        internal void ProcessRecord_UpdateAppAuthStatus()
        {
            this._logger.name += " -UpdateAppAuthStatus";
            // Create new graphql operation updateO365AppAuthStatus
            InitMutationUpdateO365AppAuthStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppPermissions.
        internal void ProcessRecord_UpdateAppPermissions()
        {
            this._logger.name += " -UpdateAppPermissions";
            // Create new graphql operation updateO365AppPermissions
            InitMutationUpdateO365AppPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365OrgCustomName.
        internal void ProcessRecord_UpdateOrgCustomName()
        {
            this._logger.name += " -UpdateOrgCustomName";
            // Create new graphql operation updateO365OrgCustomName
            InitMutationUpdateO365OrgCustomName();
        }


        // Create new GraphQL Mutation:
        // addO365Org(input: AddO365OrgInput!): AddO365OrgResponse!
        internal void InitMutationAddO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddO365OrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddO365Org",
                "($input: AddO365OrgInput!)",
                "AddO365OrgResponse",
                Mutation.AddO365Org,
                Mutation.AddO365OrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tenantId = $someString
	# REQUIRED
	stateToken = $someString
	# REQUIRED
	exocomputeClusterId = $someString
	# REQUIRED
	appTypes = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365Mailbox(mailboxIds: [UUID!]!): BatchAsyncJobStatus!
        internal void InitMutationBackupO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("mailboxIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Mailbox",
                "($mailboxIds: [UUID!]!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365Mailbox,
                Mutation.BackupO365MailboxFieldSpec,
                @"# REQUIRED
$query.Var.mailboxIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365Onedrive(input: BackupO365OnedriveInput!): BatchAsyncJobStatus!
        internal void InitMutationBackupO365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365OnedriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Onedrive",
                "($input: BackupO365OnedriveInput!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365Onedrive,
                Mutation.BackupO365OnedriveFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
        internal void InitMutationBackupO365SharePointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointSiteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharePointSite",
                "($input: BackupO365SharePointSiteInput!)",
                "CreateOnDemandJobReply",
                Mutation.BackupO365SharePointSite,
                Mutation.BackupO365SharePointSiteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	siteFid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365SharepointDrive(input: BackupO365SharepointDriveInput!): BatchAsyncJobStatus!
        internal void InitMutationBackupO365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharepointDriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharepointDrive",
                "($input: BackupO365SharepointDriveInput!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365SharepointDrive,
                Mutation.BackupO365SharepointDriveFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365SharepointList(input: BackupO365SharePointListInput!): CreateOnDemandJobReply!
        internal void InitMutationBackupO365SharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointListInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharepointList",
                "($input: BackupO365SharePointListInput!)",
                "CreateOnDemandJobReply",
                Mutation.BackupO365SharepointList,
                Mutation.BackupO365SharepointListFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snappableUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365Team(input: BackupO365TeamInput!): BatchAsyncJobStatus!
        internal void InitMutationBackupO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365TeamInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Team",
                "($input: BackupO365TeamInput!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365Team,
                Mutation.BackupO365TeamFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createO365AppComplete(input: CreateO365AppCompleteInput!): RequestStatus!
        internal void InitMutationCreateO365AppComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateO365AppComplete",
                "($input: CreateO365AppCompleteInput!)",
                "RequestStatus",
                Mutation.CreateO365AppComplete,
                Mutation.CreateO365AppCompleteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	appClientId = $someString
	# REQUIRED
	stateToken = $someString
	# REQUIRED
	tenantId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createO365AppKickoff(input: CreateO365AppKickoffInput!): CreateO365AppKickoffResp!
        internal void InitMutationCreateO365AppKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppKickoffInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateO365AppKickoff",
                "($input: CreateO365AppKickoffInput!)",
                "CreateO365AppKickoffResp",
                Mutation.CreateO365AppKickoff,
                Mutation.CreateO365AppKickoffFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	appType = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!): RequestStatus!
        internal void InitMutationDeleteO365AzureApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("o365AppClientId", "String!"),
                Tuple.Create("o365AppType", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365AzureApp",
                "($o365AppClientId: String!,$o365AppType: String!)",
                "RequestStatus",
                Mutation.DeleteO365AzureApp,
                Mutation.DeleteO365AzureAppFieldSpec,
                @"# REQUIRED
$query.Var.o365AppClientId = $someString
# REQUIRED
$query.Var.o365AppType = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteO365Org(orgId: UUID!): CreateOnDemandJobReply!
        internal void InitMutationDeleteO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365Org",
                "($orgId: UUID!)",
                "CreateOnDemandJobReply",
                Mutation.DeleteO365Org,
                Mutation.DeleteO365OrgFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteO365ServiceAccount(orgId: UUID!): RequestStatus!
        internal void InitMutationDeleteO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365ServiceAccount",
                "($orgId: UUID!)",
                "RequestStatus",
                Mutation.DeleteO365ServiceAccount,
                Mutation.DeleteO365ServiceAccountFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // enableO365SharePoint(input: EnableO365SharePointInput!): RequestStatus!
        internal void InitMutationEnableO365SharePoint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableO365SharePointInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableO365SharePoint",
                "($input: EnableO365SharePointInput!)",
                "RequestStatus",
                Mutation.EnableO365SharePoint,
                Mutation.EnableO365SharePointFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	exocomputeClusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableO365Teams(exocomputeClusterId: String!): RequestStatus!
        internal void InitMutationEnableO365Teams()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableO365Teams",
                "($exocomputeClusterId: String!)",
                "RequestStatus",
                Mutation.EnableO365Teams,
                Mutation.EnableO365TeamsFieldSpec,
                @"# REQUIRED
$query.Var.exocomputeClusterId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // exportO365Mailbox(exportConfig: ExportO365MailboxInput!): CreateOnDemandJobReply!
        internal void InitMutationExportO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exportConfig", "ExportO365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportO365Mailbox",
                "($exportConfig: ExportO365MailboxInput!)",
                "CreateOnDemandJobReply",
                Mutation.ExportO365Mailbox,
                Mutation.ExportO365MailboxFieldSpec,
                @"# REQUIRED
$query.Var.exportConfig = @{
	# OPTIONAL
	orgUuid = $someString
	# REQUIRED
	fromMailboxUuid = $someString
	# REQUIRED
	toMailboxUuid = $someString
	# OPTIONAL
	snapshotUuid = $someString
	# REQUIRED
	exportConfigs = @(
		@{
			# REQUIRED
			SnapshotUUID = $someString
			# OPTIONAL
			EmailID = $someString
			# OPTIONAL
			FolderID = $someString
		}
	)
	# OPTIONAL
	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
	# OPTIONAL
	inplaceRestoreConfig = @{
		# REQUIRED
		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
	}
	# OPTIONAL
	skipRifItems = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportO365MailboxV2(input: ExportO365MailboxInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationExportO365MailboxV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportO365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportO365MailboxV2",
                "($input: ExportO365MailboxInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.ExportO365MailboxV2,
                Mutation.ExportO365MailboxV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	orgUuid = $someString
	# REQUIRED
	fromMailboxUuid = $someString
	# REQUIRED
	toMailboxUuid = $someString
	# OPTIONAL
	snapshotUuid = $someString
	# REQUIRED
	exportConfigs = @(
		@{
			# REQUIRED
			SnapshotUUID = $someString
			# OPTIONAL
			EmailID = $someString
			# OPTIONAL
			FolderID = $someString
		}
	)
	# OPTIONAL
	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
	# OPTIONAL
	inplaceRestoreConfig = @{
		# REQUIRED
		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
	}
	# OPTIONAL
	skipRifItems = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // insertCustomerO365App(input: InsertCustomerO365AppInput!): RequestStatus!
        internal void InitMutationInsertCustomerO365App()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InsertCustomerO365AppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInsertCustomerO365App",
                "($input: InsertCustomerO365AppInput!)",
                "RequestStatus",
                Mutation.InsertCustomerO365App,
                Mutation.InsertCustomerO365AppFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	appType = $someString
	# REQUIRED
	appClientId = $someString
	# REQUIRED
	appClientSecret = $someString
	# REQUIRED
	subscriptionId = $someString
	# OPTIONAL
	base64AppCertificate = $someString
	# OPTIONAL
	base64AppPrivateKey = $someString
	# OPTIONAL
	updateAppCredentials = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // o365OauthConsentComplete(input: O365OauthConsentCompleteInput!): O365OauthConsentCompleteReply!
        internal void InitMutationO365OauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365OauthConsentComplete",
                "($input: O365OauthConsentCompleteInput!)",
                "O365OauthConsentCompleteReply",
                Mutation.O365OauthConsentComplete,
                Mutation.O365OauthConsentCompleteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tenantId = $someString
	# REQUIRED
	code = $someString
	# REQUIRED
	stateToken = $someString
	# REQUIRED
	redirectUrl = $someString
	# REQUIRED
	resourceNaturalId = $someString
	# OPTIONAL
	resourceId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!): O365OauthConsentKickoffReply!
        internal void InitMutationO365OauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentKickoffInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365OauthConsentKickoff",
                "($input: O365OauthConsentKickoffInput!)",
                "O365OauthConsentKickoffReply",
                Mutation.O365OauthConsentKickoff,
                Mutation.O365OauthConsentKickoffFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	appType = $someString
	# OPTIONAL
	resourceId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // o365PdlGroups(input: O365PdlGroupsInput!): O365PdlGroupsReply!
        internal void InitMutationO365PdlGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365PdlGroupsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365PdlGroups",
                "($input: O365PdlGroupsInput!)",
                "O365PdlGroupsReply",
                Mutation.O365PdlGroups,
                Mutation.O365PdlGroupsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	pdlAndWorkloadPairs = @(
		@{
			# REQUIRED
			pdl = $someString
			# REQUIRED
			workload = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshO365Org(orgId: UUID!): CreateOnDemandJobReply!
        internal void InitMutationRefreshO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshO365Org",
                "($orgId: UUID!)",
                "CreateOnDemandJobReply",
                Mutation.RefreshO365Org,
                Mutation.RefreshO365OrgFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("restoreConfig", "RestoreO365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365Mailbox",
                "($restoreConfig: RestoreO365MailboxInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365Mailbox,
                Mutation.RestoreO365MailboxFieldSpec,
                @"# REQUIRED
$query.Var.restoreConfig = @{
	# OPTIONAL
	orgUuid = $someString
	# REQUIRED
	mailboxUuid = $someString
	# OPTIONAL
	snapshotUuid = $someString
	# REQUIRED
	restoreConfigs = @(
		@{
			# REQUIRED
			SnapshotUUID = $someString
			# OPTIONAL
			EmailID = $someString
			# OPTIONAL
			FolderID = $someString
		}
	)
	# REQUIRED
	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
	# OPTIONAL
	inplaceRestoreConfig = @{
		# REQUIRED
		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
	}
	# OPTIONAL
	skipRifItems = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365MailboxV2(input: RestoreO365MailboxInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationRestoreO365MailboxV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365MailboxV2",
                "($input: RestoreO365MailboxInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.RestoreO365MailboxV2,
                Mutation.RestoreO365MailboxV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	orgUuid = $someString
	# REQUIRED
	mailboxUuid = $someString
	# OPTIONAL
	snapshotUuid = $someString
	# REQUIRED
	restoreConfigs = @(
		@{
			# REQUIRED
			SnapshotUUID = $someString
			# OPTIONAL
			EmailID = $someString
			# OPTIONAL
			FolderID = $someString
		}
	)
	# REQUIRED
	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
	# OPTIONAL
	inplaceRestoreConfig = @{
		# REQUIRED
		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
	}
	# OPTIONAL
	skipRifItems = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365Snappable(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreO365Snappable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365Snappable",
                "($input: RestoreO365SnappableInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365Snappable,
                Mutation.RestoreO365SnappableFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snappableType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
	# REQUIRED
	sourceSnappableUuid = $someString
	# REQUIRED
	destinationSnappableUuid = $someString
	# REQUIRED
	restoreConfig = @{
		# OPTIONAL
		destinationOrgUuid = $someString
		# OPTIONAL
		SharePointDriveRestoreConfig = @{
			# REQUIRED
			driveRestoreConfig = @{
				# REQUIRED
				filesToRestore = @(
					@{
						# REQUIRED
						fileId = $someString
						# REQUIRED
						fileName = $someString
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = $someString
								# REQUIRED
								snapshotNum = $someInt
								# REQUIRED
								fileSize = $someInt64
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = $someString
							# OPTIONAL
							ChannelID = $someString
							# OPTIONAL
							ChannelName = $someString
							# OPTIONAL
							ChannelFolderName = $someString
							# OPTIONAL
							ChannelNaturalId = $someString
							# REQUIRED
							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				foldersToRestore = @(
					@{
						# REQUIRED
						folderId = $someString
						# REQUIRED
						folderName = $someString
						# REQUIRED
						folderSize = $someInt64
						# REQUIRED
						snapshotId = $someString
						# REQUIRED
						snapshotNum = $someInt
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = $someString
							# OPTIONAL
							ChannelID = $someString
							# OPTIONAL
							ChannelName = $someString
							# OPTIONAL
							ChannelFolderName = $someString
							# OPTIONAL
							ChannelNaturalId = $someString
							# REQUIRED
							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				restoreFolderPath = $someString
			}
			# OPTIONAL
			docLibName = $someString
			# OPTIONAL
			parentSiteUuid = $someString
		}
		# OPTIONAL
		sharePointListRestoreConfig = @{
			# REQUIRED
			itemsToRestore = @(
				@{
					# REQUIRED
					itemId = $someString
					# REQUIRED
					itemName = $someString
					# REQUIRED
					itemSnapshotsToRestore = @(
						@{
							# REQUIRED
							snapshotId = $someString
							# REQUIRED
							snapshotNum = $someInt
						}
					)
				}
			)
			# REQUIRED
			foldersToRestore = @(
				@{
					# REQUIRED
					folderId = $someString
					# REQUIRED
					folderName = $someString
					# REQUIRED
					folderSize = $someInt64
					# REQUIRED
					snapshotId = $someString
					# REQUIRED
					snapshotNum = $someInt
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = $someString
						# OPTIONAL
						ChannelID = $someString
						# OPTIONAL
						ChannelName = $someString
						# OPTIONAL
						ChannelFolderName = $someString
						# OPTIONAL
						ChannelNaturalId = $someString
						# REQUIRED
						channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			restoreFolderPath = $someString
			# OPTIONAL
			listName = $someString
			# OPTIONAL
			parentSiteUuid = $someString
		}
		# OPTIONAL
		sharePointFullRestoreConfig = @{
			# OPTIONAL
			spObjectToRestore = @{
				# REQUIRED
				objectSharepointId = $someString
				# OPTIONAL
				objectId = $someString
				# REQUIRED
				objectName = $someString
				# OPTIONAL
				objectType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
				# REQUIRED
				snapshotId = $someString
				# REQUIRED
				snapshotNum = $someInt
				# OPTIONAL
				siteOwnerEmail = $someString
			}
			# OPTIONAL
			spItemsToRestore = @{
				# REQUIRED
				sharepointId = $someString
				# OPTIONAL
				objectId = $someString
				# OPTIONAL
				snappableType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
				# REQUIRED
				listItems = @(
					@{
						# REQUIRED
						itemId = $someString
						# REQUIRED
						itemName = $someString
						# REQUIRED
						itemSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = $someString
								# REQUIRED
								snapshotNum = $someInt
							}
						)
					}
				)
				# REQUIRED
				folderItems = @(
					@{
						# REQUIRED
						folderId = $someString
						# REQUIRED
						folderName = $someString
						# REQUIRED
						folderSize = $someInt64
						# REQUIRED
						snapshotId = $someString
						# REQUIRED
						snapshotNum = $someInt
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = $someString
							# OPTIONAL
							ChannelID = $someString
							# OPTIONAL
							ChannelName = $someString
							# OPTIONAL
							ChannelFolderName = $someString
							# OPTIONAL
							ChannelNaturalId = $someString
							# REQUIRED
							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				fileItems = @(
					@{
						# REQUIRED
						fileId = $someString
						# REQUIRED
						fileName = $someString
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = $someString
								# REQUIRED
								snapshotNum = $someInt
								# REQUIRED
								fileSize = $someInt64
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = $someString
							# OPTIONAL
							ChannelID = $someString
							# OPTIONAL
							ChannelName = $someString
							# OPTIONAL
							ChannelFolderName = $someString
							# OPTIONAL
							ChannelNaturalId = $someString
							# REQUIRED
							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				arePageLibraryItems = $someBoolean
			}
			# OPTIONAL
			targetObjectUuid = $someString
			# OPTIONAL
			targetObjectType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
			# REQUIRED
			shouldCreateNewObject = $someBoolean
			# OPTIONAL
			newObjectType = $someSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
			# OPTIONAL
			newObjectName = $someString
		}
		# OPTIONAL
		OneDriveRestoreConfig = @{
			# REQUIRED
			filesToRestore = @(
				@{
					# REQUIRED
					fileId = $someString
					# REQUIRED
					fileName = $someString
					# REQUIRED
					fileSnapshotsToRestore = @(
						@{
							# REQUIRED
							snapshotId = $someString
							# REQUIRED
							snapshotNum = $someInt
							# REQUIRED
							fileSize = $someInt64
						}
					)
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = $someString
						# OPTIONAL
						ChannelID = $someString
						# OPTIONAL
						ChannelName = $someString
						# OPTIONAL
						ChannelFolderName = $someString
						# OPTIONAL
						ChannelNaturalId = $someString
						# REQUIRED
						channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			foldersToRestore = @(
				@{
					# REQUIRED
					folderId = $someString
					# REQUIRED
					folderName = $someString
					# REQUIRED
					folderSize = $someInt64
					# REQUIRED
					snapshotId = $someString
					# REQUIRED
					snapshotNum = $someInt
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = $someString
						# OPTIONAL
						ChannelID = $someString
						# OPTIONAL
						ChannelName = $someString
						# OPTIONAL
						ChannelFolderName = $someString
						# OPTIONAL
						ChannelNaturalId = $someString
						# REQUIRED
						channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			restoreFolderPath = $someString
		}
		# OPTIONAL
		TeamsRestoreConfig = @{
			# OPTIONAL
			filesRestoreConfig = @{
				# REQUIRED
				filesToRestore = @(
					@{
						# REQUIRED
						fileId = $someString
						# REQUIRED
						fileName = $someString
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = $someString
								# REQUIRED
								snapshotNum = $someInt
								# REQUIRED
								fileSize = $someInt64
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = $someString
							# OPTIONAL
							ChannelID = $someString
							# OPTIONAL
							ChannelName = $someString
							# OPTIONAL
							ChannelFolderName = $someString
							# OPTIONAL
							ChannelNaturalId = $someString
							# REQUIRED
							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				foldersToRestore = @(
					@{
						# REQUIRED
						folderId = $someString
						# REQUIRED
						folderName = $someString
						# REQUIRED
						folderSize = $someInt64
						# REQUIRED
						snapshotId = $someString
						# REQUIRED
						snapshotNum = $someInt
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = $someString
							# OPTIONAL
							ChannelID = $someString
							# OPTIONAL
							ChannelName = $someString
							# OPTIONAL
							ChannelFolderName = $someString
							# OPTIONAL
							ChannelNaturalId = $someString
							# REQUIRED
							channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				restoreFolderPath = $someString
			}
			# OPTIONAL
			conversationsRestoreConfig = @{
				# OPTIONAL
				SearchFilter = @{
					# OPTIONAL
					PostedTime = @{
						# OPTIONAL
						FromTime = $someInt64
						# OPTIONAL
						UntilTime = $someInt64
					}
					# OPTIONAL
					PostedBy = $someString
					# OPTIONAL
					SnapshotId = $someString
				}
				# OPTIONAL
				ChannelInfoForFullRestore = @{
					# REQUIRED
					TeamID = $someString
					# OPTIONAL
					ChannelID = $someString
					# OPTIONAL
					ChannelName = $someString
					# OPTIONAL
					ChannelFolderName = $someString
					# OPTIONAL
					ChannelFolderId = $someString
					# OPTIONAL
					ChannelNaturalId = $someString
				}
				# REQUIRED
				RefreshTokenEncrypted = $someString
				# REQUIRED
				O365AppID = $someString
				# REQUIRED
				ChannelsToRestore = @(
					@{
						# REQUIRED
						TeamID = $someString
						# OPTIONAL
						ChannelID = $someString
						# OPTIONAL
						ChannelName = $someString
						# OPTIONAL
						ChannelFolderName = $someString
						# OPTIONAL
						ChannelFolderId = $someString
						# OPTIONAL
						ChannelNaturalId = $someString
					}
				)
				# REQUIRED
				ShouldRestoreFileAttachments = $someBoolean
			}
			# OPTIONAL
			destChannelInfo = @{
				# REQUIRED
				TeamID = $someString
				# OPTIONAL
				ChannelID = $someString
				# OPTIONAL
				ChannelName = $someString
				# OPTIONAL
				ChannelFolderName = $someString
				# OPTIONAL
				ChannelNaturalId = $someString
				# REQUIRED
				channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
			# REQUIRED
			shouldCreateDestChannel = $someBoolean
			# REQUIRED
			channelType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			# REQUIRED
			restoreLatestPermissions = $someBoolean
			# REQUIRED
			snapshotSequenceNum = $someInt
		}
		# OPTIONAL
		MailboxRestoreConfig = @{
			# OPTIONAL
			SnapshotUUID = $someString
			# REQUIRED
			RestoreConfigs = @(
				@{
					# REQUIRED
					SnapshotUUID = $someString
					# OPTIONAL
					EmailID = $someString
					# OPTIONAL
					FolderID = $someString
				}
			)
			# OPTIONAL
			skipRifItems = $someBoolean
		}
		# OPTIONAL
		calendarRestoreConfig = @{
			# REQUIRED
			eventsToRestore = @(
				@{
					# REQUIRED
					eventId = $someString
					# REQUIRED
					snapshotId = $someString
				}
			)
			# REQUIRED
			calendarsToRestore = @(
				@{
					# REQUIRED
					calendarId = $someString
					# REQUIRED
					snapshotId = $someString
				}
			)
			# REQUIRED
			calendarGroupsToRestore = @(
				@{
					# REQUIRED
					calendarGroupId = $someString
					# REQUIRED
					snapshotId = $someString
				}
			)
			# OPTIONAL
			skipRifItems = $someBoolean
		}
		# OPTIONAL
		contactsRestoreConfig = @{
			# REQUIRED
			contactsToRestore = @(
				@{
					# REQUIRED
					contactId = $someString
					# REQUIRED
					snapshotId = $someString
					# REQUIRED
					snapshotNum = $someInt
				}
			)
			# REQUIRED
			contactFoldersToRestore = @(
				@{
					# REQUIRED
					contactFolderId = $someString
					# REQUIRED
					snapshotId = $someString
					# REQUIRED
					snapshotNum = $someInt
				}
			)
			# OPTIONAL
			skipRifItems = $someBoolean
		}
		# OPTIONAL
		inplaceRestoreConfig = @{
			# REQUIRED
			nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
		}
		# OPTIONAL
		failedItemsRecoveryConfig = @{
			# REQUIRED
			failedItemsInstanceId = $someString
		}
		# OPTIONAL
		relicRestoreConfig = @{
			# OPTIONAL
			unused = $someBoolean
		}
	}
	# REQUIRED
	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreO365TeamsConversations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsConversationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365TeamsConversations",
                "($input: RestoreO365TeamsConversationsInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365TeamsConversations,
                Mutation.RestoreO365TeamsConversationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	teamUuid = $someString
	# OPTIONAL
	destTeamsChannelInfo = @{
		# REQUIRED
		TeamID = $someString
		# OPTIONAL
		ChannelID = $someString
		# OPTIONAL
		ChannelName = $someString
		# OPTIONAL
		ChannelFolderName = $someString
		# OPTIONAL
		ChannelNaturalId = $someString
		# REQUIRED
		channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldCreateDestChannel = $someBoolean
	# OPTIONAL
	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
	# OPTIONAL
	inplaceRestoreConfig = @{
		# REQUIRED
		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
	}
	# OPTIONAL
	channelInfoForFullRestore = @{
		# REQUIRED
		naturalId = $someString
		# OPTIONAL
		channelId = $someString
		# REQUIRED
		name = $someString
		# REQUIRED
		folderId = $someString
		# REQUIRED
		membershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldRestoreFileAttachments = $someBoolean
	# REQUIRED
	teamChannels = @(
		@{
			# REQUIRED
			naturalId = $someString
			# OPTIONAL
			channelId = $someString
			# REQUIRED
			name = $someString
			# REQUIRED
			folderId = $someString
			# REQUIRED
			membershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
		}
	)
	# OPTIONAL
	teamsConversationsSearchFilter = @{
		# OPTIONAL
		postedTime = @{
			# OPTIONAL
			fromTime = $someDateTime
			# OPTIONAL
			untilTime = $someDateTime
		}
		# OPTIONAL
		channelNaturalId = $someString
		# OPTIONAL
		postedBy = $someString
		# OPTIONAL
		snapshotId = $someString
		# OPTIONAL
		parentId = $someString
		# OPTIONAL
		convId = $someString
		# OPTIONAL
		snapshotNum = $someInt
		# OPTIONAL
		includeArchived = $someBoolean
		# OPTIONAL
		fetchAllPostSenders = $someString
		# OPTIONAL
		skipPostsAttachments = $someBoolean
	}
	# REQUIRED
	refreshTokenEncrypted = $someString
	# REQUIRED
	o365AppId = $someString
	# REQUIRED
	channelRecoveryType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# REQUIRED
	recoverWithLatestPermissions = $someBoolean
	# REQUIRED
	snapshotSequenceNum = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreO365TeamsFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365TeamsFiles",
                "($input: RestoreO365TeamsFilesInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365TeamsFiles,
                Mutation.RestoreO365TeamsFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	filesToRestore = @(
		@{
			# REQUIRED
			fileId = $someString
			# REQUIRED
			fileName = $someString
			# REQUIRED
			fileSnapshotsToRestore = @(
				@{
					# REQUIRED
					snapshotId = $someString
					# REQUIRED
					snapshotNum = $someInt
					# REQUIRED
					fileSize = $someInt64
				}
			)
			# OPTIONAL
			channelInfo = @{
				# REQUIRED
				TeamID = $someString
				# OPTIONAL
				ChannelID = $someString
				# OPTIONAL
				ChannelName = $someString
				# OPTIONAL
				ChannelFolderName = $someString
				# OPTIONAL
				ChannelNaturalId = $someString
				# REQUIRED
				channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
		}
	)
	# REQUIRED
	foldersToRestore = @(
		@{
			# REQUIRED
			folderId = $someString
			# REQUIRED
			folderName = $someString
			# REQUIRED
			folderSize = $someInt64
			# REQUIRED
			snapshotId = $someString
			# REQUIRED
			snapshotNum = $someInt
			# OPTIONAL
			channelInfo = @{
				# REQUIRED
				TeamID = $someString
				# OPTIONAL
				ChannelID = $someString
				# OPTIONAL
				ChannelName = $someString
				# OPTIONAL
				ChannelFolderName = $someString
				# OPTIONAL
				ChannelNaturalId = $someString
				# REQUIRED
				channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
		}
	)
	# OPTIONAL
	destTeamsChannelInfo = @{
		# REQUIRED
		TeamID = $someString
		# OPTIONAL
		ChannelID = $someString
		# OPTIONAL
		ChannelName = $someString
		# OPTIONAL
		ChannelFolderName = $someString
		# OPTIONAL
		ChannelNaturalId = $someString
		# REQUIRED
		channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldCreateDestChannel = $someBoolean
	# REQUIRED
	actionType = $someO365RestoreActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
	# OPTIONAL
	inplaceRestoreConfig = @{
		# REQUIRED
		nameCollisionRule = $someNameCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NameCollisionRule]) for enum values.
	}
	# REQUIRED
	channelRecoveryType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# REQUIRED
	recoverWithLatestPermissions = $someBoolean
	# REQUIRED
	snapshotSequenceNum = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // o365SaaSSetupKickoff: O365SaasSetupKickoffReply!
        internal void InitMutationO365SaaSsetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SaaSsetupKickoff",
                "",
                "O365SaasSetupKickoffReply",
                Mutation.O365SaaSsetupKickoff,
                Mutation.O365SaaSsetupKickoffFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // o365SaasSetupComplete(input: O365SaasSetupCompleteInput!): AddO365OrgResponse!
        internal void InitMutationO365SaasSetupComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365SaasSetupCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SaasSetupComplete",
                "($input: O365SaasSetupCompleteInput!)",
                "AddO365OrgResponse",
                Mutation.O365SaasSetupComplete,
                Mutation.O365SaasSetupCompleteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tenantId = $someString
	# REQUIRED
	regionName = $someString
	# REQUIRED
	stateToken = $someString
	# REQUIRED
	appTypes = @(
		$someString
	)
	# OPTIONAL
	kmsSpec = @{
		# OPTIONAL
		cloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
		# OPTIONAL
		tenantId = $someString
		# OPTIONAL
		kmsId = $someString
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecret = $someString
		# OPTIONAL
		keyName = $someString
		# OPTIONAL
		kekNameColossus = $someString
	}
	# REQUIRED
	storeBackupInSameRegionAsData = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!): RequestStatus!
        internal void InitMutationSetO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("username", "String!"),
                Tuple.Create("appPassword", "String!"),
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetO365ServiceAccount",
                "($username: String!,$appPassword: String!,$orgId: UUID!)",
                "RequestStatus",
                Mutation.SetO365ServiceAccount,
                Mutation.SetO365ServiceAccountFieldSpec,
                @"# REQUIRED
$query.Var.username = $someString
# REQUIRED
$query.Var.appPassword = $someString
# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // o365SetupKickoff: O365SetupKickoffResp!
        internal void InitMutationO365SetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SetupKickoff",
                "",
                "O365SetupKickoffResp",
                Mutation.O365SetupKickoff,
                Mutation.O365SetupKickoffFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!): UpdateO365AppAuthStatusReply!
        internal void InitMutationUpdateO365AppAuthStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppAuthStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365AppAuthStatus",
                "($input: UpdateO365AppAuthStatusInput!)",
                "UpdateO365AppAuthStatusReply",
                Mutation.UpdateO365AppAuthStatus,
                Mutation.UpdateO365AppAuthStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	o365OrgId = $someString
	# REQUIRED
	o365AppId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateO365AppPermissions(input: UpdateO365AppPermissionsInput!): Void
        internal void InitMutationUpdateO365AppPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppPermissionsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365AppPermissions",
                "($input: UpdateO365AppPermissionsInput!)",
                "System.String",
                Mutation.UpdateO365AppPermissions,
                Mutation.UpdateO365AppPermissionsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	o365AppType = $someO365AppType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AppType]) for enum values.
	# REQUIRED
	o365AppId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!): UpdateO365OrgCustomNameReply!
        internal void InitMutationUpdateO365OrgCustomName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365OrgCustomNameInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365OrgCustomName",
                "($input: UpdateO365OrgCustomNameInput!)",
                "UpdateO365OrgCustomNameReply",
                Mutation.UpdateO365OrgCustomName,
                Mutation.UpdateO365OrgCustomNameFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgUuid = $someString
	# REQUIRED
	customName = $someString
}"
            );
        }


    } // class New_RscMutationO365
}
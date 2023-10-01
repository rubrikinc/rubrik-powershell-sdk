// New-RscMutationGcp.cs
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
    /// Create a new RscQuery object for any of the 11
    /// operations in the 'Google Cloud Platform' API domain:
    /// CloudAccountAddManualAuthProject, CloudAccountAddProjects, CloudAccountDeleteProjects, CloudAccountOauthComplete, CloudAccountOauthInitiate, CloudAccountUpgradeProjects, CreateReaderTarget, CreateTarget, SetDefaultServiceAccountJwtConfig, UpdateTarget, or UpgradeCloudAccountPermissionsWithoutOauth.
    /// </summary>
    /// <description>
    /// New-RscMutationGcp creates a new
    /// mutation object for operations
    /// in the 'Google Cloud Platform' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 11 operations
    /// in the 'Google Cloud Platform' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CloudAccountAddManualAuthProject, CloudAccountAddProjects, CloudAccountDeleteProjects, CloudAccountOauthComplete, CloudAccountOauthInitiate, CloudAccountUpgradeProjects, CreateReaderTarget, CreateTarget, SetDefaultServiceAccountJwtConfig, UpdateTarget, or UpgradeCloudAccountPermissionsWithoutOauth.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationGcp -CloudAccountAddManualAuthProject).Info().
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
    /// (New-RscMutationGcp -CloudAccountAddManualAuthProject).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CloudAccountAddManualAuthProject operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountAddManualAuthProject
    /// 
    /// $query = New-RscMutationGcp -CloudAccountAddManualAuthProject
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	gcpNativeProjectId = $someString
    /// 	# REQUIRED
    /// 	gcpProjectName = $someString
    /// 	# REQUIRED
    /// 	gcpProjectNumber = $someInt64
    /// 	# OPTIONAL
    /// 	organizationName = $someString
    /// 	# OPTIONAL
    /// 	serviceAccountJwtConfig = $someString
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
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
    /// Runs the CloudAccountAddProjects operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountAddProjects
    /// 
    /// $query = New-RscMutationGcp -CloudAccountAddProjects
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	nativeProtectionProjectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	sharedVpcHostProjectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	cloudAccountsProjectIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpCloudAccountAddProjectsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountDeleteProjects operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountDeleteProjects
    /// 
    /// $query = New-RscMutationGcp -CloudAccountDeleteProjects
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	nativeProtectionProjectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	sharedVpcHostProjectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	cloudAccountsProjectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	skipResourceDeletion = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpCloudAccountDeleteProjectsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountOauthComplete operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountOauthComplete
    /// 
    /// $query = New-RscMutationGcp -CloudAccountOauthComplete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	authorizationCode = $someString
    /// 	# REQUIRED
    /// 	redirectUrl = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpCloudAccountOauthCompleteReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountOauthInitiate operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountOauthInitiate
    /// 
    /// $query = New-RscMutationGcp -CloudAccountOauthInitiate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	customerUrl = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpCloudAccountOauthInitiateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountUpgradeProjects operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountUpgradeProjects
    /// 
    /// $query = New-RscMutationGcp -CloudAccountUpgradeProjects
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	projectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpCloudAccountUpgradeProjectsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateReaderTarget operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CreateReaderTarget
    /// 
    /// $query = New-RscMutationGcp -CreateReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	region = $someGcpRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpRegion]) for enum values.
    /// 	# REQUIRED
    /// 	storageClass = $someGcpStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpStorageClass]) for enum values.
    /// 	# REQUIRED
    /// 	bucket = $someString
    /// 	# REQUIRED
    /// 	encryptionPassword = $someString
    /// 	# REQUIRED
    /// 	serviceAccountJsonKey = $someString
    /// 	# OPTIONAL
    /// 	archivalProxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
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
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CreateTarget
    /// 
    /// $query = New-RscMutationGcp -CreateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	region = $someGcpRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpRegion]) for enum values.
    /// 	# REQUIRED
    /// 	storageClass = $someGcpStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpStorageClass]) for enum values.
    /// 	# REQUIRED
    /// 	bucket = $someString
    /// 	# REQUIRED
    /// 	encryptionPassword = $someString
    /// 	# REQUIRED
    /// 	serviceAccountJsonKey = $someString
    /// 	# OPTIONAL
    /// 	archivalProxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
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
    /// Runs the SetDefaultServiceAccountJwtConfig operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: SetDefaultServiceAccountJwtConfig
    /// 
    /// $query = New-RscMutationGcp -SetDefaultServiceAccountJwtConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	serviceAccountName = $someString
    /// 	# REQUIRED
    /// 	serviceAccountJwtConfig = $someString
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
    /// Runs the UpdateTarget operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: UpdateTarget
    /// 
    /// $query = New-RscMutationGcp -UpdateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	region = $someGcpRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	storageClass = $someGcpStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpStorageClass]) for enum values.
    /// 	# OPTIONAL
    /// 	bucket = $someString
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# OPTIONAL
    /// 	serviceAccountJsonKey = $someString
    /// 	# OPTIONAL
    /// 	archivalProxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	bypassProxy = $someBoolean
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
    /// Runs the UpgradeCloudAccountPermissionsWithoutOauth operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: UpgradeCloudAccountPermissionsWithoutOauth
    /// 
    /// $query = New-RscMutationGcp -UpgradeCloudAccountPermissionsWithoutOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpgradeGcpCloudAccountPermissionsWithoutOauthReply
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
        "RscMutationGcp",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationGcp : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CloudAccountAddManualAuthProject",
                "CloudAccountAddProjects",
                "CloudAccountDeleteProjects",
                "CloudAccountOauthComplete",
                "CloudAccountOauthInitiate",
                "CloudAccountUpgradeProjects",
                "CreateReaderTarget",
                "CreateTarget",
                "SetDefaultServiceAccountJwtConfig",
                "UpdateTarget",
                "UpgradeCloudAccountPermissionsWithoutOauth",
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
                    case "CloudAccountAddManualAuthProject":
                        this.ProcessRecord_CloudAccountAddManualAuthProject();
                        break;
                    case "CloudAccountAddProjects":
                        this.ProcessRecord_CloudAccountAddProjects();
                        break;
                    case "CloudAccountDeleteProjects":
                        this.ProcessRecord_CloudAccountDeleteProjects();
                        break;
                    case "CloudAccountOauthComplete":
                        this.ProcessRecord_CloudAccountOauthComplete();
                        break;
                    case "CloudAccountOauthInitiate":
                        this.ProcessRecord_CloudAccountOauthInitiate();
                        break;
                    case "CloudAccountUpgradeProjects":
                        this.ProcessRecord_CloudAccountUpgradeProjects();
                        break;
                    case "CreateReaderTarget":
                        this.ProcessRecord_CreateReaderTarget();
                        break;
                    case "CreateTarget":
                        this.ProcessRecord_CreateTarget();
                        break;
                    case "SetDefaultServiceAccountJwtConfig":
                        this.ProcessRecord_SetDefaultServiceAccountJwtConfig();
                        break;
                    case "UpdateTarget":
                        this.ProcessRecord_UpdateTarget();
                        break;
                    case "UpgradeCloudAccountPermissionsWithoutOauth":
                        this.ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth();
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
        // gcpCloudAccountAddManualAuthProject.
        internal void ProcessRecord_CloudAccountAddManualAuthProject()
        {
            this._logger.name += " -CloudAccountAddManualAuthProject";
            // Create new graphql operation gcpCloudAccountAddManualAuthProject
            InitMutationGcpCloudAccountAddManualAuthProject();
        }

        // This parameter set invokes a single graphql operation:
        // gcpCloudAccountAddProjects.
        internal void ProcessRecord_CloudAccountAddProjects()
        {
            this._logger.name += " -CloudAccountAddProjects";
            // Create new graphql operation gcpCloudAccountAddProjects
            InitMutationGcpCloudAccountAddProjects();
        }

        // This parameter set invokes a single graphql operation:
        // gcpCloudAccountDeleteProjects.
        internal void ProcessRecord_CloudAccountDeleteProjects()
        {
            this._logger.name += " -CloudAccountDeleteProjects";
            // Create new graphql operation gcpCloudAccountDeleteProjects
            InitMutationGcpCloudAccountDeleteProjects();
        }

        // This parameter set invokes a single graphql operation:
        // gcpCloudAccountOauthComplete.
        internal void ProcessRecord_CloudAccountOauthComplete()
        {
            this._logger.name += " -CloudAccountOauthComplete";
            // Create new graphql operation gcpCloudAccountOauthComplete
            InitMutationGcpCloudAccountOauthComplete();
        }

        // This parameter set invokes a single graphql operation:
        // gcpCloudAccountOauthInitiate.
        internal void ProcessRecord_CloudAccountOauthInitiate()
        {
            this._logger.name += " -CloudAccountOauthInitiate";
            // Create new graphql operation gcpCloudAccountOauthInitiate
            InitMutationGcpCloudAccountOauthInitiate();
        }

        // This parameter set invokes a single graphql operation:
        // gcpCloudAccountUpgradeProjects.
        internal void ProcessRecord_CloudAccountUpgradeProjects()
        {
            this._logger.name += " -CloudAccountUpgradeProjects";
            // Create new graphql operation gcpCloudAccountUpgradeProjects
            InitMutationGcpCloudAccountUpgradeProjects();
        }

        // This parameter set invokes a single graphql operation:
        // createGcpReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Create new graphql operation createGcpReaderTarget
            InitMutationCreateGcpReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createGcpTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Create new graphql operation createGcpTarget
            InitMutationCreateGcpTarget();
        }

        // This parameter set invokes a single graphql operation:
        // gcpSetDefaultServiceAccountJwtConfig.
        internal void ProcessRecord_SetDefaultServiceAccountJwtConfig()
        {
            this._logger.name += " -SetDefaultServiceAccountJwtConfig";
            // Create new graphql operation gcpSetDefaultServiceAccountJwtConfig
            InitMutationGcpSetDefaultServiceAccountJwtConfig();
        }

        // This parameter set invokes a single graphql operation:
        // updateGcpTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateGcpTarget
            InitMutationUpdateGcpTarget();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeGcpCloudAccountPermissionsWithoutOauth.
        internal void ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth()
        {
            this._logger.name += " -UpgradeCloudAccountPermissionsWithoutOauth";
            // Create new graphql operation upgradeGcpCloudAccountPermissionsWithoutOauth
            InitMutationUpgradeGcpCloudAccountPermissionsWithoutOauth();
        }


        // Create new GraphQL Mutation:
        // gcpCloudAccountAddManualAuthProject(input: GcpCloudAccountAddManualAuthProjectInput!): Boolean!
        internal void InitMutationGcpCloudAccountAddManualAuthProject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpCloudAccountAddManualAuthProjectInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpCloudAccountAddManualAuthProject",
                "($input: GcpCloudAccountAddManualAuthProjectInput!)",
                "System.Boolean",
                Mutation.GcpCloudAccountAddManualAuthProject_ObjectFieldSpec,
                Mutation.GcpCloudAccountAddManualAuthProjectFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	gcpNativeProjectId = $someString
	# REQUIRED
	gcpProjectName = $someString
	# REQUIRED
	gcpProjectNumber = $someInt64
	# OPTIONAL
	organizationName = $someString
	# OPTIONAL
	serviceAccountJwtConfig = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpCloudAccountAddProjects(input: GcpCloudAccountAddProjectsInput!): GcpCloudAccountAddProjectsReply!
        internal void InitMutationGcpCloudAccountAddProjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpCloudAccountAddProjectsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpCloudAccountAddProjects",
                "($input: GcpCloudAccountAddProjectsInput!)",
                "GcpCloudAccountAddProjectsReply",
                Mutation.GcpCloudAccountAddProjects_ObjectFieldSpec,
                Mutation.GcpCloudAccountAddProjectsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	nativeProtectionProjectIds = @(
		$someString
	)
	# REQUIRED
	sharedVpcHostProjectIds = @(
		$someString
	)
	# REQUIRED
	cloudAccountsProjectIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpCloudAccountDeleteProjects(input: GcpCloudAccountDeleteProjectsInput!): GcpCloudAccountDeleteProjectsReply!
        internal void InitMutationGcpCloudAccountDeleteProjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpCloudAccountDeleteProjectsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpCloudAccountDeleteProjects",
                "($input: GcpCloudAccountDeleteProjectsInput!)",
                "GcpCloudAccountDeleteProjectsReply",
                Mutation.GcpCloudAccountDeleteProjects_ObjectFieldSpec,
                Mutation.GcpCloudAccountDeleteProjectsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	sessionId = $someString
	# REQUIRED
	nativeProtectionProjectIds = @(
		$someString
	)
	# REQUIRED
	sharedVpcHostProjectIds = @(
		$someString
	)
	# REQUIRED
	cloudAccountsProjectIds = @(
		$someString
	)
	# REQUIRED
	skipResourceDeletion = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpCloudAccountOauthComplete(input: GcpCloudAccountOauthCompleteInput!): GcpCloudAccountOauthCompleteReply!
        internal void InitMutationGcpCloudAccountOauthComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpCloudAccountOauthCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpCloudAccountOauthComplete",
                "($input: GcpCloudAccountOauthCompleteInput!)",
                "GcpCloudAccountOauthCompleteReply",
                Mutation.GcpCloudAccountOauthComplete_ObjectFieldSpec,
                Mutation.GcpCloudAccountOauthCompleteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	authorizationCode = $someString
	# REQUIRED
	redirectUrl = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpCloudAccountOauthInitiate(input: GcpCloudAccountOauthInitiateInput!): GcpCloudAccountOauthInitiateReply!
        internal void InitMutationGcpCloudAccountOauthInitiate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpCloudAccountOauthInitiateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpCloudAccountOauthInitiate",
                "($input: GcpCloudAccountOauthInitiateInput!)",
                "GcpCloudAccountOauthInitiateReply",
                Mutation.GcpCloudAccountOauthInitiate_ObjectFieldSpec,
                Mutation.GcpCloudAccountOauthInitiateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	customerUrl = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpCloudAccountUpgradeProjects(input: GcpCloudAccountUpgradeProjectsInput!): GcpCloudAccountUpgradeProjectsReply!
        internal void InitMutationGcpCloudAccountUpgradeProjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpCloudAccountUpgradeProjectsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpCloudAccountUpgradeProjects",
                "($input: GcpCloudAccountUpgradeProjectsInput!)",
                "GcpCloudAccountUpgradeProjectsReply",
                Mutation.GcpCloudAccountUpgradeProjects_ObjectFieldSpec,
                Mutation.GcpCloudAccountUpgradeProjectsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	projectIds = @(
		$someString
	)
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createGcpReaderTarget(input: CreateGcpReaderTargetInput!): Target!
        internal void InitMutationCreateGcpReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateGcpReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateGcpReaderTarget",
                "($input: CreateGcpReaderTargetInput!)",
                "Target",
                Mutation.CreateGcpReaderTarget_ObjectFieldSpec,
                Mutation.CreateGcpReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	region = $someGcpRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpRegion]) for enum values.
	# REQUIRED
	storageClass = $someGcpStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpStorageClass]) for enum values.
	# REQUIRED
	bucket = $someString
	# REQUIRED
	encryptionPassword = $someString
	# REQUIRED
	serviceAccountJsonKey = $someString
	# OPTIONAL
	archivalProxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# REQUIRED
	bypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createGcpTarget(input: CreateGcpTargetInput!): Target!
        internal void InitMutationCreateGcpTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateGcpTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateGcpTarget",
                "($input: CreateGcpTargetInput!)",
                "Target",
                Mutation.CreateGcpTarget_ObjectFieldSpec,
                Mutation.CreateGcpTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	region = $someGcpRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpRegion]) for enum values.
	# REQUIRED
	storageClass = $someGcpStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpStorageClass]) for enum values.
	# REQUIRED
	bucket = $someString
	# REQUIRED
	encryptionPassword = $someString
	# REQUIRED
	serviceAccountJsonKey = $someString
	# OPTIONAL
	archivalProxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# REQUIRED
	bypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpSetDefaultServiceAccountJwtConfig(input: GcpSetDefaultServiceAccountJwtConfigInput!): Boolean!
        internal void InitMutationGcpSetDefaultServiceAccountJwtConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpSetDefaultServiceAccountJwtConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpSetDefaultServiceAccountJwtConfig",
                "($input: GcpSetDefaultServiceAccountJwtConfigInput!)",
                "System.Boolean",
                Mutation.GcpSetDefaultServiceAccountJwtConfig_ObjectFieldSpec,
                Mutation.GcpSetDefaultServiceAccountJwtConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	serviceAccountName = $someString
	# REQUIRED
	serviceAccountJwtConfig = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateGcpTarget(input: UpdateGcpTargetInput!): Target!
        internal void InitMutationUpdateGcpTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGcpTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateGcpTarget",
                "($input: UpdateGcpTargetInput!)",
                "Target",
                Mutation.UpdateGcpTarget_ObjectFieldSpec,
                Mutation.UpdateGcpTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	region = $someGcpRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpRegion]) for enum values.
	# OPTIONAL
	storageClass = $someGcpStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpStorageClass]) for enum values.
	# OPTIONAL
	bucket = $someString
	# OPTIONAL
	encryptionPassword = $someString
	# OPTIONAL
	serviceAccountJsonKey = $someString
	# OPTIONAL
	archivalProxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	bypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeGcpCloudAccountPermissionsWithoutOauth(input: UpgradeGcpCloudAccountPermissionsWithoutOauthInput!): UpgradeGcpCloudAccountPermissionsWithoutOauthReply!
        internal void InitMutationUpgradeGcpCloudAccountPermissionsWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeGcpCloudAccountPermissionsWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeGcpCloudAccountPermissionsWithoutOauth",
                "($input: UpgradeGcpCloudAccountPermissionsWithoutOauthInput!)",
                "UpgradeGcpCloudAccountPermissionsWithoutOauthReply",
                Mutation.UpgradeGcpCloudAccountPermissionsWithoutOauth_ObjectFieldSpec,
                Mutation.UpgradeGcpCloudAccountPermissionsWithoutOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
}"
            );
        }


    } // class New_RscMutationGcp
}
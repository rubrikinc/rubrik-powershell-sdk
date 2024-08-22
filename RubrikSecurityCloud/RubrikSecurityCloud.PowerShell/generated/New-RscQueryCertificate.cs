// New-RscQueryCertificate.cs
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
    /// operations in the 'Certificates' API domain:
    /// AssignableGlobalCertificates, Certificates, CertificatesWithKey, ClusterCertificates, ClusterCsr, ClusterWebSigned, GlobalCertificate, GlobalCertificates, Info, SigningRequest, or SigningRequests.
    /// </summary>
    /// <description>
    /// New-RscQueryCertificate creates a new
    /// query object for operations
    /// in the 'Certificates' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 11 operations
    /// in the 'Certificates' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AssignableGlobalCertificates, Certificates, CertificatesWithKey, ClusterCertificates, ClusterCsr, ClusterWebSigned, GlobalCertificate, GlobalCertificates, Info, SigningRequest, or SigningRequests.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryCertificate -AssignableGlobalCertificates).Info().
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
    /// (New-RscQueryCertificate -AssignableGlobalCertificates).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AssignableGlobalCertificates operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: AssignableGlobalCertificates
    /// 
    /// $query = New-RscQueryCertificate -AssignableGlobalCertificates
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someGlobalCertificateSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalCertificateSortBy]) for enum values.
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	searchText = $someString
    /// 	# OPTIONAL
    /// 	hasKey = $someBoolean
    /// 	# OPTIONAL
    /// 	statuses = @(
    /// 		$someGlobalCertificateStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalCertificateStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	isTrustedAny = $someBoolean
    /// 	# OPTIONAL
    /// 	isRscBorn = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalCertificateConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Certificates operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: Certificates
    /// 
    /// $query = New-RscQueryCertificate -Certificates
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someCertMgmtSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CertMgmtSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.searchTerm = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CertificateConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CertificatesWithKey operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: CertificatesWithKey
    /// 
    /// $query = New-RscQueryCertificate -CertificatesWithKey
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CertificateConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterCertificates operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: ClusterCertificates
    /// 
    /// $query = New-RscQueryCertificate -ClusterCertificates
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	expiration = $someString
    /// 	# OPTIONAL
    /// 	hasKey = $someBoolean
    /// 	# OPTIONAL
    /// 	includeExpired = $someBoolean
    /// 	# OPTIONAL
    /// 	isTrusted = $someBoolean
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	sortBy = $someV1QueryCertificatesRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someV1QueryCertificatesRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortOrder]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CertificateSummaryListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterCsr operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: ClusterCsr
    /// 
    /// $query = New-RscQueryCertificate -ClusterCsr
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
    /// Write-Host $result.GetType().Name # prints: ClusterCsr
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterWebSigned operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: ClusterWebSigned
    /// 
    /// $query = New-RscQueryCertificate -ClusterWebSigned
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
    /// Write-Host $result.GetType().Name # prints: ClusterWebSignedCertificateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalCertificate operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: GlobalCertificate
    /// 
    /// $query = New-RscQueryCertificate -GlobalCertificate
    /// 
    /// # REQUIRED
    /// $query.Var.certificateId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalCertificate
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalCertificates operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: GlobalCertificates
    /// 
    /// $query = New-RscQueryCertificate -GlobalCertificates
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someGlobalCertificateSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalCertificateSortBy]) for enum values.
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	searchText = $someString
    /// 	# OPTIONAL
    /// 	hasKey = $someBoolean
    /// 	# OPTIONAL
    /// 	statuses = @(
    /// 		$someGlobalCertificateStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalCertificateStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	isTrustedAny = $someBoolean
    /// 	# OPTIONAL
    /// 	isRscBorn = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalCertificateConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Info operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: Info
    /// 
    /// $query = New-RscQueryCertificate -Info
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	certificatePem = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetCertificateInfoReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SigningRequest operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: SigningRequest
    /// 
    /// $query = New-RscQueryCertificate -SigningRequest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	csrFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Csr
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SigningRequests operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: SigningRequests
    /// 
    /// $query = New-RscQueryCertificate -SigningRequests
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someCertMgmtSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CertMgmtSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.searchTerm = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CsrConnection
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
        "RscQueryCertificate",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryCertificate : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AssignableGlobalCertificates",
                "Certificates",
                "CertificatesWithKey",
                "ClusterCertificates",
                "ClusterCsr",
                "ClusterWebSigned",
                "GlobalCertificate",
                "GlobalCertificates",
                "Info",
                "SigningRequest",
                "SigningRequests",
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
                    case "AssignableGlobalCertificates":
                        this.ProcessRecord_AssignableGlobalCertificates();
                        break;
                    case "Certificates":
                        this.ProcessRecord_Certificates();
                        break;
                    case "CertificatesWithKey":
                        this.ProcessRecord_CertificatesWithKey();
                        break;
                    case "ClusterCertificates":
                        this.ProcessRecord_ClusterCertificates();
                        break;
                    case "ClusterCsr":
                        this.ProcessRecord_ClusterCsr();
                        break;
                    case "ClusterWebSigned":
                        this.ProcessRecord_ClusterWebSigned();
                        break;
                    case "GlobalCertificate":
                        this.ProcessRecord_GlobalCertificate();
                        break;
                    case "GlobalCertificates":
                        this.ProcessRecord_GlobalCertificates();
                        break;
                    case "Info":
                        this.ProcessRecord_Info();
                        break;
                    case "SigningRequest":
                        this.ProcessRecord_SigningRequest();
                        break;
                    case "SigningRequests":
                        this.ProcessRecord_SigningRequests();
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
        // assignableGlobalCertificates.
        internal void ProcessRecord_AssignableGlobalCertificates()
        {
            this._logger.name += " -AssignableGlobalCertificates";
            // Create new graphql operation assignableGlobalCertificates
            InitQueryAssignableGlobalCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // certificates.
        internal void ProcessRecord_Certificates()
        {
            this._logger.name += " -Certificates";
            // Create new graphql operation certificates
            InitQueryCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // certificatesWithKey.
        internal void ProcessRecord_CertificatesWithKey()
        {
            this._logger.name += " -CertificatesWithKey";
            // Create new graphql operation certificatesWithKey
            InitQueryCertificatesWithKey();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCertificates.
        internal void ProcessRecord_ClusterCertificates()
        {
            this._logger.name += " -ClusterCertificates";
            // Create new graphql operation clusterCertificates
            InitQueryClusterCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCsr.
        internal void ProcessRecord_ClusterCsr()
        {
            this._logger.name += " -ClusterCsr";
            // Create new graphql operation clusterCsr
            InitQueryClusterCsr();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWebSignedCertificate.
        internal void ProcessRecord_ClusterWebSigned()
        {
            this._logger.name += " -ClusterWebSigned";
            // Create new graphql operation clusterWebSignedCertificate
            InitQueryClusterWebSignedCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // globalCertificate.
        internal void ProcessRecord_GlobalCertificate()
        {
            this._logger.name += " -GlobalCertificate";
            // Create new graphql operation globalCertificate
            InitQueryGlobalCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // globalCertificates.
        internal void ProcessRecord_GlobalCertificates()
        {
            this._logger.name += " -GlobalCertificates";
            // Create new graphql operation globalCertificates
            InitQueryGlobalCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // certificateInfo.
        internal void ProcessRecord_Info()
        {
            this._logger.name += " -Info";
            // Create new graphql operation certificateInfo
            InitQueryCertificateInfo();
        }

        // This parameter set invokes a single graphql operation:
        // certificateSigningRequest.
        internal void ProcessRecord_SigningRequest()
        {
            this._logger.name += " -SigningRequest";
            // Create new graphql operation certificateSigningRequest
            InitQueryCertificateSigningRequest();
        }

        // This parameter set invokes a single graphql operation:
        // certificateSigningRequests.
        internal void ProcessRecord_SigningRequests()
        {
            this._logger.name += " -SigningRequests";
            // Create new graphql operation certificateSigningRequests
            InitQueryCertificateSigningRequests();
        }


        // Create new GraphQL Query:
        // assignableGlobalCertificates(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: GlobalCertificateSortBy
        //     input: GlobalCertificatesQueryInput!
        //   ): GlobalCertificateConnection!
        internal void InitQueryAssignableGlobalCertificates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "GlobalCertificateSortBy"),
                Tuple.Create("input", "GlobalCertificatesQueryInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAssignableGlobalCertificates",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: GlobalCertificateSortBy,$input: GlobalCertificatesQueryInput!)",
                "GlobalCertificateConnection",
                Query.AssignableGlobalCertificates,
                Query.AssignableGlobalCertificatesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someGlobalCertificateSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalCertificateSortBy]) for enum values.
# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	searchText = $someString
	# OPTIONAL
	hasKey = $someBoolean
	# OPTIONAL
	statuses = @(
		$someGlobalCertificateStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalCertificateStatus]) for enum values.
	)
	# OPTIONAL
	clusterIds = @(
		$someString
	)
	# OPTIONAL
	isTrustedAny = $someBoolean
	# OPTIONAL
	isRscBorn = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // certificates(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: CertMgmtSortBy
        //     searchTerm: String
        //   ): CertificateConnection!
        internal void InitQueryCertificates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "CertMgmtSortBy"),
                Tuple.Create("searchTerm", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCertificates",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: CertMgmtSortBy,$searchTerm: String)",
                "CertificateConnection",
                Query.Certificates,
                Query.CertificatesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someCertMgmtSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CertMgmtSortBy]) for enum values.
# OPTIONAL
$query.Var.searchTerm = $someString"
            );
        }

        // Create new GraphQL Query:
        // certificatesWithKey: CertificateConnection!
        internal void InitQueryCertificatesWithKey()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCertificatesWithKey",
                "",
                "CertificateConnection",
                Query.CertificatesWithKey,
                Query.CertificatesWithKeyFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // clusterCertificates(input: QueryCertificatesInput!): CertificateSummaryListResponse!
        internal void InitQueryClusterCertificates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryCertificatesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterCertificates",
                "($input: QueryCertificatesInput!)",
                "CertificateSummaryListResponse",
                Query.ClusterCertificates,
                Query.ClusterCertificatesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	description = $someString
	# OPTIONAL
	expiration = $someString
	# OPTIONAL
	hasKey = $someBoolean
	# OPTIONAL
	includeExpired = $someBoolean
	# OPTIONAL
	isTrusted = $someBoolean
	# OPTIONAL
	name = $someString
	# OPTIONAL
	sortBy = $someV1QueryCertificatesRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someV1QueryCertificatesRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterCsr(input: GetClusterCsrInput!): ClusterCsr!
        internal void InitQueryClusterCsr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterCsrInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterCsr",
                "($input: GetClusterCsrInput!)",
                "ClusterCsr",
                Query.ClusterCsr,
                Query.ClusterCsrFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!): ClusterWebSignedCertificateReply!
        internal void InitQueryClusterWebSignedCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterWebSignedCertificateInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterWebSignedCertificate",
                "($input: ClusterWebSignedCertificateInput!)",
                "ClusterWebSignedCertificateReply",
                Query.ClusterWebSignedCertificate,
                Query.ClusterWebSignedCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // globalCertificate(certificateId: String!): GlobalCertificate!
        internal void InitQueryGlobalCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("certificateId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalCertificate",
                "($certificateId: String!)",
                "GlobalCertificate",
                Query.GlobalCertificate,
                Query.GlobalCertificateFieldSpec,
                @"# REQUIRED
$query.Var.certificateId = $someString"
            );
        }

        // Create new GraphQL Query:
        // globalCertificates(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: GlobalCertificateSortBy
        //     input: GlobalCertificatesQueryInput!
        //   ): GlobalCertificateConnection!
        internal void InitQueryGlobalCertificates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "GlobalCertificateSortBy"),
                Tuple.Create("input", "GlobalCertificatesQueryInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalCertificates",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: GlobalCertificateSortBy,$input: GlobalCertificatesQueryInput!)",
                "GlobalCertificateConnection",
                Query.GlobalCertificates,
                Query.GlobalCertificatesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someGlobalCertificateSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalCertificateSortBy]) for enum values.
# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	searchText = $someString
	# OPTIONAL
	hasKey = $someBoolean
	# OPTIONAL
	statuses = @(
		$someGlobalCertificateStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalCertificateStatus]) for enum values.
	)
	# OPTIONAL
	clusterIds = @(
		$someString
	)
	# OPTIONAL
	isTrustedAny = $someBoolean
	# OPTIONAL
	isRscBorn = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // certificateInfo(input: GetCertificateInfoInput!): GetCertificateInfoReply!
        internal void InitQueryCertificateInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetCertificateInfoInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCertificateInfo",
                "($input: GetCertificateInfoInput!)",
                "GetCertificateInfoReply",
                Query.CertificateInfo,
                Query.CertificateInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	certificatePem = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // certificateSigningRequest(input: GetCsrInput!): Csr!
        internal void InitQueryCertificateSigningRequest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetCsrInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCertificateSigningRequest",
                "($input: GetCsrInput!)",
                "Csr",
                Query.CertificateSigningRequest,
                Query.CertificateSigningRequestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	csrFid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // certificateSigningRequests(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: CertMgmtSortBy
        //     searchTerm: String
        //   ): CsrConnection!
        internal void InitQueryCertificateSigningRequests()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "CertMgmtSortBy"),
                Tuple.Create("searchTerm", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCertificateSigningRequests",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: CertMgmtSortBy,$searchTerm: String)",
                "CsrConnection",
                Query.CertificateSigningRequests,
                Query.CertificateSigningRequestsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someCertMgmtSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CertMgmtSortBy]) for enum values.
# OPTIONAL
$query.Var.searchTerm = $someString"
            );
        }


    } // class New_RscQueryCertificate
}
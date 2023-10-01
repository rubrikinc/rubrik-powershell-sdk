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
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'Certificates' API domain:
    /// Certificate, Cluster, ClusterWebSigned, SigningRequest, SigningRequests, or WithKey.
    /// </summary>
    /// <description>
    /// New-RscQueryCertificate creates a new
    /// query object for operations
    /// in the 'Certificates' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Certificates' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Certificate, Cluster, ClusterWebSigned, SigningRequest, SigningRequests, or WithKey.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryCertificate -Certificate).Info().
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
    /// (New-RscQueryCertificate -Certificate).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Certificate operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: Certificate
    /// 
    /// $query = New-RscQueryCertificate -Certificate
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
    /// Runs the Cluster operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: Cluster
    /// 
    /// $query = New-RscQueryCertificate -Cluster
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
    /// 	# OPTIONAL
    /// 	csrId = $someInt64
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
    /// <example>
    /// Runs the WithKey operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: WithKey
    /// 
    /// $query = New-RscQueryCertificate -WithKey
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
                "Certificate",
                "Cluster",
                "ClusterWebSigned",
                "SigningRequest",
                "SigningRequests",
                "WithKey",
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
                    case "Certificate":
                        this.ProcessRecord_Certificate();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "ClusterWebSigned":
                        this.ProcessRecord_ClusterWebSigned();
                        break;
                    case "SigningRequest":
                        this.ProcessRecord_SigningRequest();
                        break;
                    case "SigningRequests":
                        this.ProcessRecord_SigningRequests();
                        break;
                    case "WithKey":
                        this.ProcessRecord_WithKey();
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
        // certificates.
        internal void ProcessRecord_Certificate()
        {
            this._logger.name += " -Certificate";
            // Create new graphql operation certificates
            InitQueryCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCertificates.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Create new graphql operation clusterCertificates
            InitQueryClusterCertificates();
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

        // This parameter set invokes a single graphql operation:
        // certificatesWithKey.
        internal void ProcessRecord_WithKey()
        {
            this._logger.name += " -WithKey";
            // Create new graphql operation certificatesWithKey
            InitQueryCertificatesWithKey();
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
                Query.Certificates_ObjectFieldSpec,
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
                Query.ClusterCertificates_ObjectFieldSpec,
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
                Query.ClusterWebSignedCertificate_ObjectFieldSpec,
                Query.ClusterWebSignedCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Query.CertificateSigningRequest_ObjectFieldSpec,
                Query.CertificateSigningRequestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	csrId = $someInt64
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
                Query.CertificateSigningRequests_ObjectFieldSpec,
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
                Query.CertificatesWithKey_ObjectFieldSpec,
                Query.CertificatesWithKeyFieldSpec,
                @""
            );
        }


    } // class New_RscQueryCertificate
}
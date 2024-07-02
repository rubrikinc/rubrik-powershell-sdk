// New-RscQueryDownload.cs
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
    /// operations in the 'Report Download' API domain:
    /// CdmUpgradesPdf, DownloadedVersionList, or PackageStatus.
    /// </summary>
    /// <description>
    /// New-RscQueryDownload creates a new
    /// query object for operations
    /// in the 'Report Download' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 3 operations
    /// in the 'Report Download' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CdmUpgradesPdf, DownloadedVersionList, or PackageStatus.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryDownload -CdmUpgradesPdf).Info().
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
    /// (New-RscQueryDownload -CdmUpgradesPdf).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CdmUpgradesPdf operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: CdmUpgradesPdf
    /// 
    /// $query = New-RscQueryDownload -CdmUpgradesPdf
    /// 
    /// # OPTIONAL
    /// $query.Var.downloadFilter = @{
    /// 	# OPTIONAL
    /// 	clusterUuids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterNames = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterTypes = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	downloadedVersions = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	installedVersions = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterLocations = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	upgradeJobStatus = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	prechecksStatus = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	versionStatus = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadCdmUpgradesPdfReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DownloadedVersionList operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: DownloadedVersionList
    /// 
    /// $query = New-RscQueryDownload -DownloadedVersionList
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GroupCount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PackageStatus operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: PackageStatus
    /// 
    /// $query = New-RscQueryDownload -PackageStatus
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadPackageStatusReply
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
        "RscQueryDownload",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryDownload : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CdmUpgradesPdf",
                "DownloadedVersionList",
                "PackageStatus",
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
                    case "CdmUpgradesPdf":
                        this.ProcessRecord_CdmUpgradesPdf();
                        break;
                    case "DownloadedVersionList":
                        this.ProcessRecord_DownloadedVersionList();
                        break;
                    case "PackageStatus":
                        this.ProcessRecord_PackageStatus();
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
        // downloadCdmUpgradesPdf.
        internal void ProcessRecord_CdmUpgradesPdf()
        {
            this._logger.name += " -CdmUpgradesPdf";
            // Create new graphql operation downloadCdmUpgradesPdf
            InitQueryDownloadCdmUpgradesPdf();
        }

        // This parameter set invokes a single graphql operation:
        // downloadedVersionList.
        internal void ProcessRecord_DownloadedVersionList()
        {
            this._logger.name += " -DownloadedVersionList";
            // Create new graphql operation downloadedVersionList
            InitQueryDownloadedVersionList();
        }

        // This parameter set invokes a single graphql operation:
        // downloadPackageStatus.
        internal void ProcessRecord_PackageStatus()
        {
            this._logger.name += " -PackageStatus";
            // Create new graphql operation downloadPackageStatus
            InitQueryDownloadPackageStatus();
        }


        // Create new GraphQL Query:
        // downloadCdmUpgradesPdf(downloadFilter: DownloadCdmUpgradesPdfFiltersInput): DownloadCdmUpgradesPdfReply!
        internal void InitQueryDownloadCdmUpgradesPdf()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("downloadFilter", "DownloadCdmUpgradesPdfFiltersInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDownloadCdmUpgradesPdf",
                "($downloadFilter: DownloadCdmUpgradesPdfFiltersInput)",
                "DownloadCdmUpgradesPdfReply",
                Query.DownloadCdmUpgradesPdf,
                Query.DownloadCdmUpgradesPdfFieldSpec,
                @"# OPTIONAL
$query.Var.downloadFilter = @{
	# OPTIONAL
	clusterUuids = @(
		$someString
	)
	# OPTIONAL
	clusterNames = @(
		$someString
	)
	# OPTIONAL
	clusterTypes = @(
		$someString
	)
	# OPTIONAL
	downloadedVersions = @(
		$someString
	)
	# OPTIONAL
	installedVersions = @(
		$someString
	)
	# OPTIONAL
	clusterLocations = @(
		$someString
	)
	# OPTIONAL
	upgradeJobStatus = @(
		$someString
	)
	# OPTIONAL
	prechecksStatus = @(
		$someString
	)
	# OPTIONAL
	versionStatus = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // downloadedVersionList: [GroupCount!]!
        internal void InitQueryDownloadedVersionList()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryDownloadedVersionList",
                "",
                "List<GroupCount>",
                Query.DownloadedVersionList,
                Query.DownloadedVersionListFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // downloadPackageStatus(clusterUuid: UUID!): DownloadPackageStatusReply!
        internal void InitQueryDownloadPackageStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDownloadPackageStatus",
                "($clusterUuid: UUID!)",
                "DownloadPackageStatusReply",
                Query.DownloadPackageStatus,
                Query.DownloadPackageStatusFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }


    } // class New_RscQueryDownload
}
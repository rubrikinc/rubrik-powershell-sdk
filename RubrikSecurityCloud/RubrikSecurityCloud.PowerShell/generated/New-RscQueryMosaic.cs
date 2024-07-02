// New-RscQueryMosaic.cs
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
    /// operations in the 'Mosaic' API domain:
    /// BulkRecoveryRange, Snapshots, Stores, or Versions.
    /// </summary>
    /// <description>
    /// New-RscQueryMosaic creates a new
    /// query object for operations
    /// in the 'Mosaic' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Mosaic' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BulkRecoveryRange, Snapshots, Stores, or Versions.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryMosaic -BulkRecoveryRange).Info().
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
    /// (New-RscQueryMosaic -BulkRecoveryRange).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkRecoveryRange operation
    /// of the 'Mosaic' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mosaic
    /// # API Operation: BulkRecoveryRange
    /// 
    /// $query = New-RscQueryMosaic -BulkRecoveryRange
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	recoveryRangeData = @{
    /// 		# OPTIONAL
    /// 		sourceType = $someMosaicBulkRecoverableRangeRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicBulkRecoverableRangeRequestSourceType]) for enum values.
    /// 		# REQUIRED
    /// 		managementObjects = @{
    /// 			# OPTIONAL
    /// 			databases = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					dbName = $someString
    /// 					# OPTIONAL
    /// 					tables = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			)
    /// 		}
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicRecoveryRangeResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Snapshots operation
    /// of the 'Mosaic' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mosaic
    /// # API Operation: Snapshots
    /// 
    /// $query = New-RscQueryMosaic -Snapshots
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	versionData = @{
    /// 		# OPTIONAL
    /// 		maxEntries = $someInt
    /// 		# OPTIONAL
    /// 		since = $someInt
    /// 		# OPTIONAL
    /// 		upto = $someInt
    /// 		# OPTIONAL
    /// 		sourceType = $someVersionSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionSourceType]) for enum values.
    /// 		# REQUIRED
    /// 		databaseName = $someString
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 		# REQUIRED
    /// 		tableName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListVersionResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Stores operation
    /// of the 'Mosaic' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mosaic
    /// # API Operation: Stores
    /// 
    /// $query = New-RscQueryMosaic -Stores
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListStoreResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Versions operation
    /// of the 'Mosaic' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mosaic
    /// # API Operation: Versions
    /// 
    /// $query = New-RscQueryMosaic -Versions
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	versionData = @{
    /// 		# OPTIONAL
    /// 		maxEntries = $someInt
    /// 		# OPTIONAL
    /// 		since = $someInt
    /// 		# OPTIONAL
    /// 		upto = $someInt
    /// 		# OPTIONAL
    /// 		sourceType = $someVersionSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionSourceType]) for enum values.
    /// 		# REQUIRED
    /// 		databaseName = $someString
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 		# REQUIRED
    /// 		tableName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListVersionResponse
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
        "RscQueryMosaic",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryMosaic : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BulkRecoveryRange",
                "Snapshots",
                "Stores",
                "Versions",
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
                    case "BulkRecoveryRange":
                        this.ProcessRecord_BulkRecoveryRange();
                        break;
                    case "Snapshots":
                        this.ProcessRecord_Snapshots();
                        break;
                    case "Stores":
                        this.ProcessRecord_Stores();
                        break;
                    case "Versions":
                        this.ProcessRecord_Versions();
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
        // mosaicBulkRecoveryRange.
        internal void ProcessRecord_BulkRecoveryRange()
        {
            this._logger.name += " -BulkRecoveryRange";
            // Create new graphql operation mosaicBulkRecoveryRange
            InitQueryMosaicBulkRecoveryRange();
        }

        // This parameter set invokes a single graphql operation:
        // mosaicSnapshots.
        internal void ProcessRecord_Snapshots()
        {
            this._logger.name += " -Snapshots";
            // Create new graphql operation mosaicSnapshots
            InitQueryMosaicSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mosaicStores.
        internal void ProcessRecord_Stores()
        {
            this._logger.name += " -Stores";
            // Create new graphql operation mosaicStores
            InitQueryMosaicStores();
        }

        // This parameter set invokes a single graphql operation:
        // mosaicVersions.
        internal void ProcessRecord_Versions()
        {
            this._logger.name += " -Versions";
            // Create new graphql operation mosaicVersions
            InitQueryMosaicVersions();
        }


        // Create new GraphQL Query:
        // mosaicBulkRecoveryRange(input: MosaicBulkRecoveryRangeInput!): MosaicRecoveryRangeResponse!
        internal void InitQueryMosaicBulkRecoveryRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicBulkRecoveryRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMosaicBulkRecoveryRange",
                "($input: MosaicBulkRecoveryRangeInput!)",
                "MosaicRecoveryRangeResponse",
                Query.MosaicBulkRecoveryRange,
                Query.MosaicBulkRecoveryRangeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	recoveryRangeData = @{
		# OPTIONAL
		sourceType = $someMosaicBulkRecoverableRangeRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicBulkRecoverableRangeRequestSourceType]) for enum values.
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = $someString
					# OPTIONAL
					tables = @(
						$someString
					)
				}
			)
		}
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }

        // Create new GraphQL Query:
        // mosaicSnapshots(input: GetMosaicVersionInput!): ListVersionResponse!
        internal void InitQueryMosaicSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicVersionInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMosaicSnapshots",
                "($input: GetMosaicVersionInput!)",
                "ListVersionResponse",
                Query.MosaicSnapshots,
                Query.MosaicSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	versionData = @{
		# OPTIONAL
		maxEntries = $someInt
		# OPTIONAL
		since = $someInt
		# OPTIONAL
		upto = $someInt
		# OPTIONAL
		sourceType = $someVersionSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionSourceType]) for enum values.
		# REQUIRED
		databaseName = $someString
		# REQUIRED
		sourceName = $someString
		# REQUIRED
		tableName = $someString
	}
}"
            );
        }

        // Create new GraphQL Query:
        // mosaicStores(input: GetMosaicStoreInput!): ListStoreResponse!
        internal void InitQueryMosaicStores()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicStoreInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMosaicStores",
                "($input: GetMosaicStoreInput!)",
                "ListStoreResponse",
                Query.MosaicStores,
                Query.MosaicStoresFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // mosaicVersions(input: GetMosaicVersionInput!): ListVersionResponse!
        internal void InitQueryMosaicVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicVersionInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMosaicVersions",
                "($input: GetMosaicVersionInput!)",
                "ListVersionResponse",
                Query.MosaicVersions,
                Query.MosaicVersionsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	versionData = @{
		# OPTIONAL
		maxEntries = $someInt
		# OPTIONAL
		since = $someInt
		# OPTIONAL
		upto = $someInt
		# OPTIONAL
		sourceType = $someVersionSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionSourceType]) for enum values.
		# REQUIRED
		databaseName = $someString
		# REQUIRED
		sourceName = $someString
		# REQUIRED
		tableName = $someString
	}
}"
            );
        }


    } // class New_RscQueryMosaic
}
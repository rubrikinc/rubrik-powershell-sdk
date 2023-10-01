// New-RscMutationActivitySeries.cs
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
    /// operations in the 'Activity series' API domain:
    /// Cancel, DownloadUserCsv, or DownloadUserFileCsv.
    /// </summary>
    /// <description>
    /// New-RscMutationActivitySeries creates a new
    /// mutation object for operations
    /// in the 'Activity series' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 3 operations
    /// in the 'Activity series' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Cancel, DownloadUserCsv, or DownloadUserFileCsv.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationActivitySeries -Cancel).Info().
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
    /// (New-RscMutationActivitySeries -Cancel).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Cancel operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: Cancel
    /// 
    /// $query = New-RscMutationActivitySeries -Cancel
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	activitySeriesId = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
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
    /// Runs the DownloadUserCsv operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: DownloadUserCsv
    /// 
    /// $query = New-RscMutationActivitySeries -DownloadUserCsv
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	filters = @{
    /// 		# OPTIONAL
    /// 		openAccessTypes = @(
    /// 			$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		stalenessTypes = @(
    /// 			$someStalenessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StalenessType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		analyzerGroupIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		clusterIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		pathPrefix = $someString
    /// 		# OPTIONAL
    /// 		snappableTypes = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchText = $someString
    /// 		# OPTIONAL
    /// 		whitelistEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		fileCountTypes = @(
    /// 			$someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		accessTypes = @(
    /// 			$someAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		activityTypes = @(
    /// 			$someActivityAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityAccessType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		objectIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		inodeTypes = @(
    /// 			$someInodeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InodeType]) for enum values.
    /// 		)
    /// 		# REQUIRED
    /// 		objectTypes = @(
    /// 			$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	day = $someString
    /// 	# REQUIRED
    /// 	timezone = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DownloadUserFileCsv operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: DownloadUserFileCsv
    /// 
    /// $query = New-RscMutationActivitySeries -DownloadUserFileCsv
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	userId = $someString
    /// 	# REQUIRED
    /// 	snapshot = @{
    /// 		# OPTIONAL
    /// 		snappableFid = $someString
    /// 		# OPTIONAL
    /// 		snapshotFid = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	nativePath = $someString
    /// 	# REQUIRED
    /// 	timezone = $someString
    /// 	# REQUIRED
    /// 	startDay = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadCsvReply
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
        "RscMutationActivitySeries",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationActivitySeries : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Cancel",
                "DownloadUserCsv",
                "DownloadUserFileCsv",
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
                    case "Cancel":
                        this.ProcessRecord_Cancel();
                        break;
                    case "DownloadUserCsv":
                        this.ProcessRecord_DownloadUserCsv();
                        break;
                    case "DownloadUserFileCsv":
                        this.ProcessRecord_DownloadUserFileCsv();
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
        // cancelActivitySeries.
        internal void ProcessRecord_Cancel()
        {
            this._logger.name += " -Cancel";
            // Create new graphql operation cancelActivitySeries
            InitMutationCancelActivitySeries();
        }

        // This parameter set invokes a single graphql operation:
        // downloadUserActivityCsv.
        internal void ProcessRecord_DownloadUserCsv()
        {
            this._logger.name += " -DownloadUserCsv";
            // Create new graphql operation downloadUserActivityCsv
            InitMutationDownloadUserActivityCsv();
        }

        // This parameter set invokes a single graphql operation:
        // downloadUserFileActivityCsv.
        internal void ProcessRecord_DownloadUserFileCsv()
        {
            this._logger.name += " -DownloadUserFileCsv";
            // Create new graphql operation downloadUserFileActivityCsv
            InitMutationDownloadUserFileActivityCsv();
        }


        // Create new GraphQL Mutation:
        // cancelActivitySeries(input: CancelActivitySeriesInput!): Boolean!
        internal void InitMutationCancelActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelActivitySeries",
                "($input: CancelActivitySeriesInput!)",
                "System.Boolean",
                Mutation.CancelActivitySeries_ObjectFieldSpec,
                Mutation.CancelActivitySeriesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	activitySeriesId = $someString
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadUserActivityCsv(input: DownloadUserActivityCsvInput!): DownloadCsvReply!
        internal void InitMutationDownloadUserActivityCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadUserActivityCsvInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadUserActivityCsv",
                "($input: DownloadUserActivityCsvInput!)",
                "DownloadCsvReply",
                Mutation.DownloadUserActivityCsv_ObjectFieldSpec,
                Mutation.DownloadUserActivityCsvFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	filters = @{
		# OPTIONAL
		openAccessTypes = @(
			$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
		)
		# OPTIONAL
		stalenessTypes = @(
			$someStalenessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StalenessType]) for enum values.
		)
		# OPTIONAL
		analyzerGroupIds = @(
			$someString
		)
		# OPTIONAL
		clusterIds = @(
			$someString
		)
		# OPTIONAL
		pathPrefix = $someString
		# OPTIONAL
		snappableTypes = @(
			$someString
		)
		# OPTIONAL
		searchText = $someString
		# OPTIONAL
		whitelistEnabled = $someBoolean
		# OPTIONAL
		fileCountTypes = @(
			$someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
		)
		# OPTIONAL
		accessTypes = @(
			$someAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessType]) for enum values.
		)
		# OPTIONAL
		activityTypes = @(
			$someActivityAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityAccessType]) for enum values.
		)
		# OPTIONAL
		objectIds = @(
			$someString
		)
		# OPTIONAL
		inodeTypes = @(
			$someInodeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InodeType]) for enum values.
		)
		# REQUIRED
		objectTypes = @(
			$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
		)
	}
	# REQUIRED
	day = $someString
	# REQUIRED
	timezone = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadUserFileActivityCsv(input: DownloadUserFileActivityCsvInput!): DownloadCsvReply!
        internal void InitMutationDownloadUserFileActivityCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadUserFileActivityCsvInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadUserFileActivityCsv",
                "($input: DownloadUserFileActivityCsvInput!)",
                "DownloadCsvReply",
                Mutation.DownloadUserFileActivityCsv_ObjectFieldSpec,
                Mutation.DownloadUserFileActivityCsvFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	userId = $someString
	# REQUIRED
	snapshot = @{
		# OPTIONAL
		snappableFid = $someString
		# OPTIONAL
		snapshotFid = $someString
	}
	# REQUIRED
	nativePath = $someString
	# REQUIRED
	timezone = $someString
	# REQUIRED
	startDay = $someString
}"
            );
        }


    } // class New_RscMutationActivitySeries
}
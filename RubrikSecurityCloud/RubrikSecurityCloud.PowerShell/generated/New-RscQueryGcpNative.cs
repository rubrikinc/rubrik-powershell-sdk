// New-RscQueryGcpNative.cs
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
    /// Create a new RscQuery object for any of the 7
    /// operations in the 'Google Cloud Platform Native' API domain:
    /// Disk, Disks, GceInstance, GceInstances, Project, Projects, or StoredDiskLocations.
    /// </summary>
    /// <description>
    /// New-RscQueryGcpNative creates a new
    /// query object for operations
    /// in the 'Google Cloud Platform Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 7 operations
    /// in the 'Google Cloud Platform Native' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Disk, Disks, GceInstance, GceInstances, Project, Projects, or StoredDiskLocations.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryGcpNative -Disk).Info().
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
    /// (New-RscQueryGcpNative -Disk).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Disk operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: Disk
    /// 
    /// $query = New-RscQueryGcpNative -Disk
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpNativeDisk
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Disks operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: Disks
    /// 
    /// $query = New-RscQueryGcpNative -Disks
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
    /// $query.Var.sortBy = $someGcpNativeDiskSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeDiskSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.diskFilters = @{
    /// 	# OPTIONAL
    /// 	nameOrIdSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameOrIdSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	projectFilter = @{
    /// 		# REQUIRED
    /// 		projectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	locationFilter = @{
    /// 		# REQUIRED
    /// 		locations = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	diskTypeFilter = @{
    /// 		# REQUIRED
    /// 		diskTypes = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	labelFilter = @{
    /// 		# REQUIRED
    /// 		labelFilterParams = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				filterType = $someGcpNativeLabelFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeLabelFilterType]) for enum values.
    /// 				# REQUIRED
    /// 				labelKey = $someString
    /// 				# REQUIRED
    /// 				labelValue = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	orgFilter = @{
    /// 		# REQUIRED
    /// 		orgIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpNativeDiskConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GceInstance operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: GceInstance
    /// 
    /// $query = New-RscQueryGcpNative -GceInstance
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpNativeGceInstance
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GceInstances operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: GceInstances
    /// 
    /// $query = New-RscQueryGcpNative -GceInstances
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
    /// $query.Var.sortBy = $someGcpNativeGceInstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeGceInstanceSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.gceInstanceFilters = @{
    /// 	# OPTIONAL
    /// 	nameOrIdSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameOrIdSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	projectFilter = @{
    /// 		# REQUIRED
    /// 		projectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	machineTypeFilter = @{
    /// 		# REQUIRED
    /// 		machineTypes = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	networkFilter = @{
    /// 		# REQUIRED
    /// 		networkNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	labelFilter = @{
    /// 		# REQUIRED
    /// 		labelFilterParams = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				filterType = $someGcpNativeLabelFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeLabelFilterType]) for enum values.
    /// 				# REQUIRED
    /// 				labelKey = $someString
    /// 				# REQUIRED
    /// 				labelValue = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	orgFilter = @{
    /// 		# REQUIRED
    /// 		orgIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpNativeGceInstanceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Project operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: Project
    /// 
    /// $query = New-RscQueryGcpNative -Project
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpNativeProject
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Projects operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: Projects
    /// 
    /// $query = New-RscQueryGcpNative -Projects
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
    /// $query.Var.sortBy = $someGcpNativeProjectSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeProjectSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.projectFilters = @{
    /// 	# OPTIONAL
    /// 	nameOrNumberSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameOrNumberSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	idSubstringFilter = @{
    /// 		# REQUIRED
    /// 		idSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// # OPTIONAL
    /// $query.Var.authorizedOperationFilter = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// # OPTIONAL
    /// $query.Var.workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GcpNativeProjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StoredDiskLocations operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: StoredDiskLocations
    /// 
    /// $query = New-RscQueryGcpNative -StoredDiskLocations
    /// 
    /// # OPTIONAL
    /// $query.Var.projectId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListStoredDiskLocationsReply
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
        "RscQueryGcpNative",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryGcpNative : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Disk",
                "Disks",
                "GceInstance",
                "GceInstances",
                "Project",
                "Projects",
                "StoredDiskLocations",
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
                    case "Disk":
                        this.ProcessRecord_Disk();
                        break;
                    case "Disks":
                        this.ProcessRecord_Disks();
                        break;
                    case "GceInstance":
                        this.ProcessRecord_GceInstance();
                        break;
                    case "GceInstances":
                        this.ProcessRecord_GceInstances();
                        break;
                    case "Project":
                        this.ProcessRecord_Project();
                        break;
                    case "Projects":
                        this.ProcessRecord_Projects();
                        break;
                    case "StoredDiskLocations":
                        this.ProcessRecord_StoredDiskLocations();
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
        // gcpNativeDisk.
        internal void ProcessRecord_Disk()
        {
            this._logger.name += " -Disk";
            // Create new graphql operation gcpNativeDisk
            InitQueryGcpNativeDisk();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeDisks.
        internal void ProcessRecord_Disks()
        {
            this._logger.name += " -Disks";
            // Create new graphql operation gcpNativeDisks
            InitQueryGcpNativeDisks();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeGceInstance.
        internal void ProcessRecord_GceInstance()
        {
            this._logger.name += " -GceInstance";
            // Create new graphql operation gcpNativeGceInstance
            InitQueryGcpNativeGceInstance();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeGceInstances.
        internal void ProcessRecord_GceInstances()
        {
            this._logger.name += " -GceInstances";
            // Create new graphql operation gcpNativeGceInstances
            InitQueryGcpNativeGceInstances();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeProject.
        internal void ProcessRecord_Project()
        {
            this._logger.name += " -Project";
            // Create new graphql operation gcpNativeProject
            InitQueryGcpNativeProject();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeProjects.
        internal void ProcessRecord_Projects()
        {
            this._logger.name += " -Projects";
            // Create new graphql operation gcpNativeProjects
            InitQueryGcpNativeProjects();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeStoredDiskLocations.
        internal void ProcessRecord_StoredDiskLocations()
        {
            this._logger.name += " -StoredDiskLocations";
            // Create new graphql operation gcpNativeStoredDiskLocations
            InitQueryGcpNativeStoredDiskLocations();
        }


        // Create new GraphQL Query:
        // gcpNativeDisk(fid: UUID!): GcpNativeDisk!
        internal void InitQueryGcpNativeDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGcpNativeDisk",
                "($fid: UUID!)",
                "GcpNativeDisk",
                Query.GcpNativeDisk,
                Query.GcpNativeDiskFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // gcpNativeDisks(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: GcpNativeDiskSortFields
        //     sortOrder: SortOrder
        //     diskFilters: GcpNativeDiskFilters
        //   ): GcpNativeDiskConnection!
        internal void InitQueryGcpNativeDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "GcpNativeDiskSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("diskFilters", "GcpNativeDiskFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGcpNativeDisks",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: GcpNativeDiskSortFields,$sortOrder: SortOrder,$diskFilters: GcpNativeDiskFilters)",
                "GcpNativeDiskConnection",
                Query.GcpNativeDisks,
                Query.GcpNativeDisksFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someGcpNativeDiskSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeDiskSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.diskFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	projectFilter = @{
		# REQUIRED
		projectIds = @(
			$someString
		)
	}
	# OPTIONAL
	locationFilter = @{
		# REQUIRED
		locations = @(
			$someString
		)
	}
	# OPTIONAL
	diskTypeFilter = @{
		# REQUIRED
		diskTypes = @(
			$someString
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	labelFilter = @{
		# REQUIRED
		labelFilterParams = @(
			@{
				# REQUIRED
				filterType = $someGcpNativeLabelFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeLabelFilterType]) for enum values.
				# REQUIRED
				labelKey = $someString
				# REQUIRED
				labelValue = $someString
			}
		)
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // gcpNativeGceInstance(fid: UUID!): GcpNativeGceInstance!
        internal void InitQueryGcpNativeGceInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGcpNativeGceInstance",
                "($fid: UUID!)",
                "GcpNativeGceInstance",
                Query.GcpNativeGceInstance,
                Query.GcpNativeGceInstanceFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // gcpNativeGceInstances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: GcpNativeGceInstanceSortFields
        //     sortOrder: SortOrder
        //     gceInstanceFilters: GcpNativeGceInstanceFilters
        //   ): GcpNativeGceInstanceConnection!
        internal void InitQueryGcpNativeGceInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "GcpNativeGceInstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("gceInstanceFilters", "GcpNativeGceInstanceFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGcpNativeGceInstances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: GcpNativeGceInstanceSortFields,$sortOrder: SortOrder,$gceInstanceFilters: GcpNativeGceInstanceFilters)",
                "GcpNativeGceInstanceConnection",
                Query.GcpNativeGceInstances,
                Query.GcpNativeGceInstancesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someGcpNativeGceInstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeGceInstanceSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.gceInstanceFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = $someString
	}
	# OPTIONAL
	projectFilter = @{
		# REQUIRED
		projectIds = @(
			$someString
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someString
		)
	}
	# OPTIONAL
	machineTypeFilter = @{
		# REQUIRED
		machineTypes = @(
			$someString
		)
	}
	# OPTIONAL
	networkFilter = @{
		# REQUIRED
		networkNames = @(
			$someString
		)
	}
	# OPTIONAL
	labelFilter = @{
		# REQUIRED
		labelFilterParams = @(
			@{
				# REQUIRED
				filterType = $someGcpNativeLabelFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeLabelFilterType]) for enum values.
				# REQUIRED
				labelKey = $someString
				# REQUIRED
				labelValue = $someString
			}
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // gcpNativeProject(fid: UUID!): GcpNativeProject!
        internal void InitQueryGcpNativeProject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGcpNativeProject",
                "($fid: UUID!)",
                "GcpNativeProject",
                Query.GcpNativeProject,
                Query.GcpNativeProjectFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // gcpNativeProjects(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: GcpNativeProjectSortFields
        //     sortOrder: SortOrder
        //     projectFilters: GcpNativeProjectFilters
        //     authorizedOperationFilter: Operation
        //     workloadHierarchy: WorkloadLevelHierarchy
        //   ): GcpNativeProjectConnection!
        internal void InitQueryGcpNativeProjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "GcpNativeProjectSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("projectFilters", "GcpNativeProjectFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGcpNativeProjects",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: GcpNativeProjectSortFields,$sortOrder: SortOrder,$projectFilters: GcpNativeProjectFilters,$authorizedOperationFilter: Operation,$workloadHierarchy: WorkloadLevelHierarchy)",
                "GcpNativeProjectConnection",
                Query.GcpNativeProjects,
                Query.GcpNativeProjectsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someGcpNativeProjectSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeProjectSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.projectFilters = @{
	# OPTIONAL
	nameOrNumberSubstringFilter = @{
		# REQUIRED
		nameOrNumberSubstring = $someString
	}
	# OPTIONAL
	idSubstringFilter = @{
		# REQUIRED
		idSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
}
# OPTIONAL
$query.Var.authorizedOperationFilter = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# OPTIONAL
$query.Var.workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // gcpNativeStoredDiskLocations(projectId: UUID): ListStoredDiskLocationsReply!
        internal void InitQueryGcpNativeStoredDiskLocations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("projectId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGcpNativeStoredDiskLocations",
                "($projectId: UUID)",
                "ListStoredDiskLocationsReply",
                Query.GcpNativeStoredDiskLocations,
                Query.GcpNativeStoredDiskLocationsFieldSpec,
                @"# OPTIONAL
$query.Var.projectId = $someString"
            );
        }


    } // class New_RscQueryGcpNative
}
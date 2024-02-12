// New-RscQueryNcd.cs
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
    /// operations in the 'NAS Cloud Direct' API domain:
    /// BackEndCapacity, FrontEndCapacity, ObjectProtectionStatus, ObjectsOverTimeData, TaskData, UsageOverTimeData, or VmImageUrl.
    /// </summary>
    /// <description>
    /// New-RscQueryNcd creates a new
    /// query object for operations
    /// in the 'NAS Cloud Direct' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 7 operations
    /// in the 'NAS Cloud Direct' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BackEndCapacity, FrontEndCapacity, ObjectProtectionStatus, ObjectsOverTimeData, TaskData, UsageOverTimeData, or VmImageUrl.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryNcd -BackEndCapacity).Info().
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
    /// (New-RscQueryNcd -BackEndCapacity).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BackEndCapacity operation
    /// of the 'NAS Cloud Direct' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ncd
    /// # API Operation: BackEndCapacity
    /// 
    /// $query = New-RscQueryNcd -BackEndCapacity
    /// 
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NcdBackEndCapacity
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FrontEndCapacity operation
    /// of the 'NAS Cloud Direct' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ncd
    /// # API Operation: FrontEndCapacity
    /// 
    /// $query = New-RscQueryNcd -FrontEndCapacity
    /// 
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NcdFrontEndCapacity
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectProtectionStatus operation
    /// of the 'NAS Cloud Direct' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ncd
    /// # API Operation: ObjectProtectionStatus
    /// 
    /// $query = New-RscQueryNcd -ObjectProtectionStatus
    /// 
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NcdObjectProtectionStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectsOverTimeData operation
    /// of the 'NAS Cloud Direct' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ncd
    /// # API Operation: ObjectsOverTimeData
    /// 
    /// $query = New-RscQueryNcd -ObjectsOverTimeData
    /// 
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;NcdObjectsOverTimeData&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TaskData operation
    /// of the 'NAS Cloud Direct' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ncd
    /// # API Operation: TaskData
    /// 
    /// $query = New-RscQueryNcd -TaskData
    /// 
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;NcdTaskData&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UsageOverTimeData operation
    /// of the 'NAS Cloud Direct' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ncd
    /// # API Operation: UsageOverTimeData
    /// 
    /// $query = New-RscQueryNcd -UsageOverTimeData
    /// 
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;NcdUsageOverTimeData&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VmImageUrl operation
    /// of the 'NAS Cloud Direct' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ncd
    /// # API Operation: VmImageUrl
    /// 
    /// $query = New-RscQueryNcd -VmImageUrl
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	hypervisorType = $someNcdHypervisorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NcdHypervisorType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NcdVmImageUrl
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
        "RscQueryNcd",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryNcd : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BackEndCapacity",
                "FrontEndCapacity",
                "ObjectProtectionStatus",
                "ObjectsOverTimeData",
                "TaskData",
                "UsageOverTimeData",
                "VmImageUrl",
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
                    case "BackEndCapacity":
                        this.ProcessRecord_BackEndCapacity();
                        break;
                    case "FrontEndCapacity":
                        this.ProcessRecord_FrontEndCapacity();
                        break;
                    case "ObjectProtectionStatus":
                        this.ProcessRecord_ObjectProtectionStatus();
                        break;
                    case "ObjectsOverTimeData":
                        this.ProcessRecord_ObjectsOverTimeData();
                        break;
                    case "TaskData":
                        this.ProcessRecord_TaskData();
                        break;
                    case "UsageOverTimeData":
                        this.ProcessRecord_UsageOverTimeData();
                        break;
                    case "VmImageUrl":
                        this.ProcessRecord_VmImageUrl();
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
        // ncdBackEndCapacity.
        internal void ProcessRecord_BackEndCapacity()
        {
            this._logger.name += " -BackEndCapacity";
            // Create new graphql operation ncdBackEndCapacity
            InitQueryNcdBackEndCapacity();
        }

        // This parameter set invokes a single graphql operation:
        // ncdFrontEndCapacity.
        internal void ProcessRecord_FrontEndCapacity()
        {
            this._logger.name += " -FrontEndCapacity";
            // Create new graphql operation ncdFrontEndCapacity
            InitQueryNcdFrontEndCapacity();
        }

        // This parameter set invokes a single graphql operation:
        // ncdObjectProtectionStatus.
        internal void ProcessRecord_ObjectProtectionStatus()
        {
            this._logger.name += " -ObjectProtectionStatus";
            // Create new graphql operation ncdObjectProtectionStatus
            InitQueryNcdObjectProtectionStatus();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdObjectsOverTimeData.
        internal void ProcessRecord_ObjectsOverTimeData()
        {
            this._logger.name += " -ObjectsOverTimeData";
            // Create new graphql operation allNcdObjectsOverTimeData
            InitQueryAllNcdObjectsOverTimeData();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdTaskData.
        internal void ProcessRecord_TaskData()
        {
            this._logger.name += " -TaskData";
            // Create new graphql operation allNcdTaskData
            InitQueryAllNcdTaskData();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdUsageOverTimeData.
        internal void ProcessRecord_UsageOverTimeData()
        {
            this._logger.name += " -UsageOverTimeData";
            // Create new graphql operation allNcdUsageOverTimeData
            InitQueryAllNcdUsageOverTimeData();
        }

        // This parameter set invokes a single graphql operation:
        // ncdVmImageUrl.
        internal void ProcessRecord_VmImageUrl()
        {
            this._logger.name += " -VmImageUrl";
            // Create new graphql operation ncdVmImageUrl
            InitQueryNcdVmImageUrl();
        }


        // Create new GraphQL Query:
        // ncdBackEndCapacity(clusters: [UUID!]!): NcdBackEndCapacity
        internal void InitQueryNcdBackEndCapacity()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNcdBackEndCapacity",
                "($clusters: [UUID!]!)",
                "NcdBackEndCapacity",
                Query.NcdBackEndCapacity_ObjectFieldSpec,
                Query.NcdBackEndCapacityFieldSpec,
                @"# REQUIRED
$query.Var.clusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // ncdFrontEndCapacity(clusters: [UUID!]!): NcdFrontEndCapacity
        internal void InitQueryNcdFrontEndCapacity()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNcdFrontEndCapacity",
                "($clusters: [UUID!]!)",
                "NcdFrontEndCapacity",
                Query.NcdFrontEndCapacity_ObjectFieldSpec,
                Query.NcdFrontEndCapacityFieldSpec,
                @"# REQUIRED
$query.Var.clusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // ncdObjectProtectionStatus(clusters: [UUID!]!): NcdObjectProtectionStatus
        internal void InitQueryNcdObjectProtectionStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNcdObjectProtectionStatus",
                "($clusters: [UUID!]!)",
                "NcdObjectProtectionStatus",
                Query.NcdObjectProtectionStatus_ObjectFieldSpec,
                Query.NcdObjectProtectionStatusFieldSpec,
                @"# REQUIRED
$query.Var.clusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allNcdObjectsOverTimeData(clusters: [UUID!]!): [NcdObjectsOverTimeData!]!
        internal void InitQueryAllNcdObjectsOverTimeData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNcdObjectsOverTimeData",
                "($clusters: [UUID!]!)",
                "List<NcdObjectsOverTimeData>",
                Query.AllNcdObjectsOverTimeData_ObjectFieldSpec,
                Query.AllNcdObjectsOverTimeDataFieldSpec,
                @"# REQUIRED
$query.Var.clusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allNcdTaskData(clusters: [UUID!]!): [NcdTaskData!]!
        internal void InitQueryAllNcdTaskData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNcdTaskData",
                "($clusters: [UUID!]!)",
                "List<NcdTaskData>",
                Query.AllNcdTaskData_ObjectFieldSpec,
                Query.AllNcdTaskDataFieldSpec,
                @"# REQUIRED
$query.Var.clusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allNcdUsageOverTimeData(clusters: [UUID!]!): [NcdUsageOverTimeData!]!
        internal void InitQueryAllNcdUsageOverTimeData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNcdUsageOverTimeData",
                "($clusters: [UUID!]!)",
                "List<NcdUsageOverTimeData>",
                Query.AllNcdUsageOverTimeData_ObjectFieldSpec,
                Query.AllNcdUsageOverTimeDataFieldSpec,
                @"# REQUIRED
$query.Var.clusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // ncdVmImageUrl(input: VmImageUrlInput!): NcdVmImageUrl!
        internal void InitQueryNcdVmImageUrl()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VmImageUrlInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNcdVmImageUrl",
                "($input: VmImageUrlInput!)",
                "NcdVmImageUrl",
                Query.NcdVmImageUrl_ObjectFieldSpec,
                Query.NcdVmImageUrlFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	hypervisorType = $someNcdHypervisorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NcdHypervisorType]) for enum values.
}"
            );
        }


    } // class New_RscQueryNcd
}
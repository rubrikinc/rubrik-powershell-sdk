// New-RscQueryVmware.cs
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
    /// operations in the 'VMware' API domain:
    /// CdpStateInfos, IsManagementEnabled, MissedRecoverableRanges, or RecoverableRanges.
    /// </summary>
    /// <description>
    /// New-RscQueryVmware creates a new
    /// query object for operations
    /// in the 'VMware' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'VMware' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CdpStateInfos, IsManagementEnabled, MissedRecoverableRanges, or RecoverableRanges.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryVmware -CdpStateInfos).Info().
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
    /// (New-RscQueryVmware -CdpStateInfos).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CdpStateInfos operation
    /// of the 'VMware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vmware
    /// # API Operation: CdpStateInfos
    /// 
    /// $query = New-RscQueryVmware -CdpStateInfos
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
    /// Write-Host $result.GetType().Name # prints: List&lt;VmwareCdpStateInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsManagementEnabled operation
    /// of the 'VMware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vmware
    /// # API Operation: IsManagementEnabled
    /// 
    /// $query = New-RscQueryVmware -IsManagementEnabled
    /// 
    /// # No variables for this query.
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
    /// Runs the MissedRecoverableRanges operation
    /// of the 'VMware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vmware
    /// # API Operation: MissedRecoverableRanges
    /// 
    /// $query = New-RscQueryVmware -MissedRecoverableRanges
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	afterTime = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeTime = $someDateTime
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VmwareRecoverableRangeListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverableRanges operation
    /// of the 'VMware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vmware
    /// # API Operation: RecoverableRanges
    /// 
    /// $query = New-RscQueryVmware -RecoverableRanges
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	afterTime = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeTime = $someDateTime
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VmwareRecoverableRangeListResponse
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
        "RscQueryVmware",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryVmware : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CdpStateInfos",
                "IsManagementEnabled",
                "MissedRecoverableRanges",
                "RecoverableRanges",
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
                    case "CdpStateInfos":
                        this.ProcessRecord_CdpStateInfos();
                        break;
                    case "IsManagementEnabled":
                        this.ProcessRecord_IsManagementEnabled();
                        break;
                    case "MissedRecoverableRanges":
                        this.ProcessRecord_MissedRecoverableRanges();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
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
        // allVmwareCdpStateInfos.
        internal void ProcessRecord_CdpStateInfos()
        {
            this._logger.name += " -CdpStateInfos";
            // Create new graphql operation allVmwareCdpStateInfos
            InitQueryAllVmwareCdpStateInfos();
        }

        // This parameter set invokes a single graphql operation:
        // isVMwareManagementEnabled.
        internal void ProcessRecord_IsManagementEnabled()
        {
            this._logger.name += " -IsManagementEnabled";
            // Create new graphql operation isVMwareManagementEnabled
            InitQueryIsVmwareManagementEnabled();
        }

        // This parameter set invokes a single graphql operation:
        // vmwareMissedRecoverableRanges.
        internal void ProcessRecord_MissedRecoverableRanges()
        {
            this._logger.name += " -MissedRecoverableRanges";
            // Create new graphql operation vmwareMissedRecoverableRanges
            InitQueryVmwareMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // vmwareRecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Create new graphql operation vmwareRecoverableRanges
            InitQueryVmwareRecoverableRanges();
        }


        // Create new GraphQL Query:
        // allVmwareCdpStateInfos(ids: [String!]!): [VmwareCdpStateInfo!]!
        internal void InitQueryAllVmwareCdpStateInfos()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVmwareCdpStateInfos",
                "($ids: [String!]!)",
                "List<VmwareCdpStateInfo>",
                Query.AllVmwareCdpStateInfos_ObjectFieldSpec,
                Query.AllVmwareCdpStateInfosFieldSpec,
                @"# REQUIRED
$query.Var.ids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // isVMwareManagementEnabled: Boolean!
        internal void InitQueryIsVmwareManagementEnabled()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsVmwareManagementEnabled",
                "",
                "System.Boolean",
                Query.IsVmwareManagementEnabled_ObjectFieldSpec,
                Query.IsVmwareManagementEnabledFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // vmwareMissedRecoverableRanges(input: VmwareMissedRecoverableRangesInput!): VmwareRecoverableRangeListResponse!
        internal void InitQueryVmwareMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VmwareMissedRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVmwareMissedRecoverableRanges",
                "($input: VmwareMissedRecoverableRangesInput!)",
                "VmwareRecoverableRangeListResponse",
                Query.VmwareMissedRecoverableRanges_ObjectFieldSpec,
                Query.VmwareMissedRecoverableRangesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	afterTime = $someDateTime
	# OPTIONAL
	beforeTime = $someDateTime
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vmwareRecoverableRanges(input: VmwareRecoverableRangesInput!): VmwareRecoverableRangeListResponse!
        internal void InitQueryVmwareRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VmwareRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVmwareRecoverableRanges",
                "($input: VmwareRecoverableRangesInput!)",
                "VmwareRecoverableRangeListResponse",
                Query.VmwareRecoverableRanges_ObjectFieldSpec,
                Query.VmwareRecoverableRangesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	afterTime = $someDateTime
	# OPTIONAL
	beforeTime = $someDateTime
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscQueryVmware
}
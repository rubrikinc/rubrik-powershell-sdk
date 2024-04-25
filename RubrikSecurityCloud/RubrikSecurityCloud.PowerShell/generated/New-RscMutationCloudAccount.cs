// New-RscMutationCloudAccount.cs
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
    /// Create a new RscQuery object for any of the 2
    /// operations in the 'Cloud Account' API domain:
    /// MapExocomputeAccount, or UnmapExocomputeAccount.
    /// </summary>
    /// <description>
    /// New-RscMutationCloudAccount creates a new
    /// mutation object for operations
    /// in the 'Cloud Account' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 2 operations
    /// in the 'Cloud Account' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: MapExocomputeAccount, or UnmapExocomputeAccount.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationCloudAccount -MapExocomputeAccount).Info().
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
    /// (New-RscMutationCloudAccount -MapExocomputeAccount).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the MapExocomputeAccount operation
    /// of the 'Cloud Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudAccount
    /// # API Operation: MapExocomputeAccount
    /// 
    /// $query = New-RscMutationCloudAccount -MapExocomputeAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	exocomputeCloudAccountId = $someString
    /// 	# REQUIRED
    /// 	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MapCloudAccountExocomputeAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnmapExocomputeAccount operation
    /// of the 'Cloud Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudAccount
    /// # API Operation: UnmapExocomputeAccount
    /// 
    /// $query = New-RscMutationCloudAccount -UnmapExocomputeAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UnmapCloudAccountExocomputeAccountReply
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
        "RscMutationCloudAccount",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationCloudAccount : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "MapExocomputeAccount",
                "UnmapExocomputeAccount",
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
                    case "MapExocomputeAccount":
                        this.ProcessRecord_MapExocomputeAccount();
                        break;
                    case "UnmapExocomputeAccount":
                        this.ProcessRecord_UnmapExocomputeAccount();
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
        // mapCloudAccountExocomputeAccount.
        internal void ProcessRecord_MapExocomputeAccount()
        {
            this._logger.name += " -MapExocomputeAccount";
            // Create new graphql operation mapCloudAccountExocomputeAccount
            InitMutationMapCloudAccountExocomputeAccount();
        }

        // This parameter set invokes a single graphql operation:
        // unmapCloudAccountExocomputeAccount.
        internal void ProcessRecord_UnmapExocomputeAccount()
        {
            this._logger.name += " -UnmapExocomputeAccount";
            // Create new graphql operation unmapCloudAccountExocomputeAccount
            InitMutationUnmapCloudAccountExocomputeAccount();
        }


        // Create new GraphQL Mutation:
        // mapCloudAccountExocomputeAccount(input: MapCloudAccountExocomputeAccountInput!): MapCloudAccountExocomputeAccountReply!
        internal void InitMutationMapCloudAccountExocomputeAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapCloudAccountExocomputeAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapCloudAccountExocomputeAccount",
                "($input: MapCloudAccountExocomputeAccountInput!)",
                "MapCloudAccountExocomputeAccountReply",
                Mutation.MapCloudAccountExocomputeAccount,
                Mutation.MapCloudAccountExocomputeAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
	# REQUIRED
	exocomputeCloudAccountId = $someString
	# REQUIRED
	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // unmapCloudAccountExocomputeAccount(input: UnmapCloudAccountExocomputeAccountInput!): UnmapCloudAccountExocomputeAccountReply!
        internal void InitMutationUnmapCloudAccountExocomputeAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapCloudAccountExocomputeAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnmapCloudAccountExocomputeAccount",
                "($input: UnmapCloudAccountExocomputeAccountInput!)",
                "UnmapCloudAccountExocomputeAccountReply",
                Mutation.UnmapCloudAccountExocomputeAccount,
                Mutation.UnmapCloudAccountExocomputeAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
	# REQUIRED
	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
}"
            );
        }


    } // class New_RscMutationCloudAccount
}
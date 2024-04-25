// New-RscMutationSharepoint.cs
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
    /// Create a new RscQuery object for any of the 1
    /// operations in the 'Sharepoint' API domain:
    /// ['ExcludeObjectsFromProtection'].
    /// </summary>
    /// <description>
    /// New-RscMutationSharepoint creates a new
    /// mutation object for operations
    /// in the 'Sharepoint' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 1 operations
    /// in the 'Sharepoint' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ['ExcludeObjectsFromProtection'].
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationSharepoint -ExcludeObjectsFromProtection).Info().
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
    /// (New-RscMutationSharepoint -ExcludeObjectsFromProtection).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ExcludeObjectsFromProtection operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: ExcludeObjectsFromProtection
    /// 
    /// $query = New-RscMutationSharepoint -ExcludeObjectsFromProtection
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	exclusions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			siteFid = $someString
    /// 			# REQUIRED
    /// 			excludedObjects = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					fid = $someString
    /// 					# REQUIRED
    /// 					name = $someString
    /// 					# REQUIRED
    /// 					url = $someString
    /// 					# REQUIRED
    /// 					objectType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values.
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
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
        "RscMutationSharepoint",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationSharepoint : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ExcludeObjectsFromProtection",
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
                    case "ExcludeObjectsFromProtection":
                        this.ProcessRecord_ExcludeObjectsFromProtection();
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
        // excludeSharepointObjectsFromProtection.
        internal void ProcessRecord_ExcludeObjectsFromProtection()
        {
            this._logger.name += " -ExcludeObjectsFromProtection";
            // Create new graphql operation excludeSharepointObjectsFromProtection
            InitMutationExcludeSharepointObjectsFromProtection();
        }


        // Create new GraphQL Mutation:
        // excludeSharepointObjectsFromProtection(input: ExcludeSharepointObjectsFromProtectionInput!): Void
        internal void InitMutationExcludeSharepointObjectsFromProtection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeSharepointObjectsFromProtectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeSharepointObjectsFromProtection",
                "($input: ExcludeSharepointObjectsFromProtectionInput!)",
                "System.String",
                Mutation.ExcludeSharepointObjectsFromProtection,
                Mutation.ExcludeSharepointObjectsFromProtectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	exclusions = @(
		@{
			# REQUIRED
			siteFid = $someString
			# REQUIRED
			excludedObjects = @(
				@{
					# REQUIRED
					fid = $someString
					# REQUIRED
					name = $someString
					# REQUIRED
					url = $someString
					# REQUIRED
					objectType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values.
				}
			)
		}
	)
}"
            );
        }


    } // class New_RscMutationSharepoint
}
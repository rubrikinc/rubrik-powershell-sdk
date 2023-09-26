// New-RscMutationAzureO365.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
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
    /// operations in the 'AzureO365' API domain:
    /// ['SetupExocompute'].
    /// </summary>
    /// <description>
    /// New-RscMutationAzureO365 creates a new
    /// mutation object for operations
    /// in the 'AzureO365' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 1 operations
    /// in the 'AzureO365' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -SetupExocompute.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op SetupExocompute,
    /// which is equivalent to specifying -SetupExocompute.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationAzureO365 -SetupExocompute).Info().
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
    /// (New-RscMutationAzureO365 -SetupExocompute).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the SetupExocompute operation
    /// of the 'AzureO365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: SetupExocompute
    /// 
    /// $query = New-RscMutationAzureO365 -SetupExocompute
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.exocomputeConfig = @{
    /// 	# REQUIRED
    /// 	regionName = $someString
    /// 	# OPTIONAL
    /// 	newGroupConfig = @{
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	existingGroupConfig = @{
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	newComputeConfig = @{
    /// 		# OPTIONAL
    /// 		vnetName = $someString
    /// 		# OPTIONAL
    /// 		subnetName = $someString
    /// 		# OPTIONAL
    /// 		securityGroupName = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	existingComputeConfig = @{
    /// 		# OPTIONAL
    /// 		vnetId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	newStorageAccountConfig = @{
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		tier = $someStorageAccountTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountTier]) for enum values.
    /// 		# OPTIONAL
    /// 		sku = $someStorageAccountSku # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountSku]) for enum values.
    /// 		# OPTIONAL
    /// 		storages = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				name = $someString
    /// 				# OPTIONAL
    /// 				tier = $someStorageAccountTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountTier]) for enum values.
    /// 				# OPTIONAL
    /// 				sku = $someStorageAccountSku # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountSku]) for enum values.
    /// 				# OPTIONAL
    /// 				containerImmutabilityStatus = $someColossusStorageContainerImmutabilityStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColossusStorageContainerImmutabilityStatus]) for enum values.
    /// 				# OPTIONAL
    /// 				versioningEnabled = $someBoolean
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	existingStorageAccountConfig = @{
    /// 		# OPTIONAL
    /// 		id = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetupAzureO365ExocomputeResp
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
        "RscMutationAzureO365",
        DefaultParameterSetName = "SetupExocompute")
    ]
    public class New_RscMutationAzureO365 : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "SetupExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'SetupExocompute' operation
in the 'AzureO365' API domain.
Description of the operation:
Sets up Exocompute for an O365 subscription.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/setupazureo365exocompute.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter SetupExocompute { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "SetupExocompute":
                        this.ProcessRecord_SetupExocompute();
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
        // setupAzureO365Exocompute.
        internal void ProcessRecord_SetupExocompute()
        {
            this._logger.name += " -SetupExocompute";
            // Create new graphql operation setupAzureO365Exocompute
            InitMutationSetupAzureO365Exocompute();
        }


        // Create new GraphQL Mutation:
        // setupAzureO365Exocompute(tenantId: String!, subscriptionId: UUID!, exocomputeConfig: AzureO365ExocomputeConfig!): SetupAzureO365ExocomputeResp!
        internal void InitMutationSetupAzureO365Exocompute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("exocomputeConfig", "AzureO365ExocomputeConfig!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetupAzureO365Exocompute",
                "($tenantId: String!,$subscriptionId: UUID!,$exocomputeConfig: AzureO365ExocomputeConfig!)",
                "SetupAzureO365ExocomputeResp",
                Mutation.SetupAzureO365Exocompute_ObjectFieldSpec,
                Mutation.SetupAzureO365ExocomputeFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.exocomputeConfig = @{
	# REQUIRED
	regionName = $someString
	# OPTIONAL
	newGroupConfig = @{
		# OPTIONAL
		name = $someString
	}
	# OPTIONAL
	existingGroupConfig = @{
		# OPTIONAL
		name = $someString
	}
	# OPTIONAL
	newComputeConfig = @{
		# OPTIONAL
		vnetName = $someString
		# OPTIONAL
		subnetName = $someString
		# OPTIONAL
		securityGroupName = $someString
	}
	# OPTIONAL
	existingComputeConfig = @{
		# OPTIONAL
		vnetId = $someString
		# OPTIONAL
		subnetId = $someString
	}
	# OPTIONAL
	newStorageAccountConfig = @{
		# OPTIONAL
		name = $someString
		# OPTIONAL
		tier = $someStorageAccountTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountTier]) for enum values.
		# OPTIONAL
		sku = $someStorageAccountSku # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountSku]) for enum values.
		# OPTIONAL
		storages = @(
			@{
				# OPTIONAL
				name = $someString
				# OPTIONAL
				tier = $someStorageAccountTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountTier]) for enum values.
				# OPTIONAL
				sku = $someStorageAccountSku # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountSku]) for enum values.
				# OPTIONAL
				containerImmutabilityStatus = $someColossusStorageContainerImmutabilityStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColossusStorageContainerImmutabilityStatus]) for enum values.
				# OPTIONAL
				versioningEnabled = $someBoolean
			}
		)
	}
	# OPTIONAL
	existingStorageAccountConfig = @{
		# OPTIONAL
		id = $someString
	}
}"
            );
        }


    } // class New_RscMutationAzureO365
}
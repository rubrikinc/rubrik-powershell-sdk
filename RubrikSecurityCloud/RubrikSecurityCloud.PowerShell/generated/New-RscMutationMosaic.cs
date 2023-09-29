// New-RscMutationMosaic.cs
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
    /// Create a new RscQuery object for any of the 3
    /// operations in the 'Mosaic' API domain:
    /// AddStore, DeleteStore, or UpdateStore.
    /// </summary>
    /// <description>
    /// New-RscMutationMosaic creates a new
    /// mutation object for operations
    /// in the 'Mosaic' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 3 operations
    /// in the 'Mosaic' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -AddStore, -DeleteStore, -UpdateStore.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op AddStore,
    /// which is equivalent to specifying -AddStore.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMosaic -AddStore).Info().
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
    /// (New-RscMutationMosaic -AddStore).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddStore operation
    /// of the 'Mosaic' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mosaic
    /// # API Operation: AddStore
    /// 
    /// $query = New-RscMutationMosaic -AddStore
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	addStoreData = @{
    /// 		# OPTIONAL
    /// 		accessKeyId = $someString
    /// 		# OPTIONAL
    /// 		nfsServer = $someString
    /// 		# OPTIONAL
    /// 		nfsServerMountPath = $someString
    /// 		# OPTIONAL
    /// 		secretKey = $someString
    /// 		# OPTIONAL
    /// 		skipKeyFileConfig = $someBoolean
    /// 		# REQUIRED
    /// 		storeType = $someMosaicAddStoreRequestStoreType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicAddStoreRequestStoreType]) for enum values.
    /// 		# REQUIRED
    /// 		storeName = $someString
    /// 		# REQUIRED
    /// 		storeUrl = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteStore operation
    /// of the 'Mosaic' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mosaic
    /// # API Operation: DeleteStore
    /// 
    /// $query = New-RscMutationMosaic -DeleteStore
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	storeName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateStore operation
    /// of the 'Mosaic' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mosaic
    /// # API Operation: UpdateStore
    /// 
    /// $query = New-RscMutationMosaic -UpdateStore
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	modifyStoreData = @{
    /// 		# OPTIONAL
    /// 		accessKeyId = $someString
    /// 		# OPTIONAL
    /// 		secretKey = $someString
    /// 		# OPTIONAL
    /// 		skipKeyFileConfig = $someBoolean
    /// 		# REQUIRED
    /// 		storeName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
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
        "RscMutationMosaic",
        DefaultParameterSetName = "AddStore")
    ]
    public class New_RscMutationMosaic : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "AddStore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AddStore' operation
in the 'Mosaic' API domain.
Description of the operation:
Add a New Store

Supported in m3.2.0-m4.2.0
Add a new store to Mosaic cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/addmosaicstore.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AddStore { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteStore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteStore' operation
in the 'Mosaic' API domain.
Description of the operation:
Remove the store by store_name

Supported in m3.2.0-m4.2.0
Remove a store from Mosaic cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletemosaicstore.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteStore { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateStore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateStore' operation
in the 'Mosaic' API domain.
Description of the operation:
Modify a store

Supported in m3.2.0-m4.2.0.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatemosaicstore.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateStore { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AddStore":
                        this.ProcessRecord_AddStore();
                        break;
                    case "DeleteStore":
                        this.ProcessRecord_DeleteStore();
                        break;
                    case "UpdateStore":
                        this.ProcessRecord_UpdateStore();
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
        // addMosaicStore.
        internal void ProcessRecord_AddStore()
        {
            this._logger.name += " -AddStore";
            // Create new graphql operation addMosaicStore
            InitMutationAddMosaicStore();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMosaicStore.
        internal void ProcessRecord_DeleteStore()
        {
            this._logger.name += " -DeleteStore";
            // Create new graphql operation deleteMosaicStore
            InitMutationDeleteMosaicStore();
        }

        // This parameter set invokes a single graphql operation:
        // updateMosaicStore.
        internal void ProcessRecord_UpdateStore()
        {
            this._logger.name += " -UpdateStore";
            // Create new graphql operation updateMosaicStore
            InitMutationUpdateMosaicStore();
        }


        // Create new GraphQL Mutation:
        // addMosaicStore(input: AddMosaicStoreInput!): MosaicAsyncResponse!
        internal void InitMutationAddMosaicStore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMosaicStoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddMosaicStore",
                "($input: AddMosaicStoreInput!)",
                "MosaicAsyncResponse",
                Mutation.AddMosaicStore_ObjectFieldSpec,
                Mutation.AddMosaicStoreFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	addStoreData = @{
		# OPTIONAL
		accessKeyId = $someString
		# OPTIONAL
		nfsServer = $someString
		# OPTIONAL
		nfsServerMountPath = $someString
		# OPTIONAL
		secretKey = $someString
		# OPTIONAL
		skipKeyFileConfig = $someBoolean
		# REQUIRED
		storeType = $someMosaicAddStoreRequestStoreType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicAddStoreRequestStoreType]) for enum values.
		# REQUIRED
		storeName = $someString
		# REQUIRED
		storeUrl = $someString
	}
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMosaicStore(input: DeleteMosaicStoreInput!): MosaicAsyncResponse!
        internal void InitMutationDeleteMosaicStore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMosaicStoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMosaicStore",
                "($input: DeleteMosaicStoreInput!)",
                "MosaicAsyncResponse",
                Mutation.DeleteMosaicStore_ObjectFieldSpec,
                Mutation.DeleteMosaicStoreFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	storeName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateMosaicStore(input: ModifyMosaicStoreInput!): MosaicAsyncResponse!
        internal void InitMutationUpdateMosaicStore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyMosaicStoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMosaicStore",
                "($input: ModifyMosaicStoreInput!)",
                "MosaicAsyncResponse",
                Mutation.UpdateMosaicStore_ObjectFieldSpec,
                Mutation.UpdateMosaicStoreFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	modifyStoreData = @{
		# OPTIONAL
		accessKeyId = $someString
		# OPTIONAL
		secretKey = $someString
		# OPTIONAL
		skipKeyFileConfig = $someBoolean
		# REQUIRED
		storeName = $someString
	}
}"
            );
        }


    } // class New_RscMutationMosaic
}
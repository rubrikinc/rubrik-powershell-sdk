// Invoke-RscQueryNutanix.cs
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

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryNutanix",
        DefaultParameterSetName = "Cluster")
    ]
    public class Invoke_RscQueryNutanix : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Topleveldescendant parameter set
        //
        // [GraphQL: nutanixTopLevelDescendants]
        //
        [Parameter(
            ParameterSetName = "Topleveldescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level Nutanix Objects accessible by the current user.
[GraphQL: nutanixTopLevelDescendants]",
            Position = 0
        )]
        public SwitchParameter Topleveldescendant { get; set; }

        [Parameter(
            ParameterSetName = "Topleveldescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort hierarchy objects by hierarchy field.
GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sorting order for the results.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Types of objects to include.
GraphQL argument typeFilter: [HierarchyObjectTypeEnum!]"
        )]
        public List<HierarchyObjectTypeEnum>? TypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The hierarchy object filter.
GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // Topleveldescendantsv2 parameter set
        //
        // [GraphQL: nutanixTopLevelDescendantsV2]
        //
        [Parameter(
            ParameterSetName = "Topleveldescendantsv2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level Nutanix Objects accessible by the current user.
[GraphQL: nutanixTopLevelDescendantsV2]",
            Position = 0
        )]
        public SwitchParameter Topleveldescendantsv2 { get; set; }

        
        // -------------------------------------------------------------------
        // Cluster parameter set
        //
        // [GraphQL: nutanixCluster]
        //
        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Nutanix Cluster.
[GraphQL: nutanixCluster]",
            Position = 0
        )]
        public SwitchParameter Cluster { get; set; }

        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik UUID for the object.
GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // Prismcentral parameter set
        //
        // [GraphQL: nutanixPrismCentrals]
        //
        [Parameter(
            ParameterSetName = "Prismcentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Nutanix Prism Central objects.
[GraphQL: nutanixPrismCentrals]",
            Position = 0
        )]
        public SwitchParameter Prismcentral { get; set; }

        
        // -------------------------------------------------------------------
        // Categorie parameter set
        //
        // [GraphQL: nutanixCategories]
        //
        [Parameter(
            ParameterSetName = "Categorie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Nutanix Category objects.
[GraphQL: nutanixCategories]",
            Position = 0
        )]
        public SwitchParameter Categorie { get; set; }

        
        // -------------------------------------------------------------------
        // Categoryvalue parameter set
        //
        // [GraphQL: nutanixCategoryValues]
        //
        [Parameter(
            ParameterSetName = "Categoryvalue",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Nutanix Category Value objects.
[GraphQL: nutanixCategoryValues]",
            Position = 0
        )]
        public SwitchParameter Categoryvalue { get; set; }

        
        // -------------------------------------------------------------------
        // Categoryvaluevm parameter set
        //
        // [GraphQL: nutanixCategoryValueVms]
        //
        [Parameter(
            ParameterSetName = "Categoryvaluevm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Nutanix Virtual Machines in a Category Value.
[GraphQL: nutanixCategoryValueVms]",
            Position = 0
        )]
        public SwitchParameter Categoryvaluevm { get; set; }

        
        // -------------------------------------------------------------------
        // Vm parameter set
        //
        // [GraphQL: nutanixVm]
        //
        [Parameter(
            ParameterSetName = "Vm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Nutanix Virtual Machine.
[GraphQL: nutanixVm]",
            Position = 0
        )]
        public SwitchParameter Vm { get; set; }

        
        // -------------------------------------------------------------------
        // Mount parameter set
        //
        // [GraphQL: nutanixMounts]
        //
        [Parameter(
            ParameterSetName = "Mount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Nutanix Live Mount Connection.
[GraphQL: nutanixMounts]",
            Position = 0
        )]
        public SwitchParameter Mount { get; set; }

        [Parameter(
            ParameterSetName = "Mount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Filter for Nutanix virtual machine live mounts.
GraphQL argument filters: [NutanixLiveMountFilterInput!]"
        )]
        public List<NutanixLiveMountFilterInput>? Filters { get; set; }
        
        // -------------------------------------------------------------------
        // Clustercontainer parameter set
        //
        // [GraphQL: nutanixClusterContainers]
        //
        [Parameter(
            ParameterSetName = "Clustercontainer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get list of containers on this cluster

Supported in v5.0+
Query the nutanix cluster to get the list of containers, used for export purposes.
[GraphQL: nutanixClusterContainers]",
            Position = 0
        )]
        public SwitchParameter Clustercontainer { get; set; }

        [Parameter(
            ParameterSetName = "Clustercontainer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for InternalGetContainers.
GraphQL argument input: GetContainersInput!"
        )]
        public GetContainersInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Clusternetwork parameter set
        //
        // [GraphQL: nutanixClusterNetworks]
        //
        [Parameter(
            ParameterSetName = "Clusternetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get list of networks on this cluster

Supported in v8.1+
Retrieves the list of networks by querying the Nutanix cluster. The list of networks is used for restore purposes.
[GraphQL: nutanixClusterNetworks]",
            Position = 0
        )]
        public SwitchParameter Clusternetwork { get; set; }

        
        // -------------------------------------------------------------------
        // Clusterasyncrequeststatus parameter set
        //
        // [GraphQL: nutanixClusterAsyncRequestStatus]
        //
        [Parameter(
            ParameterSetName = "Clusterasyncrequeststatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get Nutanix cluster async request

Supported in v5.0+
Get details about a Nutanix cluster-related async request.
[GraphQL: nutanixClusterAsyncRequestStatus]",
            Position = 0
        )]
        public SwitchParameter Clusterasyncrequeststatus { get; set; }

        
        // -------------------------------------------------------------------
        // Vmasyncrequeststatus parameter set
        //
        // [GraphQL: nutanixVmAsyncRequestStatus]
        //
        [Parameter(
            ParameterSetName = "Vmasyncrequeststatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Get VM async request details
v8.1+: Get virtual machine async request details

Supported in v5.0+
v5.0-v8.0: Get details about a Nutanix VM-related async request.
v8.1+: Get details about a Nutanix virtual machine-related async request.
[GraphQL: nutanixVmAsyncRequestStatus]",
            Position = 0
        )]
        public SwitchParameter Vmasyncrequeststatus { get; set; }

        
        // -------------------------------------------------------------------
        // Searchvm parameter set
        //
        // [GraphQL: searchNutanixVm]
        //
        [Parameter(
            ParameterSetName = "Searchvm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Search for file in Nutanix VM
v8.1+: Search for file in Nutanix virtual machine

Supported in v5.0+
Search for a file within the Nutanix Virtual Machine. Search via full path prefix or filename prefix.
[GraphQL: searchNutanixVm]",
            Position = 0
        )]
        public SwitchParameter Searchvm { get; set; }

        
        // -------------------------------------------------------------------
        // Vmmissedsnapshot parameter set
        //
        // [GraphQL: nutanixVmMissedSnapshots]
        //
        [Parameter(
            ParameterSetName = "Vmmissedsnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Get details about missed snapshots for a VM
v8.1+: Get details about missed snapshots for a virtual machine

Supported in v5.0+
v5.0-v8.0: Retrieve the time of the day when the snapshots were missed specific to a vm.
v8.1+: Retrieve the time of the day when the snapshots were missed specific to a virtual machine.
[GraphQL: nutanixVmMissedSnapshots]",
            Position = 0
        )]
        public SwitchParameter Vmmissedsnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Browsesnapshot parameter set
        //
        // [GraphQL: nutanixBrowseSnapshot]
        //
        [Parameter(
            ParameterSetName = "Browsesnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Lists all files in VM snapshot
v8.1+: Lists all files in virtual machine snapshot

Supported in v5.0+
Lists all files and directories in a given path.
[GraphQL: nutanixBrowseSnapshot]",
            Position = 0
        )]
        public SwitchParameter Browsesnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Snapshotdetail parameter set
        //
        // [GraphQL: nutanixSnapshotDetail]
        //
        [Parameter(
            ParameterSetName = "Snapshotdetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Supported in v5.0+. Get Nutanix virtual machine snapshot details.
 Retrieve detailed information about a snapshot.
[GraphQL: nutanixSnapshotDetail]",
            Position = 0
        )]
        public SwitchParameter Snapshotdetail { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Topleveldescendant":
                        this.ProcessRecord_Topleveldescendant();
                        break;
                    case "Topleveldescendantsv2":
                        this.ProcessRecord_Topleveldescendantsv2();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "Prismcentral":
                        this.ProcessRecord_Prismcentral();
                        break;
                    case "Categorie":
                        this.ProcessRecord_Categorie();
                        break;
                    case "Categoryvalue":
                        this.ProcessRecord_Categoryvalue();
                        break;
                    case "Categoryvaluevm":
                        this.ProcessRecord_Categoryvaluevm();
                        break;
                    case "Vm":
                        this.ProcessRecord_Vm();
                        break;
                    case "Mount":
                        this.ProcessRecord_Mount();
                        break;
                    case "Clustercontainer":
                        this.ProcessRecord_Clustercontainer();
                        break;
                    case "Clusternetwork":
                        this.ProcessRecord_Clusternetwork();
                        break;
                    case "Clusterasyncrequeststatus":
                        this.ProcessRecord_Clusterasyncrequeststatus();
                        break;
                    case "Vmasyncrequeststatus":
                        this.ProcessRecord_Vmasyncrequeststatus();
                        break;
                    case "Searchvm":
                        this.ProcessRecord_Searchvm();
                        break;
                    case "Vmmissedsnapshot":
                        this.ProcessRecord_Vmmissedsnapshot();
                        break;
                    case "Browsesnapshot":
                        this.ProcessRecord_Browsesnapshot();
                        break;
                    case "Snapshotdetail":
                        this.ProcessRecord_Snapshotdetail();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // nutanixTopLevelDescendants.
        protected void ProcessRecord_Topleveldescendant()
        {
            this._logger.name += " -Topleveldescendant";
            // Invoke graphql operation nutanixTopLevelDescendants
            InvokeQueryNutanixTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixTopLevelDescendantsV2.
        protected void ProcessRecord_Topleveldescendantsv2()
        {
            this._logger.name += " -Topleveldescendantsv2";
            // Invoke graphql operation nutanixTopLevelDescendantsV2
            InvokeQueryNutanixTopLevelDescendantsV2();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCluster.
        protected void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Invoke graphql operation nutanixCluster
            InvokeQueryNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixPrismCentrals.
        protected void ProcessRecord_Prismcentral()
        {
            this._logger.name += " -Prismcentral";
            // Invoke graphql operation nutanixPrismCentrals
            InvokeQueryNutanixPrismCentrals();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCategories.
        protected void ProcessRecord_Categorie()
        {
            this._logger.name += " -Categorie";
            // Invoke graphql operation nutanixCategories
            InvokeQueryNutanixCategories();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCategoryValues.
        protected void ProcessRecord_Categoryvalue()
        {
            this._logger.name += " -Categoryvalue";
            // Invoke graphql operation nutanixCategoryValues
            InvokeQueryNutanixCategoryValues();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCategoryValueVms.
        protected void ProcessRecord_Categoryvaluevm()
        {
            this._logger.name += " -Categoryvaluevm";
            // Invoke graphql operation nutanixCategoryValueVms
            InvokeQueryNutanixCategoryValueVms();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVm.
        protected void ProcessRecord_Vm()
        {
            this._logger.name += " -Vm";
            // Invoke graphql operation nutanixVm
            InvokeQueryNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixMounts.
        protected void ProcessRecord_Mount()
        {
            this._logger.name += " -Mount";
            // Invoke graphql operation nutanixMounts
            InvokeQueryNutanixMounts();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterContainers.
        protected void ProcessRecord_Clustercontainer()
        {
            this._logger.name += " -Clustercontainer";
            // Invoke graphql operation nutanixClusterContainers
            InvokeQueryNutanixClusterContainers();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterNetworks.
        protected void ProcessRecord_Clusternetwork()
        {
            this._logger.name += " -Clusternetwork";
            // Invoke graphql operation nutanixClusterNetworks
            InvokeQueryNutanixClusterNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterAsyncRequestStatus.
        protected void ProcessRecord_Clusterasyncrequeststatus()
        {
            this._logger.name += " -Clusterasyncrequeststatus";
            // Invoke graphql operation nutanixClusterAsyncRequestStatus
            InvokeQueryNutanixClusterAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVmAsyncRequestStatus.
        protected void ProcessRecord_Vmasyncrequeststatus()
        {
            this._logger.name += " -Vmasyncrequeststatus";
            // Invoke graphql operation nutanixVmAsyncRequestStatus
            InvokeQueryNutanixVmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // searchNutanixVm.
        protected void ProcessRecord_Searchvm()
        {
            this._logger.name += " -Searchvm";
            // Invoke graphql operation searchNutanixVm
            InvokeQuerySearchNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVmMissedSnapshots.
        protected void ProcessRecord_Vmmissedsnapshot()
        {
            this._logger.name += " -Vmmissedsnapshot";
            // Invoke graphql operation nutanixVmMissedSnapshots
            InvokeQueryNutanixVmMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixBrowseSnapshot.
        protected void ProcessRecord_Browsesnapshot()
        {
            this._logger.name += " -Browsesnapshot";
            // Invoke graphql operation nutanixBrowseSnapshot
            InvokeQueryNutanixBrowseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixSnapshotDetail.
        protected void ProcessRecord_Snapshotdetail()
        {
            this._logger.name += " -Snapshotdetail";
            // Invoke graphql operation nutanixSnapshotDetail
            InvokeQueryNutanixSnapshotDetail();
        }


        // Invoke GraphQL Query:
        // nutanixTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        protected void InvokeQueryNutanixTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CdmHierarchyObjectConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CdmHierarchyObjectConnection)psObject.BaseObject;
                } else {
                    fields = (CdmHierarchyObjectConnection)this.Field;
                }
            }
            string document = Query.NutanixTopLevelDescendants(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixTopLevelDescendants");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixTopLevelDescendants" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixTopLevelDescendants",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CdmHierarchyObjectConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixTopLevelDescendantsV2(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): NutanixTopLevelDescendantTypeConnection!
        protected void InvokeQueryNutanixTopLevelDescendantsV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixTopLevelDescendantTypeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string document = Query.NutanixTopLevelDescendantsV2(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixTopLevelDescendantsV2");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixTopLevelDescendantsV2" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixTopLevelDescendantsV2",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixTopLevelDescendantTypeConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixCluster(fid: UUID!): NutanixCluster!
        protected void InvokeQueryNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixCluster)psObject.BaseObject;
                } else {
                    fields = (NutanixCluster)this.Field;
                }
            }
            string document = Query.NutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixCluster");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixCluster", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixPrismCentrals(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixPrismCentralConnection!
        protected void InvokeQueryNutanixPrismCentrals()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixPrismCentralConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixPrismCentralConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixPrismCentralConnection)this.Field;
                }
            }
            string document = Query.NutanixPrismCentrals(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixPrismCentrals");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixPrismCentrals" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixPrismCentrals",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixPrismCentralConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixCategories(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixCategoryConnection!
        protected void InvokeQueryNutanixCategories()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixCategoryConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixCategoryConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixCategoryConnection)this.Field;
                }
            }
            string document = Query.NutanixCategories(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixCategories");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixCategories" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixCategories",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixCategoryConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixCategoryValues(fid: UUID!): NutanixCategoryValueConnection!
        protected void InvokeQueryNutanixCategoryValues()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixCategoryValueConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixCategoryValueConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixCategoryValueConnection)this.Field;
                }
            }
            string document = Query.NutanixCategoryValues(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixCategoryValues");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixCategoryValues" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixCategoryValues",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixCategoryValueConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixCategoryValueVms(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixVmConnection!
        protected void InvokeQueryNutanixCategoryValueVms()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixVmConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixVmConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixVmConnection)this.Field;
                }
            }
            string document = Query.NutanixCategoryValueVms(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixCategoryValueVms");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixCategoryValueVms" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixCategoryValueVms",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixVmConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixVm(fid: UUID!): NutanixVm!
        protected void InvokeQueryNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixVm? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixVm)psObject.BaseObject;
                } else {
                    fields = (NutanixVm)this.Field;
                }
            }
            string document = Query.NutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixVm");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixVm" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixVm", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixMounts(
        //     first: Int
        //     after: String
        //     filters: [NutanixLiveMountFilterInput!]
        //     sortBy: NutanixLiveMountSortByInput
        //   ): NutanixLiveMountConnection!
        protected void InvokeQueryNutanixMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[NutanixLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "NutanixLiveMountSortByInput"),
            };
            NutanixLiveMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixLiveMountConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixLiveMountConnection)this.Field;
                }
            }
            string document = Query.NutanixMounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixMounts");
            var parameters = "($first: Int,$after: String,$filters: [NutanixLiveMountFilterInput!],$sortBy: NutanixLiveMountSortByInput)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixMounts" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixMounts",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixLiveMountConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixClusterContainers(input: GetContainersInput!): NutanixContainerListResponse!
        protected void InvokeQueryNutanixClusterContainers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetContainersInput!"),
            };
            NutanixContainerListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixContainerListResponse)psObject.BaseObject;
                } else {
                    fields = (NutanixContainerListResponse)this.Field;
                }
            }
            string document = Query.NutanixClusterContainers(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixClusterContainers");
            var parameters = "($input: GetContainersInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixClusterContainers" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixClusterContainers",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixContainerListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixClusterNetworks(input: GetNutanixNetworksInput!): NutanixNetworkListResponse!
        protected void InvokeQueryNutanixClusterNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixNetworksInput!"),
            };
            NutanixNetworkListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixNetworkListResponse)psObject.BaseObject;
                } else {
                    fields = (NutanixNetworkListResponse)this.Field;
                }
            }
            string document = Query.NutanixClusterNetworks(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixClusterNetworks");
            var parameters = "($input: GetNutanixNetworksInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixClusterNetworks" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixClusterNetworks",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixNetworkListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixClusterAsyncRequestStatus(input: GetNutanixClusterAsyncRequestStatusInput!): AsyncRequestStatus!
        protected void InvokeQueryNutanixClusterAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixClusterAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Query.NutanixClusterAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixClusterAsyncRequestStatus");
            var parameters = "($input: GetNutanixClusterAsyncRequestStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixClusterAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixClusterAsyncRequestStatus",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixVmAsyncRequestStatus(input: GetNutanixVmAsyncRequestStatusInput!): AsyncRequestStatus!
        protected void InvokeQueryNutanixVmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixVmAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Query.NutanixVmAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixVmAsyncRequestStatus");
            var parameters = "($input: GetNutanixVmAsyncRequestStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixVmAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixVmAsyncRequestStatus",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // searchNutanixVm(input: SearchNutanixVmInput!): SearchResponseListResponse!
        protected void InvokeQuerySearchNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SearchNutanixVmInput!"),
            };
            SearchResponseListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SearchResponseListResponse)psObject.BaseObject;
                } else {
                    fields = (SearchResponseListResponse)this.Field;
                }
            }
            string document = Query.SearchNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SearchNutanixVm");
            var parameters = "($input: SearchNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySearchNutanixVm" + parameters + "{" + document + "}",
                OperationName = "QuerySearchNutanixVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SearchResponseListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixVmMissedSnapshots(input: NutanixMissedSnapshotsInput!): MissedSnapshotListResponse!
        protected void InvokeQueryNutanixVmMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "NutanixMissedSnapshotsInput!"),
            };
            MissedSnapshotListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MissedSnapshotListResponse)psObject.BaseObject;
                } else {
                    fields = (MissedSnapshotListResponse)this.Field;
                }
            }
            string document = Query.NutanixVmMissedSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixVmMissedSnapshots");
            var parameters = "($input: NutanixMissedSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixVmMissedSnapshots" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixVmMissedSnapshots",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MissedSnapshotListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixBrowseSnapshot(input: BrowseNutanixSnapshotInput!): BrowseResponseListResponse!
        protected void InvokeQueryNutanixBrowseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BrowseNutanixSnapshotInput!"),
            };
            BrowseResponseListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BrowseResponseListResponse)psObject.BaseObject;
                } else {
                    fields = (BrowseResponseListResponse)this.Field;
                }
            }
            string document = Query.NutanixBrowseSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixBrowseSnapshot");
            var parameters = "($input: BrowseNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixBrowseSnapshot" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixBrowseSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BrowseResponseListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixSnapshotDetail(input: GetNutanixSnapshotDetailInput!): NutanixVmSnapshotDetail!
        protected void InvokeQueryNutanixSnapshotDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixSnapshotDetailInput!"),
            };
            NutanixVmSnapshotDetail? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixVmSnapshotDetail)psObject.BaseObject;
                } else {
                    fields = (NutanixVmSnapshotDetail)this.Field;
                }
            }
            string document = Query.NutanixSnapshotDetail(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixSnapshotDetail");
            var parameters = "($input: GetNutanixSnapshotDetailInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixSnapshotDetail" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixSnapshotDetail",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixVmSnapshotDetail", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryNutanix
}
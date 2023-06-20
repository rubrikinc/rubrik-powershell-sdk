// Invoke-RscQueryVsphere.cs
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
        "RscQueryVsphere",
        DefaultParameterSetName = "Host")
    ]
    public class Invoke_RscQueryVsphere : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Blueprint parameter set
        //
        // [GraphQL: vSphereBlueprint]
        //
        [Parameter(
            ParameterSetName = "Blueprint",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereBlueprint]",
            Position = 0
        )]
        public SwitchParameter Blueprint { get; set; }

        [Parameter(
            ParameterSetName = "Blueprint",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik UUID for the object.
GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // Datacenter parameter set
        //
        // [GraphQL: vSphereDatacenter]
        //
        [Parameter(
            ParameterSetName = "Datacenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereDatacenter]",
            Position = 0
        )]
        public SwitchParameter Datacenter { get; set; }

        
        // -------------------------------------------------------------------
        // Computecluster parameter set
        //
        // [GraphQL: vSphereComputeCluster]
        //
        [Parameter(
            ParameterSetName = "Computecluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereComputeCluster]",
            Position = 0
        )]
        public SwitchParameter Computecluster { get; set; }

        
        // -------------------------------------------------------------------
        // Resourcepool parameter set
        //
        // [GraphQL: vSphereResourcePool]
        //
        [Parameter(
            ParameterSetName = "Resourcepool",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereResourcePool]",
            Position = 0
        )]
        public SwitchParameter Resourcepool { get; set; }

        
        // -------------------------------------------------------------------
        // Folder parameter set
        //
        // [GraphQL: vSphereFolder]
        //
        [Parameter(
            ParameterSetName = "Folder",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereFolder]",
            Position = 0
        )]
        public SwitchParameter Folder { get; set; }

        
        // -------------------------------------------------------------------
        // Host parameter set
        //
        // [GraphQL: vSphereHost]
        //
        [Parameter(
            ParameterSetName = "Host",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereHost]",
            Position = 0
        )]
        public new SwitchParameter Host { get; set; }

        
        // -------------------------------------------------------------------
        // Datastorecluster parameter set
        //
        // [GraphQL: vSphereDatastoreCluster]
        //
        [Parameter(
            ParameterSetName = "Datastorecluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Vsphere datastore cluster based on id passed in.
[GraphQL: vSphereDatastoreCluster]",
            Position = 0
        )]
        public SwitchParameter Datastorecluster { get; set; }

        
        // -------------------------------------------------------------------
        // Datastore parameter set
        //
        // [GraphQL: vSphereDatastore]
        //
        [Parameter(
            ParameterSetName = "Datastore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Vsphere datastore based on id passed in.
[GraphQL: vSphereDatastore]",
            Position = 0
        )]
        public SwitchParameter Datastore { get; set; }

        
        // -------------------------------------------------------------------
        // Hostsbyfid parameter set
        //
        // [GraphQL: vSphereHostsByFids]
        //
        [Parameter(
            ParameterSetName = "Hostsbyfid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All of the VSphere hosts based on fids passed in.
[GraphQL: vSphereHostsByFids]",
            Position = 0
        )]
        public SwitchParameter Hostsbyfid { get; set; }

        [Parameter(
            ParameterSetName = "Hostsbyfid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument fids: [UUID!]!"
        )]
        public List<System.String>? Fids { get; set; }
        
        // -------------------------------------------------------------------
        // Tag parameter set
        //
        // [GraphQL: vSphereTag]
        //
        [Parameter(
            ParameterSetName = "Tag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereTag]",
            Position = 0
        )]
        public SwitchParameter Tag { get; set; }

        
        // -------------------------------------------------------------------
        // Tagcategory parameter set
        //
        // [GraphQL: vSphereTagCategory]
        //
        [Parameter(
            ParameterSetName = "Tagcategory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereTagCategory]",
            Position = 0
        )]
        public SwitchParameter Tagcategory { get; set; }

        
        // -------------------------------------------------------------------
        // Network parameter set
        //
        // [GraphQL: vSphereNetwork]
        //
        [Parameter(
            ParameterSetName = "Network",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereNetwork]",
            Position = 0
        )]
        public SwitchParameter Network { get; set; }

        
        // -------------------------------------------------------------------
        // Topleveldescendantsconnection parameter set
        //
        // [GraphQL: vSphereTopLevelDescendantsConnection]
        //
        [Parameter(
            ParameterSetName = "Topleveldescendantsconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereTopLevelDescendantsConnection]",
            Position = 0
        )]
        public SwitchParameter Topleveldescendantsconnection { get; set; }

        [Parameter(
            ParameterSetName = "Topleveldescendantsconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendantsconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendantsconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort hierarchy objects by hierarchy field.
GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendantsconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sorting order for the results.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendantsconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Types of objects to include.
GraphQL argument typeFilter: [HierarchyObjectTypeEnum!]"
        )]
        public List<HierarchyObjectTypeEnum>? TypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "Topleveldescendantsconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The hierarchy object filter.
GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // Rootrecoveryhierarchy parameter set
        //
        // [GraphQL: vSphereRootRecoveryHierarchy]
        //
        [Parameter(
            ParameterSetName = "Rootrecoveryhierarchy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts.
[GraphQL: vSphereRootRecoveryHierarchy]",
            Position = 0
        )]
        public SwitchParameter Rootrecoveryhierarchy { get; set; }

        
        // -------------------------------------------------------------------
        // Hostconnection parameter set
        //
        // [GraphQL: vSphereHostConnection]
        //
        [Parameter(
            ParameterSetName = "Hostconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereHostConnection]",
            Position = 0
        )]
        public SwitchParameter Hostconnection { get; set; }

        
        // -------------------------------------------------------------------
        // Datastoreconnection parameter set
        //
        // [GraphQL: vSphereDatastoreConnection]
        //
        [Parameter(
            ParameterSetName = "Datastoreconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereDatastoreConnection]",
            Position = 0
        )]
        public SwitchParameter Datastoreconnection { get; set; }

        
        // -------------------------------------------------------------------
        // Livemount parameter set
        //
        // [GraphQL: vSphereLiveMounts]
        //
        [Parameter(
            ParameterSetName = "Livemount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of vSphere Live Mounts.
[GraphQL: vSphereLiveMounts]",
            Position = 0
        )]
        public SwitchParameter Livemount { get; set; }

        
        // -------------------------------------------------------------------
        // Mountconnection parameter set
        //
        // [GraphQL: vSphereMountConnection]
        //
        [Parameter(
            ParameterSetName = "Mountconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"vSphere Live Mount Connection
[GraphQL: vSphereMountConnection]",
            Position = 0
        )]
        public SwitchParameter Mountconnection { get; set; }

        
        // -------------------------------------------------------------------
        // Mount parameter set
        //
        // [GraphQL: vSphereMount]
        //
        [Parameter(
            ParameterSetName = "Mount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get a vSphere Live Mount by id
[GraphQL: vSphereMount]",
            Position = 0
        )]
        public SwitchParameter Mount { get; set; }

        
        // -------------------------------------------------------------------
        // Hostdetail parameter set
        //
        // [GraphQL: vSphereHostDetails]
        //
        [Parameter(
            ParameterSetName = "Hostdetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get details of a ESXi hypervisor

Supported in v5.0+
Get details of a ESXi hypervisor.
[GraphQL: vSphereHostDetails]",
            Position = 0
        )]
        public SwitchParameter Hostdetail { get; set; }

        [Parameter(
            ParameterSetName = "Hostdetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for V1GetVmwareHost.
GraphQL argument input: GetVmwareHostInput!"
        )]
        public GetVmwareHostInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Vmwarecdpliveinfo parameter set
        //
        // [GraphQL: vsphereVmwareCdpLiveInfo]
        //
        [Parameter(
            ParameterSetName = "Vmwarecdpliveinfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVmwareCdpLiveInfo]",
            Position = 0
        )]
        public SwitchParameter Vmwarecdpliveinfo { get; set; }

        [Parameter(
            ParameterSetName = "Vmwarecdpliveinfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The ID of each CDP-enabled virtual machine for which live info is being retrieved.
GraphQL argument ids: [String!]!"
        )]
        public List<System.String>? Ids { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Blueprint":
                        this.ProcessRecord_Blueprint();
                        break;
                    case "Datacenter":
                        this.ProcessRecord_Datacenter();
                        break;
                    case "Computecluster":
                        this.ProcessRecord_Computecluster();
                        break;
                    case "Resourcepool":
                        this.ProcessRecord_Resourcepool();
                        break;
                    case "Folder":
                        this.ProcessRecord_Folder();
                        break;
                    case "Host":
                        this.ProcessRecord_Host();
                        break;
                    case "Datastorecluster":
                        this.ProcessRecord_Datastorecluster();
                        break;
                    case "Datastore":
                        this.ProcessRecord_Datastore();
                        break;
                    case "Hostsbyfid":
                        this.ProcessRecord_Hostsbyfid();
                        break;
                    case "Tag":
                        this.ProcessRecord_Tag();
                        break;
                    case "Tagcategory":
                        this.ProcessRecord_Tagcategory();
                        break;
                    case "Network":
                        this.ProcessRecord_Network();
                        break;
                    case "Topleveldescendantsconnection":
                        this.ProcessRecord_Topleveldescendantsconnection();
                        break;
                    case "Rootrecoveryhierarchy":
                        this.ProcessRecord_Rootrecoveryhierarchy();
                        break;
                    case "Hostconnection":
                        this.ProcessRecord_Hostconnection();
                        break;
                    case "Datastoreconnection":
                        this.ProcessRecord_Datastoreconnection();
                        break;
                    case "Livemount":
                        this.ProcessRecord_Livemount();
                        break;
                    case "Mountconnection":
                        this.ProcessRecord_Mountconnection();
                        break;
                    case "Mount":
                        this.ProcessRecord_Mount();
                        break;
                    case "Hostdetail":
                        this.ProcessRecord_Hostdetail();
                        break;
                    case "Vmwarecdpliveinfo":
                        this.ProcessRecord_Vmwarecdpliveinfo();
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
        // vSphereBlueprint.
        protected void ProcessRecord_Blueprint()
        {
            this._logger.name += " -Blueprint";
            // Invoke graphql operation vSphereBlueprint
            InvokeQueryVsphereBlueprint();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatacenter.
        protected void ProcessRecord_Datacenter()
        {
            this._logger.name += " -Datacenter";
            // Invoke graphql operation vSphereDatacenter
            InvokeQueryVsphereDatacenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereComputeCluster.
        protected void ProcessRecord_Computecluster()
        {
            this._logger.name += " -Computecluster";
            // Invoke graphql operation vSphereComputeCluster
            InvokeQueryVsphereComputeCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereResourcePool.
        protected void ProcessRecord_Resourcepool()
        {
            this._logger.name += " -Resourcepool";
            // Invoke graphql operation vSphereResourcePool
            InvokeQueryVsphereResourcePool();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereFolder.
        protected void ProcessRecord_Folder()
        {
            this._logger.name += " -Folder";
            // Invoke graphql operation vSphereFolder
            InvokeQueryVsphereFolder();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHost.
        protected void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Invoke graphql operation vSphereHost
            InvokeQueryVsphereHost();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreCluster.
        protected void ProcessRecord_Datastorecluster()
        {
            this._logger.name += " -Datastorecluster";
            // Invoke graphql operation vSphereDatastoreCluster
            InvokeQueryVsphereDatastoreCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastore.
        protected void ProcessRecord_Datastore()
        {
            this._logger.name += " -Datastore";
            // Invoke graphql operation vSphereDatastore
            InvokeQueryVsphereDatastore();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostsByFids.
        protected void ProcessRecord_Hostsbyfid()
        {
            this._logger.name += " -Hostsbyfid";
            // Invoke graphql operation vSphereHostsByFids
            InvokeQueryVsphereHostsByFids();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTag.
        protected void ProcessRecord_Tag()
        {
            this._logger.name += " -Tag";
            // Invoke graphql operation vSphereTag
            InvokeQueryVsphereTag();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTagCategory.
        protected void ProcessRecord_Tagcategory()
        {
            this._logger.name += " -Tagcategory";
            // Invoke graphql operation vSphereTagCategory
            InvokeQueryVsphereTagCategory();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereNetwork.
        protected void ProcessRecord_Network()
        {
            this._logger.name += " -Network";
            // Invoke graphql operation vSphereNetwork
            InvokeQueryVsphereNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTopLevelDescendantsConnection.
        protected void ProcessRecord_Topleveldescendantsconnection()
        {
            this._logger.name += " -Topleveldescendantsconnection";
            // Invoke graphql operation vSphereTopLevelDescendantsConnection
            InvokeQueryVsphereTopLevelDescendantsConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereRootRecoveryHierarchy.
        protected void ProcessRecord_Rootrecoveryhierarchy()
        {
            this._logger.name += " -Rootrecoveryhierarchy";
            // Invoke graphql operation vSphereRootRecoveryHierarchy
            InvokeQueryVsphereRootRecoveryHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostConnection.
        protected void ProcessRecord_Hostconnection()
        {
            this._logger.name += " -Hostconnection";
            // Invoke graphql operation vSphereHostConnection
            InvokeQueryVsphereHostConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreConnection.
        protected void ProcessRecord_Datastoreconnection()
        {
            this._logger.name += " -Datastoreconnection";
            // Invoke graphql operation vSphereDatastoreConnection
            InvokeQueryVsphereDatastoreConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereLiveMounts.
        protected void ProcessRecord_Livemount()
        {
            this._logger.name += " -Livemount";
            // Invoke graphql operation vSphereLiveMounts
            InvokeQueryVsphereLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMountConnection.
        protected void ProcessRecord_Mountconnection()
        {
            this._logger.name += " -Mountconnection";
            // Invoke graphql operation vSphereMountConnection
            InvokeQueryVsphereMountConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMount.
        protected void ProcessRecord_Mount()
        {
            this._logger.name += " -Mount";
            // Invoke graphql operation vSphereMount
            InvokeQueryVsphereMount();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostDetails.
        protected void ProcessRecord_Hostdetail()
        {
            this._logger.name += " -Hostdetail";
            // Invoke graphql operation vSphereHostDetails
            InvokeQueryVsphereHostDetails();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmwareCdpLiveInfo.
        protected void ProcessRecord_Vmwarecdpliveinfo()
        {
            this._logger.name += " -Vmwarecdpliveinfo";
            // Invoke graphql operation vsphereVmwareCdpLiveInfo
            InvokeQueryVsphereVmwareCdpLiveInfo();
        }


        // Invoke GraphQL Query:
        // vSphereBlueprint(fid: UUID!): VSphereBlueprint!
        protected void InvokeQueryVsphereBlueprint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereBlueprint? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereBlueprint)psObject.BaseObject;
                } else {
                    fields = (VsphereBlueprint)this.Field;
                }
            }
            string document = Query.VsphereBlueprint(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereBlueprint");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereBlueprint" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereBlueprint",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereBlueprint", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereDatacenter(fid: UUID!): VsphereDatacenter!
        protected void InvokeQueryVsphereDatacenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatacenter? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereDatacenter)psObject.BaseObject;
                } else {
                    fields = (VsphereDatacenter)this.Field;
                }
            }
            string document = Query.VsphereDatacenter(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereDatacenter");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereDatacenter" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereDatacenter",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereDatacenter", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereComputeCluster(fid: UUID!): VsphereComputeCluster!
        protected void InvokeQueryVsphereComputeCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereComputeCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereComputeCluster)psObject.BaseObject;
                } else {
                    fields = (VsphereComputeCluster)this.Field;
                }
            }
            string document = Query.VsphereComputeCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereComputeCluster");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereComputeCluster" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereComputeCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereComputeCluster", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereResourcePool(fid: UUID!): VsphereResourcePool!
        protected void InvokeQueryVsphereResourcePool()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereResourcePool? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereResourcePool)psObject.BaseObject;
                } else {
                    fields = (VsphereResourcePool)this.Field;
                }
            }
            string document = Query.VsphereResourcePool(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereResourcePool");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereResourcePool" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereResourcePool",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereResourcePool", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereFolder(fid: UUID!): VsphereFolder!
        protected void InvokeQueryVsphereFolder()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereFolder? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereFolder)psObject.BaseObject;
                } else {
                    fields = (VsphereFolder)this.Field;
                }
            }
            string document = Query.VsphereFolder(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereFolder");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereFolder" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereFolder",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereFolder", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereHost(fid: UUID!): VsphereHost!
        protected void InvokeQueryVsphereHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereHost? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereHost)psObject.BaseObject;
                } else {
                    fields = (VsphereHost)this.Field;
                }
            }
            string document = Query.VsphereHost(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereHost");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereHost" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereHost",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereHost", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereDatastoreCluster(fid: UUID!): VsphereDatastoreCluster!
        protected void InvokeQueryVsphereDatastoreCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatastoreCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereDatastoreCluster)psObject.BaseObject;
                } else {
                    fields = (VsphereDatastoreCluster)this.Field;
                }
            }
            string document = Query.VsphereDatastoreCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereDatastoreCluster");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereDatastoreCluster" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereDatastoreCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereDatastoreCluster", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereDatastore(fid: UUID!): VsphereDatastore!
        protected void InvokeQueryVsphereDatastore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatastore? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereDatastore)psObject.BaseObject;
                } else {
                    fields = (VsphereDatastore)this.Field;
                }
            }
            string document = Query.VsphereDatastore(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereDatastore");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereDatastore" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereDatastore",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereDatastore", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereHostsByFids(fids: [UUID!]!): [VsphereHost!]!
        protected void InvokeQueryVsphereHostsByFids()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            List<VsphereHost>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<VsphereHost>)psObject.BaseObject;
                } else {
                    fields = (List<VsphereHost>)this.Field;
                }
            }
            string document = Query.VsphereHostsByFids(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereHostsByFids");
            var parameters = "($fids: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereHostsByFids" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereHostsByFids",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<VsphereHost>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereTag(fid: UUID!): VsphereTag!
        protected void InvokeQueryVsphereTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereTag? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereTag)psObject.BaseObject;
                } else {
                    fields = (VsphereTag)this.Field;
                }
            }
            string document = Query.VsphereTag(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereTag");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereTag" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereTag",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereTag", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereTagCategory(fid: UUID!): VsphereTagCategory!
        protected void InvokeQueryVsphereTagCategory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereTagCategory? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereTagCategory)psObject.BaseObject;
                } else {
                    fields = (VsphereTagCategory)this.Field;
                }
            }
            string document = Query.VsphereTagCategory(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereTagCategory");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereTagCategory" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereTagCategory",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereTagCategory", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereNetwork(fid: UUID!): VsphereNetwork!
        protected void InvokeQueryVsphereNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereNetwork? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereNetwork)psObject.BaseObject;
                } else {
                    fields = (VsphereNetwork)this.Field;
                }
            }
            string document = Query.VsphereNetwork(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereNetwork");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereNetwork" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereNetwork",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereNetwork", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereTopLevelDescendantsConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        protected void InvokeQueryVsphereTopLevelDescendantsConnection()
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
            string document = Query.VsphereTopLevelDescendantsConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereTopLevelDescendantsConnection");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereTopLevelDescendantsConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereTopLevelDescendantsConnection",
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
        // vSphereRootRecoveryHierarchy(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        protected void InvokeQueryVsphereRootRecoveryHierarchy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
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
            string document = Query.VsphereRootRecoveryHierarchy(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereRootRecoveryHierarchy");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereRootRecoveryHierarchy" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereRootRecoveryHierarchy",
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
        // vSphereHostConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereHostConnection!
        protected void InvokeQueryVsphereHostConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereHostConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereHostConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereHostConnection)this.Field;
                }
            }
            string document = Query.VsphereHostConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereHostConnection");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereHostConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereHostConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereHostConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereDatastoreConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereDatastoreConnection!
        protected void InvokeQueryVsphereDatastoreConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereDatastoreConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereDatastoreConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereDatastoreConnection)this.Field;
                }
            }
            string document = Query.VsphereDatastoreConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereDatastoreConnection");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereDatastoreConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereDatastoreConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereDatastoreConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereLiveMounts(
        //     first: Int
        //     after: String
        //     filter: [VsphereLiveMountFilterInput!]
        //     sortBy: VsphereLiveMountSortBy
        //   ): VsphereLiveMountConnection!
        protected void InvokeQueryVsphereLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "[VsphereLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "VsphereLiveMountSortBy"),
            };
            VsphereLiveMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereLiveMountConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereLiveMountConnection)this.Field;
                }
            }
            string document = Query.VsphereLiveMounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereLiveMounts");
            var parameters = "($first: Int,$after: String,$filter: [VsphereLiveMountFilterInput!],$sortBy: VsphereLiveMountSortBy)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereLiveMounts" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereLiveMounts",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereLiveMountConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereMountConnection(
        //     first: Int
        //     after: String
        //     filter: VSphereMountFilter
        //     sortBy: VsphereMountSortBy
        //     sortOrder: SortOrder
        //   ): VsphereMountConnection!
        protected void InvokeQueryVsphereMountConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "VSphereMountFilter"),
                Tuple.Create("sortBy", "VsphereMountSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            VsphereMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereMountConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereMountConnection)this.Field;
                }
            }
            string document = Query.VsphereMountConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereMountConnection");
            var parameters = "($first: Int,$after: String,$filter: VSphereMountFilter,$sortBy: VsphereMountSortBy,$sortOrder: SortOrder)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereMountConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereMountConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereMountConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereMount(fid: UUID!): VsphereMount!
        protected void InvokeQueryVsphereMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereMount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereMount)psObject.BaseObject;
                } else {
                    fields = (VsphereMount)this.Field;
                }
            }
            string document = Query.VsphereMount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereMount");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereMount" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereMount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereMount", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereHostDetails(input: GetVmwareHostInput!): VmwareHostDetail!
        protected void InvokeQueryVsphereHostDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVmwareHostInput!"),
            };
            VmwareHostDetail? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VmwareHostDetail)psObject.BaseObject;
                } else {
                    fields = (VmwareHostDetail)this.Field;
                }
            }
            string document = Query.VsphereHostDetails(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereHostDetails");
            var parameters = "($input: GetVmwareHostInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereHostDetails" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereHostDetails",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VmwareHostDetail", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vsphereVmwareCdpLiveInfo(ids: [String!]!): BatchVmwareCdpLiveInfo!
        protected void InvokeQueryVsphereVmwareCdpLiveInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            BatchVmwareCdpLiveInfo? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchVmwareCdpLiveInfo)psObject.BaseObject;
                } else {
                    fields = (BatchVmwareCdpLiveInfo)this.Field;
                }
            }
            string document = Query.VsphereVmwareCdpLiveInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmwareCdpLiveInfo");
            var parameters = "($ids: [String!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmwareCdpLiveInfo" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmwareCdpLiveInfo",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchVmwareCdpLiveInfo", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryVsphere
}
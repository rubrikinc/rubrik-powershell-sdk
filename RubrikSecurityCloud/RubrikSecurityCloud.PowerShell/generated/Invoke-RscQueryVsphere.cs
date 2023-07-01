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
        // ComputeCluster parameter set
        //
        // [GraphQL: vSphereComputeCluster]
        //
        [Parameter(
            ParameterSetName = "ComputeCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereComputeCluster]",
            Position = 0
        )]
        public SwitchParameter ComputeCluster { get; set; }

        
        // -------------------------------------------------------------------
        // ResourcePool parameter set
        //
        // [GraphQL: vSphereResourcePool]
        //
        [Parameter(
            ParameterSetName = "ResourcePool",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereResourcePool]",
            Position = 0
        )]
        public SwitchParameter ResourcePool { get; set; }

        
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
        // DatastoreCluster parameter set
        //
        // [GraphQL: vSphereDatastoreCluster]
        //
        [Parameter(
            ParameterSetName = "DatastoreCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Vsphere datastore cluster based on id passed in.
[GraphQL: vSphereDatastoreCluster]",
            Position = 0
        )]
        public SwitchParameter DatastoreCluster { get; set; }

        
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
        // HostsByFid parameter set
        //
        // [GraphQL: vSphereHostsByFids]
        //
        [Parameter(
            ParameterSetName = "HostsByFid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All of the VSphere hosts based on fids passed in.
[GraphQL: vSphereHostsByFids]",
            Position = 0
        )]
        public SwitchParameter HostsByFid { get; set; }

        
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
        // TagCategory parameter set
        //
        // [GraphQL: vSphereTagCategory]
        //
        [Parameter(
            ParameterSetName = "TagCategory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereTagCategory]",
            Position = 0
        )]
        public SwitchParameter TagCategory { get; set; }

        
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
        // TopLevelDescendantsList parameter set
        //
        // [GraphQL: vSphereTopLevelDescendantsConnection]
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendantsList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereTopLevelDescendantsConnection]",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendantsList { get; set; }

        
        // -------------------------------------------------------------------
        // RootRecoveryHierarchy parameter set
        //
        // [GraphQL: vSphereRootRecoveryHierarchy]
        //
        [Parameter(
            ParameterSetName = "RootRecoveryHierarchy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts.
[GraphQL: vSphereRootRecoveryHierarchy]",
            Position = 0
        )]
        public SwitchParameter RootRecoveryHierarchy { get; set; }

        
        // -------------------------------------------------------------------
        // HostList parameter set
        //
        // [GraphQL: vSphereHostConnection]
        //
        [Parameter(
            ParameterSetName = "HostList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereHostConnection]",
            Position = 0
        )]
        public SwitchParameter HostList { get; set; }

        
        // -------------------------------------------------------------------
        // DatastoreList parameter set
        //
        // [GraphQL: vSphereDatastoreConnection]
        //
        [Parameter(
            ParameterSetName = "DatastoreList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereDatastoreConnection]",
            Position = 0
        )]
        public SwitchParameter DatastoreList { get; set; }

        
        // -------------------------------------------------------------------
        // LiveMount parameter set
        //
        // [GraphQL: vSphereLiveMounts]
        //
        [Parameter(
            ParameterSetName = "LiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of vSphere Live Mounts.
[GraphQL: vSphereLiveMounts]",
            Position = 0
        )]
        public SwitchParameter LiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // MountList parameter set
        //
        // [GraphQL: vSphereMountConnection]
        //
        [Parameter(
            ParameterSetName = "MountList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"vSphere Live Mount Connection
[GraphQL: vSphereMountConnection]",
            Position = 0
        )]
        public SwitchParameter MountList { get; set; }

        
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
        // HostDetail parameter set
        //
        // [GraphQL: vSphereHostDetails]
        //
        [Parameter(
            ParameterSetName = "HostDetail",
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
        public SwitchParameter HostDetail { get; set; }

        
        // -------------------------------------------------------------------
        // VmwareCdpLiveInfo parameter set
        //
        // [GraphQL: vsphereVmwareCdpLiveInfo]
        //
        [Parameter(
            ParameterSetName = "VmwareCdpLiveInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVmwareCdpLiveInfo]",
            Position = 0
        )]
        public SwitchParameter VmwareCdpLiveInfo { get; set; }


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
                    case "ComputeCluster":
                        this.ProcessRecord_ComputeCluster();
                        break;
                    case "ResourcePool":
                        this.ProcessRecord_ResourcePool();
                        break;
                    case "Folder":
                        this.ProcessRecord_Folder();
                        break;
                    case "Host":
                        this.ProcessRecord_Host();
                        break;
                    case "DatastoreCluster":
                        this.ProcessRecord_DatastoreCluster();
                        break;
                    case "Datastore":
                        this.ProcessRecord_Datastore();
                        break;
                    case "HostsByFid":
                        this.ProcessRecord_HostsByFid();
                        break;
                    case "Tag":
                        this.ProcessRecord_Tag();
                        break;
                    case "TagCategory":
                        this.ProcessRecord_TagCategory();
                        break;
                    case "Network":
                        this.ProcessRecord_Network();
                        break;
                    case "TopLevelDescendantsList":
                        this.ProcessRecord_TopLevelDescendantsList();
                        break;
                    case "RootRecoveryHierarchy":
                        this.ProcessRecord_RootRecoveryHierarchy();
                        break;
                    case "HostList":
                        this.ProcessRecord_HostList();
                        break;
                    case "DatastoreList":
                        this.ProcessRecord_DatastoreList();
                        break;
                    case "LiveMount":
                        this.ProcessRecord_LiveMount();
                        break;
                    case "MountList":
                        this.ProcessRecord_MountList();
                        break;
                    case "Mount":
                        this.ProcessRecord_Mount();
                        break;
                    case "HostDetail":
                        this.ProcessRecord_HostDetail();
                        break;
                    case "VmwareCdpLiveInfo":
                        this.ProcessRecord_VmwareCdpLiveInfo();
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
        protected void ProcessRecord_ComputeCluster()
        {
            this._logger.name += " -ComputeCluster";
            // Invoke graphql operation vSphereComputeCluster
            InvokeQueryVsphereComputeCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereResourcePool.
        protected void ProcessRecord_ResourcePool()
        {
            this._logger.name += " -ResourcePool";
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
        protected void ProcessRecord_DatastoreCluster()
        {
            this._logger.name += " -DatastoreCluster";
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
        protected void ProcessRecord_HostsByFid()
        {
            this._logger.name += " -HostsByFid";
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
        protected void ProcessRecord_TagCategory()
        {
            this._logger.name += " -TagCategory";
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
        protected void ProcessRecord_TopLevelDescendantsList()
        {
            this._logger.name += " -TopLevelDescendantsList";
            // Invoke graphql operation vSphereTopLevelDescendantsConnection
            InvokeQueryVsphereTopLevelDescendantsConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereRootRecoveryHierarchy.
        protected void ProcessRecord_RootRecoveryHierarchy()
        {
            this._logger.name += " -RootRecoveryHierarchy";
            // Invoke graphql operation vSphereRootRecoveryHierarchy
            InvokeQueryVsphereRootRecoveryHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostConnection.
        protected void ProcessRecord_HostList()
        {
            this._logger.name += " -HostList";
            // Invoke graphql operation vSphereHostConnection
            InvokeQueryVsphereHostConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreConnection.
        protected void ProcessRecord_DatastoreList()
        {
            this._logger.name += " -DatastoreList";
            // Invoke graphql operation vSphereDatastoreConnection
            InvokeQueryVsphereDatastoreConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereLiveMounts.
        protected void ProcessRecord_LiveMount()
        {
            this._logger.name += " -LiveMount";
            // Invoke graphql operation vSphereLiveMounts
            InvokeQueryVsphereLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMountConnection.
        protected void ProcessRecord_MountList()
        {
            this._logger.name += " -MountList";
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
        protected void ProcessRecord_HostDetail()
        {
            this._logger.name += " -HostDetail";
            // Invoke graphql operation vSphereHostDetails
            InvokeQueryVsphereHostDetails();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmwareCdpLiveInfo.
        protected void ProcessRecord_VmwareCdpLiveInfo()
        {
            this._logger.name += " -VmwareCdpLiveInfo";
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
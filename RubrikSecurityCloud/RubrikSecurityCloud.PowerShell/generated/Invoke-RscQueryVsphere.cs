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
        // HostsByFids parameter set
        //
        // [GraphQL: vSphereHostsByFids]
        //
        [Parameter(
            ParameterSetName = "HostsByFids",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All of the VSphere hosts based on fids passed in.
[GraphQL: vSphereHostsByFids]",
            Position = 0
        )]
        public SwitchParameter HostsByFids { get; set; }

        
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
        // ComputeClusters parameter set
        //
        // [GraphQL: vSphereComputeClusters]
        //
        [Parameter(
            ParameterSetName = "ComputeClusters",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Query compute clusters
[GraphQL: vSphereComputeClusters]",
            Position = 0
        )]
        public SwitchParameter ComputeClusters { get; set; }

        
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
        // DatastoreClusters parameter set
        //
        // [GraphQL: vSphereDatastoreClusters]
        //
        [Parameter(
            ParameterSetName = "DatastoreClusters",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Query vSphere datastore clusters.
[GraphQL: vSphereDatastoreClusters]",
            Position = 0
        )]
        public SwitchParameter DatastoreClusters { get; set; }

        
        // -------------------------------------------------------------------
        // LiveMounts parameter set
        //
        // [GraphQL: vSphereLiveMounts]
        //
        [Parameter(
            ParameterSetName = "LiveMounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of vSphere Live Mounts.
[GraphQL: vSphereLiveMounts]",
            Position = 0
        )]
        public SwitchParameter LiveMounts { get; set; }

        
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
        // HostDetails parameter set
        //
        // [GraphQL: vSphereHostDetails]
        //
        [Parameter(
            ParameterSetName = "HostDetails",
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
        public SwitchParameter HostDetails { get; set; }

        
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
                    case "HostsByFids":
                        this.ProcessRecord_HostsByFids();
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
                    case "ComputeClusters":
                        this.ProcessRecord_ComputeClusters();
                        break;
                    case "DatastoreList":
                        this.ProcessRecord_DatastoreList();
                        break;
                    case "DatastoreClusters":
                        this.ProcessRecord_DatastoreClusters();
                        break;
                    case "LiveMounts":
                        this.ProcessRecord_LiveMounts();
                        break;
                    case "MountList":
                        this.ProcessRecord_MountList();
                        break;
                    case "Mount":
                        this.ProcessRecord_Mount();
                        break;
                    case "HostDetails":
                        this.ProcessRecord_HostDetails();
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
        protected void ProcessRecord_HostsByFids()
        {
            this._logger.name += " -HostsByFids";
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
        // vSphereComputeClusters.
        protected void ProcessRecord_ComputeClusters()
        {
            this._logger.name += " -ComputeClusters";
            // Invoke graphql operation vSphereComputeClusters
            InvokeQueryVsphereComputeClusters();
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
        // vSphereDatastoreClusters.
        protected void ProcessRecord_DatastoreClusters()
        {
            this._logger.name += " -DatastoreClusters";
            // Invoke graphql operation vSphereDatastoreClusters
            InvokeQueryVsphereDatastoreClusters();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereLiveMounts.
        protected void ProcessRecord_LiveMounts()
        {
            this._logger.name += " -LiveMounts";
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
        protected void ProcessRecord_HostDetails()
        {
            this._logger.name += " -HostDetails";
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
            VsphereBlueprint? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereBlueprint)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereBlueprint)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereBlueprint(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereBlueprint",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereBlueprint"
            );
        }

        // Invoke GraphQL Query:
        // vSphereDatacenter(fid: UUID!): VsphereDatacenter!
        protected void InvokeQueryVsphereDatacenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatacenter? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereDatacenter)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereDatacenter)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereDatacenter(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereDatacenter",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereDatacenter"
            );
        }

        // Invoke GraphQL Query:
        // vSphereComputeCluster(fid: UUID!): VsphereComputeCluster!
        protected void InvokeQueryVsphereComputeCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereComputeCluster? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereComputeCluster)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereComputeCluster)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereComputeCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereComputeCluster",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereComputeCluster"
            );
        }

        // Invoke GraphQL Query:
        // vSphereResourcePool(fid: UUID!): VsphereResourcePool!
        protected void InvokeQueryVsphereResourcePool()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereResourcePool? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereResourcePool)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereResourcePool)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereResourcePool(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereResourcePool",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereResourcePool"
            );
        }

        // Invoke GraphQL Query:
        // vSphereFolder(fid: UUID!): VsphereFolder!
        protected void InvokeQueryVsphereFolder()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereFolder? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereFolder)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereFolder)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereFolder(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereFolder",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereFolder"
            );
        }

        // Invoke GraphQL Query:
        // vSphereHost(fid: UUID!): VsphereHost!
        protected void InvokeQueryVsphereHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereHost? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereHost)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereHost)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereHost(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereHost",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereHost"
            );
        }

        // Invoke GraphQL Query:
        // vSphereDatastoreCluster(fid: UUID!): VsphereDatastoreCluster!
        protected void InvokeQueryVsphereDatastoreCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatastoreCluster? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereDatastoreCluster)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereDatastoreCluster)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereDatastoreCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereDatastoreCluster",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereDatastoreCluster"
            );
        }

        // Invoke GraphQL Query:
        // vSphereDatastore(fid: UUID!): VsphereDatastore!
        protected void InvokeQueryVsphereDatastore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatastore? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereDatastore)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereDatastore)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereDatastore(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereDatastore",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereDatastore"
            );
        }

        // Invoke GraphQL Query:
        // vSphereHostsByFids(fids: [UUID!]!): [VsphereHost!]!
        protected void InvokeQueryVsphereHostsByFids()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            List<VsphereHost>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<VsphereHost>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<VsphereHost>)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereHostsByFids(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereHostsByFids",
                "($fids: [UUID!]!)",
                fieldSpecDoc,
                "List<VsphereHost>"
            );
        }

        // Invoke GraphQL Query:
        // vSphereTag(fid: UUID!): VsphereTag!
        protected void InvokeQueryVsphereTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereTag? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereTag)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereTag)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereTag(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereTag",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereTag"
            );
        }

        // Invoke GraphQL Query:
        // vSphereTagCategory(fid: UUID!): VsphereTagCategory!
        protected void InvokeQueryVsphereTagCategory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereTagCategory? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereTagCategory)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereTagCategory)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereTagCategory(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereTagCategory",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereTagCategory"
            );
        }

        // Invoke GraphQL Query:
        // vSphereNetwork(fid: UUID!): VsphereNetwork!
        protected void InvokeQueryVsphereNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereNetwork? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereNetwork)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereNetwork)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereNetwork(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereNetwork",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereNetwork"
            );
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
            CdmHierarchyObjectConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CdmHierarchyObjectConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CdmHierarchyObjectConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereTopLevelDescendantsConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereTopLevelDescendantsConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                fieldSpecDoc,
                "CdmHierarchyObjectConnection"
            );
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
            CdmHierarchyObjectConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CdmHierarchyObjectConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CdmHierarchyObjectConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereRootRecoveryHierarchy(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereRootRecoveryHierarchy",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "CdmHierarchyObjectConnection"
            );
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
            VsphereHostConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereHostConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereHostConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereHostConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereHostConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "VsphereHostConnection"
            );
        }

        // Invoke GraphQL Query:
        // vSphereComputeClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereComputeClusterConnection!
        protected void InvokeQueryVsphereComputeClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereComputeClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereComputeClusterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereComputeClusterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereComputeClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereComputeClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "VsphereComputeClusterConnection"
            );
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
            VsphereDatastoreConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereDatastoreConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereDatastoreConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereDatastoreConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereDatastoreConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "VsphereDatastoreConnection"
            );
        }

        // Invoke GraphQL Query:
        // vSphereDatastoreClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereDatastoreClusterConnection!
        protected void InvokeQueryVsphereDatastoreClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereDatastoreClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereDatastoreClusterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereDatastoreClusterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereDatastoreClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereDatastoreClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "VsphereDatastoreClusterConnection"
            );
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
            VsphereLiveMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereLiveMountConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereLiveMountConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereLiveMounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereLiveMounts",
                "($first: Int,$after: String,$filter: [VsphereLiveMountFilterInput!],$sortBy: VsphereLiveMountSortBy)",
                fieldSpecDoc,
                "VsphereLiveMountConnection"
            );
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
            VsphereMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereMountConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereMountConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereMountConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereMountConnection",
                "($first: Int,$after: String,$filter: VSphereMountFilter,$sortBy: VsphereMountSortBy,$sortOrder: SortOrder)",
                fieldSpecDoc,
                "VsphereMountConnection"
            );
        }

        // Invoke GraphQL Query:
        // vSphereMount(fid: UUID!): VsphereMount!
        protected void InvokeQueryVsphereMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereMount? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereMount)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereMount)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereMount",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereMount"
            );
        }

        // Invoke GraphQL Query:
        // vSphereHostDetails(input: GetVmwareHostInput!): VmwareHostDetail!
        protected void InvokeQueryVsphereHostDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVmwareHostInput!"),
            };
            VmwareHostDetail? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VmwareHostDetail)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VmwareHostDetail)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereHostDetails(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereHostDetails",
                "($input: GetVmwareHostInput!)",
                fieldSpecDoc,
                "VmwareHostDetail"
            );
        }

        // Invoke GraphQL Query:
        // vsphereVmwareCdpLiveInfo(ids: [String!]!): BatchVmwareCdpLiveInfo!
        protected void InvokeQueryVsphereVmwareCdpLiveInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            BatchVmwareCdpLiveInfo? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchVmwareCdpLiveInfo)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchVmwareCdpLiveInfo)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVmwareCdpLiveInfo(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVmwareCdpLiveInfo",
                "($ids: [String!]!)",
                fieldSpecDoc,
                "BatchVmwareCdpLiveInfo"
            );
        }


    } // class Invoke_RscQueryVsphere
}
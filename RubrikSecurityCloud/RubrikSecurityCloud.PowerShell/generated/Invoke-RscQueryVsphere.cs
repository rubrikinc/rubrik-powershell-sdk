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
        
        /// <summary>
        /// Blueprint parameter set
        ///
        /// [GraphQL: vSphereBlueprint]
        /// </summary>
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

        
        /// <summary>
        /// Datacenter parameter set
        ///
        /// [GraphQL: vSphereDatacenter]
        /// </summary>
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

        
        /// <summary>
        /// ComputeCluster parameter set
        ///
        /// [GraphQL: vSphereComputeCluster]
        /// </summary>
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

        
        /// <summary>
        /// ResourcePool parameter set
        ///
        /// [GraphQL: vSphereResourcePool]
        /// </summary>
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

        
        /// <summary>
        /// Folder parameter set
        ///
        /// [GraphQL: vSphereFolder]
        /// </summary>
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

        
        /// <summary>
        /// Host parameter set
        ///
        /// [GraphQL: vSphereHost]
        /// </summary>
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

        
        /// <summary>
        /// DatastoreCluster parameter set
        ///
        /// [GraphQL: vSphereDatastoreCluster]
        /// </summary>
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

        
        /// <summary>
        /// Datastore parameter set
        ///
        /// [GraphQL: vSphereDatastore]
        /// </summary>
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

        
        /// <summary>
        /// HostsByFids parameter set
        ///
        /// [GraphQL: vSphereHostsByFids]
        /// </summary>
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

        
        /// <summary>
        /// Tag parameter set
        ///
        /// [GraphQL: vSphereTag]
        /// </summary>
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

        
        /// <summary>
        /// TagCategory parameter set
        ///
        /// [GraphQL: vSphereTagCategory]
        /// </summary>
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

        
        /// <summary>
        /// Network parameter set
        ///
        /// [GraphQL: vSphereNetwork]
        /// </summary>
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

        
        /// <summary>
        /// TopLevelDescendantsList parameter set
        ///
        /// [GraphQL: vSphereTopLevelDescendantsConnection]
        /// </summary>
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

        
        /// <summary>
        /// RootRecoveryHierarchy parameter set
        ///
        /// [GraphQL: vSphereRootRecoveryHierarchy]
        /// </summary>
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

        
        /// <summary>
        /// HostList parameter set
        ///
        /// [GraphQL: vSphereHostConnection]
        /// </summary>
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

        
        /// <summary>
        /// ComputeClusters parameter set
        ///
        /// [GraphQL: vSphereComputeClusters]
        /// </summary>
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

        
        /// <summary>
        /// DatastoreList parameter set
        ///
        /// [GraphQL: vSphereDatastoreConnection]
        /// </summary>
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

        
        /// <summary>
        /// DatastoreClusters parameter set
        ///
        /// [GraphQL: vSphereDatastoreClusters]
        /// </summary>
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

        
        /// <summary>
        /// LiveMounts parameter set
        ///
        /// [GraphQL: vSphereLiveMounts]
        /// </summary>
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

        
        /// <summary>
        /// MountList parameter set
        ///
        /// [GraphQL: vSphereMountConnection]
        /// </summary>
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

        
        /// <summary>
        /// Mount parameter set
        ///
        /// [GraphQL: vSphereMount]
        /// </summary>
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

        
        /// <summary>
        /// HostDetails parameter set
        ///
        /// [GraphQL: vSphereHostDetails]
        /// </summary>
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

        
        /// <summary>
        /// VmwareCdpLiveInfo parameter set
        ///
        /// [GraphQL: vsphereVmwareCdpLiveInfo]
        /// </summary>
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


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // vSphereBlueprint.
        internal void ProcessRecord_Blueprint()
        {
            this._logger.name += " -Blueprint";
            // Invoke graphql operation vSphereBlueprint
            InvokeQueryVsphereBlueprint();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatacenter.
        internal void ProcessRecord_Datacenter()
        {
            this._logger.name += " -Datacenter";
            // Invoke graphql operation vSphereDatacenter
            InvokeQueryVsphereDatacenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereComputeCluster.
        internal void ProcessRecord_ComputeCluster()
        {
            this._logger.name += " -ComputeCluster";
            // Invoke graphql operation vSphereComputeCluster
            InvokeQueryVsphereComputeCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereResourcePool.
        internal void ProcessRecord_ResourcePool()
        {
            this._logger.name += " -ResourcePool";
            // Invoke graphql operation vSphereResourcePool
            InvokeQueryVsphereResourcePool();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereFolder.
        internal void ProcessRecord_Folder()
        {
            this._logger.name += " -Folder";
            // Invoke graphql operation vSphereFolder
            InvokeQueryVsphereFolder();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHost.
        internal void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Invoke graphql operation vSphereHost
            InvokeQueryVsphereHost();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreCluster.
        internal void ProcessRecord_DatastoreCluster()
        {
            this._logger.name += " -DatastoreCluster";
            // Invoke graphql operation vSphereDatastoreCluster
            InvokeQueryVsphereDatastoreCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastore.
        internal void ProcessRecord_Datastore()
        {
            this._logger.name += " -Datastore";
            // Invoke graphql operation vSphereDatastore
            InvokeQueryVsphereDatastore();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostsByFids.
        internal void ProcessRecord_HostsByFids()
        {
            this._logger.name += " -HostsByFids";
            // Invoke graphql operation vSphereHostsByFids
            InvokeQueryVsphereHostsByFids();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTag.
        internal void ProcessRecord_Tag()
        {
            this._logger.name += " -Tag";
            // Invoke graphql operation vSphereTag
            InvokeQueryVsphereTag();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTagCategory.
        internal void ProcessRecord_TagCategory()
        {
            this._logger.name += " -TagCategory";
            // Invoke graphql operation vSphereTagCategory
            InvokeQueryVsphereTagCategory();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereNetwork.
        internal void ProcessRecord_Network()
        {
            this._logger.name += " -Network";
            // Invoke graphql operation vSphereNetwork
            InvokeQueryVsphereNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTopLevelDescendantsConnection.
        internal void ProcessRecord_TopLevelDescendantsList()
        {
            this._logger.name += " -TopLevelDescendantsList";
            // Invoke graphql operation vSphereTopLevelDescendantsConnection
            InvokeQueryVsphereTopLevelDescendantsConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereRootRecoveryHierarchy.
        internal void ProcessRecord_RootRecoveryHierarchy()
        {
            this._logger.name += " -RootRecoveryHierarchy";
            // Invoke graphql operation vSphereRootRecoveryHierarchy
            InvokeQueryVsphereRootRecoveryHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostConnection.
        internal void ProcessRecord_HostList()
        {
            this._logger.name += " -HostList";
            // Invoke graphql operation vSphereHostConnection
            InvokeQueryVsphereHostConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereComputeClusters.
        internal void ProcessRecord_ComputeClusters()
        {
            this._logger.name += " -ComputeClusters";
            // Invoke graphql operation vSphereComputeClusters
            InvokeQueryVsphereComputeClusters();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreConnection.
        internal void ProcessRecord_DatastoreList()
        {
            this._logger.name += " -DatastoreList";
            // Invoke graphql operation vSphereDatastoreConnection
            InvokeQueryVsphereDatastoreConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreClusters.
        internal void ProcessRecord_DatastoreClusters()
        {
            this._logger.name += " -DatastoreClusters";
            // Invoke graphql operation vSphereDatastoreClusters
            InvokeQueryVsphereDatastoreClusters();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereLiveMounts.
        internal void ProcessRecord_LiveMounts()
        {
            this._logger.name += " -LiveMounts";
            // Invoke graphql operation vSphereLiveMounts
            InvokeQueryVsphereLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMountConnection.
        internal void ProcessRecord_MountList()
        {
            this._logger.name += " -MountList";
            // Invoke graphql operation vSphereMountConnection
            InvokeQueryVsphereMountConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMount.
        internal void ProcessRecord_Mount()
        {
            this._logger.name += " -Mount";
            // Invoke graphql operation vSphereMount
            InvokeQueryVsphereMount();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostDetails.
        internal void ProcessRecord_HostDetails()
        {
            this._logger.name += " -HostDetails";
            // Invoke graphql operation vSphereHostDetails
            InvokeQueryVsphereHostDetails();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmwareCdpLiveInfo.
        internal void ProcessRecord_VmwareCdpLiveInfo()
        {
            this._logger.name += " -VmwareCdpLiveInfo";
            // Invoke graphql operation vsphereVmwareCdpLiveInfo
            InvokeQueryVsphereVmwareCdpLiveInfo();
        }


        // Invoke GraphQL Query:
        // vSphereBlueprint(fid: UUID!): VSphereBlueprint!
        internal void InvokeQueryVsphereBlueprint()
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
        internal void InvokeQueryVsphereDatacenter()
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
        internal void InvokeQueryVsphereComputeCluster()
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
        internal void InvokeQueryVsphereResourcePool()
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
        internal void InvokeQueryVsphereFolder()
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
        internal void InvokeQueryVsphereHost()
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
        internal void InvokeQueryVsphereDatastoreCluster()
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
        internal void InvokeQueryVsphereDatastore()
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
        internal void InvokeQueryVsphereHostsByFids()
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
        internal void InvokeQueryVsphereTag()
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
        internal void InvokeQueryVsphereTagCategory()
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
        internal void InvokeQueryVsphereNetwork()
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
        internal void InvokeQueryVsphereTopLevelDescendantsConnection()
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
        internal void InvokeQueryVsphereRootRecoveryHierarchy()
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
        internal void InvokeQueryVsphereHostConnection()
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
        internal void InvokeQueryVsphereComputeClusters()
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
        internal void InvokeQueryVsphereDatastoreConnection()
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
        internal void InvokeQueryVsphereDatastoreClusters()
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
        internal void InvokeQueryVsphereLiveMounts()
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
        internal void InvokeQueryVsphereMountConnection()
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
        internal void InvokeQueryVsphereMount()
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
        internal void InvokeQueryVsphereHostDetails()
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
        internal void InvokeQueryVsphereVmwareCdpLiveInfo()
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
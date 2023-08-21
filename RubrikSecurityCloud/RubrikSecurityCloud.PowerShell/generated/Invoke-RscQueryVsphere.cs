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
    /// <summary>
    /// vSphere queries
    /// </summary>
    /// <description>
    /// Invoke-RscQueryVsphere is a master cmdlet for Vsphere work that can invoke any of the following subcommands: Blueprint, Datacenter, ComputeCluster, ResourcePool, Folder, Host, DatastoreCluster, Datastore, HostsByFids, Tag, TagCategory, Network, TopLevelDescendantsList, RootRecoveryHierarchy, HostList, Folders, ComputeClusters, DatastoreList, DatastoreClusters, LiveMounts, MountList, Mount, HostDetails, VmwareCdpLiveInfo.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Blueprint [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Datacenter [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -ComputeCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -ResourcePool [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Folder [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Host [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -DatastoreCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Datastore [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -HostsByFids [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Tag [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -TagCategory [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Network [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -TopLevelDescendantsList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -RootRecoveryHierarchy [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -HostList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Folders [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -ComputeClusters [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -DatastoreList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -DatastoreClusters [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -LiveMounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -MountList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -Mount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -HostDetails [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphere -VmwareCdpLiveInfo [-Arg ..] [-Field ..]</code>
    /// </example>
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
        /// Folders parameter set
        ///
        /// [GraphQL: vSphereFolders]
        /// </summary>
        [Parameter(
            ParameterSetName = "Folders",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all the vSphere folders.
[GraphQL: vSphereFolders]",
            Position = 0
        )]
        public SwitchParameter Folders { get; set; }

        
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
                    case "Folders":
                        this.ProcessRecord_Folders();
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
        // vSphereFolders.
        internal void ProcessRecord_Folders()
        {
            this._logger.name += " -Folders";
            // Invoke graphql operation vSphereFolders
            InvokeQueryVsphereFolders();
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereBlueprint",
                "($fid: UUID!)",
                "VsphereBlueprint"
                );
            VsphereBlueprint? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereBlueprint)this.Field;
            }
            string fieldSpecDoc = Query.VsphereBlueprint(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereDatacenter(fid: UUID!): VsphereDatacenter!
        internal void InvokeQueryVsphereDatacenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatacenter",
                "($fid: UUID!)",
                "VsphereDatacenter"
                );
            VsphereDatacenter? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereDatacenter)this.Field;
            }
            string fieldSpecDoc = Query.VsphereDatacenter(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereComputeCluster(fid: UUID!): VsphereComputeCluster!
        internal void InvokeQueryVsphereComputeCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereComputeCluster",
                "($fid: UUID!)",
                "VsphereComputeCluster"
                );
            VsphereComputeCluster? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereComputeCluster)this.Field;
            }
            string fieldSpecDoc = Query.VsphereComputeCluster(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereResourcePool(fid: UUID!): VsphereResourcePool!
        internal void InvokeQueryVsphereResourcePool()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereResourcePool",
                "($fid: UUID!)",
                "VsphereResourcePool"
                );
            VsphereResourcePool? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereResourcePool)this.Field;
            }
            string fieldSpecDoc = Query.VsphereResourcePool(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereFolder(fid: UUID!): VsphereFolder!
        internal void InvokeQueryVsphereFolder()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereFolder",
                "($fid: UUID!)",
                "VsphereFolder"
                );
            VsphereFolder? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereFolder)this.Field;
            }
            string fieldSpecDoc = Query.VsphereFolder(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereHost(fid: UUID!): VsphereHost!
        internal void InvokeQueryVsphereHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHost",
                "($fid: UUID!)",
                "VsphereHost"
                );
            VsphereHost? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereHost)this.Field;
            }
            string fieldSpecDoc = Query.VsphereHost(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereDatastoreCluster(fid: UUID!): VsphereDatastoreCluster!
        internal void InvokeQueryVsphereDatastoreCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatastoreCluster",
                "($fid: UUID!)",
                "VsphereDatastoreCluster"
                );
            VsphereDatastoreCluster? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereDatastoreCluster)this.Field;
            }
            string fieldSpecDoc = Query.VsphereDatastoreCluster(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereDatastore(fid: UUID!): VsphereDatastore!
        internal void InvokeQueryVsphereDatastore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatastore",
                "($fid: UUID!)",
                "VsphereDatastore"
                );
            VsphereDatastore? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereDatastore)this.Field;
            }
            string fieldSpecDoc = Query.VsphereDatastore(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereHostsByFids(fids: [UUID!]!): [VsphereHost!]!
        internal void InvokeQueryVsphereHostsByFids()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHostsByFids",
                "($fids: [UUID!]!)",
                "List<VsphereHost>"
                );
            List<VsphereHost>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<VsphereHost>)this.Field;
            }
            string fieldSpecDoc = Query.VsphereHostsByFids(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereTag(fid: UUID!): VsphereTag!
        internal void InvokeQueryVsphereTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereTag",
                "($fid: UUID!)",
                "VsphereTag"
                );
            VsphereTag? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereTag)this.Field;
            }
            string fieldSpecDoc = Query.VsphereTag(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereTagCategory(fid: UUID!): VsphereTagCategory!
        internal void InvokeQueryVsphereTagCategory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereTagCategory",
                "($fid: UUID!)",
                "VsphereTagCategory"
                );
            VsphereTagCategory? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereTagCategory)this.Field;
            }
            string fieldSpecDoc = Query.VsphereTagCategory(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereNetwork(fid: UUID!): VsphereNetwork!
        internal void InvokeQueryVsphereNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereNetwork",
                "($fid: UUID!)",
                "VsphereNetwork"
                );
            VsphereNetwork? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereNetwork)this.Field;
            }
            string fieldSpecDoc = Query.VsphereNetwork(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereTopLevelDescendantsConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "CdmHierarchyObjectConnection"
                );
            CdmHierarchyObjectConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CdmHierarchyObjectConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereTopLevelDescendantsConnection(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereRootRecoveryHierarchy",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "CdmHierarchyObjectConnection"
                );
            CdmHierarchyObjectConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CdmHierarchyObjectConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereRootRecoveryHierarchy(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHostConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereHostConnection"
                );
            VsphereHostConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereHostConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereHostConnection(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereFolders(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereFolderConnection!
        internal void InvokeQueryVsphereFolders()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereFolders",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereFolderConnection"
                );
            VsphereFolderConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereFolderConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereFolders(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereComputeClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereComputeClusterConnection"
                );
            VsphereComputeClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereComputeClusterConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereComputeClusters(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatastoreConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereDatastoreConnection"
                );
            VsphereDatastoreConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereDatastoreConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereDatastoreConnection(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatastoreClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereDatastoreClusterConnection"
                );
            VsphereDatastoreClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereDatastoreClusterConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereDatastoreClusters(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereLiveMounts",
                "($first: Int,$after: String,$filter: [VsphereLiveMountFilterInput!],$sortBy: VsphereLiveMountSortBy)",
                "VsphereLiveMountConnection"
                );
            VsphereLiveMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereLiveMountConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereLiveMounts(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "query",
                "QueryVsphereMountConnection",
                "($first: Int,$after: String,$filter: VSphereMountFilter,$sortBy: VsphereMountSortBy,$sortOrder: SortOrder)",
                "VsphereMountConnection"
                );
            VsphereMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereMountConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereMountConnection(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereMount(fid: UUID!): VsphereMount!
        internal void InvokeQueryVsphereMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereMount",
                "($fid: UUID!)",
                "VsphereMount"
                );
            VsphereMount? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereMount)this.Field;
            }
            string fieldSpecDoc = Query.VsphereMount(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereHostDetails(input: GetVmwareHostInput!): VmwareHostDetail!
        internal void InvokeQueryVsphereHostDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVmwareHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHostDetails",
                "($input: GetVmwareHostInput!)",
                "VmwareHostDetail"
                );
            VmwareHostDetail? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VmwareHostDetail)this.Field;
            }
            string fieldSpecDoc = Query.VsphereHostDetails(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vsphereVmwareCdpLiveInfo(ids: [String!]!): BatchVmwareCdpLiveInfo!
        internal void InvokeQueryVsphereVmwareCdpLiveInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmwareCdpLiveInfo",
                "($ids: [String!]!)",
                "BatchVmwareCdpLiveInfo"
                );
            BatchVmwareCdpLiveInfo? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchVmwareCdpLiveInfo)this.Field;
            }
            string fieldSpecDoc = Query.VsphereVmwareCdpLiveInfo(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQueryVsphere
}
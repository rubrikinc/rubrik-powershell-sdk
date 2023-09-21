// New-RscQueryVsphere.cs
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
    /// Queries for the 'vSphere' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryVsphere is a master cmdlet for Vsphere work that can invoke any of the following subcommands: Datacenter, ComputeCluster, ResourcePool, Folder, Host, DatastoreCluster, Datastore, HostsByFids, Tag, TagCategory, Network, TopLevelDescendantsList, RootRecoveryHierarchy, HostList, Folders, ComputeClusters, DatastoreList, DatastoreClusters, LiveMounts, MountList, Mount, HostDetails, VmwareCdpLiveInfo.
    /// </description>
    /// <example>
    /// <code>New-RscQueryVsphere -Datacenter [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -ComputeCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -ResourcePool [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -Folder [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -Host [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -DatastoreCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -Datastore [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -HostsByFids [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -Tag [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -TagCategory [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -Network [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -TopLevelDescendantsList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -RootRecoveryHierarchy [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -HostList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -Folders [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -ComputeClusters [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -DatastoreList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -DatastoreClusters [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -LiveMounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -MountList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -Mount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -HostDetails [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphere -VmwareCdpLiveInfo [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryVsphere",
        DefaultParameterSetName = "Host")
    ]
    public class New_RscQueryVsphere : RscGqlPSCmdlet
    {
        
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
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
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
        // vSphereDatacenter.
        internal void ProcessRecord_Datacenter()
        {
            this._logger.name += " -Datacenter";
            // Create new graphql operation vSphereDatacenter
            InitQueryVsphereDatacenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereComputeCluster.
        internal void ProcessRecord_ComputeCluster()
        {
            this._logger.name += " -ComputeCluster";
            // Create new graphql operation vSphereComputeCluster
            InitQueryVsphereComputeCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereResourcePool.
        internal void ProcessRecord_ResourcePool()
        {
            this._logger.name += " -ResourcePool";
            // Create new graphql operation vSphereResourcePool
            InitQueryVsphereResourcePool();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereFolder.
        internal void ProcessRecord_Folder()
        {
            this._logger.name += " -Folder";
            // Create new graphql operation vSphereFolder
            InitQueryVsphereFolder();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHost.
        internal void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Create new graphql operation vSphereHost
            InitQueryVsphereHost();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreCluster.
        internal void ProcessRecord_DatastoreCluster()
        {
            this._logger.name += " -DatastoreCluster";
            // Create new graphql operation vSphereDatastoreCluster
            InitQueryVsphereDatastoreCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastore.
        internal void ProcessRecord_Datastore()
        {
            this._logger.name += " -Datastore";
            // Create new graphql operation vSphereDatastore
            InitQueryVsphereDatastore();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostsByFids.
        internal void ProcessRecord_HostsByFids()
        {
            this._logger.name += " -HostsByFids";
            // Create new graphql operation vSphereHostsByFids
            InitQueryVsphereHostsByFids();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTag.
        internal void ProcessRecord_Tag()
        {
            this._logger.name += " -Tag";
            // Create new graphql operation vSphereTag
            InitQueryVsphereTag();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTagCategory.
        internal void ProcessRecord_TagCategory()
        {
            this._logger.name += " -TagCategory";
            // Create new graphql operation vSphereTagCategory
            InitQueryVsphereTagCategory();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereNetwork.
        internal void ProcessRecord_Network()
        {
            this._logger.name += " -Network";
            // Create new graphql operation vSphereNetwork
            InitQueryVsphereNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTopLevelDescendantsConnection.
        internal void ProcessRecord_TopLevelDescendantsList()
        {
            this._logger.name += " -TopLevelDescendantsList";
            // Create new graphql operation vSphereTopLevelDescendantsConnection
            InitQueryVsphereTopLevelDescendantsConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereRootRecoveryHierarchy.
        internal void ProcessRecord_RootRecoveryHierarchy()
        {
            this._logger.name += " -RootRecoveryHierarchy";
            // Create new graphql operation vSphereRootRecoveryHierarchy
            InitQueryVsphereRootRecoveryHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostConnection.
        internal void ProcessRecord_HostList()
        {
            this._logger.name += " -HostList";
            // Create new graphql operation vSphereHostConnection
            InitQueryVsphereHostConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereFolders.
        internal void ProcessRecord_Folders()
        {
            this._logger.name += " -Folders";
            // Create new graphql operation vSphereFolders
            InitQueryVsphereFolders();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereComputeClusters.
        internal void ProcessRecord_ComputeClusters()
        {
            this._logger.name += " -ComputeClusters";
            // Create new graphql operation vSphereComputeClusters
            InitQueryVsphereComputeClusters();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreConnection.
        internal void ProcessRecord_DatastoreList()
        {
            this._logger.name += " -DatastoreList";
            // Create new graphql operation vSphereDatastoreConnection
            InitQueryVsphereDatastoreConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreClusters.
        internal void ProcessRecord_DatastoreClusters()
        {
            this._logger.name += " -DatastoreClusters";
            // Create new graphql operation vSphereDatastoreClusters
            InitQueryVsphereDatastoreClusters();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereLiveMounts.
        internal void ProcessRecord_LiveMounts()
        {
            this._logger.name += " -LiveMounts";
            // Create new graphql operation vSphereLiveMounts
            InitQueryVsphereLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMountConnection.
        internal void ProcessRecord_MountList()
        {
            this._logger.name += " -MountList";
            // Create new graphql operation vSphereMountConnection
            InitQueryVsphereMountConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMount.
        internal void ProcessRecord_Mount()
        {
            this._logger.name += " -Mount";
            // Create new graphql operation vSphereMount
            InitQueryVsphereMount();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostDetails.
        internal void ProcessRecord_HostDetails()
        {
            this._logger.name += " -HostDetails";
            // Create new graphql operation vSphereHostDetails
            InitQueryVsphereHostDetails();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmwareCdpLiveInfo.
        internal void ProcessRecord_VmwareCdpLiveInfo()
        {
            this._logger.name += " -VmwareCdpLiveInfo";
            // Create new graphql operation vsphereVmwareCdpLiveInfo
            InitQueryVsphereVmwareCdpLiveInfo();
        }


        // Create new GraphQL Query:
        // vSphereDatacenter(fid: UUID!): VsphereDatacenter!
        internal void InitQueryVsphereDatacenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatacenter",
                "($fid: UUID!)",
                "VsphereDatacenter",
                Query.VsphereDatacenter_ObjectFieldSpec,
                Query.VsphereDatacenterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereComputeCluster(fid: UUID!): VsphereComputeCluster!
        internal void InitQueryVsphereComputeCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereComputeCluster",
                "($fid: UUID!)",
                "VsphereComputeCluster",
                Query.VsphereComputeCluster_ObjectFieldSpec,
                Query.VsphereComputeClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereResourcePool(fid: UUID!): VsphereResourcePool!
        internal void InitQueryVsphereResourcePool()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereResourcePool",
                "($fid: UUID!)",
                "VsphereResourcePool",
                Query.VsphereResourcePool_ObjectFieldSpec,
                Query.VsphereResourcePoolFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereFolder(fid: UUID!): VsphereFolder!
        internal void InitQueryVsphereFolder()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereFolder",
                "($fid: UUID!)",
                "VsphereFolder",
                Query.VsphereFolder_ObjectFieldSpec,
                Query.VsphereFolderFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereHost(fid: UUID!): VsphereHost!
        internal void InitQueryVsphereHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHost",
                "($fid: UUID!)",
                "VsphereHost",
                Query.VsphereHost_ObjectFieldSpec,
                Query.VsphereHostFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereDatastoreCluster(fid: UUID!): VsphereDatastoreCluster!
        internal void InitQueryVsphereDatastoreCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatastoreCluster",
                "($fid: UUID!)",
                "VsphereDatastoreCluster",
                Query.VsphereDatastoreCluster_ObjectFieldSpec,
                Query.VsphereDatastoreClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereDatastore(fid: UUID!): VsphereDatastore!
        internal void InitQueryVsphereDatastore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatastore",
                "($fid: UUID!)",
                "VsphereDatastore",
                Query.VsphereDatastore_ObjectFieldSpec,
                Query.VsphereDatastoreFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereHostsByFids(fids: [UUID!]!): [VsphereHost!]!
        internal void InitQueryVsphereHostsByFids()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHostsByFids",
                "($fids: [UUID!]!)",
                "List<VsphereHost>",
                Query.VsphereHostsByFids_ObjectFieldSpec,
                Query.VsphereHostsByFidsFieldSpec,
                @"# REQUIRED
$inputs.Var.fids = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereTag(fid: UUID!): VsphereTag!
        internal void InitQueryVsphereTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereTag",
                "($fid: UUID!)",
                "VsphereTag",
                Query.VsphereTag_ObjectFieldSpec,
                Query.VsphereTagFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereTagCategory(fid: UUID!): VsphereTagCategory!
        internal void InitQueryVsphereTagCategory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereTagCategory",
                "($fid: UUID!)",
                "VsphereTagCategory",
                Query.VsphereTagCategory_ObjectFieldSpec,
                Query.VsphereTagCategoryFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereNetwork(fid: UUID!): VsphereNetwork!
        internal void InitQueryVsphereNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereNetwork",
                "($fid: UUID!)",
                "VsphereNetwork",
                Query.VsphereNetwork_ObjectFieldSpec,
                Query.VsphereNetworkFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereTopLevelDescendantsConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        internal void InitQueryVsphereTopLevelDescendantsConnection()
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
                "CdmHierarchyObjectConnection",
                Query.VsphereTopLevelDescendantsConnection_ObjectFieldSpec,
                Query.VsphereTopLevelDescendantsConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereRootRecoveryHierarchy(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        internal void InitQueryVsphereRootRecoveryHierarchy()
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
                "CdmHierarchyObjectConnection",
                Query.VsphereRootRecoveryHierarchy_ObjectFieldSpec,
                Query.VsphereRootRecoveryHierarchyFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereHostConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereHostConnection!
        internal void InitQueryVsphereHostConnection()
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
                "VsphereHostConnection",
                Query.VsphereHostConnection_ObjectFieldSpec,
                Query.VsphereHostConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereFolders(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereFolderConnection!
        internal void InitQueryVsphereFolders()
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
                "VsphereFolderConnection",
                Query.VsphereFolders_ObjectFieldSpec,
                Query.VsphereFoldersFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereComputeClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereComputeClusterConnection!
        internal void InitQueryVsphereComputeClusters()
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
                "VsphereComputeClusterConnection",
                Query.VsphereComputeClusters_ObjectFieldSpec,
                Query.VsphereComputeClustersFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereDatastoreConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereDatastoreConnection!
        internal void InitQueryVsphereDatastoreConnection()
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
                "VsphereDatastoreConnection",
                Query.VsphereDatastoreConnection_ObjectFieldSpec,
                Query.VsphereDatastoreConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereDatastoreClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereDatastoreClusterConnection!
        internal void InitQueryVsphereDatastoreClusters()
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
                "VsphereDatastoreClusterConnection",
                Query.VsphereDatastoreClusters_ObjectFieldSpec,
                Query.VsphereDatastoreClustersFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereLiveMounts(
        //     first: Int
        //     after: String
        //     filter: [VsphereLiveMountFilterInput!]
        //     sortBy: VsphereLiveMountSortBy
        //   ): VsphereLiveMountConnection!
        internal void InitQueryVsphereLiveMounts()
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
                "VsphereLiveMountConnection",
                Query.VsphereLiveMounts_ObjectFieldSpec,
                Query.VsphereLiveMountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <VsphereLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <VsphereLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // vSphereMountConnection(
        //     first: Int
        //     after: String
        //     filter: VSphereMountFilter
        //     sortBy: VsphereMountSortBy
        //     sortOrder: SortOrder
        //   ): VsphereMountConnection!
        internal void InitQueryVsphereMountConnection()
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
                "VsphereMountConnection",
                Query.VsphereMountConnection_ObjectFieldSpec,
                Query.VsphereMountConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	clusterUuid = @(
		<System.String>
	)
	# OPTIONAL
	powerStatus = @(
		<System.Boolean>
	)
	# OPTIONAL
	sourceVmId = <System.String>
}
# OPTIONAL
$inputs.Var.sortBy = <VsphereMountSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereMountSortBy]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // vSphereMount(fid: UUID!): VsphereMount!
        internal void InitQueryVsphereMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereMount",
                "($fid: UUID!)",
                "VsphereMount",
                Query.VsphereMount_ObjectFieldSpec,
                Query.VsphereMountFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereHostDetails(input: GetVmwareHostInput!): VmwareHostDetail!
        internal void InitQueryVsphereHostDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVmwareHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHostDetails",
                "($input: GetVmwareHostInput!)",
                "VmwareHostDetail",
                Query.VsphereHostDetails_ObjectFieldSpec,
                Query.VsphereHostDetailsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // vsphereVmwareCdpLiveInfo(ids: [String!]!): BatchVmwareCdpLiveInfo!
        internal void InitQueryVsphereVmwareCdpLiveInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmwareCdpLiveInfo",
                "($ids: [String!]!)",
                "BatchVmwareCdpLiveInfo",
                Query.VsphereVmwareCdpLiveInfo_ObjectFieldSpec,
                Query.VsphereVmwareCdpLiveInfoFieldSpec,
                @"# REQUIRED
$inputs.Var.ids = @(
	<System.String>
)"
            );
        }


    } // class New_RscQueryVsphere
}
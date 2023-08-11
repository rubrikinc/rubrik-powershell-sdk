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
        
        /// <summary>
        /// TopLevelDescendants parameter set
        ///
        /// [GraphQL: nutanixTopLevelDescendants]
        /// </summary>
        [Parameter(
            ParameterSetName = "TopLevelDescendants",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level Nutanix Objects accessible by the current user.
[GraphQL: nutanixTopLevelDescendants]",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendants { get; set; }

        
        /// <summary>
        /// Cluster parameter set
        ///
        /// [GraphQL: nutanixCluster]
        /// </summary>
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

        
        /// <summary>
        /// Clusters parameter set
        ///
        /// [GraphQL: nutanixClusters]
        /// </summary>
        [Parameter(
            ParameterSetName = "Clusters",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Nutanix Clusters.
[GraphQL: nutanixClusters]",
            Position = 0
        )]
        public SwitchParameter Clusters { get; set; }

        
        /// <summary>
        /// PrismCentrals parameter set
        ///
        /// [GraphQL: nutanixPrismCentrals]
        /// </summary>
        [Parameter(
            ParameterSetName = "PrismCentrals",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Nutanix Prism Central objects.
[GraphQL: nutanixPrismCentrals]",
            Position = 0
        )]
        public SwitchParameter PrismCentrals { get; set; }

        
        /// <summary>
        /// PrismCentral parameter set
        ///
        /// [GraphQL: nutanixPrismCentral]
        /// </summary>
        [Parameter(
            ParameterSetName = "PrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the given Prism Central.
[GraphQL: nutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter PrismCentral { get; set; }

        
        /// <summary>
        /// Category parameter set
        ///
        /// [GraphQL: nutanixCategory]
        /// </summary>
        [Parameter(
            ParameterSetName = "Category",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the given category.
[GraphQL: nutanixCategory]",
            Position = 0
        )]
        public SwitchParameter Category { get; set; }

        
        /// <summary>
        /// CategoryValue parameter set
        ///
        /// [GraphQL: nutanixCategoryValue]
        /// </summary>
        [Parameter(
            ParameterSetName = "CategoryValue",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the given category value.
[GraphQL: nutanixCategoryValue]",
            Position = 0
        )]
        public SwitchParameter CategoryValue { get; set; }

        
        /// <summary>
        /// Vm parameter set
        ///
        /// [GraphQL: nutanixVm]
        /// </summary>
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

        
        /// <summary>
        /// Vms parameter set
        ///
        /// [GraphQL: nutanixVms]
        /// </summary>
        [Parameter(
            ParameterSetName = "Vms",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Nutanix Virtual Machines.
[GraphQL: nutanixVms]",
            Position = 0
        )]
        public SwitchParameter Vms { get; set; }

        
        /// <summary>
        /// Mounts parameter set
        ///
        /// [GraphQL: nutanixMounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "Mounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Nutanix Live Mount Connection.
[GraphQL: nutanixMounts]",
            Position = 0
        )]
        public SwitchParameter Mounts { get; set; }

        
        /// <summary>
        /// ClusterContainers parameter set
        ///
        /// [GraphQL: nutanixClusterContainers]
        /// </summary>
        [Parameter(
            ParameterSetName = "ClusterContainers",
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
        public SwitchParameter ClusterContainers { get; set; }

        
        /// <summary>
        /// ClusterNetworks parameter set
        ///
        /// [GraphQL: nutanixClusterNetworks]
        /// </summary>
        [Parameter(
            ParameterSetName = "ClusterNetworks",
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
        public SwitchParameter ClusterNetworks { get; set; }

        
        /// <summary>
        /// ClusterAsyncRequestStatus parameter set
        ///
        /// [GraphQL: nutanixClusterAsyncRequestStatus]
        /// </summary>
        [Parameter(
            ParameterSetName = "ClusterAsyncRequestStatus",
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
        public SwitchParameter ClusterAsyncRequestStatus { get; set; }

        
        /// <summary>
        /// VmAsyncRequestStatus parameter set
        ///
        /// [GraphQL: nutanixVmAsyncRequestStatus]
        /// </summary>
        [Parameter(
            ParameterSetName = "VmAsyncRequestStatus",
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
        public SwitchParameter VmAsyncRequestStatus { get; set; }

        
        /// <summary>
        /// SearchVm parameter set
        ///
        /// [GraphQL: searchNutanixVm]
        /// </summary>
        [Parameter(
            ParameterSetName = "SearchVm",
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
        public SwitchParameter SearchVm { get; set; }

        
        /// <summary>
        /// VmMissedSnapshots parameter set
        ///
        /// [GraphQL: nutanixVmMissedSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "VmMissedSnapshots",
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
        public SwitchParameter VmMissedSnapshots { get; set; }

        
        /// <summary>
        /// BrowseSnapshot parameter set
        ///
        /// [GraphQL: nutanixBrowseSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "BrowseSnapshot",
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
        public SwitchParameter BrowseSnapshot { get; set; }

        
        /// <summary>
        /// SnapshotDetail parameter set
        ///
        /// [GraphQL: nutanixSnapshotDetail]
        /// </summary>
        [Parameter(
            ParameterSetName = "SnapshotDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Supported in v5.0+. Get Nutanix virtual machine snapshot details.
 Retrieve detailed information about a snapshot.
[GraphQL: nutanixSnapshotDetail]",
            Position = 0
        )]
        public SwitchParameter SnapshotDetail { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendants":
                        this.ProcessRecord_TopLevelDescendants();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "Clusters":
                        this.ProcessRecord_Clusters();
                        break;
                    case "PrismCentrals":
                        this.ProcessRecord_PrismCentrals();
                        break;
                    case "PrismCentral":
                        this.ProcessRecord_PrismCentral();
                        break;
                    case "Category":
                        this.ProcessRecord_Category();
                        break;
                    case "CategoryValue":
                        this.ProcessRecord_CategoryValue();
                        break;
                    case "Vm":
                        this.ProcessRecord_Vm();
                        break;
                    case "Vms":
                        this.ProcessRecord_Vms();
                        break;
                    case "Mounts":
                        this.ProcessRecord_Mounts();
                        break;
                    case "ClusterContainers":
                        this.ProcessRecord_ClusterContainers();
                        break;
                    case "ClusterNetworks":
                        this.ProcessRecord_ClusterNetworks();
                        break;
                    case "ClusterAsyncRequestStatus":
                        this.ProcessRecord_ClusterAsyncRequestStatus();
                        break;
                    case "VmAsyncRequestStatus":
                        this.ProcessRecord_VmAsyncRequestStatus();
                        break;
                    case "SearchVm":
                        this.ProcessRecord_SearchVm();
                        break;
                    case "VmMissedSnapshots":
                        this.ProcessRecord_VmMissedSnapshots();
                        break;
                    case "BrowseSnapshot":
                        this.ProcessRecord_BrowseSnapshot();
                        break;
                    case "SnapshotDetail":
                        this.ProcessRecord_SnapshotDetail();
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
        // nutanixTopLevelDescendants.
        internal void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Invoke graphql operation nutanixTopLevelDescendants
            InvokeQueryNutanixTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCluster.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Invoke graphql operation nutanixCluster
            InvokeQueryNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusters.
        internal void ProcessRecord_Clusters()
        {
            this._logger.name += " -Clusters";
            // Invoke graphql operation nutanixClusters
            InvokeQueryNutanixClusters();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixPrismCentrals.
        internal void ProcessRecord_PrismCentrals()
        {
            this._logger.name += " -PrismCentrals";
            // Invoke graphql operation nutanixPrismCentrals
            InvokeQueryNutanixPrismCentrals();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixPrismCentral.
        internal void ProcessRecord_PrismCentral()
        {
            this._logger.name += " -PrismCentral";
            // Invoke graphql operation nutanixPrismCentral
            InvokeQueryNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCategory.
        internal void ProcessRecord_Category()
        {
            this._logger.name += " -Category";
            // Invoke graphql operation nutanixCategory
            InvokeQueryNutanixCategory();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCategoryValue.
        internal void ProcessRecord_CategoryValue()
        {
            this._logger.name += " -CategoryValue";
            // Invoke graphql operation nutanixCategoryValue
            InvokeQueryNutanixCategoryValue();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVm.
        internal void ProcessRecord_Vm()
        {
            this._logger.name += " -Vm";
            // Invoke graphql operation nutanixVm
            InvokeQueryNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVms.
        internal void ProcessRecord_Vms()
        {
            this._logger.name += " -Vms";
            // Invoke graphql operation nutanixVms
            InvokeQueryNutanixVms();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixMounts.
        internal void ProcessRecord_Mounts()
        {
            this._logger.name += " -Mounts";
            // Invoke graphql operation nutanixMounts
            InvokeQueryNutanixMounts();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterContainers.
        internal void ProcessRecord_ClusterContainers()
        {
            this._logger.name += " -ClusterContainers";
            // Invoke graphql operation nutanixClusterContainers
            InvokeQueryNutanixClusterContainers();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterNetworks.
        internal void ProcessRecord_ClusterNetworks()
        {
            this._logger.name += " -ClusterNetworks";
            // Invoke graphql operation nutanixClusterNetworks
            InvokeQueryNutanixClusterNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterAsyncRequestStatus.
        internal void ProcessRecord_ClusterAsyncRequestStatus()
        {
            this._logger.name += " -ClusterAsyncRequestStatus";
            // Invoke graphql operation nutanixClusterAsyncRequestStatus
            InvokeQueryNutanixClusterAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVmAsyncRequestStatus.
        internal void ProcessRecord_VmAsyncRequestStatus()
        {
            this._logger.name += " -VmAsyncRequestStatus";
            // Invoke graphql operation nutanixVmAsyncRequestStatus
            InvokeQueryNutanixVmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // searchNutanixVm.
        internal void ProcessRecord_SearchVm()
        {
            this._logger.name += " -SearchVm";
            // Invoke graphql operation searchNutanixVm
            InvokeQuerySearchNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVmMissedSnapshots.
        internal void ProcessRecord_VmMissedSnapshots()
        {
            this._logger.name += " -VmMissedSnapshots";
            // Invoke graphql operation nutanixVmMissedSnapshots
            InvokeQueryNutanixVmMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixBrowseSnapshot.
        internal void ProcessRecord_BrowseSnapshot()
        {
            this._logger.name += " -BrowseSnapshot";
            // Invoke graphql operation nutanixBrowseSnapshot
            InvokeQueryNutanixBrowseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixSnapshotDetail.
        internal void ProcessRecord_SnapshotDetail()
        {
            this._logger.name += " -SnapshotDetail";
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
        internal void InvokeQueryNutanixTopLevelDescendants()
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
            string fieldSpecDoc = Query.NutanixTopLevelDescendants(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                fieldSpecDoc,
                "CdmHierarchyObjectConnection"
            );
        }

        // Invoke GraphQL Query:
        // nutanixCluster(fid: UUID!): NutanixCluster!
        internal void InvokeQueryNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixCluster? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixCluster)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixCluster)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixCluster",
                "($fid: UUID!)",
                fieldSpecDoc,
                "NutanixCluster"
            );
        }

        // Invoke GraphQL Query:
        // nutanixClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixClusterConnection!
        internal void InvokeQueryNutanixClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixClusterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixClusterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "NutanixClusterConnection"
            );
        }

        // Invoke GraphQL Query:
        // nutanixPrismCentrals(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixPrismCentralConnection!
        internal void InvokeQueryNutanixPrismCentrals()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixPrismCentralConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixPrismCentralConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixPrismCentralConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixPrismCentrals(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixPrismCentrals",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "NutanixPrismCentralConnection"
            );
        }

        // Invoke GraphQL Query:
        // nutanixPrismCentral(fid: UUID!): NutanixPrismCentral!
        internal void InvokeQueryNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixPrismCentral? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixPrismCentral)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixPrismCentral)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixPrismCentral(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixPrismCentral",
                "($fid: UUID!)",
                fieldSpecDoc,
                "NutanixPrismCentral"
            );
        }

        // Invoke GraphQL Query:
        // nutanixCategory(fid: UUID!): NutanixCategory!
        internal void InvokeQueryNutanixCategory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixCategory? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixCategory)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixCategory)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixCategory(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixCategory",
                "($fid: UUID!)",
                fieldSpecDoc,
                "NutanixCategory"
            );
        }

        // Invoke GraphQL Query:
        // nutanixCategoryValue(fid: UUID!): NutanixCategoryValue!
        internal void InvokeQueryNutanixCategoryValue()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixCategoryValue? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixCategoryValue)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixCategoryValue)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixCategoryValue(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixCategoryValue",
                "($fid: UUID!)",
                fieldSpecDoc,
                "NutanixCategoryValue"
            );
        }

        // Invoke GraphQL Query:
        // nutanixVm(fid: UUID!): NutanixVm!
        internal void InvokeQueryNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixVm? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixVm)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixVm)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixVm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixVm",
                "($fid: UUID!)",
                fieldSpecDoc,
                "NutanixVm"
            );
        }

        // Invoke GraphQL Query:
        // nutanixVms(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixVmConnection!
        internal void InvokeQueryNutanixVms()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixVmConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixVmConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixVmConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixVms(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixVms",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "NutanixVmConnection"
            );
        }

        // Invoke GraphQL Query:
        // nutanixMounts(
        //     first: Int
        //     after: String
        //     filters: [NutanixLiveMountFilterInput!]
        //     sortBy: NutanixLiveMountSortByInput
        //   ): NutanixLiveMountConnection!
        internal void InvokeQueryNutanixMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[NutanixLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "NutanixLiveMountSortByInput"),
            };
            NutanixLiveMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixLiveMountConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixLiveMountConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixMounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixMounts",
                "($first: Int,$after: String,$filters: [NutanixLiveMountFilterInput!],$sortBy: NutanixLiveMountSortByInput)",
                fieldSpecDoc,
                "NutanixLiveMountConnection"
            );
        }

        // Invoke GraphQL Query:
        // nutanixClusterContainers(input: GetContainersInput!): NutanixContainerListResponse!
        internal void InvokeQueryNutanixClusterContainers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetContainersInput!"),
            };
            NutanixContainerListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixContainerListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixContainerListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixClusterContainers(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixClusterContainers",
                "($input: GetContainersInput!)",
                fieldSpecDoc,
                "NutanixContainerListResponse"
            );
        }

        // Invoke GraphQL Query:
        // nutanixClusterNetworks(input: GetNutanixNetworksInput!): NutanixNetworkListResponse!
        internal void InvokeQueryNutanixClusterNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixNetworksInput!"),
            };
            NutanixNetworkListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixNetworkListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixNetworkListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixClusterNetworks(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixClusterNetworks",
                "($input: GetNutanixNetworksInput!)",
                fieldSpecDoc,
                "NutanixNetworkListResponse"
            );
        }

        // Invoke GraphQL Query:
        // nutanixClusterAsyncRequestStatus(input: GetNutanixClusterAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InvokeQueryNutanixClusterAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixClusterAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixClusterAsyncRequestStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixClusterAsyncRequestStatus",
                "($input: GetNutanixClusterAsyncRequestStatusInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Query:
        // nutanixVmAsyncRequestStatus(input: GetNutanixVmAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InvokeQueryNutanixVmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixVmAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixVmAsyncRequestStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixVmAsyncRequestStatus",
                "($input: GetNutanixVmAsyncRequestStatusInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Query:
        // searchNutanixVm(input: SearchNutanixVmInput!): SearchResponseListResponse!
        internal void InvokeQuerySearchNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SearchNutanixVmInput!"),
            };
            SearchResponseListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (SearchResponseListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (SearchResponseListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.SearchNutanixVm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QuerySearchNutanixVm",
                "($input: SearchNutanixVmInput!)",
                fieldSpecDoc,
                "SearchResponseListResponse"
            );
        }

        // Invoke GraphQL Query:
        // nutanixVmMissedSnapshots(input: NutanixMissedSnapshotsInput!): MissedSnapshotListResponse!
        internal void InvokeQueryNutanixVmMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "NutanixMissedSnapshotsInput!"),
            };
            MissedSnapshotListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MissedSnapshotListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MissedSnapshotListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixVmMissedSnapshots(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixVmMissedSnapshots",
                "($input: NutanixMissedSnapshotsInput!)",
                fieldSpecDoc,
                "MissedSnapshotListResponse"
            );
        }

        // Invoke GraphQL Query:
        // nutanixBrowseSnapshot(input: BrowseNutanixSnapshotInput!): BrowseResponseListResponse!
        internal void InvokeQueryNutanixBrowseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BrowseNutanixSnapshotInput!"),
            };
            BrowseResponseListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BrowseResponseListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BrowseResponseListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixBrowseSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixBrowseSnapshot",
                "($input: BrowseNutanixSnapshotInput!)",
                fieldSpecDoc,
                "BrowseResponseListResponse"
            );
        }

        // Invoke GraphQL Query:
        // nutanixSnapshotDetail(input: GetNutanixSnapshotDetailInput!): NutanixVmSnapshotDetail!
        internal void InvokeQueryNutanixSnapshotDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixSnapshotDetailInput!"),
            };
            NutanixVmSnapshotDetail? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NutanixVmSnapshotDetail)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NutanixVmSnapshotDetail)this.Field;
                }
            }
            string fieldSpecDoc = Query.NutanixSnapshotDetail(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryNutanixSnapshotDetail",
                "($input: GetNutanixSnapshotDetailInput!)",
                fieldSpecDoc,
                "NutanixVmSnapshotDetail"
            );
        }


    } // class Invoke_RscQueryNutanix
}
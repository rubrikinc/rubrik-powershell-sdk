using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Retrieves all of the snapshots (backups) for any given object
    /// </summary>
    /// <description>
    /// The Get-RscSnapshot cmdlet is used to query the RSC instance for all
    /// known snapshots (backups) for a protected object.
    /// Multiple objects to be piped into this function is not yet supported
    /// </description>
    /// <example>
    /// Get the snapshot list for an object by the object Id
    /// <code>Get-RscSnapshot -Id 'xxxxxx-xxxxx-xxxxxx-xxxxx'</code>
    /// </example>
    /// <example>
    /// Get the snapshots for vSphere VM from pipeline
    /// <code>
    /// $vm = Get-RscVsphereVm -Id xxxxxx-xxxxxx-xxxxxx-xxxxxx
    /// $vm | Get-RscSnapshot
    /// </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "RscSnapshot", DefaultParameterSetName = "Summary")]
    public class Get_RscSnapshot : RscPSCmdlet
    {
        // ----------------------------------------------------------
        // Parameter Set "Summary"

        /// <summary>
        /// The ID of the snappable object to get a list of snapshots for.
        /// </summary>
        [Parameter(
            Position = 0,
            ParameterSetName = "Summary",
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        [Alias("Id")]
        public string SnappableId { get; set; }

        /// <summary>
        /// Return only the first # of results
        /// </summary>
        [Parameter(
            Position = 1,
            ParameterSetName = "Summary",
            Mandatory = false)]
        public int First { get; set; }

        /// <summary>
        /// Retreive a single CDM snapshot by ID. PolarisSnapshot is not yet supported.
        /// </summary>
        [Parameter(
            Position = 0,
            ParameterSetName = "SnapshotById",
            Mandatory = true,
            ValueFromPipelineByPropertyName = false,
            ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Ensure that the snapshot returned belongs to a specific CDM Cluster.
        /// </summary>
        [Parameter(
            Position = 0,
            ParameterSetName = "SnapshotById",
            Mandatory = false,
            ValueFromPipelineByPropertyName = false,
            ValueFromPipeline = false)]
        public string ClusterUUID { get; set; }

        private GraphQL.GraphQLRequest BuildSnapshotBuIdRequest()
        {
            GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest();
            CdmSnapshot queryObj = new CdmSnapshot();

            // Request the cluster information
            queryObj.Cluster = new Cluster();
            queryObj.Cluster.InitializeToDefaultValues();

            // Request the archival location information
            queryObj.ArchivalLocations = new List<DataLocation>();
            DataLocation arcLoc = new DataLocation();
            arcLoc.InitializeToDefaultValues(0);
            queryObj.ArchivalLocations.Add(arcLoc);

            queryObj.InitializeToDefaultValues(0);

            string queryFragment = Query.Snapshot(ref queryObj);
            string queryText = $"query GetSnapshotByIdQuery(" +
                $"$snapshotFid: UUID!, " +
                $"$clusterUuid: UUID" +
                $"){{\n" +
                $"{queryFragment}" +
                $"\n}}";

            request.Query = queryText;
            request.OperationName = "GetSnapshotByIdQuery";

            return request;
        }

        private GraphQL.GraphQLRequest BuildGenericRequest()
        {
            GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest();

            //build a top-level query object for the snapshots query
            GenericSnapshotConnection queryObj = new GenericSnapshotConnection();
            queryObj.Nodes = new List<GenericSnapshot>();

            // Include one of each implementing types to build the
            // query fragments with "... on "
            CdmSnapshot cdmSnapshot = new CdmSnapshot();
            PolarisSnapshot polarisSnapshot = new PolarisSnapshot();

            // Populate the scalar fields
            cdmSnapshot.InitializeToDefaultValues(0);
            cdmSnapshot.Locations = new List<DataLocation>();
            cdmSnapshot.Locations.Add(new DataLocation());

            // Request the cluster information
            cdmSnapshot.Cluster = new Cluster();
            cdmSnapshot.Cluster.InitializeToDefaultValues();

            // Request the archival location information
            cdmSnapshot.ArchivalLocations = new List<DataLocation>();
            DataLocation arcLoc = new DataLocation();
            arcLoc.InitializeToDefaultValues(0);
            cdmSnapshot.ArchivalLocations.Add(arcLoc);


            cdmSnapshot.Locations[0].InitializeToDefaultValues(0);

            // Request the SLA Domain infomraiton
            ClusterSlaDomain tmpSlaDomain = new ClusterSlaDomain();
            tmpSlaDomain.InitializeToDefaultValues(0);
            cdmSnapshot.SlaDomain = tmpSlaDomain;

            polarisSnapshot.InitializeToDefaultValues(0);

            // Remove consistencyLevel as that will fail the query
            // where multiple possible interface types could be returned
            // We need to find a way around this problem.

            cdmSnapshot.ConsistencyLevel = null;
            polarisSnapshot.ConsistencyLevel = null;

            // Add the snapshot types to the query object
            queryObj.Nodes.Add(cdmSnapshot);
            queryObj.Nodes.Add(polarisSnapshot);


            string queryFragment = Query.SnapshotOfAsnappableConnection(ref queryObj);

            // Build the query header
            string queryText = @"
                                    query SnapshotListQuery(
                                    $after: String
                                    $before: String
                                    $first: Int
                                    $ignoreActiveWorkloadCheck: Boolean
                                    $last: Int
                                    $snapshotFilter: [SnapshotQueryFilterInput!]
                                    $sortBy: SnapshotQuerySortByField
                                    $sortOrder: SortOrder
                                    $timeRange: TimeRangeInput
                                    $workloadId: String!
                                    ){";

            // Add the fields and close
            queryText += queryFragment;
            queryText += "\n}";

            request.OperationName = "SnapshotListQuery";
            request.Query = queryText;

            return request;
        }

        private GraphQL.GraphQLRequest BuildMssqlDatabaseRequest()
        {
            GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest();

            MssqlDatabase dbQueryObject = new MssqlDatabase
            {
                Id = "FETCH",
                CdmSnapshots = new CdmWorkloadSnapshotConnection
                {
                    Nodes = new List<CdmWorkloadSnapshot>
                    {
                        new CdmWorkloadSnapshot()
                    }
                }
            };

            dbQueryObject.CdmSnapshots.Nodes[0].InitializeToDefaultValues(0);

            string queryFragment = Query.MssqlDatabase(ref dbQueryObject);

            // Build the query header
            string queryText = @"
                query MssqlDatabaseSnapshotQuery(
                $fid: UUID!
                ){";

            // Add the fields and close
            queryText += queryFragment;
            queryText += "\n}";

            request.Query = queryText;
            request.OperationName = "MssqlDatabaseSnapshotQuery";

            return request;
        }

        protected override void ProcessRecord()
        {
            try
            {
                switch (ParameterSetName)
                {
                    case "SnapshotById":
                        GraphQL.GraphQLRequest snapByIdRequest = BuildSnapshotBuIdRequest();
                        OperationVariableSet snapByIdVars = new OperationVariableSet
                        {
                            Variables = new Dictionary<string, System.Object>
                            {
                                { "snapshotFid", SnapshotId },
                                { "clusterUuid", ClusterUUID}
                            }
                        };
                        Task<CdmSnapshot> snapByIdTask =
                           _rbkClient.InvokeGenericCallAsync<CdmSnapshot>
                           (snapByIdRequest, snapByIdVars);

                        snapByIdTask.Wait();

                        WriteObject(snapByIdTask.Result, false);

                        break;

                    case "Summary":

                        // Get the snappable type
                        string snappableType = this.GetSnappableTypeNameById(SnappableId);
                        GraphQL.GraphQLRequest request;
                        OperationVariableSet vars;

                        switch (snappableType)
                        {
                            case "MssqlDatabase":
                                request = BuildMssqlDatabaseRequest();

                                //Attach the variable
                                vars = new OperationVariableSet
                                {
                                    Variables = new Dictionary<string, object>
                                    {
                                        { "fid", SnappableId }
                                    }
                                };
                                Task<MssqlDatabase> mssqlTask =
                                    _rbkClient.InvokeGenericCallAsync<MssqlDatabase>
                                    (request, vars);

                                mssqlTask.Wait();
                                WriteObject(mssqlTask.Result.CdmSnapshots.Nodes, true);
                                break;

                            default:
                                request = BuildGenericRequest();

                                //Attach the variable
                                vars = new OperationVariableSet
                                {
                                    Variables = new Dictionary<string, object>
                                    {
                                        { "workloadId", SnappableId },
                                    }
                                };

                                if (First > 0)
                                {
                                    vars.Variables.Add("first", First);
                                }

                                Task<GenericSnapshotConnection> genericTask =
                                    _rbkClient.InvokeGenericCallAsync<GenericSnapshotConnection>
                                    (request, vars);

                                genericTask.Wait();
                                WriteObject(genericTask.Result.Nodes, true);

                                break;
                        }

                        break;

                    default:
                        Console.WriteLine("DEBUG Unknown parameter set" + ParameterSetName);
                        break;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorRecord(
                    ex,
                    "InvalidArgumentToCmdlet",
                    ErrorCategory.InvalidArgument,
                    null);
                ThrowTerminatingError(error);
            }
        }
    }
}

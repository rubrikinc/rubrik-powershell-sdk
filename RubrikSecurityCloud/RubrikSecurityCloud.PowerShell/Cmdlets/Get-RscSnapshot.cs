using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using Rubrik.SecurityCloud.PowerShell.Private;
using Rubrik.SecurityCloud.Types;
using RubrikSecurityCloud.PowerShell.Private;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Retrieves all of the snapshots (backups) for any given object
    /// </summary>
    /// <description>
    /// The Get-RscSnapshor cmdlet is used to query the RSC instance for all
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
            ValueFromPipelineByPropertyName = false)]
        [ValidateNotNullOrEmpty]
        public string SnappableId { get; set; }

        protected override void ProcessRecord()
        {
            try
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
                cdmSnapshot.ApplyExploratoryFragment();
                polarisSnapshot.ApplyExploratoryFragment();

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

                switch (ParameterSetName)
                {
                    case "Summary":
                        //Now build the query and attache the fragment
                        string getSnappableSnapshotsByIdQuery = queryText;

                        //Attach the variable
                        OperationVariableSet vars = new OperationVariableSet
                        {
                            Variables = new Dictionary<string, object>
                            {
                                { "workloadId", SnappableId }
                            }
                        };

                        Task<GenericSnapshotConnection> dataTask =
                                _rbkClient.InvokeGenericCallAsync<GenericSnapshotConnection>
                            (request, vars);

                        dataTask.Wait();
                        WriteObject(dataTask.Result.Nodes, true);

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

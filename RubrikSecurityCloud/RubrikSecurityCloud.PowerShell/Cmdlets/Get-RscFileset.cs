using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Threading.Tasks;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Private;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Retrieve one or more filsets managed by
    /// Rubrik Security Cloud (Rsc).
    /// </summary>
    /// <description>
    /// The Get-RscFileset cmdlet is used to get one or more filesets
    /// known to RSC. The -FilesetId parameter will return a single fileset.
    /// All other parameters will return a list of matching filesets.
    /// When -FilesetId is NOT specified, -HostId is required.
    /// -HostId can accept a value from the pipeline
    /// </description>
    /// <example>
    /// Get a list of all filesets on a specified host
    /// <code> Get-RscFileset -HostId xxxxx-xxxxx-xxxxx-xxxxx </code>
    /// </example>
    /// <example>
    /// Get a list of all filesets on a specified host, filtered by name
    /// <code> Get-RscFileset -HostId xxxxx-xxxxx-xxxxx-xxxxx -Name etc </code>
    /// </example>
    /// <example>
    /// Get a list of all filesets on a host, providing the host via the pipeline
    /// <code> Get-RscHost -OsType Linux -First 1 | Get-RscFileset </code>
    /// </example>

    [Cmdlet(VerbsCommon.Get, "RscFileset",
        DefaultParameterSetName = "Query")]
    public class Get_RscFileset: RscBasePSCmdlet
	{
        /// <summary>
        /// The Id of the Physical Host to get filesets for
        /// </summary>
        [Parameter(
            Mandatory = true,
            ParameterSetName = "Query",
            ValueFromPipelineByPropertyName = true,
            Position = 0)]
        [ValidateNotNullOrEmpty]
        [Alias("Id")]
        public string HostId { get; set; }

        /// <summary>
        /// Filter results by name
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Return only the fist # of results
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 2)]
        public int First { get; set; }

        /// <summary>
        /// Sort by field name
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 3)]
        [ValidateSet("NAME", "ID")]
        public string SortBy { get; set; }

        /// <summary>
        /// Sort Order
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 4)]
        [ValidateSet("ASC", "DESC")]
        public string SortOrder { get; set; }


        /// <summary>
        /// Get a fileset using its ID
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Id",
            Position = 0)]
        [ValidateNotNullOrEmpty]
        public string FilesetId { get; set; }

#pragma warning disable 1591 // ignore warning 'Missing XML comment'

        public Get_RscFileset(): base(retrieveConnection: true)
        {
        }

        ///// <summary>
        ///// Activate selected fields based on not-null properties
        ///// of the input fields object
        ///// </summary>
        //[Parameter(
        //    Mandatory = false,
        //    Position = 0)]
        //public new FilesetTemplate Field { get; set; }

        private string GetHostOsTypeFromHostId()
        {
            string query = $"query GetHostTypeQuery($fid: UUID!){{\n" +
                           $"physicalHost(fid: $fid){{\n" +
                           $"osType\n" +
                           $"}}\n" +
                           $"}}";
            GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest
            {
                Query = query,
                OperationName = "GetHostTypeQuery"
            };

            OperationVariableSet vars = new OperationVariableSet
            {
                Variables = new Dictionary<string, object>
                {
                    { "fid", this.HostId}
                }
            };

            Task<PhysicalHost> dataTask =
                _rbkClient.InvokeGenericCallAsync<PhysicalHost>
                (request, vars);
            dataTask.Wait();

            return dataTask.Result.OsType.ToString();
        }

        private string GetFilesetTypeFromId()
        {
            string query =
                $"query GetFilesetTypeFromId($fid: UUID!){{\n" +
                $"hierarchyObject(fid: $fid){{\n" +
                $"objectType\n}}\n}}";

            OperationVariableSet vars = new OperationVariableSet
            {
                Variables = new Dictionary<string, object>
                {
                    {"fid", this.FilesetId }
                }
            };

            GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest
            {
                Query = query,
                OperationName = "GetFilesetTypeFromId"
            };

            Task<HierarchyObject> dataTask =
                _rbkClient.InvokeGenericCallAsync<HierarchyObject>
                (request, vars);
            dataTask.Wait();

            return dataTask.Result.ObjectType.ToString();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                // Create a new GQL Request Object
                GraphQL.GraphQLRequest request = new();

                // Define a new variableset container, uninitialized.
                OperationVariableSet vars;

                switch (ParameterSetName)
                {
                    // ACT ON PARAMETERSET 'Query'
                    //We are returning a list of templates here based on a query
                    case "Query":
                    {
                        PhysicalHost nodeObj = (PhysicalHost)RscTypeInitializer
                            .InitializeTypeWithSelectedProperties("PhysicalHost",
                            new string[]
                            {
                        "Id","Name", "PhysicalChildConnection"
                            });

                        nodeObj.PhysicalChildConnection.Nodes = new RscInterface<PhysicalHostPhysicalChildType>();

                        string hostOsType = this.GetHostOsTypeFromHostId();
                        switch (hostOsType)
                        {
                            case "LINUX":
                                nodeObj.PhysicalChildConnection.Nodes.Add(
                                    new LinuxFileset());
                                nodeObj.PhysicalChildConnection.Nodes[0].InitializeToDefaultValues(0);
                                break;

                            case "WINDOWS":
                                nodeObj.PhysicalChildConnection.Nodes.Add(new WindowsFileset());
                                nodeObj.PhysicalChildConnection.Nodes[0].InitializeToDefaultValues(0);
                                break;

                            default:
                                throw new Exception(
                                    "The prodived physical host operating " +
                                    "system type could not be determined. Please ensure " +
                                    "that the Rubrik Backup Service is running and " +
                                    "registered with CDM and RSC.");
                        }
                        //PhysicalHost listQuery = new PhysicalHost();

                        string listQueryString = $"query PhysicalHostQuery(" +
                            $"$fid: UUID!, " +
                            $"$first: Int, " +
                            $"$after: String, " +
                            $"$sortBy: HierarchySortByField, " +
                            $"$sortOrder: SortOrder, " +
                            $"$filter: [Filter!]" +
                            $"){{\n" +
                            $"{Query.PhysicalHost(nodeObj)}" +
                            $"\n}}";

                        listQueryString = listQueryString.Replace("physicalChildConnection",
                            $"physicalChildConnection(" +
                            $"typeFilter: [LinuxFileset, WindowsFileset], " +
                            $"first: $first, " +
                            $"after: $after, " +
                            $"sortBy: $sortBy, " +
                            $"sortOrder: $sortOrder, " +
                            $"filter: $filter)");


                        //Initialize the variable set
                        vars = new OperationVariableSet
                        {
                            Variables = new Dictionary<string, object>
                            {
                                {"fid", HostId },
                            }
                        };

                        if (First > 0)
                        {
                            vars.Variables.Add("first", First);
                        }

                        if (!String.IsNullOrEmpty(SortBy))
                        {
                            vars.Variables.Add("sortBy", SortBy.ToUpper());
                        }

                        if (!String.IsNullOrEmpty(SortOrder))
                        {
                            vars.Variables.Add("sortOrder", SortOrder.ToUpper());
                        }

                        if (!String.IsNullOrEmpty(Name))
                        {
                            vars.Variables.Add("filter", new List<Filter>() {
                                new Filter {
                                    Field = HierarchyFilterField.NAME,
                                    Texts = new List<string>
                                    { Name }
                                }
                            });
                        }

                        request.Query = listQueryString;
                        request.OperationName = "PhysicalHostQuery";

                        Task<PhysicalHost> hostListTask =
                            _rbkClient.InvokeGenericCallAsync<PhysicalHost>
                            (request, vars);
                        hostListTask.Wait();

                        // Return the results
                        WriteObject(hostListTask.Result.PhysicalChildConnection.Nodes, true);

                        break;
                    }

                    // ACT ON PARAMETERSET 'Id'
                    // We are returning a single fileset template here based on an ID
                    case "Id":
                    {
                        string queryName = "";
                        string filesetType = this.GetFilesetTypeFromId();
                        PhysicalHost requestFields = new PhysicalHost();
                        requestFields.PhysicalChildConnection =
                            new PhysicalHostPhysicalChildTypeConnection();
                        requestFields.PhysicalChildConnection.Nodes =
                            new RscInterface<PhysicalHostPhysicalChildType>();

                        switch (filesetType)
                        {
                            case "LINUX_FILESET":
                                queryName = "linuxFileset";
                                requestFields.PhysicalChildConnection.Nodes.Add(
                                    new LinuxFileset());
                                requestFields.PhysicalChildConnection
                                    .Nodes[0].InitializeToDefaultValues(0);
                                break;

                            case "WINDOWS_FILESET":
                                queryName = "windowsFileset";
                                requestFields.PhysicalChildConnection.Nodes.Add(
                                    new WindowsFileset());
                                requestFields.PhysicalChildConnection
                                    .Nodes[0].InitializeToDefaultValues(0);
                                break;

                            default:
                                throw new Exception("The prodived physical host operating " +
                                    "system type could not be determined. Please ensure " +
                                    "that the Rubrik Backup Service is running and " +
                                    "registered with CDM and RSC.");
                        }

                        string queryText =
                            $"query FilesetByIdQuery($fid: UUID!){{\n" +
                            $"{queryName}(fid: $fid){{\n" +
                            $"{requestFields.PhysicalChildConnection.Nodes[0].AsFieldSpec(new FieldSpecConfig() { Indent=1 })}\n" +
                            $"}}\n}}";

                        // Initialize the variableset
                        vars = new OperationVariableSet
                        {
                            Variables = new Dictionary<string, object>
                            {
                                { "fid", FilesetId }
                            }
                        };

                        // Set the request
                        request.Query = queryText;
                        request.OperationName = "FilesetByIdQuery";

                        // Make the request
                        switch (filesetType)
                        {
                            case "LINUX_FILESET":
                                Task<LinuxFileset> lnxFsRequest =
                                _rbkClient.InvokeGenericCallAsync<LinuxFileset>
                                (request, vars);
                                lnxFsRequest.Wait();

                                // Return the result
                                WriteObject(lnxFsRequest.Result, false);
                                break;

                            case "WINDOWS_FILESET":
                                Task<WindowsFileset> wndFsRequest =
                                _rbkClient.InvokeGenericCallAsync<WindowsFileset>
                                (request, vars);
                                wndFsRequest.Wait();

                                // Return the result
                                WriteObject(wndFsRequest.Result, false);
                                break;
                        }

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }
    }
}


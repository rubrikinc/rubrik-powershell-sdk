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
    /// Retrieve one or more physical hosts managed by
    /// Rubrik Security Cloud (Rsc).
    /// </summary>
    /// <description>
    /// The Get-RscHost cmdlet is used to get one or more physical hosts
    /// known to RSC. The -Id parameter will return a single host. All other
    /// parameters will return a list of matching hosts.
    /// </description>
    /// <example>
    /// Get a list of all Linux from the RSC instance.
    /// <code>Get-RscHost -OsType Linux </code>
    /// </example>
    /// <example>
    /// Get a list of Windows Hosts, matching a name pattern.
    /// <code>Get-RscHost -OsType Windows -Name myWindowsServer</code>
    /// </example>
    /// <example>
    /// Get a host by Id, with default fields selected.
    /// <code>Get-RscHost -Id 76254be7-baa4-5145-a4b7-a7a7773ad97d</code>
    /// </example>

    [Cmdlet(VerbsCommon.Get, "RscHost", DefaultParameterSetName = "Query")]
    public class Get_RscHost: RscBasePSCmdlet
	{
        /// <summary>
        /// Operating system type of hosts to return. Valid values are
        /// "Windows" and "Linux".
        /// </summary>
        [Parameter(
            Mandatory = true,
            ParameterSetName = "Query",
            Position = 0)]
        [ValidateNotNullOrEmpty]
        [ValidateSet("Linux","Windows")]
        public string OsType { get; set; }

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
        /// Include only items that are relics
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 3)]
        public bool Relics { get; set; } = false;

        /// <summary>
        /// Include only items that are replicated
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 4)]
        public bool Replicated { get; set; } = false;

        /// <summary>
        /// Sort by field name
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 5)]
        [ValidateSet("NAME", "ID", "PHYSICAL_HOST_OS_NAME")]
        public string SortBy { get; set; }

        /// <summary>
        /// Sort Order
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 6)]
        [ValidateSet("ASC", "DESC")]
        public string SortOrder { get; set; }


        /// <summary>
        /// Get a physical host using its ID
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Id",
            Position = 0)]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }


        /// <summary>
        /// Activate selected fields based on not-null properties
        /// of the input fields object
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0)]
        public PhysicalHost Field { get; set; }

    #pragma warning disable 1591 // ignore warning 'Missing XML comment'

        public Get_RscHost(): base(retrieveConnection: true)
        {
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                // Create a new GQL Request Object
                GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest();

                // Define a new variableset container, uninitialized.
                OperationVariableSet vars;
                PhysicalHost nodeObj;

                if (Field != null)
                {
                    nodeObj = Field;
                }
                else
                {
                    nodeObj = new PhysicalHost();
                    // Initialize a fields object for all queries
                    nodeObj.InitializeToDefaultValues(0);
                    nodeObj.IpAddresses = new List<string>();

                    nodeObj.Cluster = new Cluster
                    {
                        Name = "FETCH",
                        Id = "FETCH",
                        DefaultAddress = "FETCH"
                    };
                }

                switch (ParameterSetName)
                {
                    //We are returning a list of hosts here based on a query
                    case "Query":
                    {
                        var hostListQuery = new PhysicalHostConnection();

                        hostListQuery.Nodes = new List<PhysicalHost>();
                        hostListQuery.Nodes.Add(nodeObj);

                        string listQueryString = $"query PhysicalHostListQuery(" +
                            $"$hostRoot: HostRoot!, " +
                            $"$first: Int, " +
                            $"$after: String, " +
                            $"$sortBy: HierarchySortByField, " +
                            $"$sortOrder: SortOrder, " +
                            $"$filter: [Filter!]" +
                            $"){{\n" +
                            $"{Query.PhysicalHosts(hostListQuery)}" +
                            $"\n}}";

                        string hostRoot = $"{OsType.ToUpper()}_HOST_ROOT";

                        //Initialize the variable set
                        var filters = new List<Filter>();
                        vars = new OperationVariableSet
                        {
                            Variables = new Dictionary<string, object>
                            {
                                {"hostRoot", hostRoot },
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
                            filters.Add(new Filter
                            {
                                Field = HierarchyFilterField.NAME,
                                Texts = new List<string>
                                {
                                    Name
                                }
                            });
                        }

                        filters.Add(new Filter
                        {
                            Field = HierarchyFilterField.IS_RELIC,
                            Texts = new List<string>
                            {
                                Relics.ToString()
                            }
                        });

                        filters.Add(new Filter
                        {
                            Field = HierarchyFilterField.IS_REPLICATED,
                            Texts = new List<string>
                            {
                                Replicated.ToString()
                            }
                        });

                        request.Query = listQueryString;
                        request.OperationName = "PhysicalHostListQuery";
                        vars.Variables.Add("filter", filters);
                        Task<PhysicalHostConnection> hostListTask =
                            _rbkClient.InvokeGenericCallAsync<PhysicalHostConnection>
                            (request, vars);
                        hostListTask.Wait();

                        // Return the results
                        WriteObject(hostListTask.Result.Nodes, true);

                        break;
                    }

                    // We are returning a single host here based on an ID
                    case "Id":
                    {
                        string hostQueryText = $"query PhysicalHostById(" +
                            $"$fid: UUID!)" +
                            $"{{\n" +
                            $"{Query.PhysicalHost(nodeObj)}" +
                            $"\n}}";

                        // Initialize the variableset
                        vars = new OperationVariableSet
                        {
                            Variables = new Dictionary<string, object>
                            {
                                { "fid", Id }
                            }
                        };

                        // Set the request
                        request.Query = hostQueryText;
                        request.OperationName = "PhysicalHostById";

                        // Make the requesy
                        Task<PhysicalHost> hostRequest =
                            _rbkClient.InvokeGenericCallAsync<PhysicalHost>
                            (request, vars);
                        hostRequest.Wait();

                        // Return the result
                        WriteObject(hostRequest.Result, false);
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


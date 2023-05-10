using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.PowerShell.Private;
using Rubrik.SecurityCloud.Types;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Retrieve one or more filset templates managed by
    /// Rubrik Security Cloud (Rsc).
    /// </summary>
    /// <description>
    /// The Get-RscFileset cmdlet is used to get one or more fileset templates
    /// known to RSC. The -Id parameter will return a template. All other
    /// parameters will return a list of matching templates.
    /// Returns Windows and Linux fileset templates.
    /// </description>
    /// <example>
    /// Get a list of all Linux fileset templates.
    /// <code>Get-RscFilesetTemplate -OsType Linux </code>
    /// </example>
    /// <example>
    /// Get a list of Windows fileset templates, matching a name pattern.
    /// <code>Get-RscFilesetTemplate -OsType Windows -Name myWinTemplate</code>
    /// </example>
    /// <example>
    /// Get a template by Id, with default fields selected.
    /// <code>Get-RscFilesetTemplate -Id 76254be7-baa4-5145-a4b7-a7a7773ad97d</code>
    /// </example>

    [Cmdlet(VerbsCommon.Get, "RscFilesetTemplate",
        DefaultParameterSetName = "Query")]
    public class Get_RscFilesetTemplate: RscPSCmdlet
	{
        /// <summary>
        /// Operating system type of fileset templates to return.
        /// Valid values are: "Windows" and "Linux".
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
        /// Sort by field name
        /// </summary>
        [Parameter(
            Mandatory = false,
            ParameterSetName = "Query",
            Position = 3)]
        [ValidateSet("NAME", "ID", "PHYSICAL_HOST_OS_NAME")]
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
        public new FilesetTemplate Field { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                // Create a new GQL Request Object
                GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest();

                // Define a new variableset container, uninitialized.
                OperationVariableSet vars;
                FilesetTemplate nodeObj;

                if (Field != null)
                {
                    nodeObj = Field;
                }
                else
                {
                    nodeObj = new FilesetTemplate();

                    // Initialize a fields object for all queries
                    nodeObj.InitializeToDefaultValues(0);
                    nodeObj.Cluster = new Cluster
                    {
                        Name = "FETCH",
                        Id = "FETCH",
                        DefaultAddress = "FETCH"
                    };
                }

                switch (ParameterSetName)
                {
                    //We are returning a list of templates here based on a query
                    case "Query":
                        FilesetTemplateConnection listQuery = new FilesetTemplateConnection();

                        listQuery.Nodes = new List<FilesetTemplate>();
                        listQuery.Nodes.Add(nodeObj);

                        string listQueryString = $"query FilesetTemplateListQuery(" +
                            $"$hostRoot: HostRoot!, " +
                            $"$first: Int, " +
                            $"$after: String, " +
                            $"$sortBy: HierarchySortByField, " +
                            $"$sortOrder: SortOrder, " +
                            $"$filter: [Filter!]" +
                            $"){{\n" +
                            $"{Query.FilesetTemplates(ref listQuery)}" +
                            $"\n}}";

                        string hostRoot = $"{OsType.ToUpper()}_HOST_ROOT";

                        //Initialize the variable set
                        vars = new OperationVariableSet
                        {
                            Filters = new List<Filter>(),
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
                            vars.Filters.Add(new Filter
                            {
                                Field = HierarchyFilterField.NAME,
                                Texts = new List<string>
                                {
                                    Name
                                }
                            });
                        }

                        request.Query = listQueryString;
                        request.OperationName = "FilesetTemplateListQuery";

                        Task<FilesetTemplateConnection> hostListTask =
                            _rbkClient.InvokeGenericCallAsync<FilesetTemplateConnection>
                            (request, vars);
                        hostListTask.Wait();

                        // Return the results
                        WriteObject(hostListTask.Result.Nodes, true);

                        break;

                    // We are returning a single fileset template here based on an ID
                    case "Id":
                        string hostQueryText = $"query FilesetTemplateById(" +
                            $"$fid: UUID!)" +
                            $"{{\n" +
                            $"{Query.FilesetTemplate(ref nodeObj)}" +
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
                        request.OperationName = "FilesetTemplateById";

                        // Make the requesy
                        Task<FilesetTemplate> hostRequest =
                            _rbkClient.InvokeGenericCallAsync<FilesetTemplate>
                            (request, vars);
                        hostRequest.Wait();

                        // Return the result
                        WriteObject(hostRequest.Result, false);
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


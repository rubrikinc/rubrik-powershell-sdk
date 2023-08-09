using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;
using RubrikSecurityCloud.PowerShell.Models;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Retrieve one or more Mssql Databases managed by
    /// Rubrik Security Cloud (Rsc).
    /// </summary>
    /// <description>
    /// The Get-RscMssqlDatabase cmdlet is used to get one or more Mssql DBs
    /// known to RSC. The -Id parameter will return a single DB. All other
    /// parameters will return a list of matching DBs.
    /// </description>
    /// <example>
    /// Get a list of all Mssql DBs from the RSC instance.
    /// <code>Get-RscMssqlDatabase</code>
    /// </example>
    /// <example>
    /// Get a list of Mssql DBs, matching a name pattern.
    /// <code>Get-RscMssqlDatabase -Name devVM</code>
    /// </example>
    /// <example>
    /// Get a Mssql DB by Id, with default fields selected.
    /// <code>Get-RscMssqlDatabase -Id 76254be7-baa4-5145-a4b7-a7a7773ad97d</code>
    /// </example>
    /// <example>
    /// Get a Mssql DB by Id, with custom fields selected (Id, Name)
    /// <code>
    /// $myFields = Get-RscType -Name MssqlDatabase -InitialFields @("Id","Name")
    /// Get-RscMssqlDatabase -Id 76254be7-baa4-5145-a4b7-a7a7773ad97d -Fields $myFields
    /// </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "RscMssqlDatabase",
        DefaultParameterSetName = "Query")]
    public class Get_RscMssqlDatabase : RscPSCmdlet
    {
        /// <summary>
        /// Filter Mssql Databases by name
        /// </summary>
        [Parameter(
            Position = 0,
            ParameterSetName = "Query")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// Retrieve a single Mssql Database by Id
        /// </summary>
        [Parameter(
            Position = 1,
            ParameterSetName = "Id")]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }

        /// <summary>
        /// An object to use as a field selector for the query.
        /// Values from the API for fields set to not-null values in this object
        /// will be returned.
        /// </summary>
        [Parameter(Mandatory = false)]
        public MssqlDatabase Fields { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                MssqlDatabaseConnection listFields;

                GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest();

                if (Fields != null)
                {
                    listFields = new MssqlDatabaseConnection
                    {
                        Nodes = new List<MssqlDatabase>()
                    };
                    listFields.Nodes.Add(Fields);
                }
                else
                {
                    listFields = new MssqlDatabaseConnection();
                    listFields.Nodes = new List<MssqlDatabase>();
                    MssqlDatabase fieldsObject = new MssqlDatabase();
                    fieldsObject.ApplyExploratoryFieldSpec();
                    listFields.Nodes.Add(fieldsObject);
                }

                switch (ParameterSetName)
                {
                    case "Query":
                    {
                        string operationString =
                            $"query MssqlDatabaseListQuery(" +
                            $"$first: Int, " +
                            $"$after: String, " +
                            $"$sortBy: HierarchySortByField, " +
                            $"$sortOrder: SortOrder, " +
                            $"$filter: [Filter!]" +
                            $"){{\n" +
                            $"{Query.MssqlDatabases(ref listFields)}" +
                            $"\n}}";

                        if (string.IsNullOrEmpty(Name))
                        {
                            request.OperationName = "MssqlDatabaseListQuery";
                            request.Query = operationString;

                            Task<MssqlDatabaseConnection> getListTask =
                                _rbkClient.
                                InvokeGenericCallAsync<MssqlDatabaseConnection>
                                (request);

                            getListTask.Wait();
                            WriteObject(getListTask.Result.Nodes, true);
                        }
                        else
                        {
                            var f = new Filter
                            {
                                Field = HierarchyFilterField.NAME,
                                Texts = new List<string>
                                { Name }
                            };
                            var variables = new OperationVariableSet
                            {
                                Variables = new Dictionary<string, object> {
                                    {"filter", new List<Filter>(){ f } }
                                }
                            };

                            request.OperationName = "MssqlDatabaseListQuery";
                            request.Query = operationString;

                            Task<MssqlDatabaseConnection> nameFilterListTask =
                                _rbkClient.
                                InvokeGenericCallAsync<MssqlDatabaseConnection>
                                (request, variables);
                            nameFilterListTask.Wait();
                            WriteObject(nameFilterListTask.Result.Nodes, true);
                        }

                        break;
                    }
                    case "Id":
                    {
                        OperationVariableSet vars = new() {
                            Variables = new Dictionary<string, object>() {
                                {"fid", Id }
                            }
                        };
                        MssqlDatabase detailFields = null;
                        if (Fields == null)
                        {
                            detailFields = new MssqlDatabase();
                            detailFields.ApplyExploratoryFieldSpec();
                        }
                        else
                        {
                            detailFields = Fields;
                        }

                        string operationByIdString =
                            $"query MssqlDatabaseByIdQuery(" +
                            $"$fid: UUID!, " +
                            $"){{\n" +
                            $"{Query.MssqlDatabase(ref detailFields)}" +
                            $"\n}}";

                        request.OperationName = "MssqlDatabaseByIdQuery";
                        request.Query = operationByIdString;
                        Task<MssqlDatabase> getDetailTask =
                            _rbkClient.InvokeGenericCallAsync<MssqlDatabase>(
                                request, vars);
                        getDetailTask.Wait();
                        WriteObject(getDetailTask.Result, false);

                        break;
                    }
                    default:

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

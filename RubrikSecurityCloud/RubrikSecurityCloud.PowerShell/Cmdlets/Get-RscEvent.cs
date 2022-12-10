using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{

    [Cmdlet(VerbsCommon.Get, "RscEvent", DefaultParameterSetName = "Query")]
    [OutputType("ActivitySeriesConnection", ParameterSetName = new string[] { "Query" })]
    public class Get_RscEvent : RscPSCmdlet
    {
        // After
        [Parameter(Position = 0, ParameterSetName = "Query", Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string After { get; set; }

        // Filters
        [Parameter(Position = 1, ParameterSetName = "Query", Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public ActivitySeriesFilter Filters { get; set; }

        // First
        [Parameter(Position = 2, ParameterSetName = "Query", Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int? First { get; set; }

        // Sort by
        [Parameter(Position = 3, ParameterSetName = "Query", Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public ActivitySeriesSortField? SortBy { get; set; }

        // Sort order
        [Parameter(Position = 4, ParameterSetName = "Query", Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public SortOrder? SortOrder { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch (ParameterSetName)
                {

                    case "Query":
                        OperationVariableSet vars = new OperationVariableSet();
                        string filtersStr = Filters != null ? JsonConvert.SerializeObject(Filters) : null;
                        vars.Variables = new Dictionary<string, object>()
                        {
                            {"after", After?.ToString() ?? null},
                            {"filters", filtersStr},
                            {"first", First},
                            {"sortBy", SortBy?.ToString() ?? null},
                            {"sortOrder", SortOrder?.ToString() ?? null}
                        };
                        Task<ActivitySeriesConnection> getEventTask =
                        this._rbkClient.InvokeGenericCallAsync<ActivitySeriesConnection>(
                            ActivitySeriesConnectionQuery.Request(),
                            vars
                        );
                        getEventTask.Wait();
                        WriteObject(getEventTask.Result, true);
                        break;

                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                var error = new ErrorRecord(
                    ex,
                    "Get-RscEvent",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
            }
        }
    }
}

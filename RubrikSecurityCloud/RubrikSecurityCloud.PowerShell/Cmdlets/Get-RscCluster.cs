using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.Operations;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        VerbsCommon.Get,
        "RscClusterOLD",
        DefaultParameterSetName = "State")]
    public class Get_RscClusterOLD : RscPSCmdlet
    {
        // ----------------------------------------------------------
        // -  Parameter Set "State"
        [Parameter(
            ParameterSetName = "State",
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = false)]
        public SwitchParameter State { get; set; }

        // ----------------------------------------------------------
        // -  Parameter Set "Location"
        [Parameter(
            ParameterSetName = "Location",
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = false)]
        public SwitchParameter Location { get; set; }

        // ----------------------------------------------------------
        // -  Parameter Set "Detail"
        [Parameter(
            ParameterSetName = "Detail",
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = false)]
        public SwitchParameter Detail { get; set; }

        // ----------------------------------------------------------
        // -  Parameter Set "Id"
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }

        // ----------------------------------------------------------
        // -  Parameter Set "Name"
        [Parameter(
            ParameterSetName = "Name",
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        // ----------------------------------------------------------
        protected override void ProcessRecord()
        {
            try
            {
                switch (this.ParameterSetName)
                {
                    case "State":
                        GetClusterState();
                        break;
                    case "Location":
                        GetClusterLocation();
                        break;
                    case "Detail":
                        GetClusterDetail();
                        break;
                    case "Id":
                        GetClusterById();
                        break;
                    case "Name":
                        GetClusterByName();
                        break;
                    default:
                        throw new Exception("Invalid Parameter Set");
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorRecord(
                    ex,
                    "Get-RscCluster",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
            }
        }

        // ----------------------------------------------------------
        private void GetClusterState()
        {
            Task<List<Cluster>> gqlCall =
                this._rbkClient.InvokeGenericCallAsync<List<Cluster>>(
                ClusterStateQuery.Request());
            gqlCall.Wait();
            WriteObject(gqlCall.Result, false);
        }

        // ----------------------------------------------------------
        private void GetClusterLocation()
        {
            Task<List<Cluster>> gqlCall =
                this._rbkClient.InvokeGenericCallAsync<List<Cluster>>(
                ClusterLocationQuery.Request());
            gqlCall.Wait();
            WriteObject(gqlCall.Result, false);
        }

        // ----------------------------------------------------------
        private void GetClusterDetail()
        {
            Task<List<Cluster>> gqlCall =
                this._rbkClient.InvokeGenericCallAsync<List<Cluster>>(
                ClusterQuery.Request());
            gqlCall.Wait();
            WriteObject(gqlCall.Result, false);
        }

        // ----------------------------------------------------------
        private void GetClusterById()
        {
            OperationVariableSet vars = new OperationVariableSet();
            vars.Variables = new Dictionary<string, object>()
            {
                { "id", this.Id }
            };
            Task<Cluster> gqlCall =
                this._rbkClient.InvokeGenericCallAsync<Cluster>(
                ClusterQuery.Request(), vars);
            gqlCall.Wait();
            WriteObject(gqlCall.Result, false);
        }

        // ----------------------------------------------------------
        private void GetClusterByName()
        {
            OperationVariableSet vars = new OperationVariableSet();
            vars.Variables = new Dictionary<string, object>()
            {
                { "clusterNames", this.Name }
            };
            Task<Cluster> gqlCall =
                this._rbkClient.InvokeGenericCallAsync<Cluster>(
                ClusterQuery.Request(), vars);
            gqlCall.Wait();
            WriteObject(gqlCall.Result, false);
        }

    }
}

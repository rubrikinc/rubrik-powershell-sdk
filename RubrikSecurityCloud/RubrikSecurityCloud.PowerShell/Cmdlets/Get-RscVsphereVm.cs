using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using RubrikSecurityCloud.PowerShell.Private;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{

    /// <summary>
    /// Retrieve one or more vSphere Virtual Machines (VMs) managed by
    /// Rubrik Security Cloud (Rsc).
    /// </summary>
    /// <description>
    /// The Get-RscVsphereVm cmdlet is used to get one or more vSphere VMs
    /// known to RSC. The -Id parameter will return a single VM. All other
    /// parameters will return a list of matching VMs.
    /// </description>
    /// <example>
    /// Get a list of all vSphere VMs from the RSC instance.
    /// <code>Get-RscVsphereVm</code>
    /// </example>
    /// <example>
    /// Get a list of vSphere VMs, matching a name pattern.
    /// <code>Get-RscVsphereVm -Name devVM</code>
    /// </example>
    /// <example>
    /// Get a vSphere VM by Id, with default fields selected.
    /// <code>Get-RscVsphereVm -Id 76254be7-baa4-5145-a4b7-a7a7773ad97d</code>
    /// </example>
    /// <example>
    /// Get a vSphere VM by Id, with custom fields selected (Id, Name, and
    /// GuestOsType).
    /// <code>
    /// $myFields = Get-RscType -Name VSphereVm
    /// $myFields.Id = "FETCH"
    /// $myFields.Name = "FETCH"
    /// $myFields.GuestOsType = "FETCH"
    /// Get-RscVsphereVm -Id 76254be7-baa4-5145-a4b7-a7a7773ad97d -Fields $myFields
    /// </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "RscVsphereVm", DefaultParameterSetName = "Query")] //Get-RscVsphereVm
    [OutputType("List<VsphereVm>", ParameterSetName = new string[] { "Query" })]
    [OutputType("VsphereVm", ParameterSetName = new string[] { "ID" })]
    public class Get_RscVsphereVm : RscPSCmdlet
    {
        /// <summary>
        /// Filter VMs by Name
        /// </summary>
        [Parameter(ParameterSetName = "Query", ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        [Alias("VM")]
        public string Name { get; set; }

        // SLA Domain policy assigned to the virtual machine - This can only be
        // implemented once the Get-RscSlaDomain cmdlet works.
        //[Parameter(ParameterSetName = "Query")]
        //[ValidateNotNullOrEmpty()]
        //public string SLA { get; set; }

        /// <summary>
        /// Retrieve a single known VM by Id
        /// </summary>
        [Parameter(Position = 0, ParameterSetName = "ID", Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }

        /// <summary>
        /// An object to use as a field selector for the query.
        /// Values from the API for fields set to not-null values in this object
        /// will be returned. To be used only with -Id parameter.
        /// </summary>
        [Parameter(Mandatory = false)]
        public VsphereVm Fields { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                //VsphereVmConnection listFields = new VsphereVmConnection
                //{
                //    Nodes = new List<VsphereVm>
                //                {
                //                    new VsphereVm
                //                    {
                //                        Id = "FETCH",
                //                        Name = "FETCH",
                //                        GuestOsName = "FETCH",
                //                        GuestOsType = GuestOsType.UNKNOWN,
                //                        ProtectionDate = new DateTime(),
                //                        Cluster = new Cluster
                //                        {
                //                            Id = "FETCH",
                //                            Name = "FETCH"
                //                        }
                //                    }
                //                }
                //};

                VsphereVmConnection listFields;

                if (Fields != null)
                {
                    listFields = new VsphereVmConnection
                    {
                        Nodes = new List<VsphereVm>()
                    };
                    listFields.Nodes.Add(Fields);
                }
                else
                {
                    listFields = (VsphereVmConnection)RscTypeInitializer
                                .InitializeTypeWithSelectedProperties(
                                "VsphereVmConnection", new String[]
                                {
                                    "Nodes.VsphereVm.Id",
                                    "Nodes.VsphereVm.Name",
                                    "Nodes.VsphereVm.GuestOsName",
                                    "Nodes.VsphereVm.GuestOsType",
                                    "Nodes.VsphereVm.ProtectionDate",
                                    "Nodes.VsphereVm.Cluster.Id",
                                    "Nodes.VsphereVm.Cluster.Name"
                                });
                }

                switch (ParameterSetName)
                    {

                        case "Query":

                            if (String.IsNullOrEmpty(Name)) //&& String.IsNullOrEmpty(SLA))
                            {
                                string operationString =
                                    $"query VsphereListQuery\n{{ " +
                                    $"vSphereVmNewConnection\n{{"+
                                    $"{listFields.AsFragment()}}}}}";

                                Task<List<VsphereVm>> getListTask =
                                    _rbkClient.InvokeGenericCallAsync<List<VsphereVm>>(operationString);
                                getListTask.Wait();
                                WriteObject(getListTask.Result, true);
                            }
                            else
                            {
                                if (!String.IsNullOrEmpty(Name))
                                {
                                    string operationByNameString =
                                        $"query VsphereListQuery($filter: [Filter!]){{ " +
                                        $"vSphereVmNewConnection\n{{" +
                                        $"{listFields.AsFragment()}}}}}";

                                    operationByNameString = operationByNameString.Replace(
                                        "vSphereVmNewConnection",
                                        "vSphereVmNewConnection(filter: $filter)");

                                    OperationVariableSet variables = new OperationVariableSet
                                    {
                                        Filters = new List<Filter>
                                    {
                                        new Filter
                                        {
                                            Field = HierarchyFilterField.NAME,
                                            Texts = new List<string>
                                            {
                                                Name
                                            }
                                        }
                                    }
                                    };

                                    Task<List<VsphereVm>> nameFilterListTask =
                                         _rbkClient.InvokeGenericCallAsync<List<VsphereVm>>(operationByNameString, variables);
                                    nameFilterListTask.Wait();
                                    WriteObject(nameFilterListTask.Result, true);
                                }
                                //else if (!string.IsNullOrEmpty(SLA))
                                //{
                                //    throw new NotImplementedException();
                                //}
                            }

                            break;

                        case "ID":

                            OperationVariableSet vars = new OperationVariableSet();
                            vars.Variables = new Dictionary<string, object>()
                        {
                            { "fid",Id }
                        };


                            VsphereVm detailFields = null;

                            if (Fields == null)
                            {

                                detailFields = new VsphereVm();
                                detailFields.ApplyExploratoryFragment();
                                detailFields.Cluster = new Cluster
                                {
                                    Id = "FETCH",
                                    Name = "FETCH"
                                };
                            }
                            else
                            {
                                bool allNull = RscCmdletHelper.CheckAllPropertiesAreNull(Fields);
                                if (allNull)
                                {
                                    throw new Exception("At least one property of the object" +
                                        " passed to the -Fields parameter must be not null");

                                }
                                else
                                {
                                    detailFields = Fields;
                                }
                            }


                            string operationByIdString =
                                        $"query VsphereVmDetailQuery($fid: UUID!){{ " +
                                        $"{Query.VsphereVmNew(ref detailFields)}" +
                                        $"}}";

                            //operationByIdString = operationByIdString.Replace(
                            //    "vSphereVmNew",
                            //    "vSphereVmNew(fid: $id)");

                            Task<VsphereVm> getDetailTask =
                                _rbkClient.InvokeGenericCallAsync<VsphereVm>(
                                    operationByIdString, vars);
                            getDetailTask.Wait();

                            WriteObject(getDetailTask.Result, false);

                            break;

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

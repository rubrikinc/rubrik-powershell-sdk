using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Models;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.Operations;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "RscMssqlDatabase")]
    public class RscMssqlDatabase : RscPSCmdlet
    {
        [Parameter(Position = 1)]
        public string Id { get; set; }

        [Parameter]
        public bool Detailed { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (!String.IsNullOrEmpty(Id))
                {
                    Task<MssqlDatabase> myTask =
                        _rbkClient.InvokeGenericCallAsync<MssqlDatabase>(
                        MssqlDatabasesQuery.Request());
                    Task.WaitAll(myTask);
                    WriteObject(myTask.Result, true);
                }
                else
                {
                    Task<List<MssqlDatabase>> myTask =
                        _rbkClient.InvokeGenericCallAsync<List<MssqlDatabase>>(
                        MssqlDatabasesQuery.Request());
                    Task.WaitAll(myTask);
                    WriteObject(myTask.Result, true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

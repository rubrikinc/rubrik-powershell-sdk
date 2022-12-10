using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.Operations;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet("Export", "RscMssqlDatabase")]
    public class ExportRscMssqlDatabase : RscPSCmdlet
    {
        //Recovery Point desired in the form of DateTime value
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Id;
        public int MaxDataStreams;
        [Parameter(ParameterSetName = "Recovery_timestamp")]
        public long TimestampMs;

        //Recovery Point desired in the form of DateTime value
        [Parameter(ParameterSetName = "Recovery_DateTime")]
        public DateTime RecoveryDateTime;

        //Recovery Point desired in the form of an LSN (Log Sequence Number)
        [Parameter(ParameterSetName = "Recovery_LSN")]
        public string RecoveryLSN;

        //Take database out of recovery mode after export
        public bool FinishRecovery;

        //Rubrik identifier of MSSQL instance to export to
        public string TargetInstanceId;

        //Name to give database upon export
        public string TargetDatabaseName;

        public bool Overwrite;

        //Simple Mode - Data File Path 
        [Alias("DataFilePath")]
        public string TargetDataFilePath;

        //#Simple Mode - Data File Path
        [Alias("LogFilePath")]
        public string TargetLogFilePath;

        //Advanced Mode - Array of hash tables for file reloaction.
        public PSCustomObject[] TargetFilePaths;

        protected override void ProcessRecord()
        {
            try
            {
                Task<List<MssqlDatabase>> myTask =
                    _rbkClient.InvokeGenericCallAsync<List<MssqlDatabase>>(
                        MssqlDatabasesQuery.Request());
                Task.WaitAll(myTask);
                WriteObject(myTask.Result, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

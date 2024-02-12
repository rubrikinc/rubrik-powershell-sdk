using System;
using System.Management.Automation;
using System.Threading.Tasks;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(VerbsCommunications.Disconnect, "Rsc")]
    public class Disconnect_Rsc : RscBasePSCmdlet
    {
        public Disconnect_Rsc() : base(retrieveConnection: true)
        {
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                Task delSessionTask = this._rbkClient.Disconnect();
                delSessionTask.Wait();

                SessionState.PSVariable.Remove(Config.SessionVariableName);
                if (SessionState.PSVariable.GetValue(Config.SessionVariableName) == null)
                {
                    WriteObject("The Rubrik Security Cloud session has been terminated.");
                }
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }
    }
}

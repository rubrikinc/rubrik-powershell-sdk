using System;
using System.Management.Automation;
using System.Threading.Tasks;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(VerbsCommunications.Disconnect, "Rsc")]
    public class Disconnect_Rsc : RscBasePSCmdlet
    {

#pragma warning disable 1591 // ignore warning 'Missing XML comment'

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

                SessionState.PSVariable.Remove("RscConnectionClient");
                if (SessionState.PSVariable.GetValue("RscConnectionClient") == null)
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

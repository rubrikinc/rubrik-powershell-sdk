using System;
using System.Management.Automation;
using System.Threading.Tasks;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(VerbsCommunications.Disconnect, "Rsc")]
    public class Disconnect_Rsc : RscPSCmdlet
    {
        protected override void ProcessRecord()
        {
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
            catch(Exception ex)
            {
                var error = new ErrorRecord(
                ex,
                "AuthenticationError",
                ErrorCategory.AuthenticationError,
                null);
                ThrowTerminatingError(error);
            }
        }
    }
}

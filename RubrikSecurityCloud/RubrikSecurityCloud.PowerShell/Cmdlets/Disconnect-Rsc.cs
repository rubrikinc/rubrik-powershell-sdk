using System;
using System.Management.Automation;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(VerbsCommunications.Disconnect, "Rsc")]
    public class Disconnect_Rsc : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            SessionState.PSVariable.Remove("RscConnectionClient");
            if (SessionState.PSVariable.GetValue("RscConnectionClient") == null)
            {
                WriteObject("The Rubrik Security Cloud session has been terminated.");
            }
        }
    }
}

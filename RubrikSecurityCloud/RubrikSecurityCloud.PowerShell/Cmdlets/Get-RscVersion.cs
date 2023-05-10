using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rubrik.SecurityCloud.PowerShell.Private;
using Rubrik.SecurityCloud.Types;
using RubrikSecurityCloud.PowerShell.Models;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Returns the Rubrik Security Cloud Server version, as well a the
    /// Rubrik Security Cloud PowerShell SDK schema version. Ideally these
    /// values should match for maximum SDK compatibility. 
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "RscVersion")]
    public class Get_RscVersion: RscPSCmdlet
    {
        protected override void ProcessRecord()
        {
            try
            {
                RscSessionInfo sessionInfo =
                    new RscSessionInfo(_rbkClient, _logger);
                WriteObject(sessionInfo.GetRscPsVersion(), false);
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


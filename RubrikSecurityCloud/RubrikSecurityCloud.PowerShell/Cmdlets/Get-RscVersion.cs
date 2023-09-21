using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
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
    public class Get_RscVersion : RscBasePSCmdlet
    {

#pragma warning disable 1591 // ignore warning 'Missing XML comment'

        public Get_RscVersion(): base(retrieveConnection: true)
        {
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            try
            {
                RscSessionInfo sessionInfo =
                    new RscSessionInfo(_rbkClient, _logger);
                WriteObject(sessionInfo.GetRscPsVersion(), false);
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }
    }
}


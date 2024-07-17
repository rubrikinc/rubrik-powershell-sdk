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
        private bool _doDisconnect = true;
        public Disconnect_Rsc() : base(retrieveConnection: false)
        {
        }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            if(!this.RetrieveConnection(throwIfNotRetrieved:false))
            {
                this._doDisconnect=false;
                WriteObject("No connection to disconnect from.");
            }
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            if(!_doDisconnect)
            {
                return;
            }
            try
            {
                Task delSessionTask = this._rbkClient.Disconnect();
                delSessionTask.Wait();

                SessionState.PSVariable.Remove(Config.SessionVariableName);
                if (SessionState.PSVariable.GetValue(Config.SessionVariableName) == null)
                {
                    WriteObject("The Rubrik Security Cloud session has been terminated.");
                }
                else
                {
                    WriteObject("Could not remove the Rubrik Security Cloud session variable. Please remove it manually.");
                }
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }
    }
}

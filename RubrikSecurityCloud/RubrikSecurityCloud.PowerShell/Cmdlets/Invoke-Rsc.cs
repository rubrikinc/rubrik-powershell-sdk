using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.Operations;
using Rubrik.SecurityCloud.PowerShell.Private;
using Rubrik.SecurityCloud.Types;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{



    [Cmdlet(
        VerbsLifecycle.Invoke,
        "Rsc")]
    public class Invoke_Rsc : RscPSCmdlet
    {
        // - Parameter Set "NativeGQL"
        // This paramset is used when the user writes their own GQL queries
        [Parameter(
            ParameterSetName = "NativeGQL",
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true)]
        public string OperationText { get; set; }

        // ----------------------------------------------------------
        // -  Parameter Set "NativePowerShell"
        // This paramset is used when using types to generate queries
        [Parameter(
            ParameterSetName = "NativePowerShell",
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public string OutputType { get; set; }

        [Parameter(
            ParameterSetName = "NativePowerShell",
            Position = 1,
            Mandatory = true)]
        public string Body { get; set; }


        protected override void ProcessRecord()
        {
            switch (ParameterSetName)
            {
                case "NativeGQL":
                    try
                    {
                        Task<Object> myTask = _rbkClient.InvokeGenericCall(OperationText);
                        myTask.Wait();
                        string jsonResult = JsonConvert.SerializeObject(myTask.Result);
                        string script = "ConvertFrom-Json -InputObject '" + jsonResult + "'";
                        var myObject = this.InvokeCommand.InvokeScript(script);
                        WriteObject(myObject);
                    }
                    catch (Exception ex)
                    {
                        WriteError(new ErrorRecord(ex, "ClientError", ErrorCategory.OperationStopped, this));
                    }
                    break;

                case "NativePowerShell":

                    Console.WriteLine(OutputType);
                    Type t = Invoke_Rsc.GetType(OutputType);
                    MethodInfo method = typeof(RscGraphQLClient).GetMethod("InvokeGenericCallAsync");
                    MethodInfo genericMethod = method.MakeGenericMethod(t);
                    object[] parameters = new object[] { AccountSettingQuery.Request(), null };
                    var taskResult = genericMethod.Invoke(_rbkClient, parameters);
                    var result = ((dynamic)taskResult).GetAwaiter().GetResult();
                    WriteObject(result);

                    break;
                    //try
                    //{
                    //    Task<t> myTask =
                    //        _rbkClient.InvokeGenericCallAsync<t>(
                    //            AccountSettingQuery.Request());
                    //    myTask.Wait();
                    //    WriteObject(myTask.Result, true);
                    //}
                    //catch (Exception ex)
                    //{
                    //    WriteError(new ErrorRecord(ex, "ClientError", ErrorCategory.OperationStopped, this));

                    //}
            }
        }
        public static Type GetType(string typeName)
        {
            var type = Type.GetType(typeName);
            if (type != null)
                return type;
            type = Type.GetType("Rubrik.SecurityCloud.Operations." + typeName + ", RubrikSecurityCloud.Schema");
            if (type != null)
                return type;
            type = Type.GetType("Rubrik.SecurityCloud.Types." + typeName + ", RubrikSecurityCloud.Schema");
            if (type != null)
                return type;
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in assemblies)
            {
                type = a.GetType(typeName);
                if (type != null)
                    return type;
            }
            return null;
        }
    }
}

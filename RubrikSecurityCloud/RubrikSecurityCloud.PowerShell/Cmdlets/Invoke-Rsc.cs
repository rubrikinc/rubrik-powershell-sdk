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
using Rubrik.SecurityCloud.PowerShell.Private;
using Rubrik.SecurityCloud.Types;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Send a custom GraphQL query to the Rubrik Security Cloud (RSC) API.
    /// </summary>
    /// <description>
    /// The passed query is sent to the Rubrik Security Cloud API,
    /// and the result is returned to the user.
    /// </description>
    /// <example>
    /// Read GraphQL query from JSON file.
    /// <code>
    /// Get-Content -Path /Samples/GetVsphereVmList.query.json -Raw | Invoke-Rsc
    /// </code>
    /// </example>
    /// <example>
    /// Read GraphQL query from parameter.
    /// <code>
    /// Invoke-Rsc '{"query":"query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}"}'
    /// </code>
    /// </example>
    [Cmdlet(VerbsLifecycle.Invoke, "Rsc", DefaultParameterSetName = "NativeGQL")]
    public class Invoke_Rsc : RscPSCmdlet
    {
        // ----------------------------------------------------------
        // - Parameter Set "NativeGQL"
        // This paramset is used when the user writes their own GQL queries
        /// <summary>
        /// The GQL query to send to the Rubrik Security Cloud API.
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeGQL",
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true
        )]
        public string OperationText { get; set; }

        // ----------------------------------------------------------
        // -  Parameter Set "NativePowerShell"
        // This paramset is used when using types to generate queries
        // [Parameter(
        //     ParameterSetName = "NativePowerShell",
        //     Mandatory = false,
        //     Position = 0,
        //     ValueFromPipeline = true)]
        // [ValidateNotNullOrEmpty]
        // public string OutputType { get; set; }

        // [Parameter(
        //     ParameterSetName = "NativePowerShell",
        //     Position = 1,
        //     Mandatory = true)]
        // public string Body { get; set; }

        protected override void ProcessRecord()
        {
            switch (ParameterSetName)
            {
                case "NativeGQL":
                    {
                        try
                        {
                            Task<object> myTask = _rbkClient.InvokeGenericCall(
                                OperationText,
                                GetMetricTags()
                            );
                            myTask.Wait();
                            string jsonResult = JsonConvert.SerializeObject(myTask.Result);
                            string script = "ConvertFrom-Json -InputObject '" + jsonResult + "'";
                            var myObject = this.InvokeCommand.InvokeScript(script);
                            WriteObject(myObject);
                        }
                        catch (Exception ex)
                        {
                            WriteError(
                                new ErrorRecord(ex, "ClientError", ErrorCategory.OperationStopped, this)
                            );
                        }
                        break;
                    }

                    // case "NativePowerShell":

                    //     Console.WriteLine(OutputType);
                    //     Type t = Invoke_Rsc.GetType(OutputType);
                    //     MethodInfo method = typeof(RscGraphQLClient).GetMethod("InvokeGenericCallAsync");
                    //     MethodInfo genericMethod = method.MakeGenericMethod(t);
                    //     object[] parameters = new object[] { /*AccountSettingQuery.Request(),*/ null };
                    //     var taskResult = genericMethod.Invoke(_rbkClient, parameters);
                    //     var result = ((dynamic)taskResult).GetAwaiter().GetResult();
                    //     WriteObject(result);

                    //     break;
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
            // type = Type.GetType("Rubrik.SecurityCloud.Operations." + typeName + ", RubrikSecurityCloud.Schema");
            // if (type != null)
            //     return type;
            type = Type.GetType(
                "Rubrik.SecurityCloud.Types." + typeName + ", RubrikSecurityCloud.Schema"
            );
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

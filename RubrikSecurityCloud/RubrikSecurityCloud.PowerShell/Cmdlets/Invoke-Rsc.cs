using System;
using System.Collections;
using System.Management.Automation;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Send a custom GraphQL query to the Rubrik Security Cloud (RSC) API.
    /// </summary>
    /// <description>
    /// The passed query is sent to the Rubrik Security Cloud API,
    /// and the result is returned to the user.
    /// </description>
    /// <example>
    /// Read GraphQL query from txt file.
    /// <code>
    /// Get-Content -Path /Samples/GetVsphereVmList.query.txt -Raw | Invoke-Rsc
    /// </code>
    /// </example>
    /// <example>
    /// Read GraphQL query from parameter.
    /// <code>
    /// Invoke-Rsc -Query "mutation DeleteWebhookMutation(`$id: Int!) { deleteWebhook(input: {id: `$id}) }" -Variables @{id = 1}
    /// </code>
    /// </example>
    [Cmdlet(
        VerbsLifecycle.Invoke,
        "Rsc",
        DefaultParameterSetName = "NativeGQL")]
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
        public string Query { get; set; }

        // ----------------------------------------------------------
        // - Parameter Set "NativeGQL"
        // This paramset is used when the user writes their own GQL queries
        /// <summary>
        /// The variables to supply to the GraphQL query.
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeGQL",
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = true
        )]
        public Hashtable Variables { get; set; }

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
                        object reply = _rbkClient.InvokeRawQuery(
                            Query,
                            Variables,
                            _logger,
                            GetMetricTags()
                        );
                        WriteObject(reply);
                    }
                    catch (Exception ex)
                    {
                        WriteError(
                            new ErrorRecord(
                                ex,
                                "ClientError",
                                ErrorCategory.OperationStopped,
                                this)
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
            // type = Type.GetType("RubrikSecurityCloud.Operations." + typeName + ", RubrikSecurityCloud.Schema");
            // if (type != null)
            //     return type;
            type = Type.GetType(
                "RubrikSecurityCloud.Types." + typeName
                    + ", RubrikSecurityCloud.Schema"
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

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using GraphQL;
using System.Collections.ObjectModel;
using System.Management.Automation.Language;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591


namespace RubrikSecurityCloud.PowerShell.Private
{
    /// <summary>
    /// Base class for all RSC PowerShell cmdlets.
    /// </summary>
    [CmdletBinding()]
    public class RscBasePSCmdlet : PSCmdlet
    {
        internal RscLogger _logger = null;
        internal RscGraphQLClient _rbkClient = null;
        internal bool _retrieveConnection = false;

        /// <summary>
        /// Create a new RSC PowerShell cmdlet with logging and a client.
        /// Client is left null until RetrieveConnection() is called
        /// from the derived class, or if the cmdlet is constructed
        /// with retrieveConnection=true.
        /// 
        /// Note that `retrieveConnection=true` retrieves an existing
        /// connection if any ; if there are none, it does not 
        /// create a new connection.
        /// </summary>
        public RscBasePSCmdlet(bool retrieveConnection = false)
        {
            _retrieveConnection = retrieveConnection;
            this._logger = new RscLogger(this);
        }

        protected Dictionary<string, string> GetMetricTags()
        {

            // Traverse PowerShell stack
            string caller = "Unknown";
            Collection<PSObject> callStack = this.InvokeCommand.InvokeScript("Get-PSCallStack");
            foreach (PSObject stackFrame in callStack)
            {
                CallStackFrame frame = (CallStackFrame)stackFrame.BaseObject;
                if (!string.IsNullOrEmpty(frame.ScriptName) &&
                    !frame.ScriptName.Contains("Toolkit/Public/"))
                {
                    string[] path = frame.ScriptName.Split('/');
                    caller = path[path.Length - 1];
                    break;
                }
            }

            string version =
                this
                    .MyInvocation
                    .MyCommand
                    .Module
                    .Version
                    .ToString();

            return new Dictionary<string, string>{
                {"Sdk-Caller", caller},
                {"Sdk-Language", "PowerShell"},
                {"Sdk-Rsc-Version", SchemaMeta.GraphqlSchemaVersion},
                {"Sdk-Version", version}
            };
        }

        internal object SendGqlRequest(
            RscGqlRequest request,
            bool writeObject = true)
        {
            _logger.Debug($"Sending request {request.OperationName}");
            try
            {
                var result = this._rbkClient.Invoke(
                    request, null, request.ReturnTypeName, this._logger,
                    GetMetricTags());
                if (writeObject)
                {
                    WriteObject(result, true);
                }
                return result;
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
            return null; // never reached
        }

        protected bool RetrieveConnection(bool throwIfNotRetrieved = true)
        {
            try
            {
                var psVar = SessionState.PSVariable.GetValue(Config.SessionVariableName);
                var sessionClient = (RscGraphQLClient)psVar;
                if(sessionClient == null)
                {
                    if(throwIfNotRetrieved)
                    {
                        throw new Exception("No active session found. Use 'Connect-Rsc'. ");
                    }
                    return false;
                }
                this._rbkClient = sessionClient;
                // reset the logger to the current session
                this._rbkClient.Logger = this._logger;
                this._logger?.Debug($"Retrieved connection from session variable {Config.SessionVariableName}: {this._rbkClient.Info()}");

                //Check if the token has expired. If it has, attempt a new session and return.
                if (_rbkClient.AuthenticationState == AuthenticationState.EXPIRED)
                {
                    this._logger?.Verbose("Client session expired, attempting to renew...");
                    if (this.Connect())
                    {
                        this._logger?.Verbose("Client session renewed.");
                        return true;
                    }
                    else
                    {
                        if (throwIfNotRetrieved)
                        {
                            throw new Exception("Could not renew expired session. Use 'Connect-Rsc'. ");
                        }
                        return false;
                    }
                }

                Task RenewAuthTask = this._rbkClient.RenewAuthAsyncIfNeeded();
                RenewAuthTask.Wait();

                if (_rbkClient.AuthenticationState != AuthenticationState.AUTHORIZED)
                {
                    if (throwIfNotRetrieved)
                    {
                        throw new Exception("No valid session found. Use 'Connect-Rsc'. ");
                    }
                    return false;
                }

            }
            catch (Exception ex)
            {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    Config.SessionVariableName,
                    ErrorCategory.ConnectionError,
                    null);
                ThrowTerminatingError(error);
            }
            return true;
        }

        protected bool Connect()
        {
            try
            {
                var authStateBefore = this._rbkClient.AuthenticationState;
                var psVarBefore = (null!=SessionState.PSVariable.GetValue(Config.SessionVariableName));
                this._logger?.Debug($"Before Auth: Auth State: {authStateBefore}, Connection object in session: {psVarBefore}");
                Task authTask = this._rbkClient.AuthAsync();
                authTask.Wait();

                this._logger?.Verbose($"Authentication Status: " +
                        $"{this._rbkClient.AuthenticationState}");

                if (this._rbkClient.AuthenticationState == AuthenticationState.AUTHORIZED)
                {
                    SessionState.PSVariable.Set(
                        new PSVariable(
                            Config.SessionVariableName,
                            this._rbkClient,
                            ScopedItemOptions.AllScope));
                    this._logger?.Debug("Connected. Connection stored in session variable.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorRecord(
                    ex,
                    "UnableToAuthenticateToRubrikSecurityCloud",
                    ErrorCategory.AuthenticationError,
                    null);
                ThrowTerminatingError(error);
            }
            return false;
        }


#pragma warning disable 1591 // ignore warning 'Missing XML comment'
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            // build report and tally switches:
            var report = BuildCmdletParametersReport();
            this._logger.Debug(report);

            if (_retrieveConnection)
            {
                RetrieveConnection();
            }
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
            this._logger.Flush();
        }

        protected void ThrowTerminatingException(
            Exception ex,
            string errorId = null,
            ErrorCategory errorCategory = ErrorCategory.InvalidOperation,
            object targetObject = null)
        {
            this._logger?.Flush();
            string message = ex.Message;
            if (ex.InnerException != null)
            {
                if (message == "Exception has been thrown by the target of an invocation.")
                {
                    message = "";
                }
                message += $"\n{ex.InnerException.Message}";
            }
            var error = new ErrorRecord(
                new Exception(message),
                string.IsNullOrEmpty(errorId) ? this.GetType().Name : errorId,
                errorCategory,
                targetObject);
            ThrowTerminatingError(error);
        }

        protected string GetCmdletName()
        {
            var attr = (CmdletAttribute)Attribute.GetCustomAttribute(
                this.GetType(), typeof(CmdletAttribute));
            if (attr == null)
            {
                return "";
            }
            return $"{attr.VerbName}-{attr.NounName}";
        }

        virtual public SchemaMeta.ApiDomainName ApiDomainName()
        {
            return SchemaMeta.ApiDomainNameByCmdletName(
                this.GetCmdletName());
        }

        public string ValidateOperation(
            string op,
            bool unknownOk = true)
        {

            var domain = this.ApiDomainName();
            List<string> validOps =
                SchemaMeta.ApiOperationsByApiDomainName(domain);

            if (op.ToLower() == "unknown")
            {
                if (unknownOk)
                {
                    return "";
                }
                throw new Exception($"Unknown operation. Valid operations are: {string.Join(", ", validOps)}");
            }

            // Check if op matches any entry in validOps, regardless of case.
            var matchedOp = validOps.FirstOrDefault(v => v.Equals(op, StringComparison.OrdinalIgnoreCase));
            if (matchedOp != null)
            {
                return matchedOp;
            }
            // See if it's a GraphQL root field name:
            var _rscOp = (new RscOp(gqlRootFieldName: op)).Finalize();
            if (_rscOp.IsDetermined())
            {
                if (_rscOp.CmdletName == this.GetCmdletName())
                {
                    return _rscOp.OpName();
                }
                if (!unknownOk)
                {
                    throw new Exception($"GraphQL root field '{op}' is not supported by this cmdlet. Use {_rscOp.Syntax()} instead.");
                }
            }
            if (unknownOk)
            {
                return "";
            }
            throw new Exception($"Unknown operation '{op}'. Valid operations are: {string.Join(", ", validOps)}");
        }

        protected string GetSessionCWD()
        {
            return SessionState.Path.CurrentFileSystemLocation.Path;
        }

        protected string GetProcessCWD()
        {
            return Directory.GetCurrentDirectory();
        }

        protected string GetSessionVar(string name, string defaultValue = "")
        {
            return SessionState.PSVariable.GetValue(name, defaultValue)?.ToString();
        }

        protected string GetEnvVar(string name, string defaultValue = "")
        {
            return Environment.GetEnvironmentVariable(name) ?? defaultValue;
        }

        protected string GetCustomDir()
        {
            string customDir = this.GetEnvVar("RSC_CUSTOM_DIR");
            if (string.IsNullOrEmpty(customDir) ||
                 !Directory.Exists(customDir))
            {
                customDir = this.GetSessionCWD();
            }
            return customDir;
        }

        /// <summary>
        /// Get the RSC SDK's user profile directory.
        /// Typically "$(Split-Path $PROFILE -Parent)/rubrik-powershell-sdk"
        /// But resolves to the current directory if $PROFILE is not defined.
        /// </summary>
        protected string GetProfileDir()
        {
            string profPath = GetSessionVar("PROFILE");
            if (string.IsNullOrEmpty(profPath))
            {
                profPath = Environment.GetEnvironmentVariable("PROFILE");
            }
            // if not defined, use default
            if (string.IsNullOrEmpty(profPath))
            {
                profPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            }
            // if not defined, use cwd
            if (string.IsNullOrEmpty(profPath))
            {
                return this.GetSessionCWD();
            }
            // if it's a file, get its directory
            if (File.Exists(profPath))
            {
                profPath = Path.GetDirectoryName(profPath);
            }
            else if (!Directory.Exists(profPath))
            {
                // see if parent directory exists
                profPath = Path.GetDirectoryName(profPath);
                if (!Directory.Exists(profPath))
                {
                    throw new DirectoryNotFoundException("Could not find: " + profPath);
                }
            }
            profPath = Path.Combine(profPath, "rubrik-powershell-sdk");
            // if it doesn't exist, create it
            if (!Directory.Exists(profPath))
            {
                Directory.CreateDirectory(profPath);
            }
            return profPath;
        }

        /// <summary>
        /// If a cmdlet parameter exists with given name, within the current parameter set, return its value.
        /// </summary>
        internal object GetValueFromParameterSet(string argName)
        {
            string fieldName = StringUtils.Capitalize(argName);
            System.Type parentType = this.GetType();
            PropertyInfo propertyInfo = parentType.GetProperty(fieldName, BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfo == null)
            {
                // _logger.Debug($"No public property with name {fieldName}");
                return null;
            }
            // there is a public field with the same name
            // but is it a parameter?
            ParameterAttribute parameterAttribute =
                propertyInfo.GetCustomAttributes(typeof(ParameterAttribute), true).FirstOrDefault() as ParameterAttribute;

            if (parameterAttribute == null)
            {
                // _logger.Debug($"No parameter attribute for field {fieldName}");
                return null;
            }
            // but is it part of the current parameter set?
            if (parameterAttribute.ParameterSetName != this
                .ParameterSetName)
            {
                // _logger.Debug($"Parameter attribute for field {fieldName} is not in the current parameter set");
                return null;
            }
            // If so, use the value of the parameter
            var argValue = propertyInfo.GetValue(this);
            if (argValue == null)
            {
                // _logger.Debug($"Field {fieldName} is null");
                return null;
            }
            return argValue;
        }

        internal List<string> GetSwitchNames()
        {
            List<string> switchNames = new();
            try
            {
                System.Reflection.PropertyInfo[] cmdletProperties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var prop in cmdletProperties)
                {
                    // filter for parameters only
                    ParameterAttribute parameterAttribute = prop.GetCustomAttributes(typeof(ParameterAttribute), true).FirstOrDefault() as ParameterAttribute;
                    if (parameterAttribute == null)
                    {
                        continue;
                    }
                    if (prop.PropertyType.Name == "SwitchParameter")
                    {
                        switchNames.Add(prop.Name);
                    }
                }
            }
            catch (Exception e)
            {
                _logger?.Debug($"Could not retrieve switch names: {e}");
            }
            return switchNames;
        }

        // For debugging purposes,
        // Create a report of all inputs with their types and values,
        // using introspection to get the names of the parameters.
        internal string BuildCmdletParametersReport(int indent = 0)
        {
            List<string> lines = new();
            var indentStr = new string(' ', indent);
            lines.Add($"{indentStr}Cmdlet Inputs:");
            System.Type cmdletType = this.GetType();
            string cmdletName = cmdletType.Name;
            System.Reflection.PropertyInfo[] cmdletProperties = cmdletType
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in cmdletProperties)
            {
                // filter for parameters only
                ParameterAttribute parameterAttribute = prop.GetCustomAttributes(typeof(ParameterAttribute), true).FirstOrDefault() as ParameterAttribute;
                if (parameterAttribute == null)
                {
                    continue;
                }
                try
                {
                    var propVal = prop.GetValue(this);
                    if (propVal == null)
                    {
                        continue; // skip unset parameters
                    }
                    var propType = prop.PropertyType;
                    var propTypeName = propType.Name;

                    if (propTypeName == "SwitchParameter")
                    {
                        if (propVal.ToString() == "False")
                        {
                            continue; // skip false switch parameters
                        }
                    }
                    var paramValueStr = StringUtils.FormatObjectForLogging(propVal);

                    // Display actual type for Object:
                    if (propType is System.Object && propVal != null)
                    {
                        propTypeName = propVal.GetType().Name;
                    }

                    lines.Add($"{indentStr}  {prop.Name}: {paramValueStr}");
                }
                catch (Exception e)
                {
                    lines.Add($"{indentStr}  Exception: {e}");
                }
            }
            return string.Join("\n", lines);
        }
    }
}


using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using GraphQL;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

// until we use #nullable enable
#pragma warning disable CS8632

public class OperationCompleter : IArgumentCompleter
{
    static public IRscLogger? _logger = null;
    public IEnumerable<CompletionResult> CompleteArgument(
        string commandName,
        string parameterName,
        string wordToComplete,
        CommandAst commandAst,
        IDictionary fakeBoundParameters)
    {
        // Extract Domain value from commandName
        var domain = commandName
            .Replace("New-RscQuery", "")
            .Replace("New-RscMutation", "");

        // Extract Domain value from fakeBoundParameters
        if (fakeBoundParameters.Contains("Domain"))
        {
            var d = fakeBoundParameters["Domain"].ToString();
            if (!string.IsNullOrEmpty(d))
            {
                domain = d;
            }
        }

        // Get the list of valid operations
        List<string> validValues;
        if (!string.IsNullOrEmpty(domain))
        {
            validValues = GetValidOperations(domain);
        }
        else
        {
            validValues = new List<string>();
        }

        // Filter the values based on wordToComplete and return them
        foreach (var value in validValues)
        {
            if (value.StartsWith(wordToComplete, StringComparison.OrdinalIgnoreCase))
            {
                yield return new CompletionResult(value);
            }
        }
    }

    protected List<string> GetValidOperations(string domain)
    {
        // Implement your C# logic here to get the valid operations
        // For the sake of this example, I'm returning a static list
        return SchemaMeta.ApiOperationsByApiDomainName(domain);
    }
}

namespace RubrikSecurityCloud.PowerShell.Private
{
    public delegate RuntimeDefinedParameter? DefineDynParamMethod();

    public class RscDynParamPSCmdletConfig
    {
        public bool HasDynParam_AddField = true;
        public bool HasDynParam_RemoveField = true;

        public bool Enabled()
        {
            return this.HasDynParam_AddField ||
                this.HasDynParam_RemoveField;
        }
    }
    // This class simplifies the implementation of cmdlets
    // that have dynamic parameters.
    // To use, derive from this class with `enableDynParams` set to true,
    // and call AddDynParamMethod() in the constructor of the derived class
    // to add methods that define dynamic parameters.
    //
    // If config.HasDynParam_AddField is true or config.HasDynParam_RemoveField is true,
    // the derived class must define GetValidPatchSet().
    [CmdletBinding()]
    public class RscDynParamPSCmdlet : RscBasePSCmdlet, IDynamicParameters
    {
        public RscDynParamPSCmdlet(RscDynParamPSCmdletConfig? config = null) : base()
        {
            OperationCompleter._logger = _logger;
            this.DynParamsConfig = (config != null) ? config : new RscDynParamPSCmdletConfig();
            if (this.DynParamsConfig.Enabled())
            {
                if (this.DynParamsConfig.HasDynParam_AddField)
                {
                    this.AddDynParamMethod(this.MakeDynParam_AddField);
                }
                if (this.DynParamsConfig.HasDynParam_RemoveField)
                {
                    this.AddDynParamMethod(this.MakeDynParam_RemoveField);
                }
            }
        }
        protected RscDynParamPSCmdletConfig DynParamsConfig;
        protected RuntimeDefinedParameterDictionary? DynamicParameters = null;

        // list of methods that define dynamic parameters.
        protected List<DefineDynParamMethod> DynParamMethods = new List<DefineDynParamMethod>();

        // Add a method to the list of methods that define dynamic parameters.
        //
        // Derived classes should call this method as many times 
        // as they need to add methods that define dynamic parameters.
        // The methods will be called in the order they were added.
        // The methods will be called before BeginProcessing() is called.
        // This should be called in the constructor of the derived class.
        protected void AddDynParamMethod(DefineDynParamMethod method)
        {
            this.DynParamMethods.Add(method);
        }

        // implement IDynamicParameters.
        // This method is called before BeginProcessing() as many times
        // as the user presses TAB to complete the cmdlet's parameters,
        // and then once more before BeginProcessing() is called.
        public object GetDynamicParameters()
        {
            if (!this.DynParamsConfig.Enabled())
            {
                return null;
            }
            if (this.DynamicParameters == null)
            {
                this.DynamicParameters =
                    new RuntimeDefinedParameterDictionary();
                try
                {
                    this.UpdateDynParams();
                }
                catch (Exception e)
                {
                    _logger?.Debug($" UpdateDynParams -->  exception: {e}");
                }
            }
            _logger?.Debug($"  returning\n{this.DynamicParametersToString()}");
            return this.DynamicParameters;
        }

        protected string DynamicParametersToString()
        {
            if (this.DynamicParameters == null)
            {
                return "null";
            }
            string s = "";
            foreach (var dynParam in this.DynamicParameters)
            {
                string val = "?";
                if (dynParam.Value is RuntimeDefinedParameter rdp)
                {
                    val = $"Name={rdp.Name} Type={rdp.ParameterType} IsSet={rdp.IsSet} Value={rdp.Value}";
                }
                s += $"  {dynParam.Key}: {val}\n";
            }
            return s;
        }

        // Called by GetDynamicParameters()
        // multiple times after InitDynParams()
        // to update the dynamic parameters.
        protected virtual void UpdateDynParams()
        {
            foreach (var method in this.DynParamMethods)
            {
                var dynParam = method();
                if (dynParam == null)
                {
                    continue;
                }
                if (this.DynamicParameters.ContainsKey(dynParam.Name))
                {
                    this.DynamicParameters[dynParam.Name] = dynParam;
                }
                else
                {
                    this.DynamicParameters.Add(dynParam.Name, dynParam);
                }
            }
        }

        // Get a dynamic parameter value as an object
        protected object? GetDynParam(string name)
        {
            if (this.DynamicParameters == null)
            {
                throw new Exception($"{name}: DynamicParameters is null");
            }
            if (!this.DynamicParameters.ContainsKey(name))
            {
                return null;
            }
            if (this.DynamicParameters[name].Value == null)
            {
                return null;
            }
            _logger?.Debug($"  {name}: {this.DynamicParameters[name].Value}");
            return this.DynamicParameters[name].Value;
        }


        // Get a dynamic parameter value as a string.
        protected string? GetStringDynParam(string name)
        {
            return this.GetDynParam(name)?.ToString();
        }

        protected string[] GetStringArrayDynParam(string name)
        {
            var value = this.GetDynParam(name);
            if (value == null)
            {
                return new string[0];
            }
            if (value is string[] strings)
            {
                return strings;
            }
            if (value is string s)
            {
                return new string[] { s };
            }
            throw new Exception($"{name}: {value} is not a string or string[]");
        }

        // Define -AddField
        // Relies on derived class to define GetValidPatchSet().
        protected RuntimeDefinedParameter? MakeDynParam_AddField()
        {
            if (!this.DynParamsConfig.HasDynParam_AddField)
            {
                return null;
            }
            var attrs = new Collection<Attribute>();
            attrs.Add(new ParameterAttribute
            {
                HelpMessage = "Add fields to the set of fields that are selected for retrieval."
            });
            List<string> validValues = this.GetValidPatchSet();
            if (validValues != null)
            {
                string validValuesString =
                    String.Join(",", validValues.Select(x => $"\"{x}\""));
                const int maxValuesLen = 10;
                string truncatedValidValuesString =
                    string
                        .Join(
                            ",", validValues.Take(maxValuesLen).Select(x => $"\"{x}\"")
                        ) + (validValues.Count > maxValuesLen ? "..." : "");
                var script = ScriptBlock.Create($@"
                                $givenValues = $_
                                $validValues = @({validValuesString})
                                $givenValues | ForEach-Object {{
                                    if ($validValues -notcontains $_) {{
                                        throw 'Cannot validate argument on parameter ''AddField''. The argument ' + $_ + ' does not belong to the set: {truncatedValidValuesString}'
                                    }}
                                }}
                                return $true
                            ");
                var validationAttr = new ValidateScriptAttribute(
                    script);
                var autocompleteAttr = new ValidateSetAttribute(validValues.ToArray());
                attrs.Add(validationAttr);
                attrs.Add(autocompleteAttr);
            }
            return new RuntimeDefinedParameter(
                "AddField", typeof(string[]), attrs);
        }

        // Define -RemoveField
        // Relies on derived class to define GetValidPatchSet().
        protected RuntimeDefinedParameter? MakeDynParam_RemoveField()
        {
            if (!this.DynParamsConfig.HasDynParam_RemoveField)
            {
                return null;
            }
            var attrs = new Collection<Attribute>();
            attrs.Add(new ParameterAttribute
            {
                HelpMessage = "remove fields to the set of fields that are selected for retrieval."
            });
            List<string> validValues = this.GetValidPatchSet();
            if (validValues != null)
            {
                var attr = new ValidateSetAttribute(validValues.ToArray());
                attrs.Add(attr);
            }
            return new RuntimeDefinedParameter(
                "RemoveField", typeof(string[]), attrs);
        }

        // Return a list of valid values for -AddField and -RemoveField.
        // Derived classes should override this method
        virtual protected List<string>? GetValidPatchSet()
        {
            return null;
        }

    }
}
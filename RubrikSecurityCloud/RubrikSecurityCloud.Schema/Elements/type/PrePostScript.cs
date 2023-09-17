// PrePostScript.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region PrePostScript
    public class PrePostScript: BaseType
    {
        #region members

        //      C# -> PrePostScriptFailureHandlingEnum? FailureHandling
        // GraphQL -> failureHandling: PrePostScriptFailureHandlingEnum! (enum)
        [JsonProperty("failureHandling")]
        public PrePostScriptFailureHandlingEnum? FailureHandling { get; set; }

        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        [JsonProperty("scriptPath")]
        public System.String? ScriptPath { get; set; }

        //      C# -> System.Int32? TimeoutMs
        // GraphQL -> timeoutMs: Int! (scalar)
        [JsonProperty("timeoutMs")]
        public System.Int32? TimeoutMs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrePostScript";
    }

    public PrePostScript Set(
        PrePostScriptFailureHandlingEnum? FailureHandling = null,
        System.String? ScriptPath = null,
        System.Int32? TimeoutMs = null
    ) 
    {
        if ( FailureHandling != null ) {
            this.FailureHandling = FailureHandling;
        }
        if ( ScriptPath != null ) {
            this.ScriptPath = ScriptPath;
        }
        if ( TimeoutMs != null ) {
            this.TimeoutMs = TimeoutMs;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> PrePostScriptFailureHandlingEnum? FailureHandling
        // GraphQL -> failureHandling: PrePostScriptFailureHandlingEnum! (enum)
        if (this.FailureHandling != null) {
            s += ind + "failureHandling\n" ;
        }
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        if (this.ScriptPath != null) {
            s += ind + "scriptPath\n" ;
        }
        //      C# -> System.Int32? TimeoutMs
        // GraphQL -> timeoutMs: Int! (scalar)
        if (this.TimeoutMs != null) {
            s += ind + "timeoutMs\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PrePostScriptFailureHandlingEnum? FailureHandling
        // GraphQL -> failureHandling: PrePostScriptFailureHandlingEnum! (enum)
        if (this.FailureHandling == null && ec.Includes("failureHandling",true))
        {
            this.FailureHandling = new PrePostScriptFailureHandlingEnum();
        }
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        if (this.ScriptPath == null && ec.Includes("scriptPath",true))
        {
            this.ScriptPath = "FETCH";
        }
        //      C# -> System.Int32? TimeoutMs
        // GraphQL -> timeoutMs: Int! (scalar)
        if (this.TimeoutMs == null && ec.Includes("timeoutMs",true))
        {
            this.TimeoutMs = Int32.MinValue;
        }
    }


    #endregion

    } // class PrePostScript
    
    #endregion

    public static class ListPrePostScriptExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<PrePostScript> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrePostScript> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrePostScript());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrePostScript> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
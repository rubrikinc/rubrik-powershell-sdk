// NutanixBackupScript.cs
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
    #region NutanixBackupScript
    public class NutanixBackupScript: BaseType
    {
        #region members

        //      C# -> NutanixBackupScriptFailureHandling? FailureHandling
        // GraphQL -> failureHandling: NutanixBackupScriptFailureHandling! (enum)
        [JsonProperty("failureHandling")]
        public NutanixBackupScriptFailureHandling? FailureHandling { get; set; }

        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String (scalar)
        [JsonProperty("scriptPath")]
        public System.String? ScriptPath { get; set; }

        //      C# -> System.Int64? TimeoutMs
        // GraphQL -> timeoutMs: Long! (scalar)
        [JsonProperty("timeoutMs")]
        public System.Int64? TimeoutMs { get; set; }


        #endregion

    #region methods

    public NutanixBackupScript Set(
        NutanixBackupScriptFailureHandling? FailureHandling = null,
        System.String? ScriptPath = null,
        System.Int64? TimeoutMs = null
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
        //      C# -> NutanixBackupScriptFailureHandling? FailureHandling
        // GraphQL -> failureHandling: NutanixBackupScriptFailureHandling! (enum)
        if (this.FailureHandling != null) {
            s += ind + "failureHandling\n" ;
        }
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String (scalar)
        if (this.ScriptPath != null) {
            s += ind + "scriptPath\n" ;
        }
        //      C# -> System.Int64? TimeoutMs
        // GraphQL -> timeoutMs: Long! (scalar)
        if (this.TimeoutMs != null) {
            s += ind + "timeoutMs\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> NutanixBackupScriptFailureHandling? FailureHandling
        // GraphQL -> failureHandling: NutanixBackupScriptFailureHandling! (enum)
        if (this.FailureHandling == null && Exploration.Includes(parent + ".failureHandling", true))
        {
            this.FailureHandling = new NutanixBackupScriptFailureHandling();
        }
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String (scalar)
        if (this.ScriptPath == null && Exploration.Includes(parent + ".scriptPath", true))
        {
            this.ScriptPath = "FETCH";
        }
        //      C# -> System.Int64? TimeoutMs
        // GraphQL -> timeoutMs: Long! (scalar)
        if (this.TimeoutMs == null && Exploration.Includes(parent + ".timeoutMs", true))
        {
            this.TimeoutMs = new System.Int64();
        }
    }


    #endregion

    } // class NutanixBackupScript
    
    #endregion

    public static class ListNutanixBackupScriptExtensions
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
            this List<NutanixBackupScript> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixBackupScript> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixBackupScript());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
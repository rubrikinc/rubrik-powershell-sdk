// SlaManagedVolumeScriptSummary.cs
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
    #region SlaManagedVolumeScriptSummary
    public class SlaManagedVolumeScriptSummary: BaseType
    {
        #region members

        //      C# -> System.String? RunAsUser
        // GraphQL -> runAsUser: String! (scalar)
        [JsonProperty("runAsUser")]
        public System.String? RunAsUser { get; set; }

        //      C# -> System.String? ScriptCommand
        // GraphQL -> scriptCommand: String! (scalar)
        [JsonProperty("scriptCommand")]
        public System.String? ScriptCommand { get; set; }

        //      C# -> System.Int64? Timeout
        // GraphQL -> timeout: Long (scalar)
        [JsonProperty("timeout")]
        public System.Int64? Timeout { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaManagedVolumeScriptSummary";
    }

    public SlaManagedVolumeScriptSummary Set(
        System.String? RunAsUser = null,
        System.String? ScriptCommand = null,
        System.Int64? Timeout = null
    ) 
    {
        if ( RunAsUser != null ) {
            this.RunAsUser = RunAsUser;
        }
        if ( ScriptCommand != null ) {
            this.ScriptCommand = ScriptCommand;
        }
        if ( Timeout != null ) {
            this.Timeout = Timeout;
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
        //      C# -> System.String? RunAsUser
        // GraphQL -> runAsUser: String! (scalar)
        if (this.RunAsUser != null) {
            s += ind + "runAsUser\n" ;
        }
        //      C# -> System.String? ScriptCommand
        // GraphQL -> scriptCommand: String! (scalar)
        if (this.ScriptCommand != null) {
            s += ind + "scriptCommand\n" ;
        }
        //      C# -> System.Int64? Timeout
        // GraphQL -> timeout: Long (scalar)
        if (this.Timeout != null) {
            s += ind + "timeout\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? RunAsUser
        // GraphQL -> runAsUser: String! (scalar)
        if (this.RunAsUser == null && ec.Includes("runAsUser",true))
        {
            this.RunAsUser = "FETCH";
        }
        //      C# -> System.String? ScriptCommand
        // GraphQL -> scriptCommand: String! (scalar)
        if (this.ScriptCommand == null && ec.Includes("scriptCommand",true))
        {
            this.ScriptCommand = "FETCH";
        }
        //      C# -> System.Int64? Timeout
        // GraphQL -> timeout: Long (scalar)
        if (this.Timeout == null && ec.Includes("timeout",true))
        {
            this.Timeout = new System.Int64();
        }
    }


    #endregion

    } // class SlaManagedVolumeScriptSummary
    
    #endregion

    public static class ListSlaManagedVolumeScriptSummaryExtensions
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
            this List<SlaManagedVolumeScriptSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaManagedVolumeScriptSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaManagedVolumeScriptSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SlaManagedVolumeScriptSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
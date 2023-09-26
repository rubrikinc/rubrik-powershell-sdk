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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? RunAsUser
        // GraphQL -> runAsUser: String! (scalar)
        if (this.RunAsUser != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runAsUser\n" ;
            } else {
                s += ind + "runAsUser\n" ;
            }
        }
        //      C# -> System.String? ScriptCommand
        // GraphQL -> scriptCommand: String! (scalar)
        if (this.ScriptCommand != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scriptCommand\n" ;
            } else {
                s += ind + "scriptCommand\n" ;
            }
        }
        //      C# -> System.Int64? Timeout
        // GraphQL -> timeout: Long (scalar)
        if (this.Timeout != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timeout\n" ;
            } else {
                s += ind + "timeout\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? RunAsUser
        // GraphQL -> runAsUser: String! (scalar)
        if (ec.Includes("runAsUser",true))
        {
            if(this.RunAsUser == null) {

                this.RunAsUser = "FETCH";

            } else {


            }
        }
        else if (this.RunAsUser != null && ec.Excludes("runAsUser",true))
        {
            this.RunAsUser = null;
        }
        //      C# -> System.String? ScriptCommand
        // GraphQL -> scriptCommand: String! (scalar)
        if (ec.Includes("scriptCommand",true))
        {
            if(this.ScriptCommand == null) {

                this.ScriptCommand = "FETCH";

            } else {


            }
        }
        else if (this.ScriptCommand != null && ec.Excludes("scriptCommand",true))
        {
            this.ScriptCommand = null;
        }
        //      C# -> System.Int64? Timeout
        // GraphQL -> timeout: Long (scalar)
        if (ec.Includes("timeout",true))
        {
            if(this.Timeout == null) {

                this.Timeout = new System.Int64();

            } else {


            }
        }
        else if (this.Timeout != null && ec.Excludes("timeout",true))
        {
            this.Timeout = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<SlaManagedVolumeScriptSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
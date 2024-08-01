// NasAutomigrationTaskStatus.cs
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
    #region NasAutomigrationTaskStatus
    public class NasAutomigrationTaskStatus: BaseType
    {
        #region members

        //      C# -> TaskchainState? JobInstanceState
        // GraphQL -> jobInstanceState: TaskchainState! (enum)
        [JsonProperty("jobInstanceState")]
        public TaskchainState? JobInstanceState { get; set; }

        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        [JsonProperty("errorMsg")]
        public System.String? ErrorMsg { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasAutomigrationTaskStatus";
    }

    public NasAutomigrationTaskStatus Set(
        TaskchainState? JobInstanceState = null,
        System.String? ErrorMsg = null
    ) 
    {
        if ( JobInstanceState != null ) {
            this.JobInstanceState = JobInstanceState;
        }
        if ( ErrorMsg != null ) {
            this.ErrorMsg = ErrorMsg;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> TaskchainState? JobInstanceState
        // GraphQL -> jobInstanceState: TaskchainState! (enum)
        if (this.JobInstanceState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobInstanceState\n" ;
            } else {
                s += ind + "jobInstanceState\n" ;
            }
        }
        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        if (this.ErrorMsg != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMsg\n" ;
            } else {
                s += ind + "errorMsg\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TaskchainState? JobInstanceState
        // GraphQL -> jobInstanceState: TaskchainState! (enum)
        if (ec.Includes("jobInstanceState",true))
        {
            if(this.JobInstanceState == null) {

                this.JobInstanceState = new TaskchainState();

            } else {


            }
        }
        else if (this.JobInstanceState != null && ec.Excludes("jobInstanceState",true))
        {
            this.JobInstanceState = null;
        }
        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        if (ec.Includes("errorMsg",true))
        {
            if(this.ErrorMsg == null) {

                this.ErrorMsg = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMsg != null && ec.Excludes("errorMsg",true))
        {
            this.ErrorMsg = null;
        }
    }


    #endregion

    } // class NasAutomigrationTaskStatus
    
    #endregion

    public static class ListNasAutomigrationTaskStatusExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<NasAutomigrationTaskStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NasAutomigrationTaskStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NasAutomigrationTaskStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NasAutomigrationTaskStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NasAutomigrationTaskStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
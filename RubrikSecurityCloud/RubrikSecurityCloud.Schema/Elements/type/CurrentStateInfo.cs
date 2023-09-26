// CurrentStateInfo.cs
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
    #region CurrentStateInfo
    public class CurrentStateInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? CompletedStates
        // GraphQL -> completedStates: [String!]! (scalar)
        [JsonProperty("completedStates")]
        public List<System.String>? CompletedStates { get; set; }

        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        [JsonProperty("currentState")]
        public System.String? CurrentState { get; set; }

        //      C# -> System.String? CurrentTaskIndex
        // GraphQL -> currentTaskIndex: String! (scalar)
        [JsonProperty("currentTaskIndex")]
        public System.String? CurrentTaskIndex { get; set; }

        //      C# -> System.String? CurrentTaskName
        // GraphQL -> currentTaskName: String! (scalar)
        [JsonProperty("currentTaskName")]
        public System.String? CurrentTaskName { get; set; }

        //      C# -> List<System.String>? PendingStates
        // GraphQL -> pendingStates: [String!]! (scalar)
        [JsonProperty("pendingStates")]
        public List<System.String>? PendingStates { get; set; }

        //      C# -> System.String? Result
        // GraphQL -> result: String! (scalar)
        [JsonProperty("result")]
        public System.String? Result { get; set; }

        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        [JsonProperty("status")]
        public StatusResponse? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CurrentStateInfo";
    }

    public CurrentStateInfo Set(
        List<System.String>? CompletedStates = null,
        System.String? CurrentState = null,
        System.String? CurrentTaskIndex = null,
        System.String? CurrentTaskName = null,
        List<System.String>? PendingStates = null,
        System.String? Result = null,
        StatusResponse? Status = null
    ) 
    {
        if ( CompletedStates != null ) {
            this.CompletedStates = CompletedStates;
        }
        if ( CurrentState != null ) {
            this.CurrentState = CurrentState;
        }
        if ( CurrentTaskIndex != null ) {
            this.CurrentTaskIndex = CurrentTaskIndex;
        }
        if ( CurrentTaskName != null ) {
            this.CurrentTaskName = CurrentTaskName;
        }
        if ( PendingStates != null ) {
            this.PendingStates = PendingStates;
        }
        if ( Result != null ) {
            this.Result = Result;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> List<System.String>? CompletedStates
        // GraphQL -> completedStates: [String!]! (scalar)
        if (this.CompletedStates != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completedStates\n" ;
            } else {
                s += ind + "completedStates\n" ;
            }
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        if (this.CurrentState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentState\n" ;
            } else {
                s += ind + "currentState\n" ;
            }
        }
        //      C# -> System.String? CurrentTaskIndex
        // GraphQL -> currentTaskIndex: String! (scalar)
        if (this.CurrentTaskIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentTaskIndex\n" ;
            } else {
                s += ind + "currentTaskIndex\n" ;
            }
        }
        //      C# -> System.String? CurrentTaskName
        // GraphQL -> currentTaskName: String! (scalar)
        if (this.CurrentTaskName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentTaskName\n" ;
            } else {
                s += ind + "currentTaskName\n" ;
            }
        }
        //      C# -> List<System.String>? PendingStates
        // GraphQL -> pendingStates: [String!]! (scalar)
        if (this.PendingStates != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingStates\n" ;
            } else {
                s += ind + "pendingStates\n" ;
            }
        }
        //      C# -> System.String? Result
        // GraphQL -> result: String! (scalar)
        if (this.Result != null) {
            if (conf.Flat) {
                s += conf.Prefix + "result\n" ;
            } else {
                s += ind + "result\n" ;
            }
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? CompletedStates
        // GraphQL -> completedStates: [String!]! (scalar)
        if (ec.Includes("completedStates",true))
        {
            if(this.CompletedStates == null) {

                this.CompletedStates = new List<System.String>();

            } else {


            }
        }
        else if (this.CompletedStates != null && ec.Excludes("completedStates",true))
        {
            this.CompletedStates = null;
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        if (ec.Includes("currentState",true))
        {
            if(this.CurrentState == null) {

                this.CurrentState = "FETCH";

            } else {


            }
        }
        else if (this.CurrentState != null && ec.Excludes("currentState",true))
        {
            this.CurrentState = null;
        }
        //      C# -> System.String? CurrentTaskIndex
        // GraphQL -> currentTaskIndex: String! (scalar)
        if (ec.Includes("currentTaskIndex",true))
        {
            if(this.CurrentTaskIndex == null) {

                this.CurrentTaskIndex = "FETCH";

            } else {


            }
        }
        else if (this.CurrentTaskIndex != null && ec.Excludes("currentTaskIndex",true))
        {
            this.CurrentTaskIndex = null;
        }
        //      C# -> System.String? CurrentTaskName
        // GraphQL -> currentTaskName: String! (scalar)
        if (ec.Includes("currentTaskName",true))
        {
            if(this.CurrentTaskName == null) {

                this.CurrentTaskName = "FETCH";

            } else {


            }
        }
        else if (this.CurrentTaskName != null && ec.Excludes("currentTaskName",true))
        {
            this.CurrentTaskName = null;
        }
        //      C# -> List<System.String>? PendingStates
        // GraphQL -> pendingStates: [String!]! (scalar)
        if (ec.Includes("pendingStates",true))
        {
            if(this.PendingStates == null) {

                this.PendingStates = new List<System.String>();

            } else {


            }
        }
        else if (this.PendingStates != null && ec.Excludes("pendingStates",true))
        {
            this.PendingStates = null;
        }
        //      C# -> System.String? Result
        // GraphQL -> result: String! (scalar)
        if (ec.Includes("result",true))
        {
            if(this.Result == null) {

                this.Result = "FETCH";

            } else {


            }
        }
        else if (this.Result != null && ec.Excludes("result",true))
        {
            this.Result = null;
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new StatusResponse();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class CurrentStateInfo
    
    #endregion

    public static class ListCurrentStateInfoExtensions
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
            this List<CurrentStateInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CurrentStateInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CurrentStateInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CurrentStateInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
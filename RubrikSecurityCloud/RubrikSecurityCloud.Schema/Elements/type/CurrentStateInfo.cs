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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? CompletedStates
        // GraphQL -> completedStates: [String!]! (scalar)
        if (this.CompletedStates != null) {
            s += ind + "completedStates\n" ;
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        if (this.CurrentState != null) {
            s += ind + "currentState\n" ;
        }
        //      C# -> System.String? CurrentTaskIndex
        // GraphQL -> currentTaskIndex: String! (scalar)
        if (this.CurrentTaskIndex != null) {
            s += ind + "currentTaskIndex\n" ;
        }
        //      C# -> System.String? CurrentTaskName
        // GraphQL -> currentTaskName: String! (scalar)
        if (this.CurrentTaskName != null) {
            s += ind + "currentTaskName\n" ;
        }
        //      C# -> List<System.String>? PendingStates
        // GraphQL -> pendingStates: [String!]! (scalar)
        if (this.PendingStates != null) {
            s += ind + "pendingStates\n" ;
        }
        //      C# -> System.String? Result
        // GraphQL -> result: String! (scalar)
        if (this.Result != null) {
            s += ind + "result\n" ;
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "status {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? CompletedStates
        // GraphQL -> completedStates: [String!]! (scalar)
        if (this.CompletedStates == null && Exploration.Includes(parent + ".completedStates", true))
        {
            this.CompletedStates = new List<System.String>();
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        if (this.CurrentState == null && Exploration.Includes(parent + ".currentState", true))
        {
            this.CurrentState = "FETCH";
        }
        //      C# -> System.String? CurrentTaskIndex
        // GraphQL -> currentTaskIndex: String! (scalar)
        if (this.CurrentTaskIndex == null && Exploration.Includes(parent + ".currentTaskIndex", true))
        {
            this.CurrentTaskIndex = "FETCH";
        }
        //      C# -> System.String? CurrentTaskName
        // GraphQL -> currentTaskName: String! (scalar)
        if (this.CurrentTaskName == null && Exploration.Includes(parent + ".currentTaskName", true))
        {
            this.CurrentTaskName = "FETCH";
        }
        //      C# -> List<System.String>? PendingStates
        // GraphQL -> pendingStates: [String!]! (scalar)
        if (this.PendingStates == null && Exploration.Includes(parent + ".pendingStates", true))
        {
            this.PendingStates = new List<System.String>();
        }
        //      C# -> System.String? Result
        // GraphQL -> result: String! (scalar)
        if (this.Result == null && Exploration.Includes(parent + ".result", true))
        {
            this.Result = "FETCH";
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (this.Status == null && Exploration.Includes(parent + ".status"))
        {
            this.Status = new StatusResponse();
            this.Status.ApplyExploratoryFieldSpec(parent + ".status");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CurrentStateInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CurrentStateInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
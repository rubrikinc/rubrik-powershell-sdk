// CurrentStateInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:10.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region CurrentStateInfo
    public class CurrentStateInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? CompletedStates
            // GraphQL -> completedStates: [String!]! (scalar)
            if (this.CompletedStates != null)
            {
                 s += ind + "completedStates\n";

            }
            //      C# -> System.String? CurrentState
            // GraphQL -> currentState: String! (scalar)
            if (this.CurrentState != null)
            {
                 s += ind + "currentState\n";

            }
            //      C# -> System.String? CurrentTaskIndex
            // GraphQL -> currentTaskIndex: String! (scalar)
            if (this.CurrentTaskIndex != null)
            {
                 s += ind + "currentTaskIndex\n";

            }
            //      C# -> System.String? CurrentTaskName
            // GraphQL -> currentTaskName: String! (scalar)
            if (this.CurrentTaskName != null)
            {
                 s += ind + "currentTaskName\n";

            }
            //      C# -> List<System.String>? PendingStates
            // GraphQL -> pendingStates: [String!]! (scalar)
            if (this.PendingStates != null)
            {
                 s += ind + "pendingStates\n";

            }
            //      C# -> System.String? Result
            // GraphQL -> result: String! (scalar)
            if (this.Result != null)
            {
                 s += ind + "result\n";

            }
            //      C# -> StatusResponse? Status
            // GraphQL -> status: StatusResponse (type)
            if (this.Status != null)
            {
                 s += ind + "status\n";

                 s += ind + "{\n" + 
                 this.Status.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? CompletedStates
            // GraphQL -> completedStates: [String!]! (scalar)
            if (this.CompletedStates == null && Exploration.Includes(parent + ".completedStates$"))
            {
                this.CompletedStates = new List<System.String>();
            }
            //      C# -> System.String? CurrentState
            // GraphQL -> currentState: String! (scalar)
            if (this.CurrentState == null && Exploration.Includes(parent + ".currentState$"))
            {
                this.CurrentState = new System.String("FETCH");
            }
            //      C# -> System.String? CurrentTaskIndex
            // GraphQL -> currentTaskIndex: String! (scalar)
            if (this.CurrentTaskIndex == null && Exploration.Includes(parent + ".currentTaskIndex$"))
            {
                this.CurrentTaskIndex = new System.String("FETCH");
            }
            //      C# -> System.String? CurrentTaskName
            // GraphQL -> currentTaskName: String! (scalar)
            if (this.CurrentTaskName == null && Exploration.Includes(parent + ".currentTaskName$"))
            {
                this.CurrentTaskName = new System.String("FETCH");
            }
            //      C# -> List<System.String>? PendingStates
            // GraphQL -> pendingStates: [String!]! (scalar)
            if (this.PendingStates == null && Exploration.Includes(parent + ".pendingStates$"))
            {
                this.PendingStates = new List<System.String>();
            }
            //      C# -> System.String? Result
            // GraphQL -> result: String! (scalar)
            if (this.Result == null && Exploration.Includes(parent + ".result$"))
            {
                this.Result = new System.String("FETCH");
            }
            //      C# -> StatusResponse? Status
            // GraphQL -> status: StatusResponse (type)
            if (this.Status == null && Exploration.Includes(parent + ".status"))
            {
                this.Status = new StatusResponse();
                this.Status.ApplyExploratoryFragment(parent + ".status");
            }
        }


    #endregion

    } // class CurrentStateInfo
    #endregion

    public static class ListCurrentStateInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CurrentStateInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CurrentStateInfo> list, 
            String parent = "")
        {
            var item = new CurrentStateInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
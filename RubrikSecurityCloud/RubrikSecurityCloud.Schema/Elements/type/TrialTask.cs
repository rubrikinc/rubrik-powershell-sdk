// TrialTask.cs
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
    #region TrialTask
    public class TrialTask: BaseType
    {
        #region members

        //      C# -> TrialStep? Step
        // GraphQL -> step: TrialStep! (enum)
        [JsonProperty("step")]
        public TrialStep? Step { get; set; }

        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        [JsonProperty("completedAt")]
        public DateTime? CompletedAt { get; set; }

        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        [JsonProperty("isCompleted")]
        public System.Boolean? IsCompleted { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TrialTask";
    }

    public TrialTask Set(
        TrialStep? Step = null,
        DateTime? CompletedAt = null,
        System.Boolean? IsCompleted = null
    ) 
    {
        if ( Step != null ) {
            this.Step = Step;
        }
        if ( CompletedAt != null ) {
            this.CompletedAt = CompletedAt;
        }
        if ( IsCompleted != null ) {
            this.IsCompleted = IsCompleted;
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
        //      C# -> TrialStep? Step
        // GraphQL -> step: TrialStep! (enum)
        if (this.Step != null) {
            s += ind + "step\n" ;
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (this.CompletedAt != null) {
            s += ind + "completedAt\n" ;
        }
        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        if (this.IsCompleted != null) {
            s += ind + "isCompleted\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TrialStep? Step
        // GraphQL -> step: TrialStep! (enum)
        if (this.Step == null && Exploration.Includes(parent + ".step", true))
        {
            this.Step = new TrialStep();
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (this.CompletedAt == null && Exploration.Includes(parent + ".completedAt", true))
        {
            this.CompletedAt = new DateTime();
        }
        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        if (this.IsCompleted == null && Exploration.Includes(parent + ".isCompleted", true))
        {
            this.IsCompleted = true;
        }
    }


    #endregion

    } // class TrialTask
    
    #endregion

    public static class ListTrialTaskExtensions
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
            this List<TrialTask> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TrialTask> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TrialTask());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
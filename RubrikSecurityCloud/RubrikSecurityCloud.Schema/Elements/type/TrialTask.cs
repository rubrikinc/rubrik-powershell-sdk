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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> TrialStep? Step
        // GraphQL -> step: TrialStep! (enum)
        if (this.Step != null) {
            if (conf.Flat) {
                s += conf.Prefix + "step\n" ;
            } else {
                s += ind + "step\n" ;
            }
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (this.CompletedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completedAt\n" ;
            } else {
                s += ind + "completedAt\n" ;
            }
        }
        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        if (this.IsCompleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCompleted\n" ;
            } else {
                s += ind + "isCompleted\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TrialStep? Step
        // GraphQL -> step: TrialStep! (enum)
        if (ec.Includes("step",true))
        {
            if(this.Step == null) {

                this.Step = new TrialStep();

            } else {


            }
        }
        else if (this.Step != null && ec.Excludes("step",true))
        {
            this.Step = null;
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (ec.Includes("completedAt",true))
        {
            if(this.CompletedAt == null) {

                this.CompletedAt = new DateTime();

            } else {


            }
        }
        else if (this.CompletedAt != null && ec.Excludes("completedAt",true))
        {
            this.CompletedAt = null;
        }
        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        if (ec.Includes("isCompleted",true))
        {
            if(this.IsCompleted == null) {

                this.IsCompleted = true;

            } else {


            }
        }
        else if (this.IsCompleted != null && ec.Excludes("isCompleted",true))
        {
            this.IsCompleted = null;
        }
    }


    #endregion

    } // class TrialTask
    
    #endregion

    public static class ListTrialTaskExtensions
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
            this List<TrialTask> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TrialTask> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TrialTask> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TrialTask());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TrialTask> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
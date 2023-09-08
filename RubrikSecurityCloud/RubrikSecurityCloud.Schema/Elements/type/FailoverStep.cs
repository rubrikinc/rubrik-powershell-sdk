// FailoverStep.cs
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
    #region FailoverStep
    public class FailoverStep: BaseType
    {
        #region members

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        [JsonProperty("seq")]
        public System.Int32? Seq { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.Int32? Weight
        // GraphQL -> weight: Int! (scalar)
        [JsonProperty("weight")]
        public System.Int32? Weight { get; set; }

        //      C# -> List<FailoverSubStep>? SubSteps
        // GraphQL -> subSteps: [FailoverSubStep!]! (type)
        [JsonProperty("subSteps")]
        public List<FailoverSubStep>? SubSteps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverStep";
    }

    public FailoverStep Set(
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.String? Message = null,
        System.Single? Progress = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        System.String? Status = null,
        System.Int32? Weight = null,
        List<FailoverSubStep>? SubSteps = null
    ) 
    {
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( Seq != null ) {
            this.Seq = Seq;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Weight != null ) {
            this.Weight = Weight;
        }
        if ( SubSteps != null ) {
            this.SubSteps = SubSteps;
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
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime != null) {
            s += ind + "elapsedTime\n" ;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq != null) {
            s += ind + "seq\n" ;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int32? Weight
        // GraphQL -> weight: Int! (scalar)
        if (this.Weight != null) {
            s += ind + "weight\n" ;
        }
        //      C# -> List<FailoverSubStep>? SubSteps
        // GraphQL -> subSteps: [FailoverSubStep!]! (type)
        if (this.SubSteps != null) {
            var fspec = this.SubSteps.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subSteps {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime == null && ec.Includes("elapsedTime",true))
        {
            this.ElapsedTime = new System.Int64();
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime == null && ec.Includes("endTime",true))
        {
            this.EndTime = new System.Int64();
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress == null && ec.Includes("progress",true))
        {
            this.Progress = new System.Single();
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq == null && ec.Includes("seq",true))
        {
            this.Seq = Int32.MinValue;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime == null && ec.Includes("startTime",true))
        {
            this.StartTime = new System.Int64();
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = "FETCH";
        }
        //      C# -> System.Int32? Weight
        // GraphQL -> weight: Int! (scalar)
        if (this.Weight == null && ec.Includes("weight",true))
        {
            this.Weight = Int32.MinValue;
        }
        //      C# -> List<FailoverSubStep>? SubSteps
        // GraphQL -> subSteps: [FailoverSubStep!]! (type)
        if (this.SubSteps == null && ec.Includes("subSteps",false))
        {
            this.SubSteps = new List<FailoverSubStep>();
            this.SubSteps.ApplyExploratoryFieldSpec(ec.NewChild("subSteps"));
        }
    }


    #endregion

    } // class FailoverStep
    
    #endregion

    public static class ListFailoverStepExtensions
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
            this List<FailoverStep> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverStep> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverStep());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FailoverStep> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
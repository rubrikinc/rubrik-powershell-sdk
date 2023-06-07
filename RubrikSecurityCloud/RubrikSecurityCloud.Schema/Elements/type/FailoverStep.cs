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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "subSteps {\n" + this.SubSteps.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime == null && Exploration.Includes(parent + ".elapsedTime", true))
        {
            this.ElapsedTime = new System.Int64();
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new System.Int64();
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = new System.Single();
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq == null && Exploration.Includes(parent + ".seq", true))
        {
            this.Seq = Int32.MinValue;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new System.Int64();
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
        //      C# -> System.Int32? Weight
        // GraphQL -> weight: Int! (scalar)
        if (this.Weight == null && Exploration.Includes(parent + ".weight", true))
        {
            this.Weight = Int32.MinValue;
        }
        //      C# -> List<FailoverSubStep>? SubSteps
        // GraphQL -> subSteps: [FailoverSubStep!]! (type)
        if (this.SubSteps == null && Exploration.Includes(parent + ".subSteps"))
        {
            this.SubSteps = new List<FailoverSubStep>();
            this.SubSteps.ApplyExploratoryFieldSpec(parent + ".subSteps");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverStep> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverStep());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// SelectorStepEvent.cs
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
    #region SelectorStepEvent
    public class SelectorStepEvent: BaseType
    {
        #region members

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int (scalar)
        [JsonProperty("failed")]
        public System.Int32? Failed { get; set; }

        //      C# -> System.Int32? InProgress
        // GraphQL -> inProgress: Int (scalar)
        [JsonProperty("inProgress")]
        public System.Int32? InProgress { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        [JsonProperty("objectsWithoutSnapshot")]
        public System.Int32? ObjectsWithoutSnapshot { get; set; }

        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        [JsonProperty("seq")]
        public System.Int32? Seq { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        [JsonProperty("total")]
        public System.Int32? Total { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SelectorStepEvent";
    }

    public SelectorStepEvent Set(
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.Int32? Failed = null,
        System.Int32? InProgress = null,
        System.String? Message = null,
        System.Int32? ObjectsWithoutSnapshot = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        System.String? Status = null,
        System.Int32? Total = null
    ) 
    {
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Failed != null ) {
            this.Failed = Failed;
        }
        if ( InProgress != null ) {
            this.InProgress = InProgress;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ObjectsWithoutSnapshot != null ) {
            this.ObjectsWithoutSnapshot = ObjectsWithoutSnapshot;
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
        if ( Total != null ) {
            this.Total = Total;
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
        // GraphQL -> endTime: Long (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int (scalar)
        if (this.Failed != null) {
            s += ind + "failed\n" ;
        }
        //      C# -> System.Int32? InProgress
        // GraphQL -> inProgress: Int (scalar)
        if (this.InProgress != null) {
            s += ind + "inProgress\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        if (this.ObjectsWithoutSnapshot != null) {
            s += ind + "objectsWithoutSnapshot\n" ;
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq != null) {
            s += ind + "seq\n" ;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (this.Total != null) {
            s += ind + "total\n" ;
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
        // GraphQL -> endTime: Long (scalar)
        if (this.EndTime == null && ec.Includes("endTime",true))
        {
            this.EndTime = new System.Int64();
        }
        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int (scalar)
        if (this.Failed == null && ec.Includes("failed",true))
        {
            this.Failed = Int32.MinValue;
        }
        //      C# -> System.Int32? InProgress
        // GraphQL -> inProgress: Int (scalar)
        if (this.InProgress == null && ec.Includes("inProgress",true))
        {
            this.InProgress = Int32.MinValue;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        if (this.ObjectsWithoutSnapshot == null && ec.Includes("objectsWithoutSnapshot",true))
        {
            this.ObjectsWithoutSnapshot = Int32.MinValue;
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq == null && ec.Includes("seq",true))
        {
            this.Seq = Int32.MinValue;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
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
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (this.Total == null && ec.Includes("total",true))
        {
            this.Total = Int32.MinValue;
        }
    }


    #endregion

    } // class SelectorStepEvent
    
    #endregion

    public static class ListSelectorStepEventExtensions
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
            this List<SelectorStepEvent> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SelectorStepEvent> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SelectorStepEvent());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SelectorStepEvent> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
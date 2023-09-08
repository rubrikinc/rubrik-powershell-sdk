// FailoverEvent.cs
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
    #region FailoverEvent
    public class FailoverEvent: BaseType
    {
        #region members

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverEvent";
    }

    public FailoverEvent Set(
        System.String? Message = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        System.String? Status = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
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
    }


    #endregion

    } // class FailoverEvent
    
    #endregion

    public static class ListFailoverEventExtensions
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
            this List<FailoverEvent> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverEvent> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverEvent());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FailoverEvent> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
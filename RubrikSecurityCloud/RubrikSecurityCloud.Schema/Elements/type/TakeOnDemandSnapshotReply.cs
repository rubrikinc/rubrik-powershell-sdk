// TakeOnDemandSnapshotReply.cs
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
    #region TakeOnDemandSnapshotReply
    public class TakeOnDemandSnapshotReply: BaseType
    {
        #region members

        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        [JsonProperty("errors")]
        public List<TakeOnDemandSnapshotError>? Errors { get; set; }

        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        [JsonProperty("taskchainUuids")]
        public List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TakeOnDemandSnapshotReply";
    }

    public TakeOnDemandSnapshotReply Set(
        List<TakeOnDemandSnapshotError>? Errors = null,
        List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( TaskchainUuids != null ) {
            this.TaskchainUuids = TaskchainUuids;
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
        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "errors {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        if (this.TaskchainUuids != null) {
            var fspec = this.TaskchainUuids.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "taskchainUuids {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        if (this.Errors == null && ec.Includes("errors",false))
        {
            this.Errors = new List<TakeOnDemandSnapshotError>();
            this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));
        }
        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        if (this.TaskchainUuids == null && ec.Includes("taskchainUuids",false))
        {
            this.TaskchainUuids = new List<TakeOnDemandSnapshotTaskchainUuid>();
            this.TaskchainUuids.ApplyExploratoryFieldSpec(ec.NewChild("taskchainUuids"));
        }
    }


    #endregion

    } // class TakeOnDemandSnapshotReply
    
    #endregion

    public static class ListTakeOnDemandSnapshotReplyExtensions
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
            this List<TakeOnDemandSnapshotReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TakeOnDemandSnapshotReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TakeOnDemandSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TakeOnDemandSnapshotReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
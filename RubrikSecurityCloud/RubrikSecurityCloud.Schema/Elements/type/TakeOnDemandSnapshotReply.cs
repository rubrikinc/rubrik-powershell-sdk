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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "errors {\n" + this.Errors.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        if (this.TaskchainUuids != null) {
            s += ind + "taskchainUuids {\n" + this.TaskchainUuids.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        if (this.Errors == null && Exploration.Includes(parent + ".errors"))
        {
            this.Errors = new List<TakeOnDemandSnapshotError>();
            this.Errors.ApplyExploratoryFieldSpec(parent + ".errors");
        }
        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        if (this.TaskchainUuids == null && Exploration.Includes(parent + ".taskchainUuids"))
        {
            this.TaskchainUuids = new List<TakeOnDemandSnapshotTaskchainUuid>();
            this.TaskchainUuids.ApplyExploratoryFieldSpec(parent + ".taskchainUuids");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TakeOnDemandSnapshotReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TakeOnDemandSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
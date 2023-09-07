// GetPendingSlaAssignmentsReply.cs
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
    #region GetPendingSlaAssignmentsReply
    public class GetPendingSlaAssignmentsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? InvalidIds
        // GraphQL -> invalidIds: [String!]! (scalar)
        [JsonProperty("invalidIds")]
        public List<System.String>? InvalidIds { get; set; }

        //      C# -> List<ManagedObjectSlaInfo>? ObjectsWithNoOp
        // GraphQL -> objectsWithNoOp: [ManagedObjectSlaInfo!]! (type)
        [JsonProperty("objectsWithNoOp")]
        public List<ManagedObjectSlaInfo>? ObjectsWithNoOp { get; set; }

        //      C# -> List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp
        // GraphQL -> objectsWithPendingOp: [ManagedObjectPendingSlaInfo!]! (type)
        [JsonProperty("objectsWithPendingOp")]
        public List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPendingSlaAssignmentsReply";
    }

    public GetPendingSlaAssignmentsReply Set(
        List<System.String>? InvalidIds = null,
        List<ManagedObjectSlaInfo>? ObjectsWithNoOp = null,
        List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp = null
    ) 
    {
        if ( InvalidIds != null ) {
            this.InvalidIds = InvalidIds;
        }
        if ( ObjectsWithNoOp != null ) {
            this.ObjectsWithNoOp = ObjectsWithNoOp;
        }
        if ( ObjectsWithPendingOp != null ) {
            this.ObjectsWithPendingOp = ObjectsWithPendingOp;
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
        //      C# -> List<System.String>? InvalidIds
        // GraphQL -> invalidIds: [String!]! (scalar)
        if (this.InvalidIds != null) {
            s += ind + "invalidIds\n" ;
        }
        //      C# -> List<ManagedObjectSlaInfo>? ObjectsWithNoOp
        // GraphQL -> objectsWithNoOp: [ManagedObjectSlaInfo!]! (type)
        if (this.ObjectsWithNoOp != null) {
            var fspec = this.ObjectsWithNoOp.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "objectsWithNoOp {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp
        // GraphQL -> objectsWithPendingOp: [ManagedObjectPendingSlaInfo!]! (type)
        if (this.ObjectsWithPendingOp != null) {
            var fspec = this.ObjectsWithPendingOp.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "objectsWithPendingOp {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? InvalidIds
        // GraphQL -> invalidIds: [String!]! (scalar)
        if (this.InvalidIds == null && ec.Includes("invalidIds",true))
        {
            this.InvalidIds = new List<System.String>();
        }
        //      C# -> List<ManagedObjectSlaInfo>? ObjectsWithNoOp
        // GraphQL -> objectsWithNoOp: [ManagedObjectSlaInfo!]! (type)
        if (this.ObjectsWithNoOp == null && ec.Includes("objectsWithNoOp",false))
        {
            this.ObjectsWithNoOp = new List<ManagedObjectSlaInfo>();
            this.ObjectsWithNoOp.ApplyExploratoryFieldSpec(ec.NewChild("objectsWithNoOp"));
        }
        //      C# -> List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp
        // GraphQL -> objectsWithPendingOp: [ManagedObjectPendingSlaInfo!]! (type)
        if (this.ObjectsWithPendingOp == null && ec.Includes("objectsWithPendingOp",false))
        {
            this.ObjectsWithPendingOp = new List<ManagedObjectPendingSlaInfo>();
            this.ObjectsWithPendingOp.ApplyExploratoryFieldSpec(ec.NewChild("objectsWithPendingOp"));
        }
    }


    #endregion

    } // class GetPendingSlaAssignmentsReply
    
    #endregion

    public static class ListGetPendingSlaAssignmentsReplyExtensions
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
            this List<GetPendingSlaAssignmentsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetPendingSlaAssignmentsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPendingSlaAssignmentsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GetPendingSlaAssignmentsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
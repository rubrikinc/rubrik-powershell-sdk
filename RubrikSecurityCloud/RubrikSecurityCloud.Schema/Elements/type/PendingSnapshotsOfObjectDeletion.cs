// PendingSnapshotsOfObjectDeletion.cs
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
    #region PendingSnapshotsOfObjectDeletion
    public class PendingSnapshotsOfObjectDeletion: BaseType
    {
        #region members

        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        [JsonProperty("status")]
        public PendingActionStatus? Status { get; set; }

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }


        #endregion

    #region methods

    public PendingSnapshotsOfObjectDeletion Set(
        PendingActionStatus? Status = null,
        System.String? ObjectFid = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
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
        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid != null) {
            s += ind + "objectFid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new PendingActionStatus();
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid == null && Exploration.Includes(parent + ".objectFid", true))
        {
            this.ObjectFid = "FETCH";
        }
    }


    #endregion

    } // class PendingSnapshotsOfObjectDeletion
    
    #endregion

    public static class ListPendingSnapshotsOfObjectDeletionExtensions
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
            this List<PendingSnapshotsOfObjectDeletion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PendingSnapshotsOfObjectDeletion> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PendingSnapshotsOfObjectDeletion());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
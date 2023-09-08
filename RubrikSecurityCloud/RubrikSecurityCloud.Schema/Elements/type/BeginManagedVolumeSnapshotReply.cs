// BeginManagedVolumeSnapshotReply.cs
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
    #region BeginManagedVolumeSnapshotReply
    public class BeginManagedVolumeSnapshotReply: BaseType
    {
        #region members

        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String (scalar)
        [JsonProperty("ownerId")]
        public System.String? OwnerId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BeginManagedVolumeSnapshotReply";
    }

    public BeginManagedVolumeSnapshotReply Set(
        System.String? OwnerId = null,
        System.String? SnapshotId = null,
        AsyncRequestStatus? AsyncRequestStatus = null
    ) 
    {
        if ( OwnerId != null ) {
            this.OwnerId = OwnerId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
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
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String (scalar)
        if (this.OwnerId != null) {
            s += ind + "ownerId\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            var fspec = this.AsyncRequestStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "asyncRequestStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String (scalar)
        if (this.OwnerId == null && ec.Includes("ownerId",true))
        {
            this.OwnerId = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus == null && ec.Includes("asyncRequestStatus",false))
        {
            this.AsyncRequestStatus = new AsyncRequestStatus();
            this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));
        }
    }


    #endregion

    } // class BeginManagedVolumeSnapshotReply
    
    #endregion

    public static class ListBeginManagedVolumeSnapshotReplyExtensions
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
            this List<BeginManagedVolumeSnapshotReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BeginManagedVolumeSnapshotReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BeginManagedVolumeSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BeginManagedVolumeSnapshotReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// EndManagedVolumeSnapshotReply.cs
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
    #region EndManagedVolumeSnapshotReply
    public class EndManagedVolumeSnapshotReply: BaseType
    {
        #region members

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
        // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
        [JsonProperty("managedVolumeSnapshotSummary")]
        public ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EndManagedVolumeSnapshotReply";
    }

    public EndManagedVolumeSnapshotReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( ManagedVolumeSnapshotSummary != null ) {
            this.ManagedVolumeSnapshotSummary = ManagedVolumeSnapshotSummary;
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
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            var fspec = this.AsyncRequestStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "asyncRequestStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
        // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
        if (this.ManagedVolumeSnapshotSummary != null) {
            var fspec = this.ManagedVolumeSnapshotSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "managedVolumeSnapshotSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus == null && ec.Includes("asyncRequestStatus",false))
        {
            this.AsyncRequestStatus = new AsyncRequestStatus();
            this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));
        }
        //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
        // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
        if (this.ManagedVolumeSnapshotSummary == null && ec.Includes("managedVolumeSnapshotSummary",false))
        {
            this.ManagedVolumeSnapshotSummary = new ManagedVolumeSnapshotSummary();
            this.ManagedVolumeSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeSnapshotSummary"));
        }
    }


    #endregion

    } // class EndManagedVolumeSnapshotReply
    
    #endregion

    public static class ListEndManagedVolumeSnapshotReplyExtensions
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
            this List<EndManagedVolumeSnapshotReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EndManagedVolumeSnapshotReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EndManagedVolumeSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EndManagedVolumeSnapshotReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
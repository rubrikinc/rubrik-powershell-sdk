// ManagedVolumeSnapshotSummary.cs
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
    #region ManagedVolumeSnapshotSummary
    public class ManagedVolumeSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsQueuedSnapshot
        // GraphQL -> isQueuedSnapshot: Boolean (scalar)
        [JsonProperty("isQueuedSnapshot")]
        public System.Boolean? IsQueuedSnapshot { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }

        //      C# -> ManagedVolumeSnapshotLinks? Links
        // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
        [JsonProperty("links")]
        public ManagedVolumeSnapshotLinks? Links { get; set; }


        #endregion

    #region methods

    public ManagedVolumeSnapshotSummary Set(
        System.Boolean? IsQueuedSnapshot = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null,
        ManagedVolumeSnapshotLinks? Links = null
    ) 
    {
        if ( IsQueuedSnapshot != null ) {
            this.IsQueuedSnapshot = IsQueuedSnapshot;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
        }
        if ( Links != null ) {
            this.Links = Links;
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
        //      C# -> System.Boolean? IsQueuedSnapshot
        // GraphQL -> isQueuedSnapshot: Boolean (scalar)
        if (this.IsQueuedSnapshot != null) {
            s += ind + "isQueuedSnapshot\n" ;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "baseSnapshotSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeSnapshotLinks? Links
        // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
        if (this.Links != null) {
            var fspec = this.Links.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "links {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsQueuedSnapshot
        // GraphQL -> isQueuedSnapshot: Boolean (scalar)
        if (this.IsQueuedSnapshot == null && Exploration.Includes(parent + ".isQueuedSnapshot", true))
        {
            this.IsQueuedSnapshot = true;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary == null && Exploration.Includes(parent + ".baseSnapshotSummary"))
        {
            this.BaseSnapshotSummary = new BaseSnapshotSummary();
            this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(parent + ".baseSnapshotSummary");
        }
        //      C# -> ManagedVolumeSnapshotLinks? Links
        // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
        if (this.Links == null && Exploration.Includes(parent + ".links"))
        {
            this.Links = new ManagedVolumeSnapshotLinks();
            this.Links.ApplyExploratoryFieldSpec(parent + ".links");
        }
    }


    #endregion

    } // class ManagedVolumeSnapshotSummary
    
    #endregion

    public static class ListManagedVolumeSnapshotSummaryExtensions
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
            this List<ManagedVolumeSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSnapshotSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
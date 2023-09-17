// ManagedVolumeSnapshotLinks.cs
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
    #region ManagedVolumeSnapshotLinks
    public class ManagedVolumeSnapshotLinks: BaseType
    {
        #region members

        //      C# -> Link? ExportLink
        // GraphQL -> exportLink: Link (type)
        [JsonProperty("exportLink")]
        public Link? ExportLink { get; set; }

        //      C# -> Link? Self
        // GraphQL -> self: Link (type)
        [JsonProperty("self")]
        public Link? Self { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeSnapshotLinks";
    }

    public ManagedVolumeSnapshotLinks Set(
        Link? ExportLink = null,
        Link? Self = null
    ) 
    {
        if ( ExportLink != null ) {
            this.ExportLink = ExportLink;
        }
        if ( Self != null ) {
            this.Self = Self;
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
        //      C# -> Link? ExportLink
        // GraphQL -> exportLink: Link (type)
        if (this.ExportLink != null) {
            var fspec = this.ExportLink.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "exportLink {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Link? Self
        // GraphQL -> self: Link (type)
        if (this.Self != null) {
            var fspec = this.Self.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "self {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Link? ExportLink
        // GraphQL -> exportLink: Link (type)
        if (this.ExportLink == null && ec.Includes("exportLink",false))
        {
            this.ExportLink = new Link();
            this.ExportLink.ApplyExploratoryFieldSpec(ec.NewChild("exportLink"));
        }
        //      C# -> Link? Self
        // GraphQL -> self: Link (type)
        if (this.Self == null && ec.Includes("self",false))
        {
            this.Self = new Link();
            this.Self.ApplyExploratoryFieldSpec(ec.NewChild("self"));
        }
    }


    #endregion

    } // class ManagedVolumeSnapshotLinks
    
    #endregion

    public static class ListManagedVolumeSnapshotLinksExtensions
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
            this List<ManagedVolumeSnapshotLinks> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSnapshotLinks> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSnapshotLinks());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSnapshotLinks> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
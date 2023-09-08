// ItemSnapshot.cs
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
    #region ItemSnapshot
    public class ItemSnapshot: BaseType
    {
        #region members

        //      C# -> Item? Item
        // GraphQL -> item: Item! (type)
        [JsonProperty("item")]
        public Item? Item { get; set; }

        //      C# -> SaasAppSnapshot? Snapshot
        // GraphQL -> snapshot: SaasAppSnapshot (type)
        [JsonProperty("snapshot")]
        public SaasAppSnapshot? Snapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ItemSnapshot";
    }

    public ItemSnapshot Set(
        Item? Item = null,
        SaasAppSnapshot? Snapshot = null
    ) 
    {
        if ( Item != null ) {
            this.Item = Item;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
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
        //      C# -> Item? Item
        // GraphQL -> item: Item! (type)
        if (this.Item != null) {
            var fspec = this.Item.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "item {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SaasAppSnapshot? Snapshot
        // GraphQL -> snapshot: SaasAppSnapshot (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Item? Item
        // GraphQL -> item: Item! (type)
        if (this.Item == null && ec.Includes("item",false))
        {
            this.Item = new Item();
            this.Item.ApplyExploratoryFieldSpec(ec.NewChild("item"));
        }
        //      C# -> SaasAppSnapshot? Snapshot
        // GraphQL -> snapshot: SaasAppSnapshot (type)
        if (this.Snapshot == null && ec.Includes("snapshot",false))
        {
            this.Snapshot = new SaasAppSnapshot();
            this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));
        }
    }


    #endregion

    } // class ItemSnapshot
    
    #endregion

    public static class ListItemSnapshotExtensions
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
            this List<ItemSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ItemSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ItemSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ItemSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// BulkRefreshHostsReply.cs
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
    #region BulkRefreshHostsReply
    public class BulkRefreshHostsReply: BaseType
    {
        #region members

        //      C# -> List<RefreshHostReply>? Data
        // GraphQL -> data: [RefreshHostReply!]! (type)
        [JsonProperty("data")]
        public List<RefreshHostReply>? Data { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkRefreshHostsReply";
    }

    public BulkRefreshHostsReply Set(
        List<RefreshHostReply>? Data = null
    ) 
    {
        if ( Data != null ) {
            this.Data = Data;
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
        //      C# -> List<RefreshHostReply>? Data
        // GraphQL -> data: [RefreshHostReply!]! (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "data {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RefreshHostReply>? Data
        // GraphQL -> data: [RefreshHostReply!]! (type)
        if (this.Data == null && ec.Includes("data",false))
        {
            this.Data = new List<RefreshHostReply>();
            this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));
        }
    }


    #endregion

    } // class BulkRefreshHostsReply
    
    #endregion

    public static class ListBulkRefreshHostsReplyExtensions
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
            this List<BulkRefreshHostsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BulkRefreshHostsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRefreshHostsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BulkRefreshHostsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
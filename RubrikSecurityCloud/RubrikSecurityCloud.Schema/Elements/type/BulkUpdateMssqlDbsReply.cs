// BulkUpdateMssqlDbsReply.cs
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
    #region BulkUpdateMssqlDbsReply
    public class BulkUpdateMssqlDbsReply: BaseType
    {
        #region members

        //      C# -> List<MssqlDbDetail>? Items
        // GraphQL -> items: [MssqlDbDetail!]! (type)
        [JsonProperty("items")]
        public List<MssqlDbDetail>? Items { get; set; }


        #endregion

    #region methods

    public BulkUpdateMssqlDbsReply Set(
        List<MssqlDbDetail>? Items = null
    ) 
    {
        if ( Items != null ) {
            this.Items = Items;
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
        //      C# -> List<MssqlDbDetail>? Items
        // GraphQL -> items: [MssqlDbDetail!]! (type)
        if (this.Items != null) {
            var fspec = this.Items.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "items {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<MssqlDbDetail>? Items
        // GraphQL -> items: [MssqlDbDetail!]! (type)
        if (this.Items == null && Exploration.Includes(parent + ".items"))
        {
            this.Items = new List<MssqlDbDetail>();
            this.Items.ApplyExploratoryFieldSpec(parent + ".items");
        }
    }


    #endregion

    } // class BulkUpdateMssqlDbsReply
    
    #endregion

    public static class ListBulkUpdateMssqlDbsReplyExtensions
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
            this List<BulkUpdateMssqlDbsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BulkUpdateMssqlDbsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkUpdateMssqlDbsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
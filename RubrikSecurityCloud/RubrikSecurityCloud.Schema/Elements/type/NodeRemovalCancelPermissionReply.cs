// NodeRemovalCancelPermissionReply.cs
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
    #region NodeRemovalCancelPermissionReply
    public class NodeRemovalCancelPermissionReply: BaseType
    {
        #region members

        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean! (scalar)
        [JsonProperty("isCancelable")]
        public System.Boolean? IsCancelable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodeRemovalCancelPermissionReply";
    }

    public NodeRemovalCancelPermissionReply Set(
        System.String? EventSeriesId = null,
        System.Boolean? IsCancelable = null
    ) 
    {
        if ( EventSeriesId != null ) {
            this.EventSeriesId = EventSeriesId;
        }
        if ( IsCancelable != null ) {
            this.IsCancelable = IsCancelable;
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
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (this.EventSeriesId != null) {
            s += ind + "eventSeriesId\n" ;
        }
        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean! (scalar)
        if (this.IsCancelable != null) {
            s += ind + "isCancelable\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (this.EventSeriesId == null && Exploration.Includes(parent + ".eventSeriesId", true))
        {
            this.EventSeriesId = "FETCH";
        }
        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean! (scalar)
        if (this.IsCancelable == null && Exploration.Includes(parent + ".isCancelable", true))
        {
            this.IsCancelable = true;
        }
    }


    #endregion

    } // class NodeRemovalCancelPermissionReply
    
    #endregion

    public static class ListNodeRemovalCancelPermissionReplyExtensions
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
            this List<NodeRemovalCancelPermissionReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NodeRemovalCancelPermissionReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeRemovalCancelPermissionReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
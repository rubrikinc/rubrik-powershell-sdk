// RemoveVlansReply.cs
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
    #region RemoveVlansReply
    public class RemoveVlansReply: BaseType
    {
        #region members

        //      C# -> List<System.Int32>? FailureVlanIds
        // GraphQL -> failureVlanIds: [Int!]! (scalar)
        [JsonProperty("failureVlanIds")]
        public List<System.Int32>? FailureVlanIds { get; set; }

        //      C# -> List<System.Int32>? SuccessVlanIds
        // GraphQL -> successVlanIds: [Int!]! (scalar)
        [JsonProperty("successVlanIds")]
        public List<System.Int32>? SuccessVlanIds { get; set; }


        #endregion

    #region methods

    public RemoveVlansReply Set(
        List<System.Int32>? FailureVlanIds = null,
        List<System.Int32>? SuccessVlanIds = null
    ) 
    {
        if ( FailureVlanIds != null ) {
            this.FailureVlanIds = FailureVlanIds;
        }
        if ( SuccessVlanIds != null ) {
            this.SuccessVlanIds = SuccessVlanIds;
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
        //      C# -> List<System.Int32>? FailureVlanIds
        // GraphQL -> failureVlanIds: [Int!]! (scalar)
        if (this.FailureVlanIds != null) {
            s += ind + "failureVlanIds\n" ;
        }
        //      C# -> List<System.Int32>? SuccessVlanIds
        // GraphQL -> successVlanIds: [Int!]! (scalar)
        if (this.SuccessVlanIds != null) {
            s += ind + "successVlanIds\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.Int32>? FailureVlanIds
        // GraphQL -> failureVlanIds: [Int!]! (scalar)
        if (this.FailureVlanIds == null && Exploration.Includes(parent + ".failureVlanIds", true))
        {
            this.FailureVlanIds = new List<System.Int32>();
        }
        //      C# -> List<System.Int32>? SuccessVlanIds
        // GraphQL -> successVlanIds: [Int!]! (scalar)
        if (this.SuccessVlanIds == null && Exploration.Includes(parent + ".successVlanIds", true))
        {
            this.SuccessVlanIds = new List<System.Int32>();
        }
    }


    #endregion

    } // class RemoveVlansReply
    
    #endregion

    public static class ListRemoveVlansReplyExtensions
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
            this List<RemoveVlansReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RemoveVlansReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RemoveVlansReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
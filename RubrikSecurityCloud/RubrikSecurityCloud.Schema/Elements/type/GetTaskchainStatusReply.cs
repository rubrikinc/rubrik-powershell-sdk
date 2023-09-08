// GetTaskchainStatusReply.cs
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
    #region GetTaskchainStatusReply
    public class GetTaskchainStatusReply: BaseType
    {
        #region members

        //      C# -> Taskchain? Taskchain
        // GraphQL -> taskchain: Taskchain (type)
        [JsonProperty("taskchain")]
        public Taskchain? Taskchain { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetTaskchainStatusReply";
    }

    public GetTaskchainStatusReply Set(
        Taskchain? Taskchain = null
    ) 
    {
        if ( Taskchain != null ) {
            this.Taskchain = Taskchain;
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
        //      C# -> Taskchain? Taskchain
        // GraphQL -> taskchain: Taskchain (type)
        if (this.Taskchain != null) {
            var fspec = this.Taskchain.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "taskchain {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Taskchain? Taskchain
        // GraphQL -> taskchain: Taskchain (type)
        if (this.Taskchain == null && ec.Includes("taskchain",false))
        {
            this.Taskchain = new Taskchain();
            this.Taskchain.ApplyExploratoryFieldSpec(ec.NewChild("taskchain"));
        }
    }


    #endregion

    } // class GetTaskchainStatusReply
    
    #endregion

    public static class ListGetTaskchainStatusReplyExtensions
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
            this List<GetTaskchainStatusReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetTaskchainStatusReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetTaskchainStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GetTaskchainStatusReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
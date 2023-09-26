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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> Taskchain? Taskchain
        // GraphQL -> taskchain: Taskchain (type)
        if (this.Taskchain != null) {
            var fspec = this.Taskchain.AsFieldSpec(conf.Child("taskchain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "taskchain {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Taskchain? Taskchain
        // GraphQL -> taskchain: Taskchain (type)
        if (ec.Includes("taskchain",false))
        {
            if(this.Taskchain == null) {

                this.Taskchain = new Taskchain();
                this.Taskchain.ApplyExploratoryFieldSpec(ec.NewChild("taskchain"));

            } else {

                this.Taskchain.ApplyExploratoryFieldSpec(ec.NewChild("taskchain"));

            }
        }
        else if (this.Taskchain != null && ec.Excludes("taskchain",false))
        {
            this.Taskchain = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<GetTaskchainStatusReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
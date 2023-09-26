// NodeToReplaceReply.cs
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
    #region NodeToReplaceReply
    public class NodeToReplaceReply: BaseType
    {
        #region members

        //      C# -> System.String? NodeToReplace
        // GraphQL -> nodeToReplace: String! (scalar)
        [JsonProperty("nodeToReplace")]
        public System.String? NodeToReplace { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodeToReplaceReply";
    }

    public NodeToReplaceReply Set(
        System.String? NodeToReplace = null
    ) 
    {
        if ( NodeToReplace != null ) {
            this.NodeToReplace = NodeToReplace;
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
        //      C# -> System.String? NodeToReplace
        // GraphQL -> nodeToReplace: String! (scalar)
        if (this.NodeToReplace != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeToReplace\n" ;
            } else {
                s += ind + "nodeToReplace\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? NodeToReplace
        // GraphQL -> nodeToReplace: String! (scalar)
        if (ec.Includes("nodeToReplace",true))
        {
            if(this.NodeToReplace == null) {

                this.NodeToReplace = "FETCH";

            } else {


            }
        }
        else if (this.NodeToReplace != null && ec.Excludes("nodeToReplace",true))
        {
            this.NodeToReplace = null;
        }
    }


    #endregion

    } // class NodeToReplaceReply
    
    #endregion

    public static class ListNodeToReplaceReplyExtensions
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
            this List<NodeToReplaceReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NodeToReplaceReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeToReplaceReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NodeToReplaceReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
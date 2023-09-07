// BulkDeleteAwsCloudAccountWithoutCftReply.cs
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
    #region BulkDeleteAwsCloudAccountWithoutCftReply
    public class BulkDeleteAwsCloudAccountWithoutCftReply: BaseType
    {
        #region members

        //      C# -> List<DeleteAwsCloudAccountWithoutCftResp>? DeleteAwsCloudAccountWithoutCftResp
        // GraphQL -> deleteAwsCloudAccountWithoutCftResp: [DeleteAwsCloudAccountWithoutCftResp!]! (type)
        [JsonProperty("deleteAwsCloudAccountWithoutCftResp")]
        public List<DeleteAwsCloudAccountWithoutCftResp>? DeleteAwsCloudAccountWithoutCftResp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkDeleteAwsCloudAccountWithoutCftReply";
    }

    public BulkDeleteAwsCloudAccountWithoutCftReply Set(
        List<DeleteAwsCloudAccountWithoutCftResp>? DeleteAwsCloudAccountWithoutCftResp = null
    ) 
    {
        if ( DeleteAwsCloudAccountWithoutCftResp != null ) {
            this.DeleteAwsCloudAccountWithoutCftResp = DeleteAwsCloudAccountWithoutCftResp;
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
        //      C# -> List<DeleteAwsCloudAccountWithoutCftResp>? DeleteAwsCloudAccountWithoutCftResp
        // GraphQL -> deleteAwsCloudAccountWithoutCftResp: [DeleteAwsCloudAccountWithoutCftResp!]! (type)
        if (this.DeleteAwsCloudAccountWithoutCftResp != null) {
            var fspec = this.DeleteAwsCloudAccountWithoutCftResp.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "deleteAwsCloudAccountWithoutCftResp {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DeleteAwsCloudAccountWithoutCftResp>? DeleteAwsCloudAccountWithoutCftResp
        // GraphQL -> deleteAwsCloudAccountWithoutCftResp: [DeleteAwsCloudAccountWithoutCftResp!]! (type)
        if (this.DeleteAwsCloudAccountWithoutCftResp == null && ec.Includes("deleteAwsCloudAccountWithoutCftResp",false))
        {
            this.DeleteAwsCloudAccountWithoutCftResp = new List<DeleteAwsCloudAccountWithoutCftResp>();
            this.DeleteAwsCloudAccountWithoutCftResp.ApplyExploratoryFieldSpec(ec.NewChild("deleteAwsCloudAccountWithoutCftResp"));
        }
    }


    #endregion

    } // class BulkDeleteAwsCloudAccountWithoutCftReply
    
    #endregion

    public static class ListBulkDeleteAwsCloudAccountWithoutCftReplyExtensions
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
            this List<BulkDeleteAwsCloudAccountWithoutCftReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BulkDeleteAwsCloudAccountWithoutCftReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkDeleteAwsCloudAccountWithoutCftReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BulkDeleteAwsCloudAccountWithoutCftReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// GetCloudNativeTagRulesReply.cs
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
    #region GetCloudNativeTagRulesReply
    public class GetCloudNativeTagRulesReply: BaseType
    {
        #region members

        //      C# -> List<CloudNativeTagRule>? TagRules
        // GraphQL -> tagRules: [CloudNativeTagRule!]! (type)
        [JsonProperty("tagRules")]
        public List<CloudNativeTagRule>? TagRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetCloudNativeTagRulesReply";
    }

    public GetCloudNativeTagRulesReply Set(
        List<CloudNativeTagRule>? TagRules = null
    ) 
    {
        if ( TagRules != null ) {
            this.TagRules = TagRules;
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
        //      C# -> List<CloudNativeTagRule>? TagRules
        // GraphQL -> tagRules: [CloudNativeTagRule!]! (type)
        if (this.TagRules != null) {
            var fspec = this.TagRules.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tagRules {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CloudNativeTagRule>? TagRules
        // GraphQL -> tagRules: [CloudNativeTagRule!]! (type)
        if (this.TagRules == null && ec.Includes("tagRules",false))
        {
            this.TagRules = new List<CloudNativeTagRule>();
            this.TagRules.ApplyExploratoryFieldSpec(ec.NewChild("tagRules"));
        }
    }


    #endregion

    } // class GetCloudNativeTagRulesReply
    
    #endregion

    public static class ListGetCloudNativeTagRulesReplyExtensions
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
            this List<GetCloudNativeTagRulesReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetCloudNativeTagRulesReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetCloudNativeTagRulesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetCloudNativeTagRulesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
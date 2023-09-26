// GetCloudNativeLabelRulesReply.cs
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
    #region GetCloudNativeLabelRulesReply
    public class GetCloudNativeLabelRulesReply: BaseType
    {
        #region members

        //      C# -> List<LabelRule>? LabelRules
        // GraphQL -> labelRules: [LabelRule!]! (type)
        [JsonProperty("labelRules")]
        public List<LabelRule>? LabelRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetCloudNativeLabelRulesReply";
    }

    public GetCloudNativeLabelRulesReply Set(
        List<LabelRule>? LabelRules = null
    ) 
    {
        if ( LabelRules != null ) {
            this.LabelRules = LabelRules;
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
        //      C# -> List<LabelRule>? LabelRules
        // GraphQL -> labelRules: [LabelRule!]! (type)
        if (this.LabelRules != null) {
            var fspec = this.LabelRules.AsFieldSpec(conf.Child("labelRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "labelRules {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<LabelRule>? LabelRules
        // GraphQL -> labelRules: [LabelRule!]! (type)
        if (ec.Includes("labelRules",false))
        {
            if(this.LabelRules == null) {

                this.LabelRules = new List<LabelRule>();
                this.LabelRules.ApplyExploratoryFieldSpec(ec.NewChild("labelRules"));

            } else {

                this.LabelRules.ApplyExploratoryFieldSpec(ec.NewChild("labelRules"));

            }
        }
        else if (this.LabelRules != null && ec.Excludes("labelRules",false))
        {
            this.LabelRules = null;
        }
    }


    #endregion

    } // class GetCloudNativeLabelRulesReply
    
    #endregion

    public static class ListGetCloudNativeLabelRulesReplyExtensions
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
            this List<GetCloudNativeLabelRulesReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetCloudNativeLabelRulesReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetCloudNativeLabelRulesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetCloudNativeLabelRulesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
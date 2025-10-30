// ClassificationPreview.cs
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
    #region ClassificationPreview
    public class ClassificationPreview: BaseType
    {
        #region members

        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        [JsonProperty("analyzerId")]
        public System.String? AnalyzerId { get; set; }

        //      C# -> System.Int32? EndIdx
        // GraphQL -> endIdx: Int! (scalar)
        [JsonProperty("endIdx")]
        public System.Int32? EndIdx { get; set; }

        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!]! (scalar)
        [JsonProperty("policyIds")]
        public List<System.String>? PolicyIds { get; set; }

        //      C# -> System.Int32? StartIdx
        // GraphQL -> startIdx: Int! (scalar)
        [JsonProperty("startIdx")]
        public System.Int32? StartIdx { get; set; }

        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        [JsonProperty("text")]
        public System.String? Text { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClassificationPreview";
    }

    public ClassificationPreview Set(
        System.String? AnalyzerId = null,
        System.Int32? EndIdx = null,
        List<System.String>? PolicyIds = null,
        System.Int32? StartIdx = null,
        System.String? Text = null
    ) 
    {
        if ( AnalyzerId != null ) {
            this.AnalyzerId = AnalyzerId;
        }
        if ( EndIdx != null ) {
            this.EndIdx = EndIdx;
        }
        if ( PolicyIds != null ) {
            this.PolicyIds = PolicyIds;
        }
        if ( StartIdx != null ) {
            this.StartIdx = StartIdx;
        }
        if ( Text != null ) {
            this.Text = Text;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        if (this.AnalyzerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzerId\n" ;
            } else {
                s += ind + "analyzerId\n" ;
            }
        }
        //      C# -> System.Int32? EndIdx
        // GraphQL -> endIdx: Int! (scalar)
        if (this.EndIdx != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endIdx\n" ;
            } else {
                s += ind + "endIdx\n" ;
            }
        }
        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!]! (scalar)
        if (this.PolicyIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyIds\n" ;
            } else {
                s += ind + "policyIds\n" ;
            }
        }
        //      C# -> System.Int32? StartIdx
        // GraphQL -> startIdx: Int! (scalar)
        if (this.StartIdx != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startIdx\n" ;
            } else {
                s += ind + "startIdx\n" ;
            }
        }
        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        if (this.Text != null) {
            if (conf.Flat) {
                s += conf.Prefix + "text\n" ;
            } else {
                s += ind + "text\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        if (ec.Includes("analyzerId",true))
        {
            if(this.AnalyzerId == null) {

                this.AnalyzerId = "FETCH";

            } else {


            }
        }
        else if (this.AnalyzerId != null && ec.Excludes("analyzerId",true))
        {
            this.AnalyzerId = null;
        }
        //      C# -> System.Int32? EndIdx
        // GraphQL -> endIdx: Int! (scalar)
        if (ec.Includes("endIdx",true))
        {
            if(this.EndIdx == null) {

                this.EndIdx = Int32.MinValue;

            } else {


            }
        }
        else if (this.EndIdx != null && ec.Excludes("endIdx",true))
        {
            this.EndIdx = null;
        }
        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!]! (scalar)
        if (ec.Includes("policyIds",true))
        {
            if(this.PolicyIds == null) {

                this.PolicyIds = new List<System.String>();

            } else {


            }
        }
        else if (this.PolicyIds != null && ec.Excludes("policyIds",true))
        {
            this.PolicyIds = null;
        }
        //      C# -> System.Int32? StartIdx
        // GraphQL -> startIdx: Int! (scalar)
        if (ec.Includes("startIdx",true))
        {
            if(this.StartIdx == null) {

                this.StartIdx = Int32.MinValue;

            } else {


            }
        }
        else if (this.StartIdx != null && ec.Excludes("startIdx",true))
        {
            this.StartIdx = null;
        }
        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        if (ec.Includes("text",true))
        {
            if(this.Text == null) {

                this.Text = "FETCH";

            } else {


            }
        }
        else if (this.Text != null && ec.Excludes("text",true))
        {
            this.Text = null;
        }
    }


    #endregion

    } // class ClassificationPreview
    
    #endregion

    public static class ListClassificationPreviewExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ClassificationPreview> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClassificationPreview> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClassificationPreview> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClassificationPreview());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClassificationPreview> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
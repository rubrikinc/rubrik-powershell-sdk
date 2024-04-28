// ContentNode.cs
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
    #region ContentNode
    public class ContentNode: BaseType
    {
        #region members

        //      C# -> System.Int32? Index
        // GraphQL -> index: Int (scalar)
        [JsonProperty("index")]
        public System.Int32? Index { get; set; }

        //      C# -> System.Int32? ParentIndex
        // GraphQL -> parentIndex: Int (scalar)
        [JsonProperty("parentIndex")]
        public System.Int32? ParentIndex { get; set; }

        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        [JsonProperty("tag")]
        public System.String? Tag { get; set; }

        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        [JsonProperty("text")]
        public System.String? Text { get; set; }

        //      C# -> List<ContentNodeAttribute>? Attributes
        // GraphQL -> attributes: [ContentNodeAttribute!]! (type)
        [JsonProperty("attributes")]
        public List<ContentNodeAttribute>? Attributes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ContentNode";
    }

    public ContentNode Set(
        System.Int32? Index = null,
        System.Int32? ParentIndex = null,
        System.String? Tag = null,
        System.String? Text = null,
        List<ContentNodeAttribute>? Attributes = null
    ) 
    {
        if ( Index != null ) {
            this.Index = Index;
        }
        if ( ParentIndex != null ) {
            this.ParentIndex = ParentIndex;
        }
        if ( Tag != null ) {
            this.Tag = Tag;
        }
        if ( Text != null ) {
            this.Text = Text;
        }
        if ( Attributes != null ) {
            this.Attributes = Attributes;
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
        //      C# -> System.Int32? Index
        // GraphQL -> index: Int (scalar)
        if (this.Index != null) {
            if (conf.Flat) {
                s += conf.Prefix + "index\n" ;
            } else {
                s += ind + "index\n" ;
            }
        }
        //      C# -> System.Int32? ParentIndex
        // GraphQL -> parentIndex: Int (scalar)
        if (this.ParentIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentIndex\n" ;
            } else {
                s += ind + "parentIndex\n" ;
            }
        }
        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        if (this.Tag != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tag\n" ;
            } else {
                s += ind + "tag\n" ;
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
        //      C# -> List<ContentNodeAttribute>? Attributes
        // GraphQL -> attributes: [ContentNodeAttribute!]! (type)
        if (this.Attributes != null) {
            var fspec = this.Attributes.AsFieldSpec(conf.Child("attributes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "attributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Index
        // GraphQL -> index: Int (scalar)
        if (ec.Includes("index",true))
        {
            if(this.Index == null) {

                this.Index = Int32.MinValue;

            } else {


            }
        }
        else if (this.Index != null && ec.Excludes("index",true))
        {
            this.Index = null;
        }
        //      C# -> System.Int32? ParentIndex
        // GraphQL -> parentIndex: Int (scalar)
        if (ec.Includes("parentIndex",true))
        {
            if(this.ParentIndex == null) {

                this.ParentIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.ParentIndex != null && ec.Excludes("parentIndex",true))
        {
            this.ParentIndex = null;
        }
        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        if (ec.Includes("tag",true))
        {
            if(this.Tag == null) {

                this.Tag = "FETCH";

            } else {


            }
        }
        else if (this.Tag != null && ec.Excludes("tag",true))
        {
            this.Tag = null;
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
        //      C# -> List<ContentNodeAttribute>? Attributes
        // GraphQL -> attributes: [ContentNodeAttribute!]! (type)
        if (ec.Includes("attributes",false))
        {
            if(this.Attributes == null) {

                this.Attributes = new List<ContentNodeAttribute>();
                this.Attributes.ApplyExploratoryFieldSpec(ec.NewChild("attributes"));

            } else {

                this.Attributes.ApplyExploratoryFieldSpec(ec.NewChild("attributes"));

            }
        }
        else if (this.Attributes != null && ec.Excludes("attributes",false))
        {
            this.Attributes = null;
        }
    }


    #endregion

    } // class ContentNode
    
    #endregion

    public static class ListContentNodeExtensions
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
            this List<ContentNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ContentNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ContentNode> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ContentNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ContentNode> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
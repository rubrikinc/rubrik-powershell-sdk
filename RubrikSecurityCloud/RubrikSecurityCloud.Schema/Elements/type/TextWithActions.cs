// TextWithActions.cs
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
    #region TextWithActions
    public class TextWithActions: BaseType
    {
        #region members

        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        [JsonProperty("text")]
        public System.String? Text { get; set; }

        //      C# -> List<TextAction>? Actions
        // GraphQL -> actions: [TextAction!]! (type)
        [JsonProperty("actions")]
        public List<TextAction>? Actions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TextWithActions";
    }

    public TextWithActions Set(
        System.String? Text = null,
        List<TextAction>? Actions = null
    ) 
    {
        if ( Text != null ) {
            this.Text = Text;
        }
        if ( Actions != null ) {
            this.Actions = Actions;
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
        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        if (this.Text != null) {
            if (conf.Flat) {
                s += conf.Prefix + "text\n" ;
            } else {
                s += ind + "text\n" ;
            }
        }
        //      C# -> List<TextAction>? Actions
        // GraphQL -> actions: [TextAction!]! (type)
        if (this.Actions != null) {
            var fspec = this.Actions.AsFieldSpec(conf.Child("actions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "actions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> List<TextAction>? Actions
        // GraphQL -> actions: [TextAction!]! (type)
        if (ec.Includes("actions",false))
        {
            if(this.Actions == null) {

                this.Actions = new List<TextAction>();
                this.Actions.ApplyExploratoryFieldSpec(ec.NewChild("actions"));

            } else {

                this.Actions.ApplyExploratoryFieldSpec(ec.NewChild("actions"));

            }
        }
        else if (this.Actions != null && ec.Excludes("actions",false))
        {
            this.Actions = null;
        }
    }


    #endregion

    } // class TextWithActions
    
    #endregion

    public static class ListTextWithActionsExtensions
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
            this List<TextWithActions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TextWithActions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TextWithActions> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TextWithActions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TextWithActions> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// AnnapurnaChatAttributesValue.cs
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
    #region AnnapurnaChatAttributesValue
    public class AnnapurnaChatAttributesValue: BaseType
    {
        #region members

        //      C# -> System.String? ChatbotId
        // GraphQL -> chatbotId: String! (scalar)
        [JsonProperty("chatbotId")]
        public System.String? ChatbotId { get; set; }

        //      C# -> System.String? ChatbotName
        // GraphQL -> chatbotName: String! (scalar)
        [JsonProperty("chatbotName")]
        public System.String? ChatbotName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnnapurnaChatAttributesValue";
    }

    public AnnapurnaChatAttributesValue Set(
        System.String? ChatbotId = null,
        System.String? ChatbotName = null
    ) 
    {
        if ( ChatbotId != null ) {
            this.ChatbotId = ChatbotId;
        }
        if ( ChatbotName != null ) {
            this.ChatbotName = ChatbotName;
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
        //      C# -> System.String? ChatbotId
        // GraphQL -> chatbotId: String! (scalar)
        if (this.ChatbotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chatbotId\n" ;
            } else {
                s += ind + "chatbotId\n" ;
            }
        }
        //      C# -> System.String? ChatbotName
        // GraphQL -> chatbotName: String! (scalar)
        if (this.ChatbotName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chatbotName\n" ;
            } else {
                s += ind + "chatbotName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ChatbotId
        // GraphQL -> chatbotId: String! (scalar)
        if (ec.Includes("chatbotId",true))
        {
            if(this.ChatbotId == null) {

                this.ChatbotId = "FETCH";

            } else {


            }
        }
        else if (this.ChatbotId != null && ec.Excludes("chatbotId",true))
        {
            this.ChatbotId = null;
        }
        //      C# -> System.String? ChatbotName
        // GraphQL -> chatbotName: String! (scalar)
        if (ec.Includes("chatbotName",true))
        {
            if(this.ChatbotName == null) {

                this.ChatbotName = "FETCH";

            } else {


            }
        }
        else if (this.ChatbotName != null && ec.Excludes("chatbotName",true))
        {
            this.ChatbotName = null;
        }
    }


    #endregion

    } // class AnnapurnaChatAttributesValue
    
    #endregion

    public static class ListAnnapurnaChatAttributesValueExtensions
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
            this List<AnnapurnaChatAttributesValue> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnnapurnaChatAttributesValue> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnnapurnaChatAttributesValue> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnnapurnaChatAttributesValue());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnnapurnaChatAttributesValue> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// Chat.cs
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
    #region Chat
    public class Chat: BaseType
    {
        #region members

        //      C# -> ChatUsage? ChatUsage
        // GraphQL -> chatUsage: ChatUsage! (enum)
        [JsonProperty("chatUsage")]
        public ChatUsage? ChatUsage { get; set; }

        //      C# -> System.String? ChatId
        // GraphQL -> chatId: UUID! (scalar)
        [JsonProperty("chatId")]
        public System.String? ChatId { get; set; }

        //      C# -> System.Boolean? Pinned
        // GraphQL -> pinned: Boolean! (scalar)
        [JsonProperty("pinned")]
        public System.Boolean? Pinned { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> AdditionalAttributes? AdditionalAttributes
        // GraphQL -> additionalAttributes: AdditionalAttributes (type)
        [JsonProperty("additionalAttributes")]
        public AdditionalAttributes? AdditionalAttributes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Chat";
    }

    public Chat Set(
        ChatUsage? ChatUsage = null,
        System.String? ChatId = null,
        System.Boolean? Pinned = null,
        System.String? Title = null,
        DateTime? UpdatedAt = null,
        AdditionalAttributes? AdditionalAttributes = null
    ) 
    {
        if ( ChatUsage != null ) {
            this.ChatUsage = ChatUsage;
        }
        if ( ChatId != null ) {
            this.ChatId = ChatId;
        }
        if ( Pinned != null ) {
            this.Pinned = Pinned;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( AdditionalAttributes != null ) {
            this.AdditionalAttributes = AdditionalAttributes;
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
        //      C# -> ChatUsage? ChatUsage
        // GraphQL -> chatUsage: ChatUsage! (enum)
        if (this.ChatUsage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chatUsage\n" ;
            } else {
                s += ind + "chatUsage\n" ;
            }
        }
        //      C# -> System.String? ChatId
        // GraphQL -> chatId: UUID! (scalar)
        if (this.ChatId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chatId\n" ;
            } else {
                s += ind + "chatId\n" ;
            }
        }
        //      C# -> System.Boolean? Pinned
        // GraphQL -> pinned: Boolean! (scalar)
        if (this.Pinned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pinned\n" ;
            } else {
                s += ind + "pinned\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> AdditionalAttributes? AdditionalAttributes
        // GraphQL -> additionalAttributes: AdditionalAttributes (type)
        if (this.AdditionalAttributes != null) {
            var fspec = this.AdditionalAttributes.AsFieldSpec(conf.Child("additionalAttributes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "additionalAttributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ChatUsage? ChatUsage
        // GraphQL -> chatUsage: ChatUsage! (enum)
        if (ec.Includes("chatUsage",true))
        {
            if(this.ChatUsage == null) {

                this.ChatUsage = new ChatUsage();

            } else {


            }
        }
        else if (this.ChatUsage != null && ec.Excludes("chatUsage",true))
        {
            this.ChatUsage = null;
        }
        //      C# -> System.String? ChatId
        // GraphQL -> chatId: UUID! (scalar)
        if (ec.Includes("chatId",true))
        {
            if(this.ChatId == null) {

                this.ChatId = "FETCH";

            } else {


            }
        }
        else if (this.ChatId != null && ec.Excludes("chatId",true))
        {
            this.ChatId = null;
        }
        //      C# -> System.Boolean? Pinned
        // GraphQL -> pinned: Boolean! (scalar)
        if (ec.Includes("pinned",true))
        {
            if(this.Pinned == null) {

                this.Pinned = true;

            } else {


            }
        }
        else if (this.Pinned != null && ec.Excludes("pinned",true))
        {
            this.Pinned = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
        //      C# -> AdditionalAttributes? AdditionalAttributes
        // GraphQL -> additionalAttributes: AdditionalAttributes (type)
        if (ec.Includes("additionalAttributes",false))
        {
            if(this.AdditionalAttributes == null) {

                this.AdditionalAttributes = new AdditionalAttributes();
                this.AdditionalAttributes.ApplyExploratoryFieldSpec(ec.NewChild("additionalAttributes"));

            } else {

                this.AdditionalAttributes.ApplyExploratoryFieldSpec(ec.NewChild("additionalAttributes"));

            }
        }
        else if (this.AdditionalAttributes != null && ec.Excludes("additionalAttributes",false))
        {
            this.AdditionalAttributes = null;
        }
    }


    #endregion

    } // class Chat
    
    #endregion

    public static class ListChatExtensions
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
            this List<Chat> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Chat> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Chat> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Chat());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Chat> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// CreateChatReply.cs
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
    #region CreateChatReply
    public class CreateChatReply: BaseType
    {
        #region members

        //      C# -> System.String? ChatId
        // GraphQL -> chatId: UUID! (scalar)
        [JsonProperty("chatId")]
        public System.String? ChatId { get; set; }

        //      C# -> List<ChatMessage>? Messages
        // GraphQL -> messages: [ChatMessage!]! (type)
        [JsonProperty("messages")]
        public List<ChatMessage>? Messages { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateChatReply";
    }

    public CreateChatReply Set(
        System.String? ChatId = null,
        List<ChatMessage>? Messages = null
    ) 
    {
        if ( ChatId != null ) {
            this.ChatId = ChatId;
        }
        if ( Messages != null ) {
            this.Messages = Messages;
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
        //      C# -> System.String? ChatId
        // GraphQL -> chatId: UUID! (scalar)
        if (this.ChatId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chatId\n" ;
            } else {
                s += ind + "chatId\n" ;
            }
        }
        //      C# -> List<ChatMessage>? Messages
        // GraphQL -> messages: [ChatMessage!]! (type)
        if (this.Messages != null) {
            var fspec = this.Messages.AsFieldSpec(conf.Child("messages"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "messages" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> List<ChatMessage>? Messages
        // GraphQL -> messages: [ChatMessage!]! (type)
        if (ec.Includes("messages",false))
        {
            if(this.Messages == null) {

                this.Messages = new List<ChatMessage>();
                this.Messages.ApplyExploratoryFieldSpec(ec.NewChild("messages"));

            } else {

                this.Messages.ApplyExploratoryFieldSpec(ec.NewChild("messages"));

            }
        }
        else if (this.Messages != null && ec.Excludes("messages",false))
        {
            this.Messages = null;
        }
    }


    #endregion

    } // class CreateChatReply
    
    #endregion

    public static class ListCreateChatReplyExtensions
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
            this List<CreateChatReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CreateChatReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateChatReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateChatReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateChatReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
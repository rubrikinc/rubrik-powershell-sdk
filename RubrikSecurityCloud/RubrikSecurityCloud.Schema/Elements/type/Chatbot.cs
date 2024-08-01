// Chatbot.cs
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
    #region Chatbot
    public class Chatbot: BaseType
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.Int64? EmbeddingFactoryId
        // GraphQL -> embeddingFactoryId: Long! (scalar)
        [JsonProperty("embeddingFactoryId")]
        public System.Int64? EmbeddingFactoryId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> EmbeddingFactoryFilters? Filters
        // GraphQL -> filters: EmbeddingFactoryFilters (type)
        [JsonProperty("filters")]
        public EmbeddingFactoryFilters? Filters { get; set; }

        //      C# -> List<ChatbotObjectMetadata>? Objects
        // GraphQL -> objects: [ChatbotObjectMetadata!]! (type)
        [JsonProperty("objects")]
        public List<ChatbotObjectMetadata>? Objects { get; set; }

        //      C# -> ChatbotStats? Stats
        // GraphQL -> stats: ChatbotStats (type)
        [JsonProperty("stats")]
        public ChatbotStats? Stats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Chatbot";
    }

    public Chatbot Set(
        System.String? Description = null,
        System.Int64? EmbeddingFactoryId = null,
        System.String? Id = null,
        System.String? Name = null,
        EmbeddingFactoryFilters? Filters = null,
        List<ChatbotObjectMetadata>? Objects = null,
        ChatbotStats? Stats = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( EmbeddingFactoryId != null ) {
            this.EmbeddingFactoryId = EmbeddingFactoryId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Filters != null ) {
            this.Filters = Filters;
        }
        if ( Objects != null ) {
            this.Objects = Objects;
        }
        if ( Stats != null ) {
            this.Stats = Stats;
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
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.Int64? EmbeddingFactoryId
        // GraphQL -> embeddingFactoryId: Long! (scalar)
        if (this.EmbeddingFactoryId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "embeddingFactoryId\n" ;
            } else {
                s += ind + "embeddingFactoryId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> EmbeddingFactoryFilters? Filters
        // GraphQL -> filters: EmbeddingFactoryFilters (type)
        if (this.Filters != null) {
            var fspec = this.Filters.AsFieldSpec(conf.Child("filters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ChatbotObjectMetadata>? Objects
        // GraphQL -> objects: [ChatbotObjectMetadata!]! (type)
        if (this.Objects != null) {
            var fspec = this.Objects.AsFieldSpec(conf.Child("objects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ChatbotStats? Stats
        // GraphQL -> stats: ChatbotStats (type)
        if (this.Stats != null) {
            var fspec = this.Stats.AsFieldSpec(conf.Child("stats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "stats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.Int64? EmbeddingFactoryId
        // GraphQL -> embeddingFactoryId: Long! (scalar)
        if (ec.Includes("embeddingFactoryId",true))
        {
            if(this.EmbeddingFactoryId == null) {

                this.EmbeddingFactoryId = new System.Int64();

            } else {


            }
        }
        else if (this.EmbeddingFactoryId != null && ec.Excludes("embeddingFactoryId",true))
        {
            this.EmbeddingFactoryId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> EmbeddingFactoryFilters? Filters
        // GraphQL -> filters: EmbeddingFactoryFilters (type)
        if (ec.Includes("filters",false))
        {
            if(this.Filters == null) {

                this.Filters = new EmbeddingFactoryFilters();
                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            } else {

                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            }
        }
        else if (this.Filters != null && ec.Excludes("filters",false))
        {
            this.Filters = null;
        }
        //      C# -> List<ChatbotObjectMetadata>? Objects
        // GraphQL -> objects: [ChatbotObjectMetadata!]! (type)
        if (ec.Includes("objects",false))
        {
            if(this.Objects == null) {

                this.Objects = new List<ChatbotObjectMetadata>();
                this.Objects.ApplyExploratoryFieldSpec(ec.NewChild("objects"));

            } else {

                this.Objects.ApplyExploratoryFieldSpec(ec.NewChild("objects"));

            }
        }
        else if (this.Objects != null && ec.Excludes("objects",false))
        {
            this.Objects = null;
        }
        //      C# -> ChatbotStats? Stats
        // GraphQL -> stats: ChatbotStats (type)
        if (ec.Includes("stats",false))
        {
            if(this.Stats == null) {

                this.Stats = new ChatbotStats();
                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            } else {

                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            }
        }
        else if (this.Stats != null && ec.Excludes("stats",false))
        {
            this.Stats = null;
        }
    }


    #endregion

    } // class Chatbot
    
    #endregion

    public static class ListChatbotExtensions
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
            this List<Chatbot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Chatbot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Chatbot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Chatbot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Chatbot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
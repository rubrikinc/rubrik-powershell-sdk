// TprReqStatusChange.cs
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
    #region TprReqStatusChange
    public class TprReqStatusChange: BaseType
    {
        #region members

        //      C# -> TprReqOperation? Operation
        // GraphQL -> operation: TprReqOperation! (enum)
        [JsonProperty("operation")]
        public TprReqOperation? Operation { get; set; }

        //      C# -> System.String? AuthorId
        // GraphQL -> authorId: String! (scalar)
        [JsonProperty("authorId")]
        public System.String? AuthorId { get; set; }

        //      C# -> System.String? AuthorName
        // GraphQL -> authorName: String! (scalar)
        [JsonProperty("authorName")]
        public System.String? AuthorName { get; set; }

        //      C# -> List<System.String>? ChangedPolicies
        // GraphQL -> changedPolicies: [String!]! (scalar)
        [JsonProperty("changedPolicies")]
        public List<System.String>? ChangedPolicies { get; set; }

        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        [JsonProperty("comment")]
        public System.String? Comment { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        //      C# -> UserSummary? Author
        // GraphQL -> author: UserSummary (type)
        [JsonProperty("author")]
        public UserSummary? Author { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprReqStatusChange";
    }

    public TprReqStatusChange Set(
        TprReqOperation? Operation = null,
        System.String? AuthorId = null,
        System.String? AuthorName = null,
        List<System.String>? ChangedPolicies = null,
        System.String? Comment = null,
        DateTime? Timestamp = null,
        UserSummary? Author = null
    ) 
    {
        if ( Operation != null ) {
            this.Operation = Operation;
        }
        if ( AuthorId != null ) {
            this.AuthorId = AuthorId;
        }
        if ( AuthorName != null ) {
            this.AuthorName = AuthorName;
        }
        if ( ChangedPolicies != null ) {
            this.ChangedPolicies = ChangedPolicies;
        }
        if ( Comment != null ) {
            this.Comment = Comment;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( Author != null ) {
            this.Author = Author;
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
        //      C# -> TprReqOperation? Operation
        // GraphQL -> operation: TprReqOperation! (enum)
        if (this.Operation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operation\n" ;
            } else {
                s += ind + "operation\n" ;
            }
        }
        //      C# -> System.String? AuthorId
        // GraphQL -> authorId: String! (scalar)
        if (this.AuthorId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorId\n" ;
            } else {
                s += ind + "authorId\n" ;
            }
        }
        //      C# -> System.String? AuthorName
        // GraphQL -> authorName: String! (scalar)
        if (this.AuthorName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorName\n" ;
            } else {
                s += ind + "authorName\n" ;
            }
        }
        //      C# -> List<System.String>? ChangedPolicies
        // GraphQL -> changedPolicies: [String!]! (scalar)
        if (this.ChangedPolicies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "changedPolicies\n" ;
            } else {
                s += ind + "changedPolicies\n" ;
            }
        }
        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        if (this.Comment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "comment\n" ;
            } else {
                s += ind + "comment\n" ;
            }
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        //      C# -> UserSummary? Author
        // GraphQL -> author: UserSummary (type)
        if (this.Author != null) {
            var fspec = this.Author.AsFieldSpec(conf.Child("author"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "author" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TprReqOperation? Operation
        // GraphQL -> operation: TprReqOperation! (enum)
        if (ec.Includes("operation",true))
        {
            if(this.Operation == null) {

                this.Operation = new TprReqOperation();

            } else {


            }
        }
        else if (this.Operation != null && ec.Excludes("operation",true))
        {
            this.Operation = null;
        }
        //      C# -> System.String? AuthorId
        // GraphQL -> authorId: String! (scalar)
        if (ec.Includes("authorId",true))
        {
            if(this.AuthorId == null) {

                this.AuthorId = "FETCH";

            } else {


            }
        }
        else if (this.AuthorId != null && ec.Excludes("authorId",true))
        {
            this.AuthorId = null;
        }
        //      C# -> System.String? AuthorName
        // GraphQL -> authorName: String! (scalar)
        if (ec.Includes("authorName",true))
        {
            if(this.AuthorName == null) {

                this.AuthorName = "FETCH";

            } else {


            }
        }
        else if (this.AuthorName != null && ec.Excludes("authorName",true))
        {
            this.AuthorName = null;
        }
        //      C# -> List<System.String>? ChangedPolicies
        // GraphQL -> changedPolicies: [String!]! (scalar)
        if (ec.Includes("changedPolicies",true))
        {
            if(this.ChangedPolicies == null) {

                this.ChangedPolicies = new List<System.String>();

            } else {


            }
        }
        else if (this.ChangedPolicies != null && ec.Excludes("changedPolicies",true))
        {
            this.ChangedPolicies = null;
        }
        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        if (ec.Includes("comment",true))
        {
            if(this.Comment == null) {

                this.Comment = "FETCH";

            } else {


            }
        }
        else if (this.Comment != null && ec.Excludes("comment",true))
        {
            this.Comment = null;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = new DateTime();

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
        //      C# -> UserSummary? Author
        // GraphQL -> author: UserSummary (type)
        if (ec.Includes("author",false))
        {
            if(this.Author == null) {

                this.Author = new UserSummary();
                this.Author.ApplyExploratoryFieldSpec(ec.NewChild("author"));

            } else {

                this.Author.ApplyExploratoryFieldSpec(ec.NewChild("author"));

            }
        }
        else if (this.Author != null && ec.Excludes("author",false))
        {
            this.Author = null;
        }
    }


    #endregion

    } // class TprReqStatusChange
    
    #endregion

    public static class ListTprReqStatusChangeExtensions
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
            this List<TprReqStatusChange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprReqStatusChange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprReqStatusChange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprReqStatusChange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprReqStatusChange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
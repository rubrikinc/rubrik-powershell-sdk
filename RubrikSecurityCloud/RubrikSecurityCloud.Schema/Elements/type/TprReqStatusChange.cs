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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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

        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        [JsonProperty("comment")]
        public System.String? Comment { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }


        #endregion

    #region methods

    public TprReqStatusChange Set(
        TprReqOperation? Operation = null,
        System.String? AuthorId = null,
        System.String? AuthorName = null,
        System.String? Comment = null,
        DateTime? Timestamp = null
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
        if ( Comment != null ) {
            this.Comment = Comment;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
        //      C# -> TprReqOperation? Operation
        // GraphQL -> operation: TprReqOperation! (enum)
        if (this.Operation != null) {
            s += ind + "operation\n" ;
        }
        //      C# -> System.String? AuthorId
        // GraphQL -> authorId: String! (scalar)
        if (this.AuthorId != null) {
            s += ind + "authorId\n" ;
        }
        //      C# -> System.String? AuthorName
        // GraphQL -> authorName: String! (scalar)
        if (this.AuthorName != null) {
            s += ind + "authorName\n" ;
        }
        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        if (this.Comment != null) {
            s += ind + "comment\n" ;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            s += ind + "timestamp\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TprReqOperation? Operation
        // GraphQL -> operation: TprReqOperation! (enum)
        if (this.Operation == null && Exploration.Includes(parent + ".operation", true))
        {
            this.Operation = new TprReqOperation();
        }
        //      C# -> System.String? AuthorId
        // GraphQL -> authorId: String! (scalar)
        if (this.AuthorId == null && Exploration.Includes(parent + ".authorId", true))
        {
            this.AuthorId = new System.String("FETCH");
        }
        //      C# -> System.String? AuthorName
        // GraphQL -> authorName: String! (scalar)
        if (this.AuthorName == null && Exploration.Includes(parent + ".authorName", true))
        {
            this.AuthorName = new System.String("FETCH");
        }
        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        if (this.Comment == null && Exploration.Includes(parent + ".comment", true))
        {
            this.Comment = new System.String("FETCH");
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp", true))
        {
            this.Timestamp = new DateTime();
        }
    }


    #endregion

    } // class TprReqStatusChange
    
    #endregion

    public static class ListTprReqStatusChangeExtensions
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
            this List<TprReqStatusChange> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprReqStatusChange> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprReqStatusChange());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// O365Email.cs
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
    #region O365Email
 
    public class O365Email: BaseType, O365ExchangeObject
    {
        #region members

        //      C# -> System.String? From
        // GraphQL -> from: String (scalar)
        [JsonProperty("from")]
        public System.String? From { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        [JsonProperty("parentFolderId")]
        public System.String? ParentFolderId { get; set; }

        //      C# -> DateTime? ReceivedDateTime
        // GraphQL -> receivedDateTime: DateTime (scalar)
        [JsonProperty("receivedDateTime")]
        public DateTime? ReceivedDateTime { get; set; }

        //      C# -> DateTime? SentDateTime
        // GraphQL -> sentDateTime: DateTime (scalar)
        [JsonProperty("sentDateTime")]
        public DateTime? SentDateTime { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }

        //      C# -> System.String? Subject
        // GraphQL -> subject: String (scalar)
        [JsonProperty("subject")]
        public System.String? Subject { get; set; }

        //      C# -> List<System.String>? ToRecipients
        // GraphQL -> toRecipients: [String!]! (scalar)
        [JsonProperty("toRecipients")]
        public List<System.String>? ToRecipients { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365Email";
    }

    public O365Email Set(
        System.String? From = null,
        System.String? Id = null,
        System.String? ParentFolderId = null,
        DateTime? ReceivedDateTime = null,
        DateTime? SentDateTime = null,
        System.String? SnapshotId = null,
        System.Int32? SnapshotNum = null,
        System.String? Subject = null,
        List<System.String>? ToRecipients = null
    ) 
    {
        if ( From != null ) {
            this.From = From;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ParentFolderId != null ) {
            this.ParentFolderId = ParentFolderId;
        }
        if ( ReceivedDateTime != null ) {
            this.ReceivedDateTime = ReceivedDateTime;
        }
        if ( SentDateTime != null ) {
            this.SentDateTime = SentDateTime;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SnapshotNum != null ) {
            this.SnapshotNum = SnapshotNum;
        }
        if ( Subject != null ) {
            this.Subject = Subject;
        }
        if ( ToRecipients != null ) {
            this.ToRecipients = ToRecipients;
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
        //      C# -> System.String? From
        // GraphQL -> from: String (scalar)
        if (this.From != null) {
            s += ind + "from\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId != null) {
            s += ind + "parentFolderId\n" ;
        }
        //      C# -> DateTime? ReceivedDateTime
        // GraphQL -> receivedDateTime: DateTime (scalar)
        if (this.ReceivedDateTime != null) {
            s += ind + "receivedDateTime\n" ;
        }
        //      C# -> DateTime? SentDateTime
        // GraphQL -> sentDateTime: DateTime (scalar)
        if (this.SentDateTime != null) {
            s += ind + "sentDateTime\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum != null) {
            s += ind + "snapshotNum\n" ;
        }
        //      C# -> System.String? Subject
        // GraphQL -> subject: String (scalar)
        if (this.Subject != null) {
            s += ind + "subject\n" ;
        }
        //      C# -> List<System.String>? ToRecipients
        // GraphQL -> toRecipients: [String!]! (scalar)
        if (this.ToRecipients != null) {
            s += ind + "toRecipients\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? From
        // GraphQL -> from: String (scalar)
        if (this.From == null && ec.Includes("from",true))
        {
            this.From = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId == null && ec.Includes("parentFolderId",true))
        {
            this.ParentFolderId = "FETCH";
        }
        //      C# -> DateTime? ReceivedDateTime
        // GraphQL -> receivedDateTime: DateTime (scalar)
        if (this.ReceivedDateTime == null && ec.Includes("receivedDateTime",true))
        {
            this.ReceivedDateTime = new DateTime();
        }
        //      C# -> DateTime? SentDateTime
        // GraphQL -> sentDateTime: DateTime (scalar)
        if (this.SentDateTime == null && ec.Includes("sentDateTime",true))
        {
            this.SentDateTime = new DateTime();
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum == null && ec.Includes("snapshotNum",true))
        {
            this.SnapshotNum = Int32.MinValue;
        }
        //      C# -> System.String? Subject
        // GraphQL -> subject: String (scalar)
        if (this.Subject == null && ec.Includes("subject",true))
        {
            this.Subject = "FETCH";
        }
        //      C# -> List<System.String>? ToRecipients
        // GraphQL -> toRecipients: [String!]! (scalar)
        if (this.ToRecipients == null && ec.Includes("toRecipients",true))
        {
            this.ToRecipients = new List<System.String>();
        }
    }


    #endregion

    } // class O365Email
    
    #endregion

    public static class ListO365EmailExtensions
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
            this List<O365Email> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365Email> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365Email());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<O365Email> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? From
        // GraphQL -> from: String (scalar)
        if (this.From != null) {
            if (conf.Flat) {
                s += conf.Prefix + "from\n" ;
            } else {
                s += ind + "from\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentFolderId\n" ;
            } else {
                s += ind + "parentFolderId\n" ;
            }
        }
        //      C# -> DateTime? ReceivedDateTime
        // GraphQL -> receivedDateTime: DateTime (scalar)
        if (this.ReceivedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "receivedDateTime\n" ;
            } else {
                s += ind + "receivedDateTime\n" ;
            }
        }
        //      C# -> DateTime? SentDateTime
        // GraphQL -> sentDateTime: DateTime (scalar)
        if (this.SentDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sentDateTime\n" ;
            } else {
                s += ind + "sentDateTime\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotNum\n" ;
            } else {
                s += ind + "snapshotNum\n" ;
            }
        }
        //      C# -> System.String? Subject
        // GraphQL -> subject: String (scalar)
        if (this.Subject != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subject\n" ;
            } else {
                s += ind + "subject\n" ;
            }
        }
        //      C# -> List<System.String>? ToRecipients
        // GraphQL -> toRecipients: [String!]! (scalar)
        if (this.ToRecipients != null) {
            if (conf.Flat) {
                s += conf.Prefix + "toRecipients\n" ;
            } else {
                s += ind + "toRecipients\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? From
        // GraphQL -> from: String (scalar)
        if (ec.Includes("from",true))
        {
            if(this.From == null) {

                this.From = "FETCH";

            } else {


            }
        }
        else if (this.From != null && ec.Excludes("from",true))
        {
            this.From = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (ec.Includes("parentFolderId",true))
        {
            if(this.ParentFolderId == null) {

                this.ParentFolderId = "FETCH";

            } else {


            }
        }
        else if (this.ParentFolderId != null && ec.Excludes("parentFolderId",true))
        {
            this.ParentFolderId = null;
        }
        //      C# -> DateTime? ReceivedDateTime
        // GraphQL -> receivedDateTime: DateTime (scalar)
        if (ec.Includes("receivedDateTime",true))
        {
            if(this.ReceivedDateTime == null) {

                this.ReceivedDateTime = new DateTime();

            } else {


            }
        }
        else if (this.ReceivedDateTime != null && ec.Excludes("receivedDateTime",true))
        {
            this.ReceivedDateTime = null;
        }
        //      C# -> DateTime? SentDateTime
        // GraphQL -> sentDateTime: DateTime (scalar)
        if (ec.Includes("sentDateTime",true))
        {
            if(this.SentDateTime == null) {

                this.SentDateTime = new DateTime();

            } else {


            }
        }
        else if (this.SentDateTime != null && ec.Excludes("sentDateTime",true))
        {
            this.SentDateTime = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (ec.Includes("snapshotNum",true))
        {
            if(this.SnapshotNum == null) {

                this.SnapshotNum = Int32.MinValue;

            } else {


            }
        }
        else if (this.SnapshotNum != null && ec.Excludes("snapshotNum",true))
        {
            this.SnapshotNum = null;
        }
        //      C# -> System.String? Subject
        // GraphQL -> subject: String (scalar)
        if (ec.Includes("subject",true))
        {
            if(this.Subject == null) {

                this.Subject = "FETCH";

            } else {


            }
        }
        else if (this.Subject != null && ec.Excludes("subject",true))
        {
            this.Subject = null;
        }
        //      C# -> List<System.String>? ToRecipients
        // GraphQL -> toRecipients: [String!]! (scalar)
        if (ec.Includes("toRecipients",true))
        {
            if(this.ToRecipients == null) {

                this.ToRecipients = new List<System.String>();

            } else {


            }
        }
        else if (this.ToRecipients != null && ec.Excludes("toRecipients",true))
        {
            this.ToRecipients = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<O365Email> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
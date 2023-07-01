// O365Contact.cs
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
    #region O365Contact
 
    public class O365Contact: BaseType, O365ExchangeObject
    {
        #region members

        //      C# -> List<System.String>? Addresses
        // GraphQL -> addresses: [String!]! (scalar)
        [JsonProperty("addresses")]
        public List<System.String>? Addresses { get; set; }

        //      C# -> System.String? Company
        // GraphQL -> company: String (scalar)
        [JsonProperty("company")]
        public System.String? Company { get; set; }

        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        [JsonProperty("emailAddresses")]
        public List<System.String>? EmailAddresses { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        [JsonProperty("parentFolderId")]
        public System.String? ParentFolderId { get; set; }

        //      C# -> List<System.String>? PhoneNumbers
        // GraphQL -> phoneNumbers: [String!]! (scalar)
        [JsonProperty("phoneNumbers")]
        public List<System.String>? PhoneNumbers { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365Contact";
    }

    public O365Contact Set(
        List<System.String>? Addresses = null,
        System.String? Company = null,
        List<System.String>? EmailAddresses = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? ParentFolderId = null,
        List<System.String>? PhoneNumbers = null,
        System.String? SnapshotId = null,
        System.Int32? SnapshotNum = null,
        DateTime? SnapshotTime = null
    ) 
    {
        if ( Addresses != null ) {
            this.Addresses = Addresses;
        }
        if ( Company != null ) {
            this.Company = Company;
        }
        if ( EmailAddresses != null ) {
            this.EmailAddresses = EmailAddresses;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentFolderId != null ) {
            this.ParentFolderId = ParentFolderId;
        }
        if ( PhoneNumbers != null ) {
            this.PhoneNumbers = PhoneNumbers;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SnapshotNum != null ) {
            this.SnapshotNum = SnapshotNum;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        //      C# -> List<System.String>? Addresses
        // GraphQL -> addresses: [String!]! (scalar)
        if (this.Addresses != null) {
            s += ind + "addresses\n" ;
        }
        //      C# -> System.String? Company
        // GraphQL -> company: String (scalar)
        if (this.Company != null) {
            s += ind + "company\n" ;
        }
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        if (this.EmailAddresses != null) {
            s += ind + "emailAddresses\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId != null) {
            s += ind + "parentFolderId\n" ;
        }
        //      C# -> List<System.String>? PhoneNumbers
        // GraphQL -> phoneNumbers: [String!]! (scalar)
        if (this.PhoneNumbers != null) {
            s += ind + "phoneNumbers\n" ;
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
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            s += ind + "snapshotTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? Addresses
        // GraphQL -> addresses: [String!]! (scalar)
        if (this.Addresses == null && Exploration.Includes(parent + ".addresses", true))
        {
            this.Addresses = new List<System.String>();
        }
        //      C# -> System.String? Company
        // GraphQL -> company: String (scalar)
        if (this.Company == null && Exploration.Includes(parent + ".company", true))
        {
            this.Company = "FETCH";
        }
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        if (this.EmailAddresses == null && Exploration.Includes(parent + ".emailAddresses", true))
        {
            this.EmailAddresses = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId == null && Exploration.Includes(parent + ".parentFolderId", true))
        {
            this.ParentFolderId = "FETCH";
        }
        //      C# -> List<System.String>? PhoneNumbers
        // GraphQL -> phoneNumbers: [String!]! (scalar)
        if (this.PhoneNumbers == null && Exploration.Includes(parent + ".phoneNumbers", true))
        {
            this.PhoneNumbers = new List<System.String>();
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum == null && Exploration.Includes(parent + ".snapshotNum", true))
        {
            this.SnapshotNum = Int32.MinValue;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime == null && Exploration.Includes(parent + ".snapshotTime", true))
        {
            this.SnapshotTime = new DateTime();
        }
    }


    #endregion

    } // class O365Contact
    
    #endregion

    public static class ListO365ContactExtensions
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
            this List<O365Contact> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365Contact> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365Contact());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
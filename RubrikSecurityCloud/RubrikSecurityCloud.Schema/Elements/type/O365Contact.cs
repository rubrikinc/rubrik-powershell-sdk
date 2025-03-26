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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? Addresses
        // GraphQL -> addresses: [String!]! (scalar)
        if (this.Addresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "addresses\n" ;
            } else {
                s += ind + "addresses\n" ;
            }
        }
        //      C# -> System.String? Company
        // GraphQL -> company: String (scalar)
        if (this.Company != null) {
            if (conf.Flat) {
                s += conf.Prefix + "company\n" ;
            } else {
                s += ind + "company\n" ;
            }
        }
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        if (this.EmailAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "emailAddresses\n" ;
            } else {
                s += ind + "emailAddresses\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        //      C# -> List<System.String>? PhoneNumbers
        // GraphQL -> phoneNumbers: [String!]! (scalar)
        if (this.PhoneNumbers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "phoneNumbers\n" ;
            } else {
                s += ind + "phoneNumbers\n" ;
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
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? Addresses
        // GraphQL -> addresses: [String!]! (scalar)
        if (ec.Includes("addresses",true))
        {
            if(this.Addresses == null) {

                this.Addresses = new List<System.String>();

            } else {


            }
        }
        else if (this.Addresses != null && ec.Excludes("addresses",true))
        {
            this.Addresses = null;
        }
        //      C# -> System.String? Company
        // GraphQL -> company: String (scalar)
        if (ec.Includes("company",true))
        {
            if(this.Company == null) {

                this.Company = "FETCH";

            } else {


            }
        }
        else if (this.Company != null && ec.Excludes("company",true))
        {
            this.Company = null;
        }
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!]! (scalar)
        if (ec.Includes("emailAddresses",true))
        {
            if(this.EmailAddresses == null) {

                this.EmailAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.EmailAddresses != null && ec.Excludes("emailAddresses",true))
        {
            this.EmailAddresses = null;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
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
        //      C# -> List<System.String>? PhoneNumbers
        // GraphQL -> phoneNumbers: [String!]! (scalar)
        if (ec.Includes("phoneNumbers",true))
        {
            if(this.PhoneNumbers == null) {

                this.PhoneNumbers = new List<System.String>();

            } else {


            }
        }
        else if (this.PhoneNumbers != null && ec.Excludes("phoneNumbers",true))
        {
            this.PhoneNumbers = null;
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
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
    }


    #endregion

    } // class O365Contact
    
    #endregion

    public static class ListO365ContactExtensions
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
            this List<O365Contact> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365Contact> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365Contact> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365Contact());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365Contact> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// Csr.cs
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
    #region Csr
    public class Csr: BaseType
    {
        #region members

        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        [JsonProperty("city")]
        public System.String? City { get; set; }

        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        [JsonProperty("country")]
        public System.String? Country { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? CreatorEmail
        // GraphQL -> creatorEmail: String! (scalar)
        [JsonProperty("creatorEmail")]
        public System.String? CreatorEmail { get; set; }

        //      C# -> System.String? CsrField
        // GraphQL -> csr: String! (scalar)
        [JsonProperty("csr")]
        public System.String? CsrField { get; set; }

        //      C# -> System.Int64? CsrId
        // GraphQL -> csrId: Long! (scalar)
        [JsonProperty("csrId")]
        public System.Int64? CsrId { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> List<System.String>? Hostnames
        // GraphQL -> hostnames: [String!]! (scalar)
        [JsonProperty("hostnames")]
        public List<System.String>? Hostnames { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Organization
        // GraphQL -> organization: String! (scalar)
        [JsonProperty("organization")]
        public System.String? Organization { get; set; }

        //      C# -> System.String? OrganizationUnit
        // GraphQL -> organizationUnit: String! (scalar)
        [JsonProperty("organizationUnit")]
        public System.String? OrganizationUnit { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> System.String? Surname
        // GraphQL -> surname: String! (scalar)
        [JsonProperty("surname")]
        public System.String? Surname { get; set; }

        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        [JsonProperty("userId")]
        public System.String? UserId { get; set; }


        #endregion

    #region methods

    public Csr Set(
        System.String? City = null,
        System.String? Country = null,
        DateTime? CreatedAt = null,
        System.String? CreatorEmail = null,
        System.String? CsrField = null,
        System.Int64? CsrId = null,
        System.String? Email = null,
        List<System.String>? Hostnames = null,
        System.String? Name = null,
        System.String? Organization = null,
        System.String? OrganizationUnit = null,
        System.String? State = null,
        System.String? Surname = null,
        System.String? UserId = null
    ) 
    {
        if ( City != null ) {
            this.City = City;
        }
        if ( Country != null ) {
            this.Country = Country;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CreatorEmail != null ) {
            this.CreatorEmail = CreatorEmail;
        }
        if ( CsrField != null ) {
            this.CsrField = CsrField;
        }
        if ( CsrId != null ) {
            this.CsrId = CsrId;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Hostnames != null ) {
            this.Hostnames = Hostnames;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Organization != null ) {
            this.Organization = Organization;
        }
        if ( OrganizationUnit != null ) {
            this.OrganizationUnit = OrganizationUnit;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Surname != null ) {
            this.Surname = Surname;
        }
        if ( UserId != null ) {
            this.UserId = UserId;
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
        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        if (this.City != null) {
            s += ind + "city\n" ;
        }
        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        if (this.Country != null) {
            s += ind + "country\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> System.String? CreatorEmail
        // GraphQL -> creatorEmail: String! (scalar)
        if (this.CreatorEmail != null) {
            s += ind + "creatorEmail\n" ;
        }
        //      C# -> System.String? CsrField
        // GraphQL -> csr: String! (scalar)
        if (this.CsrField != null) {
            s += ind + "csr\n" ;
        }
        //      C# -> System.Int64? CsrId
        // GraphQL -> csrId: Long! (scalar)
        if (this.CsrId != null) {
            s += ind + "csrId\n" ;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            s += ind + "email\n" ;
        }
        //      C# -> List<System.String>? Hostnames
        // GraphQL -> hostnames: [String!]! (scalar)
        if (this.Hostnames != null) {
            s += ind + "hostnames\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? Organization
        // GraphQL -> organization: String! (scalar)
        if (this.Organization != null) {
            s += ind + "organization\n" ;
        }
        //      C# -> System.String? OrganizationUnit
        // GraphQL -> organizationUnit: String! (scalar)
        if (this.OrganizationUnit != null) {
            s += ind + "organizationUnit\n" ;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> System.String? Surname
        // GraphQL -> surname: String! (scalar)
        if (this.Surname != null) {
            s += ind + "surname\n" ;
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (this.UserId != null) {
            s += ind + "userId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        if (this.City == null && Exploration.Includes(parent + ".city", true))
        {
            this.City = "FETCH";
        }
        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        if (this.Country == null && Exploration.Includes(parent + ".country", true))
        {
            this.Country = "FETCH";
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.String? CreatorEmail
        // GraphQL -> creatorEmail: String! (scalar)
        if (this.CreatorEmail == null && Exploration.Includes(parent + ".creatorEmail", true))
        {
            this.CreatorEmail = "FETCH";
        }
        //      C# -> System.String? CsrField
        // GraphQL -> csr: String! (scalar)
        if (this.CsrField == null && Exploration.Includes(parent + ".csr", true))
        {
            this.CsrField = "FETCH";
        }
        //      C# -> System.Int64? CsrId
        // GraphQL -> csrId: Long! (scalar)
        if (this.CsrId == null && Exploration.Includes(parent + ".csrId", true))
        {
            this.CsrId = new System.Int64();
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email == null && Exploration.Includes(parent + ".email", true))
        {
            this.Email = "FETCH";
        }
        //      C# -> List<System.String>? Hostnames
        // GraphQL -> hostnames: [String!]! (scalar)
        if (this.Hostnames == null && Exploration.Includes(parent + ".hostnames", true))
        {
            this.Hostnames = new List<System.String>();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? Organization
        // GraphQL -> organization: String! (scalar)
        if (this.Organization == null && Exploration.Includes(parent + ".organization", true))
        {
            this.Organization = "FETCH";
        }
        //      C# -> System.String? OrganizationUnit
        // GraphQL -> organizationUnit: String! (scalar)
        if (this.OrganizationUnit == null && Exploration.Includes(parent + ".organizationUnit", true))
        {
            this.OrganizationUnit = "FETCH";
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = "FETCH";
        }
        //      C# -> System.String? Surname
        // GraphQL -> surname: String! (scalar)
        if (this.Surname == null && Exploration.Includes(parent + ".surname", true))
        {
            this.Surname = "FETCH";
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (this.UserId == null && Exploration.Includes(parent + ".userId", true))
        {
            this.UserId = "FETCH";
        }
    }


    #endregion

    } // class Csr
    
    #endregion

    public static class ListCsrExtensions
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
            this List<Csr> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Csr> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Csr());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
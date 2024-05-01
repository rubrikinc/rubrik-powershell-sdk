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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> System.String? CsrFid
        // GraphQL -> csrFid: UUID! (scalar)
        [JsonProperty("csrFid")]
        public System.String? CsrFid { get; set; }

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

    public override string GetGqlTypeName() {
        return "Csr";
    }

    public Csr Set(
        System.String? City = null,
        System.String? Country = null,
        DateTime? CreatedAt = null,
        System.String? CreatorEmail = null,
        System.String? CsrField = null,
        System.String? CsrFid = null,
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
        if ( CsrFid != null ) {
            this.CsrFid = CsrFid;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        if (this.City != null) {
            if (conf.Flat) {
                s += conf.Prefix + "city\n" ;
            } else {
                s += ind + "city\n" ;
            }
        }
        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        if (this.Country != null) {
            if (conf.Flat) {
                s += conf.Prefix + "country\n" ;
            } else {
                s += ind + "country\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? CreatorEmail
        // GraphQL -> creatorEmail: String! (scalar)
        if (this.CreatorEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creatorEmail\n" ;
            } else {
                s += ind + "creatorEmail\n" ;
            }
        }
        //      C# -> System.String? CsrField
        // GraphQL -> csr: String! (scalar)
        if (this.CsrField != null) {
            if (conf.Flat) {
                s += conf.Prefix + "csr\n" ;
            } else {
                s += ind + "csr\n" ;
            }
        }
        //      C# -> System.String? CsrFid
        // GraphQL -> csrFid: UUID! (scalar)
        if (this.CsrFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "csrFid\n" ;
            } else {
                s += ind + "csrFid\n" ;
            }
        }
        //      C# -> System.Int64? CsrId
        // GraphQL -> csrId: Long! (scalar)
        if (this.CsrId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "csrId\n" ;
            } else {
                s += ind + "csrId\n" ;
            }
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            if (conf.Flat) {
                s += conf.Prefix + "email\n" ;
            } else {
                s += ind + "email\n" ;
            }
        }
        //      C# -> List<System.String>? Hostnames
        // GraphQL -> hostnames: [String!]! (scalar)
        if (this.Hostnames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostnames\n" ;
            } else {
                s += ind + "hostnames\n" ;
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
        //      C# -> System.String? Organization
        // GraphQL -> organization: String! (scalar)
        if (this.Organization != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organization\n" ;
            } else {
                s += ind + "organization\n" ;
            }
        }
        //      C# -> System.String? OrganizationUnit
        // GraphQL -> organizationUnit: String! (scalar)
        if (this.OrganizationUnit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organizationUnit\n" ;
            } else {
                s += ind + "organizationUnit\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> System.String? Surname
        // GraphQL -> surname: String! (scalar)
        if (this.Surname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "surname\n" ;
            } else {
                s += ind + "surname\n" ;
            }
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (this.UserId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userId\n" ;
            } else {
                s += ind + "userId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? City
        // GraphQL -> city: String! (scalar)
        if (ec.Includes("city",true))
        {
            if(this.City == null) {

                this.City = "FETCH";

            } else {


            }
        }
        else if (this.City != null && ec.Excludes("city",true))
        {
            this.City = null;
        }
        //      C# -> System.String? Country
        // GraphQL -> country: String! (scalar)
        if (ec.Includes("country",true))
        {
            if(this.Country == null) {

                this.Country = "FETCH";

            } else {


            }
        }
        else if (this.Country != null && ec.Excludes("country",true))
        {
            this.Country = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.String? CreatorEmail
        // GraphQL -> creatorEmail: String! (scalar)
        if (ec.Includes("creatorEmail",true))
        {
            if(this.CreatorEmail == null) {

                this.CreatorEmail = "FETCH";

            } else {


            }
        }
        else if (this.CreatorEmail != null && ec.Excludes("creatorEmail",true))
        {
            this.CreatorEmail = null;
        }
        //      C# -> System.String? CsrField
        // GraphQL -> csr: String! (scalar)
        if (ec.Includes("csr",true))
        {
            if(this.CsrField == null) {

                this.CsrField = "FETCH";

            } else {


            }
        }
        else if (this.CsrField != null && ec.Excludes("csr",true))
        {
            this.CsrField = null;
        }
        //      C# -> System.String? CsrFid
        // GraphQL -> csrFid: UUID! (scalar)
        if (ec.Includes("csrFid",true))
        {
            if(this.CsrFid == null) {

                this.CsrFid = "FETCH";

            } else {


            }
        }
        else if (this.CsrFid != null && ec.Excludes("csrFid",true))
        {
            this.CsrFid = null;
        }
        //      C# -> System.Int64? CsrId
        // GraphQL -> csrId: Long! (scalar)
        if (ec.Includes("csrId",true))
        {
            if(this.CsrId == null) {

                this.CsrId = new System.Int64();

            } else {


            }
        }
        else if (this.CsrId != null && ec.Excludes("csrId",true))
        {
            this.CsrId = null;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (ec.Includes("email",true))
        {
            if(this.Email == null) {

                this.Email = "FETCH";

            } else {


            }
        }
        else if (this.Email != null && ec.Excludes("email",true))
        {
            this.Email = null;
        }
        //      C# -> List<System.String>? Hostnames
        // GraphQL -> hostnames: [String!]! (scalar)
        if (ec.Includes("hostnames",true))
        {
            if(this.Hostnames == null) {

                this.Hostnames = new List<System.String>();

            } else {


            }
        }
        else if (this.Hostnames != null && ec.Excludes("hostnames",true))
        {
            this.Hostnames = null;
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
        //      C# -> System.String? Organization
        // GraphQL -> organization: String! (scalar)
        if (ec.Includes("organization",true))
        {
            if(this.Organization == null) {

                this.Organization = "FETCH";

            } else {


            }
        }
        else if (this.Organization != null && ec.Excludes("organization",true))
        {
            this.Organization = null;
        }
        //      C# -> System.String? OrganizationUnit
        // GraphQL -> organizationUnit: String! (scalar)
        if (ec.Includes("organizationUnit",true))
        {
            if(this.OrganizationUnit == null) {

                this.OrganizationUnit = "FETCH";

            } else {


            }
        }
        else if (this.OrganizationUnit != null && ec.Excludes("organizationUnit",true))
        {
            this.OrganizationUnit = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> System.String? Surname
        // GraphQL -> surname: String! (scalar)
        if (ec.Includes("surname",true))
        {
            if(this.Surname == null) {

                this.Surname = "FETCH";

            } else {


            }
        }
        else if (this.Surname != null && ec.Excludes("surname",true))
        {
            this.Surname = null;
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (ec.Includes("userId",true))
        {
            if(this.UserId == null) {

                this.UserId = "FETCH";

            } else {


            }
        }
        else if (this.UserId != null && ec.Excludes("userId",true))
        {
            this.UserId = null;
        }
    }


    #endregion

    } // class Csr
    
    #endregion

    public static class ListCsrExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<Csr> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Csr> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Csr> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Csr());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Csr> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
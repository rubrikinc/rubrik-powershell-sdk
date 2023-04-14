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

namespace Rubrik.SecurityCloud.Types
{
    #region Csr
    public class Csr: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? City
            // GraphQL -> city: String! (scalar)
            if (this.City != null)
            {
                 s += ind + "city\n";

            }
            //      C# -> System.String? Country
            // GraphQL -> country: String! (scalar)
            if (this.Country != null)
            {
                 s += ind + "country\n";

            }
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime (scalar)
            if (this.CreatedAt != null)
            {
                 s += ind + "createdAt\n";

            }
            //      C# -> System.String? CreatorEmail
            // GraphQL -> creatorEmail: String! (scalar)
            if (this.CreatorEmail != null)
            {
                 s += ind + "creatorEmail\n";

            }
            //      C# -> System.String? CsrField
            // GraphQL -> csr: String! (scalar)
            if (this.CsrField != null)
            {
                 s += ind + "csr\n";

            }
            //      C# -> System.Int64? CsrId
            // GraphQL -> csrId: Long! (scalar)
            if (this.CsrId != null)
            {
                 s += ind + "csrId\n";

            }
            //      C# -> System.String? Email
            // GraphQL -> email: String! (scalar)
            if (this.Email != null)
            {
                 s += ind + "email\n";

            }
            //      C# -> List<System.String>? Hostnames
            // GraphQL -> hostnames: [String!]! (scalar)
            if (this.Hostnames != null)
            {
                 s += ind + "hostnames\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? Organization
            // GraphQL -> organization: String! (scalar)
            if (this.Organization != null)
            {
                 s += ind + "organization\n";

            }
            //      C# -> System.String? OrganizationUnit
            // GraphQL -> organizationUnit: String! (scalar)
            if (this.OrganizationUnit != null)
            {
                 s += ind + "organizationUnit\n";

            }
            //      C# -> System.String? State
            // GraphQL -> state: String! (scalar)
            if (this.State != null)
            {
                 s += ind + "state\n";

            }
            //      C# -> System.String? Surname
            // GraphQL -> surname: String! (scalar)
            if (this.Surname != null)
            {
                 s += ind + "surname\n";

            }
            //      C# -> System.String? UserId
            // GraphQL -> userId: String! (scalar)
            if (this.UserId != null)
            {
                 s += ind + "userId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? City
            // GraphQL -> city: String! (scalar)
            if (this.City == null && Exploration.Includes(parent + ".city$"))
            {
                this.City = new System.String("FETCH");
            }
            //      C# -> System.String? Country
            // GraphQL -> country: String! (scalar)
            if (this.Country == null && Exploration.Includes(parent + ".country$"))
            {
                this.Country = new System.String("FETCH");
            }
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime (scalar)
            if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt$"))
            {
                this.CreatedAt = new DateTime();
            }
            //      C# -> System.String? CreatorEmail
            // GraphQL -> creatorEmail: String! (scalar)
            if (this.CreatorEmail == null && Exploration.Includes(parent + ".creatorEmail$"))
            {
                this.CreatorEmail = new System.String("FETCH");
            }
            //      C# -> System.String? CsrField
            // GraphQL -> csr: String! (scalar)
            if (this.CsrField == null && Exploration.Includes(parent + ".csr$"))
            {
                this.CsrField = new System.String("FETCH");
            }
            //      C# -> System.Int64? CsrId
            // GraphQL -> csrId: Long! (scalar)
            if (this.CsrId == null && Exploration.Includes(parent + ".csrId$"))
            {
                this.CsrId = new System.Int64();
            }
            //      C# -> System.String? Email
            // GraphQL -> email: String! (scalar)
            if (this.Email == null && Exploration.Includes(parent + ".email$"))
            {
                this.Email = new System.String("FETCH");
            }
            //      C# -> List<System.String>? Hostnames
            // GraphQL -> hostnames: [String!]! (scalar)
            if (this.Hostnames == null && Exploration.Includes(parent + ".hostnames$"))
            {
                this.Hostnames = new List<System.String>();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? Organization
            // GraphQL -> organization: String! (scalar)
            if (this.Organization == null && Exploration.Includes(parent + ".organization$"))
            {
                this.Organization = new System.String("FETCH");
            }
            //      C# -> System.String? OrganizationUnit
            // GraphQL -> organizationUnit: String! (scalar)
            if (this.OrganizationUnit == null && Exploration.Includes(parent + ".organizationUnit$"))
            {
                this.OrganizationUnit = new System.String("FETCH");
            }
            //      C# -> System.String? State
            // GraphQL -> state: String! (scalar)
            if (this.State == null && Exploration.Includes(parent + ".state$"))
            {
                this.State = new System.String("FETCH");
            }
            //      C# -> System.String? Surname
            // GraphQL -> surname: String! (scalar)
            if (this.Surname == null && Exploration.Includes(parent + ".surname$"))
            {
                this.Surname = new System.String("FETCH");
            }
            //      C# -> System.String? UserId
            // GraphQL -> userId: String! (scalar)
            if (this.UserId == null && Exploration.Includes(parent + ".userId$"))
            {
                this.UserId = new System.String("FETCH");
            }
        }


    #endregion

    } // class Csr
    #endregion

    public static class ListCsrExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<Csr> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Csr> list, 
            String parent = "")
        {
            var item = new Csr();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
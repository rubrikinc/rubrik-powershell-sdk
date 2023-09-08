// UserSummary.cs
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
    #region UserSummary
    public class UserSummary: BaseType
    {
        #region members

        //      C# -> UserDomain? Domain
        // GraphQL -> domain: UserDomain! (enum)
        [JsonProperty("domain")]
        public UserDomain? Domain { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        [JsonProperty("userId")]
        public System.String? UserId { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserSummary";
    }

    public UserSummary Set(
        UserDomain? Domain = null,
        System.String? Email = null,
        System.String? UserId = null,
        System.String? Username = null
    ) 
    {
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( UserId != null ) {
            this.UserId = UserId;
        }
        if ( Username != null ) {
            this.Username = Username;
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
        //      C# -> UserDomain? Domain
        // GraphQL -> domain: UserDomain! (enum)
        if (this.Domain != null) {
            s += ind + "domain\n" ;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            s += ind + "email\n" ;
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (this.UserId != null) {
            s += ind + "userId\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserDomain? Domain
        // GraphQL -> domain: UserDomain! (enum)
        if (this.Domain == null && ec.Includes("domain",true))
        {
            this.Domain = new UserDomain();
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email == null && ec.Includes("email",true))
        {
            this.Email = "FETCH";
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (this.UserId == null && ec.Includes("userId",true))
        {
            this.UserId = "FETCH";
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && ec.Includes("username",true))
        {
            this.Username = "FETCH";
        }
    }


    #endregion

    } // class UserSummary
    
    #endregion

    public static class ListUserSummaryExtensions
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
            this List<UserSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UserSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
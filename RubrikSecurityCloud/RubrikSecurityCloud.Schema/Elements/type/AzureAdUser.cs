// AzureAdUser.cs
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
    #region AzureAdUser
    public class AzureAdUser: BaseType
    {
        #region members

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? PrincipalUserName
        // GraphQL -> principalUserName: String! (scalar)
        [JsonProperty("principalUserName")]
        public System.String? PrincipalUserName { get; set; }

        //      C# -> System.String? UserType
        // GraphQL -> userType: String! (scalar)
        [JsonProperty("userType")]
        public System.String? UserType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdUser";
    }

    public AzureAdUser Set(
        System.String? DisplayName = null,
        System.String? PrincipalUserName = null,
        System.String? UserType = null
    ) 
    {
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( PrincipalUserName != null ) {
            this.PrincipalUserName = PrincipalUserName;
        }
        if ( UserType != null ) {
            this.UserType = UserType;
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
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            s += ind + "displayName\n" ;
        }
        //      C# -> System.String? PrincipalUserName
        // GraphQL -> principalUserName: String! (scalar)
        if (this.PrincipalUserName != null) {
            s += ind + "principalUserName\n" ;
        }
        //      C# -> System.String? UserType
        // GraphQL -> userType: String! (scalar)
        if (this.UserType != null) {
            s += ind + "userType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName == null && Exploration.Includes(parent + ".displayName", true))
        {
            this.DisplayName = "FETCH";
        }
        //      C# -> System.String? PrincipalUserName
        // GraphQL -> principalUserName: String! (scalar)
        if (this.PrincipalUserName == null && Exploration.Includes(parent + ".principalUserName", true))
        {
            this.PrincipalUserName = "FETCH";
        }
        //      C# -> System.String? UserType
        // GraphQL -> userType: String! (scalar)
        if (this.UserType == null && Exploration.Includes(parent + ".userType", true))
        {
            this.UserType = "FETCH";
        }
    }


    #endregion

    } // class AzureAdUser
    
    #endregion

    public static class ListAzureAdUserExtensions
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
            this List<AzureAdUser> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdUser> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdUser());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
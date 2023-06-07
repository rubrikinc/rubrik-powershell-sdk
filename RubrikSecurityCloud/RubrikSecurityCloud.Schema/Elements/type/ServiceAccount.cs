// ServiceAccount.cs
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
    #region ServiceAccount
    public class ServiceAccount: BaseType
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        [JsonProperty("lastLogin")]
        public DateTime? LastLogin { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        [JsonProperty("roles")]
        public List<Role>? Roles { get; set; }


        #endregion

    #region methods

    public ServiceAccount Set(
        System.String? ClientId = null,
        System.String? Description = null,
        DateTime? LastLogin = null,
        System.String? Name = null,
        List<Role>? Roles = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( LastLogin != null ) {
            this.LastLogin = LastLogin;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
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
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            s += ind + "clientId\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin != null) {
            s += ind + "lastLogin\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles != null) {
            s += ind + "roles {\n" + this.Roles.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId == null && Exploration.Includes(parent + ".clientId", true))
        {
            this.ClientId = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin == null && Exploration.Includes(parent + ".lastLogin", true))
        {
            this.LastLogin = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles == null && Exploration.Includes(parent + ".roles"))
        {
            this.Roles = new List<Role>();
            this.Roles.ApplyExploratoryFieldSpec(parent + ".roles");
        }
    }


    #endregion

    } // class ServiceAccount
    
    #endregion

    public static class ListServiceAccountExtensions
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
            this List<ServiceAccount> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ServiceAccount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ServiceAccount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// ActiveDirectoryObjectsCount.cs
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
    #region ActiveDirectoryObjectsCount
    public class ActiveDirectoryObjectsCount: BaseType
    {
        #region members

        //      C# -> System.Int64? Computers
        // GraphQL -> computers: Long (scalar)
        [JsonProperty("computers")]
        public System.Int64? Computers { get; set; }

        //      C# -> System.Int64? Contacts
        // GraphQL -> contacts: Long (scalar)
        [JsonProperty("contacts")]
        public System.Int64? Contacts { get; set; }

        //      C# -> System.Int64? Containers
        // GraphQL -> containers: Long (scalar)
        [JsonProperty("containers")]
        public System.Int64? Containers { get; set; }

        //      C# -> System.Int64? Gpos
        // GraphQL -> gpos: Long (scalar)
        [JsonProperty("gpos")]
        public System.Int64? Gpos { get; set; }

        //      C# -> System.Int64? Groups
        // GraphQL -> groups: Long (scalar)
        [JsonProperty("groups")]
        public System.Int64? Groups { get; set; }

        //      C# -> System.Int64? OrganizationalUnits
        // GraphQL -> organizationalUnits: Long (scalar)
        [JsonProperty("organizationalUnits")]
        public System.Int64? OrganizationalUnits { get; set; }

        //      C# -> System.Int64? Users
        // GraphQL -> users: Long (scalar)
        [JsonProperty("users")]
        public System.Int64? Users { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryObjectsCount";
    }

    public ActiveDirectoryObjectsCount Set(
        System.Int64? Computers = null,
        System.Int64? Contacts = null,
        System.Int64? Containers = null,
        System.Int64? Gpos = null,
        System.Int64? Groups = null,
        System.Int64? OrganizationalUnits = null,
        System.Int64? Users = null
    ) 
    {
        if ( Computers != null ) {
            this.Computers = Computers;
        }
        if ( Contacts != null ) {
            this.Contacts = Contacts;
        }
        if ( Containers != null ) {
            this.Containers = Containers;
        }
        if ( Gpos != null ) {
            this.Gpos = Gpos;
        }
        if ( Groups != null ) {
            this.Groups = Groups;
        }
        if ( OrganizationalUnits != null ) {
            this.OrganizationalUnits = OrganizationalUnits;
        }
        if ( Users != null ) {
            this.Users = Users;
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
        //      C# -> System.Int64? Computers
        // GraphQL -> computers: Long (scalar)
        if (this.Computers != null) {
            s += ind + "computers\n" ;
        }
        //      C# -> System.Int64? Contacts
        // GraphQL -> contacts: Long (scalar)
        if (this.Contacts != null) {
            s += ind + "contacts\n" ;
        }
        //      C# -> System.Int64? Containers
        // GraphQL -> containers: Long (scalar)
        if (this.Containers != null) {
            s += ind + "containers\n" ;
        }
        //      C# -> System.Int64? Gpos
        // GraphQL -> gpos: Long (scalar)
        if (this.Gpos != null) {
            s += ind + "gpos\n" ;
        }
        //      C# -> System.Int64? Groups
        // GraphQL -> groups: Long (scalar)
        if (this.Groups != null) {
            s += ind + "groups\n" ;
        }
        //      C# -> System.Int64? OrganizationalUnits
        // GraphQL -> organizationalUnits: Long (scalar)
        if (this.OrganizationalUnits != null) {
            s += ind + "organizationalUnits\n" ;
        }
        //      C# -> System.Int64? Users
        // GraphQL -> users: Long (scalar)
        if (this.Users != null) {
            s += ind + "users\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Computers
        // GraphQL -> computers: Long (scalar)
        if (this.Computers == null && ec.Includes("computers",true))
        {
            this.Computers = new System.Int64();
        }
        //      C# -> System.Int64? Contacts
        // GraphQL -> contacts: Long (scalar)
        if (this.Contacts == null && ec.Includes("contacts",true))
        {
            this.Contacts = new System.Int64();
        }
        //      C# -> System.Int64? Containers
        // GraphQL -> containers: Long (scalar)
        if (this.Containers == null && ec.Includes("containers",true))
        {
            this.Containers = new System.Int64();
        }
        //      C# -> System.Int64? Gpos
        // GraphQL -> gpos: Long (scalar)
        if (this.Gpos == null && ec.Includes("gpos",true))
        {
            this.Gpos = new System.Int64();
        }
        //      C# -> System.Int64? Groups
        // GraphQL -> groups: Long (scalar)
        if (this.Groups == null && ec.Includes("groups",true))
        {
            this.Groups = new System.Int64();
        }
        //      C# -> System.Int64? OrganizationalUnits
        // GraphQL -> organizationalUnits: Long (scalar)
        if (this.OrganizationalUnits == null && ec.Includes("organizationalUnits",true))
        {
            this.OrganizationalUnits = new System.Int64();
        }
        //      C# -> System.Int64? Users
        // GraphQL -> users: Long (scalar)
        if (this.Users == null && ec.Includes("users",true))
        {
            this.Users = new System.Int64();
        }
    }


    #endregion

    } // class ActiveDirectoryObjectsCount
    
    #endregion

    public static class ListActiveDirectoryObjectsCountExtensions
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
            this List<ActiveDirectoryObjectsCount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryObjectsCount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryObjectsCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryObjectsCount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// ManagedVolumeSmbShare.cs
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
    #region ManagedVolumeSmbShare
    public class ManagedVolumeSmbShare: BaseType
    {
        #region members

        //      C# -> List<System.String>? ActiveDirectoryGroups
        // GraphQL -> activeDirectoryGroups: [String!]! (scalar)
        [JsonProperty("activeDirectoryGroups")]
        public List<System.String>? ActiveDirectoryGroups { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> List<System.String>? ValidIps
        // GraphQL -> validIps: [String!]! (scalar)
        [JsonProperty("validIps")]
        public List<System.String>? ValidIps { get; set; }

        //      C# -> List<System.String>? ValidUsers
        // GraphQL -> validUsers: [String!]! (scalar)
        [JsonProperty("validUsers")]
        public List<System.String>? ValidUsers { get; set; }


        #endregion

    #region methods

    public ManagedVolumeSmbShare Set(
        List<System.String>? ActiveDirectoryGroups = null,
        System.String? DomainName = null,
        List<System.String>? ValidIps = null,
        List<System.String>? ValidUsers = null
    ) 
    {
        if ( ActiveDirectoryGroups != null ) {
            this.ActiveDirectoryGroups = ActiveDirectoryGroups;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( ValidIps != null ) {
            this.ValidIps = ValidIps;
        }
        if ( ValidUsers != null ) {
            this.ValidUsers = ValidUsers;
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
        //      C# -> List<System.String>? ActiveDirectoryGroups
        // GraphQL -> activeDirectoryGroups: [String!]! (scalar)
        if (this.ActiveDirectoryGroups != null) {
            s += ind + "activeDirectoryGroups\n" ;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            s += ind + "domainName\n" ;
        }
        //      C# -> List<System.String>? ValidIps
        // GraphQL -> validIps: [String!]! (scalar)
        if (this.ValidIps != null) {
            s += ind + "validIps\n" ;
        }
        //      C# -> List<System.String>? ValidUsers
        // GraphQL -> validUsers: [String!]! (scalar)
        if (this.ValidUsers != null) {
            s += ind + "validUsers\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? ActiveDirectoryGroups
        // GraphQL -> activeDirectoryGroups: [String!]! (scalar)
        if (this.ActiveDirectoryGroups == null && Exploration.Includes(parent + ".activeDirectoryGroups", true))
        {
            this.ActiveDirectoryGroups = new List<System.String>();
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName == null && Exploration.Includes(parent + ".domainName", true))
        {
            this.DomainName = "FETCH";
        }
        //      C# -> List<System.String>? ValidIps
        // GraphQL -> validIps: [String!]! (scalar)
        if (this.ValidIps == null && Exploration.Includes(parent + ".validIps", true))
        {
            this.ValidIps = new List<System.String>();
        }
        //      C# -> List<System.String>? ValidUsers
        // GraphQL -> validUsers: [String!]! (scalar)
        if (this.ValidUsers == null && Exploration.Includes(parent + ".validUsers", true))
        {
            this.ValidUsers = new List<System.String>();
        }
    }


    #endregion

    } // class ManagedVolumeSmbShare
    
    #endregion

    public static class ListManagedVolumeSmbShareExtensions
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
            this List<ManagedVolumeSmbShare> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSmbShare> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSmbShare());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
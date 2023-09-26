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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "ManagedVolumeSmbShare";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? ActiveDirectoryGroups
        // GraphQL -> activeDirectoryGroups: [String!]! (scalar)
        if (this.ActiveDirectoryGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeDirectoryGroups\n" ;
            } else {
                s += ind + "activeDirectoryGroups\n" ;
            }
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        //      C# -> List<System.String>? ValidIps
        // GraphQL -> validIps: [String!]! (scalar)
        if (this.ValidIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "validIps\n" ;
            } else {
                s += ind + "validIps\n" ;
            }
        }
        //      C# -> List<System.String>? ValidUsers
        // GraphQL -> validUsers: [String!]! (scalar)
        if (this.ValidUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "validUsers\n" ;
            } else {
                s += ind + "validUsers\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? ActiveDirectoryGroups
        // GraphQL -> activeDirectoryGroups: [String!]! (scalar)
        if (ec.Includes("activeDirectoryGroups",true))
        {
            if(this.ActiveDirectoryGroups == null) {

                this.ActiveDirectoryGroups = new List<System.String>();

            } else {


            }
        }
        else if (this.ActiveDirectoryGroups != null && ec.Excludes("activeDirectoryGroups",true))
        {
            this.ActiveDirectoryGroups = null;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
        //      C# -> List<System.String>? ValidIps
        // GraphQL -> validIps: [String!]! (scalar)
        if (ec.Includes("validIps",true))
        {
            if(this.ValidIps == null) {

                this.ValidIps = new List<System.String>();

            } else {


            }
        }
        else if (this.ValidIps != null && ec.Excludes("validIps",true))
        {
            this.ValidIps = null;
        }
        //      C# -> List<System.String>? ValidUsers
        // GraphQL -> validUsers: [String!]! (scalar)
        if (ec.Includes("validUsers",true))
        {
            if(this.ValidUsers == null) {

                this.ValidUsers = new List<System.String>();

            } else {


            }
        }
        else if (this.ValidUsers != null && ec.Excludes("validUsers",true))
        {
            this.ValidUsers = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSmbShare> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSmbShare());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSmbShare> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
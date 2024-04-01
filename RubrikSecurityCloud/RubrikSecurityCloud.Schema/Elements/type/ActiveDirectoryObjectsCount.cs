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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? Computers
        // GraphQL -> computers: Long (scalar)
        if (this.Computers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computers\n" ;
            } else {
                s += ind + "computers\n" ;
            }
        }
        //      C# -> System.Int64? Contacts
        // GraphQL -> contacts: Long (scalar)
        if (this.Contacts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contacts\n" ;
            } else {
                s += ind + "contacts\n" ;
            }
        }
        //      C# -> System.Int64? Containers
        // GraphQL -> containers: Long (scalar)
        if (this.Containers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "containers\n" ;
            } else {
                s += ind + "containers\n" ;
            }
        }
        //      C# -> System.Int64? Gpos
        // GraphQL -> gpos: Long (scalar)
        if (this.Gpos != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gpos\n" ;
            } else {
                s += ind + "gpos\n" ;
            }
        }
        //      C# -> System.Int64? Groups
        // GraphQL -> groups: Long (scalar)
        if (this.Groups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groups\n" ;
            } else {
                s += ind + "groups\n" ;
            }
        }
        //      C# -> System.Int64? OrganizationalUnits
        // GraphQL -> organizationalUnits: Long (scalar)
        if (this.OrganizationalUnits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organizationalUnits\n" ;
            } else {
                s += ind + "organizationalUnits\n" ;
            }
        }
        //      C# -> System.Int64? Users
        // GraphQL -> users: Long (scalar)
        if (this.Users != null) {
            if (conf.Flat) {
                s += conf.Prefix + "users\n" ;
            } else {
                s += ind + "users\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Computers
        // GraphQL -> computers: Long (scalar)
        if (ec.Includes("computers",true))
        {
            if(this.Computers == null) {

                this.Computers = new System.Int64();

            } else {


            }
        }
        else if (this.Computers != null && ec.Excludes("computers",true))
        {
            this.Computers = null;
        }
        //      C# -> System.Int64? Contacts
        // GraphQL -> contacts: Long (scalar)
        if (ec.Includes("contacts",true))
        {
            if(this.Contacts == null) {

                this.Contacts = new System.Int64();

            } else {


            }
        }
        else if (this.Contacts != null && ec.Excludes("contacts",true))
        {
            this.Contacts = null;
        }
        //      C# -> System.Int64? Containers
        // GraphQL -> containers: Long (scalar)
        if (ec.Includes("containers",true))
        {
            if(this.Containers == null) {

                this.Containers = new System.Int64();

            } else {


            }
        }
        else if (this.Containers != null && ec.Excludes("containers",true))
        {
            this.Containers = null;
        }
        //      C# -> System.Int64? Gpos
        // GraphQL -> gpos: Long (scalar)
        if (ec.Includes("gpos",true))
        {
            if(this.Gpos == null) {

                this.Gpos = new System.Int64();

            } else {


            }
        }
        else if (this.Gpos != null && ec.Excludes("gpos",true))
        {
            this.Gpos = null;
        }
        //      C# -> System.Int64? Groups
        // GraphQL -> groups: Long (scalar)
        if (ec.Includes("groups",true))
        {
            if(this.Groups == null) {

                this.Groups = new System.Int64();

            } else {


            }
        }
        else if (this.Groups != null && ec.Excludes("groups",true))
        {
            this.Groups = null;
        }
        //      C# -> System.Int64? OrganizationalUnits
        // GraphQL -> organizationalUnits: Long (scalar)
        if (ec.Includes("organizationalUnits",true))
        {
            if(this.OrganizationalUnits == null) {

                this.OrganizationalUnits = new System.Int64();

            } else {


            }
        }
        else if (this.OrganizationalUnits != null && ec.Excludes("organizationalUnits",true))
        {
            this.OrganizationalUnits = null;
        }
        //      C# -> System.Int64? Users
        // GraphQL -> users: Long (scalar)
        if (ec.Includes("users",true))
        {
            if(this.Users == null) {

                this.Users = new System.Int64();

            } else {


            }
        }
        else if (this.Users != null && ec.Excludes("users",true))
        {
            this.Users = null;
        }
    }


    #endregion

    } // class ActiveDirectoryObjectsCount
    
    #endregion

    public static class ListActiveDirectoryObjectsCountExtensions
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
            this List<ActiveDirectoryObjectsCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryObjectsCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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
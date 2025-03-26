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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<ManagedVolumeSmbShare> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeSmbShare> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSmbShare> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSmbShare());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSmbShare> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
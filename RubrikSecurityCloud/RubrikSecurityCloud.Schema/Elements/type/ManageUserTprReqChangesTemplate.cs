// ManageUserTprReqChangesTemplate.cs
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
    #region ManageUserTprReqChangesTemplate
 
    public class ManageUserTprReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> List<UserGroupSummary>? Groups
        // GraphQL -> groups: [UserGroupSummary!]! (type)
        [JsonProperty("groups")]
        public List<UserGroupSummary>? Groups { get; set; }

        //      C# -> List<UserSummary>? Users
        // GraphQL -> users: [UserSummary!]! (type)
        [JsonProperty("users")]
        public List<UserSummary>? Users { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManageUserTprReqChangesTemplate";
    }

    public ManageUserTprReqChangesTemplate Set(
        System.String? TemplateName = null,
        List<UserGroupSummary>? Groups = null,
        List<UserSummary>? Users = null
    ) 
    {
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( Groups != null ) {
            this.Groups = Groups;
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
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            s += ind + "templateName\n" ;
        }
        //      C# -> List<UserGroupSummary>? Groups
        // GraphQL -> groups: [UserGroupSummary!]! (type)
        if (this.Groups != null) {
            var fspec = this.Groups.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groups {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<UserSummary>? Users
        // GraphQL -> users: [UserSummary!]! (type)
        if (this.Users != null) {
            var fspec = this.Users.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "users {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName == null && ec.Includes("templateName",true))
        {
            this.TemplateName = "FETCH";
        }
        //      C# -> List<UserGroupSummary>? Groups
        // GraphQL -> groups: [UserGroupSummary!]! (type)
        if (this.Groups == null && ec.Includes("groups",false))
        {
            this.Groups = new List<UserGroupSummary>();
            this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));
        }
        //      C# -> List<UserSummary>? Users
        // GraphQL -> users: [UserSummary!]! (type)
        if (this.Users == null && ec.Includes("users",false))
        {
            this.Users = new List<UserSummary>();
            this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));
        }
    }


    #endregion

    } // class ManageUserTprReqChangesTemplate
    
    #endregion

    public static class ListManageUserTprReqChangesTemplateExtensions
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
            this List<ManageUserTprReqChangesTemplate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManageUserTprReqChangesTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManageUserTprReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ManageUserTprReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
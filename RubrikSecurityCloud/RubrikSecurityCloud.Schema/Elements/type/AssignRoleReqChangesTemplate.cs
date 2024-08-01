// AssignRoleReqChangesTemplate.cs
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
    #region AssignRoleReqChangesTemplate
 
    public class AssignRoleReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> List<UserGroupWithRoles>? GroupsWithRoles
        // GraphQL -> groupsWithRoles: [UserGroupWithRoles!]! (type)
        [JsonProperty("groupsWithRoles")]
        public List<UserGroupWithRoles>? GroupsWithRoles { get; set; }

        //      C# -> List<RoleSummary>? NewRoles
        // GraphQL -> newRoles: [RoleSummary!]! (type)
        [JsonProperty("newRoles")]
        public List<RoleSummary>? NewRoles { get; set; }

        //      C# -> List<RoleSummary>? OldRoles
        // GraphQL -> oldRoles: [RoleSummary!]! (type)
        [JsonProperty("oldRoles")]
        public List<RoleSummary>? OldRoles { get; set; }

        //      C# -> List<UserWithRoles>? UsersWithRoles
        // GraphQL -> usersWithRoles: [UserWithRoles!]! (type)
        [JsonProperty("usersWithRoles")]
        public List<UserWithRoles>? UsersWithRoles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AssignRoleReqChangesTemplate";
    }

    public AssignRoleReqChangesTemplate Set(
        System.String? TemplateName = null,
        List<UserGroupWithRoles>? GroupsWithRoles = null,
        List<RoleSummary>? NewRoles = null,
        List<RoleSummary>? OldRoles = null,
        List<UserWithRoles>? UsersWithRoles = null
    ) 
    {
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( GroupsWithRoles != null ) {
            this.GroupsWithRoles = GroupsWithRoles;
        }
        if ( NewRoles != null ) {
            this.NewRoles = NewRoles;
        }
        if ( OldRoles != null ) {
            this.OldRoles = OldRoles;
        }
        if ( UsersWithRoles != null ) {
            this.UsersWithRoles = UsersWithRoles;
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
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateName\n" ;
            } else {
                s += ind + "templateName\n" ;
            }
        }
        //      C# -> List<UserGroupWithRoles>? GroupsWithRoles
        // GraphQL -> groupsWithRoles: [UserGroupWithRoles!]! (type)
        if (this.GroupsWithRoles != null) {
            var fspec = this.GroupsWithRoles.AsFieldSpec(conf.Child("groupsWithRoles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupsWithRoles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RoleSummary>? NewRoles
        // GraphQL -> newRoles: [RoleSummary!]! (type)
        if (this.NewRoles != null) {
            var fspec = this.NewRoles.AsFieldSpec(conf.Child("newRoles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newRoles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RoleSummary>? OldRoles
        // GraphQL -> oldRoles: [RoleSummary!]! (type)
        if (this.OldRoles != null) {
            var fspec = this.OldRoles.AsFieldSpec(conf.Child("oldRoles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldRoles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<UserWithRoles>? UsersWithRoles
        // GraphQL -> usersWithRoles: [UserWithRoles!]! (type)
        if (this.UsersWithRoles != null) {
            var fspec = this.UsersWithRoles.AsFieldSpec(conf.Child("usersWithRoles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "usersWithRoles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (ec.Includes("templateName",true))
        {
            if(this.TemplateName == null) {

                this.TemplateName = "FETCH";

            } else {


            }
        }
        else if (this.TemplateName != null && ec.Excludes("templateName",true))
        {
            this.TemplateName = null;
        }
        //      C# -> List<UserGroupWithRoles>? GroupsWithRoles
        // GraphQL -> groupsWithRoles: [UserGroupWithRoles!]! (type)
        if (ec.Includes("groupsWithRoles",false))
        {
            if(this.GroupsWithRoles == null) {

                this.GroupsWithRoles = new List<UserGroupWithRoles>();
                this.GroupsWithRoles.ApplyExploratoryFieldSpec(ec.NewChild("groupsWithRoles"));

            } else {

                this.GroupsWithRoles.ApplyExploratoryFieldSpec(ec.NewChild("groupsWithRoles"));

            }
        }
        else if (this.GroupsWithRoles != null && ec.Excludes("groupsWithRoles",false))
        {
            this.GroupsWithRoles = null;
        }
        //      C# -> List<RoleSummary>? NewRoles
        // GraphQL -> newRoles: [RoleSummary!]! (type)
        if (ec.Includes("newRoles",false))
        {
            if(this.NewRoles == null) {

                this.NewRoles = new List<RoleSummary>();
                this.NewRoles.ApplyExploratoryFieldSpec(ec.NewChild("newRoles"));

            } else {

                this.NewRoles.ApplyExploratoryFieldSpec(ec.NewChild("newRoles"));

            }
        }
        else if (this.NewRoles != null && ec.Excludes("newRoles",false))
        {
            this.NewRoles = null;
        }
        //      C# -> List<RoleSummary>? OldRoles
        // GraphQL -> oldRoles: [RoleSummary!]! (type)
        if (ec.Includes("oldRoles",false))
        {
            if(this.OldRoles == null) {

                this.OldRoles = new List<RoleSummary>();
                this.OldRoles.ApplyExploratoryFieldSpec(ec.NewChild("oldRoles"));

            } else {

                this.OldRoles.ApplyExploratoryFieldSpec(ec.NewChild("oldRoles"));

            }
        }
        else if (this.OldRoles != null && ec.Excludes("oldRoles",false))
        {
            this.OldRoles = null;
        }
        //      C# -> List<UserWithRoles>? UsersWithRoles
        // GraphQL -> usersWithRoles: [UserWithRoles!]! (type)
        if (ec.Includes("usersWithRoles",false))
        {
            if(this.UsersWithRoles == null) {

                this.UsersWithRoles = new List<UserWithRoles>();
                this.UsersWithRoles.ApplyExploratoryFieldSpec(ec.NewChild("usersWithRoles"));

            } else {

                this.UsersWithRoles.ApplyExploratoryFieldSpec(ec.NewChild("usersWithRoles"));

            }
        }
        else if (this.UsersWithRoles != null && ec.Excludes("usersWithRoles",false))
        {
            this.UsersWithRoles = null;
        }
    }


    #endregion

    } // class AssignRoleReqChangesTemplate
    
    #endregion

    public static class ListAssignRoleReqChangesTemplateExtensions
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
            this List<AssignRoleReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AssignRoleReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AssignRoleReqChangesTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AssignRoleReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AssignRoleReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
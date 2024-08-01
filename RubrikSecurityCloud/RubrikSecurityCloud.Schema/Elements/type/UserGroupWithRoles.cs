// UserGroupWithRoles.cs
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
    #region UserGroupWithRoles
    public class UserGroupWithRoles: BaseType
    {
        #region members

        //      C# -> UserGroupSummary? Group
        // GraphQL -> group: UserGroupSummary! (type)
        [JsonProperty("group")]
        public UserGroupSummary? Group { get; set; }

        //      C# -> List<RoleSummary>? Roles
        // GraphQL -> roles: [RoleSummary!]! (type)
        [JsonProperty("roles")]
        public List<RoleSummary>? Roles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserGroupWithRoles";
    }

    public UserGroupWithRoles Set(
        UserGroupSummary? Group = null,
        List<RoleSummary>? Roles = null
    ) 
    {
        if ( Group != null ) {
            this.Group = Group;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
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
        //      C# -> UserGroupSummary? Group
        // GraphQL -> group: UserGroupSummary! (type)
        if (this.Group != null) {
            var fspec = this.Group.AsFieldSpec(conf.Child("group"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "group" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RoleSummary>? Roles
        // GraphQL -> roles: [RoleSummary!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(conf.Child("roles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserGroupSummary? Group
        // GraphQL -> group: UserGroupSummary! (type)
        if (ec.Includes("group",false))
        {
            if(this.Group == null) {

                this.Group = new UserGroupSummary();
                this.Group.ApplyExploratoryFieldSpec(ec.NewChild("group"));

            } else {

                this.Group.ApplyExploratoryFieldSpec(ec.NewChild("group"));

            }
        }
        else if (this.Group != null && ec.Excludes("group",false))
        {
            this.Group = null;
        }
        //      C# -> List<RoleSummary>? Roles
        // GraphQL -> roles: [RoleSummary!]! (type)
        if (ec.Includes("roles",false))
        {
            if(this.Roles == null) {

                this.Roles = new List<RoleSummary>();
                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            } else {

                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            }
        }
        else if (this.Roles != null && ec.Excludes("roles",false))
        {
            this.Roles = null;
        }
    }


    #endregion

    } // class UserGroupWithRoles
    
    #endregion

    public static class ListUserGroupWithRolesExtensions
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
            this List<UserGroupWithRoles> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserGroupWithRoles> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserGroupWithRoles> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserGroupWithRoles());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserGroupWithRoles> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
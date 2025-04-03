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
        //      C# -> List<UserGroupSummary>? Groups
        // GraphQL -> groups: [UserGroupSummary!]! (type)
        if (this.Groups != null) {
            var fspec = this.Groups.AsFieldSpec(conf.Child("groups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<UserSummary>? Users
        // GraphQL -> users: [UserSummary!]! (type)
        if (this.Users != null) {
            var fspec = this.Users.AsFieldSpec(conf.Child("users"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "users" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> List<UserGroupSummary>? Groups
        // GraphQL -> groups: [UserGroupSummary!]! (type)
        if (ec.Includes("groups",false))
        {
            if(this.Groups == null) {

                this.Groups = new List<UserGroupSummary>();
                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            } else {

                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            }
        }
        else if (this.Groups != null && ec.Excludes("groups",false))
        {
            this.Groups = null;
        }
        //      C# -> List<UserSummary>? Users
        // GraphQL -> users: [UserSummary!]! (type)
        if (ec.Includes("users",false))
        {
            if(this.Users == null) {

                this.Users = new List<UserSummary>();
                this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));

            } else {

                this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));

            }
        }
        else if (this.Users != null && ec.Excludes("users",false))
        {
            this.Users = null;
        }
    }


    #endregion

    } // class ManageUserTprReqChangesTemplate
    
    #endregion

    public static class ListManageUserTprReqChangesTemplateExtensions
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
            this List<ManageUserTprReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManageUserTprReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManageUserTprReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManageUserTprReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManageUserTprReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
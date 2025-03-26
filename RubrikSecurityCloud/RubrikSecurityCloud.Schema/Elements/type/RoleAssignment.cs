// RoleAssignment.cs
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
    #region RoleAssignment
    public class RoleAssignment: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsExplicitlyAssigned
        // GraphQL -> isExplicitlyAssigned: Boolean! (scalar)
        [JsonProperty("isExplicitlyAssigned")]
        public System.Boolean? IsExplicitlyAssigned { get; set; }

        //      C# -> Role? Role
        // GraphQL -> role: Role! (type)
        [JsonProperty("role")]
        public Role? Role { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RoleAssignment";
    }

    public RoleAssignment Set(
        System.Boolean? IsExplicitlyAssigned = null,
        Role? Role = null
    ) 
    {
        if ( IsExplicitlyAssigned != null ) {
            this.IsExplicitlyAssigned = IsExplicitlyAssigned;
        }
        if ( Role != null ) {
            this.Role = Role;
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
        //      C# -> System.Boolean? IsExplicitlyAssigned
        // GraphQL -> isExplicitlyAssigned: Boolean! (scalar)
        if (this.IsExplicitlyAssigned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExplicitlyAssigned\n" ;
            } else {
                s += ind + "isExplicitlyAssigned\n" ;
            }
        }
        //      C# -> Role? Role
        // GraphQL -> role: Role! (type)
        if (this.Role != null) {
            var fspec = this.Role.AsFieldSpec(conf.Child("role"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "role" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsExplicitlyAssigned
        // GraphQL -> isExplicitlyAssigned: Boolean! (scalar)
        if (ec.Includes("isExplicitlyAssigned",true))
        {
            if(this.IsExplicitlyAssigned == null) {

                this.IsExplicitlyAssigned = true;

            } else {


            }
        }
        else if (this.IsExplicitlyAssigned != null && ec.Excludes("isExplicitlyAssigned",true))
        {
            this.IsExplicitlyAssigned = null;
        }
        //      C# -> Role? Role
        // GraphQL -> role: Role! (type)
        if (ec.Includes("role",false))
        {
            if(this.Role == null) {

                this.Role = new Role();
                this.Role.ApplyExploratoryFieldSpec(ec.NewChild("role"));

            } else {

                this.Role.ApplyExploratoryFieldSpec(ec.NewChild("role"));

            }
        }
        else if (this.Role != null && ec.Excludes("role",false))
        {
            this.Role = null;
        }
    }


    #endregion

    } // class RoleAssignment
    
    #endregion

    public static class ListRoleAssignmentExtensions
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
            this List<RoleAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RoleAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RoleAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RoleAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RoleAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
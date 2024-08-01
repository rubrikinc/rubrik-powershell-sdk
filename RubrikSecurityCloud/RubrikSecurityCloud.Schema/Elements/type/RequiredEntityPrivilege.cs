// RequiredEntityPrivilege.cs
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
    #region RequiredEntityPrivilege
    public class RequiredEntityPrivilege: BaseType
    {
        #region members

        //      C# -> RequiredPrivilegeEntityType? EntityType
        // GraphQL -> entityType: RequiredPrivilegeEntityType! (enum)
        [JsonProperty("entityType")]
        public RequiredPrivilegeEntityType? EntityType { get; set; }

        //      C# -> List<RequiredPrivilege>? RequiredPrivileges
        // GraphQL -> requiredPrivileges: [RequiredPrivilege!]! (type)
        [JsonProperty("requiredPrivileges")]
        public List<RequiredPrivilege>? RequiredPrivileges { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RequiredEntityPrivilege";
    }

    public RequiredEntityPrivilege Set(
        RequiredPrivilegeEntityType? EntityType = null,
        List<RequiredPrivilege>? RequiredPrivileges = null
    ) 
    {
        if ( EntityType != null ) {
            this.EntityType = EntityType;
        }
        if ( RequiredPrivileges != null ) {
            this.RequiredPrivileges = RequiredPrivileges;
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
        //      C# -> RequiredPrivilegeEntityType? EntityType
        // GraphQL -> entityType: RequiredPrivilegeEntityType! (enum)
        if (this.EntityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityType\n" ;
            } else {
                s += ind + "entityType\n" ;
            }
        }
        //      C# -> List<RequiredPrivilege>? RequiredPrivileges
        // GraphQL -> requiredPrivileges: [RequiredPrivilege!]! (type)
        if (this.RequiredPrivileges != null) {
            var fspec = this.RequiredPrivileges.AsFieldSpec(conf.Child("requiredPrivileges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "requiredPrivileges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RequiredPrivilegeEntityType? EntityType
        // GraphQL -> entityType: RequiredPrivilegeEntityType! (enum)
        if (ec.Includes("entityType",true))
        {
            if(this.EntityType == null) {

                this.EntityType = new RequiredPrivilegeEntityType();

            } else {


            }
        }
        else if (this.EntityType != null && ec.Excludes("entityType",true))
        {
            this.EntityType = null;
        }
        //      C# -> List<RequiredPrivilege>? RequiredPrivileges
        // GraphQL -> requiredPrivileges: [RequiredPrivilege!]! (type)
        if (ec.Includes("requiredPrivileges",false))
        {
            if(this.RequiredPrivileges == null) {

                this.RequiredPrivileges = new List<RequiredPrivilege>();
                this.RequiredPrivileges.ApplyExploratoryFieldSpec(ec.NewChild("requiredPrivileges"));

            } else {

                this.RequiredPrivileges.ApplyExploratoryFieldSpec(ec.NewChild("requiredPrivileges"));

            }
        }
        else if (this.RequiredPrivileges != null && ec.Excludes("requiredPrivileges",false))
        {
            this.RequiredPrivileges = null;
        }
    }


    #endregion

    } // class RequiredEntityPrivilege
    
    #endregion

    public static class ListRequiredEntityPrivilegeExtensions
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
            this List<RequiredEntityPrivilege> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RequiredEntityPrivilege> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RequiredEntityPrivilege> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RequiredEntityPrivilege());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RequiredEntityPrivilege> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
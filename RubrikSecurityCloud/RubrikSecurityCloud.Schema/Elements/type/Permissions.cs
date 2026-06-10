// Permissions.cs
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
    #region Permissions
    public class Permissions: BaseType
    {
        #region members

        //      C# -> List<System.Int32>? EvaluationResultRanks
        // GraphQL -> evaluationResultRanks: [Int!]! (scalar)
        [JsonProperty("evaluationResultRanks")]
        public List<System.Int32>? EvaluationResultRanks { get; set; }

        //      C# -> PermissionsViaSummary? AccessVia
        // GraphQL -> accessVia: PermissionsViaSummary (type)
        [JsonProperty("accessVia")]
        public PermissionsViaSummary? AccessVia { get; set; }

        //      C# -> List<PermissionDetails>? DirectPermissions
        // GraphQL -> directPermissions: [PermissionDetails!]! (type)
        [JsonProperty("directPermissions")]
        public List<PermissionDetails>? DirectPermissions { get; set; }

        //      C# -> List<PermissionDetails>? PermissionsByGroup
        // GraphQL -> permissionsByGroup: [PermissionDetails!]! (type)
        [JsonProperty("permissionsByGroup")]
        public List<PermissionDetails>? PermissionsByGroup { get; set; }

        //      C# -> List<PermissionDetails>? PermissionsByRole
        // GraphQL -> permissionsByRole: [PermissionDetails!]! (type)
        [JsonProperty("permissionsByRole")]
        public List<PermissionDetails>? PermissionsByRole { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Permissions";
    }

    public Permissions Set(
        List<System.Int32>? EvaluationResultRanks = null,
        PermissionsViaSummary? AccessVia = null,
        List<PermissionDetails>? DirectPermissions = null,
        List<PermissionDetails>? PermissionsByGroup = null,
        List<PermissionDetails>? PermissionsByRole = null
    ) 
    {
        if ( EvaluationResultRanks != null ) {
            this.EvaluationResultRanks = EvaluationResultRanks;
        }
        if ( AccessVia != null ) {
            this.AccessVia = AccessVia;
        }
        if ( DirectPermissions != null ) {
            this.DirectPermissions = DirectPermissions;
        }
        if ( PermissionsByGroup != null ) {
            this.PermissionsByGroup = PermissionsByGroup;
        }
        if ( PermissionsByRole != null ) {
            this.PermissionsByRole = PermissionsByRole;
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
        //      C# -> List<System.Int32>? EvaluationResultRanks
        // GraphQL -> evaluationResultRanks: [Int!]! (scalar)
        if (this.EvaluationResultRanks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "evaluationResultRanks\n" ;
            } else {
                s += ind + "evaluationResultRanks\n" ;
            }
        }
        //      C# -> PermissionsViaSummary? AccessVia
        // GraphQL -> accessVia: PermissionsViaSummary (type)
        if (this.AccessVia != null) {
            var fspec = this.AccessVia.AsFieldSpec(conf.Child("accessVia"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "accessVia" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PermissionDetails>? DirectPermissions
        // GraphQL -> directPermissions: [PermissionDetails!]! (type)
        if (this.DirectPermissions != null) {
            var fspec = this.DirectPermissions.AsFieldSpec(conf.Child("directPermissions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "directPermissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PermissionDetails>? PermissionsByGroup
        // GraphQL -> permissionsByGroup: [PermissionDetails!]! (type)
        if (this.PermissionsByGroup != null) {
            var fspec = this.PermissionsByGroup.AsFieldSpec(conf.Child("permissionsByGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissionsByGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PermissionDetails>? PermissionsByRole
        // GraphQL -> permissionsByRole: [PermissionDetails!]! (type)
        if (this.PermissionsByRole != null) {
            var fspec = this.PermissionsByRole.AsFieldSpec(conf.Child("permissionsByRole"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissionsByRole" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.Int32>? EvaluationResultRanks
        // GraphQL -> evaluationResultRanks: [Int!]! (scalar)
        if (ec.Includes("evaluationResultRanks",true))
        {
            if(this.EvaluationResultRanks == null) {

                this.EvaluationResultRanks = new List<System.Int32>();

            } else {


            }
        }
        else if (this.EvaluationResultRanks != null && ec.Excludes("evaluationResultRanks",true))
        {
            this.EvaluationResultRanks = null;
        }
        //      C# -> PermissionsViaSummary? AccessVia
        // GraphQL -> accessVia: PermissionsViaSummary (type)
        if (ec.Includes("accessVia",false))
        {
            if(this.AccessVia == null) {

                this.AccessVia = new PermissionsViaSummary();
                this.AccessVia.ApplyExploratoryFieldSpec(ec.NewChild("accessVia"));

            } else {

                this.AccessVia.ApplyExploratoryFieldSpec(ec.NewChild("accessVia"));

            }
        }
        else if (this.AccessVia != null && ec.Excludes("accessVia",false))
        {
            this.AccessVia = null;
        }
        //      C# -> List<PermissionDetails>? DirectPermissions
        // GraphQL -> directPermissions: [PermissionDetails!]! (type)
        if (ec.Includes("directPermissions",false))
        {
            if(this.DirectPermissions == null) {

                this.DirectPermissions = new List<PermissionDetails>();
                this.DirectPermissions.ApplyExploratoryFieldSpec(ec.NewChild("directPermissions"));

            } else {

                this.DirectPermissions.ApplyExploratoryFieldSpec(ec.NewChild("directPermissions"));

            }
        }
        else if (this.DirectPermissions != null && ec.Excludes("directPermissions",false))
        {
            this.DirectPermissions = null;
        }
        //      C# -> List<PermissionDetails>? PermissionsByGroup
        // GraphQL -> permissionsByGroup: [PermissionDetails!]! (type)
        if (ec.Includes("permissionsByGroup",false))
        {
            if(this.PermissionsByGroup == null) {

                this.PermissionsByGroup = new List<PermissionDetails>();
                this.PermissionsByGroup.ApplyExploratoryFieldSpec(ec.NewChild("permissionsByGroup"));

            } else {

                this.PermissionsByGroup.ApplyExploratoryFieldSpec(ec.NewChild("permissionsByGroup"));

            }
        }
        else if (this.PermissionsByGroup != null && ec.Excludes("permissionsByGroup",false))
        {
            this.PermissionsByGroup = null;
        }
        //      C# -> List<PermissionDetails>? PermissionsByRole
        // GraphQL -> permissionsByRole: [PermissionDetails!]! (type)
        if (ec.Includes("permissionsByRole",false))
        {
            if(this.PermissionsByRole == null) {

                this.PermissionsByRole = new List<PermissionDetails>();
                this.PermissionsByRole.ApplyExploratoryFieldSpec(ec.NewChild("permissionsByRole"));

            } else {

                this.PermissionsByRole.ApplyExploratoryFieldSpec(ec.NewChild("permissionsByRole"));

            }
        }
        else if (this.PermissionsByRole != null && ec.Excludes("permissionsByRole",false))
        {
            this.PermissionsByRole = null;
        }
    }


    #endregion

    } // class Permissions
    
    #endregion

    public static class ListPermissionsExtensions
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
            this List<Permissions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Permissions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Permissions> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Permissions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Permissions> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
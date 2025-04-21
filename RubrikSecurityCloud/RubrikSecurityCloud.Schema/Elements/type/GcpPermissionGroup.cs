// GcpPermissionGroup.cs
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
    #region GcpPermissionGroup
    public class GcpPermissionGroup: BaseType
    {
        #region members

        //      C# -> PermissionsGroup? PermissionGroupType
        // GraphQL -> permissionGroupType: PermissionsGroup! (enum)
        [JsonProperty("permissionGroupType")]
        public PermissionsGroup? PermissionGroupType { get; set; }

        //      C# -> List<System.String>? PermissionsWithConditions
        // GraphQL -> permissionsWithConditions: [String!]! (scalar)
        [JsonProperty("permissionsWithConditions")]
        public List<System.String>? PermissionsWithConditions { get; set; }

        //      C# -> System.Int32? PolicyVersion
        // GraphQL -> policyVersion: Int! (scalar)
        [JsonProperty("policyVersion")]
        public System.Int32? PolicyVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpPermissionGroup";
    }

    public GcpPermissionGroup Set(
        PermissionsGroup? PermissionGroupType = null,
        List<System.String>? PermissionsWithConditions = null,
        System.Int32? PolicyVersion = null
    ) 
    {
        if ( PermissionGroupType != null ) {
            this.PermissionGroupType = PermissionGroupType;
        }
        if ( PermissionsWithConditions != null ) {
            this.PermissionsWithConditions = PermissionsWithConditions;
        }
        if ( PolicyVersion != null ) {
            this.PolicyVersion = PolicyVersion;
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
        //      C# -> PermissionsGroup? PermissionGroupType
        // GraphQL -> permissionGroupType: PermissionsGroup! (enum)
        if (this.PermissionGroupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionGroupType\n" ;
            } else {
                s += ind + "permissionGroupType\n" ;
            }
        }
        //      C# -> List<System.String>? PermissionsWithConditions
        // GraphQL -> permissionsWithConditions: [String!]! (scalar)
        if (this.PermissionsWithConditions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionsWithConditions\n" ;
            } else {
                s += ind + "permissionsWithConditions\n" ;
            }
        }
        //      C# -> System.Int32? PolicyVersion
        // GraphQL -> policyVersion: Int! (scalar)
        if (this.PolicyVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyVersion\n" ;
            } else {
                s += ind + "policyVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PermissionsGroup? PermissionGroupType
        // GraphQL -> permissionGroupType: PermissionsGroup! (enum)
        if (ec.Includes("permissionGroupType",true))
        {
            if(this.PermissionGroupType == null) {

                this.PermissionGroupType = new PermissionsGroup();

            } else {


            }
        }
        else if (this.PermissionGroupType != null && ec.Excludes("permissionGroupType",true))
        {
            this.PermissionGroupType = null;
        }
        //      C# -> List<System.String>? PermissionsWithConditions
        // GraphQL -> permissionsWithConditions: [String!]! (scalar)
        if (ec.Includes("permissionsWithConditions",true))
        {
            if(this.PermissionsWithConditions == null) {

                this.PermissionsWithConditions = new List<System.String>();

            } else {


            }
        }
        else if (this.PermissionsWithConditions != null && ec.Excludes("permissionsWithConditions",true))
        {
            this.PermissionsWithConditions = null;
        }
        //      C# -> System.Int32? PolicyVersion
        // GraphQL -> policyVersion: Int! (scalar)
        if (ec.Includes("policyVersion",true))
        {
            if(this.PolicyVersion == null) {

                this.PolicyVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.PolicyVersion != null && ec.Excludes("policyVersion",true))
        {
            this.PolicyVersion = null;
        }
    }


    #endregion

    } // class GcpPermissionGroup
    
    #endregion

    public static class ListGcpPermissionGroupExtensions
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
            this List<GcpPermissionGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpPermissionGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpPermissionGroup> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpPermissionGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpPermissionGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
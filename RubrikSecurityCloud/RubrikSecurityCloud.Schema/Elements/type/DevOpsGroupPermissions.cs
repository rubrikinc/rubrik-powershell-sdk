// DevOpsGroupPermissions.cs
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
    #region DevOpsGroupPermissions
    public class DevOpsGroupPermissions: BaseType
    {
        #region members

        //      C# -> PermissionsGroup? Group
        // GraphQL -> group: PermissionsGroup! (enum)
        [JsonProperty("group")]
        public PermissionsGroup? Group { get; set; }

        //      C# -> List<System.String>? Permissions
        // GraphQL -> permissions: [String!]! (scalar)
        [JsonProperty("permissions")]
        public List<System.String>? Permissions { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DevOpsGroupPermissions";
    }

    public DevOpsGroupPermissions Set(
        PermissionsGroup? Group = null,
        List<System.String>? Permissions = null,
        System.Int32? Version = null
    ) 
    {
        if ( Group != null ) {
            this.Group = Group;
        }
        if ( Permissions != null ) {
            this.Permissions = Permissions;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> PermissionsGroup? Group
        // GraphQL -> group: PermissionsGroup! (enum)
        if (this.Group != null) {
            if (conf.Flat) {
                s += conf.Prefix + "group\n" ;
            } else {
                s += ind + "group\n" ;
            }
        }
        //      C# -> List<System.String>? Permissions
        // GraphQL -> permissions: [String!]! (scalar)
        if (this.Permissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissions\n" ;
            } else {
                s += ind + "permissions\n" ;
            }
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PermissionsGroup? Group
        // GraphQL -> group: PermissionsGroup! (enum)
        if (ec.Includes("group",true))
        {
            if(this.Group == null) {

                this.Group = new PermissionsGroup();

            } else {


            }
        }
        else if (this.Group != null && ec.Excludes("group",true))
        {
            this.Group = null;
        }
        //      C# -> List<System.String>? Permissions
        // GraphQL -> permissions: [String!]! (scalar)
        if (ec.Includes("permissions",true))
        {
            if(this.Permissions == null) {

                this.Permissions = new List<System.String>();

            } else {


            }
        }
        else if (this.Permissions != null && ec.Excludes("permissions",true))
        {
            this.Permissions = null;
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = Int32.MinValue;

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class DevOpsGroupPermissions
    
    #endregion

    public static class ListDevOpsGroupPermissionsExtensions
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
            this List<DevOpsGroupPermissions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DevOpsGroupPermissions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DevOpsGroupPermissions> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DevOpsGroupPermissions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DevOpsGroupPermissions> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
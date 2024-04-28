// PathSecInfo.cs
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
    #region PathSecInfo
    public class PathSecInfo: BaseType
    {
        #region members

        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        [JsonProperty("owner")]
        public System.String? Owner { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> List<SddlPermission>? Permissions
        // GraphQL -> permissions: [SDDLPermission!]! (type)
        [JsonProperty("permissions")]
        public List<SddlPermission>? Permissions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PathSecInfo";
    }

    public PathSecInfo Set(
        System.String? Owner = null,
        System.String? Path = null,
        List<SddlPermission>? Permissions = null
    ) 
    {
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Permissions != null ) {
            this.Permissions = Permissions;
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
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "owner\n" ;
            } else {
                s += ind + "owner\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> List<SddlPermission>? Permissions
        // GraphQL -> permissions: [SDDLPermission!]! (type)
        if (this.Permissions != null) {
            var fspec = this.Permissions.AsFieldSpec(conf.Child("permissions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (ec.Includes("owner",true))
        {
            if(this.Owner == null) {

                this.Owner = "FETCH";

            } else {


            }
        }
        else if (this.Owner != null && ec.Excludes("owner",true))
        {
            this.Owner = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> List<SddlPermission>? Permissions
        // GraphQL -> permissions: [SDDLPermission!]! (type)
        if (ec.Includes("permissions",false))
        {
            if(this.Permissions == null) {

                this.Permissions = new List<SddlPermission>();
                this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));

            } else {

                this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));

            }
        }
        else if (this.Permissions != null && ec.Excludes("permissions",false))
        {
            this.Permissions = null;
        }
    }


    #endregion

    } // class PathSecInfo
    
    #endregion

    public static class ListPathSecInfoExtensions
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
            this List<PathSecInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PathSecInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PathSecInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PathSecInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PathSecInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// PermissionsGroupWithVersion.cs
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
    #region PermissionsGroupWithVersion
    public class PermissionsGroupWithVersion: BaseType
    {
        #region members

        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        [JsonProperty("permissionsGroup")]
        public PermissionsGroup? PermissionsGroup { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PermissionsGroupWithVersion";
    }

    public PermissionsGroupWithVersion Set(
        PermissionsGroup? PermissionsGroup = null,
        System.Int32? Version = null
    ) 
    {
        if ( PermissionsGroup != null ) {
            this.PermissionsGroup = PermissionsGroup;
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
        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        if (this.PermissionsGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionsGroup\n" ;
            } else {
                s += ind + "permissionsGroup\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        if (ec.Includes("permissionsGroup",true))
        {
            if(this.PermissionsGroup == null) {

                this.PermissionsGroup = new PermissionsGroup();

            } else {


            }
        }
        else if (this.PermissionsGroup != null && ec.Excludes("permissionsGroup",true))
        {
            this.PermissionsGroup = null;
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

    } // class PermissionsGroupWithVersion
    
    #endregion

    public static class ListPermissionsGroupWithVersionExtensions
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
            this List<PermissionsGroupWithVersion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PermissionsGroupWithVersion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PermissionsGroupWithVersion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PermissionsGroupWithVersion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PermissionsGroupWithVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
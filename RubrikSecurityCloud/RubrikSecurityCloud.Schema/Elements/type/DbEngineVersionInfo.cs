// DbEngineVersionInfo.cs
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
    #region DbEngineVersionInfo
    public class DbEngineVersionInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDifferentMajor
        // GraphQL -> isDifferentMajor: Boolean! (scalar)
        [JsonProperty("isDifferentMajor")]
        public System.Boolean? IsDifferentMajor { get; set; }

        //      C# -> System.Boolean? IsExtendedSupport
        // GraphQL -> isExtendedSupport: Boolean! (scalar)
        [JsonProperty("isExtendedSupport")]
        public System.Boolean? IsExtendedSupport { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DbEngineVersionInfo";
    }

    public DbEngineVersionInfo Set(
        System.Boolean? IsDifferentMajor = null,
        System.Boolean? IsExtendedSupport = null,
        System.String? Version = null
    ) 
    {
        if ( IsDifferentMajor != null ) {
            this.IsDifferentMajor = IsDifferentMajor;
        }
        if ( IsExtendedSupport != null ) {
            this.IsExtendedSupport = IsExtendedSupport;
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
        //      C# -> System.Boolean? IsDifferentMajor
        // GraphQL -> isDifferentMajor: Boolean! (scalar)
        if (this.IsDifferentMajor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDifferentMajor\n" ;
            } else {
                s += ind + "isDifferentMajor\n" ;
            }
        }
        //      C# -> System.Boolean? IsExtendedSupport
        // GraphQL -> isExtendedSupport: Boolean! (scalar)
        if (this.IsExtendedSupport != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExtendedSupport\n" ;
            } else {
                s += ind + "isExtendedSupport\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
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
        //      C# -> System.Boolean? IsDifferentMajor
        // GraphQL -> isDifferentMajor: Boolean! (scalar)
        if (ec.Includes("isDifferentMajor",true))
        {
            if(this.IsDifferentMajor == null) {

                this.IsDifferentMajor = true;

            } else {


            }
        }
        else if (this.IsDifferentMajor != null && ec.Excludes("isDifferentMajor",true))
        {
            this.IsDifferentMajor = null;
        }
        //      C# -> System.Boolean? IsExtendedSupport
        // GraphQL -> isExtendedSupport: Boolean! (scalar)
        if (ec.Includes("isExtendedSupport",true))
        {
            if(this.IsExtendedSupport == null) {

                this.IsExtendedSupport = true;

            } else {


            }
        }
        else if (this.IsExtendedSupport != null && ec.Excludes("isExtendedSupport",true))
        {
            this.IsExtendedSupport = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class DbEngineVersionInfo
    
    #endregion

    public static class ListDbEngineVersionInfoExtensions
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
            this List<DbEngineVersionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DbEngineVersionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DbEngineVersionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DbEngineVersionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DbEngineVersionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
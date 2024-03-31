// SddlPermission.cs
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
    #region SddlPermission
    public class SddlPermission: BaseType
    {
        #region members

        //      C# -> AceQualifier? AccessType
        // GraphQL -> accessType: AceQualifier! (enum)
        [JsonProperty("accessType")]
        public AceQualifier? AccessType { get; set; }

        //      C# -> List<AceFlags>? Flags
        // GraphQL -> flags: [AceFlags!]! (enum)
        [JsonProperty("flags")]
        public List<AceFlags>? Flags { get; set; }

        //      C# -> ResolutionType? ResolutionType
        // GraphQL -> resolutionType: ResolutionType! (enum)
        [JsonProperty("resolutionType")]
        public ResolutionType? ResolutionType { get; set; }

        //      C# -> System.String? Access
        // GraphQL -> access: String! (scalar)
        [JsonProperty("access")]
        public System.String? Access { get; set; }

        //      C# -> System.String? Cn
        // GraphQL -> cn: String! (scalar)
        [JsonProperty("cn")]
        public System.String? Cn { get; set; }

        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        [JsonProperty("dn")]
        public System.String? Dn { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SDDLPermission";
    }

    public SddlPermission Set(
        AceQualifier? AccessType = null,
        List<AceFlags>? Flags = null,
        ResolutionType? ResolutionType = null,
        System.String? Access = null,
        System.String? Cn = null,
        System.String? Dn = null
    ) 
    {
        if ( AccessType != null ) {
            this.AccessType = AccessType;
        }
        if ( Flags != null ) {
            this.Flags = Flags;
        }
        if ( ResolutionType != null ) {
            this.ResolutionType = ResolutionType;
        }
        if ( Access != null ) {
            this.Access = Access;
        }
        if ( Cn != null ) {
            this.Cn = Cn;
        }
        if ( Dn != null ) {
            this.Dn = Dn;
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
        //      C# -> AceQualifier? AccessType
        // GraphQL -> accessType: AceQualifier! (enum)
        if (this.AccessType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessType\n" ;
            } else {
                s += ind + "accessType\n" ;
            }
        }
        //      C# -> List<AceFlags>? Flags
        // GraphQL -> flags: [AceFlags!]! (enum)
        if (this.Flags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "flags\n" ;
            } else {
                s += ind + "flags\n" ;
            }
        }
        //      C# -> ResolutionType? ResolutionType
        // GraphQL -> resolutionType: ResolutionType! (enum)
        if (this.ResolutionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resolutionType\n" ;
            } else {
                s += ind + "resolutionType\n" ;
            }
        }
        //      C# -> System.String? Access
        // GraphQL -> access: String! (scalar)
        if (this.Access != null) {
            if (conf.Flat) {
                s += conf.Prefix + "access\n" ;
            } else {
                s += ind + "access\n" ;
            }
        }
        //      C# -> System.String? Cn
        // GraphQL -> cn: String! (scalar)
        if (this.Cn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cn\n" ;
            } else {
                s += ind + "cn\n" ;
            }
        }
        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        if (this.Dn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dn\n" ;
            } else {
                s += ind + "dn\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AceQualifier? AccessType
        // GraphQL -> accessType: AceQualifier! (enum)
        if (ec.Includes("accessType",true))
        {
            if(this.AccessType == null) {

                this.AccessType = new AceQualifier();

            } else {


            }
        }
        else if (this.AccessType != null && ec.Excludes("accessType",true))
        {
            this.AccessType = null;
        }
        //      C# -> List<AceFlags>? Flags
        // GraphQL -> flags: [AceFlags!]! (enum)
        if (ec.Includes("flags",true))
        {
            if(this.Flags == null) {

                this.Flags = new List<AceFlags>();

            } else {


            }
        }
        else if (this.Flags != null && ec.Excludes("flags",true))
        {
            this.Flags = null;
        }
        //      C# -> ResolutionType? ResolutionType
        // GraphQL -> resolutionType: ResolutionType! (enum)
        if (ec.Includes("resolutionType",true))
        {
            if(this.ResolutionType == null) {

                this.ResolutionType = new ResolutionType();

            } else {


            }
        }
        else if (this.ResolutionType != null && ec.Excludes("resolutionType",true))
        {
            this.ResolutionType = null;
        }
        //      C# -> System.String? Access
        // GraphQL -> access: String! (scalar)
        if (ec.Includes("access",true))
        {
            if(this.Access == null) {

                this.Access = "FETCH";

            } else {


            }
        }
        else if (this.Access != null && ec.Excludes("access",true))
        {
            this.Access = null;
        }
        //      C# -> System.String? Cn
        // GraphQL -> cn: String! (scalar)
        if (ec.Includes("cn",true))
        {
            if(this.Cn == null) {

                this.Cn = "FETCH";

            } else {


            }
        }
        else if (this.Cn != null && ec.Excludes("cn",true))
        {
            this.Cn = null;
        }
        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        if (ec.Includes("dn",true))
        {
            if(this.Dn == null) {

                this.Dn = "FETCH";

            } else {


            }
        }
        else if (this.Dn != null && ec.Excludes("dn",true))
        {
            this.Dn = null;
        }
    }


    #endregion

    } // class SddlPermission
    
    #endregion

    public static class ListSddlPermissionExtensions
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
            this List<SddlPermission> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SddlPermission> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SddlPermission> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SddlPermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SddlPermission> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AceQualifier? AccessType
        // GraphQL -> accessType: AceQualifier! (enum)
        if (this.AccessType != null) {
            s += ind + "accessType\n" ;
        }
        //      C# -> List<AceFlags>? Flags
        // GraphQL -> flags: [AceFlags!]! (enum)
        if (this.Flags != null) {
            s += ind + "flags\n" ;
        }
        //      C# -> ResolutionType? ResolutionType
        // GraphQL -> resolutionType: ResolutionType! (enum)
        if (this.ResolutionType != null) {
            s += ind + "resolutionType\n" ;
        }
        //      C# -> System.String? Access
        // GraphQL -> access: String! (scalar)
        if (this.Access != null) {
            s += ind + "access\n" ;
        }
        //      C# -> System.String? Cn
        // GraphQL -> cn: String! (scalar)
        if (this.Cn != null) {
            s += ind + "cn\n" ;
        }
        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        if (this.Dn != null) {
            s += ind + "dn\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AceQualifier? AccessType
        // GraphQL -> accessType: AceQualifier! (enum)
        if (this.AccessType == null && Exploration.Includes(parent + ".accessType", true))
        {
            this.AccessType = new AceQualifier();
        }
        //      C# -> List<AceFlags>? Flags
        // GraphQL -> flags: [AceFlags!]! (enum)
        if (this.Flags == null && Exploration.Includes(parent + ".flags", true))
        {
            this.Flags = new List<AceFlags>();
        }
        //      C# -> ResolutionType? ResolutionType
        // GraphQL -> resolutionType: ResolutionType! (enum)
        if (this.ResolutionType == null && Exploration.Includes(parent + ".resolutionType", true))
        {
            this.ResolutionType = new ResolutionType();
        }
        //      C# -> System.String? Access
        // GraphQL -> access: String! (scalar)
        if (this.Access == null && Exploration.Includes(parent + ".access", true))
        {
            this.Access = "FETCH";
        }
        //      C# -> System.String? Cn
        // GraphQL -> cn: String! (scalar)
        if (this.Cn == null && Exploration.Includes(parent + ".cn", true))
        {
            this.Cn = "FETCH";
        }
        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        if (this.Dn == null && Exploration.Includes(parent + ".dn", true))
        {
            this.Dn = "FETCH";
        }
    }


    #endregion

    } // class SddlPermission
    
    #endregion

    public static class ListSddlPermissionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<SddlPermission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SddlPermission> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SddlPermission());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
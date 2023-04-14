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

namespace Rubrik.SecurityCloud.Types
{
    #region SddlPermission
    public class SddlPermission: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public SddlPermission Set(
        System.String? Access = null,
        System.String? Cn = null,
        System.String? Dn = null,
        AceQualifier? AccessType = null,
        List<AceFlags>? Flags = null,
        ResolutionType? ResolutionType = null
    ) 
    {
        if ( Access != null ) {
            this.Access = Access;
        }
        if ( Cn != null ) {
            this.Cn = Cn;
        }
        if ( Dn != null ) {
            this.Dn = Dn;
        }
        if ( AccessType != null ) {
            this.AccessType = AccessType;
        }
        if ( Flags != null ) {
            this.Flags = Flags;
        }
        if ( ResolutionType != null ) {
            this.ResolutionType = ResolutionType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Access
            // GraphQL -> access: String! (scalar)
            if (this.Access != null)
            {
                 s += ind + "access\n";

            }
            //      C# -> System.String? Cn
            // GraphQL -> cn: String! (scalar)
            if (this.Cn != null)
            {
                 s += ind + "cn\n";

            }
            //      C# -> System.String? Dn
            // GraphQL -> dn: String! (scalar)
            if (this.Dn != null)
            {
                 s += ind + "dn\n";

            }
            //      C# -> AceQualifier? AccessType
            // GraphQL -> accessType: AceQualifier! (enum)
            if (this.AccessType != null)
            {
                 s += ind + "accessType\n";

            }
            //      C# -> List<AceFlags>? Flags
            // GraphQL -> flags: [AceFlags!]! (enum)
            if (this.Flags != null)
            {
                 s += ind + "flags\n";

            }
            //      C# -> ResolutionType? ResolutionType
            // GraphQL -> resolutionType: ResolutionType! (enum)
            if (this.ResolutionType != null)
            {
                 s += ind + "resolutionType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Access
            // GraphQL -> access: String! (scalar)
            if (this.Access == null && Exploration.Includes(parent + ".access$"))
            {
                this.Access = new System.String("FETCH");
            }
            //      C# -> System.String? Cn
            // GraphQL -> cn: String! (scalar)
            if (this.Cn == null && Exploration.Includes(parent + ".cn$"))
            {
                this.Cn = new System.String("FETCH");
            }
            //      C# -> System.String? Dn
            // GraphQL -> dn: String! (scalar)
            if (this.Dn == null && Exploration.Includes(parent + ".dn$"))
            {
                this.Dn = new System.String("FETCH");
            }
            //      C# -> AceQualifier? AccessType
            // GraphQL -> accessType: AceQualifier! (enum)
            if (this.AccessType == null && Exploration.Includes(parent + ".accessType$"))
            {
                this.AccessType = new AceQualifier();
            }
            //      C# -> List<AceFlags>? Flags
            // GraphQL -> flags: [AceFlags!]! (enum)
            if (this.Flags == null && Exploration.Includes(parent + ".flags$"))
            {
                this.Flags = new List<AceFlags>();
            }
            //      C# -> ResolutionType? ResolutionType
            // GraphQL -> resolutionType: ResolutionType! (enum)
            if (this.ResolutionType == null && Exploration.Includes(parent + ".resolutionType$"))
            {
                this.ResolutionType = new ResolutionType();
            }
        }


    #endregion

    } // class SddlPermission
    #endregion

    public static class ListSddlPermissionExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<SddlPermission> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SddlPermission> list, 
            String parent = "")
        {
            var item = new SddlPermission();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
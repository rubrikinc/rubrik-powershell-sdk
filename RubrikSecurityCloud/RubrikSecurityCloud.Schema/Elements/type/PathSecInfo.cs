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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner != null) {
            s += ind + "owner\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> List<SddlPermission>? Permissions
        // GraphQL -> permissions: [SDDLPermission!]! (type)
        if (this.Permissions != null) {
            s += ind + "permissions {\n" + this.Permissions.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner == null && Exploration.Includes(parent + ".owner", true))
        {
            this.Owner = new System.String("FETCH");
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = new System.String("FETCH");
        }
        //      C# -> List<SddlPermission>? Permissions
        // GraphQL -> permissions: [SDDLPermission!]! (type)
        if (this.Permissions == null && Exploration.Includes(parent + ".permissions"))
        {
            this.Permissions = new List<SddlPermission>();
            this.Permissions.ApplyExploratoryFieldSpec(parent + ".permissions");
        }
    }


    #endregion

    } // class PathSecInfo
    
    #endregion

    public static class ListPathSecInfoExtensions
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
            this List<PathSecInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PathSecInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PathSecInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
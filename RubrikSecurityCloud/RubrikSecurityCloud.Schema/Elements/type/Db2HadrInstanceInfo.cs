// Db2HadrInstanceInfo.cs
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
    #region Db2HadrInstanceInfo
    public class Db2HadrInstanceInfo: BaseType
    {
        #region members

        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }

        //      C# -> Db2Instance? Db2Instance
        // GraphQL -> db2Instance: Db2Instance! (type)
        [JsonProperty("db2Instance")]
        public Db2Instance? Db2Instance { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2HadrInstanceInfo";
    }

    public Db2HadrInstanceInfo Set(
        System.String? Role = null,
        Db2Instance? Db2Instance = null
    ) 
    {
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( Db2Instance != null ) {
            this.Db2Instance = Db2Instance;
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
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role != null) {
            s += ind + "role\n" ;
        }
        //      C# -> Db2Instance? Db2Instance
        // GraphQL -> db2Instance: Db2Instance! (type)
        if (this.Db2Instance != null) {
            var fspec = this.Db2Instance.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "db2Instance {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role == null && Exploration.Includes(parent + ".role", true))
        {
            this.Role = "FETCH";
        }
        //      C# -> Db2Instance? Db2Instance
        // GraphQL -> db2Instance: Db2Instance! (type)
        if (this.Db2Instance == null && Exploration.Includes(parent + ".db2Instance"))
        {
            this.Db2Instance = new Db2Instance();
            this.Db2Instance.ApplyExploratoryFieldSpec(parent + ".db2Instance");
        }
    }


    #endregion

    } // class Db2HadrInstanceInfo
    
    #endregion

    public static class ListDb2HadrInstanceInfoExtensions
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
            this List<Db2HadrInstanceInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2HadrInstanceInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2HadrInstanceInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
// DataGuardGroupMember.cs
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
    #region DataGuardGroupMember
    public class DataGuardGroupMember: BaseType
    {
        #region members

        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        [JsonProperty("dbUniqueName")]
        public System.String? DbUniqueName { get; set; }

        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        [JsonProperty("racId")]
        public System.String? RacId { get; set; }

        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        [JsonProperty("racName")]
        public System.String? RacName { get; set; }

        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }

        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        [JsonProperty("standaloneHostId")]
        public System.String? StandaloneHostId { get; set; }

        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        [JsonProperty("standaloneHostName")]
        public System.String? StandaloneHostName { get; set; }


        #endregion

    #region methods

    public DataGuardGroupMember Set(
        System.String? DbUniqueName = null,
        System.String? RacId = null,
        System.String? RacName = null,
        System.String? Role = null,
        System.String? StandaloneHostId = null,
        System.String? StandaloneHostName = null
    ) 
    {
        if ( DbUniqueName != null ) {
            this.DbUniqueName = DbUniqueName;
        }
        if ( RacId != null ) {
            this.RacId = RacId;
        }
        if ( RacName != null ) {
            this.RacName = RacName;
        }
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( StandaloneHostId != null ) {
            this.StandaloneHostId = StandaloneHostId;
        }
        if ( StandaloneHostName != null ) {
            this.StandaloneHostName = StandaloneHostName;
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
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        if (this.DbUniqueName != null) {
            s += ind + "dbUniqueName\n" ;
        }
        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        if (this.RacId != null) {
            s += ind + "racId\n" ;
        }
        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        if (this.RacName != null) {
            s += ind + "racName\n" ;
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role != null) {
            s += ind + "role\n" ;
        }
        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        if (this.StandaloneHostId != null) {
            s += ind + "standaloneHostId\n" ;
        }
        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        if (this.StandaloneHostName != null) {
            s += ind + "standaloneHostName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        if (this.DbUniqueName == null && Exploration.Includes(parent + ".dbUniqueName", true))
        {
            this.DbUniqueName = new System.String("FETCH");
        }
        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        if (this.RacId == null && Exploration.Includes(parent + ".racId", true))
        {
            this.RacId = new System.String("FETCH");
        }
        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        if (this.RacName == null && Exploration.Includes(parent + ".racName", true))
        {
            this.RacName = new System.String("FETCH");
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role == null && Exploration.Includes(parent + ".role", true))
        {
            this.Role = new System.String("FETCH");
        }
        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        if (this.StandaloneHostId == null && Exploration.Includes(parent + ".standaloneHostId", true))
        {
            this.StandaloneHostId = new System.String("FETCH");
        }
        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        if (this.StandaloneHostName == null && Exploration.Includes(parent + ".standaloneHostName", true))
        {
            this.StandaloneHostName = new System.String("FETCH");
        }
    }


    #endregion

    } // class DataGuardGroupMember
    
    #endregion

    public static class ListDataGuardGroupMemberExtensions
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
            this List<DataGuardGroupMember> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DataGuardGroupMember> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DataGuardGroupMember());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
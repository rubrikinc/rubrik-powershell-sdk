// MssqlRootProperties.cs
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
    #region MssqlRootProperties
    public class MssqlRootProperties: BaseType
    {
        #region members

        //      C# -> MssqlRootPropertiesRootType? RootType
        // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
        [JsonProperty("rootType")]
        public MssqlRootPropertiesRootType? RootType { get; set; }

        //      C# -> System.String? RootId
        // GraphQL -> rootId: String (scalar)
        [JsonProperty("rootId")]
        public System.String? RootId { get; set; }

        //      C# -> System.String? RootName
        // GraphQL -> rootName: String! (scalar)
        [JsonProperty("rootName")]
        public System.String? RootName { get; set; }

        //      C# -> System.String? RootRole
        // GraphQL -> rootRole: String (scalar)
        [JsonProperty("rootRole")]
        public System.String? RootRole { get; set; }


        #endregion

    #region methods

    public MssqlRootProperties Set(
        MssqlRootPropertiesRootType? RootType = null,
        System.String? RootId = null,
        System.String? RootName = null,
        System.String? RootRole = null
    ) 
    {
        if ( RootType != null ) {
            this.RootType = RootType;
        }
        if ( RootId != null ) {
            this.RootId = RootId;
        }
        if ( RootName != null ) {
            this.RootName = RootName;
        }
        if ( RootRole != null ) {
            this.RootRole = RootRole;
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
        //      C# -> MssqlRootPropertiesRootType? RootType
        // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
        if (this.RootType != null) {
            s += ind + "rootType\n" ;
        }
        //      C# -> System.String? RootId
        // GraphQL -> rootId: String (scalar)
        if (this.RootId != null) {
            s += ind + "rootId\n" ;
        }
        //      C# -> System.String? RootName
        // GraphQL -> rootName: String! (scalar)
        if (this.RootName != null) {
            s += ind + "rootName\n" ;
        }
        //      C# -> System.String? RootRole
        // GraphQL -> rootRole: String (scalar)
        if (this.RootRole != null) {
            s += ind + "rootRole\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MssqlRootPropertiesRootType? RootType
        // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
        if (this.RootType == null && Exploration.Includes(parent + ".rootType", true))
        {
            this.RootType = new MssqlRootPropertiesRootType();
        }
        //      C# -> System.String? RootId
        // GraphQL -> rootId: String (scalar)
        if (this.RootId == null && Exploration.Includes(parent + ".rootId", true))
        {
            this.RootId = "FETCH";
        }
        //      C# -> System.String? RootName
        // GraphQL -> rootName: String! (scalar)
        if (this.RootName == null && Exploration.Includes(parent + ".rootName", true))
        {
            this.RootName = "FETCH";
        }
        //      C# -> System.String? RootRole
        // GraphQL -> rootRole: String (scalar)
        if (this.RootRole == null && Exploration.Includes(parent + ".rootRole", true))
        {
            this.RootRole = "FETCH";
        }
    }


    #endregion

    } // class MssqlRootProperties
    
    #endregion

    public static class ListMssqlRootPropertiesExtensions
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
            this List<MssqlRootProperties> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlRootProperties> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlRootProperties());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
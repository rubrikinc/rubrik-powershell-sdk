// GetUserDetailReply.cs
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
    #region GetUserDetailReply
    public class GetUserDetailReply: BaseType
    {
        #region members

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumFilesAccessible
        // GraphQL -> numFilesAccessible: Int! (scalar)
        [JsonProperty("numFilesAccessible")]
        public System.Int32? NumFilesAccessible { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetUserDetailReply";
    }

    public GetUserDetailReply Set(
        RiskLevelType? Risk = null,
        System.String? Location = null,
        System.String? Name = null,
        System.Int32? NumFilesAccessible = null
    ) 
    {
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumFilesAccessible != null ) {
            this.NumFilesAccessible = NumFilesAccessible;
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
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            s += ind + "risk\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumFilesAccessible
        // GraphQL -> numFilesAccessible: Int! (scalar)
        if (this.NumFilesAccessible != null) {
            s += ind + "numFilesAccessible\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk == null && Exploration.Includes(parent + ".risk", true))
        {
            this.Risk = new RiskLevelType();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && Exploration.Includes(parent + ".location", true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumFilesAccessible
        // GraphQL -> numFilesAccessible: Int! (scalar)
        if (this.NumFilesAccessible == null && Exploration.Includes(parent + ".numFilesAccessible", true))
        {
            this.NumFilesAccessible = Int32.MinValue;
        }
    }


    #endregion

    } // class GetUserDetailReply
    
    #endregion

    public static class ListGetUserDetailReplyExtensions
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
            this List<GetUserDetailReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetUserDetailReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetUserDetailReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
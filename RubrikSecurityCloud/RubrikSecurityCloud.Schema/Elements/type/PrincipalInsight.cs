// PrincipalInsight.cs
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
    #region PrincipalInsight
    public class PrincipalInsight: BaseType
    {
        #region members

        //      C# -> UserAccessInsightType? Type
        // GraphQL -> type: UserAccessInsightType! (enum)
        [JsonProperty("type")]
        public UserAccessInsightType? Type { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalInsight";
    }

    public PrincipalInsight Set(
        UserAccessInsightType? Type = null,
        System.String? Message = null,
        DateTime? Time = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( Time != null ) {
            this.Time = Time;
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
        //      C# -> UserAccessInsightType? Type
        // GraphQL -> type: UserAccessInsightType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            s += ind + "time\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> UserAccessInsightType? Type
        // GraphQL -> type: UserAccessInsightType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new UserAccessInsightType();
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time == null && Exploration.Includes(parent + ".time", true))
        {
            this.Time = new DateTime();
        }
    }


    #endregion

    } // class PrincipalInsight
    
    #endregion

    public static class ListPrincipalInsightExtensions
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
            this List<PrincipalInsight> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalInsight> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalInsight());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
// StatusResponse.cs
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
    #region StatusResponse
    public class StatusResponse: BaseType
    {
        #region members

        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        [JsonProperty("code")]
        public System.String? Code { get; set; }

        //      C# -> System.String? Excepshuns
        // GraphQL -> excepshuns: String! (scalar)
        [JsonProperty("excepshuns")]
        public System.String? Excepshuns { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public StatusResponse Set(
        System.String? Code = null,
        System.String? Excepshuns = null,
        System.String? Message = null
    ) 
    {
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( Excepshuns != null ) {
            this.Excepshuns = Excepshuns;
        }
        if ( Message != null ) {
            this.Message = Message;
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
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (this.Code != null) {
            s += ind + "code\n" ;
        }
        //      C# -> System.String? Excepshuns
        // GraphQL -> excepshuns: String! (scalar)
        if (this.Excepshuns != null) {
            s += ind + "excepshuns\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (this.Code == null && Exploration.Includes(parent + ".code", true))
        {
            this.Code = "FETCH";
        }
        //      C# -> System.String? Excepshuns
        // GraphQL -> excepshuns: String! (scalar)
        if (this.Excepshuns == null && Exploration.Includes(parent + ".excepshuns", true))
        {
            this.Excepshuns = "FETCH";
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
    }


    #endregion

    } // class StatusResponse
    
    #endregion

    public static class ListStatusResponseExtensions
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
            this List<StatusResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StatusResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new StatusResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
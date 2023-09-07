// RegisterCloudClusterReply.cs
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
    #region RegisterCloudClusterReply
    public class RegisterCloudClusterReply: BaseType
    {
        #region members

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        [JsonProperty("isSuccessful")]
        public System.Boolean? IsSuccessful { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RegisterCloudClusterReply";
    }

    public RegisterCloudClusterReply Set(
        System.String? Error = null,
        System.Boolean? IsSuccessful = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
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
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful != null) {
            s += ind + "isSuccessful\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error == null && ec.Includes("error",true))
        {
            this.Error = "FETCH";
        }
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful == null && ec.Includes("isSuccessful",true))
        {
            this.IsSuccessful = true;
        }
    }


    #endregion

    } // class RegisterCloudClusterReply
    
    #endregion

    public static class ListRegisterCloudClusterReplyExtensions
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
            this List<RegisterCloudClusterReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RegisterCloudClusterReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RegisterCloudClusterReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RegisterCloudClusterReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
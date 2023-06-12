// CreateOrgSwitchSessionReply.cs
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
    #region CreateOrgSwitchSessionReply
    public class CreateOrgSwitchSessionReply: BaseType
    {
        #region members

        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        [JsonProperty("accessToken")]
        public System.String? AccessToken { get; set; }


        #endregion

    #region methods

    public CreateOrgSwitchSessionReply Set(
        System.String? AccessToken = null
    ) 
    {
        if ( AccessToken != null ) {
            this.AccessToken = AccessToken;
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
        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        if (this.AccessToken != null) {
            s += ind + "accessToken\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        if (this.AccessToken == null && Exploration.Includes(parent + ".accessToken", true))
        {
            this.AccessToken = "FETCH";
        }
    }


    #endregion

    } // class CreateOrgSwitchSessionReply
    
    #endregion

    public static class ListCreateOrgSwitchSessionReplyExtensions
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
            this List<CreateOrgSwitchSessionReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateOrgSwitchSessionReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateOrgSwitchSessionReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
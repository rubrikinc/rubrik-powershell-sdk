// StartAzureCloudAccountOauthReply.cs
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
    #region StartAzureCloudAccountOauthReply
    public class StartAzureCloudAccountOauthReply: BaseType
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }


        #endregion

    #region methods

    public StartAzureCloudAccountOauthReply Set(
        System.String? ClientId = null,
        System.String? SessionId = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
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
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            s += ind + "clientId\n" ;
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId != null) {
            s += ind + "sessionId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId == null && Exploration.Includes(parent + ".clientId", true))
        {
            this.ClientId = "FETCH";
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId == null && Exploration.Includes(parent + ".sessionId", true))
        {
            this.SessionId = "FETCH";
        }
    }


    #endregion

    } // class StartAzureCloudAccountOauthReply
    
    #endregion

    public static class ListStartAzureCloudAccountOauthReplyExtensions
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
            this List<StartAzureCloudAccountOauthReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StartAzureCloudAccountOauthReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new StartAzureCloudAccountOauthReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// RestoreFormComputeProxyConfig.cs
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
    #region RestoreFormComputeProxyConfig
    public class RestoreFormComputeProxyConfig: BaseType
    {
        #region members

        //      C# -> System.String? ProxyServer
        // GraphQL -> proxyServer: String (scalar)
        [JsonProperty("proxyServer")]
        public System.String? ProxyServer { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RestoreFormComputeProxyConfig";
    }

    public RestoreFormComputeProxyConfig Set(
        System.String? ProxyServer = null
    ) 
    {
        if ( ProxyServer != null ) {
            this.ProxyServer = ProxyServer;
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
        //      C# -> System.String? ProxyServer
        // GraphQL -> proxyServer: String (scalar)
        if (this.ProxyServer != null) {
            s += ind + "proxyServer\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ProxyServer
        // GraphQL -> proxyServer: String (scalar)
        if (this.ProxyServer == null && Exploration.Includes(parent + ".proxyServer", true))
        {
            this.ProxyServer = "FETCH";
        }
    }


    #endregion

    } // class RestoreFormComputeProxyConfig
    
    #endregion

    public static class ListRestoreFormComputeProxyConfigExtensions
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
            this List<RestoreFormComputeProxyConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormComputeProxyConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormComputeProxyConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
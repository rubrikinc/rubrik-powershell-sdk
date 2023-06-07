// MongodbHost.cs
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
    #region MongodbHost
    public class MongodbHost: BaseType
    {
        #region members

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Port
        // GraphQL -> port: String! (scalar)
        [JsonProperty("port")]
        public System.String? Port { get; set; }


        #endregion

    #region methods

    public MongodbHost Set(
        System.String? Hostname = null,
        System.String? Port = null
    ) 
    {
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Port != null ) {
            this.Port = Port;
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
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Port
        // GraphQL -> port: String! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? Port
        // GraphQL -> port: String! (scalar)
        if (this.Port == null && Exploration.Includes(parent + ".port", true))
        {
            this.Port = "FETCH";
        }
    }


    #endregion

    } // class MongodbHost
    
    #endregion

    public static class ListMongodbHostExtensions
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
            this List<MongodbHost> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongodbHost> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MongodbHost());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
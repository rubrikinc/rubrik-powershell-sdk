// OracleInstanceProperties.cs
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
    #region OracleInstanceProperties
    public class OracleInstanceProperties: BaseType
    {
        #region members

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? InstanceSid
        // GraphQL -> instanceSid: String! (scalar)
        [JsonProperty("instanceSid")]
        public System.String? InstanceSid { get; set; }


        #endregion

    #region methods

    public OracleInstanceProperties Set(
        System.String? HostName = null,
        System.String? InstanceSid = null
    ) 
    {
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( InstanceSid != null ) {
            this.InstanceSid = InstanceSid;
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
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? InstanceSid
        // GraphQL -> instanceSid: String! (scalar)
        if (this.InstanceSid != null) {
            s += ind + "instanceSid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = new System.String("FETCH");
        }
        //      C# -> System.String? InstanceSid
        // GraphQL -> instanceSid: String! (scalar)
        if (this.InstanceSid == null && Exploration.Includes(parent + ".instanceSid", true))
        {
            this.InstanceSid = new System.String("FETCH");
        }
    }


    #endregion

    } // class OracleInstanceProperties
    
    #endregion

    public static class ListOracleInstancePropertiesExtensions
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
            this List<OracleInstanceProperties> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleInstanceProperties> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleInstanceProperties());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
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

namespace Rubrik.SecurityCloud.Types
{
    #region OracleInstanceProperties
    public class OracleInstanceProperties: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName != null)
            {
                 s += ind + "hostName\n";

            }
            //      C# -> System.String? InstanceSid
            // GraphQL -> instanceSid: String! (scalar)
            if (this.InstanceSid != null)
            {
                 s += ind + "instanceSid\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName == null && Exploration.Includes(parent + ".hostName$"))
            {
                this.HostName = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceSid
            // GraphQL -> instanceSid: String! (scalar)
            if (this.InstanceSid == null && Exploration.Includes(parent + ".instanceSid$"))
            {
                this.InstanceSid = new System.String("FETCH");
            }
        }


    #endregion

    } // class OracleInstanceProperties
    #endregion

    public static class ListOracleInstancePropertiesExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<OracleInstanceProperties> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleInstanceProperties> list, 
            String parent = "")
        {
            var item = new OracleInstanceProperties();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
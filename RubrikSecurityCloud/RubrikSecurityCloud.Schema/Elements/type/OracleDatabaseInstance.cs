// OracleDatabaseInstance.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:56.
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
    #region OracleDatabaseInstance
    public class OracleDatabaseInstance: IFragment
    {
        #region members
        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        #endregion

    #region methods

    public OracleDatabaseInstance Set(
        System.String? HostId = null,
        System.String? InstanceName = null
    ) 
    {
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
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
            //      C# -> System.String? HostId
            // GraphQL -> hostId: UUID! (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.String? InstanceName
            // GraphQL -> instanceName: String! (scalar)
            if (this.InstanceName != null)
            {
                 s += ind + "instanceName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HostId
            // GraphQL -> hostId: UUID! (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceName
            // GraphQL -> instanceName: String! (scalar)
            if (this.InstanceName == null && Exploration.Includes(parent + ".instanceName$"))
            {
                this.InstanceName = new System.String("FETCH");
            }
        }


    #endregion

    } // class OracleDatabaseInstance
    #endregion

    public static class ListOracleDatabaseInstanceExtensions
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
            this List<OracleDatabaseInstance> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleDatabaseInstance> list, 
            String parent = "")
        {
            var item = new OracleDatabaseInstance();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
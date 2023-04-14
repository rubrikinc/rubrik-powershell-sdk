// ClusterHostGroupInfo.cs
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
    #region ClusterHostGroupInfo
    public class ClusterHostGroupInfo: IFragment
    {
        #region members
        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        [JsonProperty("datacenterName")]
        public System.String? DatacenterName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<HostGroupInfo>? HostGroups
        // GraphQL -> hostGroups: [HostGroupInfo!]! (type)
        [JsonProperty("hostGroups")]
        public List<HostGroupInfo>? HostGroups { get; set; }

        #endregion

    #region methods

    public ClusterHostGroupInfo Set(
        System.String? DatacenterName = null,
        System.String? Id = null,
        System.String? Name = null,
        List<HostGroupInfo>? HostGroups = null
    ) 
    {
        if ( DatacenterName != null ) {
            this.DatacenterName = DatacenterName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( HostGroups != null ) {
            this.HostGroups = HostGroups;
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
            //      C# -> System.String? DatacenterName
            // GraphQL -> datacenterName: String! (scalar)
            if (this.DatacenterName != null)
            {
                 s += ind + "datacenterName\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> List<HostGroupInfo>? HostGroups
            // GraphQL -> hostGroups: [HostGroupInfo!]! (type)
            if (this.HostGroups != null)
            {
                 s += ind + "hostGroups\n";

                 s += ind + "{\n" + 
                 this.HostGroups.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DatacenterName
            // GraphQL -> datacenterName: String! (scalar)
            if (this.DatacenterName == null && Exploration.Includes(parent + ".datacenterName$"))
            {
                this.DatacenterName = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> List<HostGroupInfo>? HostGroups
            // GraphQL -> hostGroups: [HostGroupInfo!]! (type)
            if (this.HostGroups == null && Exploration.Includes(parent + ".hostGroups"))
            {
                this.HostGroups = new List<HostGroupInfo>();
                this.HostGroups.ApplyExploratoryFragment(parent + ".hostGroups");
            }
        }


    #endregion

    } // class ClusterHostGroupInfo
    #endregion

    public static class ListClusterHostGroupInfoExtensions
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
            this List<ClusterHostGroupInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterHostGroupInfo> list, 
            String parent = "")
        {
            var item = new ClusterHostGroupInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
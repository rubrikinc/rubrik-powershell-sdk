// Vnet.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:54.
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
    #region Vnet
    public class Vnet: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        [JsonProperty("regionName")]
        public System.String? RegionName { get; set; }

        //      C# -> ResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroup (type)
        [JsonProperty("resourceGroup")]
        public ResourceGroup? ResourceGroup { get; set; }

        #endregion

    #region methods

    public Vnet Set(
        System.String? Id = null,
        System.String? Name = null,
        System.String? RegionName = null,
        ResourceGroup? ResourceGroup = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RegionName != null ) {
            this.RegionName = RegionName;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
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
            //      C# -> System.String? RegionName
            // GraphQL -> regionName: String! (scalar)
            if (this.RegionName != null)
            {
                 s += ind + "regionName\n";

            }
            //      C# -> ResourceGroup? ResourceGroup
            // GraphQL -> resourceGroup: ResourceGroup (type)
            if (this.ResourceGroup != null)
            {
                 s += ind + "resourceGroup\n";

                 s += ind + "{\n" + 
                 this.ResourceGroup.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
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
            //      C# -> System.String? RegionName
            // GraphQL -> regionName: String! (scalar)
            if (this.RegionName == null && Exploration.Includes(parent + ".regionName$"))
            {
                this.RegionName = new System.String("FETCH");
            }
            //      C# -> ResourceGroup? ResourceGroup
            // GraphQL -> resourceGroup: ResourceGroup (type)
            if (this.ResourceGroup == null && Exploration.Includes(parent + ".resourceGroup"))
            {
                this.ResourceGroup = new ResourceGroup();
                this.ResourceGroup.ApplyExploratoryFragment(parent + ".resourceGroup");
            }
        }


    #endregion

    } // class Vnet
    #endregion

    public static class ListVnetExtensions
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
            this List<Vnet> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Vnet> list, 
            String parent = "")
        {
            var item = new Vnet();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
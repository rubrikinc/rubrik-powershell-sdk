// InterfaceCidr.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
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
    #region InterfaceCidr
    public class InterfaceCidr: IFragment
    {
        #region members
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        [JsonProperty("cidr")]
        public System.String? Cidr { get; set; }

        //      C# -> System.Boolean? Selected
        // GraphQL -> selected: Boolean! (scalar)
        [JsonProperty("selected")]
        public System.Boolean? Selected { get; set; }

        //      C# -> InterfaceType? InterfaceType
        // GraphQL -> interfaceType: InterfaceType! (enum)
        [JsonProperty("interfaceType")]
        public InterfaceType? InterfaceType { get; set; }

        #endregion

    #region methods

    public InterfaceCidr Set(
        System.String? Cidr = null,
        System.Boolean? Selected = null,
        InterfaceType? InterfaceType = null
    ) 
    {
        if ( Cidr != null ) {
            this.Cidr = Cidr;
        }
        if ( Selected != null ) {
            this.Selected = Selected;
        }
        if ( InterfaceType != null ) {
            this.InterfaceType = InterfaceType;
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
            //      C# -> System.String? Cidr
            // GraphQL -> cidr: String! (scalar)
            if (this.Cidr != null)
            {
                 s += ind + "cidr\n";

            }
            //      C# -> System.Boolean? Selected
            // GraphQL -> selected: Boolean! (scalar)
            if (this.Selected != null)
            {
                 s += ind + "selected\n";

            }
            //      C# -> InterfaceType? InterfaceType
            // GraphQL -> interfaceType: InterfaceType! (enum)
            if (this.InterfaceType != null)
            {
                 s += ind + "interfaceType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Cidr
            // GraphQL -> cidr: String! (scalar)
            if (this.Cidr == null && Exploration.Includes(parent + ".cidr$"))
            {
                this.Cidr = new System.String("FETCH");
            }
            //      C# -> System.Boolean? Selected
            // GraphQL -> selected: Boolean! (scalar)
            if (this.Selected == null && Exploration.Includes(parent + ".selected$"))
            {
                this.Selected = new System.Boolean();
            }
            //      C# -> InterfaceType? InterfaceType
            // GraphQL -> interfaceType: InterfaceType! (enum)
            if (this.InterfaceType == null && Exploration.Includes(parent + ".interfaceType$"))
            {
                this.InterfaceType = new InterfaceType();
            }
        }


    #endregion

    } // class InterfaceCidr
    #endregion

    public static class ListInterfaceCidrExtensions
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
            this List<InterfaceCidr> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<InterfaceCidr> list, 
            String parent = "")
        {
            var item = new InterfaceCidr();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
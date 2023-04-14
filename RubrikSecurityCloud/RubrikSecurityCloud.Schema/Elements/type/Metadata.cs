// Metadata.cs
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
    #region Metadata
    public class Metadata: IFragment
    {
        #region members
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> Value? Value
        // GraphQL -> value: Value (interface)
        [JsonProperty("value")]
        public Value? Value { get; set; }

        #endregion

    #region methods

    public Metadata Set(
        System.String? Key = null,
        Value? Value = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( Value != null ) {
            this.Value = Value;
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
            //      C# -> System.String? Key
            // GraphQL -> key: String! (scalar)
            if (this.Key != null)
            {
                 s += ind + "key\n";

            }
                        //      C# -> Value? Value
            // GraphQL -> value: Value (interface)
            if (this.Value != null)
            {
                s += ind + "value\n";
                s += ind + "{\n";

                string typename = this.Value.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.Value.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Key
            // GraphQL -> key: String! (scalar)
            if (this.Key == null && Exploration.Includes(parent + ".key$"))
            {
                this.Key = new System.String("FETCH");
            }
            //      C# -> Value? Value
            // GraphQL -> value: Value (interface)
            if (this.Value == null && Exploration.Includes(parent + ".value"))
            {
                this.Value = (Value)InterfaceHelper.CreateInstanceOfFirstType(typeof(Value));
                this.Value.ApplyExploratoryFragment(parent + ".value");
            }
        }


    #endregion

    } // class Metadata
    #endregion

    public static class ListMetadataExtensions
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
            this List<Metadata> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Metadata> list, 
            String parent = "")
        {
            var item = new Metadata();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
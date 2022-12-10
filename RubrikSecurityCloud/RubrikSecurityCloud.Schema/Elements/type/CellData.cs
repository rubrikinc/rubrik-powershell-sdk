// CellData.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:59.
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
    #region CellData
    public class CellData: IFragment
    {
        #region members
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }

        //      C# -> DisplayableValue? DisplayableValue
        // GraphQL -> displayableValue: DisplayableValue (interface)
        [JsonProperty("displayableValue")]
        public DisplayableValue? DisplayableValue { get; set; }

        #endregion

    #region methods

    public CellData Set(
        List<Metadata>? Metadata = null,
        DisplayableValue? DisplayableValue = null
    ) 
    {
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( DisplayableValue != null ) {
            this.DisplayableValue = DisplayableValue;
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
            //      C# -> List<Metadata>? Metadata
            // GraphQL -> metadata: [Metadata!]! (type)
            if (this.Metadata != null)
            {
                 s += ind + "metadata\n";

                 s += ind + "{\n" + 
                 this.Metadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
                        //      C# -> DisplayableValue? DisplayableValue
            // GraphQL -> displayableValue: DisplayableValue (interface)
            if (this.DisplayableValue != null)
            {
                s += ind + "displayableValue\n";
                s += ind + "{\n";

                string typename = this.DisplayableValue.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.DisplayableValue.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<Metadata>? Metadata
            // GraphQL -> metadata: [Metadata!]! (type)
            if (this.Metadata == null && Exploration.Includes(parent + ".metadata"))
            {
                this.Metadata = new List<Metadata>();
                this.Metadata.ApplyExploratoryFragment(parent + ".metadata");
            }
            //      C# -> DisplayableValue? DisplayableValue
            // GraphQL -> displayableValue: DisplayableValue (interface)
            if (this.DisplayableValue == null && Exploration.Includes(parent + ".displayableValue"))
            {
                this.DisplayableValue = (DisplayableValue)InterfaceHelper.CreateInstanceOfFirstType(typeof(DisplayableValue));
                this.DisplayableValue.ApplyExploratoryFragment(parent + ".displayableValue");
            }
        }


    #endregion

    } // class CellData
    #endregion

    public static class ListCellDataExtensions
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
            this List<CellData> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CellData> list, 
            String parent = "")
        {
            var item = new CellData();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
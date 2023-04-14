// CascadingArchivalSpec.cs
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
    #region CascadingArchivalSpec
    public class CascadingArchivalSpec: IFragment
    {
        #region members
        //      C# -> Duration? ArchivalThreshold
        // GraphQL -> archivalThreshold: Duration (type)
        [JsonProperty("archivalThreshold")]
        public Duration? ArchivalThreshold { get; set; }

        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        [JsonProperty("archivalTieringSpec")]
        public ArchivalTieringSpec? ArchivalTieringSpec { get; set; }

        //      C# -> List<RetentionUnit>? Frequency
        // GraphQL -> frequency: [RetentionUnit!]! (enum)
        [JsonProperty("frequency")]
        public List<RetentionUnit>? Frequency { get; set; }

        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target (interface)
        [JsonProperty("archivalLocation")]
        public Target? ArchivalLocation { get; set; }

        #endregion

    #region methods

    public CascadingArchivalSpec Set(
        Duration? ArchivalThreshold = null,
        ArchivalTieringSpec? ArchivalTieringSpec = null,
        List<RetentionUnit>? Frequency = null,
        Target? ArchivalLocation = null
    ) 
    {
        if ( ArchivalThreshold != null ) {
            this.ArchivalThreshold = ArchivalThreshold;
        }
        if ( ArchivalTieringSpec != null ) {
            this.ArchivalTieringSpec = ArchivalTieringSpec;
        }
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( ArchivalLocation != null ) {
            this.ArchivalLocation = ArchivalLocation;
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
            //      C# -> Duration? ArchivalThreshold
            // GraphQL -> archivalThreshold: Duration (type)
            if (this.ArchivalThreshold != null)
            {
                 s += ind + "archivalThreshold\n";

                 s += ind + "{\n" + 
                 this.ArchivalThreshold.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
            // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
            if (this.ArchivalTieringSpec != null)
            {
                 s += ind + "archivalTieringSpec\n";

                 s += ind + "{\n" + 
                 this.ArchivalTieringSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RetentionUnit>? Frequency
            // GraphQL -> frequency: [RetentionUnit!]! (enum)
            if (this.Frequency != null)
            {
                 s += ind + "frequency\n";

            }
                        //      C# -> Target? ArchivalLocation
            // GraphQL -> archivalLocation: Target (interface)
            if (this.ArchivalLocation != null)
            {
                s += ind + "archivalLocation\n";
                s += ind + "{\n";

                string typename = this.ArchivalLocation.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.ArchivalLocation.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> Duration? ArchivalThreshold
            // GraphQL -> archivalThreshold: Duration (type)
            if (this.ArchivalThreshold == null && Exploration.Includes(parent + ".archivalThreshold"))
            {
                this.ArchivalThreshold = new Duration();
                this.ArchivalThreshold.ApplyExploratoryFragment(parent + ".archivalThreshold");
            }
            //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
            // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
            if (this.ArchivalTieringSpec == null && Exploration.Includes(parent + ".archivalTieringSpec"))
            {
                this.ArchivalTieringSpec = new ArchivalTieringSpec();
                this.ArchivalTieringSpec.ApplyExploratoryFragment(parent + ".archivalTieringSpec");
            }
            //      C# -> List<RetentionUnit>? Frequency
            // GraphQL -> frequency: [RetentionUnit!]! (enum)
            if (this.Frequency == null && Exploration.Includes(parent + ".frequency$"))
            {
                this.Frequency = new List<RetentionUnit>();
            }
            //      C# -> Target? ArchivalLocation
            // GraphQL -> archivalLocation: Target (interface)
            if (this.ArchivalLocation == null && Exploration.Includes(parent + ".archivalLocation"))
            {
                this.ArchivalLocation = (Target)InterfaceHelper.CreateInstanceOfFirstType(typeof(Target));
                this.ArchivalLocation.ApplyExploratoryFragment(parent + ".archivalLocation");
            }
        }


    #endregion

    } // class CascadingArchivalSpec
    #endregion

    public static class ListCascadingArchivalSpecExtensions
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
            this List<CascadingArchivalSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CascadingArchivalSpec> list, 
            String parent = "")
        {
            var item = new CascadingArchivalSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
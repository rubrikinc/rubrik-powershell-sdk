// Hits.cs
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
    #region Hits
    public class Hits: IFragment
    {
        #region members
        //      C# -> System.Int32? PermittedHits
        // GraphQL -> permittedHits: Int! (scalar)
        [JsonProperty("permittedHits")]
        public System.Int32? PermittedHits { get; set; }

        //      C# -> System.Int32? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Int! (scalar)
        [JsonProperty("permittedHitsDelta")]
        public System.Int32? PermittedHitsDelta { get; set; }

        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        [JsonProperty("totalHits")]
        public System.Int32? TotalHits { get; set; }

        //      C# -> System.Int32? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Int! (scalar)
        [JsonProperty("totalHitsDelta")]
        public System.Int32? TotalHitsDelta { get; set; }

        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        [JsonProperty("violations")]
        public System.Int32? Violations { get; set; }

        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        [JsonProperty("violationsDelta")]
        public System.Int32? ViolationsDelta { get; set; }

        #endregion

    #region methods

    public Hits Set(
        System.Int32? PermittedHits = null,
        System.Int32? PermittedHitsDelta = null,
        System.Int32? TotalHits = null,
        System.Int32? TotalHitsDelta = null,
        System.Int32? Violations = null,
        System.Int32? ViolationsDelta = null
    ) 
    {
        if ( PermittedHits != null ) {
            this.PermittedHits = PermittedHits;
        }
        if ( PermittedHitsDelta != null ) {
            this.PermittedHitsDelta = PermittedHitsDelta;
        }
        if ( TotalHits != null ) {
            this.TotalHits = TotalHits;
        }
        if ( TotalHitsDelta != null ) {
            this.TotalHitsDelta = TotalHitsDelta;
        }
        if ( Violations != null ) {
            this.Violations = Violations;
        }
        if ( ViolationsDelta != null ) {
            this.ViolationsDelta = ViolationsDelta;
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
            //      C# -> System.Int32? PermittedHits
            // GraphQL -> permittedHits: Int! (scalar)
            if (this.PermittedHits != null)
            {
                 s += ind + "permittedHits\n";

            }
            //      C# -> System.Int32? PermittedHitsDelta
            // GraphQL -> permittedHitsDelta: Int! (scalar)
            if (this.PermittedHitsDelta != null)
            {
                 s += ind + "permittedHitsDelta\n";

            }
            //      C# -> System.Int32? TotalHits
            // GraphQL -> totalHits: Int! (scalar)
            if (this.TotalHits != null)
            {
                 s += ind + "totalHits\n";

            }
            //      C# -> System.Int32? TotalHitsDelta
            // GraphQL -> totalHitsDelta: Int! (scalar)
            if (this.TotalHitsDelta != null)
            {
                 s += ind + "totalHitsDelta\n";

            }
            //      C# -> System.Int32? Violations
            // GraphQL -> violations: Int! (scalar)
            if (this.Violations != null)
            {
                 s += ind + "violations\n";

            }
            //      C# -> System.Int32? ViolationsDelta
            // GraphQL -> violationsDelta: Int! (scalar)
            if (this.ViolationsDelta != null)
            {
                 s += ind + "violationsDelta\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? PermittedHits
            // GraphQL -> permittedHits: Int! (scalar)
            if (this.PermittedHits == null && Exploration.Includes(parent + ".permittedHits$"))
            {
                this.PermittedHits = new System.Int32();
            }
            //      C# -> System.Int32? PermittedHitsDelta
            // GraphQL -> permittedHitsDelta: Int! (scalar)
            if (this.PermittedHitsDelta == null && Exploration.Includes(parent + ".permittedHitsDelta$"))
            {
                this.PermittedHitsDelta = new System.Int32();
            }
            //      C# -> System.Int32? TotalHits
            // GraphQL -> totalHits: Int! (scalar)
            if (this.TotalHits == null && Exploration.Includes(parent + ".totalHits$"))
            {
                this.TotalHits = new System.Int32();
            }
            //      C# -> System.Int32? TotalHitsDelta
            // GraphQL -> totalHitsDelta: Int! (scalar)
            if (this.TotalHitsDelta == null && Exploration.Includes(parent + ".totalHitsDelta$"))
            {
                this.TotalHitsDelta = new System.Int32();
            }
            //      C# -> System.Int32? Violations
            // GraphQL -> violations: Int! (scalar)
            if (this.Violations == null && Exploration.Includes(parent + ".violations$"))
            {
                this.Violations = new System.Int32();
            }
            //      C# -> System.Int32? ViolationsDelta
            // GraphQL -> violationsDelta: Int! (scalar)
            if (this.ViolationsDelta == null && Exploration.Includes(parent + ".violationsDelta$"))
            {
                this.ViolationsDelta = new System.Int32();
            }
        }


    #endregion

    } // class Hits
    #endregion

    public static class ListHitsExtensions
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
            this List<Hits> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Hits> list, 
            String parent = "")
        {
            var item = new Hits();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
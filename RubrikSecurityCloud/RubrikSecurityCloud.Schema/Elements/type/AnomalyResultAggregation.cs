// AnomalyResultAggregation.cs
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
    #region AnomalyResultAggregation
    public class AnomalyResultAggregation: IFragment
    {
        #region members
        //      C# -> System.Int64? BytesAdded
        // GraphQL -> bytesAdded: Long! (scalar)
        [JsonProperty("bytesAdded")]
        public System.Int64? BytesAdded { get; set; }

        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        [JsonProperty("bytesDeleted")]
        public System.Int64? BytesDeleted { get; set; }

        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        [JsonProperty("bytesModified")]
        public System.Int64? BytesModified { get; set; }

        //      C# -> System.Int64? FilesAdded
        // GraphQL -> filesAdded: Long! (scalar)
        [JsonProperty("filesAdded")]
        public System.Int64? FilesAdded { get; set; }

        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        [JsonProperty("filesDeleted")]
        public System.Int64? FilesDeleted { get; set; }

        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        [JsonProperty("filesModified")]
        public System.Int64? FilesModified { get; set; }

        #endregion

    #region methods

    public AnomalyResultAggregation Set(
        System.Int64? BytesAdded = null,
        System.Int64? BytesDeleted = null,
        System.Int64? BytesModified = null,
        System.Int64? FilesAdded = null,
        System.Int64? FilesDeleted = null,
        System.Int64? FilesModified = null
    ) 
    {
        if ( BytesAdded != null ) {
            this.BytesAdded = BytesAdded;
        }
        if ( BytesDeleted != null ) {
            this.BytesDeleted = BytesDeleted;
        }
        if ( BytesModified != null ) {
            this.BytesModified = BytesModified;
        }
        if ( FilesAdded != null ) {
            this.FilesAdded = FilesAdded;
        }
        if ( FilesDeleted != null ) {
            this.FilesDeleted = FilesDeleted;
        }
        if ( FilesModified != null ) {
            this.FilesModified = FilesModified;
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
            //      C# -> System.Int64? BytesAdded
            // GraphQL -> bytesAdded: Long! (scalar)
            if (this.BytesAdded != null)
            {
                 s += ind + "bytesAdded\n";

            }
            //      C# -> System.Int64? BytesDeleted
            // GraphQL -> bytesDeleted: Long! (scalar)
            if (this.BytesDeleted != null)
            {
                 s += ind + "bytesDeleted\n";

            }
            //      C# -> System.Int64? BytesModified
            // GraphQL -> bytesModified: Long! (scalar)
            if (this.BytesModified != null)
            {
                 s += ind + "bytesModified\n";

            }
            //      C# -> System.Int64? FilesAdded
            // GraphQL -> filesAdded: Long! (scalar)
            if (this.FilesAdded != null)
            {
                 s += ind + "filesAdded\n";

            }
            //      C# -> System.Int64? FilesDeleted
            // GraphQL -> filesDeleted: Long! (scalar)
            if (this.FilesDeleted != null)
            {
                 s += ind + "filesDeleted\n";

            }
            //      C# -> System.Int64? FilesModified
            // GraphQL -> filesModified: Long! (scalar)
            if (this.FilesModified != null)
            {
                 s += ind + "filesModified\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? BytesAdded
            // GraphQL -> bytesAdded: Long! (scalar)
            if (this.BytesAdded == null && Exploration.Includes(parent + ".bytesAdded$"))
            {
                this.BytesAdded = new System.Int64();
            }
            //      C# -> System.Int64? BytesDeleted
            // GraphQL -> bytesDeleted: Long! (scalar)
            if (this.BytesDeleted == null && Exploration.Includes(parent + ".bytesDeleted$"))
            {
                this.BytesDeleted = new System.Int64();
            }
            //      C# -> System.Int64? BytesModified
            // GraphQL -> bytesModified: Long! (scalar)
            if (this.BytesModified == null && Exploration.Includes(parent + ".bytesModified$"))
            {
                this.BytesModified = new System.Int64();
            }
            //      C# -> System.Int64? FilesAdded
            // GraphQL -> filesAdded: Long! (scalar)
            if (this.FilesAdded == null && Exploration.Includes(parent + ".filesAdded$"))
            {
                this.FilesAdded = new System.Int64();
            }
            //      C# -> System.Int64? FilesDeleted
            // GraphQL -> filesDeleted: Long! (scalar)
            if (this.FilesDeleted == null && Exploration.Includes(parent + ".filesDeleted$"))
            {
                this.FilesDeleted = new System.Int64();
            }
            //      C# -> System.Int64? FilesModified
            // GraphQL -> filesModified: Long! (scalar)
            if (this.FilesModified == null && Exploration.Includes(parent + ".filesModified$"))
            {
                this.FilesModified = new System.Int64();
            }
        }


    #endregion

    } // class AnomalyResultAggregation
    #endregion

    public static class ListAnomalyResultAggregationExtensions
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
            this List<AnomalyResultAggregation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnomalyResultAggregation> list, 
            String parent = "")
        {
            var item = new AnomalyResultAggregation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
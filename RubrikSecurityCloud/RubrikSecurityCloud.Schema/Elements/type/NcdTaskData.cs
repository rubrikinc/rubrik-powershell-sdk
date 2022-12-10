// NcdTaskData.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:12.
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
    #region NcdTaskData
    public class NcdTaskData: IFragment
    {
        #region members
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Site
        // GraphQL -> site: String! (scalar)
        [JsonProperty("site")]
        public System.String? Site { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        //      C# -> NcdTaskStatus? Status
        // GraphQL -> status: NcdTaskStatus! (enum)
        [JsonProperty("status")]
        public NcdTaskStatus? Status { get; set; }

        #endregion

    #region methods

    public NcdTaskData Set(
        System.String? Description = null,
        System.String? Site = null,
        DateTime? Timestamp = null,
        NcdTaskStatus? Status = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Site != null ) {
            this.Site = Site;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? Site
            // GraphQL -> site: String! (scalar)
            if (this.Site != null)
            {
                 s += ind + "site\n";

            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            //      C# -> NcdTaskStatus? Status
            // GraphQL -> status: NcdTaskStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? Site
            // GraphQL -> site: String! (scalar)
            if (this.Site == null && Exploration.Includes(parent + ".site$"))
            {
                this.Site = new System.String("FETCH");
            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new DateTime();
            }
            //      C# -> NcdTaskStatus? Status
            // GraphQL -> status: NcdTaskStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new NcdTaskStatus();
            }
        }


    #endregion

    } // class NcdTaskData
    #endregion

    public static class ListNcdTaskDataExtensions
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
            this List<NcdTaskData> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NcdTaskData> list, 
            String parent = "")
        {
            var item = new NcdTaskData();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
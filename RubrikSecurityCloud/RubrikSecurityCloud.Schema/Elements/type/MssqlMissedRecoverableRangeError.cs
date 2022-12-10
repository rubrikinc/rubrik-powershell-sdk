// MssqlMissedRecoverableRangeError.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:47.
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
    #region MssqlMissedRecoverableRangeError
    public class MssqlMissedRecoverableRangeError: IFragment
    {
        #region members
        //      C# -> System.String? EventMessage
        // GraphQL -> eventMessage: String (scalar)
        [JsonProperty("eventMessage")]
        public System.String? EventMessage { get; set; }

        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        #endregion

    #region methods

    public MssqlMissedRecoverableRangeError Set(
        System.String? EventMessage = null,
        System.String? EventSeriesId = null,
        DateTime? Time = null
    ) 
    {
        if ( EventMessage != null ) {
            this.EventMessage = EventMessage;
        }
        if ( EventSeriesId != null ) {
            this.EventSeriesId = EventSeriesId;
        }
        if ( Time != null ) {
            this.Time = Time;
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
            //      C# -> System.String? EventMessage
            // GraphQL -> eventMessage: String (scalar)
            if (this.EventMessage != null)
            {
                 s += ind + "eventMessage\n";

            }
            //      C# -> System.String? EventSeriesId
            // GraphQL -> eventSeriesId: String (scalar)
            if (this.EventSeriesId != null)
            {
                 s += ind + "eventSeriesId\n";

            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime (scalar)
            if (this.Time != null)
            {
                 s += ind + "time\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EventMessage
            // GraphQL -> eventMessage: String (scalar)
            if (this.EventMessage == null && Exploration.Includes(parent + ".eventMessage$"))
            {
                this.EventMessage = new System.String("FETCH");
            }
            //      C# -> System.String? EventSeriesId
            // GraphQL -> eventSeriesId: String (scalar)
            if (this.EventSeriesId == null && Exploration.Includes(parent + ".eventSeriesId$"))
            {
                this.EventSeriesId = new System.String("FETCH");
            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime (scalar)
            if (this.Time == null && Exploration.Includes(parent + ".time$"))
            {
                this.Time = new DateTime();
            }
        }


    #endregion

    } // class MssqlMissedRecoverableRangeError
    #endregion

    public static class ListMssqlMissedRecoverableRangeErrorExtensions
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
            this List<MssqlMissedRecoverableRangeError> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlMissedRecoverableRangeError> list, 
            String parent = "")
        {
            var item = new MssqlMissedRecoverableRangeError();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
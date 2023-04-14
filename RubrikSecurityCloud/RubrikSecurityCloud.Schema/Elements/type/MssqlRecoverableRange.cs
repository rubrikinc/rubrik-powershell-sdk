// MssqlRecoverableRange.cs
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
    #region MssqlRecoverableRange
    public class MssqlRecoverableRange: IFragment
    {
        #region members
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        [JsonProperty("beginTime")]
        public DateTime? BeginTime { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.Boolean? IsMountAllowed
        // GraphQL -> isMountAllowed: Boolean! (scalar)
        [JsonProperty("isMountAllowed")]
        public System.Boolean? IsMountAllowed { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        #endregion

    #region methods

    public MssqlRecoverableRange Set(
        DateTime? BeginTime = null,
        DateTime? EndTime = null,
        System.Boolean? IsMountAllowed = null,
        System.String? Status = null
    ) 
    {
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( IsMountAllowed != null ) {
            this.IsMountAllowed = IsMountAllowed;
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
            //      C# -> DateTime? BeginTime
            // GraphQL -> beginTime: DateTime (scalar)
            if (this.BeginTime != null)
            {
                 s += ind + "beginTime\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.Boolean? IsMountAllowed
            // GraphQL -> isMountAllowed: Boolean! (scalar)
            if (this.IsMountAllowed != null)
            {
                 s += ind + "isMountAllowed\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? BeginTime
            // GraphQL -> beginTime: DateTime (scalar)
            if (this.BeginTime == null && Exploration.Includes(parent + ".beginTime$"))
            {
                this.BeginTime = new DateTime();
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> System.Boolean? IsMountAllowed
            // GraphQL -> isMountAllowed: Boolean! (scalar)
            if (this.IsMountAllowed == null && Exploration.Includes(parent + ".isMountAllowed$"))
            {
                this.IsMountAllowed = new System.Boolean();
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
        }


    #endregion

    } // class MssqlRecoverableRange
    #endregion

    public static class ListMssqlRecoverableRangeExtensions
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
            this List<MssqlRecoverableRange> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlRecoverableRange> list, 
            String parent = "")
        {
            var item = new MssqlRecoverableRange();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
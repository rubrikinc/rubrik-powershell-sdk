// MssqlMissedRecoverableRange.cs
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
    #region MssqlMissedRecoverableRange
    public class MssqlMissedRecoverableRange: IFragment
    {
        #region members
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        [JsonProperty("beginTime")]
        public DateTime? BeginTime { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        [JsonProperty("errorType")]
        public System.String? ErrorType { get; set; }

        //      C# -> MssqlMissedRecoverableRangeError? FirstError
        // GraphQL -> firstError: MssqlMissedRecoverableRangeError (type)
        [JsonProperty("firstError")]
        public MssqlMissedRecoverableRangeError? FirstError { get; set; }

        //      C# -> MssqlMissedRecoverableRangeError? LastError
        // GraphQL -> lastError: MssqlMissedRecoverableRangeError (type)
        [JsonProperty("lastError")]
        public MssqlMissedRecoverableRangeError? LastError { get; set; }

        #endregion

    #region methods

    public MssqlMissedRecoverableRange Set(
        DateTime? BeginTime = null,
        System.String? Description = null,
        DateTime? EndTime = null,
        System.String? ErrorType = null,
        MssqlMissedRecoverableRangeError? FirstError = null,
        MssqlMissedRecoverableRangeError? LastError = null
    ) 
    {
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( ErrorType != null ) {
            this.ErrorType = ErrorType;
        }
        if ( FirstError != null ) {
            this.FirstError = FirstError;
        }
        if ( LastError != null ) {
            this.LastError = LastError;
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
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.String? ErrorType
            // GraphQL -> errorType: String! (scalar)
            if (this.ErrorType != null)
            {
                 s += ind + "errorType\n";

            }
            //      C# -> MssqlMissedRecoverableRangeError? FirstError
            // GraphQL -> firstError: MssqlMissedRecoverableRangeError (type)
            if (this.FirstError != null)
            {
                 s += ind + "firstError\n";

                 s += ind + "{\n" + 
                 this.FirstError.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlMissedRecoverableRangeError? LastError
            // GraphQL -> lastError: MssqlMissedRecoverableRangeError (type)
            if (this.LastError != null)
            {
                 s += ind + "lastError\n";

                 s += ind + "{\n" + 
                 this.LastError.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> System.String? ErrorType
            // GraphQL -> errorType: String! (scalar)
            if (this.ErrorType == null && Exploration.Includes(parent + ".errorType$"))
            {
                this.ErrorType = new System.String("FETCH");
            }
            //      C# -> MssqlMissedRecoverableRangeError? FirstError
            // GraphQL -> firstError: MssqlMissedRecoverableRangeError (type)
            if (this.FirstError == null && Exploration.Includes(parent + ".firstError"))
            {
                this.FirstError = new MssqlMissedRecoverableRangeError();
                this.FirstError.ApplyExploratoryFragment(parent + ".firstError");
            }
            //      C# -> MssqlMissedRecoverableRangeError? LastError
            // GraphQL -> lastError: MssqlMissedRecoverableRangeError (type)
            if (this.LastError == null && Exploration.Includes(parent + ".lastError"))
            {
                this.LastError = new MssqlMissedRecoverableRangeError();
                this.LastError.ApplyExploratoryFragment(parent + ".lastError");
            }
        }


    #endregion

    } // class MssqlMissedRecoverableRange
    #endregion

    public static class ListMssqlMissedRecoverableRangeExtensions
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
            this List<MssqlMissedRecoverableRange> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlMissedRecoverableRange> list, 
            String parent = "")
        {
            var item = new MssqlMissedRecoverableRange();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
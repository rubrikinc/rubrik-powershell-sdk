// LatestUserNote.cs
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
    #region LatestUserNote
    public class LatestUserNote: IFragment
    {
        #region members
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        [JsonProperty("userName")]
        public System.String? UserName { get; set; }

        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        [JsonProperty("userNote")]
        public System.String? UserNote { get; set; }

        #endregion

    #region methods

    public LatestUserNote Set(
        System.String? ObjectId = null,
        DateTime? Time = null,
        System.String? UserName = null,
        System.String? UserNote = null
    ) 
    {
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( Time != null ) {
            this.Time = Time;
        }
        if ( UserName != null ) {
            this.UserName = UserName;
        }
        if ( UserNote != null ) {
            this.UserNote = UserNote;
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
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId != null)
            {
                 s += ind + "objectId\n";

            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime! (scalar)
            if (this.Time != null)
            {
                 s += ind + "time\n";

            }
            //      C# -> System.String? UserName
            // GraphQL -> userName: String (scalar)
            if (this.UserName != null)
            {
                 s += ind + "userName\n";

            }
            //      C# -> System.String? UserNote
            // GraphQL -> userNote: String (scalar)
            if (this.UserNote != null)
            {
                 s += ind + "userNote\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId == null && Exploration.Includes(parent + ".objectId$"))
            {
                this.ObjectId = new System.String("FETCH");
            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime! (scalar)
            if (this.Time == null && Exploration.Includes(parent + ".time$"))
            {
                this.Time = new DateTime();
            }
            //      C# -> System.String? UserName
            // GraphQL -> userName: String (scalar)
            if (this.UserName == null && Exploration.Includes(parent + ".userName$"))
            {
                this.UserName = new System.String("FETCH");
            }
            //      C# -> System.String? UserNote
            // GraphQL -> userNote: String (scalar)
            if (this.UserNote == null && Exploration.Includes(parent + ".userNote$"))
            {
                this.UserNote = new System.String("FETCH");
            }
        }


    #endregion

    } // class LatestUserNote
    #endregion

    public static class ListLatestUserNoteExtensions
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
            this List<LatestUserNote> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LatestUserNote> list, 
            String parent = "")
        {
            var item = new LatestUserNote();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
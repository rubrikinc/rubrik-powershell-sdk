// BackupWindow.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:13.
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
    #region BackupWindow
    public class BackupWindow: IFragment
    {
        #region members
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        [JsonProperty("durationInHours")]
        public System.Int32? DurationInHours { get; set; }

        //      C# -> StartTimeAttributes? StartTimeAttributes
        // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
        [JsonProperty("startTimeAttributes")]
        public StartTimeAttributes? StartTimeAttributes { get; set; }

        #endregion

    #region methods

    public BackupWindow Set(
        System.Int32? DurationInHours = null,
        StartTimeAttributes? StartTimeAttributes = null
    ) 
    {
        if ( DurationInHours != null ) {
            this.DurationInHours = DurationInHours;
        }
        if ( StartTimeAttributes != null ) {
            this.StartTimeAttributes = StartTimeAttributes;
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
            //      C# -> System.Int32? DurationInHours
            // GraphQL -> durationInHours: Int! (scalar)
            if (this.DurationInHours != null)
            {
                 s += ind + "durationInHours\n";

            }
            //      C# -> StartTimeAttributes? StartTimeAttributes
            // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
            if (this.StartTimeAttributes != null)
            {
                 s += ind + "startTimeAttributes\n";

                 s += ind + "{\n" + 
                 this.StartTimeAttributes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? DurationInHours
            // GraphQL -> durationInHours: Int! (scalar)
            if (this.DurationInHours == null && Exploration.Includes(parent + ".durationInHours$"))
            {
                this.DurationInHours = new System.Int32();
            }
            //      C# -> StartTimeAttributes? StartTimeAttributes
            // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
            if (this.StartTimeAttributes == null && Exploration.Includes(parent + ".startTimeAttributes"))
            {
                this.StartTimeAttributes = new StartTimeAttributes();
                this.StartTimeAttributes.ApplyExploratoryFragment(parent + ".startTimeAttributes");
            }
        }


    #endregion

    } // class BackupWindow
    #endregion

    public static class ListBackupWindowExtensions
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
            this List<BackupWindow> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BackupWindow> list, 
            String parent = "")
        {
            var item = new BackupWindow();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
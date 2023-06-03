// BackupWindow.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region BackupWindow
    public class BackupWindow: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (this.DurationInHours != null) {
            s += ind + "durationInHours\n" ;
        }
        //      C# -> StartTimeAttributes? StartTimeAttributes
        // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
        if (this.StartTimeAttributes != null) {
            s += ind + "startTimeAttributes {\n" + this.StartTimeAttributes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (this.DurationInHours == null && Exploration.Includes(parent + ".durationInHours", true))
        {
            this.DurationInHours = new System.Int32();
        }
        //      C# -> StartTimeAttributes? StartTimeAttributes
        // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
        if (this.StartTimeAttributes == null && Exploration.Includes(parent + ".startTimeAttributes"))
        {
            this.StartTimeAttributes = new StartTimeAttributes();
            this.StartTimeAttributes.ApplyExploratoryFieldSpec(parent + ".startTimeAttributes");
        }
    }


    #endregion

    } // class BackupWindow
    
    #endregion

    public static class ListBackupWindowExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<BackupWindow> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BackupWindow> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupWindow());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
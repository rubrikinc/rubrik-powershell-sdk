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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "BackupWindow";
    }

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
            var fspec = this.StartTimeAttributes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "startTimeAttributes {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (this.DurationInHours == null && ec.Includes("durationInHours",true))
        {
            this.DurationInHours = Int32.MinValue;
        }
        //      C# -> StartTimeAttributes? StartTimeAttributes
        // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
        if (this.StartTimeAttributes == null && ec.Includes("startTimeAttributes",false))
        {
            this.StartTimeAttributes = new StartTimeAttributes();
            this.StartTimeAttributes.ApplyExploratoryFieldSpec(ec.NewChild("startTimeAttributes"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BackupWindow> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupWindow());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BackupWindow> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
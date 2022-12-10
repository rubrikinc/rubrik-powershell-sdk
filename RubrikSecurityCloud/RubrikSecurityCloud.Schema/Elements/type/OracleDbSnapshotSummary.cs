// OracleDbSnapshotSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:58.
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
    #region OracleDbSnapshotSummary
    public class OracleDbSnapshotSummary: IFragment
    {
        #region members
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        [JsonProperty("databaseName")]
        public System.String? DatabaseName { get; set; }

        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean (scalar)
        [JsonProperty("isValid")]
        public System.Boolean? IsValid { get; set; }

        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        [JsonProperty("tablespaces")]
        public List<System.String>? Tablespaces { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }

        #endregion

    #region methods

    public OracleDbSnapshotSummary Set(
        System.String? DatabaseName = null,
        System.Boolean? IsValid = null,
        List<System.String>? Tablespaces = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( DatabaseName != null ) {
            this.DatabaseName = DatabaseName;
        }
        if ( IsValid != null ) {
            this.IsValid = IsValid;
        }
        if ( Tablespaces != null ) {
            this.Tablespaces = Tablespaces;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
            //      C# -> System.String? DatabaseName
            // GraphQL -> databaseName: String! (scalar)
            if (this.DatabaseName != null)
            {
                 s += ind + "databaseName\n";

            }
            //      C# -> System.Boolean? IsValid
            // GraphQL -> isValid: Boolean (scalar)
            if (this.IsValid != null)
            {
                 s += ind + "isValid\n";

            }
            //      C# -> List<System.String>? Tablespaces
            // GraphQL -> tablespaces: [String!]! (scalar)
            if (this.Tablespaces != null)
            {
                 s += ind + "tablespaces\n";

            }
            //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
            // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
            if (this.BaseSnapshotSummary != null)
            {
                 s += ind + "baseSnapshotSummary\n";

                 s += ind + "{\n" + 
                 this.BaseSnapshotSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DatabaseName
            // GraphQL -> databaseName: String! (scalar)
            if (this.DatabaseName == null && Exploration.Includes(parent + ".databaseName$"))
            {
                this.DatabaseName = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsValid
            // GraphQL -> isValid: Boolean (scalar)
            if (this.IsValid == null && Exploration.Includes(parent + ".isValid$"))
            {
                this.IsValid = new System.Boolean();
            }
            //      C# -> List<System.String>? Tablespaces
            // GraphQL -> tablespaces: [String!]! (scalar)
            if (this.Tablespaces == null && Exploration.Includes(parent + ".tablespaces$"))
            {
                this.Tablespaces = new List<System.String>();
            }
            //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
            // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
            if (this.BaseSnapshotSummary == null && Exploration.Includes(parent + ".baseSnapshotSummary"))
            {
                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFragment(parent + ".baseSnapshotSummary");
            }
        }


    #endregion

    } // class OracleDbSnapshotSummary
    #endregion

    public static class ListOracleDbSnapshotSummaryExtensions
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
            this List<OracleDbSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleDbSnapshotSummary> list, 
            String parent = "")
        {
            var item = new OracleDbSnapshotSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
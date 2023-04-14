// OraclePdb.cs
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
    #region OraclePdb
    public class OraclePdb: IFragment
    {
        #region members
        //      C# -> System.Int64? ApplicationRootContainerId
        // GraphQL -> applicationRootContainerId: Long! (scalar)
        [JsonProperty("applicationRootContainerId")]
        public System.Int64? ApplicationRootContainerId { get; set; }

        //      C# -> System.Int64? DbId
        // GraphQL -> dbId: Long! (scalar)
        [JsonProperty("dbId")]
        public System.Int64? DbId { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.Boolean? IsApplicationPdb
        // GraphQL -> isApplicationPdb: Boolean! (scalar)
        [JsonProperty("isApplicationPdb")]
        public System.Boolean? IsApplicationPdb { get; set; }

        //      C# -> System.Boolean? IsApplicationRoot
        // GraphQL -> isApplicationRoot: Boolean! (scalar)
        [JsonProperty("isApplicationRoot")]
        public System.Boolean? IsApplicationRoot { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> OraclePdbOpenMode? OpenMode
        // GraphQL -> openMode: OraclePdbOpenMode! (enum)
        [JsonProperty("openMode")]
        public OraclePdbOpenMode? OpenMode { get; set; }

        #endregion

    #region methods

    public OraclePdb Set(
        System.Int64? ApplicationRootContainerId = null,
        System.Int64? DbId = null,
        System.Int64? Id = null,
        System.Boolean? IsApplicationPdb = null,
        System.Boolean? IsApplicationRoot = null,
        System.String? Name = null,
        OraclePdbOpenMode? OpenMode = null
    ) 
    {
        if ( ApplicationRootContainerId != null ) {
            this.ApplicationRootContainerId = ApplicationRootContainerId;
        }
        if ( DbId != null ) {
            this.DbId = DbId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsApplicationPdb != null ) {
            this.IsApplicationPdb = IsApplicationPdb;
        }
        if ( IsApplicationRoot != null ) {
            this.IsApplicationRoot = IsApplicationRoot;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OpenMode != null ) {
            this.OpenMode = OpenMode;
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
            //      C# -> System.Int64? ApplicationRootContainerId
            // GraphQL -> applicationRootContainerId: Long! (scalar)
            if (this.ApplicationRootContainerId != null)
            {
                 s += ind + "applicationRootContainerId\n";

            }
            //      C# -> System.Int64? DbId
            // GraphQL -> dbId: Long! (scalar)
            if (this.DbId != null)
            {
                 s += ind + "dbId\n";

            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsApplicationPdb
            // GraphQL -> isApplicationPdb: Boolean! (scalar)
            if (this.IsApplicationPdb != null)
            {
                 s += ind + "isApplicationPdb\n";

            }
            //      C# -> System.Boolean? IsApplicationRoot
            // GraphQL -> isApplicationRoot: Boolean! (scalar)
            if (this.IsApplicationRoot != null)
            {
                 s += ind + "isApplicationRoot\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> OraclePdbOpenMode? OpenMode
            // GraphQL -> openMode: OraclePdbOpenMode! (enum)
            if (this.OpenMode != null)
            {
                 s += ind + "openMode\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ApplicationRootContainerId
            // GraphQL -> applicationRootContainerId: Long! (scalar)
            if (this.ApplicationRootContainerId == null && Exploration.Includes(parent + ".applicationRootContainerId$"))
            {
                this.ApplicationRootContainerId = new System.Int64();
            }
            //      C# -> System.Int64? DbId
            // GraphQL -> dbId: Long! (scalar)
            if (this.DbId == null && Exploration.Includes(parent + ".dbId$"))
            {
                this.DbId = new System.Int64();
            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.Int64();
            }
            //      C# -> System.Boolean? IsApplicationPdb
            // GraphQL -> isApplicationPdb: Boolean! (scalar)
            if (this.IsApplicationPdb == null && Exploration.Includes(parent + ".isApplicationPdb$"))
            {
                this.IsApplicationPdb = new System.Boolean();
            }
            //      C# -> System.Boolean? IsApplicationRoot
            // GraphQL -> isApplicationRoot: Boolean! (scalar)
            if (this.IsApplicationRoot == null && Exploration.Includes(parent + ".isApplicationRoot$"))
            {
                this.IsApplicationRoot = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> OraclePdbOpenMode? OpenMode
            // GraphQL -> openMode: OraclePdbOpenMode! (enum)
            if (this.OpenMode == null && Exploration.Includes(parent + ".openMode$"))
            {
                this.OpenMode = new OraclePdbOpenMode();
            }
        }


    #endregion

    } // class OraclePdb
    #endregion

    public static class ListOraclePdbExtensions
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
            this List<OraclePdb> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OraclePdb> list, 
            String parent = "")
        {
            var item = new OraclePdb();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
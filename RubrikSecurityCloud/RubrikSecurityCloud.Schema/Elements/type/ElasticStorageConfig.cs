// ElasticStorageConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    #region ElasticStorageConfig
    public class ElasticStorageConfig: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsImmutable
        // GraphQL -> isImmutable: Boolean! (scalar)
        [JsonProperty("isImmutable")]
        public System.Boolean? IsImmutable { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }

        #endregion

    #region methods

    public ElasticStorageConfig Set(
        System.Boolean? IsImmutable = null,
        System.String? LocationId = null,
        System.String? LocationName = null
    ) 
    {
        if ( IsImmutable != null ) {
            this.IsImmutable = IsImmutable;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
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
            //      C# -> System.Boolean? IsImmutable
            // GraphQL -> isImmutable: Boolean! (scalar)
            if (this.IsImmutable != null)
            {
                 s += ind + "isImmutable\n";

            }
            //      C# -> System.String? LocationId
            // GraphQL -> locationId: String! (scalar)
            if (this.LocationId != null)
            {
                 s += ind + "locationId\n";

            }
            //      C# -> System.String? LocationName
            // GraphQL -> locationName: String! (scalar)
            if (this.LocationName != null)
            {
                 s += ind + "locationName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsImmutable
            // GraphQL -> isImmutable: Boolean! (scalar)
            if (this.IsImmutable == null && Exploration.Includes(parent + ".isImmutable$"))
            {
                this.IsImmutable = new System.Boolean();
            }
            //      C# -> System.String? LocationId
            // GraphQL -> locationId: String! (scalar)
            if (this.LocationId == null && Exploration.Includes(parent + ".locationId$"))
            {
                this.LocationId = new System.String("FETCH");
            }
            //      C# -> System.String? LocationName
            // GraphQL -> locationName: String! (scalar)
            if (this.LocationName == null && Exploration.Includes(parent + ".locationName$"))
            {
                this.LocationName = new System.String("FETCH");
            }
        }


    #endregion

    } // class ElasticStorageConfig
    #endregion

    public static class ListElasticStorageConfigExtensions
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
            this List<ElasticStorageConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ElasticStorageConfig> list, 
            String parent = "")
        {
            var item = new ElasticStorageConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
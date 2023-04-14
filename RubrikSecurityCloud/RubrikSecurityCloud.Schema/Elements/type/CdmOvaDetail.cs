// CdmOvaDetail.cs
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
    #region CdmOvaDetail
    public class CdmOvaDetail: IFragment
    {
        #region members
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? OvaDownloadLink
        // GraphQL -> ovaDownloadLink: String! (scalar)
        [JsonProperty("ovaDownloadLink")]
        public System.String? OvaDownloadLink { get; set; }

        //      C# -> System.String? OvaSize
        // GraphQL -> ovaSize: String! (scalar)
        [JsonProperty("ovaSize")]
        public System.String? OvaSize { get; set; }

        #endregion

    #region methods

    public CdmOvaDetail Set(
        System.String? CdmVersion = null,
        System.String? OvaDownloadLink = null,
        System.String? OvaSize = null
    ) 
    {
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
        }
        if ( OvaDownloadLink != null ) {
            this.OvaDownloadLink = OvaDownloadLink;
        }
        if ( OvaSize != null ) {
            this.OvaSize = OvaSize;
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
            //      C# -> System.String? CdmVersion
            // GraphQL -> cdmVersion: String! (scalar)
            if (this.CdmVersion != null)
            {
                 s += ind + "cdmVersion\n";

            }
            //      C# -> System.String? OvaDownloadLink
            // GraphQL -> ovaDownloadLink: String! (scalar)
            if (this.OvaDownloadLink != null)
            {
                 s += ind + "ovaDownloadLink\n";

            }
            //      C# -> System.String? OvaSize
            // GraphQL -> ovaSize: String! (scalar)
            if (this.OvaSize != null)
            {
                 s += ind + "ovaSize\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmVersion
            // GraphQL -> cdmVersion: String! (scalar)
            if (this.CdmVersion == null && Exploration.Includes(parent + ".cdmVersion$"))
            {
                this.CdmVersion = new System.String("FETCH");
            }
            //      C# -> System.String? OvaDownloadLink
            // GraphQL -> ovaDownloadLink: String! (scalar)
            if (this.OvaDownloadLink == null && Exploration.Includes(parent + ".ovaDownloadLink$"))
            {
                this.OvaDownloadLink = new System.String("FETCH");
            }
            //      C# -> System.String? OvaSize
            // GraphQL -> ovaSize: String! (scalar)
            if (this.OvaSize == null && Exploration.Includes(parent + ".ovaSize$"))
            {
                this.OvaSize = new System.String("FETCH");
            }
        }


    #endregion

    } // class CdmOvaDetail
    #endregion

    public static class ListCdmOvaDetailExtensions
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
            this List<CdmOvaDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmOvaDetail> list, 
            String parent = "")
        {
            var item = new CdmOvaDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
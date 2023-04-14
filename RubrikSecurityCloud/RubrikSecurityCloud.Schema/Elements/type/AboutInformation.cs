// AboutInformation.cs
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
    #region AboutInformation
    public class AboutInformation: IFragment
    {
        #region members
        //      C# -> System.String? ApiType
        // GraphQL -> apiType: String! (scalar)
        [JsonProperty("apiType")]
        public System.String? ApiType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        [JsonProperty("osType")]
        public System.String? OsType { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        #endregion

    #region methods

    public AboutInformation Set(
        System.String? ApiType = null,
        System.String? Name = null,
        System.String? OsType = null,
        System.String? Version = null
    ) 
    {
        if ( ApiType != null ) {
            this.ApiType = ApiType;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( Version != null ) {
            this.Version = Version;
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
            //      C# -> System.String? ApiType
            // GraphQL -> apiType: String! (scalar)
            if (this.ApiType != null)
            {
                 s += ind + "apiType\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? OsType
            // GraphQL -> osType: String! (scalar)
            if (this.OsType != null)
            {
                 s += ind + "osType\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ApiType
            // GraphQL -> apiType: String! (scalar)
            if (this.ApiType == null && Exploration.Includes(parent + ".apiType$"))
            {
                this.ApiType = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? OsType
            // GraphQL -> osType: String! (scalar)
            if (this.OsType == null && Exploration.Includes(parent + ".osType$"))
            {
                this.OsType = new System.String("FETCH");
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
        }


    #endregion

    } // class AboutInformation
    #endregion

    public static class ListAboutInformationExtensions
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
            this List<AboutInformation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AboutInformation> list, 
            String parent = "")
        {
            var item = new AboutInformation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
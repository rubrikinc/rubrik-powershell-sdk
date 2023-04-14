// SmbDomainDetail.cs
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
    #region SmbDomainDetail
    public class SmbDomainDetail: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsStickySmbService
        // GraphQL -> isStickySmbService: Boolean! (scalar)
        [JsonProperty("isStickySmbService")]
        public System.Boolean? IsStickySmbService { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ServiceAccount
        // GraphQL -> serviceAccount: String (scalar)
        [JsonProperty("serviceAccount")]
        public System.String? ServiceAccount { get; set; }

        //      C# -> SmbDomainStatus? Status
        // GraphQL -> status: SmbDomainStatus! (enum)
        [JsonProperty("status")]
        public SmbDomainStatus? Status { get; set; }

        #endregion

    #region methods

    public SmbDomainDetail Set(
        System.Boolean? IsStickySmbService = null,
        System.String? Name = null,
        System.String? ServiceAccount = null,
        SmbDomainStatus? Status = null
    ) 
    {
        if ( IsStickySmbService != null ) {
            this.IsStickySmbService = IsStickySmbService;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ServiceAccount != null ) {
            this.ServiceAccount = ServiceAccount;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.Boolean? IsStickySmbService
            // GraphQL -> isStickySmbService: Boolean! (scalar)
            if (this.IsStickySmbService != null)
            {
                 s += ind + "isStickySmbService\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? ServiceAccount
            // GraphQL -> serviceAccount: String (scalar)
            if (this.ServiceAccount != null)
            {
                 s += ind + "serviceAccount\n";

            }
            //      C# -> SmbDomainStatus? Status
            // GraphQL -> status: SmbDomainStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsStickySmbService
            // GraphQL -> isStickySmbService: Boolean! (scalar)
            if (this.IsStickySmbService == null && Exploration.Includes(parent + ".isStickySmbService$"))
            {
                this.IsStickySmbService = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? ServiceAccount
            // GraphQL -> serviceAccount: String (scalar)
            if (this.ServiceAccount == null && Exploration.Includes(parent + ".serviceAccount$"))
            {
                this.ServiceAccount = new System.String("FETCH");
            }
            //      C# -> SmbDomainStatus? Status
            // GraphQL -> status: SmbDomainStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new SmbDomainStatus();
            }
        }


    #endregion

    } // class SmbDomainDetail
    #endregion

    public static class ListSmbDomainDetailExtensions
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
            this List<SmbDomainDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SmbDomainDetail> list, 
            String parent = "")
        {
            var item = new SmbDomainDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
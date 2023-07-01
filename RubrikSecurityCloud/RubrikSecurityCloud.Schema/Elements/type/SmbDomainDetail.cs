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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region SmbDomainDetail
    public class SmbDomainDetail: BaseType
    {
        #region members

        //      C# -> SmbDomainStatus? Status
        // GraphQL -> status: SmbDomainStatus! (enum)
        [JsonProperty("status")]
        public SmbDomainStatus? Status { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SmbDomainDetail";
    }

    public SmbDomainDetail Set(
        SmbDomainStatus? Status = null,
        System.Boolean? IsStickySmbService = null,
        System.String? Name = null,
        System.String? ServiceAccount = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( IsStickySmbService != null ) {
            this.IsStickySmbService = IsStickySmbService;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ServiceAccount != null ) {
            this.ServiceAccount = ServiceAccount;
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
        //      C# -> SmbDomainStatus? Status
        // GraphQL -> status: SmbDomainStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Boolean? IsStickySmbService
        // GraphQL -> isStickySmbService: Boolean! (scalar)
        if (this.IsStickySmbService != null) {
            s += ind + "isStickySmbService\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ServiceAccount
        // GraphQL -> serviceAccount: String (scalar)
        if (this.ServiceAccount != null) {
            s += ind + "serviceAccount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SmbDomainStatus? Status
        // GraphQL -> status: SmbDomainStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new SmbDomainStatus();
        }
        //      C# -> System.Boolean? IsStickySmbService
        // GraphQL -> isStickySmbService: Boolean! (scalar)
        if (this.IsStickySmbService == null && Exploration.Includes(parent + ".isStickySmbService", true))
        {
            this.IsStickySmbService = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? ServiceAccount
        // GraphQL -> serviceAccount: String (scalar)
        if (this.ServiceAccount == null && Exploration.Includes(parent + ".serviceAccount", true))
        {
            this.ServiceAccount = "FETCH";
        }
    }


    #endregion

    } // class SmbDomainDetail
    
    #endregion

    public static class ListSmbDomainDetailExtensions
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
            this List<SmbDomainDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SmbDomainDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SmbDomainDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
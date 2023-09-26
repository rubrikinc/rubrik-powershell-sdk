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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SmbDomainStatus? Status
        // GraphQL -> status: SmbDomainStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Boolean? IsStickySmbService
        // GraphQL -> isStickySmbService: Boolean! (scalar)
        if (this.IsStickySmbService != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isStickySmbService\n" ;
            } else {
                s += ind + "isStickySmbService\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? ServiceAccount
        // GraphQL -> serviceAccount: String (scalar)
        if (this.ServiceAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceAccount\n" ;
            } else {
                s += ind + "serviceAccount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SmbDomainStatus? Status
        // GraphQL -> status: SmbDomainStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new SmbDomainStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Boolean? IsStickySmbService
        // GraphQL -> isStickySmbService: Boolean! (scalar)
        if (ec.Includes("isStickySmbService",true))
        {
            if(this.IsStickySmbService == null) {

                this.IsStickySmbService = true;

            } else {


            }
        }
        else if (this.IsStickySmbService != null && ec.Excludes("isStickySmbService",true))
        {
            this.IsStickySmbService = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? ServiceAccount
        // GraphQL -> serviceAccount: String (scalar)
        if (ec.Includes("serviceAccount",true))
        {
            if(this.ServiceAccount == null) {

                this.ServiceAccount = "FETCH";

            } else {


            }
        }
        else if (this.ServiceAccount != null && ec.Excludes("serviceAccount",true))
        {
            this.ServiceAccount = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SmbDomainDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SmbDomainDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SmbDomainDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
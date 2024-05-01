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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SmbDomainDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SmbDomainDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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
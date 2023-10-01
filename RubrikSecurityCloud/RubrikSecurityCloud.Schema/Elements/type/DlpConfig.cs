// DlpConfig.cs
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
    #region DlpConfig
    public class DlpConfig: BaseType
    {
        #region members

        //      C# -> DlpConfigTargetType? TargetType
        // GraphQL -> targetType: DlpConfigTargetType! (enum)
        [JsonProperty("targetType")]
        public DlpConfigTargetType? TargetType { get; set; }

        //      C# -> List<System.String>? Policies
        // GraphQL -> policies: [String!] (scalar)
        [JsonProperty("policies")]
        public List<System.String>? Policies { get; set; }

        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String (scalar)
        [JsonProperty("serviceAccountId")]
        public System.String? ServiceAccountId { get; set; }

        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String (scalar)
        [JsonProperty("serviceAccountName")]
        public System.String? ServiceAccountName { get; set; }

        //      C# -> DlpConfigGenericNas? GenericNas
        // GraphQL -> genericNas: DlpConfigGenericNas (type)
        [JsonProperty("genericNas")]
        public DlpConfigGenericNas? GenericNas { get; set; }

        //      C# -> DlpStatus? Status
        // GraphQL -> status: DlpStatus! (type)
        [JsonProperty("status")]
        public DlpStatus? Status { get; set; }

        //      C# -> DlpConfigVmwareVm? VmwareVm
        // GraphQL -> vmwareVm: DlpConfigVmwareVm (type)
        [JsonProperty("vmwareVm")]
        public DlpConfigVmwareVm? VmwareVm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DlpConfig";
    }

    public DlpConfig Set(
        DlpConfigTargetType? TargetType = null,
        List<System.String>? Policies = null,
        System.String? ServiceAccountId = null,
        System.String? ServiceAccountName = null,
        DlpConfigGenericNas? GenericNas = null,
        DlpStatus? Status = null,
        DlpConfigVmwareVm? VmwareVm = null
    ) 
    {
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( Policies != null ) {
            this.Policies = Policies;
        }
        if ( ServiceAccountId != null ) {
            this.ServiceAccountId = ServiceAccountId;
        }
        if ( ServiceAccountName != null ) {
            this.ServiceAccountName = ServiceAccountName;
        }
        if ( GenericNas != null ) {
            this.GenericNas = GenericNas;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( VmwareVm != null ) {
            this.VmwareVm = VmwareVm;
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
        //      C# -> DlpConfigTargetType? TargetType
        // GraphQL -> targetType: DlpConfigTargetType! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> List<System.String>? Policies
        // GraphQL -> policies: [String!] (scalar)
        if (this.Policies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policies\n" ;
            } else {
                s += ind + "policies\n" ;
            }
        }
        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String (scalar)
        if (this.ServiceAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceAccountId\n" ;
            } else {
                s += ind + "serviceAccountId\n" ;
            }
        }
        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String (scalar)
        if (this.ServiceAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceAccountName\n" ;
            } else {
                s += ind + "serviceAccountName\n" ;
            }
        }
        //      C# -> DlpConfigGenericNas? GenericNas
        // GraphQL -> genericNas: DlpConfigGenericNas (type)
        if (this.GenericNas != null) {
            var fspec = this.GenericNas.AsFieldSpec(conf.Child("genericNas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "genericNas {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DlpStatus? Status
        // GraphQL -> status: DlpStatus! (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DlpConfigVmwareVm? VmwareVm
        // GraphQL -> vmwareVm: DlpConfigVmwareVm (type)
        if (this.VmwareVm != null) {
            var fspec = this.VmwareVm.AsFieldSpec(conf.Child("vmwareVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareVm {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DlpConfigTargetType? TargetType
        // GraphQL -> targetType: DlpConfigTargetType! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new DlpConfigTargetType();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> List<System.String>? Policies
        // GraphQL -> policies: [String!] (scalar)
        if (ec.Includes("policies",true))
        {
            if(this.Policies == null) {

                this.Policies = new List<System.String>();

            } else {


            }
        }
        else if (this.Policies != null && ec.Excludes("policies",true))
        {
            this.Policies = null;
        }
        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String (scalar)
        if (ec.Includes("serviceAccountId",true))
        {
            if(this.ServiceAccountId == null) {

                this.ServiceAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ServiceAccountId != null && ec.Excludes("serviceAccountId",true))
        {
            this.ServiceAccountId = null;
        }
        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String (scalar)
        if (ec.Includes("serviceAccountName",true))
        {
            if(this.ServiceAccountName == null) {

                this.ServiceAccountName = "FETCH";

            } else {


            }
        }
        else if (this.ServiceAccountName != null && ec.Excludes("serviceAccountName",true))
        {
            this.ServiceAccountName = null;
        }
        //      C# -> DlpConfigGenericNas? GenericNas
        // GraphQL -> genericNas: DlpConfigGenericNas (type)
        if (ec.Includes("genericNas",false))
        {
            if(this.GenericNas == null) {

                this.GenericNas = new DlpConfigGenericNas();
                this.GenericNas.ApplyExploratoryFieldSpec(ec.NewChild("genericNas"));

            } else {

                this.GenericNas.ApplyExploratoryFieldSpec(ec.NewChild("genericNas"));

            }
        }
        else if (this.GenericNas != null && ec.Excludes("genericNas",false))
        {
            this.GenericNas = null;
        }
        //      C# -> DlpStatus? Status
        // GraphQL -> status: DlpStatus! (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new DlpStatus();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
        //      C# -> DlpConfigVmwareVm? VmwareVm
        // GraphQL -> vmwareVm: DlpConfigVmwareVm (type)
        if (ec.Includes("vmwareVm",false))
        {
            if(this.VmwareVm == null) {

                this.VmwareVm = new DlpConfigVmwareVm();
                this.VmwareVm.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVm"));

            } else {

                this.VmwareVm.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVm"));

            }
        }
        else if (this.VmwareVm != null && ec.Excludes("vmwareVm",false))
        {
            this.VmwareVm = null;
        }
    }


    #endregion

    } // class DlpConfig
    
    #endregion

    public static class ListDlpConfigExtensions
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
            this List<DlpConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DlpConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DlpConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DlpConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DlpConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
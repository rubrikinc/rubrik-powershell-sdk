// IpInfo.cs
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
    #region IpInfo
    public class IpInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? ContainsCurrentIpAddress
        // GraphQL -> containsCurrentIpAddress: Boolean! (scalar)
        [JsonProperty("containsCurrentIpAddress")]
        public System.Boolean? ContainsCurrentIpAddress { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? IpCidr
        // GraphQL -> ipCidr: String! (scalar)
        [JsonProperty("ipCidr")]
        public System.String? IpCidr { get; set; }

        //      C# -> System.Boolean? IsGlobalEntry
        // GraphQL -> isGlobalEntry: Boolean! (scalar)
        [JsonProperty("isGlobalEntry")]
        public System.Boolean? IsGlobalEntry { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IpInfo";
    }

    public IpInfo Set(
        System.Boolean? ContainsCurrentIpAddress = null,
        DateTime? CreatedAt = null,
        System.String? Description = null,
        System.Int64? Id = null,
        System.String? IpCidr = null,
        System.Boolean? IsGlobalEntry = null,
        DateTime? UpdatedAt = null
    ) 
    {
        if ( ContainsCurrentIpAddress != null ) {
            this.ContainsCurrentIpAddress = ContainsCurrentIpAddress;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IpCidr != null ) {
            this.IpCidr = IpCidr;
        }
        if ( IsGlobalEntry != null ) {
            this.IsGlobalEntry = IsGlobalEntry;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? ContainsCurrentIpAddress
        // GraphQL -> containsCurrentIpAddress: Boolean! (scalar)
        if (this.ContainsCurrentIpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "containsCurrentIpAddress\n" ;
            } else {
                s += ind + "containsCurrentIpAddress\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? IpCidr
        // GraphQL -> ipCidr: String! (scalar)
        if (this.IpCidr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipCidr\n" ;
            } else {
                s += ind + "ipCidr\n" ;
            }
        }
        //      C# -> System.Boolean? IsGlobalEntry
        // GraphQL -> isGlobalEntry: Boolean! (scalar)
        if (this.IsGlobalEntry != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isGlobalEntry\n" ;
            } else {
                s += ind + "isGlobalEntry\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? ContainsCurrentIpAddress
        // GraphQL -> containsCurrentIpAddress: Boolean! (scalar)
        if (ec.Includes("containsCurrentIpAddress",true))
        {
            if(this.ContainsCurrentIpAddress == null) {

                this.ContainsCurrentIpAddress = true;

            } else {


            }
        }
        else if (this.ContainsCurrentIpAddress != null && ec.Excludes("containsCurrentIpAddress",true))
        {
            this.ContainsCurrentIpAddress = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? IpCidr
        // GraphQL -> ipCidr: String! (scalar)
        if (ec.Includes("ipCidr",true))
        {
            if(this.IpCidr == null) {

                this.IpCidr = "FETCH";

            } else {


            }
        }
        else if (this.IpCidr != null && ec.Excludes("ipCidr",true))
        {
            this.IpCidr = null;
        }
        //      C# -> System.Boolean? IsGlobalEntry
        // GraphQL -> isGlobalEntry: Boolean! (scalar)
        if (ec.Includes("isGlobalEntry",true))
        {
            if(this.IsGlobalEntry == null) {

                this.IsGlobalEntry = true;

            } else {


            }
        }
        else if (this.IsGlobalEntry != null && ec.Excludes("isGlobalEntry",true))
        {
            this.IsGlobalEntry = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
    }


    #endregion

    } // class IpInfo
    
    #endregion

    public static class ListIpInfoExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<IpInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IpInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IpInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IpInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IpInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
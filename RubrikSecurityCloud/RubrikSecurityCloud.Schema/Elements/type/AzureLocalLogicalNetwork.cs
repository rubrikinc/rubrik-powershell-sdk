// AzureLocalLogicalNetwork.cs
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
    #region AzureLocalLogicalNetwork
    public class AzureLocalLogicalNetwork: BaseType
    {
        #region members

        //      C# -> AzureLocalIpv4Type? Ipv4Type
        // GraphQL -> ipv4Type: AzureLocalIpv4Type! (enum)
        [JsonProperty("ipv4Type")]
        public AzureLocalIpv4Type? Ipv4Type { get; set; }

        //      C# -> System.String? AddressPrefix
        // GraphQL -> addressPrefix: String (scalar)
        [JsonProperty("addressPrefix")]
        public System.String? AddressPrefix { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<AzureLocalIpPool>? IpPools
        // GraphQL -> ipPools: [AzureLocalIpPool!]! (type)
        [JsonProperty("ipPools")]
        public List<AzureLocalIpPool>? IpPools { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureLocalLogicalNetwork";
    }

    public AzureLocalLogicalNetwork Set(
        AzureLocalIpv4Type? Ipv4Type = null,
        System.String? AddressPrefix = null,
        System.String? Id = null,
        System.String? Name = null,
        List<AzureLocalIpPool>? IpPools = null
    ) 
    {
        if ( Ipv4Type != null ) {
            this.Ipv4Type = Ipv4Type;
        }
        if ( AddressPrefix != null ) {
            this.AddressPrefix = AddressPrefix;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( IpPools != null ) {
            this.IpPools = IpPools;
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
        //      C# -> AzureLocalIpv4Type? Ipv4Type
        // GraphQL -> ipv4Type: AzureLocalIpv4Type! (enum)
        if (this.Ipv4Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipv4Type\n" ;
            } else {
                s += ind + "ipv4Type\n" ;
            }
        }
        //      C# -> System.String? AddressPrefix
        // GraphQL -> addressPrefix: String (scalar)
        if (this.AddressPrefix != null) {
            if (conf.Flat) {
                s += conf.Prefix + "addressPrefix\n" ;
            } else {
                s += ind + "addressPrefix\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> List<AzureLocalIpPool>? IpPools
        // GraphQL -> ipPools: [AzureLocalIpPool!]! (type)
        if (this.IpPools != null) {
            var fspec = this.IpPools.AsFieldSpec(conf.Child("ipPools"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ipPools" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureLocalIpv4Type? Ipv4Type
        // GraphQL -> ipv4Type: AzureLocalIpv4Type! (enum)
        if (ec.Includes("ipv4Type",true))
        {
            if(this.Ipv4Type == null) {

                this.Ipv4Type = new AzureLocalIpv4Type();

            } else {


            }
        }
        else if (this.Ipv4Type != null && ec.Excludes("ipv4Type",true))
        {
            this.Ipv4Type = null;
        }
        //      C# -> System.String? AddressPrefix
        // GraphQL -> addressPrefix: String (scalar)
        if (ec.Includes("addressPrefix",true))
        {
            if(this.AddressPrefix == null) {

                this.AddressPrefix = "FETCH";

            } else {


            }
        }
        else if (this.AddressPrefix != null && ec.Excludes("addressPrefix",true))
        {
            this.AddressPrefix = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> List<AzureLocalIpPool>? IpPools
        // GraphQL -> ipPools: [AzureLocalIpPool!]! (type)
        if (ec.Includes("ipPools",false))
        {
            if(this.IpPools == null) {

                this.IpPools = new List<AzureLocalIpPool>();
                this.IpPools.ApplyExploratoryFieldSpec(ec.NewChild("ipPools"));

            } else {

                this.IpPools.ApplyExploratoryFieldSpec(ec.NewChild("ipPools"));

            }
        }
        else if (this.IpPools != null && ec.Excludes("ipPools",false))
        {
            this.IpPools = null;
        }
    }


    #endregion

    } // class AzureLocalLogicalNetwork
    
    #endregion

    public static class ListAzureLocalLogicalNetworkExtensions
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
            this List<AzureLocalLogicalNetwork> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureLocalLogicalNetwork> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureLocalLogicalNetwork> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureLocalLogicalNetwork());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureLocalLogicalNetwork> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// AzureNativeSubnet.cs
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
    #region AzureNativeSubnet
    public class AzureNativeSubnet: BaseType
    {
        #region members

        //      C# -> List<System.String>? AddressPrefixes
        // GraphQL -> addressPrefixes: [String!]! (scalar)
        [JsonProperty("addressPrefixes")]
        public List<System.String>? AddressPrefixes { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> AzureNativeVirtualNetwork? Vnet
        // GraphQL -> vnet: AzureNativeVirtualNetwork! (type)
        [JsonProperty("vnet")]
        public AzureNativeVirtualNetwork? Vnet { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeSubnet";
    }

    public AzureNativeSubnet Set(
        List<System.String>? AddressPrefixes = null,
        System.String? Name = null,
        System.String? NativeId = null,
        AzureNativeVirtualNetwork? Vnet = null
    ) 
    {
        if ( AddressPrefixes != null ) {
            this.AddressPrefixes = AddressPrefixes;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( Vnet != null ) {
            this.Vnet = Vnet;
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
        //      C# -> List<System.String>? AddressPrefixes
        // GraphQL -> addressPrefixes: [String!]! (scalar)
        if (this.AddressPrefixes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "addressPrefixes\n" ;
            } else {
                s += ind + "addressPrefixes\n" ;
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
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeId\n" ;
            } else {
                s += ind + "nativeId\n" ;
            }
        }
        //      C# -> AzureNativeVirtualNetwork? Vnet
        // GraphQL -> vnet: AzureNativeVirtualNetwork! (type)
        if (this.Vnet != null) {
            var fspec = this.Vnet.AsFieldSpec(conf.Child("vnet"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vnet" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? AddressPrefixes
        // GraphQL -> addressPrefixes: [String!]! (scalar)
        if (ec.Includes("addressPrefixes",true))
        {
            if(this.AddressPrefixes == null) {

                this.AddressPrefixes = new List<System.String>();

            } else {


            }
        }
        else if (this.AddressPrefixes != null && ec.Excludes("addressPrefixes",true))
        {
            this.AddressPrefixes = null;
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
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (ec.Includes("nativeId",true))
        {
            if(this.NativeId == null) {

                this.NativeId = "FETCH";

            } else {


            }
        }
        else if (this.NativeId != null && ec.Excludes("nativeId",true))
        {
            this.NativeId = null;
        }
        //      C# -> AzureNativeVirtualNetwork? Vnet
        // GraphQL -> vnet: AzureNativeVirtualNetwork! (type)
        if (ec.Includes("vnet",false))
        {
            if(this.Vnet == null) {

                this.Vnet = new AzureNativeVirtualNetwork();
                this.Vnet.ApplyExploratoryFieldSpec(ec.NewChild("vnet"));

            } else {

                this.Vnet.ApplyExploratoryFieldSpec(ec.NewChild("vnet"));

            }
        }
        else if (this.Vnet != null && ec.Excludes("vnet",false))
        {
            this.Vnet = null;
        }
    }


    #endregion

    } // class AzureNativeSubnet
    
    #endregion

    public static class ListAzureNativeSubnetExtensions
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
            this List<AzureNativeSubnet> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeSubnet> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeSubnet> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeSubnet());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeSubnet> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
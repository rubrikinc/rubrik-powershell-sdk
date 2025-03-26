// AzureSubscriptionWithExocomputeMapping.cs
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
    #region AzureSubscriptionWithExocomputeMapping
    public class AzureSubscriptionWithExocomputeMapping: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        [JsonProperty("mappedExocomputeSubscription")]
        public AzureMappedExocomputeSubscription? MappedExocomputeSubscription { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSubscriptionWithExocomputeMapping";
    }

    public AzureSubscriptionWithExocomputeMapping Set(
        System.String? Id = null,
        System.String? Name = null,
        System.String? NativeId = null,
        AzureMappedExocomputeSubscription? MappedExocomputeSubscription = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( MappedExocomputeSubscription != null ) {
            this.MappedExocomputeSubscription = MappedExocomputeSubscription;
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
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeId\n" ;
            } else {
                s += ind + "nativeId\n" ;
            }
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (this.MappedExocomputeSubscription != null) {
            var fspec = this.MappedExocomputeSubscription.AsFieldSpec(conf.Child("mappedExocomputeSubscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedExocomputeSubscription" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (ec.Includes("mappedExocomputeSubscription",false))
        {
            if(this.MappedExocomputeSubscription == null) {

                this.MappedExocomputeSubscription = new AzureMappedExocomputeSubscription();
                this.MappedExocomputeSubscription.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeSubscription"));

            } else {

                this.MappedExocomputeSubscription.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeSubscription"));

            }
        }
        else if (this.MappedExocomputeSubscription != null && ec.Excludes("mappedExocomputeSubscription",false))
        {
            this.MappedExocomputeSubscription = null;
        }
    }


    #endregion

    } // class AzureSubscriptionWithExocomputeMapping
    
    #endregion

    public static class ListAzureSubscriptionWithExocomputeMappingExtensions
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
            this List<AzureSubscriptionWithExocomputeMapping> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureSubscriptionWithExocomputeMapping> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureSubscriptionWithExocomputeMapping> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSubscriptionWithExocomputeMapping());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureSubscriptionWithExocomputeMapping> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// CloudNativeStorageClassTier.cs
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
    #region CloudNativeStorageClassTier
    public class CloudNativeStorageClassTier: BaseType
    {
        #region members

        //      C# -> AwsStorageClass? AwsStorageClass
        // GraphQL -> awsStorageClass: AwsStorageClass (enum)
        [JsonProperty("awsStorageClass")]
        public AwsStorageClass? AwsStorageClass { get; set; }

        //      C# -> AzureStorageTier? AzureStorageTier
        // GraphQL -> azureStorageTier: AzureStorageTier (enum)
        [JsonProperty("azureStorageTier")]
        public AzureStorageTier? AzureStorageTier { get; set; }

        //      C# -> GcpStorageClass? GcpStorageClass
        // GraphQL -> gcpStorageClass: GcpStorageClass (enum)
        [JsonProperty("gcpStorageClass")]
        public GcpStorageClass? GcpStorageClass { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeStorageClassTier";
    }

    public CloudNativeStorageClassTier Set(
        AwsStorageClass? AwsStorageClass = null,
        AzureStorageTier? AzureStorageTier = null,
        GcpStorageClass? GcpStorageClass = null
    ) 
    {
        if ( AwsStorageClass != null ) {
            this.AwsStorageClass = AwsStorageClass;
        }
        if ( AzureStorageTier != null ) {
            this.AzureStorageTier = AzureStorageTier;
        }
        if ( GcpStorageClass != null ) {
            this.GcpStorageClass = GcpStorageClass;
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
        //      C# -> AwsStorageClass? AwsStorageClass
        // GraphQL -> awsStorageClass: AwsStorageClass (enum)
        if (this.AwsStorageClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsStorageClass\n" ;
            } else {
                s += ind + "awsStorageClass\n" ;
            }
        }
        //      C# -> AzureStorageTier? AzureStorageTier
        // GraphQL -> azureStorageTier: AzureStorageTier (enum)
        if (this.AzureStorageTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureStorageTier\n" ;
            } else {
                s += ind + "azureStorageTier\n" ;
            }
        }
        //      C# -> GcpStorageClass? GcpStorageClass
        // GraphQL -> gcpStorageClass: GcpStorageClass (enum)
        if (this.GcpStorageClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gcpStorageClass\n" ;
            } else {
                s += ind + "gcpStorageClass\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsStorageClass? AwsStorageClass
        // GraphQL -> awsStorageClass: AwsStorageClass (enum)
        if (ec.Includes("awsStorageClass",true))
        {
            if(this.AwsStorageClass == null) {

                this.AwsStorageClass = new AwsStorageClass();

            } else {


            }
        }
        else if (this.AwsStorageClass != null && ec.Excludes("awsStorageClass",true))
        {
            this.AwsStorageClass = null;
        }
        //      C# -> AzureStorageTier? AzureStorageTier
        // GraphQL -> azureStorageTier: AzureStorageTier (enum)
        if (ec.Includes("azureStorageTier",true))
        {
            if(this.AzureStorageTier == null) {

                this.AzureStorageTier = new AzureStorageTier();

            } else {


            }
        }
        else if (this.AzureStorageTier != null && ec.Excludes("azureStorageTier",true))
        {
            this.AzureStorageTier = null;
        }
        //      C# -> GcpStorageClass? GcpStorageClass
        // GraphQL -> gcpStorageClass: GcpStorageClass (enum)
        if (ec.Includes("gcpStorageClass",true))
        {
            if(this.GcpStorageClass == null) {

                this.GcpStorageClass = new GcpStorageClass();

            } else {


            }
        }
        else if (this.GcpStorageClass != null && ec.Excludes("gcpStorageClass",true))
        {
            this.GcpStorageClass = null;
        }
    }


    #endregion

    } // class CloudNativeStorageClassTier
    
    #endregion

    public static class ListCloudNativeStorageClassTierExtensions
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
            this List<CloudNativeStorageClassTier> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeStorageClassTier> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeStorageClassTier> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeStorageClassTier());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeStorageClassTier> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
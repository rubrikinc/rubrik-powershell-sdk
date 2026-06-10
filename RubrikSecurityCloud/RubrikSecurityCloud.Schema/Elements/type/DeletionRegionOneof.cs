// DeletionRegionOneof.cs
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
    #region DeletionRegionOneof
    public class DeletionRegionOneof: BaseType
    {
        #region members

        //      C# -> AzureCloudAccountRegion? AzureRegion
        // GraphQL -> azureRegion: AzureCloudAccountRegion (enum)
        [JsonProperty("azureRegion")]
        public AzureCloudAccountRegion? AzureRegion { get; set; }

        //      C# -> AwsRegionOneof? AwsRegion
        // GraphQL -> awsRegion: AwsRegionOneof (type)
        [JsonProperty("awsRegion")]
        public AwsRegionOneof? AwsRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeletionRegionOneof";
    }

    public DeletionRegionOneof Set(
        AzureCloudAccountRegion? AzureRegion = null,
        AwsRegionOneof? AwsRegion = null
    ) 
    {
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
        }
        if ( AwsRegion != null ) {
            this.AwsRegion = AwsRegion;
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
        //      C# -> AzureCloudAccountRegion? AzureRegion
        // GraphQL -> azureRegion: AzureCloudAccountRegion (enum)
        if (this.AzureRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureRegion\n" ;
            } else {
                s += ind + "azureRegion\n" ;
            }
        }
        //      C# -> AwsRegionOneof? AwsRegion
        // GraphQL -> awsRegion: AwsRegionOneof (type)
        if (this.AwsRegion != null) {
            var fspec = this.AwsRegion.AsFieldSpec(conf.Child("awsRegion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsRegion" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureCloudAccountRegion? AzureRegion
        // GraphQL -> azureRegion: AzureCloudAccountRegion (enum)
        if (ec.Includes("azureRegion",true))
        {
            if(this.AzureRegion == null) {

                this.AzureRegion = new AzureCloudAccountRegion();

            } else {


            }
        }
        else if (this.AzureRegion != null && ec.Excludes("azureRegion",true))
        {
            this.AzureRegion = null;
        }
        //      C# -> AwsRegionOneof? AwsRegion
        // GraphQL -> awsRegion: AwsRegionOneof (type)
        if (ec.Includes("awsRegion",false))
        {
            if(this.AwsRegion == null) {

                this.AwsRegion = new AwsRegionOneof();
                this.AwsRegion.ApplyExploratoryFieldSpec(ec.NewChild("awsRegion"));

            } else {

                this.AwsRegion.ApplyExploratoryFieldSpec(ec.NewChild("awsRegion"));

            }
        }
        else if (this.AwsRegion != null && ec.Excludes("awsRegion",false))
        {
            this.AwsRegion = null;
        }
    }


    #endregion

    } // class DeletionRegionOneof
    
    #endregion

    public static class ListDeletionRegionOneofExtensions
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
            this List<DeletionRegionOneof> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DeletionRegionOneof> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DeletionRegionOneof> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DeletionRegionOneof());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DeletionRegionOneof> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
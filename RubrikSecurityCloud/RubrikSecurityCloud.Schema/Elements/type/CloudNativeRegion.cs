// CloudNativeRegion.cs
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
    #region CloudNativeRegion
    public class CloudNativeRegion: BaseType
    {
        #region members

        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion (enum)
        [JsonProperty("awsRegion")]
        public AwsNativeRegion? AwsRegion { get; set; }

        //      C# -> AzureNativeRegion? AzureRegion
        // GraphQL -> azureRegion: AzureNativeRegion (enum)
        [JsonProperty("azureRegion")]
        public AzureNativeRegion? AzureRegion { get; set; }

        //      C# -> GcpNativeRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpNativeRegion (type)
        [JsonProperty("gcpRegion")]
        public GcpNativeRegion? GcpRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeRegion";
    }

    public CloudNativeRegion Set(
        AwsNativeRegion? AwsRegion = null,
        AzureNativeRegion? AzureRegion = null,
        GcpNativeRegion? GcpRegion = null
    ) 
    {
        if ( AwsRegion != null ) {
            this.AwsRegion = AwsRegion;
        }
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
        }
        if ( GcpRegion != null ) {
            this.GcpRegion = GcpRegion;
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
        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion (enum)
        if (this.AwsRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsRegion\n" ;
            } else {
                s += ind + "awsRegion\n" ;
            }
        }
        //      C# -> AzureNativeRegion? AzureRegion
        // GraphQL -> azureRegion: AzureNativeRegion (enum)
        if (this.AzureRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureRegion\n" ;
            } else {
                s += ind + "azureRegion\n" ;
            }
        }
        //      C# -> GcpNativeRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpNativeRegion (type)
        if (this.GcpRegion != null) {
            var fspec = this.GcpRegion.AsFieldSpec(conf.Child("gcpRegion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "gcpRegion" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion (enum)
        if (ec.Includes("awsRegion",true))
        {
            if(this.AwsRegion == null) {

                this.AwsRegion = new AwsNativeRegion();

            } else {


            }
        }
        else if (this.AwsRegion != null && ec.Excludes("awsRegion",true))
        {
            this.AwsRegion = null;
        }
        //      C# -> AzureNativeRegion? AzureRegion
        // GraphQL -> azureRegion: AzureNativeRegion (enum)
        if (ec.Includes("azureRegion",true))
        {
            if(this.AzureRegion == null) {

                this.AzureRegion = new AzureNativeRegion();

            } else {


            }
        }
        else if (this.AzureRegion != null && ec.Excludes("azureRegion",true))
        {
            this.AzureRegion = null;
        }
        //      C# -> GcpNativeRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpNativeRegion (type)
        if (ec.Includes("gcpRegion",false))
        {
            if(this.GcpRegion == null) {

                this.GcpRegion = new GcpNativeRegion();
                this.GcpRegion.ApplyExploratoryFieldSpec(ec.NewChild("gcpRegion"));

            } else {

                this.GcpRegion.ApplyExploratoryFieldSpec(ec.NewChild("gcpRegion"));

            }
        }
        else if (this.GcpRegion != null && ec.Excludes("gcpRegion",false))
        {
            this.GcpRegion = null;
        }
    }


    #endregion

    } // class CloudNativeRegion
    
    #endregion

    public static class ListCloudNativeRegionExtensions
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
            this List<CloudNativeRegion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeRegion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeRegion> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeRegion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeRegion> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
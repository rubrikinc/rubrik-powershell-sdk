// CloudSpecificRegionOneof.cs
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
    #region CloudSpecificRegionOneof
    public class CloudSpecificRegionOneof: BaseType
    {
        #region members

        //      C# -> AwsRegion? AwsRegion
        // GraphQL -> awsRegion: AwsRegion (enum)
        [JsonProperty("awsRegion")]
        public AwsRegion? AwsRegion { get; set; }

        //      C# -> AzureRegion? AzureRegion
        // GraphQL -> azureRegion: AzureRegion (enum)
        [JsonProperty("azureRegion")]
        public AzureRegion? AzureRegion { get; set; }

        //      C# -> GcpRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpRegion (enum)
        [JsonProperty("gcpRegion")]
        public GcpRegion? GcpRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudSpecificRegionOneof";
    }

    public CloudSpecificRegionOneof Set(
        AwsRegion? AwsRegion = null,
        AzureRegion? AzureRegion = null,
        GcpRegion? GcpRegion = null
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
        //      C# -> AwsRegion? AwsRegion
        // GraphQL -> awsRegion: AwsRegion (enum)
        if (this.AwsRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsRegion\n" ;
            } else {
                s += ind + "awsRegion\n" ;
            }
        }
        //      C# -> AzureRegion? AzureRegion
        // GraphQL -> azureRegion: AzureRegion (enum)
        if (this.AzureRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureRegion\n" ;
            } else {
                s += ind + "azureRegion\n" ;
            }
        }
        //      C# -> GcpRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpRegion (enum)
        if (this.GcpRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gcpRegion\n" ;
            } else {
                s += ind + "gcpRegion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsRegion? AwsRegion
        // GraphQL -> awsRegion: AwsRegion (enum)
        if (ec.Includes("awsRegion",true))
        {
            if(this.AwsRegion == null) {

                this.AwsRegion = new AwsRegion();

            } else {


            }
        }
        else if (this.AwsRegion != null && ec.Excludes("awsRegion",true))
        {
            this.AwsRegion = null;
        }
        //      C# -> AzureRegion? AzureRegion
        // GraphQL -> azureRegion: AzureRegion (enum)
        if (ec.Includes("azureRegion",true))
        {
            if(this.AzureRegion == null) {

                this.AzureRegion = new AzureRegion();

            } else {


            }
        }
        else if (this.AzureRegion != null && ec.Excludes("azureRegion",true))
        {
            this.AzureRegion = null;
        }
        //      C# -> GcpRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpRegion (enum)
        if (ec.Includes("gcpRegion",true))
        {
            if(this.GcpRegion == null) {

                this.GcpRegion = new GcpRegion();

            } else {


            }
        }
        else if (this.GcpRegion != null && ec.Excludes("gcpRegion",true))
        {
            this.GcpRegion = null;
        }
    }


    #endregion

    } // class CloudSpecificRegionOneof
    
    #endregion

    public static class ListCloudSpecificRegionOneofExtensions
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
            this List<CloudSpecificRegionOneof> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudSpecificRegionOneof> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudSpecificRegionOneof> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudSpecificRegionOneof());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudSpecificRegionOneof> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
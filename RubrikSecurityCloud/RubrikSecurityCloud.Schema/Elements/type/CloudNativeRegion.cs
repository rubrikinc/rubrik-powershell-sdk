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
                    s += ind + "gcpRegion {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
            this List<CloudNativeRegion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeRegion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeRegion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeRegion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
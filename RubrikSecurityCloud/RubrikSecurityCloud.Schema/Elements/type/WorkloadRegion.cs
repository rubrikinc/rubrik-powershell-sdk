// WorkloadRegion.cs
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
    #region WorkloadRegion
    public class WorkloadRegion: BaseType
    {
        #region members

        //      C# -> AwsNativeRegion? AwsNativeRegion
        // GraphQL -> awsNativeRegion: AwsNativeRegion! (enum)
        [JsonProperty("awsNativeRegion")]
        public AwsNativeRegion? AwsNativeRegion { get; set; }

        //      C# -> AzureNativeRegion? AzureNativeRegion
        // GraphQL -> azureNativeRegion: AzureNativeRegion! (enum)
        [JsonProperty("azureNativeRegion")]
        public AzureNativeRegion? AzureNativeRegion { get; set; }

        //      C# -> System.String? GcpNativeRegion
        // GraphQL -> gcpNativeRegion: String! (scalar)
        [JsonProperty("gcpNativeRegion")]
        public System.String? GcpNativeRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadRegion";
    }

    public WorkloadRegion Set(
        AwsNativeRegion? AwsNativeRegion = null,
        AzureNativeRegion? AzureNativeRegion = null,
        System.String? GcpNativeRegion = null
    ) 
    {
        if ( AwsNativeRegion != null ) {
            this.AwsNativeRegion = AwsNativeRegion;
        }
        if ( AzureNativeRegion != null ) {
            this.AzureNativeRegion = AzureNativeRegion;
        }
        if ( GcpNativeRegion != null ) {
            this.GcpNativeRegion = GcpNativeRegion;
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
        //      C# -> AwsNativeRegion? AwsNativeRegion
        // GraphQL -> awsNativeRegion: AwsNativeRegion! (enum)
        if (this.AwsNativeRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsNativeRegion\n" ;
            } else {
                s += ind + "awsNativeRegion\n" ;
            }
        }
        //      C# -> AzureNativeRegion? AzureNativeRegion
        // GraphQL -> azureNativeRegion: AzureNativeRegion! (enum)
        if (this.AzureNativeRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureNativeRegion\n" ;
            } else {
                s += ind + "azureNativeRegion\n" ;
            }
        }
        //      C# -> System.String? GcpNativeRegion
        // GraphQL -> gcpNativeRegion: String! (scalar)
        if (this.GcpNativeRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gcpNativeRegion\n" ;
            } else {
                s += ind + "gcpNativeRegion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsNativeRegion? AwsNativeRegion
        // GraphQL -> awsNativeRegion: AwsNativeRegion! (enum)
        if (ec.Includes("awsNativeRegion",true))
        {
            if(this.AwsNativeRegion == null) {

                this.AwsNativeRegion = new AwsNativeRegion();

            } else {


            }
        }
        else if (this.AwsNativeRegion != null && ec.Excludes("awsNativeRegion",true))
        {
            this.AwsNativeRegion = null;
        }
        //      C# -> AzureNativeRegion? AzureNativeRegion
        // GraphQL -> azureNativeRegion: AzureNativeRegion! (enum)
        if (ec.Includes("azureNativeRegion",true))
        {
            if(this.AzureNativeRegion == null) {

                this.AzureNativeRegion = new AzureNativeRegion();

            } else {


            }
        }
        else if (this.AzureNativeRegion != null && ec.Excludes("azureNativeRegion",true))
        {
            this.AzureNativeRegion = null;
        }
        //      C# -> System.String? GcpNativeRegion
        // GraphQL -> gcpNativeRegion: String! (scalar)
        if (ec.Includes("gcpNativeRegion",true))
        {
            if(this.GcpNativeRegion == null) {

                this.GcpNativeRegion = "FETCH";

            } else {


            }
        }
        else if (this.GcpNativeRegion != null && ec.Excludes("gcpNativeRegion",true))
        {
            this.GcpNativeRegion = null;
        }
    }


    #endregion

    } // class WorkloadRegion
    
    #endregion

    public static class ListWorkloadRegionExtensions
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
            this List<WorkloadRegion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<WorkloadRegion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadRegion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadRegion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadRegion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
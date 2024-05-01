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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<WorkloadRegion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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
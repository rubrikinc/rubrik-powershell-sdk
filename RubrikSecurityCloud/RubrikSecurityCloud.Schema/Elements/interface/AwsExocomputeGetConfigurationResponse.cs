// AwsExocomputeGetConfigurationResponse.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AwsExocomputeGetConfigurationResponse

    public interface AwsExocomputeGetConfigurationResponse: IFieldSpec
    {
        #region members

        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: UUID! (scalar)
        [JsonProperty("configUuid")]
        System.String? ConfigUuid { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        System.String? Message { get; set; }

        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        [JsonProperty("region")]
        AwsCloudAccountRegion? Region { get; set; }

        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        [JsonProperty("healthCheckStatus")]
        ExocomputeHealthCheckStatus? HealthCheckStatus { get; set; }

        //      C# -> ExocomputeClusterDetails? LatestExoclusterDetails
        // GraphQL -> latestExoclusterDetails: ExocomputeClusterDetails (type)
        [JsonProperty("latestExoclusterDetails")]
        ExocomputeClusterDetails? LatestExoclusterDetails { get; set; }

        //      C# -> System.Boolean? HasPcr
        // GraphQL -> hasPcr: Boolean! (scalar)
        [JsonProperty("hasPcr")]
        System.Boolean? HasPcr { get; set; }

        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String (scalar)
        [JsonProperty("pcrUrl")]
        System.String? PcrUrl { get; set; }

        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String (scalar)
        [JsonProperty("pcrLatestApprovedBundleVersion")]
        System.String? PcrLatestApprovedBundleVersion { get; set; }

        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String (scalar)
        [JsonProperty("pcrImagePullAwsNativeId")]
        System.String? PcrImagePullAwsNativeId { get; set; }


        #endregion

    } // interface AwsExocomputeGetConfigurationResponse

    #endregion



    public static class ListAwsExocomputeGetConfigurationResponseExtensions
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
            this List<AwsExocomputeGetConfigurationResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            string ind = conf.IndentStr();
            string fieldspecs = "";
            foreach (AwsExocomputeGetConfigurationResponse item in list) 
            {
                var fspec = item.AsFieldSpec(conf.Child(ignoreComposition: true));
                string typename;
                if (item is BaseType bt) {
                    typename = bt.GetGqlTypeName();
                } else {
                    typename = item.GetType().Name;
                }
                string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
                if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                    if ( conf.Flat ) {
                        fieldspecs += conf.Prefix + fspec;
                    } else {
                        fieldspecs += ind + " ... on " + typename + " {\n" + fspec + ind + "}\n";
                    }
                }
            }
            return fieldspecs; // L-II
        }

        public static List<string> SelectedFields(this List<AwsExocomputeGetConfigurationResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsExocomputeGetConfigurationResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<AwsExocomputeGetConfigurationResponse>(
                        list, 
                        instance => instance.ApplyExploratoryFieldSpec(ec));
            } else {
                foreach (AwsExocomputeGetConfigurationResponse item in list) {
                    item.ApplyExploratoryFieldSpec(ec);
                }
            }

        }

        public static void SelectForRetrieval(this List<AwsExocomputeGetConfigurationResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
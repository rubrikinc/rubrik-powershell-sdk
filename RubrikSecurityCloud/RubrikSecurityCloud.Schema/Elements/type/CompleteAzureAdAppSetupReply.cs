// CompleteAzureAdAppSetupReply.cs
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
    #region CompleteAzureAdAppSetupReply
    public class CompleteAzureAdAppSetupReply: BaseType
    {
        #region members

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> ClusterDetails? ClusterDetails
        // GraphQL -> clusterDetails: ClusterDetails (type)
        [JsonProperty("clusterDetails")]
        public ClusterDetails? ClusterDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CompleteAzureAdAppSetupReply";
    }

    public CompleteAzureAdAppSetupReply Set(
        System.String? WorkloadFid = null,
        ClusterDetails? ClusterDetails = null
    ) 
    {
        if ( WorkloadFid != null ) {
            this.WorkloadFid = WorkloadFid;
        }
        if ( ClusterDetails != null ) {
            this.ClusterDetails = ClusterDetails;
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
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        if (this.WorkloadFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadFid\n" ;
            } else {
                s += ind + "workloadFid\n" ;
            }
        }
        //      C# -> ClusterDetails? ClusterDetails
        // GraphQL -> clusterDetails: ClusterDetails (type)
        if (this.ClusterDetails != null) {
            var fspec = this.ClusterDetails.AsFieldSpec(conf.Child("clusterDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        if (ec.Includes("workloadFid",true))
        {
            if(this.WorkloadFid == null) {

                this.WorkloadFid = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadFid != null && ec.Excludes("workloadFid",true))
        {
            this.WorkloadFid = null;
        }
        //      C# -> ClusterDetails? ClusterDetails
        // GraphQL -> clusterDetails: ClusterDetails (type)
        if (ec.Includes("clusterDetails",false))
        {
            if(this.ClusterDetails == null) {

                this.ClusterDetails = new ClusterDetails();
                this.ClusterDetails.ApplyExploratoryFieldSpec(ec.NewChild("clusterDetails"));

            } else {

                this.ClusterDetails.ApplyExploratoryFieldSpec(ec.NewChild("clusterDetails"));

            }
        }
        else if (this.ClusterDetails != null && ec.Excludes("clusterDetails",false))
        {
            this.ClusterDetails = null;
        }
    }


    #endregion

    } // class CompleteAzureAdAppSetupReply
    
    #endregion

    public static class ListCompleteAzureAdAppSetupReplyExtensions
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
            this List<CompleteAzureAdAppSetupReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CompleteAzureAdAppSetupReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CompleteAzureAdAppSetupReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CompleteAzureAdAppSetupReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CompleteAzureAdAppSetupReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
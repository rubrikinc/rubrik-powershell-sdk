// ExocomputeClusterDetails.cs
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
    #region ExocomputeClusterDetails
    public class ExocomputeClusterDetails: BaseType
    {
        #region members

        //      C# -> ExoClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: ExoClusterStatus! (enum)
        [JsonProperty("clusterStatus")]
        public ExoClusterStatus? ClusterStatus { get; set; }

        //      C# -> System.String? ClusterNativeId
        // GraphQL -> clusterNativeId: String! (scalar)
        [JsonProperty("clusterNativeId")]
        public System.String? ClusterNativeId { get; set; }

        //      C# -> System.Boolean? IsExoclusterLongRunning
        // GraphQL -> isExoclusterLongRunning: Boolean! (scalar)
        [JsonProperty("isExoclusterLongRunning")]
        public System.Boolean? IsExoclusterLongRunning { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExocomputeClusterDetails";
    }

    public ExocomputeClusterDetails Set(
        ExoClusterStatus? ClusterStatus = null,
        System.String? ClusterNativeId = null,
        System.Boolean? IsExoclusterLongRunning = null
    ) 
    {
        if ( ClusterStatus != null ) {
            this.ClusterStatus = ClusterStatus;
        }
        if ( ClusterNativeId != null ) {
            this.ClusterNativeId = ClusterNativeId;
        }
        if ( IsExoclusterLongRunning != null ) {
            this.IsExoclusterLongRunning = IsExoclusterLongRunning;
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
        //      C# -> ExoClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: ExoClusterStatus! (enum)
        if (this.ClusterStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterStatus\n" ;
            } else {
                s += ind + "clusterStatus\n" ;
            }
        }
        //      C# -> System.String? ClusterNativeId
        // GraphQL -> clusterNativeId: String! (scalar)
        if (this.ClusterNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterNativeId\n" ;
            } else {
                s += ind + "clusterNativeId\n" ;
            }
        }
        //      C# -> System.Boolean? IsExoclusterLongRunning
        // GraphQL -> isExoclusterLongRunning: Boolean! (scalar)
        if (this.IsExoclusterLongRunning != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExoclusterLongRunning\n" ;
            } else {
                s += ind + "isExoclusterLongRunning\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ExoClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: ExoClusterStatus! (enum)
        if (ec.Includes("clusterStatus",true))
        {
            if(this.ClusterStatus == null) {

                this.ClusterStatus = new ExoClusterStatus();

            } else {


            }
        }
        else if (this.ClusterStatus != null && ec.Excludes("clusterStatus",true))
        {
            this.ClusterStatus = null;
        }
        //      C# -> System.String? ClusterNativeId
        // GraphQL -> clusterNativeId: String! (scalar)
        if (ec.Includes("clusterNativeId",true))
        {
            if(this.ClusterNativeId == null) {

                this.ClusterNativeId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterNativeId != null && ec.Excludes("clusterNativeId",true))
        {
            this.ClusterNativeId = null;
        }
        //      C# -> System.Boolean? IsExoclusterLongRunning
        // GraphQL -> isExoclusterLongRunning: Boolean! (scalar)
        if (ec.Includes("isExoclusterLongRunning",true))
        {
            if(this.IsExoclusterLongRunning == null) {

                this.IsExoclusterLongRunning = true;

            } else {


            }
        }
        else if (this.IsExoclusterLongRunning != null && ec.Excludes("isExoclusterLongRunning",true))
        {
            this.IsExoclusterLongRunning = null;
        }
    }


    #endregion

    } // class ExocomputeClusterDetails
    
    #endregion

    public static class ListExocomputeClusterDetailsExtensions
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
            this List<ExocomputeClusterDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExocomputeClusterDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExocomputeClusterDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExocomputeClusterDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExocomputeClusterDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
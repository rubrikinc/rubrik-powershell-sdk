// RscKeyRotationRequest.cs
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
    #region RscKeyRotationRequest
    public class RscKeyRotationRequest: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? DidKeyRotationJobFail
        // GraphQL -> didKeyRotationJobFail: Boolean! (scalar)
        [JsonProperty("didKeyRotationJobFail")]
        public System.Boolean? DidKeyRotationJobFail { get; set; }

        //      C# -> DateTime? RequestedAt
        // GraphQL -> requestedAt: DateTime (scalar)
        [JsonProperty("requestedAt")]
        public DateTime? RequestedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RscKeyRotationRequest";
    }

    public RscKeyRotationRequest Set(
        System.String? ClusterUuid = null,
        System.Boolean? DidKeyRotationJobFail = null,
        DateTime? RequestedAt = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DidKeyRotationJobFail != null ) {
            this.DidKeyRotationJobFail = DidKeyRotationJobFail;
        }
        if ( RequestedAt != null ) {
            this.RequestedAt = RequestedAt;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Boolean? DidKeyRotationJobFail
        // GraphQL -> didKeyRotationJobFail: Boolean! (scalar)
        if (this.DidKeyRotationJobFail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "didKeyRotationJobFail\n" ;
            } else {
                s += ind + "didKeyRotationJobFail\n" ;
            }
        }
        //      C# -> DateTime? RequestedAt
        // GraphQL -> requestedAt: DateTime (scalar)
        if (this.RequestedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestedAt\n" ;
            } else {
                s += ind + "requestedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Boolean? DidKeyRotationJobFail
        // GraphQL -> didKeyRotationJobFail: Boolean! (scalar)
        if (ec.Includes("didKeyRotationJobFail",true))
        {
            if(this.DidKeyRotationJobFail == null) {

                this.DidKeyRotationJobFail = true;

            } else {


            }
        }
        else if (this.DidKeyRotationJobFail != null && ec.Excludes("didKeyRotationJobFail",true))
        {
            this.DidKeyRotationJobFail = null;
        }
        //      C# -> DateTime? RequestedAt
        // GraphQL -> requestedAt: DateTime (scalar)
        if (ec.Includes("requestedAt",true))
        {
            if(this.RequestedAt == null) {

                this.RequestedAt = new DateTime();

            } else {


            }
        }
        else if (this.RequestedAt != null && ec.Excludes("requestedAt",true))
        {
            this.RequestedAt = null;
        }
    }


    #endregion

    } // class RscKeyRotationRequest
    
    #endregion

    public static class ListRscKeyRotationRequestExtensions
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
            this List<RscKeyRotationRequest> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RscKeyRotationRequest> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RscKeyRotationRequest> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RscKeyRotationRequest());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RscKeyRotationRequest> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
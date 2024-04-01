// DeleteGlobalCertificateReply.cs
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
    #region DeleteGlobalCertificateReply
    public class DeleteGlobalCertificateReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }

        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        [JsonProperty("clusterErrors")]
        public List<CertificateClusterOperationError>? ClusterErrors { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeleteGlobalCertificateReply";
    }

    public DeleteGlobalCertificateReply Set(
        List<System.String>? ClusterUuids = null,
        List<CertificateClusterOperationError>? ClusterErrors = null
    ) 
    {
        if ( ClusterUuids != null ) {
            this.ClusterUuids = ClusterUuids;
        }
        if ( ClusterErrors != null ) {
            this.ClusterErrors = ClusterErrors;
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
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (this.ClusterUuids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuids\n" ;
            } else {
                s += ind + "clusterUuids\n" ;
            }
        }
        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        if (this.ClusterErrors != null) {
            var fspec = this.ClusterErrors.AsFieldSpec(conf.Child("clusterErrors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterErrors {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (ec.Includes("clusterUuids",true))
        {
            if(this.ClusterUuids == null) {

                this.ClusterUuids = new List<System.String>();

            } else {


            }
        }
        else if (this.ClusterUuids != null && ec.Excludes("clusterUuids",true))
        {
            this.ClusterUuids = null;
        }
        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        if (ec.Includes("clusterErrors",false))
        {
            if(this.ClusterErrors == null) {

                this.ClusterErrors = new List<CertificateClusterOperationError>();
                this.ClusterErrors.ApplyExploratoryFieldSpec(ec.NewChild("clusterErrors"));

            } else {

                this.ClusterErrors.ApplyExploratoryFieldSpec(ec.NewChild("clusterErrors"));

            }
        }
        else if (this.ClusterErrors != null && ec.Excludes("clusterErrors",false))
        {
            this.ClusterErrors = null;
        }
    }


    #endregion

    } // class DeleteGlobalCertificateReply
    
    #endregion

    public static class ListDeleteGlobalCertificateReplyExtensions
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
            this List<DeleteGlobalCertificateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DeleteGlobalCertificateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DeleteGlobalCertificateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteGlobalCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DeleteGlobalCertificateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
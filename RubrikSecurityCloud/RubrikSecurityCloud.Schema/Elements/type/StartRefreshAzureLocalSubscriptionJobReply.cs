// StartRefreshAzureLocalSubscriptionJobReply.cs
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
    #region StartRefreshAzureLocalSubscriptionJobReply
    public class StartRefreshAzureLocalSubscriptionJobReply: BaseType
    {
        #region members

        //      C# -> System.String? ClusterDiscoveryTaskchainId
        // GraphQL -> clusterDiscoveryTaskchainId: String! (scalar)
        [JsonProperty("clusterDiscoveryTaskchainId")]
        public System.String? ClusterDiscoveryTaskchainId { get; set; }

        //      C# -> System.String? VmDiscoveryTaskchainId
        // GraphQL -> vmDiscoveryTaskchainId: String! (scalar)
        [JsonProperty("vmDiscoveryTaskchainId")]
        public System.String? VmDiscoveryTaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartRefreshAzureLocalSubscriptionJobReply";
    }

    public StartRefreshAzureLocalSubscriptionJobReply Set(
        System.String? ClusterDiscoveryTaskchainId = null,
        System.String? VmDiscoveryTaskchainId = null
    ) 
    {
        if ( ClusterDiscoveryTaskchainId != null ) {
            this.ClusterDiscoveryTaskchainId = ClusterDiscoveryTaskchainId;
        }
        if ( VmDiscoveryTaskchainId != null ) {
            this.VmDiscoveryTaskchainId = VmDiscoveryTaskchainId;
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
        //      C# -> System.String? ClusterDiscoveryTaskchainId
        // GraphQL -> clusterDiscoveryTaskchainId: String! (scalar)
        if (this.ClusterDiscoveryTaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterDiscoveryTaskchainId\n" ;
            } else {
                s += ind + "clusterDiscoveryTaskchainId\n" ;
            }
        }
        //      C# -> System.String? VmDiscoveryTaskchainId
        // GraphQL -> vmDiscoveryTaskchainId: String! (scalar)
        if (this.VmDiscoveryTaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmDiscoveryTaskchainId\n" ;
            } else {
                s += ind + "vmDiscoveryTaskchainId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ClusterDiscoveryTaskchainId
        // GraphQL -> clusterDiscoveryTaskchainId: String! (scalar)
        if (ec.Includes("clusterDiscoveryTaskchainId",true))
        {
            if(this.ClusterDiscoveryTaskchainId == null) {

                this.ClusterDiscoveryTaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterDiscoveryTaskchainId != null && ec.Excludes("clusterDiscoveryTaskchainId",true))
        {
            this.ClusterDiscoveryTaskchainId = null;
        }
        //      C# -> System.String? VmDiscoveryTaskchainId
        // GraphQL -> vmDiscoveryTaskchainId: String! (scalar)
        if (ec.Includes("vmDiscoveryTaskchainId",true))
        {
            if(this.VmDiscoveryTaskchainId == null) {

                this.VmDiscoveryTaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.VmDiscoveryTaskchainId != null && ec.Excludes("vmDiscoveryTaskchainId",true))
        {
            this.VmDiscoveryTaskchainId = null;
        }
    }


    #endregion

    } // class StartRefreshAzureLocalSubscriptionJobReply
    
    #endregion

    public static class ListStartRefreshAzureLocalSubscriptionJobReplyExtensions
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
            this List<StartRefreshAzureLocalSubscriptionJobReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StartRefreshAzureLocalSubscriptionJobReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StartRefreshAzureLocalSubscriptionJobReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartRefreshAzureLocalSubscriptionJobReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StartRefreshAzureLocalSubscriptionJobReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
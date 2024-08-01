// DisabledReplicationLocationDefinition.cs
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
    #region DisabledReplicationLocationDefinition
    public class DisabledReplicationLocationDefinition: BaseType
    {
        #region members

        //      C# -> System.String? PeerClusterCertificate
        // GraphQL -> peerClusterCertificate: String (scalar)
        [JsonProperty("peerClusterCertificate")]
        public System.String? PeerClusterCertificate { get; set; }

        //      C# -> System.String? PeerClusterName
        // GraphQL -> peerClusterName: String! (scalar)
        [JsonProperty("peerClusterName")]
        public System.String? PeerClusterName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DisabledReplicationLocationDefinition";
    }

    public DisabledReplicationLocationDefinition Set(
        System.String? PeerClusterCertificate = null,
        System.String? PeerClusterName = null
    ) 
    {
        if ( PeerClusterCertificate != null ) {
            this.PeerClusterCertificate = PeerClusterCertificate;
        }
        if ( PeerClusterName != null ) {
            this.PeerClusterName = PeerClusterName;
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
        //      C# -> System.String? PeerClusterCertificate
        // GraphQL -> peerClusterCertificate: String (scalar)
        if (this.PeerClusterCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "peerClusterCertificate\n" ;
            } else {
                s += ind + "peerClusterCertificate\n" ;
            }
        }
        //      C# -> System.String? PeerClusterName
        // GraphQL -> peerClusterName: String! (scalar)
        if (this.PeerClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "peerClusterName\n" ;
            } else {
                s += ind + "peerClusterName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? PeerClusterCertificate
        // GraphQL -> peerClusterCertificate: String (scalar)
        if (ec.Includes("peerClusterCertificate",true))
        {
            if(this.PeerClusterCertificate == null) {

                this.PeerClusterCertificate = "FETCH";

            } else {


            }
        }
        else if (this.PeerClusterCertificate != null && ec.Excludes("peerClusterCertificate",true))
        {
            this.PeerClusterCertificate = null;
        }
        //      C# -> System.String? PeerClusterName
        // GraphQL -> peerClusterName: String! (scalar)
        if (ec.Includes("peerClusterName",true))
        {
            if(this.PeerClusterName == null) {

                this.PeerClusterName = "FETCH";

            } else {


            }
        }
        else if (this.PeerClusterName != null && ec.Excludes("peerClusterName",true))
        {
            this.PeerClusterName = null;
        }
    }


    #endregion

    } // class DisabledReplicationLocationDefinition
    
    #endregion

    public static class ListDisabledReplicationLocationDefinitionExtensions
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
            this List<DisabledReplicationLocationDefinition> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DisabledReplicationLocationDefinition> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DisabledReplicationLocationDefinition> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DisabledReplicationLocationDefinition());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DisabledReplicationLocationDefinition> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
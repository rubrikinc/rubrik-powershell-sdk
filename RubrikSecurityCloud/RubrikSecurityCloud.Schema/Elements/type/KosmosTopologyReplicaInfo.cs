// KosmosTopologyReplicaInfo.cs
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
    #region KosmosTopologyReplicaInfo
    public class KosmosTopologyReplicaInfo: BaseType
    {
        #region members

        //      C# -> KosmosTopologyReplicaRole? Role
        // GraphQL -> role: KosmosTopologyReplicaRole! (enum)
        [JsonProperty("role")]
        public KosmosTopologyReplicaRole? Role { get; set; }

        //      C# -> KosmosTopologyReplicaStatus? Status
        // GraphQL -> status: KosmosTopologyReplicaStatus! (enum)
        [JsonProperty("status")]
        public KosmosTopologyReplicaStatus? Status { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        [JsonProperty("replicaId")]
        public System.String? ReplicaId { get; set; }

        //      C# -> System.String? ReplicaName
        // GraphQL -> replicaName: String! (scalar)
        [JsonProperty("replicaName")]
        public System.String? ReplicaName { get; set; }

        //      C# -> List<System.String>? StatusMessages
        // GraphQL -> statusMessages: [String!]! (scalar)
        [JsonProperty("statusMessages")]
        public List<System.String>? StatusMessages { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KosmosTopologyReplicaInfo";
    }

    public KosmosTopologyReplicaInfo Set(
        KosmosTopologyReplicaRole? Role = null,
        KosmosTopologyReplicaStatus? Status = null,
        System.String? HostId = null,
        System.String? ReplicaId = null,
        System.String? ReplicaName = null,
        List<System.String>? StatusMessages = null
    ) 
    {
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( ReplicaId != null ) {
            this.ReplicaId = ReplicaId;
        }
        if ( ReplicaName != null ) {
            this.ReplicaName = ReplicaName;
        }
        if ( StatusMessages != null ) {
            this.StatusMessages = StatusMessages;
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
        //      C# -> KosmosTopologyReplicaRole? Role
        // GraphQL -> role: KosmosTopologyReplicaRole! (enum)
        if (this.Role != null) {
            if (conf.Flat) {
                s += conf.Prefix + "role\n" ;
            } else {
                s += ind + "role\n" ;
            }
        }
        //      C# -> KosmosTopologyReplicaStatus? Status
        // GraphQL -> status: KosmosTopologyReplicaStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        if (this.ReplicaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicaId\n" ;
            } else {
                s += ind + "replicaId\n" ;
            }
        }
        //      C# -> System.String? ReplicaName
        // GraphQL -> replicaName: String! (scalar)
        if (this.ReplicaName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicaName\n" ;
            } else {
                s += ind + "replicaName\n" ;
            }
        }
        //      C# -> List<System.String>? StatusMessages
        // GraphQL -> statusMessages: [String!]! (scalar)
        if (this.StatusMessages != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessages\n" ;
            } else {
                s += ind + "statusMessages\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> KosmosTopologyReplicaRole? Role
        // GraphQL -> role: KosmosTopologyReplicaRole! (enum)
        if (ec.Includes("role",true))
        {
            if(this.Role == null) {

                this.Role = new KosmosTopologyReplicaRole();

            } else {


            }
        }
        else if (this.Role != null && ec.Excludes("role",true))
        {
            this.Role = null;
        }
        //      C# -> KosmosTopologyReplicaStatus? Status
        // GraphQL -> status: KosmosTopologyReplicaStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new KosmosTopologyReplicaStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        if (ec.Includes("replicaId",true))
        {
            if(this.ReplicaId == null) {

                this.ReplicaId = "FETCH";

            } else {


            }
        }
        else if (this.ReplicaId != null && ec.Excludes("replicaId",true))
        {
            this.ReplicaId = null;
        }
        //      C# -> System.String? ReplicaName
        // GraphQL -> replicaName: String! (scalar)
        if (ec.Includes("replicaName",true))
        {
            if(this.ReplicaName == null) {

                this.ReplicaName = "FETCH";

            } else {


            }
        }
        else if (this.ReplicaName != null && ec.Excludes("replicaName",true))
        {
            this.ReplicaName = null;
        }
        //      C# -> List<System.String>? StatusMessages
        // GraphQL -> statusMessages: [String!]! (scalar)
        if (ec.Includes("statusMessages",true))
        {
            if(this.StatusMessages == null) {

                this.StatusMessages = new List<System.String>();

            } else {


            }
        }
        else if (this.StatusMessages != null && ec.Excludes("statusMessages",true))
        {
            this.StatusMessages = null;
        }
    }


    #endregion

    } // class KosmosTopologyReplicaInfo
    
    #endregion

    public static class ListKosmosTopologyReplicaInfoExtensions
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
            this List<KosmosTopologyReplicaInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KosmosTopologyReplicaInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KosmosTopologyReplicaInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KosmosTopologyReplicaInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KosmosTopologyReplicaInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
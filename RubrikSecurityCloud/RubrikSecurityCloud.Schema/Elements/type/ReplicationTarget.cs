// ReplicationTarget.cs
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
    #region ReplicationTarget
    public class ReplicationTarget: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        [JsonProperty("targetClusterAddress")]
        public System.String? TargetClusterAddress { get; set; }

        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        [JsonProperty("targetClusterName")]
        public System.String? TargetClusterName { get; set; }

        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        [JsonProperty("targetClusterUuid")]
        public System.String? TargetClusterUuid { get; set; }

        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        [JsonProperty("totalStorage")]
        public System.Int64? TotalStorage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationTarget";
    }

    public ReplicationTarget Set(
        System.String? Id = null,
        System.String? TargetClusterAddress = null,
        System.String? TargetClusterName = null,
        System.String? TargetClusterUuid = null,
        System.Int64? TotalStorage = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( TargetClusterAddress != null ) {
            this.TargetClusterAddress = TargetClusterAddress;
        }
        if ( TargetClusterName != null ) {
            this.TargetClusterName = TargetClusterName;
        }
        if ( TargetClusterUuid != null ) {
            this.TargetClusterUuid = TargetClusterUuid;
        }
        if ( TotalStorage != null ) {
            this.TotalStorage = TotalStorage;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        if (this.TargetClusterAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetClusterAddress\n" ;
            } else {
                s += ind + "targetClusterAddress\n" ;
            }
        }
        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        if (this.TargetClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetClusterName\n" ;
            } else {
                s += ind + "targetClusterName\n" ;
            }
        }
        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        if (this.TargetClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetClusterUuid\n" ;
            } else {
                s += ind + "targetClusterUuid\n" ;
            }
        }
        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        if (this.TotalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalStorage\n" ;
            } else {
                s += ind + "totalStorage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        if (ec.Includes("targetClusterAddress",true))
        {
            if(this.TargetClusterAddress == null) {

                this.TargetClusterAddress = "FETCH";

            } else {


            }
        }
        else if (this.TargetClusterAddress != null && ec.Excludes("targetClusterAddress",true))
        {
            this.TargetClusterAddress = null;
        }
        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        if (ec.Includes("targetClusterName",true))
        {
            if(this.TargetClusterName == null) {

                this.TargetClusterName = "FETCH";

            } else {


            }
        }
        else if (this.TargetClusterName != null && ec.Excludes("targetClusterName",true))
        {
            this.TargetClusterName = null;
        }
        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        if (ec.Includes("targetClusterUuid",true))
        {
            if(this.TargetClusterUuid == null) {

                this.TargetClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.TargetClusterUuid != null && ec.Excludes("targetClusterUuid",true))
        {
            this.TargetClusterUuid = null;
        }
        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        if (ec.Includes("totalStorage",true))
        {
            if(this.TotalStorage == null) {

                this.TotalStorage = new System.Int64();

            } else {


            }
        }
        else if (this.TotalStorage != null && ec.Excludes("totalStorage",true))
        {
            this.TotalStorage = null;
        }
    }


    #endregion

    } // class ReplicationTarget
    
    #endregion

    public static class ListReplicationTargetExtensions
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
            this List<ReplicationTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReplicationTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
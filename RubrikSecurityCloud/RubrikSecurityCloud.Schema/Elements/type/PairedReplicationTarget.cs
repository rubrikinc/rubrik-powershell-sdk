// PairedReplicationTarget.cs
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
    #region PairedReplicationTarget
    public class PairedReplicationTarget: BaseType
    {
        #region members

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> List<ValidReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ValidReplicationTarget!]! (type)
        [JsonProperty("replicationTargets")]
        public List<ValidReplicationTarget>? ReplicationTargets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PairedReplicationTarget";
    }

    public PairedReplicationTarget Set(
        System.String? Uuid = null,
        List<ValidReplicationTarget>? ReplicationTargets = null
    ) 
    {
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( ReplicationTargets != null ) {
            this.ReplicationTargets = ReplicationTargets;
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
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (this.Uuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uuid\n" ;
            } else {
                s += ind + "uuid\n" ;
            }
        }
        //      C# -> List<ValidReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ValidReplicationTarget!]! (type)
        if (this.ReplicationTargets != null) {
            var fspec = this.ReplicationTargets.AsFieldSpec(conf.Child("replicationTargets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationTargets" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (ec.Includes("uuid",true))
        {
            if(this.Uuid == null) {

                this.Uuid = "FETCH";

            } else {


            }
        }
        else if (this.Uuid != null && ec.Excludes("uuid",true))
        {
            this.Uuid = null;
        }
        //      C# -> List<ValidReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ValidReplicationTarget!]! (type)
        if (ec.Includes("replicationTargets",false))
        {
            if(this.ReplicationTargets == null) {

                this.ReplicationTargets = new List<ValidReplicationTarget>();
                this.ReplicationTargets.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargets"));

            } else {

                this.ReplicationTargets.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargets"));

            }
        }
        else if (this.ReplicationTargets != null && ec.Excludes("replicationTargets",false))
        {
            this.ReplicationTargets = null;
        }
    }


    #endregion

    } // class PairedReplicationTarget
    
    #endregion

    public static class ListPairedReplicationTargetExtensions
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
            this List<PairedReplicationTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PairedReplicationTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PairedReplicationTarget> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PairedReplicationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PairedReplicationTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
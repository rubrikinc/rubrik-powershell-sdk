// BidirectionalReplicationSpec.cs
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
    #region BidirectionalReplicationSpec
    public class BidirectionalReplicationSpec: BaseType
    {
        #region members

        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
        // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
        [JsonProperty("replicationSpec1")]
        public UnidirectionalReplicationSpec? ReplicationSpec1 { get; set; }

        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
        // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
        [JsonProperty("replicationSpec2")]
        public UnidirectionalReplicationSpec? ReplicationSpec2 { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BidirectionalReplicationSpec";
    }

    public BidirectionalReplicationSpec Set(
        UnidirectionalReplicationSpec? ReplicationSpec1 = null,
        UnidirectionalReplicationSpec? ReplicationSpec2 = null
    ) 
    {
        if ( ReplicationSpec1 != null ) {
            this.ReplicationSpec1 = ReplicationSpec1;
        }
        if ( ReplicationSpec2 != null ) {
            this.ReplicationSpec2 = ReplicationSpec2;
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
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
        // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
        if (this.ReplicationSpec1 != null) {
            var fspec = this.ReplicationSpec1.AsFieldSpec(conf.Child("replicationSpec1"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationSpec1" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
        // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
        if (this.ReplicationSpec2 != null) {
            var fspec = this.ReplicationSpec2.AsFieldSpec(conf.Child("replicationSpec2"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationSpec2" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
        // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
        if (ec.Includes("replicationSpec1",false))
        {
            if(this.ReplicationSpec1 == null) {

                this.ReplicationSpec1 = new UnidirectionalReplicationSpec();
                this.ReplicationSpec1.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec1"));

            } else {

                this.ReplicationSpec1.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec1"));

            }
        }
        else if (this.ReplicationSpec1 != null && ec.Excludes("replicationSpec1",false))
        {
            this.ReplicationSpec1 = null;
        }
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
        // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
        if (ec.Includes("replicationSpec2",false))
        {
            if(this.ReplicationSpec2 == null) {

                this.ReplicationSpec2 = new UnidirectionalReplicationSpec();
                this.ReplicationSpec2.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec2"));

            } else {

                this.ReplicationSpec2.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec2"));

            }
        }
        else if (this.ReplicationSpec2 != null && ec.Excludes("replicationSpec2",false))
        {
            this.ReplicationSpec2 = null;
        }
    }


    #endregion

    } // class BidirectionalReplicationSpec
    
    #endregion

    public static class ListBidirectionalReplicationSpecExtensions
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
            this List<BidirectionalReplicationSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BidirectionalReplicationSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BidirectionalReplicationSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BidirectionalReplicationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BidirectionalReplicationSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// SpecificReplicationSpec.cs
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
    #region SpecificReplicationSpec
    public class SpecificReplicationSpec: BaseType
    {
        #region members

        //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
        // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
        [JsonProperty("bidirectionalSpec")]
        public BidirectionalReplicationSpec? BidirectionalSpec { get; set; }

        //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
        // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
        [JsonProperty("cloudLocationSpec")]
        public ReplicationToCloudLocationSpec? CloudLocationSpec { get; set; }

        //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
        // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
        [JsonProperty("cloudRegionSpec")]
        public ReplicationToCloudRegionSpec? CloudRegionSpec { get; set; }

        //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
        // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
        [JsonProperty("unidirectionalSpec")]
        public UnidirectionalReplicationSpec? UnidirectionalSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SpecificReplicationSpec";
    }

    public SpecificReplicationSpec Set(
        BidirectionalReplicationSpec? BidirectionalSpec = null,
        ReplicationToCloudLocationSpec? CloudLocationSpec = null,
        ReplicationToCloudRegionSpec? CloudRegionSpec = null,
        UnidirectionalReplicationSpec? UnidirectionalSpec = null
    ) 
    {
        if ( BidirectionalSpec != null ) {
            this.BidirectionalSpec = BidirectionalSpec;
        }
        if ( CloudLocationSpec != null ) {
            this.CloudLocationSpec = CloudLocationSpec;
        }
        if ( CloudRegionSpec != null ) {
            this.CloudRegionSpec = CloudRegionSpec;
        }
        if ( UnidirectionalSpec != null ) {
            this.UnidirectionalSpec = UnidirectionalSpec;
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
        //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
        // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
        if (this.BidirectionalSpec != null) {
            var fspec = this.BidirectionalSpec.AsFieldSpec(conf.Child("bidirectionalSpec"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "bidirectionalSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
        // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
        if (this.CloudLocationSpec != null) {
            var fspec = this.CloudLocationSpec.AsFieldSpec(conf.Child("cloudLocationSpec"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudLocationSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
        // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
        if (this.CloudRegionSpec != null) {
            var fspec = this.CloudRegionSpec.AsFieldSpec(conf.Child("cloudRegionSpec"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudRegionSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
        // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
        if (this.UnidirectionalSpec != null) {
            var fspec = this.UnidirectionalSpec.AsFieldSpec(conf.Child("unidirectionalSpec"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "unidirectionalSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
        // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
        if (ec.Includes("bidirectionalSpec",false))
        {
            if(this.BidirectionalSpec == null) {

                this.BidirectionalSpec = new BidirectionalReplicationSpec();
                this.BidirectionalSpec.ApplyExploratoryFieldSpec(ec.NewChild("bidirectionalSpec"));

            } else {

                this.BidirectionalSpec.ApplyExploratoryFieldSpec(ec.NewChild("bidirectionalSpec"));

            }
        }
        else if (this.BidirectionalSpec != null && ec.Excludes("bidirectionalSpec",false))
        {
            this.BidirectionalSpec = null;
        }
        //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
        // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
        if (ec.Includes("cloudLocationSpec",false))
        {
            if(this.CloudLocationSpec == null) {

                this.CloudLocationSpec = new ReplicationToCloudLocationSpec();
                this.CloudLocationSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudLocationSpec"));

            } else {

                this.CloudLocationSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudLocationSpec"));

            }
        }
        else if (this.CloudLocationSpec != null && ec.Excludes("cloudLocationSpec",false))
        {
            this.CloudLocationSpec = null;
        }
        //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
        // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
        if (ec.Includes("cloudRegionSpec",false))
        {
            if(this.CloudRegionSpec == null) {

                this.CloudRegionSpec = new ReplicationToCloudRegionSpec();
                this.CloudRegionSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudRegionSpec"));

            } else {

                this.CloudRegionSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudRegionSpec"));

            }
        }
        else if (this.CloudRegionSpec != null && ec.Excludes("cloudRegionSpec",false))
        {
            this.CloudRegionSpec = null;
        }
        //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
        // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
        if (ec.Includes("unidirectionalSpec",false))
        {
            if(this.UnidirectionalSpec == null) {

                this.UnidirectionalSpec = new UnidirectionalReplicationSpec();
                this.UnidirectionalSpec.ApplyExploratoryFieldSpec(ec.NewChild("unidirectionalSpec"));

            } else {

                this.UnidirectionalSpec.ApplyExploratoryFieldSpec(ec.NewChild("unidirectionalSpec"));

            }
        }
        else if (this.UnidirectionalSpec != null && ec.Excludes("unidirectionalSpec",false))
        {
            this.UnidirectionalSpec = null;
        }
    }


    #endregion

    } // class SpecificReplicationSpec
    
    #endregion

    public static class ListSpecificReplicationSpecExtensions
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
            this List<SpecificReplicationSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SpecificReplicationSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SpecificReplicationSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SpecificReplicationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SpecificReplicationSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// AzureAdObject.cs
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
    #region AzureAdObject
    public class AzureAdObject: BaseType
    {
        #region members

        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        [JsonProperty("type")]
        public AzureAdObjectType? Type { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> AzureAdObjects? AzureAdObjects
        // GraphQL -> azureAdObjects: AzureAdObjects! (type)
        [JsonProperty("azureAdObjects")]
        public AzureAdObjects? AzureAdObjects { get; set; }

        //      C# -> Map? Relationships
        // GraphQL -> relationships: Map! (type)
        [JsonProperty("relationships")]
        public Map? Relationships { get; set; }

        //      C# -> List<AzureAdReverseRelationship>? ReverseRelationships
        // GraphQL -> reverseRelationships: [AzureAdReverseRelationship!]! (type)
        [JsonProperty("reverseRelationships")]
        public List<AzureAdReverseRelationship>? ReverseRelationships { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdObject";
    }

    public AzureAdObject Set(
        AzureAdObjectType? Type = null,
        System.String? ObjectId = null,
        System.String? SnapshotId = null,
        AzureAdObjects? AzureAdObjects = null,
        Map? Relationships = null,
        List<AzureAdReverseRelationship>? ReverseRelationships = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( AzureAdObjects != null ) {
            this.AzureAdObjects = AzureAdObjects;
        }
        if ( Relationships != null ) {
            this.Relationships = Relationships;
        }
        if ( ReverseRelationships != null ) {
            this.ReverseRelationships = ReverseRelationships;
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
        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> AzureAdObjects? AzureAdObjects
        // GraphQL -> azureAdObjects: AzureAdObjects! (type)
        if (this.AzureAdObjects != null) {
            var fspec = this.AzureAdObjects.AsFieldSpec(conf.Child("azureAdObjects"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Map? Relationships
        // GraphQL -> relationships: Map! (type)
        if (this.Relationships != null) {
            var fspec = this.Relationships.AsFieldSpec(conf.Child("relationships"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "relationships" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureAdReverseRelationship>? ReverseRelationships
        // GraphQL -> reverseRelationships: [AzureAdReverseRelationship!]! (type)
        if (this.ReverseRelationships != null) {
            var fspec = this.ReverseRelationships.AsFieldSpec(conf.Child("reverseRelationships"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "reverseRelationships" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new AzureAdObjectType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> AzureAdObjects? AzureAdObjects
        // GraphQL -> azureAdObjects: AzureAdObjects! (type)
        if (ec.Includes("azureAdObjects",false))
        {
            if(this.AzureAdObjects == null) {

                this.AzureAdObjects = new AzureAdObjects();
                this.AzureAdObjects.ApplyExploratoryFieldSpec(ec.NewChild("azureAdObjects"));

            } else {

                this.AzureAdObjects.ApplyExploratoryFieldSpec(ec.NewChild("azureAdObjects"));

            }
        }
        else if (this.AzureAdObjects != null && ec.Excludes("azureAdObjects",false))
        {
            this.AzureAdObjects = null;
        }
        //      C# -> Map? Relationships
        // GraphQL -> relationships: Map! (type)
        if (ec.Includes("relationships",false))
        {
            if(this.Relationships == null) {

                this.Relationships = new Map();
                this.Relationships.ApplyExploratoryFieldSpec(ec.NewChild("relationships"));

            } else {

                this.Relationships.ApplyExploratoryFieldSpec(ec.NewChild("relationships"));

            }
        }
        else if (this.Relationships != null && ec.Excludes("relationships",false))
        {
            this.Relationships = null;
        }
        //      C# -> List<AzureAdReverseRelationship>? ReverseRelationships
        // GraphQL -> reverseRelationships: [AzureAdReverseRelationship!]! (type)
        if (ec.Includes("reverseRelationships",false))
        {
            if(this.ReverseRelationships == null) {

                this.ReverseRelationships = new List<AzureAdReverseRelationship>();
                this.ReverseRelationships.ApplyExploratoryFieldSpec(ec.NewChild("reverseRelationships"));

            } else {

                this.ReverseRelationships.ApplyExploratoryFieldSpec(ec.NewChild("reverseRelationships"));

            }
        }
        else if (this.ReverseRelationships != null && ec.Excludes("reverseRelationships",false))
        {
            this.ReverseRelationships = null;
        }
    }


    #endregion

    } // class AzureAdObject
    
    #endregion

    public static class ListAzureAdObjectExtensions
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
            this List<AzureAdObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
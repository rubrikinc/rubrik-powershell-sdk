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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdObject";
    }

    public AzureAdObject Set(
        AzureAdObjectType? Type = null,
        System.String? ObjectId = null,
        System.String? SnapshotId = null,
        AzureAdObjects? AzureAdObjects = null
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdObjects {\n" + fspec + ind + "}\n" ;
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
    }


    #endregion

    } // class AzureAdObject
    
    #endregion

    public static class ListAzureAdObjectExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AzureAdObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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
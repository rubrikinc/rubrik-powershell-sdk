// CreateLegalHoldReply.cs
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
    #region CreateLegalHoldReply
    public class CreateLegalHoldReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        [JsonProperty("snapshotIds")]
        public List<System.String>? SnapshotIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateLegalHoldReply";
    }

    public CreateLegalHoldReply Set(
        List<System.String>? SnapshotIds = null
    ) 
    {
        if ( SnapshotIds != null ) {
            this.SnapshotIds = SnapshotIds;
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
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (this.SnapshotIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotIds\n" ;
            } else {
                s += ind + "snapshotIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (ec.Includes("snapshotIds",true))
        {
            if(this.SnapshotIds == null) {

                this.SnapshotIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SnapshotIds != null && ec.Excludes("snapshotIds",true))
        {
            this.SnapshotIds = null;
        }
    }


    #endregion

    } // class CreateLegalHoldReply
    
    #endregion

    public static class ListCreateLegalHoldReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CreateLegalHoldReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CreateLegalHoldReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateLegalHoldReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateLegalHoldReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateLegalHoldReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
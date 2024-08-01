// RcvOwnerArchivalLocationEncryptionKey.cs
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
    #region RcvOwnerArchivalLocationEncryptionKey
    public class RcvOwnerArchivalLocationEncryptionKey: BaseType
    {
        #region members

        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: UUID! (scalar)
        [JsonProperty("ownerId")]
        public System.String? OwnerId { get; set; }

        //      C# -> System.String? OwnerName
        // GraphQL -> ownerName: String! (scalar)
        [JsonProperty("ownerName")]
        public System.String? OwnerName { get; set; }

        //      C# -> ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo
        // GraphQL -> archivalLocationKeyAssignmentInfo: ArchivalLocationKeyAssignmentInfo! (type)
        [JsonProperty("archivalLocationKeyAssignmentInfo")]
        public ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvOwnerArchivalLocationEncryptionKey";
    }

    public RcvOwnerArchivalLocationEncryptionKey Set(
        System.String? OwnerId = null,
        System.String? OwnerName = null,
        ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo = null
    ) 
    {
        if ( OwnerId != null ) {
            this.OwnerId = OwnerId;
        }
        if ( OwnerName != null ) {
            this.OwnerName = OwnerName;
        }
        if ( ArchivalLocationKeyAssignmentInfo != null ) {
            this.ArchivalLocationKeyAssignmentInfo = ArchivalLocationKeyAssignmentInfo;
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
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: UUID! (scalar)
        if (this.OwnerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ownerId\n" ;
            } else {
                s += ind + "ownerId\n" ;
            }
        }
        //      C# -> System.String? OwnerName
        // GraphQL -> ownerName: String! (scalar)
        if (this.OwnerName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ownerName\n" ;
            } else {
                s += ind + "ownerName\n" ;
            }
        }
        //      C# -> ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo
        // GraphQL -> archivalLocationKeyAssignmentInfo: ArchivalLocationKeyAssignmentInfo! (type)
        if (this.ArchivalLocationKeyAssignmentInfo != null) {
            var fspec = this.ArchivalLocationKeyAssignmentInfo.AsFieldSpec(conf.Child("archivalLocationKeyAssignmentInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalLocationKeyAssignmentInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: UUID! (scalar)
        if (ec.Includes("ownerId",true))
        {
            if(this.OwnerId == null) {

                this.OwnerId = "FETCH";

            } else {


            }
        }
        else if (this.OwnerId != null && ec.Excludes("ownerId",true))
        {
            this.OwnerId = null;
        }
        //      C# -> System.String? OwnerName
        // GraphQL -> ownerName: String! (scalar)
        if (ec.Includes("ownerName",true))
        {
            if(this.OwnerName == null) {

                this.OwnerName = "FETCH";

            } else {


            }
        }
        else if (this.OwnerName != null && ec.Excludes("ownerName",true))
        {
            this.OwnerName = null;
        }
        //      C# -> ArchivalLocationKeyAssignmentInfo? ArchivalLocationKeyAssignmentInfo
        // GraphQL -> archivalLocationKeyAssignmentInfo: ArchivalLocationKeyAssignmentInfo! (type)
        if (ec.Includes("archivalLocationKeyAssignmentInfo",false))
        {
            if(this.ArchivalLocationKeyAssignmentInfo == null) {

                this.ArchivalLocationKeyAssignmentInfo = new ArchivalLocationKeyAssignmentInfo();
                this.ArchivalLocationKeyAssignmentInfo.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocationKeyAssignmentInfo"));

            } else {

                this.ArchivalLocationKeyAssignmentInfo.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocationKeyAssignmentInfo"));

            }
        }
        else if (this.ArchivalLocationKeyAssignmentInfo != null && ec.Excludes("archivalLocationKeyAssignmentInfo",false))
        {
            this.ArchivalLocationKeyAssignmentInfo = null;
        }
    }


    #endregion

    } // class RcvOwnerArchivalLocationEncryptionKey
    
    #endregion

    public static class ListRcvOwnerArchivalLocationEncryptionKeyExtensions
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
            this List<RcvOwnerArchivalLocationEncryptionKey> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvOwnerArchivalLocationEncryptionKey> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvOwnerArchivalLocationEncryptionKey> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvOwnerArchivalLocationEncryptionKey());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvOwnerArchivalLocationEncryptionKey> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// ObjectRecordChange.cs
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
    #region ObjectRecordChange
    public class ObjectRecordChange: BaseType
    {
        #region members

        //      C# -> AppItemActionType? Action
        // GraphQL -> action: AppItemActionType! (enum)
        [JsonProperty("action")]
        public AppItemActionType? Action { get; set; }

        //      C# -> SalesforceObjectRecord? NewRecord
        // GraphQL -> newRecord: SalesforceObjectRecord (type)
        [JsonProperty("newRecord")]
        public SalesforceObjectRecord? NewRecord { get; set; }

        //      C# -> SalesforceObjectRecord? OldRecord
        // GraphQL -> oldRecord: SalesforceObjectRecord (type)
        [JsonProperty("oldRecord")]
        public SalesforceObjectRecord? OldRecord { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectRecordChange";
    }

    public ObjectRecordChange Set(
        AppItemActionType? Action = null,
        SalesforceObjectRecord? NewRecord = null,
        SalesforceObjectRecord? OldRecord = null
    ) 
    {
        if ( Action != null ) {
            this.Action = Action;
        }
        if ( NewRecord != null ) {
            this.NewRecord = NewRecord;
        }
        if ( OldRecord != null ) {
            this.OldRecord = OldRecord;
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
        //      C# -> AppItemActionType? Action
        // GraphQL -> action: AppItemActionType! (enum)
        if (this.Action != null) {
            if (conf.Flat) {
                s += conf.Prefix + "action\n" ;
            } else {
                s += ind + "action\n" ;
            }
        }
        //      C# -> SalesforceObjectRecord? NewRecord
        // GraphQL -> newRecord: SalesforceObjectRecord (type)
        if (this.NewRecord != null) {
            var fspec = this.NewRecord.AsFieldSpec(conf.Child("newRecord"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newRecord" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SalesforceObjectRecord? OldRecord
        // GraphQL -> oldRecord: SalesforceObjectRecord (type)
        if (this.OldRecord != null) {
            var fspec = this.OldRecord.AsFieldSpec(conf.Child("oldRecord"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldRecord" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AppItemActionType? Action
        // GraphQL -> action: AppItemActionType! (enum)
        if (ec.Includes("action",true))
        {
            if(this.Action == null) {

                this.Action = new AppItemActionType();

            } else {


            }
        }
        else if (this.Action != null && ec.Excludes("action",true))
        {
            this.Action = null;
        }
        //      C# -> SalesforceObjectRecord? NewRecord
        // GraphQL -> newRecord: SalesforceObjectRecord (type)
        if (ec.Includes("newRecord",false))
        {
            if(this.NewRecord == null) {

                this.NewRecord = new SalesforceObjectRecord();
                this.NewRecord.ApplyExploratoryFieldSpec(ec.NewChild("newRecord"));

            } else {

                this.NewRecord.ApplyExploratoryFieldSpec(ec.NewChild("newRecord"));

            }
        }
        else if (this.NewRecord != null && ec.Excludes("newRecord",false))
        {
            this.NewRecord = null;
        }
        //      C# -> SalesforceObjectRecord? OldRecord
        // GraphQL -> oldRecord: SalesforceObjectRecord (type)
        if (ec.Includes("oldRecord",false))
        {
            if(this.OldRecord == null) {

                this.OldRecord = new SalesforceObjectRecord();
                this.OldRecord.ApplyExploratoryFieldSpec(ec.NewChild("oldRecord"));

            } else {

                this.OldRecord.ApplyExploratoryFieldSpec(ec.NewChild("oldRecord"));

            }
        }
        else if (this.OldRecord != null && ec.Excludes("oldRecord",false))
        {
            this.OldRecord = null;
        }
    }


    #endregion

    } // class ObjectRecordChange
    
    #endregion

    public static class ListObjectRecordChangeExtensions
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
            this List<ObjectRecordChange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectRecordChange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectRecordChange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectRecordChange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectRecordChange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
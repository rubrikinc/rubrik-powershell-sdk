// ActivityAuditorPrimaryTargetEntity.cs
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
    #region ActivityAuditorPrimaryTargetEntity
    public class ActivityAuditorPrimaryTargetEntity: BaseType
    {
        #region members

        //      C# -> List<ActivityAuditorAttributeChange>? Changes
        // GraphQL -> changes: [ActivityAuditorAttributeChange!]! (type)
        [JsonProperty("changes")]
        public List<ActivityAuditorAttributeChange>? Changes { get; set; }

        //      C# -> ActivityAuditorEntity? Entity
        // GraphQL -> entity: ActivityAuditorEntity (type)
        [JsonProperty("entity")]
        public ActivityAuditorEntity? Entity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivityAuditorPrimaryTargetEntity";
    }

    public ActivityAuditorPrimaryTargetEntity Set(
        List<ActivityAuditorAttributeChange>? Changes = null,
        ActivityAuditorEntity? Entity = null
    ) 
    {
        if ( Changes != null ) {
            this.Changes = Changes;
        }
        if ( Entity != null ) {
            this.Entity = Entity;
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
        //      C# -> List<ActivityAuditorAttributeChange>? Changes
        // GraphQL -> changes: [ActivityAuditorAttributeChange!]! (type)
        if (this.Changes != null) {
            var fspec = this.Changes.AsFieldSpec(conf.Child("changes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "changes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivityAuditorEntity? Entity
        // GraphQL -> entity: ActivityAuditorEntity (type)
        if (this.Entity != null) {
            var fspec = this.Entity.AsFieldSpec(conf.Child("entity"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entity" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ActivityAuditorAttributeChange>? Changes
        // GraphQL -> changes: [ActivityAuditorAttributeChange!]! (type)
        if (ec.Includes("changes",false))
        {
            if(this.Changes == null) {

                this.Changes = new List<ActivityAuditorAttributeChange>();
                this.Changes.ApplyExploratoryFieldSpec(ec.NewChild("changes"));

            } else {

                this.Changes.ApplyExploratoryFieldSpec(ec.NewChild("changes"));

            }
        }
        else if (this.Changes != null && ec.Excludes("changes",false))
        {
            this.Changes = null;
        }
        //      C# -> ActivityAuditorEntity? Entity
        // GraphQL -> entity: ActivityAuditorEntity (type)
        if (ec.Includes("entity",false))
        {
            if(this.Entity == null) {

                this.Entity = new ActivityAuditorEntity();
                this.Entity.ApplyExploratoryFieldSpec(ec.NewChild("entity"));

            } else {

                this.Entity.ApplyExploratoryFieldSpec(ec.NewChild("entity"));

            }
        }
        else if (this.Entity != null && ec.Excludes("entity",false))
        {
            this.Entity = null;
        }
    }


    #endregion

    } // class ActivityAuditorPrimaryTargetEntity
    
    #endregion

    public static class ListActivityAuditorPrimaryTargetEntityExtensions
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
            this List<ActivityAuditorPrimaryTargetEntity> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivityAuditorPrimaryTargetEntity> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivityAuditorPrimaryTargetEntity> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityAuditorPrimaryTargetEntity());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivityAuditorPrimaryTargetEntity> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
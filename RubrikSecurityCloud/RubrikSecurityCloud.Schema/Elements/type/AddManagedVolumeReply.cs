// AddManagedVolumeReply.cs
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
    #region AddManagedVolumeReply
    public class AddManagedVolumeReply: BaseType
    {
        #region members

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
        // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
        [JsonProperty("managedVolumeSummary")]
        public UpdateManagedVolumeReply? ManagedVolumeSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddManagedVolumeReply";
    }

    public AddManagedVolumeReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        UpdateManagedVolumeReply? ManagedVolumeSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( ManagedVolumeSummary != null ) {
            this.ManagedVolumeSummary = ManagedVolumeSummary;
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
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            var fspec = this.AsyncRequestStatus.AsFieldSpec(conf.Child("asyncRequestStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "asyncRequestStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
        // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
        if (this.ManagedVolumeSummary != null) {
            var fspec = this.ManagedVolumeSummary.AsFieldSpec(conf.Child("managedVolumeSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumeSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (ec.Includes("asyncRequestStatus",false))
        {
            if(this.AsyncRequestStatus == null) {

                this.AsyncRequestStatus = new AsyncRequestStatus();
                this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));

            } else {

                this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));

            }
        }
        else if (this.AsyncRequestStatus != null && ec.Excludes("asyncRequestStatus",false))
        {
            this.AsyncRequestStatus = null;
        }
        //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
        // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
        if (ec.Includes("managedVolumeSummary",false))
        {
            if(this.ManagedVolumeSummary == null) {

                this.ManagedVolumeSummary = new UpdateManagedVolumeReply();
                this.ManagedVolumeSummary.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeSummary"));

            } else {

                this.ManagedVolumeSummary.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeSummary"));

            }
        }
        else if (this.ManagedVolumeSummary != null && ec.Excludes("managedVolumeSummary",false))
        {
            this.ManagedVolumeSummary = null;
        }
    }


    #endregion

    } // class AddManagedVolumeReply
    
    #endregion

    public static class ListAddManagedVolumeReplyExtensions
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
            this List<AddManagedVolumeReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AddManagedVolumeReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddManagedVolumeReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddManagedVolumeReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddManagedVolumeReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
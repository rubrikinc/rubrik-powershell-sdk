// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AccountSettingQuery {
      /// <summary>
      /// AccountSettingQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = AccountSettingDocument,
          OperationName = "AccountSetting"
        };
      }

      
      public static string AccountSettingDocument = @"
        query AccountSetting {
          accountSettings {
            ...AccountSettingFragment1
          }
        }
        fragment AccountSettingFragment1 on AccountSetting {
          isEulaAccepted
          isEmailNotificationEnabled
        }";
      
    }
}

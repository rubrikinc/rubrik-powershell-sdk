### ChatbotUserAssignmentInput
Information for creating a new chatbot role and assigning users and groups to the newly created role. If null, a new chatbot role will not be created.

- roleName: System.String
  - Name of the role to create for this chatbot.
- roleDescription: System.String
  - Description of the role to create for this chatbot.
- userIds: list of System.Strings
  - IDs of the users to assign to the chatbot role. If empty, no users will be assigned to the chatbot role.
- userGroupIds: list of System.Strings
  - IDs of the groups to assign to the chatbot role. If empty, no groups will be assigned to the chatbot role.

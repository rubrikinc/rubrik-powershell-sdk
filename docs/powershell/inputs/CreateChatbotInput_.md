### CreateChatbotInput
- name: System.String
  - Name of the chatbot.
- description: System.String
  - Description of the chatbot.
- filters: SourceDataFiltersInput
  - Filters applied to Retrieval Augmented Generation source data for
 this chatbot. If null, then no filtering will be applied.
- userAssignment: ChatbotUserAssignmentInput
  - Information for creating a new chatbot role and assigning users and
 groups to the newly created role. If null, a new chatbot role will
 not be created.
- chatbotSettings: ChatbotSettingsInput
  - Settings of the chatbot.
- embeddingFactorySettings: EmbeddingFactorySettingsInput
  - Settings of the embedding factory.
- objects: list of ChatbotObjectMetadataInputs
  - List of objects that this chatbot can use in Retrieval Augmented Generation. If this list is empty, no objects will be enabled for the chatbot.
- roleIds: list of System.Strings
  - IDs of the existing roles to assign to the chatbot. If empty, the chatbot will not be assigned to any existing roles.

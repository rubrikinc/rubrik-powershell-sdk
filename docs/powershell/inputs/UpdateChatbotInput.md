### UpdateChatbotInput
- name: System.String
  - Name of the chatbot
- description: System.String
  - Description of the chatbot
- filters: SourceDataFiltersInput
  - Filters applied to Retrieval Augmented Generation source data for
 this chatbot. If null, then no filtering will be applied.
- chatbotId: System.String
  - Chatbot FID.
- objects: list of ChatbotObjectMetadataInputs
  - List of objects that this chatbot can use in Retrieval Augmented Generation. If this list is empty, no objects will be enabled for the chatbot.

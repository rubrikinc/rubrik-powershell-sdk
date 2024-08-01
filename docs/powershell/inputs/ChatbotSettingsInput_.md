### ChatbotSettingsInput
ChatbotSettings contains settings for a chatbot.

- enableDocLevelAccessControl: System.Boolean
  - Determines whether to enable document-level access control.
- systemMessage: System.String
  - The system message for the chatbot. This message informs the chatbot how to
 interpret the conversation.
- numChunksToRetrieve: System.Int32
  - The number of chunks returned by search. Defaults to 4 if not specified.

### Chatbot
Representation of chatbot.

- name: System.String
  - Name of the chatbot.
- description: System.String
  - Description of the chatbot.
- embeddingFactoryId: System.Int64
  - ID of the embedding factory used by the chatbot.
- stats: ChatbotStats
  - Optional stats about the chatbot.
- objects: list of ChatbotObjectMetadatas
  - Optional list of objects this chatbot can use in Retrieval Augmented
 Generation.
- filters: EmbeddingFactoryFilters
  - Optional filters applied to Retrieval Augmented Generation source data for
 this chatbot.
- id: System.String
  - The ID of the chatbot.

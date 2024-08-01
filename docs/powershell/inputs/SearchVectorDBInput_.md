### SearchVectorDBInput
Input to search a chatbot's VectorDB. Requires a chatbotId and the query to search the VectorDB.

- chatbotId: System.String
  - Chatbot FID.
- query: System.String
  - Query to search the VectorDB.
- topK: System.Int32
  - The number of chunks returned by the search. Defaults to 4 if not specified.

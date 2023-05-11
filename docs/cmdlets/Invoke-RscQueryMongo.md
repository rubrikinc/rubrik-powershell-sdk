# Invoke-RscQueryMongo
## Subcommands
### Collection
Provides details for a MongoDB collection identified by the fid.

- The Input parameter takes a single value of type System.String.
- Returns MongoCollection.
### Database
Provides details for a MongoDB database identified by the fid.

- The Input parameter takes a single value of type System.String.
- Returns MongoDatabase.
### RecoverableRange
Provides the range for recovery of MongoDB objects.

- The Input parameter takes a single value of type RecoverableRangeInput.
- Returns MongoRecoverableRanges.
### Source
Provides details for the MongoDB source cluster identified by the fid.

- The Input parameter takes a single value of type System.String.
- Returns MongoSource.
### dbBulkRecoverableRange
Recoverable range for multiple Management Objects on NoSQL cluster.

- The Input parameter takes a single value of type MosaicBulkRecoveryRangeInput.
- Returns MosaicRecoveryRangeResponse.
### dbCollection
MongoDB collection identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections

- The Input parameter takes a single value of type System.String.
- Returns MongodbCollection.
### dbCollectionRecoverableRange
Recoverable Range of a MongoDB collection on NoSQL cluster.

- The Input parameter takes a single value of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### dbDatabase
MongoDB database identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
A database stores one or more collections of documents. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections/

- The Input parameter takes a single value of type System.String.
- Returns MongodbDatabase.
### dbSource
MongoDB source cluster identified by FID on NoSQL cluster. 
For MongoDB, the term "source" is usually used for either a replica set or a sharded cluster. 
For more info on MongoDB cluster refer to : https://docs.mongodb.com/manual/introduction/

- The Input parameter takes a single value of type System.String.
- Returns MongodbSource.

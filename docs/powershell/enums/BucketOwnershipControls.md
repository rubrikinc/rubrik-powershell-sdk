### BucketOwnershipControls
BucketOwnershipControls describes the rules for AWS S3 bucket ownership.

- UNSPECIFIED - The bucket ownership rules are not specified. Default is BucketOwnerEnfored.
- BUCKET_OWNER_ENFORCED - The ownership is changed to bucket owner. ACLs are not enabled on them.
- BUCKET_OWNER_PREFERRED - The ownership is changed to bucket owner if the objects are uploaded with the bucket-owner-full-control canned ACL.
- OBJECT_WRITER - The uploading account will own the object if the object is uploaded with the bucket-owner-full-control canned ACL.

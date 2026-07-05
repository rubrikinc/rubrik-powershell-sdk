### AWSExoTaskImageBundle
AWS Exocompute images and corresponding information.

- bundleVersion: System.String
  - The current version of the Exocompute image bundle.
- repoUrl: System.String
  - Contains the URL of Rubrik's ECR from where the images can be downloaded.
- bundleImages: list of BundleImages
  - Details of the Exocompute images in the bundle.
- eksVersion: System.String
  - EKS cluster version which helps identify images compatible to the given version.
- supportedEksVersions: list of System.Strings
  - List of EKS versions supported by RSC.

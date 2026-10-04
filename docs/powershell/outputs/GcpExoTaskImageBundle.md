### GcpExoTaskImageBundle
GCP Exocompute images and corresponding information delivered to PCR customers
for mirroring into their own Artifact Registry.

- bundleVersion: System.String
  - The current version of the Exocompute images bundle.
- repoUrl: System.String
  - Contains the URL of Rubrik's central GAR from where the images can be downloaded.
- bundleImages: list of BundleImages
  - Details of the Exocompute images in the bundle.

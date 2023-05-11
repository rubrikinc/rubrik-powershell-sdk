### LicensedClusterProduct
Represents a single licensed product.

- contributions: a list of CapacityContributions
  - The contributions from other products that make up the used capacity of this product. Only valid when product type is Scale.
- nextExpiringBytes: System.Single
  - The amount of bytes under the license with the nearest expiry date.
- nextExpiringTime: DateTime
  - The next expiry date of a license under this product.
- numClusters: System.Int32
  - The number of Rubrik clusters included in this product.
- product: Product
  - The name of the product.
- productTypes: a list of System.Strings
  - The product types under this product that the customer has.
- purchasedCapacityBytes: System.Single
  - The total purchased capacity of this product, in bytes.
- registeredCapacityBytes: System.Single
  - The total registered capacity of this product, in bytes.

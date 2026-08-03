### RubrikProduct
RubrikProduct is the set of Rubrik products a user may register interest
in. Mirrors the MySQL SMALLINT column product_interest_registrations.product
by numeric value. Additive only. Never renumber. Never remove.

- RUBRIK_PRODUCT_UNSPECIFIED - Default zero value; rejected by the handler.
- RUBRIK_PRODUCT_IDENTITY_RESILIENCE - Identity Resilience (Rubrik's identity recovery + resiliency product).

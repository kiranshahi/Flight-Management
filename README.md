# Flight Management System

This is the sample system for small charter airline to manage its flights and customers. This application keeps track of their planes, customer details and flight bookings.

## System Details

### Business rules assumed:

	1. Must not over-book a plane (either with passengers/cargo)
    2. Must not assign cargo to a passenger only plane, or a passenger to a cargo only plane.
    3. Must not assign a plane to more than one booking scheduled at the same time (cant overlap)
    4. A Booking requires a plane and client to be created/saved (planes can be changed after bookings created if needed).


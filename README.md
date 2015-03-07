Grant Manager
=============

A Windows application to keep track of grants, grantors, and related projects.
Created in 2013 by Kelsey Burns, Spencer Grande, Dave Moss, Isaac Schemm, Conor Sherman, and Matt Wisby.
Version 2.0 created in 2015 by Isaac Schemm.

Note
----

One of the database tables is named "changelog". This table stores verbose information about each grant/grantor/etc. that is added/deleted/changed in the database - the old and new values, the date and time, and the logged in user. Administrators can export this changelog to a CSV text file.
When any user (administrator or not) logs in to Grant Manager, the program automatically deletes all changelog entries older than 30 days. To change this time period or disable writing to the changelog entirely, edit the constants in Settings.cs and recompile the software.

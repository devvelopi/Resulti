# Changelog

### V0.1.0

+ Initial version

### V0.1.1

+ Added result builder functionality
+ Added result extension methods
+ Added type to notifications
+ Added notification type utility

### V0.1.2

+ Added quick access customisable 'Success' boolean on results
+ Added missing clone elements for HttpResult
+ **BREAKING:** Moved trace out of notifications to the result

### V0.1.3 - Hotfix
+ Fixed an issue where a databag result when used with `.Failure()` would lead to the status being `SUCCESS`
# C# BaseCode
## _ASI Bridge Program BaseCode_

This is the base code that will be used during the bridge program.
```
```
## Installation
1.  Open the `.sln` file.
    _※Use Visual Studio 2022_
2.  Change connection strings on the `appsettings.json` base on your server
3.  Set `Basecode.WebApp` as the Startup project.
4.  Clean and ReBuild the solution.

## Code Structure

- `Basecode.Data`
    - This project contains the repositories and other logics that involves with database.
    - Make sure that the repository is for db processing only.
    - If it involves additional logic, move the logic into the service file.
- `Basecode.Services`
    - This project contains the services and other processing logics before connecting to the repository.
    - This can also contains classes that can be use by the WebApp project with/without db processing.
- `Basecode.WebApp`
    - This project contains the main codes especially the `Controllers` and `Views`.
    - This is where you put the connection logic to the APIs.
    - Make sure that the controllers are clean and no other logic should involve.
    - If it involves additional logic, move the logic into the service file.
```
```

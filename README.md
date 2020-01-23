# Project
This works as a template for a React Single-Page-App with [Auth0](https://auth0.com/) authentication set up.
Backend is built on top of the **dotnet new webapi** template, version 3.1. Entity framework configuration to local Postgres database.

## Requirements
- [.NET Core 3.1](https://dotnet.microsoft.com/download)
- [Node 10.16 or newer + npm (included with Node)]https://nodejs.org/en/
- [Auth0 account](https://auth0.com/)
- [Postgres database](https://www.postgresql.org/)

## Installation
Download the project and open up a terminal in the root directory
and run dotnet restore

```bash
dotnet restore
```
change directory to the react-app and run npm install
```bash
cd client-app
npm install
```
Configure the appsettings.Development.json database connection string accordingly with your database address, port, DB name, user name and password.
Make sure your database user has permissions.

Next you need to configure the auth_config.json -file in /client-app/src folder.
Set up the auth0 domain and clientId from the Auth0 dashboard after you have logged in and created an app to the service.
## Usage
Start the server from the root directory
```bash
dotnet run
```
Next start the react-app
```bash
cd ./client-app
npm run start
```
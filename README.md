# Parks Lookup API (version 1.0)

#### _Building an API Independent Project for Epicodus_

#### By: **Michelle Morin**, April 3, 2020

## Description

_This API allows a user to create, read, update, and delete state and national parks. All endpoints of the Parks Lookup API have a defualt version 1.0. Requests made to any endpoint without specifying a version number or specifying a nonexistent version number (as a query parameter '?v=1.0' in the path of the request) will default to version 1.0. Request responses to any endpoint contain a respone header named api-supported-versions, which lists all available API versions for that endpont (1.0 is the only version currently supported for each endpoint)._

## Specification user stories:
* A user is able to read (GET) a list of all parks in the database.
* A user is able to filter their search by various query parameters, including: park name, park agency (state, local, national, etc.), state, and whether the park includes campsites.
* A user is able to create (POST) a new park entry in the database.
* A user is able to edit (PUT) an existing park entry in the database. 
* A user is able to delete (DELETE) an existing park entry in the database.
* A user is able to view details for a specific park, based on ParkId.

### All endpoints of the Parks Lookup API use host 'localhost:5000' and base path '/api'
* '/parks'
  - GET request
  - returns a list of all parks from the ``michelle_morin`` database table ``parks``.
  - optionally accepts query parameters of name, agency, state, and campsites to filter the list of results (e.g., '/parks?name=zion&state=utah' returns a list of all parks from the ``michelle_morin`` database table ``parks`` having a name "zion" and a state "utah")
* '/parks'
  - POST request
  - requires a park object (formatted in JSON) in the body of the API request
  - a successful (200 OK) request returns nothing, and instead posts the park object as a new entry in the ``michelle_morin`` database table ``parks``
* '/parks/{id}'
  - GET request
  - requires an id parameter (ParkId of the park object) in the path of the API request
  - a successful request (200 OK) returns a single park object from the ``michelle_morin`` database table ``parks`` based on ParkId
* '/parks/{id}'
  - PUT request
  - requires an id parameter (ParkId of the park object) in the path of the API request; the id parameter must match a ParkId of an existing entry in the ``parks`` table of the ``michelle_morin`` database
  - requires a park object (formatted in JSON) in the body of the API request
  - a successful (200 OK) request returns nothing, and instead updates an existing park entry in the ``parks`` table of the ``michelle_morin`` database
* '/parks/{id}'
  - DELETE request
  - requires an id parameter (ParkId of the park object) in the path of the API request
  - a successful (200 OK) request returns nothing, and instead deletes an existing entry having a ParkId matching the input id parameter from the ``parks`` table of the ``michelle_morin`` database

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Install MySQL and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

_Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/ParksLookup.Solution``
* ``cd ParksLookup.Solution/ParksLookup``

_Confirm that you have navigated to the ParksLookup directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Recreate the ``michelle_morin`` database using the following commands (in Terminal on macOS or PowerShell on Windows) at the root of the ParksLookup directory:_
* ``dotnet restore``
* ``dotnet build``
* ``dotnet ef database update``

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows) at the root of the ParksLookup directory:_
* ``dotnet run`` or ``dotnet watch run``
* With this API running, open the [Swagger UI](http://localhost:5000/swagger/index.html#/) to view and test the different routes of this API!

_To view/edit the source code of this API, open the contents of the ParksLookup.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal at the root of the ParksLookup.Solution directory)._

## Technologies Used

* GitBash
* Git 2.23.0
* C#
* .NET Core 2.2.106
* Entity Framework Core 2.2
* dotnet script 0.50.1
* MySQL
* MySQL Workbench
* Swagger 2.0 documentation (swagger.json)
* NSwag ASP.NET Core middleware
* Nuget Versioning package 2.2.0 (Microsoft.AspNetCore.Mvc.Versioning)

## License

Licensed under the MIT license.

&copy; 2020 - Michelle Morin
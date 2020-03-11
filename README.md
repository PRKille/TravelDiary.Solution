# _Travel Diary_

#### _ASP.NET Core MVC practice for Epicodus_, _Mar. 11, 2020_

#### By _**Geoff Goetz, Michelle Morin**_

## Description

_This project is a website where a user can enter places they've been to create an online travel diary. The webpage includes a form where a user can enter information about a location and also includes a list view to view all locations._ 

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------:| 
| Application creates instance of Place object when user submits form | user enters city name then submits form| new Place object created for that city name |
| Application navigates to page notifying user that new Place was added to travel diary | user submits new place form | webpage displays view notifying user of new place creation |
| Application allows users to view all locations in the travel diary | user clicks link to display all locations | webpage routes to Show() |

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

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository.
* ``cd TravelDiary.Solution``

_Confirm that you have navigated to the TravelDiary.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_To view/edit the source code of this application, open the contents of the TravelDiary.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

_Run this console application by entering the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd TravelDiary`
* ``dotnet run``


_Test this console application by entering the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd TravelDiary.Tests``
* ``dotnet restore``
* ``dotnet test``

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Geoff Goetz, Michelle Morin_**
# _Barber Shop_

#### By _**Tim Empey**_

#### _Eau Calvin's Barber Shop Website_

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _MySQL_
* _Entity_

## Description

_Website designed with the employees in mind to track current and past stylists, and clients. More specifically, what clients were under a specific stylist, stylist hiring date, client normal haircut, times visited, last visit, and name._

## Setup/Installation Requirements

* _Open up your terminal and navigate to the desired landing folder_
* _In terminal enter, ' "git clone https://github.com/TimEmpey/HairSalon '_
* _In terminal enter 'code .' to open files in Visual Studio Code_
* _In VS Code terminal navigate to the HairSalon directory (file path ex. user/desktop/epicodus/projects/HairSalon/HairSalon)_
* _Configure files with '$ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0' & '$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2'_
* _Run '$ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0' to install Lazy Loading_
* _Run '$ dotnet restore'_
* _Create file names 'appsettings.json'_
* _Enter the following into the file_
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=tim_empey;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* _To setup the database you open up MySQL and under 'Administration' select 'Data Import'_
* _Check the 'Import from self contained file' option and enter the file path of the Database within HairSalon, then start Import_
* _Enter '$ dotnet run to start program'_

## Known Bugs

* _Page redirects to broken HTML page when attempting to enter the 'Hiring' page from the 'Appointment' page and vise versa_

## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_

Copyright (c) _2022_ _Timothy Empey_

# _Hair Salon_

#### By: _*Kim Brannian*_

#### _A web application for a salon owner to track clients and stylists._

## Technologies Used
* C#
* .NET
* ASP.NET Core MVC
* Razor
* NuGet
* _git_
* _GitHub_
* Entity Framework Core
* Pomelo
* MySql


## Description
_A website to track stylists and their clients._

## System Requirements
* Download and install [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* Download and install [MySql](https://www.mysql.com/downloads/) and connect to your local server
* A text editor, such as [VS Code](https://code.visualstudio.com/)


## Setup/Installation Requirements
* Navigate to https://github.com/kimberkay/HairSalon.Solution
* Click on the green "Code" button and copy the repository URL or click on the copy button
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/kimberkay/ HairSalon.Solution.git`
* After cloning the project, navigate into it using the command `cd HairSalon.Solution
* Create a .gitignore file in the root directory and add: 
  
  */obj/
  */bin/
  */appsettings.json

* Create an appsettings.json file in the root directory and add:

  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=first_last;uid=root;pwd=[your-mysql-password];"
    }
  }

* Run the command `git init`
* Run the command `git add .gitignore`
* Run the command `cd HairSalon` to navigate the `HairSalon.Solutions\HairSalon` main       project folder  
* Run the command `dotnet restore` to install project dependencies
* Run the command `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
* Run the command `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
* Run the command `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
* Run the command `dotnet run` to run the project in the browser

## Known Bugs
* _New order and new vendor forms do not have all entries available yet._

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Kim Brannian_

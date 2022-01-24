# _SnackBar_

#### By **Zach Wilson**

#### _A C# application that uses a many-to-many database to help Pierre the Baker manage his new confection stand_

## Technologies Used

* HTML
* C#
* .NET
* Entity
* Sql

## Description

_A webpage built under request of Pierre the Baker. France's #1 imaginary baker. This application helps Pierre manage the entirety of his dessert menu by keeping track of all his available treats, as well as all of his available flavors and the treat/flavor combinations he's currently selling. Also sports user authentication so that nobody without a registered account can edit the webpage's information. Uses the Entity Framework and Sql to build databases that store information regarding treats and flavos and uses Identity for account authorization._

## Setup/Installation Requirements

* Clone this repository to your Desktop
* Open 'SnackBar' in your code editor
* Use your terminal to navigate to 'SnackBar.Solution/SnackBar' and create a file called 'appsettings.json'
* Fill your appsettings.json file with the code below:

{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=SnackBar;uid=root;pwd=[YOUR PASSWORD];"
}
}

* Download MySQL and MySQL Workbench to set up a local database
* Once installed, open MySQL Workbench and open a local server

* Navigate to the project folder in VS code and access your terminal. Type 'dotnet ef database update' to create your database on MySQL

* Run 'dotnet restore' in your terminal to install bin & obj folders.

* Use your terminal to navigate back to 'Factory.Solution/Factory' and run 'dotnet run' to activate application.
* Create an account at the main menu in order to access the site's full functionality. Register first, and then log in as your new account.
* Use the user interface provided by the webpage to manage your treats and flavors.

## Known Bugs

Currently no known bugs.

## License

MIT License

Copyright (c) [2021] [Zachary Wilson]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

### Feel free to fix/edit all contained code to your liking. If you encounter and problems, contact me at zwilson22495@gmail.com
# __Currency Exchanger__

#### __An application which a user can use to manage bread and pastry orders across vendors. October 2, 2020__

#### By _**Emme Buentiempo**_

## Description

This application was created as an Epicodus assignment, with the intent to have it serve as a demonstration of knowledge after the program's ninth week. For the time being this README will serve as a checklist to demonstrate the satisfaction of all project requirements and objectives. 

## Project requirements:

Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors.

For example, Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships.

Use Razor to display information on each page.

Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".

## Project Objectives:

  * A splash page is used. [Incomplete]
  * Project has Vendor and Order classes. [Incomplete]
  * Project uses two or more controllers. [Incomplete]
  * Models are thoroughly tested. [Incomplete]
  * GET and POST requests/responses are used successfully. [Incomplete]
  * MVC routes follow RESTful conventions. [Incomplete]
  * Code and documentation follow best practices (descriptive variables names, proper indentation and spacing, separation between user-interface and business logic, detailed commit messages in the correct tense, and a well-formatted README with installation instructions). [Incomplete]
  * Project is in a polished, portfolio-quality state. [Incomplete]
  * Required functionality was present at Friday deadline. [Incomplete]
  * Project demonstrates understanding of this week's concepts. If prompted, you can discuss your code with an instructor using the correct terminology. [Incomplete]

## Specs

  1.[x] Orders can be created, with the properties of OrderTitle, OrderDescription, OrderPrice, OrderDate, and ID.
    * Input:
    * Output:

  2.[x] Vendors can be created, with the properties of VendorName, VendorDescription, a list of Orders, and ID.
    * Input:
    * Output:

  3.[x] The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
    * Input:
    * Output:

  4.[x] The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
    * Input:
    * Output:

  5.[x] Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
    * Input:
    * Output:

  6.[x] Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor.
    * Input:
    * Output:

## Setup/Installation Requirements

* _open terminal_
* _type "cd desktop", then press enter_
* _type "git clone https://github.com/3emme/OrderTrack", then press enter_
* _locate and open directory on desktop named "OrderTrack" with your console of choice_
* _in console, locate and move to the directory inside called OrderTrack_
* _in console, run $dotnet restore_
* _in console, run $dotnet run_


## Support and contact details

_Please do not hesitate to contact me at emmettbuentiempo@gmail.com should you have any questions regarding this project_

## Technologies Used

* _C#_

### License

Copyright (c) 2020 **_Emme Buentiempo_**
This software is licensed under the MIT license.
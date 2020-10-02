# __Currency Exchanger__

#### __An application which a user can use to determine the to determine the cost of buying bread and pastries. September 25, 2020__

#### By _**Emme Buentiempo**_

## Description

This application was created as an Epicodus assignment, with the intent to have it serve as a demonstration of knowledge after the program's eighth week. For the time being this README will serve as a checklist to demonstrate the satisfaction of all project requirements and objectives. 

## Project requirements:

Create a C# console application for a bakery that includes the following functionality:

There should be two classes: one for Bread and one for Pastry.

When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

The application will return the total cost of the order.

Pierre offers the following deals:

Bread: Buy 2, get 1 free. A single loaf costs $5.
Pastry: Buy 1 for \$2 or 3 for $5.
All functionality for the models should be tested.

## Project Objectives:

  * Code includes two custom classes and uses namespaces. **[Complete]**
  * Console application works correctly. **[Complete]**
  * Application correctly uses auto-implemented properties. **[Incomplete]**
  * Classes should include methods for determining the price of an order. **[Complete]**
  * Models are thoroughly tested. **[Complete]**
  * Previous objectives have been met. **[Complete]**
  * Required functionality is in place by the 5:00pm Friday deadline. **[Complete]**
  * Project is in a polished, portfolio-quality state. **[Complete]**
  * Project demonstrates understanding of this week's concepts. If prompted, you can discuss your code with an instructor using the correct terminology. **[Complete]**

## Business Specs

  1.[X] Given a number, the BreadCost method will return the number of breads given and calculate the total cost of bread assuming the cost is a $5 for 1.
    * Input: 1
    * Output: {1,5}

  2.[X] Given a number, the BreadCost method will return the number of breads given and the total cost assuming the cost is a single piece is $5 for 1, but that buying 2 will give you a third for free.
    * Input: 2
    * Output: {3,10}

  3.[X] Given a number, the PastryCost method will return the number of pastries given and calculate the total cost of pastries assuming the cost is a $2 for 1.
    * Input: 1
    * Output: {1,2}

  4.[X] Given a number, the PastryCost method will return the number of pastries given and the total cost assuming the cost is a single piece is $2 for 1, but that buying 3 costs 5.
    * Input: 3
    * Output: {3,5}

  5.[X] Given two numbers, one for a bread order and the other for a pastry order, the RingUp method will return the total number of bread and patries received in addition to their total cost together.
    * Input: {2,3}
    * Output: {3,3,15}

## Setup/Installation Requirements

* _open terminal_
* _type "cd desktop", then press enter_
* _type "git clone https://github.com/3emme/Bakery", then press enter_
* _locate and open directory on desktop named "Bakery" with your console of choice_
* _in console, locate and move to the directory inside called Bakery_
* _in console, run $dotnet restore_
* _in console, run $dotnet run_


## Support and contact details

_Please do not hesitate to contact me at emmettbuentiempo@gmail.com should you have any questions regarding this project_

## Technologies Used

* _C#_

### License

Copyright (c) 2020 **_Emme Buentiempo_**
This software is licensed under the MIT license.
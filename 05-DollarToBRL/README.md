# Dollar to BRL Converter Using Class (C#)

This project is a C# console application that calculates how many Brazilian reais (BRL) are required to buy a given amount of US dollars (USD), including the 6% IOF tax.

The application uses a dedicated class to encapsulate the currency conversion logic, applying Object-Oriented Programming (OOP) principles to keep the code organized, readable, and reusable.

## Features

- Uses a custom `ConversorDeMoeda` class  
- Applies a fixed IOF tax of 6%  
- Performs currency conversion using `decimal` precision  
- Reads user input using `CultureInfo.InvariantCulture`  
- Calculates the total amount in BRL including IOF  
- Displays the formatted final value to the user  

---

## Concepts Practiced

- Object-Oriented Programming (OOP)  
- Classes and static methods  
- Encapsulation of business logic  
- Financial calculations using `decimal`  
- `CultureInfo` for numeric input/output  
- Console input and output  
- Mathematical formulas  

---

## Program.cs

- Handles user input and output  
- Reads the exchange rate (USD to BRL)  
- Reads the desired amount in dollars  
- Calls the conversion method from `ConversorDeMoeda`  
- Displays the final amount in reais including IOF  

---

## ConversorDeMoeda.cs

- Defines the `ConversorDeMoeda` class  
- Contains a static IOF value (`0.06`)  
- Contains the `Conversion` method  
- Performs the currency conversion calculation including tax  

---

## How It Works

1. The user enters the current dollar-to-real exchange rate.  
2. The user enters the amount of dollars they want to buy.  
3. The program calculates the base value in reais.  
4. The IOF tax is applied to the total operation.  
5. The final amount in reais is displayed with two decimal places. 

# Patient Record Filter (C#)

## Description
This C# console application reads patient records from a text file and displays patients whose account balance meets or exceeds a user-entered minimum balance.

## Features
- Reads patient data from `Patients.txt`
- Parses comma-separated records
- Prompts the user for a minimum balance
- Filters records based on balance
- Displays matching patient IDs, names, and balances in a formatted table
- Shows a message when no matching records are found

## Technologies Used
- C#
- .NET
- File I/O
- String parsing
- Console application formatting

## Input File Format
The program expects a text file named `Patients.txt` with records in this format:

222,Anderson,2000  
390,Bell,2500  
488,Carter,1000  

Each record contains:
- Patient ID
- Patient name
- Account balance

## What I Learned
- Reading data from files using `FileStream` and `StreamReader`
- Splitting and parsing comma-separated values
- Converting strings into numeric data types
- Filtering records based on user input
- Formatting console output for readability

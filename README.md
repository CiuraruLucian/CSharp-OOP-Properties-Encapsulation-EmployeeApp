# C# OOP Encapsulation Using Properties – Employee Application

## 📌 Overview

This project is a **C# console application** created to demonstrate modern **Object-Oriented Programming (OOP)** practices, focusing on **encapsulation using C# properties** instead of traditional accessor and mutator methods.

The application models an `Employee` object whose internal state is protected and accessed safely through properties and constructor chaining.

---

## 🎯 Concepts Demonstrated

* Encapsulation in C#
* Properties (`get` / `set`)
* Property validation logic
* Constructor chaining
* Object state management
* Method-based behavior modification
* Clean class design principles

---

## 🧱 Project Structure

```
EmployeeApp.NetProperties/
│
├── Program.cs     → Application entry point
└── Employee.cs    → Employee class implementation
```

---

## ⚙️ Employee Class Features

### Private Fields

The internal data is hidden from direct access:

* Employee Name
* Employee ID
* Current Pay
* Employee Age

---

### Properties (Encapsulation)

Instead of traditional getters and setters:

```csharp
public string Name
{
    get { return empName; }
    set
    {
        if (value.Length > 15)
            Console.WriteLine("Error! Name length exceeds 15 characters");
        else
            empName = value;
    }
}
```

Properties allow safer and cleaner interaction with object data.

---

### Constructor Chaining

```csharp
public Employee(string name, int id, float pay)
    : this(name, id, pay, 0)
{ }
```

This removes duplicated initialization logic and provides default values automatically.

---

## ▶️ Example Usage

```csharp
Employee emp = new Employee("Lucian", 100, 42000);
emp.GiveBonus(1000);
emp.DisplayStats();
```

Incrementing age using properties:

```csharp
joe.Age++;
```

Compared to traditional methods:

```csharp
joe.SetAge(joe.GetAge() + 1);
```

---

## 💻 Technologies Used

* C#
* .NET Console Application
* Object-Oriented Programming (OOP)

---

## 🧠 Key Learning Outcome

Properties integrate naturally with C# syntax and operators, making objects easier to use while maintaining strict control over internal data.

---

## 🚀 Possible Improvements

* Auto-implemented properties
* Exception handling instead of console validation
* Inheritance (Manager / Developer subclasses)
* Collection of employees
* Menu-driven console interface

---

## 👤 Author

Lucian Ciuraru

---

⭐ Part of my C# and software engineering learning journey.

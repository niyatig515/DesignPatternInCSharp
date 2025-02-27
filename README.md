## Design Patterns Implementation

## Overview

This project includes the implementation of three essential design patterns to enhance code maintainability, scalability, and flexibility. Each pattern solves a specific problem and follows industry best practices.

## Tasks

## 1. Factory Design Pattern

The Notification System is implemented using the Factory Pattern to support multiple notification types such as Email, SMS, and Push Notification. This design allows new notification types to be added easily without modifying existing code. The system dynamically creates notification instances based on user preferences.

## 2. Builder Design Pattern

The Fluent Builder is used for generating SQL queries dynamically. Instead of concatenating query strings manually, the Builder Pattern structures query generation in a step-by-step manner, ensuring better readability and maintainability. The system enables users to build complex queries fluently by chaining method calls.

## 3 Observer Design Pattern

The Stock Price Alert System follows the Observer Pattern, where multiple investors subscribe to receive automatic updates when a stock price changes. This ensures that all subscribers are notified in real-time without requiring direct dependencies between the stock and investors, making the system more flexible and scalable.

## Technologies Used

C# (.NET Framework/.NET Core) with Factory, Builder, and Observer design patterns.

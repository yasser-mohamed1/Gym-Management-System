# Gym Management System

## Overview

The Gym Management System is a comprehensive application built with **ASP.NET Core** that allows gym administrators to manage gym profiles, subscriptions, and users. The system follows **Clean Architecture** principles to ensure maintainable and scalable code. The implementation uses **CQRS** for separating read and write operations, and the **Mediator pattern** for decoupling communication between different layers of the system.

## Features

- **Gym Management**: Admins can create, update, and manage gym profiles, including details and settings.
- **Subscription Management**: Users can subscribe to gym plans with flexible billing options, automated renewals, and notifications.
- **CQRS Implementation**: Separated read and write operations for improved performance and clarity.
- **Mediator Pattern**: Centralized request handling for reduced dependencies and improved maintainability.

## Design & Architecture

- **Clean Architecture**: Ensures clear separation of concerns between the UI, business logic, and data access layers.
- **CQRS**: Optimizes performance by dividing the system into distinct commands (write operations) and queries (read operations).
- **Mediator Pattern**: Promotes decoupled communication between various components and layers, centralizing request processing.
# Flavour Junction Restaurant App

## Introduction:
The Flavour Junction Restaurant App is a Blazor Maui application designed to provide a user-friendly interface for customers to place their food orders. 
The app allows customers to browse through the restaurant's menu, select items, and place their orders with ease. 
Customer's can see the location, contact us information and working hours of restaurant on the landing page.
It's a take-away customer service restaurant that provides a unique 4 digit order id when a customer places order and get order confirmation message along with order details.

### Technologies Used:
- Abstract Classes/ Classes/ Interfaces
- Blazor Maui
- MAUI GUI
- Exceptions

## Functionality:
The core functionality of the Flavour Junction Restaurant App includes:
- Displaying the restaurant's menu items categorically (Breakfast, Lunch, Dinner, Drinks, Dessert).
- Allowing customers to select multiple items from the menu.
- Calculating the total cost of the order.
- Validating customer input.
- Handling exceptions to provide a smooth user experience.

## Classes and Inheritance:
The project includes the following classes:
- `IMenuItem`: An interface defining the properties of a menu item.
- `MenuItemBase`: An abstract class implementing the `IMenuItem` interface and providing base properties for menu items.
- `MenuItem`: A concrete class inheriting from `MenuItemBase` and representing a menu item.

Inheritance is used to create a hierarchy of classes where `MenuItem` inherits properties from `MenuItemBase`.

## MAUI GUI:
The MAUI GUI is used to create the project's user interface, providing a visually appealing and user-friendly experience for customers.

## Exceptions:
Exceptions are handled to ensure a smooth user experience. The project includes a custom `InvalidInputException` class, which is thrown when invalid user input is detected. 
It throws exception when customer inserts special symbols and numbers in customer name field.
Exceptions are caught and appropriate error messages are displayed to the user.

## Conclusion:
The Flavour Junction Restaurant App provides a seamless experience for customers to place their food orders. With its user-friendly interface and robust functionality, 
the app aims to enhance the restaurant's take-away service and improve customer satisfaction.

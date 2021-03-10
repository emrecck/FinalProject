using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Bussiness.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime = "Time to Maintenance,sorry";
        public static string ProductsListed = "Products are listed";
        public static string ProductsListedByCategory = "Products are listed by category";
        public static string ProductById = "Product taked by Id";
        public static string ProductsListedByUnitPrice = "Products are listed by unit price";
        public static string ProductDetailsListed = "Product details are listed";
        public static string ProductCategoryLimitExceded= "Category limit is exceded ! So, you cannot add this product";
        public static string ProductWithThisNameAlreadyExist = "Product with this name already exist";
        public static string CategoryLimitExceded = "There must be 15 Category ! Sorry, you cannot add this product.";
        public static string AuthorizationDenied = "You have not authorization";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error !";
        public static string SuccessfulLogin = "Logged successfully";
        public static string UserAlreadyExists = "User already exist";
        public static string AccessTokenCreated = "Access Token Created";
        public static string CategoryDeleted = "Category deleted succesfully";
    }
}

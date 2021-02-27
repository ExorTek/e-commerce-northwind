using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "The system is under maintenance";
        public static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "There can be a maximum of 10 products in a category";
        public static string ProductNameAlreadyExists = "There is already another product with this name";
        public static string CategoryLimitExceded = "Cannot add new products because the category limit is exceeded";
        public static string AuthorizationDenied = "Authorization denied";
        public static string UserRegistered = "User register";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Wrong password";
        public static string SuccessfulLogin = "Login successful";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access token created";
    }
}

namespace WebStore.Common
{
    public static class EntityValidationConstants
    {
        public static class Category
        {
            public const int NameMinLength = 0;
            public const int NameMaxLength = 25;
        }

        public static class SubCategory
        {
            public const int NameMinLength = 0;
            public const int NameMaxLength = 25;
        }

        public static class IndividualProduct
        {
            public const int NameMinLength = 0;
            public const int NameMaxLength = 30;

            public const int DescriptionMinLength = 0;
            public const int DescriptionMaxLength = 300;
        }

        public static class User
        {
            public const int UsernameMinLength = 3;
            public const int UsernameMaxLength = 25;

            public const int PasswordMinLength = 4;
            public const int PasswordMaxLength = 35;
        }
    }
}
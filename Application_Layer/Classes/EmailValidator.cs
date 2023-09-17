namespace Application_Layer.Classes
{
    public class EmailValidator
    {
        public static bool ValidateEmail(string email)
        {
            // Por simplicidad, asumiremos que cualquier dirección que contenga un "@" es válida.
            if (email != null)
            {
                return email.Contains("@") ? true : throw new ArgumentException("Email must contain @!");
            }

            throw new ArgumentException("Factorial is not define to negative numbers.");
        }
    }
}

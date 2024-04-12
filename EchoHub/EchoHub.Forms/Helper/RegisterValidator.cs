namespace EchoHub.Forms.Helper
{
    public static class RegisterValidator
    {

        public static int MinimumLength = 8;

        private static bool IsPasswordValid(string? Password)
        {

            if (Password != null
                &&
                Password.Replace(" ", "").Length >= MinimumLength
                &&
                !Password.Contains(" "))
            { return true; }
            return false;

        }

        private static bool IsPasswordEquals(string? Password, string? Repeat)
        {
            if (Password != null && Repeat != null)
            {
                if (Password.Equals(Repeat)) return true;
            }
            return false;

        }

        public static bool ValidatePassword(string? Password, string? Repeat)
        {

            if(IsPasswordValid(Password) &&
               IsPasswordValid(Repeat) &&
               IsPasswordEquals(Password, Repeat)
               ) 
            { return true; }
            return false;

        }

        public static bool ValidateEmail(string? Email)
        {

            if(Email != null &&
               Email.Replace(" ","").Length >= MinimumLength &&
               !Email.Contains(" ") &&
               Email.Contains("@")
                ) 
            { return true; }
            return false;

        }

    }

}

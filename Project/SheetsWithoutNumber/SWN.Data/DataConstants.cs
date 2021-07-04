namespace SWN.Data
{
    public class DataConstants
    {
        public const int UsernameMaxLength = 30;
        public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";


        public const int GameNameMaxLength = 50;
        public const int GameDescriptionMaxLength = 200;
    }
}

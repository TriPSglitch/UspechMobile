namespace UspechMobile.Models
{
    interface IRegistrationModel
    {
        string Lastname { get; set; }
        string Firstname { get; set; }
        string Middlename { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Login { get; set; }
        void Registration();
        void Back();
    }
}
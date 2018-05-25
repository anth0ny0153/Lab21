using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class UserInfo
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string password;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName; 
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public UserInfo()
        {

        }
        public UserInfo(string firstName, string lastName, string email, string phoneNumber, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }
    }
}
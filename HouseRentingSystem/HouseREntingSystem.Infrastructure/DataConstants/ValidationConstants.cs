﻿namespace HouseRentingSystem.Infrastructure.DataConstants
{
    public class ValidationConstants
    {
        public const int CategoryNameMaxLength = 50;

        public const int HouseTitleMinLength = 10;
        public const int HouseTitleMaxLength = 50;

        public const int HouseAddressMinLength = 30;
        public const int HouseAddressMaxLength = 150;
        
        public const int HouseDescriptionMinLength = 50;
        public const int HouseDescriptionMaxLength = 500;

        public const int AgentPhoneNumberMinLength = 7;
        public const int AgentPhoneNumberMaxLength = 15;

        public const string MinPricePerMonth = "0";
        public const string MaxPricePerMonth = "2000";
        public const string PriceErrorMessage = "Price per month must be a positive number and less than {2} leva";
    }
}

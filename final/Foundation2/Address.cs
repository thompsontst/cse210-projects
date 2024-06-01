using System;
using System.Collections.Generic;

namespace CustomerManagement
{
     public class Address
   
    {
        private string _Street;
        private string _City;
        private string _State;
        private string _Country;

        
        public Address (string city, string country, string street, string state)
        {
            _City = city;
            _Country = country;
            _State = state;
            _Street = street;
        }
        public string GetCity ()
        {
            return _City;
        }
        
        public void SetCity (string City)
        {
            _City = City;
        }
        public string GetState ()
        {
            return _State;
        }
        
        public void SetState (string State)
        {
            _State = State;
        }
         public string GetStreet ()
        {
            return _Street;
        }
        
        public void SetStreet (string Street)
        {
            _Street = Street;
        }
        public string GetCountry ()
        {
            return _Country;
        }
         public void SetCountry (string Country)
        {
            _Country = Country;
        }
        public bool IsCustomerInUSA()
        {
            return _Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public string CustomerFullAddress()
        {
            return $"{_Street}\n{_City}, {_State}\n{_Country}";
        }
    }
}
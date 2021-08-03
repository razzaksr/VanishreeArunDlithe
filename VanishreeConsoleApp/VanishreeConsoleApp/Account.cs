using System;
using System.Collections.Generic;
using System.Text;

namespace VanishreeConsoleApp
{
    class Account
    {
        String username;
        Int64 contact;
        String email;
        String address;
        Item[] kart;
        Item[] orders;

        //setters; getters
        public void setUsername(String username)
        {
            this.username = username;
        }
        public String getUsername()
        {
            return username;
        }

        public void setContact(Int64 contact)
        {
            this.contact = contact;
        }

        public Int64 getConnect()
        {
            return contact;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }
        public String getAddress()
        {
            return address;
        }

        public void setKart(Item[] kart)
        {
            this.kart = kart;
        }
        public Item[] getKart()
        {
            return kart;
        }
        public void setOrders(Item[] orders)
        {
            this.orders = orders;
        }
        public Item[] getOrders()
        {
            return orders;
        }
    }
}

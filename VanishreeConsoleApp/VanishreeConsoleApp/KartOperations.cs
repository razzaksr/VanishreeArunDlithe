using System;
using System.Collections.Generic;
using System.Text;

namespace VanishreeConsoleApp
{
    interface KartOperations
    {
        public void createNewAccount(Account account);
        public void removeAccount(Account account);
        public void removeAccount(String name);
        public void updateProfile(Account account);
        public void listAllAccounts();
        public void listItems();
        public String placeOrder(Account account,Item item);
        public String addToKart(Account account,Item item);
        public void newItems(Item item);
        public void listKart(Account account);
        public void listOrders(Account account);
    }
}

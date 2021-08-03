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
        public List<Account> listAllAccounts();
        public List<Item> listItems();
        public String placeOrder(Item item);
        public String addToKart(Item item);
    }
}

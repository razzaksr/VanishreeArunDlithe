using System;
using System.Collections.Generic;
using System.Text;

namespace VanishreeConsoleApp
{
    class Controller:KartOperations
    {
        Account[] accounts = new Account[10];// data access logic
        Item[] items = new Item[20];

        public string addToKart(Account account,Item item)
        {
            for(int index=0;index<account.getKart().Length;index++)
            {
                if(account.getKart()[index]==null)
                {
                    account.getKart()[index] = item;
                    return item.getName()+" has added to the "+ account.getUsername()+"'s kart";
                }
            }
            return item.getName() + " has not added";
        }

        public void createNewAccount(Account account)
        {
            for(int index=0;index<accounts.Length;index++)
            {
                if(accounts[index]==null)
                {
                    accounts[index] = account;
                    Console.WriteLine("Profile created");
                    break;
                }
            }
        }

        public void listAllAccounts()
        {
            foreach(Account acc in accounts)
            {
                if(acc!=null)
                {
                    Console.WriteLine(acc);
                    listKart(acc);
                    listOrders(acc);
                }
            } 
        }

        public void listItems()
        {
            foreach(Item it in items)
            {
                Console.WriteLine(it);
            }
        }

        public void listKart(Account account)
        {
            Console.WriteLine("Listing kart items of "+account.getUsername());
            foreach(Item it in account.getKart())
            {
                Console.WriteLine(it);
            }
        }

        public void listOrders(Account account)
        {
            Console.WriteLine("Listing order items of " + account.getUsername());
            foreach (Item it in account.getOrders())
            {
                Console.WriteLine(it);
            }
        }

        public void newItems(Item item)
        {
            for(int index=0;index<items.Length;index++)
            {
                if(items[index]==null)
                {
                    items[index] = item;
                    Console.WriteLine("Item has added to site");
                    break;
                }
            }
        }

        public string placeOrder(Account account,Item item)
        {
            for (int index = 0; index < account.getOrders().Length; index++)
            {
                if (account.getOrders()[index] == null)
                {
                    account.getOrders()[index] = item;
                    return item.getName() + " has placed by the " + account.getUsername() ;
                }
            }
            return item.getName() + " has not placed";
        }

        public void removeAccount(Account account)
        {
            for(int index=0;index<accounts.Length;index++)
            {
                if(accounts[index]!=null&&accounts[index].getConnect()==account.getConnect())
                {
                    accounts[index] = null;
                    Console.WriteLine(account.getUsername()+" has deleted from profiles");
                    break;
                }
            }
        }

        public void removeAccount(string name)
        {
            for (int index = 0; index < accounts.Length; index++)
            {
                if (accounts[index] != null && accounts[index].getUsername().Equals(name))
                {
                    accounts[index] = null;
                    Console.WriteLine(name + " has deleted from profiles");
                    break;
                }
            }
        }

        public void updateProfile(Account account)
        {
            for (int index = 0; index < accounts.Length; index++)
            {
                if (accounts[index].getConnect() == account.getConnect())
                {
                    accounts[index] = account;
                    Console.WriteLine(account.getConnect()+ " has updated");
                    break;
                }
            }
        }
    }
}

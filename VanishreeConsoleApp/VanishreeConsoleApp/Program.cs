using System;

namespace VanishreeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            Item item1 = new Item("32gb pendrive","Sandisk",600);
            Item item2 = new Item("bean bag", "Flipkart Assured", 2700);
            Item item3 = new Item("Wrist3b", "Realme", 1400);
            Item item4 = new Item("huwai123", "Walkaro", 540);
            Item item5 = new Item("6.1Plus", "Nokia", 10600);
            Item item6 = new Item("Note11 Pro", "Redmi", 21600);
            Item item7 = new Item("Pavilion 1563","HP", 42600);
            Item item8 = new Item("ExternalHDD", "Sony", 4600);
            Item item9 = new Item("Kids Bike", "Hero", 9600);
            Item item10 = new Item("OpticalMouse", "LG", 600);

            Account account = new Account();account.setUsername("razakmohamed");
            account.setAddress("Salem");account.setContact(87656789876);
            account.setEmail("razzaksr@gmail.com");

            Account account1 = new Account("sabariragu","Salem",9876545678,"sabariragu@gmail.com");

            controller.createNewAccount(account); controller.createNewAccount(account1);

            controller.newItems(item9); controller.newItems(item8);
            controller.newItems(item7); controller.newItems(item6);
            controller.newItems(item5); controller.newItems(item4);
            controller.newItems(item3); controller.newItems(item2);
            controller.newItems(item1); controller.newItems(item10);


            controller.listItems();

            Console.WriteLine(controller.addToKart(account, item8));
            Console.WriteLine(controller.addToKart(account, item1));
            Console.WriteLine(controller.addToKart(account, item3));
            Console.WriteLine(controller.addToKart(account1, item10));
            Console.WriteLine(controller.addToKart(account1, item4));
            Console.WriteLine(controller.addToKart(account1, item1));
            Console.WriteLine(controller.addToKart(account, item5));
            Console.WriteLine(controller.addToKart(account1, item7));

            controller.listAllAccounts();


            Console.WriteLine(controller.placeOrder(account1, item3));
            Console.WriteLine(controller.placeOrder(account1, item10));
            Console.WriteLine(controller.placeOrder(account1, item4));

            Console.WriteLine(controller.placeOrder(account, item2));
            Console.WriteLine(controller.placeOrder(account1, item7));
            Console.WriteLine(controller.placeOrder(account1, item6));

            controller.updateProfile(account);

            controller.listAllAccounts();

            controller.removeAccount("razakmohamed");
            controller.listAllAccounts();
            controller.removeAccount(account1);
            controller.listAllAccounts();

        }
    }
}

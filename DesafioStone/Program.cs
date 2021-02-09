using System;
using System.Collections.Generic;

namespace StoneChallenge
{
    class Program
    {  
        static void Main(string[] args)
        {
            Item bean = new Item();
            Item meat = new Item();
            Item rice = new Item();
            Item sugar = new Item();

            rice.price = 449;
            rice.quantity = 5;
            bean.price = 629;
            bean.quantity = 4;
            sugar.price = 354;
            sugar.quantity = 2;
            meat.price = 3439;
            meat.quantity = 1;

            List<Item> itens = new List<Item>
            {
                bean,
                meat,
                rice,
                sugar
            };

            string email1 = "antonio@stone.com";
            string email2 = "marcos@stone.com";
            string email3 = "isabela@stone.com";
            string email4 = "rodrigues@stone.com";
            string email5 = "teste@stone.com";
            List<string> emails = new List<string>
            {
                email1,
                email2,
                email3,
                email4,
                email5
            };

            Dictionary<string, int> result = Desafio.calculate(itens, emails);

            foreach (KeyValuePair<string, int> kvp in result)
            {
                Console.WriteLine(string.Format("Person = {0}, Value = {1}", kvp.Key, kvp.Value));
            }
        }
    }
}

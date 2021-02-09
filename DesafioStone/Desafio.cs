using System.Collections.Generic;

namespace StoneChallenge
{
    class Desafio
    {
        public static Dictionary<string, int> calculate(List<Item> items, List<string> emails)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            int valuePerProducts = 0;
            int valuePerPerson;
            int rest;

            foreach(Item item in items)
            {
                valuePerProducts += item.price * item.quantity;
            }

            valuePerPerson = valuePerProducts / emails.Count;
            rest = valuePerProducts - (valuePerPerson * emails.Count);

            foreach(var i in emails)
                 result.Add(i, valuePerPerson);

            for(int i = 0; i < result.Count; i++)
            {
                if (rest > 0)
                {
                    result[emails[i]] += 1;
                    rest -= 1;
                }
                else
                    break;
            }
                
            return result;
        }
    }
}

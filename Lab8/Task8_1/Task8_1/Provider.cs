using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Provider
    {
        List<Tarif> tarifList = new List<Tarif>();
        List<User> userList = new List<User>();
        User findUser(string name)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Name == name)
                    return userList[i];
            }
            return new User();
        }
        Tarif findTarif(string name)
        {
            for (int i = 0; i < tarifList.Count; i++)
            {
                if (tarifList[i].Name == name)
                    return tarifList[i];
            }
            return new TarifNoDiscount(string.Empty);
        }
        public bool tarifInput(string name, int price, int discount = 0)
        {
            if (price < 0)
                return false;
            if (discount != 0)
                tarifList.Add(new TarifDiscount(name, price, discount));
            else
                tarifList.Add(new TarifNoDiscount(name, price));
            return true;
        }
        public bool register(string name, string tarifName, int trafic = 0)
        {
            if (trafic < 0)
                return false;
            User user = new User();
            user.Name = name;
            user.Tarif = findTarif(tarifName);
            user.Trafic = trafic;
            userList.Add(user);
            return true;
        }
        public int userTrafic(string name)
        {
            return findUser(name).Trafic;
        }
        public int profit()
        {
            int profit = 0;
            for (int i = 0; i < userList.Count; i++)
            {
                profit += userList[i].fullPrice();
            }
            return profit;
        }
        public string mainUser()
        {
            User mainUser = userList[0];
            for (int i = 1; i < userList.Count; i++)
            {
                if (userList[i].fullPrice() > mainUser.fullPrice())
                    mainUser = userList[i];
            }
            return mainUser.Name;
        }
    }
}
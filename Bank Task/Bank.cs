using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task
{
    class Bank
    {
        public string Name { get; set; }
        public double budget { get; set; }
        public double Profit { get; set; }
        public CEO CEO { get; set; }
        public List<Worker> workers { get; }
        public List<Client> clients { get; }
        public void ShowClientCredit(string fullName)
        {

        }
        public void PayCredit(Client client,double money)
        {

        }
        public void ShowAllCredit() { 
        }

    }
}

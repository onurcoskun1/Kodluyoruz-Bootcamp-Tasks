using System;
using System.Collections.Generic;

namespace BootcampWeek2Section1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Chart of Week-2
             * Methods and Build-in Methods
             * 
            */
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            //int result = word.IndexOf("i", 1);
            int startIndex = 0;
            Console.WriteLine("Aradığın harf: ");
            string character= Console.ReadLine();

            Console.WriteLine($"Index values of {character}: ");

            while (word.IndexOf(character,startIndex)!=-1)
            {
                int findingIndex = word.IndexOf(character, startIndex);
                Console.Write($"{findingIndex}, ");
                startIndex = findingIndex + 1;
            }

            //string b= word.ToUpperInvariant(); //Tüm harfleri ya da belirlediğimiz harfleri büyük harfe dönüşür 
            //Console.WriteLine(b);


            //Another exercise

            //Şirketlere ait olanları, public domainlere ait olanlardan ayırmak için operasyon
            //List<string> emails = new List<string>()
            //{
            //    "coskunonur01@gmail.com",
            //    "rabianurallah@yahoo.com",
            //    "turkaz.urkmez@dinamikzihin.com",
            //    "turkay.urkmez@gmail.com",
            //    "babyboy@mynet.com",
            //    "testData"
            //};

            ////Önce elemek istediklerimizi bir yerde topluyoruz

            //List<string> publicDomains = new List<string>()
            //{
            //    "yahoo.com",
            //    "gmail.com",
            //    "mynet.com",
            //};

            //List<string> companyMails = new List<string>();

            //foreach (var mail in emails)
            //{
            //    //foreach (var domain in publicDomains)
            //    //{
            //    //    if (!mail.EndsWith(domain))
            //    //    {

            //    //    }
            //    //}

            //    string[] mailParts = mail.Split('@');
            //    if(mailParts.Length > 1)
            //    {
            //        string mailDomain = mailParts[1];

            //        bool isExist = publicDomains.Contains(mailDomain);
            //        if (!isExist)
            //        {
            //            companyMails.Add(mail);
            //        }
            //    }
                
                
            //}
            //Console.WriteLine("Şirket e-posta adresleri: ");
            //foreach (var mailAdress in companyMails)
            //{
            //    Console.WriteLine(mailAdress);
            //}

            //Bulunan şehirlerden hangisinden varsa, birer tane getirecek bir uygulama getirsin
            List<string> cities = new List<string>() { "Ankara", "Ankara", "Ankara", "Sinop", "İstanbul", "İstanbul", "İstanbul", "Eskişehir", "Ankara" };

            List<string> cityList = new List<string>();

            

        }
    }
}

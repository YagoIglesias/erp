using System.Data;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Infrastructure;
using Client_menu;


Console.WriteLine("\n                                                Gestionaire de clients                       \n\n");

Console.WriteLine("Bienvenue sur le menu  de la base de donnees des clients, que desirez vous?\n");

Console.Write("     1. Clients          ");
Console.Write("     2. Produits         ");
Console.Write("     3. Comandes       \n\n");

Console.WriteLine("Choisisez le numero pour avoir les informations que vous desirez\n");

int reponse = Convert.ToInt32(Console.ReadLine());


bool valid = true;
if (reponse == 1)
{

    database.Connect();
    foreach (string line  in File.ReadAllLines("../../../listclients.csv"))
    {
        if (valid)
        {
            valid = false;
        }
        else

        {
            var columns = line.Split(";");
            string firstname = columns[0];
            string lastname = columns[1];
            string companyname = columns[2];
            string address = columns[3];
            string city = columns[4];
            string county = columns[5];
            string state = columns[6];
            int zip = Convert.ToInt32(columns[7]);
            string phone1 = columns[8];
            string phone2 = columns[9];
            string email = columns[10];
            string web = columns[11];
            string username;
            string password;


            Random random = new Random();
            string CharRandom = null;

            for (int i = 0; i < 32; i++)
            {
                CharRandom = CharRandom + Convert.ToChar(random.Next(33, 122));


            }

            password = database.sha256(CharRandom);

            var premier3Lettres = firstname.Substring(0, Math.Min(firstname.Length, 3)) + lastname;

            username = $"{premier3Lettres}";


           

            var sql = $"SELECT cliUsserName FROM t_client WHERE cliUsserName ='{username}'";

            var reader = database.Select(sql);

            if (reader.HasRows == false)
            {

                sql = $" INSERT INTO `ERP`.`t_client` (cliName, cliLastName, cliCompanyName, cliAddress, cliCity, cliCounty, cliState, cliZip, cliPhone1, cliPhone2, cliEmail, cliWeb, cliUsserName, cliPassWord) VALUES('{firstname}', '{lastname}', '{companyname}', '{address}', '{city} ', '{county} ', '{state}', '{zip}', '{phone1}', '{phone2}','{email}', '{web}', '{premier3Lettres}', '{password}')";
                database.Insert(sql);
            }

            else
            {
                if (reader["cliLastName"].ToString() != lastname || reader["cliName"].ToString() != firstname)
                { 

                    
                    sql = $"UPDATE t_client set cliName = {firstname},cliLastName ={lastname}, cliCompanyName = {companyname}, cliAddress = {address}, cliCity = {city}, cliCounty = {county}, cliState = {state}, cliZip = {zip}, cliPhone1 = {phone1}, cliPhone2 = {phone2}, cliEmail = {email}, cliWeb{web}, cliUsserName{premier3Lettres}, cliPassWord = {password}";
                    database.Update(sql);

                }
                else
                {

                     database.Select(sql);
                }
                
            }
            


            



            
            

        }




    }
}

   /*var firstChar = firstname[0];
            var secondChar = firstname[1];
            var thirdChar = firstname[2];*/

            /*username = $"{firstChar}{secondChar}{thirdChar}";*/
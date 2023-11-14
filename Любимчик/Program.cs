Console.WriteLine("Введите свое имя");
string UserName = Console.ReadLine();
if (UserName.ToLower()== "alice") //ToLower()-переводит в нижний регистр

{
    Console.WriteLine("Привет Алисонька^^");
}
else
{
Console.WriteLine("Привет " + UserName);  
}   

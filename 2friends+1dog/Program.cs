Console.WriteLine("Введите скорость первого друга");
string fr1 = Console.ReadLine();
//int Fr1Speed = Convert.ToInt16(fr1);
int FriendSpeed1 = Convert.ToInt16(fr1);
Console.WriteLine("Введите скорость второго друга");
fr1 = Console.ReadLine();
int FriendSpeed2 = Convert.ToInt16(fr1);
Console.WriteLine("Введите скорость второго собаки");
fr1 = Console.ReadLine();
int DogSpeed = Convert.ToInt16(fr1);
Console.WriteLine("Введите дистанцию между друзьями");
fr1 = Console.ReadLine();
Double distance = Convert.ToDouble(fr1);
Double time = 0;
bool F1 = true;
int count = 0;
while (distance > 20)
 {
    if (F1==true)
     {time=distance/(FriendSpeed2+DogSpeed);
     //Console.WriteLine("F1 "+distance + " " + time);
     F1=false;
    }
    else
    {
     time=distance/(FriendSpeed1+DogSpeed);
     //Console.WriteLine("F2 "+distance + " " + time);
     F1=true;
    }
    distance=distance-time*(FriendSpeed1+FriendSpeed2);
    count++;
 }


Console.WriteLine("Собака сделает " + count + " разворотов");

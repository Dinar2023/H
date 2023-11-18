int FriendSpeed1 = 9;
int FriendSpeed2 = 7;
int DogSpeed = 200;
float distance = 200000;
float time = 0;
bool F1 = true;
int count = 0;
while (distance > 20)
 {
    if (F1==true)
    {time=distance/(FriendSpeed2+DogSpeed);
    distance=distance-time*(FriendSpeed1+FriendSpeed2);
    count++;
    }
    else
    {
    time=distance/(FriendSpeed1+DogSpeed);
    distance=distance-time*(FriendSpeed1+FriendSpeed2);
    count++;  
    }
 }


Console.WriteLine(count);

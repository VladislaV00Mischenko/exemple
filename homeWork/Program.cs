int distance = 10000;
int friendspeed1 = 1;
int friendspeed2 = 2;
int dogspeed = 5;
int i = 0;
int friend = 2;
int time = 0;

while(distance > 10)
{ 
    if(friend == 1)
    { time = distance / (friendspeed1 + dogspeed);
    friend = 2;
    }
    else
    { 
        time = distance / (friendspeed2 + dogspeed);
        friend = 1;
    }
    distance = distance - (friendspeed1 + friendspeed2) * time;
    i++;
    Console.WriteLine(distance);


}
Console.WriteLine(i);

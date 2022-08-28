int count = 0, first_friend_speed = 1, second_friend_speed = 2,
    dog_speed = 5, friend = 2, distance = 10000, time = 0;
while (distance > 10)
{
    if (friend == 2)
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
    }
    else
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
    }
    count++;
    distance = distance - time * (first_friend_speed + second_friend_speed);
}
Console.Write(count);

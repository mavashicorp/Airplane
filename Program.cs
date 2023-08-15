﻿
int[] sectors = { 6, 28, 15, 15, 17 };
bool isOpen = true;

while (isOpen)
{
    Console.SetCursorPosition(0, 18);
    for (int i = 0; i < sectors.Length; i++)
    {
        Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");
    }

    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Регистрация рейса.");
    Console.WriteLine("\n\n1 - забронировать места\n\n2 - выход из программы.\n\n");
    Console.Write("Введите номер команды: ");
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            int userSector, userPlaceAmount;
            Console.WriteLine("В каком секторе вы хотите лететь?");
            userSector = Convert.ToInt32(Console.ReadLine()) - 1;
            if (sectors.Length <= userSector || userSector < 0)
            {
                Console.WriteLine("Такого сектора не существует.");
                break;
            }
            Console.WriteLine("Сколько мест вы хотите забронировать?");
            userPlaceAmount = Convert.ToInt32(Console.ReadLine());
            if (userPlaceAmount < 0)
            {
                Console.WriteLine("Неверное количество мест.");
                break;
            }
            if (sectors[userSector] < userPlaceAmount)
            {
                Console.WriteLine($"В секторе {userSector} недостаточно мест" + $"Остатоток {sectors[userSector]}");
                break;
            }
            sectors[userSector] = userPlaceAmount;
            Console.WriteLine("Бронирование успешно.");
            break;
        case 2:
            isOpen = false;
            break;
    }

    Console.ReadKey();
    Console.Clear();
}
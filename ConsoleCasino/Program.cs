﻿using ConsoleCasino;
using ConsoleCasino.Slots;
using Newtonsoft.Json;
Account account = new Account();
Console.WriteLine("Witaj w Royal Casino "+account.getName());
Console.WriteLine("Twój aktualny status konta: "+account.getBalance());
Slots test = new Slots();
test.Lever();


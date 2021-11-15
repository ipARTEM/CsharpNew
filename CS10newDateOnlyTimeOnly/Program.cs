
DateOnly date = new(2021, 11, 15);
Console.WriteLine(date);
date.AddDays(1);
date.AddMonths(1);
date.AddYears(1);
Console.WriteLine(date);

TimeOnly time = new(14, 00, 01);
TimeOnly timeFrom = new(13, 00, 01);
TimeOnly timeTo = new(15, 00, 01);
Console.WriteLine(time);
time.AddHours(1);
time.AddMinutes(1);

Console.WriteLine(time);
Console.WriteLine(time.IsBetween(timeFrom, timeTo));



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case.Lib;

namespace Case_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random((int)DateTime.Now.Ticks);
            DataService ds = new DataService();

            string[] rase = new string[] { "Фея", "Человек", "Эльф", "Оборотень", "Вампир", "Рептилоид" };
            string[] clas = new string[] { "Маг", "Вор", "Воин", "Лучник", "Иллюминат" };
            string[] weapon = new string[] {"Меч двуручный", "Меч одноручный", "Лук", "Копьё", "Волшебная палочка", "Посох", "Чайник" };
            string[] armor = new string[] { "Доспехи", "Кожанная броня", "Мантия", "Кольчуга"};
            string[] battlepass = new string[] {"Боевой пропуск", "Без боевого пропуска"};
            string[] gender = new string[] { "Мужской", "Женский", "Не указан" };
            int male = 2;
            int female = 1;
            int none = 0;

            string[][] genres = new string[][] { };
            string[][] res = new string[][] { };
            string[] empty = new string[] { };
            string[] empty2 = new string[] { };



            string[][] rate = ds.Res(gender, battlepass, rase, clas, weapon, armor);

            

            int[] llvl = new int[] { };
            for (int i = 0; i<=99; i++)
            {
                llvl = llvl.Append(Convert.ToInt32(rate[i][6])).ToArray();
            }
            Array.Sort(llvl);
            Array.Reverse(llvl);

            
            for (int i = 0; i <= 3; i++)
            { int fst = 0;
                while (fst <= 99)
                {
                    if (llvl[i] == Convert.ToInt32(rate[fst][6]))
                    {
                        res = res.Append(rate[fst]).ToArray();
                        fst++;
                    }
                    else
                    {
                        fst++;
                    }
                }
            }

            Console.WriteLine("ТОП-3 РЕЙТИНГ ИГРОКОВ");
            Console.WriteLine("1. Пол 2. Наличие боевого пропуска 3. Раса 4. Класс персонажа 5. Любимое оружие 6. Любимая броня 7. Уровень");
            Console.WriteLine();
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                Console.WriteLine();
            }
            Console.WriteLine("************************************************************************************************");


            for (int i = 0; i <= 99; i++)
            {
                if (rate[i][0] == "Мужской")
                {
                    genres = genres.Append(rate[i]).ToArray();
                }
            }

            for (int i = 0; i <= 99; i++)
            {
                if (rate[i][0] == "Женский")
                {
                    genres = genres.Append(rate[i]).ToArray();
                }
            }

            for (int i = 0; i <= 99; i++)
            {
                if (rate[i][0] == "Не указан")
                {
                    genres = genres.Append(rate[i]).ToArray();
                }
            }




            

            

            Console.ReadKey();
            for (int i = 0; i <= 99; i++)
            {
                Console.WriteLine("1. " + genres[i][0] + " 2. " + genres[i][1] + " 3. " + genres[i][2] + " 4. " + genres[i][3] + " 5. " + genres[i][4] + " 6. " + genres[i][5] + " 7. " + genres[i][6]);
                Console.WriteLine();
            }

            bool exit = true;
            
            while (exit == true)
            {
                Console.WriteLine("Выберите критерий для оценивания лучших игроков и введите его: \nПол, Наличие боевого пропуска, Раса, Класс персонажа, Любимое оружие, Любимая броня\nДля завершения программы введите слово Выход");
                string input = Convert.ToString(Console.ReadLine());

                switch (input)
                {
                    case "Пол":
                        Console.WriteLine("Укажите желаемый пол: мужской/женский/не указан");
                        string inp1 = Convert.ToString(Console.ReadLine());
                        if (inp1 == "Мужской" || inp1 == "мужской")
                        {
                            int count = 0;
                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                
                                if (res[i][0] == "Мужской")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }
                            }
                        }

                        if (inp1 == "Женский" || inp1 == "женский")
                        {
                            int count = 0;
                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                               
                                if (res[i][0] == "Женский")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }
                            
                            }
                        }

                        if (inp1 == "Не указан" || inp1 == "не указан")
                        {
                            Array.Clear(empty2, 0, empty2.Length);
                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                int count = 0;
                                if (res[i][0] == "Не указан")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }
                            }
                        }

                        break;

                    case "Наличие боевого пропуска":
                        Console.WriteLine("Имеет ли игрок боевой пропуск: да/нет");
                        string inp2 = Convert.ToString(Console.ReadLine());
                        if (inp2 == "Да" || inp2 == "да")
                        {
                            int count = 0;
                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][1] == "Боевой пропуск")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }
                            }
                        }

                        if (inp2 == "Нет" || inp2 == "нет")
                        {
                            int count = 0;
                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][1] == "Без боевого пропуска")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }
                            }
                        }

                        break;

                    case "Раса":
                        Console.WriteLine("Укажите расу персонажа: человек/фея/эльф/оборотень/вампир/рептилоид");
                        string inp3 = Convert.ToString(Console.ReadLine());
                        if (inp3 == "Человек" || inp3 == "человек")
                        {
                            int count = 0;
                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][2] == "Человек")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }
                            }
                        }

                        if (inp3 == "Фея" || inp3 == "фея")
                        {
                            int count = 0;
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][2] == "Фея")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }

                            }
                        }

                        if (inp3 == "Эльф" || inp3 == "эльф")
                        {
                            int count = 0;
                            Array.Clear(empty2, 0, empty2.Length);
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][2] == "Эльф")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }
                            }
                        }

                        if (inp3 == "Оборотень" || inp3 == "оборотень")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                int count = 0;
                                if (res[i][2] == "Оборотень")
                                {
                                    if (count < 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        count++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                    }
                                }
                            }
                        }

                        if (inp3 == "Вампир" || inp3 == "вампир")
                        {
                            int count = 0;
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][2] == "Вампир")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }

                            }
                        }

                        if (inp3 == "Рептилоид" || inp3 == "рептилоид")
                        {
                            Array.Clear(empty2, 0, empty2.Length);
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][2] == "Рептилоид")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        break;

                    case "Класс персонажа":
                        Console.WriteLine("Укажите класс персонажа: маг/вор/воин/лучник/иллюминат");
                        string inp4 = Convert.ToString(Console.ReadLine());
                        if (inp4 == "Маг" || inp4 == "маг")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][3] == "Маг")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp4 == "Вор" || inp4 == "вор")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][3] == "Вор")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }

                            }
                        }

                        if (inp4 == "Воин" || inp4 == "воин")
                        {
                            Array.Clear(empty2, 0, empty2.Length);
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][3] == "Воин")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp4 == "Лучник" || inp4 == "лучник")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][3] == "Лучник")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp4 == "Иллюминат" || inp4 == "иллюминат")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][3] == "Иллюминат")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }

                            }
                        }

                        break;

                    case "Любимое оружие":
                        Console.WriteLine("Укажите любимое оружие персонажа: Меч двуручный/Меч одноручный/Лук/Копьё/Волшебная палочка/Посох/Чайник");
                        string inp5 = Convert.ToString(Console.ReadLine());
                        if (inp5 == "Меч двуручный" || inp5 == "меч двуручный")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][4] == "Меч двуручный")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp5 == "Меч одноручный" || inp5 == "меч одноручный")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][4] == "Меч одноручный")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }

                            }
                        }

                        if (inp5 == "Лук" || inp5 == "лук")
                        {
                            Array.Clear(empty2, 0, empty2.Length);
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][4] == "Лук")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp5 == "Копьё" || inp5 == "копьё")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][4] == "Копьё")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp5 == "Волшебная палочка" || inp5 == "волшебная палочка")
                        {

                            for (int i = 0; i <= res.Length-1; i++)
                            {

                                if (res[i][4] == "Волшебная палочка")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }

                            }
                        }

                        if (inp5 == "Посох" || inp5 == "посох")
                        {
                            Array.Clear(empty2, 0, empty2.Length);
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][4] == "Посох")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp5 == "Чайник" || inp5 == "чайник")
                        {
                            Array.Clear(empty2, 0, empty2.Length);
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][4] == "Чайник")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        break;

                    case "Любимая броня":
                        Console.WriteLine("Выберите любимое оружие персонажа: Доспехи/Кожанная броня/Мантия/Кольчуга");
                        string inp6 = Convert.ToString(Console.ReadLine());
                        if (inp6 == "Доспехи" || inp6 == "доспехи")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][5] == "Доспехи")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp6 == "Кожанная броня" || inp6 == "кожанная броня")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][5] == "Кожанная броня")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }

                            }
                        }

                        if (inp6 == "Мантия" || inp6 == "мантия")
                        {
                            Array.Clear(empty2, 0, empty2.Length);
                            for (int i = 0; i <= res.Length - 1; i++)
                            {

                                if (res[i][5] == "Мантия")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        if (inp6 == "Кольчуга" || inp6 == "кольчуга")
                        {

                            for (int i = 0; i <= res.Length - 1; i++)
                            {
                                if (res[i][5] == "Кольчуга")
                                {
                                    Console.WriteLine("1. " + res[i][0] + " 2. " + res[i][1] + " 3. " + res[i][2] + " 4. " + res[i][3] + " 5. " + res[i][4] + " 6. " + res[i][5] + " 7. " + res[i][6]);
                                }
                            }
                        }

                        break;

                    case "Выход":
                        exit = false;
                        break;

                    case "выход":
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Введённые данные не совсем корректны. Пожалуйста, попробуйте ещё раз.");
                        break;
                }
            }    
        }
    }
}

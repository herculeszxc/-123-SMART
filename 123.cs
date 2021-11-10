using System;

namespace _123
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("//////////////////////////////////////////");
            Console.WriteLine("1)Get 1 GB VIDEO EVERY DAY, 7DAYS");
            Console.WriteLine("2)Get 1 GB STORIES EVERY DAY, 7DAYS");
            Console.WriteLine("3)GIGA");
            Console.WriteLine("4)PRO");
            Console.WriteLine("5)ALL DATA");
            Console.WriteLine("6)MAGIC DATA");
            Console.WriteLine("7)Bal:Svcs");
            Console.WriteLine("//////////////////////////////////////////");

            Console.WriteLine("Choose 1 - 7");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1){
                Console.Clear();
                promo1();
            }
            else if (num == 2)
            {
                Console.Clear();
                promo2();
            }
            else if (num == 3)
            {
                Console.Clear();
                promo3();
            }
            else if (num == 4)
            {
                Console.Clear();
                promo4();
            }
            else if (num == 5)
            {
                Console.Clear();
                promo5();
            }
            else if (num == 6)
            {
                Console.Clear();
                promo6();
            }
            else if (num == 7)
            {
                Console.Clear();
                bal();
            }
        }

        static void promo1()
        {
            Console.WriteLine("Get 1 GB VIDEO EVERYDAY for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(7GB + 2GB, 7DAYS P99)");
            Console.WriteLine("1)Subscribe");
            Console.WriteLine("0)Back");
            Console.WriteLine("Choose 0 - 1");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.Clear();
                Console.WriteLine("Thank you for subscribing this promo.");
            }
            else if (num == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input");
            };
        }

        static void promo2()
        {
            Console.WriteLine("Get 1 GB STORIES EVERYDAY for TikTok, IG, FB, Twitter, Kumu (7GB + 2GB, 7DAYS P99)");
            Console.WriteLine("1)Subscribe");
            Console.WriteLine("0)Back");
            Console.WriteLine("Choose 1 - 0");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.Clear();
                Console.WriteLine("Thank you for subscribing this promo.");
            } else if (num == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input");
            };
        }

        static void promo3()
        {
            Console.WriteLine("1) Get 1 GB VIDEO EVERY DAY, 7DAYS");
            Console.WriteLine("2) Get 1 GB STORIES EVERY DAY, 7DAYS");
            Console.WriteLine("3) VIDEO");
            Console.WriteLine("4) STORIES");
            Console.WriteLine("5) GAMES");
            Console.WriteLine("0 )Back");

            Console.WriteLine("Choose 0 - 5");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.Clear();
                promo31();
            }
            else if (num == 2)
            {
                Console.Clear();
                promo32();
            } 
            else if (num == 3)
            {
                Console.Clear();
                promo33();
            }
            else if (num == 4)
            {
                Console.Clear();
                promo34();
            }
            else if (num == 5)
            {
                Console.Clear();
                promo35();
            }
            else if (num == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input");
            }
            
            static void promo31()
            {
                Console.WriteLine("Get 1 GB VIDEO EVERYDAY for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(7GB + 2GB, 7DAYS P99)");
                Console.WriteLine("1) Subscribe");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 1");

                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo3();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                };
            }

            static void promo32()
            {
                Console.WriteLine("Get 1 GB STORIES EVERYDAY for TikTok, IG, FB, Twitter, Kumu (7GB + 2GB, 7DAYS P99)");
                Console.WriteLine("1) Subscribe");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 1");

                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo3();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                };
            }

            static void promo33()
            {
                Console.WriteLine("Get 1 GB VIDEO EVERY DAY PLUS");
                Console.WriteLine("1) 1GB, 3Days, P50");
                Console.WriteLine("2) 2GB, 7Days, P90");
                Console.WriteLine("3) 4GB, 30Days, P299");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 3");

                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    promo331();
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo332();
                }else if (num == 3)
                {
                    Console.Clear();
                    promo333();
                }else if (num == 0)
                {
                    Console.Clear();
                    promo3();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                };

                static void promo331()
                {
                    Console.WriteLine("Get 1 GB VIDEO EVERYDAY for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(3GB + 1GB, 3DAYS P50)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("2) Add P49 for 2 GB 7 Days");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 2");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }else if (num == 2)
                    {
                        Console.Clear();
                        promo3312();
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo33();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    };

                    static void promo3312()
                    {
                        Console.WriteLine("Get 1 GB VIDEO EVERYDAY for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(7GB + 2GB, 3DAYS P50)");
                        Console.WriteLine("1) Subscribe");
                        Console.WriteLine("0) Back");
                        Console.WriteLine("Choose 0 - 2");

                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for subscribing this promo.");
                        }
                        else if (num == 0)
                        {
                            Console.Clear();
                            promo331();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                        };
                    }
                }

                static void promo332()
                {
                    Console.WriteLine("Get 1 GB VIDEO EVERYDAY for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(7GB + 2GB, 7DAYS P90)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("2) Add P200 for 4 GB 30 Days");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 2");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 2)
                    {
                        Console.Clear();
                        promo3322();
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo33();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    };

                    static void promo3322()
                    {
                        Console.WriteLine("Get 1 GB VIDEO EVERYDAY for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(30GB + 4GB, 30DAYS P299)");
                        Console.WriteLine("1) Subscribe");
                        Console.WriteLine("0) Back");
                        Console.WriteLine("Choose 0 - 2");

                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for subscribing this promo.");
                        }
                        else if (num == 0)
                        {
                            Console.Clear();
                            promo332();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                        };
                    }
                }

                static void promo333(){
                    Console.WriteLine("Get 1 GB VIDEO EVERYDAY for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(30GB + 4GB, 30DAYS P299)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("2) Add P200 for 4 GB 30 Days");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 2");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo33();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    };

                    
                    }
                
            }

            static void promo34()
            {
                Console.WriteLine("Get 1 GB STORIES EVERY DAY PLUS");
                Console.WriteLine("1) 1GB, 3Days, P50");
                Console.WriteLine("2) 2GB, 7Days, P90");
                Console.WriteLine("3) 4GB, 30Days, P299");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 3");

                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    promo341();
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo342();
                }
                else if (num == 3)
                {
                    Console.Clear();
                    promo343();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo3();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                };

                static void promo341()
                {
                    Console.WriteLine("Get 1 GB STORIES EVERYDAY for TikTok, IG, FB, TWITTER, KUMU(3GB + 1GB, 3DAYS P50)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("2) Add P49 for 2 GB 7 Days");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 2");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 2)
                    {
                        Console.Clear();
                        promo3412();
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo33();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    };

                    static void promo3412()
                    {
                        Console.WriteLine("Get 1 GB STORIES EVERYDAY for TikTok, IG, FB, TWITTER, KUMU(7GB + 2GB, 3DAYS, P99)");
                        Console.WriteLine("1) Subscribe");
                        Console.WriteLine("0) Back");
                        Console.WriteLine("Choose 0 - 2");

                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for subscribing this promo.");
                        }
                        else if (num == 0)
                        {
                            Console.Clear();
                            promo341();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                        };
                    }
                }

                static void promo342()
                {
                    Console.WriteLine("Get 1 GB Get 1 GB STORIES EVERYDAY for TikTok, IG, FB, TWITTER, KUMU(7GB + 2GB, 7DAYS P90)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("2) Add P200 for 4 GB 30 Days");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 2");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 2)
                    {
                        Console.Clear();
                        promo3422();
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo33();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    };

                    static void promo3422()
                    {
                        Console.WriteLine("Get 1 STORIES EVERYDAY for TikTok, IG, FB, TWITTER, KUMU(30GB + 4GB, 30DAYS P299)");
                        Console.WriteLine("1) Subscribe");
                        Console.WriteLine("0) Back");
                        Console.WriteLine("Choose 0 - 2");

                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for subscribing this promo.");
                        }
                        else if (num == 0)
                        {
                            Console.Clear();
                            promo342();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                        };
                    }
                }

                static void promo343()
                {
                    Console.WriteLine("Get 1 GB STORIES EVERYDAY for TikTok, IG, FB, TWITTER, KUMU(30GB + 4GB, 30DAYS P299)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo33();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    };


                }
            }

            static void promo35()
            {
                Console.WriteLine("Get 1 GB GAMES EVERY DAY PLUS");
                Console.WriteLine("1) 1GB, 3Days, P50");
                Console.WriteLine("2) 2GB, 7Days, P90");
                Console.WriteLine("3) 4GB, 30Days, P299");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 3");

                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    promo351();
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo352();
                }
                else if (num == 3)
                {
                    Console.Clear();
                    promo353();
                }
                else if (num == 0)  
                {
                    Console.Clear();
                    promo3();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                };

                static void promo351()
                {
                    Console.WriteLine("Get 1 GB GAMES EVERYDAY for CoC, AoV, Clash Royal, ML, FB Gaming(3GB + 1GB, 3DAYS P50)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("2) Add P49 for 2GB 7 Days");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 2");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 2)
                    {
                        Console.Clear();
                        promo3512();
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo35();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    };

                    static void promo3512()
                    {
                        Console.WriteLine("Get 1 GB GAMES EVERYDAY for CoC, AoV, Clash Royal, ML, FB Gaming(7GB + 2GB, 7DAYS P99)");
                        Console.WriteLine("1) Subscribe");
                        Console.WriteLine("0) Back");
                        Console.WriteLine("Choose 0 - 2");

                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for subscribing this promo.");
                        }
                        else if (num == 0)
                        {
                            Console.Clear();
                            promo351();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                        };
                    }
                }
                
                static void promo352()
                {
                    Console.WriteLine("Get 1 GB GAMES EVERYDAY for CoC, AoV, Clash Royal, ML, FB Gaming(7GB + 2GB, 7DAYS P99)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("2) Add P200 for 4GB 30Days");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 2");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 2)
                    {
                        Console.Clear();
                        promo3522();
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo35();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    };

                    static void promo3522()
                    {
                        Console.WriteLine("Get 1 GB GAMES EVERYDAY for CoC, AoV, Clash Royal, ML, FB Gaming(30GB + 4GB, 30DAYS P299)");
                        Console.WriteLine("1) Subscribe");
                        Console.WriteLine("0) Back");
                        Console.WriteLine("Choose 0 - 2");

                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for subscribing this promo.");
                        }
                        else if (num == 0)
                        {
                            Console.Clear();
                            promo351();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                        };
                    }
                }

                static void promo353()
                {
                    Console.WriteLine("Get 1 GB GAMES EVERYDAY for CoC, AoV, Clash Royal, ML, FB Gaming(30GB + 4GB, 30DAYS P299)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo35();
                    }
                    else
                    {
                        Console.Clear();

                    }
                }   

        }
         }

        static void promo4()
        {
            Console.WriteLine("1) Get 3 GB VIDEO EVERY DAY, 7 DAYS");
            Console.WriteLine("2) Get 3 GB STORIES EVERY DAY, 7 DAYS");
            Console.WriteLine("3) VIDEO");
            Console.WriteLine("4) STORIES");
            Console.WriteLine("5) STUDY");
            Console.WriteLine("6) WORK");
            Console.WriteLine("7) GAMES");
            Console.WriteLine("0) Get 3 GB VIDEO EVERY DAY, 7 DAYS");
            Console.WriteLine("Choose 0 - 7");

            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.Clear();
                promo41();
            }
            else if (num == 2){
                Console.Clear();
                promo42();
            }
            else if (num == 3)
            {
                Console.Clear();
                promo43();
            }
            else if (num == 4)
            {
                Console.Clear();
                promo44();
            }
            else if (num == 5)
            {
                Console.Clear();
                promo45();
            }
            else if (num == 6)
            {
                Console.Clear();
                promo46();
            }else if (num == 7)
            {
                Console.Clear();
                promo47();
            }else if (num == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            static void promo41()
            {
                Console.WriteLine("Get 3 GB VIDEO EVERY DAY, 7 DAYS for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(21GB + 6GB, 7DAYS, P199)");
                Console.WriteLine("1) Subscribe");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 1");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo4();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            static void promo42(){
                Console.WriteLine("Get 3 GB STORIES EVERY DAY, for TikTok, IG, FB, Twitter, Kumu (21GB + 6GB, 7DAYS, P199)");
                Console.WriteLine("1) Subscribe");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 1");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo4();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            static void promo43()
            {
                Console.WriteLine("Get 3 GB VIDEO EVERYDAY PLUS");
                Console.WriteLine("1) 6GB, 7 DAYS, P199");
                Console.WriteLine("2) 24GB, 30 DAYS, P999");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    promo431();
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo432();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo4();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo431()
                {
                    Console.WriteLine("Get 3 GB VIDEO EVERY DAY, 7 DAYS for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(21GB + 6GB, 7DAYS, P199)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo43();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                static void promo432()
                {
                    Console.WriteLine("Get 3 GB VIDEO EVERY DAY, 7 DAYS for YouTube, NBA TV, GigaPlay, iWant TFC, Cignal Play(90GB + 24GB, 7DAYS, P999)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo43();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            static void promo44()
            {
                Console.WriteLine("Get 3 GB STORIES EVERYDAY PLUS");
                Console.WriteLine("1) 6GB, 7 DAYS, P199");
                Console.WriteLine("2) 24GB, 30 DAYS, P999");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    promo441();
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo442();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo4();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo441()
                {
                    Console.WriteLine("Get 3 GB STORIES EVERY DAY for TikTok, IG, FB, Twitter, Kumu(21GB + 6GB, 7DAYS, P199)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo44();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                static void promo442()
                {
                    Console.WriteLine("Get 3 GB STORIES EVERY DAY for TikTok, IG, FB, Twitter, Kumu(90GB + 24GB, 7DAYS, P999)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo44();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

            }
            
            static void promo45()
            {
                Console.WriteLine("Get 3 GB STUDY EVERYDAY PLUS");
                Console.WriteLine("1) 6GB, 7 DAYS, P199");
                Console.WriteLine("2) 24GB, 30 DAYS, P999");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    promo451();
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo452();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo4();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo451()
                {
                    Console.WriteLine("Get 3 GB STUDY EVERYDAY for Google Classroom, MS Teams, Youtube & MORE(21GB + 6GB, 7DAYS, P199)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo45();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                static void promo452()
                {
                    Console.WriteLine("Get 3 GB STUDY EVERYDAY for Google Classroom, MS Teams, Youtube & MORE(90GB + 24GB, 30DAYS, P999)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo45();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            static void promo46()
            {
                Console.WriteLine("Get 3 GB WORK EVERYDAY PLUS");
                Console.WriteLine("1) 6GB, 7 DAYS, P199");
                Console.WriteLine("2) 24GB, 30 DAYS, P999");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    promo461();
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo462();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo4();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo461()
                {
                    Console.WriteLine("Get 3 GB WORK EVERYDAY for Office 365, MS Teams & MORE(21GB + 6GB, 7DAYS, P199)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo46();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                static void promo462()
                {
                    Console.WriteLine("Get 3 GB WORK EVERYDAY for Office 365, MS Teams & MORE(90GB + 24GB, 30DAYS, P999)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo46();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

            }

            static void promo47()
            {
                Console.WriteLine("Get 3 GB GAMES EVERYDAY PLUS");
                Console.WriteLine("1) 6GB, 7 DAYS, P199");
                Console.WriteLine("2) 24GB, 30 DAYS, P999");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    promo471();
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo472();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo4();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo471(){
                    Console.WriteLine("Get 3 GB GAME EVERYDAY for Wild Rift, Call of Duty, CoC, AOV, Clash Royale, ML, FB Gaming(21GB + 6GB, 7DAYS, P199)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo47();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                static void promo472(){
                    Console.WriteLine("Get 3 GB GAME EVERYDAY for Wild Rift, Call of Duty, CoC, AOV, Clash Royale, ML, FB Gaming(90GB + 24GB, 30DAYS, P999)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo47();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }

        static void promo5()
        {
            Console.WriteLine("Enjoy DATA FOR ALL SITES (SHARABLE)");
            Console.WriteLine("1) 2GB, 3 DAYS, P50");
            Console.WriteLine("2) 6GB, 7 DAYS, P99");
            Console.WriteLine("3) 24GB, 30 DAYS, P299");
            Console.WriteLine("0) Back");
            Console.WriteLine("Choose 0 - 3");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.Clear();
                promo51();
            }
            else if (num == 2)
            {
                Console.Clear();
                promo52();
            }
            else if (num == 3)
            {
                Console.Clear();
                promo53();
            }
            else if (num == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            static void promo51()
            {
                Console.WriteLine("Get 2GB SHARABLE DATA 3Days, P50");
                Console.WriteLine("1) SUBSCRIBE");
                Console.WriteLine("2) Add P49 for 6 GB, 7 Days");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo512();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo5();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo512()
                {
                    Console.WriteLine("Get 6 GB SHARABLE DATA 7 Days, P99");
                    Console.WriteLine("1) SUBSCRIBE");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo51();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            static void promo52()
            {
                Console.WriteLine("Get 6GB SHARABLE DATA 7Days, P99");
                Console.WriteLine("1) SUBSCRIBE");
                Console.WriteLine("2) Add P200 for 24 GB, 30 Days");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo522();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo5();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo522()
                {
                    Console.WriteLine("Get 24 GB SHARABLE DATA 30 Days, P99");
                    Console.WriteLine("1) SUBSCRIBE");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo52();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    }
                }
            }
            
            static void promo53()
            {
                Console.WriteLine("Get 24GB SHARABLE DATA 30Days, P299");
                Console.WriteLine("1) SUBSCRIBE");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo5();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }
        }

        static void promo6()
        {
            Console.WriteLine("Enjoy MAGIC DATA FOR ALL SITES (NO EXPIRY )");
            Console.WriteLine("1) 2GB, P99");
            Console.WriteLine("2) 6GB, P199");
            Console.WriteLine("3) 24GB, P399");
            Console.WriteLine("0) Back");
            Console.WriteLine("Choose 0 - 3");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.Clear();
                promo61();
            }
            else if (num == 2)
            {
                Console.Clear();
                promo62();
            }
            else if (num == 3)
            {
                Console.Clear();
                promo63();
            }
            else if (num == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            static void promo61()
            {
                Console.WriteLine("Get 2 GB MAGIC DATA, P99");
                Console.WriteLine("1) SUBSCRIBE");
                Console.WriteLine("2) Add P100 for 6 GB");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo612();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo6();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo612()
                {
                    Console.WriteLine("Get 6 GB MAGIC DATA 7 Days, P199");
                    Console.WriteLine("1) SUBSCRIBE");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo61();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    }
                }

                
            }

            static void promo62()
            {
                Console.WriteLine("Get 6 GB MAGIC DATA, P199");
                Console.WriteLine("1) SUBSCRIBE");
                Console.WriteLine("2) Add P200 for 24 GB");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 2)
                {
                    Console.Clear();
                    promo622();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo6();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void promo622()
                {
                    Console.WriteLine("Get 24 GB MAGIC DATA, P399");
                    Console.WriteLine("1) SUBSCRIBE");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Choose 0 - 1");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for subscribing this promo.");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        promo62();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            static void promo63()
            {
                Console.WriteLine("Get 24GB MAGIC DATA, P399");
                Console.WriteLine("1) SUBSCRIBE");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 1");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 0)
                {
                    Console.Clear();
                    promo6();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }
        }

        static void bal()
        {
            Console.WriteLine("1) Get 1 GB VIDEO EVERYDAY, 7DAYS");
            Console.WriteLine("2) Get 1 GB STORIES EVERY DAY, 7DAYS");
            Console.WriteLine("3) BALANCE");
            Console.WriteLine("4) Giga Points");
            Console.WriteLine("0) Back");
            Console.WriteLine("Choose 0 - 4");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.Clear();
                svcs1();
            }
            else if (num == 2)
            {
                Console.Clear();
                svcs2();
            }
            else if (num == 3)
            {
                Console.Clear();
                bal();
            }
            else if (num == 4)
            {
                Console.Clear();
                svcs4();
            }
            else if (num == 0)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            static void svcs1()
            {
                Console.WriteLine("Get 1 GB VIDEO EVERY DAY for YouTube, NBA TV, Giga Play, iWant TFC, Cignal Pla(7 GB + 2GB 7 DAYS, P99)");
                Console.WriteLine("1) SUBSCRIBE");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 1");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 0)
                {
                    Console.Clear();
                    bal();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            static void svcs2()
            {
                Console.WriteLine("Get 1 GB STORIES EVERY DAY for TikTok, IG, FB, Twitter, Kumu(7 GB + 2GB 7 DAYS, P99)");
                Console.WriteLine("1) SUBSCRIBE");
                Console.WriteLine("0) Back");
                Console.WriteLine("Choose 0 - 1");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for subscribing this promo.");
                }
                else if (num == 0)
                {
                    Console.Clear();
                    bal();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }

            static void bal()
            {
                Console.WriteLine("09271520387");
                Console.WriteLine("Regular Load: P1337.69 Exp. 22Nov2022 13:37PM");
            }

            static void svcs4()
            {
                Console.WriteLine("1 Giga Point = 1 Peso");
                Console.WriteLine("Download the Giga life App for MORE points for MORE rewards!");
                Console.WriteLine("1) Download NOW!");
                Console.WriteLine("2) Get 1 GB VIDEO EVERY DAY, 7 DAYS");
                Console.WriteLine("0) Back");

                Console.WriteLine("Choose 0 - 2");
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("App is being downloading. Thankyou");
                }
                else if (num == 2)
                {
                    Console.Clear();
                    svcs42();
                }
                else if (num == 0)
                {
                    Console.Clear();
                    Main();
                }

                static void svcs42()
                {
                    Console.WriteLine("Get 1 GB VIDEO EVERY DAY for YouTube, NBA TV, iWant TFC, Cignal Play (7GB + 2GB, 7DAYS, P99)");
                    Console.WriteLine("1) Subscribe");
                    Console.WriteLine("0) Back");

                    Console.WriteLine("Choose 0 - 2");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Thankyou for subscribing to this promo");
                    }
                    else if (num == 0)
                    {
                        Console.Clear();
                        svcs4();
                    }
                }
            }

        }
    }
}

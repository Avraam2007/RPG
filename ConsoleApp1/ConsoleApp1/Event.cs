namespace ConsoleApp1.Event
{
    class Event
    {
        private int minus = 0;
        private Player.Player player = null;
        private Monster.Monster enemy = null;
        private Random rand = null;

        private Weapon.Weapon buyWeapon(int wallet, int damage, int price, string name)
        {

            if (checkWallet(price, wallet))
            {
                return new Weapon.Weapon(damage, name, price);
            }

            return null;
        }

        private Shield.Shield buyShield(int wallet, int protect, int price, string name)
        {

            if (checkWallet(price, wallet))
            {
                return new Shield.Shield(protect, name, price);
            }

            return null;
        }

        public Event(Player.Player player, Random rand)
        {
            this.rand = rand;
            this.player = player;
        }

        public string typeName(string text)
        {
            Console.WriteLine(text);
            text = Console.ReadLine();
            return text;
        }

        public int typeNameInt(string text)
        {
            int number = 0;
            Console.WriteLine(text);
            number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public bool checkWallet(int price, int wallet)
        {
            if (price > wallet)
            {
                Console.WriteLine("Sorry, we can't give credit! Come back when you been little mmm..... Richer!");
                return false;
            }
            else
            {
                this.player.setWallet(wallet - price);
                return true;
            }
        }


        public Weapon.Weapon shopWeapon(int choose3)
        {
            Weapon.Weapon gun = null;
            int wallet = player.getWallet();

            switch (choose3)
            {
                case 1:
                    return this.buyWeapon(wallet, 3, 30, "flint and stone");
                    break;
                case 2:
                    return this.buyWeapon(wallet, 5, 50, "sword");
                    break;
                case 3:
                    return this.buyWeapon(wallet, 7, 70, "bow");
                    break;
                case 4:
                    return this.buyWeapon(wallet, 9, 90, "fireball");
                    break;
                case 5:
                    return this.buyWeapon(wallet, 11, 110, "axe");
                    break;
                case 6:
                    return this.buyWeapon(wallet, 15, 150, "AK-47");
                    break;
                case 7:
                    return this.buyWeapon(wallet, 20, 200, "HIPL");
                    break;
                default:
                    Console.WriteLine("\aError: Wrong value! Try again!");
                    return null;
                    break;
            }

        }

        Shield.Shield shopShield(int choose3)
        {
            Shield.Shield target = null;
            int wallet = player.getWallet();

            switch (choose3)
            {
                case 1:
                    return this.buyShield(wallet, 3, 30, "package ATB");
                    break;
                case 2:
                    return this.buyShield(wallet, 5, 50, "wood");
                    break;
                case 3:
                    return this.buyShield(wallet, 7, 70, "stone");
                    break;
                case 4:
                    return this.buyShield(wallet, 9, 90, "steel");
                    break;
                case 5:
                    return this.buyShield(wallet, 11, 110, "IRIS");
                    break;
                case 6:
                    return this.buyShield(wallet, 15, 150, "graphene");
                    break;
                case 7:
                    return this.buyShield(wallet, 20, 200, "magic shield");
                    break;
                default:
                    Console.WriteLine("\aError: Wrong value! Try again!");
                    return null;
                    break;
            }
        }

        public void mainPage(int choose)
        {
            if (choose == 1)
            {
                this.player.setWeapon(shopWeapon(typeNameInt("Choose item: \n1-flint and stone-30$ \n2-sword-50$ \n3-bow-70$ \n4-fireball-90$ \n5-axe-110$ \n6-AK-47-150$ \n7-HIPL-200$")));
            }
            else if (choose == 2)
            {
                this.player.setShield(shopShield(typeNameInt("Choose item: \n1-package ATB-30$ \n2-wood-50$ \n3-stone-70$ \n4-steel-90$ \n5-IRIS-110$ \n6-graphene-150$ \n7-magic shield-200$(SALE -0,0000001%!!!)")));
            }
            else if (choose == 3)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("\aError: Wrong value! Try again!");
                return;
            };
        }

        public void meetMonster()
        {
            int skillChoose = typeNameInt("Do you want to use skill(1-level up,2-critical damage,3-healing,4-no)");
            if (skillChoose < 1 || skillChoose > 3)
            {
                Console.WriteLine("\aError: Wrong value! Try again!");
                return;
            }
            else if (skillChoose == 1)
            {
                player.useSkill(0, enemy);
            }
            else if (skillChoose == 2)
            {
                player.useSkill(1, enemy);
            }
            else if (skillChoose == 3)
            {
                player.useSkill(2, enemy);
            }
            else
            {
                Console.WriteLine("OK!");
            }
            Engine.Engine action = new Engine.Engine(rand);
            this.enemy = action.createMonster(this.player.getLevel());


            Console.WriteLine("Monster has spawned!");

            int roundCount = 1;
            while (player.getHealth() > 0 && enemy.getHealth() > 0)
            {
                Console.WriteLine($"Round {roundCount}");
                Console.WriteLine("==============================");

                player.setHealth(player.getHealth() - enemy.getDamage());
                Console.WriteLine($"Player: {player.getHealth()}");

                enemy.setHealth(enemy.getHealth() - player.getDamage());
                Console.WriteLine($"Enemy: {enemy.getHealth()} \n");

                roundCount++;
            }

            if (player.getHealth() > 0)
            {
                Console.WriteLine("You win!");
                player.setXp(player.getXp() + enemy.getXpPlus());
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }

        public void increaseCharacter(int randChoose)
        {
            if (randChoose == 1)
            {
                Console.WriteLine("Level up! Congrats!");
            }
            else if (randChoose == 2)
            {
                player.setHealth(player.getHealth() + 150);
                Console.WriteLine("Your health bar has increased! Congrats!");
            }
            else if (randChoose == 3)
            {
                player.setEnergy(player.getEnergy() + 150);
                Console.WriteLine("Your energy bar has increased! Congrats!");
            }
            else if (randChoose == 4)
            {
                player.setAgility(player.getAgility() + 150);
                Console.WriteLine("You become agiliter! Congrats!");
            }
            else if (randChoose == 5)
            {
                player.setEndurance(player.getEndurance() + 150);
                Console.WriteLine("You become endurancer! Congrats!");
            }
            else if (randChoose == 6)
            {
                player.setPower(player.getPower() + 150);
                Console.WriteLine("Power You have more power! Congrats!");
            }
            else if (randChoose == 7)
            {
                player.setXp(player.getXp() + 150);
                Console.WriteLine("XP You become smarter! Congrats!");
            }
            else if (randChoose == 8)
            {
                int coin = rand.Next(1, 11);
                Console.WriteLine($"You got {coin} coins! Congrats!");

                player.setWallet(player.getWallet() + coin);
            }
        }

        public void nothing()
        {
            Console.Clear();
            Console.WriteLine("Nothing...");
            Console.WriteLine("    //_____ __");
            Console.WriteLine("   @ )====// .\\\\___");
            Console.WriteLine("   \\#\\_\\__(_/_\\_/");
            Console.WriteLine("     / /       \\\\  ");
            Console.WriteLine("That's a cricket");
        }

        ~Event() { }
    };
}

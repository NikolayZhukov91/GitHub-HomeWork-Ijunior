using System;

namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandUsualAttack = "1";
            const string CommandFireball = "2";
            const string CommandTreatment = "3";
            
            string command;
            string commandMemory = "0";

            Random random = new Random();
            int lowerBoundHealth = 90;
            int upperBoundHealth = 121;
            int lowerBoundBossAttack = 15;
            int upperBoundBossAttack = 20;
            int healthBoss = random.Next(lowerBoundHealth, upperBoundHealth);
            int attackBoss = random.Next(lowerBoundBossAttack, upperBoundBossAttack);

            int lowerBoundPlayerAttack = 10;
            int upperBoundPlayerAttack = 16;
            int playerUsualAttack = random.Next(lowerBoundPlayerAttack, upperBoundPlayerAttack);

            int playerInspiration = random.Next(lowerBoundPlayerAttack,upperBoundPlayerAttack);
            int maxPlayerInspirarion = playerInspiration;
            int minPlayerInspiration = 0;

            int lowerBoundPlayerFireBall = 25;
            int upperBoundPlayerFireBall = 36;
            int playerFireBallAttack = random.Next(lowerBoundPlayerFireBall, upperBoundPlayerFireBall);
            int coastFireball = playerInspiration / 3;

            int lowerBoundPlayerBoom = 25;
            int upperBoundPlayerBoom = 36;
            int playerFireBallBoom = random.Next(lowerBoundPlayerBoom, upperBoundPlayerBoom);
            int damageMultiplier = 2;

            int lowerBoundPlayerTreatment = 15;
            int upperBoundPlayerTreatment = 30;
            int playerTreatment = random.Next(lowerBoundPlayerTreatment, upperBoundPlayerTreatment);
            int dividerInspirarion = 2;
            int treatmentCounter = 0;
            int borderTreatment = 3;
            

            int playerHealth = random.Next(lowerBoundHealth, upperBoundHealth);
            int maxPlayerHealth = playerHealth;
            int death = 0;

            Console.WriteLine($"Приветствую тебя путник! перед тобой уровня, у него {healthBoss} - здоровья, его аттака будет колебаться от {lowerBoundBossAttack} до {upperBoundBossAttack}");
            Console.WriteLine("У тебя есть умения:");
            Console.WriteLine($"Обычная атака - наносит {playerUsualAttack} урона. Команда атаки - {CommandUsualAttack}");
            Console.WriteLine($"Огненный шар, который тратит ману - наносит {playerFireBallAttack} урона. Стоимость огненого шара {coastFireball} - маны. У тебя маны - {playerInspiration}. Команда атаки - {CommandFireball}");
            Console.WriteLine($"Взрыв. Можно вызывать, только если был использован огненный шар. Для повторного применения надо повторно использовать огненный шар - наносит {playerFireBallBoom} урона. Команда атаки - {CommandFireball}");
            Console.WriteLine($"Лечение. Восстанавливает здоровье и ману, но не больше их максимального значения. Можно использовать {borderTreatment} - раз. Команда лечения - {CommandTreatment}");
            Console.WriteLine($"У тебя {playerHealth} - здоровья.");

            while (playerHealth > death && healthBoss > death)
            {
                Console.WriteLine("Введите вашу команду:");
                command =  Console.ReadLine();

                switch (command)
                {
                    case CommandUsualAttack:
                        healthBoss -= playerUsualAttack;
                        Console.WriteLine($"Ты нанес {playerUsualAttack} урона Боссу, У Босса осталось {healthBoss} здоровья.");
                        commandMemory = command;
                        playerHealth -= attackBoss;
                        Console.WriteLine($"Босс нанес {attackBoss} урона. У тебя осталось {playerHealth} здоровья.");
                        break;
                    case CommandFireball:
                        if (commandMemory != command)
                        {
                            if ((playerInspiration - coastFireball) > minPlayerInspiration)
                            {
                                healthBoss -= playerFireBallAttack;
                                playerInspiration -= coastFireball;
                                Console.WriteLine($"Ты нанес огненым шаром {playerFireBallAttack}  урона Боссу, У Босса осталось {healthBoss} здоровья. У тебя осталось {playerInspiration} маны");
                                playerHealth -= attackBoss;
                                Console.WriteLine($"Босс нанес {attackBoss} урона. У тебя осталось {playerHealth} здоровья.");
                            }
                            else
                            {
                                Console.WriteLine($"У тебя недостаточно маны.");
                                playerHealth -= attackBoss;
                                Console.WriteLine($"Босс нанес {attackBoss} урона. У тебя осталось {playerHealth} здоровья.");
                            }
                            
                        }
                        else
                        {
                            healthBoss -= playerFireBallAttack*damageMultiplier;
                            Console.WriteLine($"Ты нанес взрывом {playerFireBallAttack * damageMultiplier}  урона Боссу, У Босса осталось {healthBoss} здоровья.");
                            playerHealth -= attackBoss;
                            Console.WriteLine($"Босс нанес {attackBoss} урона. У тебя осталось {playerHealth} здоровья.");
                        }
                        commandMemory = command;
                        break;
                    case CommandTreatment:
                        if (treatmentCounter < borderTreatment)
                        {
                            if (maxPlayerHealth > (playerHealth + playerTreatment))
                            {
                                playerHealth += playerTreatment;
                            }
                            else
                            {
                                playerHealth = maxPlayerHealth;
                            }
                            
                            if (maxPlayerInspirarion > (playerInspiration + (playerTreatment / dividerInspirarion)))
                            {
                                playerInspiration += (playerTreatment / dividerInspirarion);
                            }
                            else
                            {
                                playerInspiration = maxPlayerInspirarion;
                            }

                            treatmentCounter++;
                            Console.WriteLine($"Твое здоровье востановленно до {playerHealth}, а мана до  {playerInspiration}");
                            playerHealth -= attackBoss;
                            Console.WriteLine($"Босс нанес {attackBoss} урона. У тебя осталось {playerHealth} здоровья.");
                        }
                        else
                        {
                            Console.WriteLine("Ты использовал все заклинания лечения.");
                            playerHealth -= attackBoss;
                            Console.WriteLine($"Босс нанес {attackBoss} урона. У тебя осталось {playerHealth} здоровья.");
                        }

                        commandMemory = command;
                        break;
                    default:
                        Console.WriteLine("Ты ввел неверную команду, твой ход сгорает.");
                        playerHealth -= attackBoss;
                        Console.WriteLine($"Босс нанес {attackBoss} урона. У тебя осталось {playerHealth} здоровья.");
                        break;
                }
            }

            if (playerHealth < death && healthBoss < death)
            {
                Console.WriteLine("Вы славно сражались, но оба погибли.");
            }
            else if (playerHealth < death)
            {
                Console.WriteLine("Твой герой погиб, press 'F'");
            }
            else
            {
                Console.WriteLine("Ты победил Босса!");
            }

            Console.ReadKey();
        }
    }
}

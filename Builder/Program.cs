using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new CharacterDirector();
            
            // Create a hero using HeroBuilder
            var heroBuilder = new HeroBuilder();
            director.CreateCharacter(heroBuilder);
            var hero = heroBuilder.Build();
            Console.WriteLine("Created Hero:");
            Console.WriteLine(hero);
            Console.WriteLine();

            // Create an enemy using EnemyBuilder
            var enemyBuilder = new EnemyBuilder();
            director.CreateCharacter(enemyBuilder);
            var enemy = enemyBuilder.Build();
            Console.WriteLine("Created Enemy:");
            Console.WriteLine(enemy);
            Console.WriteLine();

            // Create a custom hero using HeroBuilder directly
            var customHeroBuilder = new HeroBuilder();
            director.CreateCharacter(customHeroBuilder);
            var customHero = customHeroBuilder
                .SaveVillage("Dragon's Rest")
                .DefeatEvil("Evil Sorcerer")
                .HelpInnocent("Freed the captured villagers")
                .Build();
            Console.WriteLine("Created Custom Hero:");
            Console.WriteLine(customHero);
            Console.WriteLine();

            // Create a custom enemy using EnemyBuilder directly
            var customEnemyBuilder = new EnemyBuilder();
            director.CreateCharacter(customEnemyBuilder);
            var customEnemy = customEnemyBuilder
                .DestroyVillage("Elven Haven")
                .StealArtifact("Staff of Darkness")
                .CorruptInnocent("Corrupted the royal guard")
                .Build();
            Console.WriteLine("Created Custom Enemy:");
            Console.WriteLine(customEnemy);
        }
    }
}

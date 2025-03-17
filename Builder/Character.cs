using System.Collections.Generic;

namespace Builder
{
    public class Character
    {
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public List<string> Clothing { get; set; } = new List<string>();
        public List<string> Inventory { get; set; } = new List<string>();
        public bool IsHero { get; set; }
        public List<string> GoodDeeds { get; set; } = new List<string>();
        public List<string> EvilDeeds { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Character Configuration:\n" +
                   $"Type: {(IsHero ? "Hero" : "Enemy")}\n" +
                   $"Height: {Height}cm\n" +
                   $"Build: {Build}\n" +
                   $"Hair Color: {HairColor}\n" +
                   $"Eye Color: {EyeColor}\n" +
                   $"Clothing: {string.Join(", ", Clothing)}\n" +
                   $"Inventory: {string.Join(", ", Inventory)}\n" +
                   $"Good Deeds: {string.Join(", ", GoodDeeds)}\n" +
                   $"Evil Deeds: {string.Join(", ", EvilDeeds)}";
        }
    }
} 
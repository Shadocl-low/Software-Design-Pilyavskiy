using System.Collections.Generic;

namespace Builder
{
    public class CharacterDirector
    {
        public void CreateCharacter(ICharacterBuilder builder)
        {
            builder
                .Reset()
                .SetType()
                .SetHeight()
                .SetBuild()
                .SetHairColor()
                .SetEyeColor()
                .AddClothing()
                .AddToInventory();
        }
    }
} 
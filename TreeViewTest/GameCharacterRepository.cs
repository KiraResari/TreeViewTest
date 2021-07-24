using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewTest
{
    class GameCharacterRepository
    {
        private static readonly GameCharacter sylvia
            = new GameCharacter("Sylvia", "Nefilim", "Axe");
        private static readonly GameCharacter bokay
            = new GameCharacter("Bokay", "Nefilim", "Bow");
        private static readonly List<GameCharacter> claudiasChildren
            = new List<GameCharacter>() { sylvia, bokay };
        private static readonly GameCharacter claudia
            = new GameCharacter("Claudia", "Nefilim", "Axe", claudiasChildren);
        private static readonly GameCharacter jioan
            = new GameCharacter("Jioan", "Celinne", "Fists");
        private static readonly GameCharacter idra
            = new GameCharacter("Idra", "Dragon", "Claws");

        public static readonly List<GameCharacter> sampleGameCharacters = new List<GameCharacter>()
        {
            claudia,
            jioan,
            idra
        };

        public static string GetSpeciesByCharacterName(string characterName)
        {
            GameCharacter gameCharacter = GetCharacterByName(characterName);
            return gameCharacter.Species;
        }

        internal static string GetWeaponByCharacterName(string characterName)
        {
            GameCharacter gameCharacter = GetCharacterByName(characterName);
            return gameCharacter.Weapon;
        }

        private static GameCharacter GetCharacterByName(string characterName)
        {
            List<GameCharacter> flattenedGameCharacterList = GetFlattenedGameCharacterList();
            foreach(GameCharacter gameCharacter in flattenedGameCharacterList)
            {
                if(gameCharacter.Name == characterName)
                {
                    return gameCharacter;
                }
            }
            throw new Exception("Could not find character with name: " + characterName);
        }

        private static List<GameCharacter> GetFlattenedGameCharacterList()
        {
            List<GameCharacter> flattenedGameCharacterList = new List<GameCharacter>();
            foreach(GameCharacter gameCharacter in sampleGameCharacters)
            {
                flattenedGameCharacterList.Add(gameCharacter);
                flattenedGameCharacterList.AddRange(gameCharacter.GetFlattenedChildrenList());
            }
            return flattenedGameCharacterList;
        }
    }
}

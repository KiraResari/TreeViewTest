using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewTest
{
    class SampleGameCharacters
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
    }
}

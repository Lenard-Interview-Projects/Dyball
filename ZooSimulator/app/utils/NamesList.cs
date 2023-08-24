/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   A short list of names to be used anywhere within the software
|   currently used to name the instantiated animals
|
|--------------------------------------*/
using System.Collections.Generic;

namespace ZooSimulator.Utils
{
    public static class NamesList
    {
        private static List<string> names = new List<string>(){
            { "James"       }, { "Arthur"   },
            { "Casey"       }, { "Tom"      },
            { "Terri"       }, { "Felecia"  },
            { "Minnie"      }, { "Jenny"    },
            { "Zachary"     }, { "Dustin"   },
            { "Christian"   }, { "Courtney" },
            { "Wayne"       }, { "Aubrey"   },
            { "Lenard"      },
        };

        public static List<string> Names { get => names; }
    }
}

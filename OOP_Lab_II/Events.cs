using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GAME_TEST
{
    class Events
    {
        public List<EventHandler> events { get; }
        private Events()
        {
            events = new List<EventHandler>();
            
        }
        private static Events Instance;
        public static Events instance
        {
            get
            {
                if (Instance == null)
                    Instance = new Events();
                return Instance;
            }
        }
    }
}

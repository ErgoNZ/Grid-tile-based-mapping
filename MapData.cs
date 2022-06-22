﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Grid_based_map
{
    class MapData
    {
        //0= free movement 1= no movement 2= Cannot move left 3= Cannot move right 4= up 5= down
        //(x,0,0) is a visual indicator, (0,x,0) Repersents the player pos, (0,0,x) is the type of movemnt restriction the tile has.
       public int[,,] Tiles = new int[10, 10, 3]
            {
                { {1,0,0},{1,0,0},{2,0,1},{2,0,1},{2,0,1}, {2,0,1},{2,0,0},{2,0,1},{2,0,1},{2,0,1}  },
                { {1,0,0},{1,0,0},{1,0,0},{2,0,1},{2,0,1}, {2,0,0},{2,0,0},{1,0,0},{2,0,1},{2,0,1}  },
                { {1,0,0},{2,0,1},{1,0,0},{2,0,1},{2,0,1}, {1,0,0},{2,0,0},{1,0,0},{2,0,1},{2,0,1}  },
                { {1,0,0},{1,0,0},{1,0,0},{1,0,0},{2,0,1}, {1,0,0},{1,0,0},{1,0,0},{1,0,0},{2,0,1}  },
                { {1,0,0},{1,0,0},{1,0,0},{1,0,0},{1,0,0}, {1,0,0},{1,0,0},{1,0,0},{1,0,0},{1,0,0}  },
                { {2,0,1},{2,0,1},{2,0,1},{2,0,1},{1,0,0}, {2,0,1},{2,0,1},{2,0,1},{2,0,1},{2,0,1}  },
                { {2,0,1},{2,0,1},{1,0,0},{2,0,0},{1,0,0}, {2,0,1},{2,0,1},{1,0,0},{2,0,1},{2,0,1}  },
                { {1,0,0},{2,0,1},{1,0,0},{2,0,0},{1,0,0}, {1,0,0},{2,0,1},{1,0,0},{2,0,1},{2,0,1}  },
                { {1,0,0},{1,0,0},{1,0,0},{1,0,0},{1,0,0}, {1,0,0},{1,0,0},{1,0,0},{1,0,0},{2,0,1}  },
                { {1,0,0},{1,0,0},{1,0,0},{1,0,0},{1,0,0}, {1,0,0},{1,0,0},{1,0,0},{1,0,0},{1,0,0}  }
            };
       public int[,,] PlayerTiles = new int[10, 10, 2];
       public int[,,] ViewRange = new int[5, 5, 2];

    }
}

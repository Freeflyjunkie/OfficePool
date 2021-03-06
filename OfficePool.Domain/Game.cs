﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficePool.Domain
{
        public class Game
        {
            public int GameId { get; set; }
            public int FavoredTeamId { get; set; }
            public decimal Spread { get; set; }
            public int UnderdogTeamId { get; set; }
            public DateTime GameDate { get; set; }
            public bool IsHomeTeamFavorite { get; set; }
            public int TotalPoints { get; set; }
            public bool IsTieBreaker { get; set; }
        }
}

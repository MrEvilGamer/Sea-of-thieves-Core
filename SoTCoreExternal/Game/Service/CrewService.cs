﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoT.Game.Service
{
    public class CrewService : UE4Actor
    {
        public TArray<Crew> Crews
        {
            get
            {
                return new TArray<Crew>(Address + SotCore.Instance.Offsets["ACrewService.Crews"]);
            }
        }
        public CrewService(UE4Actor actor) : base(actor.Address)
        {
        }

        public CrewService(ulong address) : base(address)
        {
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGame.ConsoleGame
{
    internal static class MapExtensions
    {
        internal static IDrawable CreatureAtExtension(this List<Creature> creatures, Cell cell)
        {
            //IDrawable result = cell;
            //foreach (var creature in creatures)
            //{
            //    if (creature.Cell == cell)
            //    {
            //        result = creature;
            //        break;
            //    }
            //}
            //return result;

            return creatures.FirstOrDefault(c => c.Cell == cell)  ?? cell as IDrawable;
        } 
        
        [return: MaybeNull]
        internal static IDrawable CreatureAtExtension2(this List<Creature> creatures, Cell cell)
        {
            //IDrawable? result = null;
            //foreach (var creature in creatures)
            //{
            //    if (creature.Cell == cell)
            //    {
            //        result = creature;
            //        break;
            //    }
            //}
            //return result;

            return creatures.FirstOrDefault(c => c.Cell == cell);
        }
    }
}

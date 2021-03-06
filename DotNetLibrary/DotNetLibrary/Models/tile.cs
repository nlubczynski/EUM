﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLibrary.Models
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Tile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Next_Function { get; set; }
        public string Land_Function { get; set; }
        
        private Utility.VectorTile _neighbours;
        public Utility.VectorTile Neighbours
        {
            get { return _neighbours; }
        }

        public Tile()
        {
            _neighbours = new Utility.VectorTile();
        }

        public bool addNeighbour(Tile tile)
        {
           return _neighbours.AddObject(tile);
        }
    }
}

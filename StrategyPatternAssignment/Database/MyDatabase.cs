﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment.Database
{
    class MyDatabase
    {
        public List<Shirt> Shirts { get; set; }
        public MyDatabase()
        {
            Shirt s1 = new Shirt(Color.GREEN, Size.XS, Fabric.CASHMERE);
            Shirt s2 = new Shirt(Color.BLUE, Size.S, Fabric.COTTON);
            Shirt s3 = new Shirt(Color.INDIGO, Size.M, Fabric.LINEN);
            Shirt s4 = new Shirt(Color.ORANGE, Size.L, Fabric.POLYESTER);
            Shirt s5 = new Shirt(Color.RED, Size.XL, Fabric.RAYON);
            Shirt s6 = new Shirt(Color.VIOLET, Size.XXL, Fabric.SILK);
            Shirt s7 = new Shirt(Color.YELLOW, Size.XXXL, Fabric.WOOL);
            Shirt s8 = new Shirt (Color.GREEN, Size.XS, Fabric.CASHMERE);
            Shirt s9 = new Shirt (Color.BLUE, Size.S, Fabric.COTTON);
            Shirt s10 = new Shirt(Color.INDIGO, Size.M, Fabric.LINEN);
            Shirt s11 = new Shirt(Color.ORANGE, Size.L, Fabric.POLYESTER);
            Shirt s12 = new Shirt(Color.RED, Size.XL, Fabric.RAYON);
            Shirt s13 = new Shirt(Color.VIOLET, Size.XXL, Fabric.SILK);
            Shirt s14 = new Shirt(Color.YELLOW, Size.XXXL, Fabric.WOOL);
            Shirt s15 = new Shirt(Color.GREEN, Size.XS, Fabric.CASHMERE);
            Shirt s16 = new Shirt(Color.BLUE, Size.S, Fabric.COTTON);
            Shirt s17 = new Shirt(Color.INDIGO, Size.M, Fabric.LINEN);
            Shirt s18 = new Shirt(Color.ORANGE, Size.L, Fabric.POLYESTER);
            Shirt s19 = new Shirt(Color.RED, Size.XL, Fabric.RAYON);
            Shirt s20 = new Shirt(Color.VIOLET, Size.XXL, Fabric.SILK);
            Shirt s21 = new Shirt(Color.YELLOW, Size.XXXL, Fabric.WOOL);
            Shirt s22 = new Shirt(Color.GREEN, Size.XS, Fabric.CASHMERE);
            Shirt s23 = new Shirt(Color.BLUE, Size.S, Fabric.COTTON);
            Shirt s24 = new Shirt(Color.INDIGO, Size.M, Fabric.LINEN);
            Shirt s25 = new Shirt(Color.ORANGE, Size.L, Fabric.POLYESTER);
            Shirt s26 = new Shirt(Color.RED, Size.XL, Fabric.RAYON);
            Shirt s27 = new Shirt(Color.VIOLET, Size.XXL, Fabric.SILK);
            Shirt s28 = new Shirt(Color.YELLOW, Size.XXXL, Fabric.WOOL);
            Shirt s29 = new Shirt(Color.GREEN, Size.XS, Fabric.CASHMERE);
            Shirt s30 = new Shirt(Color.BLUE, Size.S, Fabric.COTTON);
            Shirt s31 = new Shirt(Color.INDIGO, Size.M, Fabric.LINEN);
            Shirt s32 = new Shirt(Color.ORANGE, Size.L, Fabric.POLYESTER);
            Shirt s33 = new Shirt(Color.RED, Size.XL, Fabric.RAYON);
            Shirt s34 = new Shirt(Color.VIOLET, Size.XXL, Fabric.SILK);
            Shirt s35 = new Shirt(Color.YELLOW, Size.XXXL, Fabric.WOOL);
            Shirt s36 = new Shirt(Color.GREEN, Size.XS, Fabric.CASHMERE);
            Shirt s37 = new Shirt(Color.BLUE, Size.S, Fabric.COTTON);
            Shirt s38 = new Shirt(Color.INDIGO, Size.M, Fabric.LINEN);
            Shirt s39 = new Shirt(Color.ORANGE, Size.L, Fabric.POLYESTER);
            Shirt s40 = new Shirt(Color.RED, Size.XL, Fabric.RAYON);


            Shirts = new List<Shirt>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36, s37, s38, s39, s40 };

        }
    }
}

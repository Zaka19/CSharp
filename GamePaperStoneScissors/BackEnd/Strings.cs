using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Strings
    {
        private const String STONE = "STONE";
        public static String Stone { get { return STONE; } }

        private const String SCISSORS = "SCISSORS";
        public static String Scissors { get { return SCISSORS; } }

        private const String PAPER = "PAPER";
        public static String Paper { get { return PAPER; } }

        private const String LIZARD = "LIZARD";
        public static String Lizard { get { return LIZARD; } }

        private const String SPOKE = "SPOKE";
        public static String Spoke { get { return SPOKE; } }

        private const String ASKNAMEPLAYER = "Enter your name : ";
        public static String AskNamePlayer { get { return ASKNAMEPLAYER; } }

        private const String SELECTOPTION = "Select one option(STONE, PAPER, SCISSORS, LIZARD, SPOKE) ";
        public static String SelectOption { get { return SELECTOPTION; } }

        private const String ERROROPTION = "Error...Introduce option: ";
        public static String ErrorOption { get { return ERROROPTION; } }

        private const String WIN = " WIN";
        public static String Win { get{ return WIN; } }

        private const String DRAW = "DRAW";
        public static String Draw { get{ return DRAW; } }


    }
}
